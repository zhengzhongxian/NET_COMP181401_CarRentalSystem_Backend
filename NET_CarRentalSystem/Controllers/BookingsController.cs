using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.API.Attributes;
using NET_CarRentalSystem.API.Extensions;
using NET_CarRentalSystem.API.Models.Request.Bookings;
using NET_CarRentalSystem.API.Models.Response.Bookings;
using NET_CarRentalSystem.Application.Features.Bookings.Commands.CancelBookingCommand;
using NET_CarRentalSystem.Application.Features.Bookings.Commands.CompleteBookingCommand;
using NET_CarRentalSystem.Application.Features.Bookings.Commands.CreateBookingCommand;
using NET_CarRentalSystem.Application.Features.Bookings.Commands.CreateFinalPaymentCommand;
using NET_CarRentalSystem.Application.Features.Bookings.Commands.ExportBookingContractCommand;
using NET_CarRentalSystem.Application.Features.Bookings.Commands.GenerateBookingContractCommand;
using NET_CarRentalSystem.Application.Features.Bookings.Commands.GenerateQrReturnVehicleCommand;
using NET_CarRentalSystem.Application.Features.Bookings.Commands.ReturnVehicleCommand;
using NET_CarRentalSystem.Application.Features.Bookings.Commands.SwapVehicleModelCommand;
using NET_CarRentalSystem.Application.Features.Bookings.Commands.UpdateAfterReturnCommand;
using NET_CarRentalSystem.Application.Features.Bookings.Commands.UpdateFinalPaymentCommand;
using NET_CarRentalSystem.Application.Features.Bookings.Queries.GetBookingDetailQuery;
using NET_CarRentalSystem.Application.Features.Bookings.Queries.GetBookingByTransactionCodeQuery;
using NET_CarRentalSystem.Application.Features.Bookings.Queries.GetBookingsPagedQuery;
using NET_CarRentalSystem.Application.Features.Bookings.Queries.GetCustomerBookingDetailQuery;
using NET_CarRentalSystem.Application.Features.Bookings.Queries.GetCustomerBookingsPagedQuery;
using NET_CarRentalSystem.Application.Features.Bookings.Queries.RegenerateFinalPaymentQuery;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Pagination;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookingsController(ISender sender, IMapper mapper) : ControllerBase
{
    #region Admin APIs
    
    [HttpGet]
    [ValidateUserExists(Policy = PermissionConstants.Bookings.View)]
    public async Task<IActionResult> GetBookings([FromQuery] GetBookingsPagedRequest request, CancellationToken ct)
    {
        try
        {
            var queryParams = mapper.Map<GetBookingsPagedQueryParams>(request);
            var query = new GetBookingsPagedQuery
            {
                RequestParams = queryParams
            };

            var result = await sender.Send(query, ct);

            var pagedResponse = mapper.Map<PagedResponse<GetBookingResponse>>(result);
            var apiResponse = ApiResponse.SuccessResult(pagedResponse, BookingMessage.Get.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                BookingMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpGet("{bookingId:guid}")]
    [ValidateUserExists(Policy = PermissionConstants.Bookings.ViewDetail)]
    public async Task<IActionResult> GetBookingDetail([FromRoute] Guid bookingId, CancellationToken ct)
    {
        try
        {
            var query = new GetBookingDetailQuery { BookingId = bookingId };
            var result = await sender.Send(query, ct);

            if (result == null)
            {
                var notFoundResponse = ApiResponse.ErrorResult(
                    BookingMessage.Get.NotFound,
                    StatusCodes.Status404NotFound);
                return StatusCode(StatusCodes.Status404NotFound, notFoundResponse);
            }

            var response = mapper.Map<GetBookingDetailResponse>(result);
            var apiResponse = ApiResponse.SuccessResult(response, BookingMessage.Get.DetailSuccess);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                BookingMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpGet("by-transaction/{transactionCode:long}")]
    public async Task<IActionResult> GetBookingByTransactionCode([FromRoute] long transactionCode, CancellationToken ct)
    {
        try
        {
            var query = new GetBookingByTransactionCodeQuery { TransactionCode = transactionCode };
            var result = await sender.Send(query, ct);

            if (result == null)
            {
                var notFoundResponse = ApiResponse.ErrorResult(
                    BookingMessage.Get.NotFound,
                    StatusCodes.Status404NotFound);
                return StatusCode(notFoundResponse.StatusCode, notFoundResponse);
            }

            var response = mapper.Map<GetBookingByTransactionCodeResponse>(result);
            var apiResponse = ApiResponse.SuccessResult(response, BookingMessage.Get.DetailSuccess);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                BookingMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }
    
    #endregion
    
    #region Customer APIs
    
    [HttpGet("my-bookings")]
    [ValidateUserExists]
    public async Task<IActionResult> GetMyBookings([FromQuery] GetCustomerBookingsPagedRequest request, CancellationToken ct)
    {
        try
        {
            var queryParams = mapper.Map<GetCustomerBookingsPagedQueryParams>(request);
            var query = new GetCustomerBookingsPagedQuery
            {
                RequestParams = queryParams
            };

            var result = await sender.Send(query, ct);

            var pagedResponse = mapper.Map<PagedResponse<GetBookingResponse>>(result);
            var apiResponse = ApiResponse.SuccessResult(pagedResponse, BookingMessage.Get.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                BookingMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpGet("my-bookings/{bookingId:guid}")]
    [ValidateUserExists]
    public async Task<IActionResult> GetMyBookingDetail([FromRoute] Guid bookingId, CancellationToken ct)
    {
        try
        {
            var query = new GetCustomerBookingDetailQuery { BookingId = bookingId };
            var result = await sender.Send(query, ct);

            if (result == null)
            {
                var notFoundResponse = ApiResponse.ErrorResult(
                    BookingMessage.Get.NotFound,
                    StatusCodes.Status404NotFound);
                return StatusCode(StatusCodes.Status404NotFound, notFoundResponse);
            }

            var response = mapper.Map<GetBookingDetailResponse>(result);
            var apiResponse = ApiResponse.SuccessResult(response, BookingMessage.Get.DetailSuccess);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                BookingMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }
    
    #endregion
    
    #region Booking Operations

    [HttpPost]
    [ValidateUserExists(Policy = PermissionConstants.Ekyc.FullyVerified)]
    public async Task<IActionResult> CreateBooking([FromBody] CreateBookingRequest request, CancellationToken ct)
    {
        var command = mapper.Map<CreateBookingCommand>(request);
        var (success, message, transactionDto) = await sender.Send(command, ct);

        if (!success || transactionDto is null)
        {
            var errorResponse = ApiResponse.ErrorResult(message);
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }

        var response = mapper.Map<CreateBookingResponse>(transactionDto);
        var apiResponse = ApiResponse.SuccessResult(response, BookingMessage.Create.Success);

        return StatusCode(apiResponse.StatusCode, apiResponse);
    }
    
    [HttpPost("{bookingId:guid}/final-payment")]
    [ValidateUserExists(Policy = PermissionConstants.Bookings.CreateFinalPayment)]
    public async Task<IActionResult> CreateFinalPayment(
        [FromRoute] Guid bookingId, 
        [FromForm] CreateFinalPaymentRequest request, 
        CancellationToken ct)
    {
        List<FileModel>? images = null;
        if (request.Images is { Count: > 0 })
        {
            images = [];
            foreach (var file in request.Images)
            {
                var memoryStream = new MemoryStream();
                await file.CopyToAsync(memoryStream, ct);
                memoryStream.Position = 0;
                
                images.Add(new FileModel
                {
                    FileName = file.FileName,
                    Content = memoryStream,
                    ContentType = file.ContentType
                });
            }
        }
        
        var command = new CreateFinalPaymentCommand
        {
            BookingId = bookingId,
            MileageStart = request.MileageStart,
            FuelLevelStart = request.FuelLevelStart,
            FuelPrice = request.FuelPrice,
            ConditionNotes = request.ConditionNotes,
            Images = images
        };
        
        var (success, message, transactionDto) = await sender.Send(command, ct);

        if (!success || transactionDto is null)
        {
            var errorResponse = ApiResponse.ErrorResult(message);
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }

        var response = mapper.Map<CreateBookingResponse>(transactionDto);
        var apiResponse = ApiResponse.SuccessResult(
            response,
            BookingMessage.FinalPayment.Success
        );

        return StatusCode(apiResponse.StatusCode, apiResponse);
    }
    
    [HttpGet("{bookingId:guid}/final-payment/regenerate")]
    [ValidateUserExists(Policy = PermissionConstants.Bookings.CreateFinalPayment)]
    public async Task<IActionResult> RegenerateFinalPaymentLink(
        [FromRoute] Guid bookingId,
        CancellationToken ct)
    {
        var query = new RegenerateFinalPaymentQuery { BookingId = bookingId };
        var (success, message, transactionDto) = await sender.Send(query, ct);

        if (!success || transactionDto is null)
        {
            var errorResponse = ApiResponse.ErrorResult(message);
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }

        var response = mapper.Map<CreateBookingResponse>(transactionDto);
        var apiResponse = ApiResponse.SuccessResult(
            response,
            BookingMessage.FinalPayment.RegenerateSuccess
        );

        return StatusCode(apiResponse.StatusCode, apiResponse);
    }
    
    [HttpPut("{bookingId:guid}/swap-vehicle-model")]
    [ValidateUserExists(Policy = PermissionConstants.Bookings.SwapVehicleModel)]
    public async Task<IActionResult> SwapVehicleModel(
        [FromRoute] Guid bookingId,
        [FromBody] SwapVehicleModelRequest request,
        CancellationToken ct)
    {
        try
        {
            var command = new SwapVehicleModelCommand
            {
                BookingId = bookingId,
                NewVehicleModelId = request.NewVehicleModelId,
                OldVehicleModelStatus = request.OldVehicleModelStatus,
                Reason = request.Reason
            };

            var (dto, message) = await sender.Send(command, ct);

            if (dto == null)
            {
                var errorResponse = ApiResponse.ErrorResult(message);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var response = mapper.Map<SwapVehicleModelResponse>(dto);
            var apiResponse = ApiResponse.SuccessResult(
                response,
                BookingMessage.SwapVehicleModel.Success
            );

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                BookingMessage.SwapVehicleModel.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]
            );
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpPost("{bookingId:guid}/cancel")]
    [ValidateUserExists(Policy = PermissionConstants.Bookings.Cancel, Roles = RoleConstants.Customer)]
    public async Task<IActionResult> CancelBooking(
        [FromRoute] Guid bookingId,
        [FromBody] CancelBookingRequest request,
        CancellationToken ct)
    {
        try
        {
            var command = mapper.Map<CancelBookingCommand>(request);
            command.BookingId = bookingId;

            var (success, message) = await sender.Send(command, ct);

            if (!success)
            {
                var errorResponse = ApiResponse.ErrorResult(message);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(
                success,
                message
            );

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                BookingMessage.Cancel.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]
            );
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpPost("{bookingId:guid}/generate-contract")]
    [ValidateUserExists(Policy = PermissionConstants.Bookings.GenerateContract)]
    public async Task<IActionResult> GenerateContract(
        [FromRoute] Guid bookingId,
        CancellationToken ct)
    {
        try
        {
            var command = new GenerateBookingContractCommand { BookingId = bookingId };
            var (success, message, fileName) = await sender.Send(command, ct);

            if (!success)
            {
                var errorResponse = ApiResponse.ErrorResult(message);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(
                new { fileName },
                message
            );

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                BookingMessage.GenerateContract.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]
            );
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpGet("export-contract")]
    [ValidateUserExists(Policy = PermissionConstants.Bookings.ExportContract)]
    public async Task<IActionResult> ExportContract(
        [FromQuery] string fileName,
        CancellationToken ct)
    {
        try
        {
            var command = new ExportBookingContractCommand { FileName = fileName };
            var (success, message, fileStream, contentType) = await sender.Send(command, ct);

            if (success && fileStream != null && contentType != null) return File(fileStream, contentType, fileName);
            var errorResponse = ApiResponse.ErrorResult(
                message,
                StatusCodes.Status404NotFound);
            return StatusCode(errorResponse.StatusCode, errorResponse);

        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                BookingMessage.ExportContract.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]
            );
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }
    
    [HttpPut("{bookingId:guid}/final-payment")]
    [ValidateUserExists(Policy = PermissionConstants.Bookings.UpdateFinalPayment)]
    public async Task<IActionResult> UpdateFinalPayment(
        [FromRoute] Guid bookingId,
        [FromForm] UpdateFinalPaymentRequest request,
        CancellationToken ct)
    {
        List<FileModel>? images = null;

        if (request.Images is { Count: > 0 })
        {
            images = [];
            foreach (var file in request.Images)
            {
                var memoryStream = new MemoryStream();
                await file.CopyToAsync(memoryStream, ct);
                memoryStream.Position = 0;

                images.Add(new FileModel
                {
                    FileName = file.FileName,
                    Content = memoryStream,
                    ContentType = file.ContentType
                });
            }
        }

        var command = new UpdateFinalPaymentCommand
        {
            BookingId = bookingId,
            MileageStart = request.MileageStart,
            FuelPrice = request.FuelPrice,
            ConditionNotes = request.ConditionNotes,
            Images = images,
            FuelLevelStart = request.FuelLevelStart
        };

        var (success, message) = await sender.Send(command, ct);

        if (!success)
        {
            var errorResponse = ApiResponse.ErrorResult(message);
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }

        var apiResponse = ApiResponse.SuccessResult(
            success,
            BookingMessage.UpdateFinalPayment.Success
        );

        return StatusCode(apiResponse.StatusCode, apiResponse);
    }
    
    [HttpPost("qr/generate")]
    public async Task<IActionResult> GenerateReturnQr([FromBody] GenerateQrReturnVehicleRequest request, CancellationToken ct)
    {
        try
        {
            var command = new GenerateQrReturnVehicleCommand { LocationId = request.LocationId };
            var (url, message) = await sender.Send(command, ct);

            if (string.IsNullOrEmpty(url))
            {
                var errorResponse = ApiResponse.ErrorResult(message);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(new { url }, LocationMessage.Get.Success);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(LocationMessage.Get.Error, StatusCodes.Status500InternalServerError, [ex.Message]);
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpPost("return")]
    [ValidateUserExists]
    public async Task<IActionResult> ReturnByQr(string qrCode, CancellationToken ct)
    {
        var command = new ReturnVehicleCommand { QrToken = qrCode };
        var (success, message) = await sender.Send(command, ct);
        if (!success)
        {
            var errorResponse = ApiResponse.ErrorResult(message);
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }

        var apiResponse = ApiResponse.SuccessResult(true, message);
        return StatusCode(apiResponse.StatusCode, apiResponse);
    }

    [HttpPost("update-after-return")]
    [ValidateUserExists(Policy = PermissionConstants.Bookings.Edit)]
    public async Task<IActionResult> UpdateAfterReturn([FromForm] UpdateAfterReturnRequest request, CancellationToken ct)
    {
        try
        {
            List<FileModel>? fileModels = null;
            if (request.ReturnImages is { Count: > 0 })
            {
                fileModels = [];
                foreach (var file in request.ReturnImages)
                {
                    var memoryStream = new MemoryStream();
                    await file.CopyToAsync(memoryStream, ct);
                    memoryStream.Position = 0;
                    
                    fileModels.Add(new FileModel
                    {
                        FileName = file.FileName,
                        Content = memoryStream,
                        ContentType = file.ContentType
                    });
                }
            }
            
            var command = mapper.Map<UpdateAfterReturnCommand>(request);
            command.ReturnImages = fileModels;

            var (success, message, violationCount, violations) = await sender.Send(command, ct);

            if (!success)
            {
                var errorResponse = ApiResponse.ErrorResult(message);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var response = new UpdateAfterReturnResponse
            {
                Success = success,
                Message = message,
                ViolationCount = violationCount,
                Violations = violations.Select(v => new ViolationInfo
                {
                    ViolationId = v.Id,
                    ViolationType = v.ViolationType.ToString(),
                    Description = v.Description,
                    Amount = v.Amount,
                    Status = v.Status.ToString()
                }).ToList()
            };

            var apiResponse = ApiResponse.SuccessResult(response, message);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(BookingMessage.UpdateAfterReturn.Error, StatusCodes.Status500InternalServerError, [ex.Message]);
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpPost("complete")]
    [ValidateUserExists(Policy = PermissionConstants.Bookings.Edit)]
    public async Task<IActionResult> CompleteBooking([FromBody] CompleteBookingRequest request, CancellationToken ct)
    {
        try
        {
            var command = mapper.Map<CompleteBookingCommand>(request);
            var (success, message, loyaltyPointsAwarded, totalLoyaltyPoints) = await sender.Send(command, ct);

            if (!success)
            {
                var errorResponse = ApiResponse.ErrorResult(message);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var response = new CompleteBookingResponse
            {
                Success = success,
                Message = message,
                LoyaltyPointsAwarded = loyaltyPointsAwarded,
                TotalLoyaltyPoints = totalLoyaltyPoints
            };

            var apiResponse = ApiResponse.SuccessResult(response, message);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(BookingMessage.CompleteBooking.Error, StatusCodes.Status500InternalServerError, [ex.Message]);
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    #endregion
}
