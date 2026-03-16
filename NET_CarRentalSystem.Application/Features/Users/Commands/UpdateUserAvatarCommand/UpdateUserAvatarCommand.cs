using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Storage;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Users.Commands.UpdateUserAvatarCommand;

public class UpdateUserAvatarCommand : ICommand<(bool Success, string Message, string? AvatarUrl)>
{
    public required FileModel AvatarFile { get; set; }
}

public class UpdateUserAvatarCommandHandler(
    IUnitOfWork unitOfWork,
    IImageResizeService imageResizeService,
    ICloudinaryService cloudinaryService,
    ICurrentUserService currentUserService)
    : IRequestHandler<UpdateUserAvatarCommand, (bool Success, string Message, string? AvatarUrl)>
{
    private const int MaxWidth = 500;
    private const int MaxHeight = 500;
    private const int Quality = 85;

    public async Task<(bool Success, string Message, string? AvatarUrl)> Handle(UpdateUserAvatarCommand request, CancellationToken cancellationToken)
    {
        var customerRepo = unitOfWork.GetWriteRepository<Customer>();

        var userId = currentUserService.GetUserId();
        if (!userId.HasValue)
        {
            return (false, UserMessage.NotFound, null);
        }

        var customer = await customerRepo.GetFirstOrDefaultAsync(
            c => c.UserId == userId.Value,
            cancellationToken);

        if (customer == null)
        {
            return (false, UserMessage.NotFound, null);
        }

        var resizedImage = await imageResizeService.ResizeAndCompressAsync(
            request.AvatarFile,
            MaxWidth,
            MaxHeight,
            Quality);
        
        var uploadResult = await cloudinaryService.UploadImageAsync(
            resizedImage,
            folder: $"avatars/{userId.Value}");
        
        customer.AvatarUrl = uploadResult.SecureUrl;

        customerRepo.Update(customer);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return (true, UserMessage.Avatar.UpdateSuccess, uploadResult.SecureUrl);
    }
}

