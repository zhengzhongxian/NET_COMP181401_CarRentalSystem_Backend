using MassTransit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Documents;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;
using NET_CarRentalSystem.Application.Interfaces.Services.Storage;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace NET_CarRentalSystem.Infrastructure.Services.Documents;

public class PdfContractService : IPdfContractService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMinioService _minioService;
    private readonly IPublishEndpoint _publishEndpoint;
    private readonly ICryptographyService _cryptographyService;
    private readonly ILogger<PdfContractService> _logger;

    public PdfContractService(
        IUnitOfWork unitOfWork,
        IMinioService minioService,
        IPublishEndpoint publishEndpoint,
        ICryptographyService cryptographyService,
        ILogger<PdfContractService> logger)
    {
        _unitOfWork = unitOfWork;
        _minioService = minioService;
        _publishEndpoint = publishEndpoint;
        _cryptographyService = cryptographyService;
        _logger = logger;
        QuestPDF.Settings.License = LicenseType.Community;
    }

    public async Task<(bool Success, string Message, string? FileName)> GenerateBookingContractAsync(
        Guid bookingId,
        CancellationToken cancellationToken = default)
    {
        try
        {
            _logger.LogInformation("[GenerateContract] Starting contract generation for booking {BookingId}", bookingId);

            var wbookingRepo = _unitOfWork.GetWriteRepository<Booking>();

            var booking = await wbookingRepo.GetQueryable()
                .Include(b => b.Customer)
                    .ThenInclude(c => c.User)
                .Include(b => b.Vehicle)
                .Include(b => b.VehicleModel)
                .Include(b => b.Transactions)
                .FirstOrDefaultAsync(b => b.Id == bookingId, cancellationToken);
            
            if (booking == null)
            {
                _logger.LogWarning("[GenerateContract] Booking {BookingId} not found", bookingId);
                return (false, BookingMessage.GenerateContract.BookingNotFound, null);
            }
            
            if (booking.Status != BookingStatus.DepositPaid)
            {
                _logger.LogWarning("[GenerateContract] Booking {BookingId} has invalid status: {Status}",
                    bookingId, booking.Status);
                return (false, BookingMessage.GenerateContract.InvalidStatus, null);
            }
            
            var decryptedPhoneNumber = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(booking.Customer.PhoneNumber))
                {
                    decryptedPhoneNumber = _cryptographyService.DecryptAes(booking.Customer.PhoneNumber);
                }
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "[GenerateContract] Failed to decrypt phone number, using masked value");
                decryptedPhoneNumber = "***-***-****";
            }
            
            var pdfBytes = GenerateContractPdf(booking, decryptedPhoneNumber);
            
            var timestamp = DateTime.UtcNow.ToString("yyyyMMdd_HHmmss");
            var fileName = $"HopDong_{bookingId}_{timestamp}.pdf";
            var objectPath = $"contracts/{booking.CustomerId}/{fileName}";
            // Upload to MinIO
            using var pdfStream = new MemoryStream(pdfBytes);
            var fileModel = new FileModel
            {
                FileName = fileName,
                Content = pdfStream,
                ContentType = "application/pdf"
            };

            var metadata = new Dictionary<string, string>
            {
                { "booking-id", bookingId.ToString() },
                { "customer-id", booking.CustomerId.ToString() },
                { "generated-at", DateTime.UtcNow.ToString("O") },
                { "type", "contract" }
            };

            var uploadResult = await _minioService.UploadFileAsync(
                fileModel,
                objectName: objectPath,
                metadata: metadata,
                cancellationToken: cancellationToken);

            _logger.LogInformation("[GenerateContract] Contract uploaded to MinIO: {ObjectName}", uploadResult.ObjectName);
            
            return await _unitOfWork.ExecuteInTransactionAsync(async (ct) =>
            {
                booking.FileName = objectPath;
                wbookingRepo.Update(booking);
                await _unitOfWork.SaveChangesAsync(ct);
                
                var bookingUpdatedEvent = booking.ToUpdatedEvent<Booking, BookingUpdatedEvent, Guid>(_ => new BookingUpdatedEvent
                {
                    FileName = objectPath,
                    Id = default,
                    CreatedAt = default,
                    CreatedBy = null,
                    UpdatedAt = default,
                    UpdatedBy = null
                });

                await _publishEndpoint.Publish(bookingUpdatedEvent, ct);
                await _unitOfWork.SaveChangesAsync(ct);

                _logger.LogInformation("[GenerateContract] Contract generated successfully for booking {BookingId}", bookingId);
                return (true, BookingMessage.GenerateContract.Success, objectPath);

            }, cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "[GenerateContract] Error generating contract for booking {BookingId}", bookingId);
            return (false, $"{BookingMessage.GenerateContract.Error} {ex.Message}", null);
        }
    }

    private byte[] GenerateContractPdf(Booking booking, string decryptedPhoneNumber)
    {
        var primaryColor = Colors.Blue.Darken3;
        var accentColor = Colors.Blue.Lighten4;
        var borderColor = Colors.Grey.Lighten1;

        var document = Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(30);
                page.PageColor(Colors.White);
                page.DefaultTextStyle(x => x.FontSize(10).FontFamily("Arial"));

                // Header
                page.Header().Element(header => ComposeHeader(header, booking, primaryColor));

                // Content
                page.Content().Element(content => ComposeContent(content, booking, decryptedPhoneNumber, primaryColor, accentColor, borderColor));

                // Footer
                page.Footer().Element(footer => ComposeFooter(footer, primaryColor));
            });
        });

        return document.GeneratePdf();
    }

    private void ComposeHeader(IContainer container, Booking booking, string primaryColor)
    {
        container.Column(column =>
        {
            // Company Header
            column.Item().Background(primaryColor).Padding(15).Row(row =>
            {
                row.RelativeItem().Column(col =>
                {
                    col.Item().Text("RENTICAR").FontSize(24).Bold().FontColor(Colors.White);
                    col.Item().Text("DỊCH VỤ CHO THUÊ XE CHUYÊN NGHIỆP").FontSize(10).FontColor(Colors.White);
                    col.Item().Text("PROFESSIONAL VEHICLE RENTAL SERVICE").FontSize(8).FontColor(Colors.Grey.Lighten3);
                });
                row.ConstantItem(150).AlignRight().AlignMiddle().Column(col =>
                {
                    col.Item().Text("Hotline: 1900-RENT").FontSize(11).Bold().FontColor(Colors.White);
                    col.Item().Text("24/7 Support").FontSize(9).FontColor(Colors.Grey.Lighten3);
                });
            });

            // Contract Title
            column.Item().PaddingVertical(15).AlignCenter().Column(col =>
            {
                col.Item().Text("HỢP ĐỒNG THUÊ XE").FontSize(18).Bold().FontColor(primaryColor);
                col.Item().Text("VEHICLE RENTAL CONTRACT").FontSize(12).FontColor(Colors.Grey.Darken2);
            });

            // Contract Info Row
            column.Item().Border(1).BorderColor(Colors.Grey.Lighten2).Padding(10).Row(row =>
            {
                row.RelativeItem().Column(col =>
                {
                    col.Item().Text(text =>
                    {
                        text.Span("Số hợp đồng / Contract No: ").SemiBold();
                        text.Span($"{booking.Id.ToString()[..8].ToUpper()}");
                    });
                });
                row.RelativeItem().AlignRight().Column(col =>
                {
                    col.Item().Text(text =>
                    {
                        text.Span("Ngày lập / Date: ").SemiBold();
                        text.Span($"{DateTime.UtcNow:dd/MM/yyyy}");
                    });
                });
            });

            column.Item().PaddingTop(10);
        });
    }

    private void ComposeFooter(IContainer container, string primaryColor)
    {
        container.Column(column =>
        {
            column.Item().LineHorizontal(1).LineColor(primaryColor);
            column.Item().PaddingTop(5).Row(row =>
            {
                row.RelativeItem().Text(text =>
                {
                    text.Span("RENTICAR").Bold().FontColor(primaryColor);
                    text.Span(" - 123 Đường ABC, Quận XYZ, TP.HCM | Email: support@renticar.vn | Tel: 1900-RENT").FontSize(8).FontColor(Colors.Grey.Darken1);
                });
                row.ConstantItem(100).AlignRight().Text(text =>
                {
                    text.Span("Trang ").FontSize(9);
                    text.CurrentPageNumber().FontSize(9);
                    text.Span(" / ").FontSize(9);
                    text.TotalPages().FontSize(9);
                });
            });
        });
    }

    private static void ComposeContent(IContainer container, Booking booking, string decryptedPhoneNumber, string primaryColor, string accentColor, string borderColor)
    {
        container.Column(column =>
        {
            column.Spacing(12);

            // Section 1: Party A (Lessor) and Party B (Lessee) side by side
            column.Item().Row(row =>
            {
                // Party A
                row.RelativeItem().Border(1).BorderColor(borderColor).Column(col =>
                {
                    col.Item().Background(accentColor).Padding(8).Text("BÊN CHO THUÊ (BÊN A) / LESSOR").Bold().FontSize(10).FontColor(primaryColor);
                    col.Item().Padding(10).Column(innerCol =>
                    {
                        innerCol.Item().Text("Công ty RENTICAR").SemiBold();
                        innerCol.Item().PaddingTop(3).Text("Địa chỉ: 123 Đường ABC, Quận XYZ, TP.HCM").FontSize(9);
                        innerCol.Item().Text("MST: 0123456789").FontSize(9);
                        innerCol.Item().Text("Điện thoại: 1900-RENT").FontSize(9);
                        innerCol.Item().Text("Email: contract@renticar.vn").FontSize(9);
                    });
                });

                row.ConstantItem(10); // Spacing between columns

                // Party B
                row.RelativeItem().Border(1).BorderColor(borderColor).Column(col =>
                {
                    col.Item().Background(accentColor).Padding(8).Text("BÊN THUÊ (BÊN B) / LESSEE").Bold().FontSize(10).FontColor(primaryColor);
                    col.Item().Padding(10).Column(innerCol =>
                    {
                        var fullName = $"{booking.Customer.FirstName} {booking.Customer.LastName}".Trim();
                        if (string.IsNullOrEmpty(fullName)) fullName = "N/A";
                        innerCol.Item().Text(fullName).SemiBold();
                        innerCol.Item().PaddingTop(3).Text($"Email: {booking.Customer.User!.Email}").FontSize(9);
                        innerCol.Item().Text($"Điện thoại: {decryptedPhoneNumber}").FontSize(9);
                        innerCol.Item().Text($"Mã KH: {booking.CustomerId.ToString()[..8].ToUpper()}").FontSize(9);
                    });
                });
            });

            // Section 2: Vehicle Information
            column.Item().Border(1).BorderColor(borderColor).Column(col =>
            {
                col.Item().Background(accentColor).Padding(8).Text("THÔNG TIN PHƯƠNG TIỆN / VEHICLE INFORMATION").Bold().FontSize(10).FontColor(primaryColor);
                col.Item().Padding(10).Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn();
                        columns.RelativeColumn(2);
                        columns.RelativeColumn();
                        columns.RelativeColumn(2);
                    });

                    // Row 1
                    table.Cell().Text("Hãng xe:").SemiBold().FontSize(9);
                    table.Cell().Text(booking.Vehicle.Manufacturer).FontSize(9);
                    table.Cell().Text("Model:").SemiBold().FontSize(9);
                    table.Cell().Text(booking.Vehicle.Model).FontSize(9);

                    // Row 2
                    table.Cell().PaddingTop(5).Text("Biển số:").SemiBold().FontSize(9);
                    table.Cell().PaddingTop(5).Text(booking.VehicleModel.NumberPlate).FontSize(9);
                    table.Cell().PaddingTop(5).Text("Màu sắc:").SemiBold().FontSize(9);
                    table.Cell().PaddingTop(5).Text(booking.Vehicle.Color ?? "N/A").FontSize(9);
                });
            });

            // Section 3: Rental Period
            column.Item().Border(1).BorderColor(borderColor).Column(col =>
            {
                col.Item().Background(accentColor).Padding(8).Text("THỜI GIAN THUÊ / RENTAL PERIOD").Bold().FontSize(10).FontColor(primaryColor);
                col.Item().Padding(10).Row(row =>
                {
                    row.RelativeItem().Column(innerCol =>
                    {
                        innerCol.Item().Text("Ngày bắt đầu / Start Date:").SemiBold().FontSize(9);
                        innerCol.Item().PaddingTop(3).Text($"{booking.StartDate:dd/MM/yyyy HH:mm}").FontSize(11).FontColor(Colors.Green.Darken3);
                    });
                    row.RelativeItem().Column(innerCol =>
                    {
                        innerCol.Item().Text("Ngày kết thúc / End Date:").SemiBold().FontSize(9);
                        innerCol.Item().PaddingTop(3).Text($"{booking.EndDate:dd/MM/yyyy HH:mm}").FontSize(11).FontColor(Colors.Red.Darken3);
                    });
                    row.RelativeItem().Column(innerCol =>
                    {
                        innerCol.Item().Text("Tổng số ngày / Total Days:").SemiBold().FontSize(9);
                        innerCol.Item().PaddingTop(3).Text($"{(booking.EndDate - booking.StartDate).Days} ngày").FontSize(11).Bold().FontColor(primaryColor);
                    });
                });
            });

            // Section 4: Payment Information
            column.Item().Border(1).BorderColor(borderColor).Column(col =>
            {
                col.Item().Background(accentColor).Padding(8).Text("THÔNG TIN THANH TOÁN / PAYMENT INFORMATION").Bold().FontSize(10).FontColor(primaryColor);
                col.Item().Padding(10).Column(innerCol =>
                {
                    var depositAmount = booking.TotalPrice * booking.DepositRatio;
                    var remainingAmount = booking.TotalPrice - depositAmount;

                    innerCol.Item().Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.RelativeColumn(2);
                            columns.RelativeColumn();
                        });

                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2).Padding(5).Text("Mô tả / Description").SemiBold().FontSize(9);
                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2).Padding(5).AlignRight().Text("Số tiền / Amount (VNĐ)").SemiBold().FontSize(9);

                        table.Cell().Padding(5).Text("Tổng giá trị hợp đồng / Total Contract Value").FontSize(9);
                        table.Cell().Padding(5).AlignRight().Text($"{booking.TotalPrice:N0}").FontSize(9).Bold();

                        table.Cell().Padding(5).Text($"Tiền đặt cọc / Deposit ({booking.DepositRatio * 100:N0}%)").FontSize(9);
                        table.Cell().Padding(5).AlignRight().Text($"{depositAmount:N0}").FontSize(9).FontColor(Colors.Green.Darken2);

                        table.Cell().BorderTop(1).BorderColor(Colors.Grey.Lighten2).Padding(5).Text("Còn lại phải thanh toán / Remaining Balance").FontSize(9).SemiBold();
                        table.Cell().BorderTop(1).BorderColor(Colors.Grey.Lighten2).Padding(5).AlignRight().Text($"{remainingAmount:N0}").FontSize(10).Bold().FontColor(Colors.Red.Darken2);
                    });

                    innerCol.Item().PaddingTop(5).Background(Colors.Green.Lighten5).Padding(5).Row(row =>
                    {
                        row.AutoItem().Text("✓").FontSize(10).FontColor(Colors.Green.Darken2);
                        row.RelativeItem().PaddingLeft(5).Text($"Trạng thái: {GetStatusDisplayName(booking.Status)}").FontSize(9).FontColor(Colors.Green.Darken2).SemiBold();
                    });
                });
            });

            // Section 5: Terms and Conditions
            column.Item().Border(1).BorderColor(borderColor).Column(col =>
            {
                col.Item().Background(accentColor).Padding(8).Text("ĐIỀU KHOẢN VÀ ĐIỀU KIỆN / TERMS AND CONDITIONS").Bold().FontSize(10).FontColor(primaryColor);
                col.Item().Padding(10).Column(innerCol =>
                {
                    innerCol.Item().Text("Điều 1: Quyền và nghĩa vụ của Bên A").SemiBold().FontSize(9);
                    innerCol.Item().PaddingLeft(10).Text("• Cung cấp xe đúng như mô tả trong hợp đồng, đảm bảo xe trong tình trạng tốt.").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Hỗ trợ Bên B 24/7 trong suốt thời gian thuê xe.").FontSize(8);
                    
                    innerCol.Item().PaddingTop(5).Text("Điều 2: Quyền và nghĩa vụ của Bên B").SemiBold().FontSize(9);
                    innerCol.Item().PaddingLeft(10).Text("• Sử dụng xe đúng mục đích, tuân thủ pháp luật giao thông.").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Chịu trách nhiệm về mọi vi phạm và thiệt hại trong thời gian thuê.").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Thanh toán đầy đủ và đúng hạn theo hợp đồng.").FontSize(8);
                    
                    innerCol.Item().PaddingTop(5).Text("Điều 3: Đặt cọc và hoàn trả").SemiBold().FontSize(9);
                    innerCol.Item().PaddingLeft(10).Text("• Tiền đặt cọc sẽ được hoàn trả sau khi trả xe và kiểm tra không có hư hỏng.").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Trường hợp có thiệt hại, chi phí sẽ được khấu trừ từ tiền đặt cọc.").FontSize(8);

                    innerCol.Item().PaddingTop(5).Text("Điều 4: Hiệu lực hợp đồng").SemiBold().FontSize(9);
                    innerCol.Item().PaddingLeft(10).Text("• Hợp đồng có hiệu lực kể từ ngày ký và kết thúc khi hoàn tất việc trả xe.").FontSize(8);
                });
            });

            // Section 6: Signatures
            column.Item().PaddingTop(15).Row(row =>
            {
                row.RelativeItem().Border(1).BorderColor(borderColor).Column(col =>
                {
                    col.Item().Background(accentColor).Padding(8).AlignCenter().Text("ĐẠI DIỆN BÊN A / PARTY A").Bold().FontSize(10).FontColor(primaryColor);
                    col.Item().Padding(10).MinHeight(80).Column(innerCol =>
                    {
                        innerCol.Item().AlignCenter().Text("(Ký và đóng dấu)").FontSize(8).Italic().FontColor(Colors.Grey.Darken1);
                        innerCol.Item().AlignCenter().Text("(Signature & Stamp)").FontSize(7).FontColor(Colors.Grey.Medium);
                    });
                    col.Item().BorderTop(1).BorderColor(Colors.Grey.Lighten2).Padding(5).AlignCenter().Text("RENTICAR").SemiBold().FontSize(9);
                });

                row.ConstantItem(20); // Spacing

                row.RelativeItem().Border(1).BorderColor(borderColor).Column(col =>
                {
                    col.Item().Background(accentColor).Padding(8).AlignCenter().Text("BÊN THUÊ XE / PARTY B").Bold().FontSize(10).FontColor(primaryColor);
                    col.Item().Padding(10).MinHeight(80).Column(innerCol =>
                    {
                        innerCol.Item().AlignCenter().Text("(Ký và ghi rõ họ tên)").FontSize(8).Italic().FontColor(Colors.Grey.Darken1);
                        innerCol.Item().AlignCenter().Text("(Signature & Full Name)").FontSize(7).FontColor(Colors.Grey.Medium);
                    });
                    var fullName = $"{booking.Customer.FirstName} {booking.Customer.LastName}".Trim();
                    col.Item().BorderTop(1).BorderColor(Colors.Grey.Lighten2).Padding(5).AlignCenter().Text(string.IsNullOrEmpty(fullName) ? "_______________" : fullName).SemiBold().FontSize(9);
                });
            });

            // Legal Notice
            column.Item().PaddingTop(10).Background(Colors.Grey.Lighten4).Padding(8).Column(col =>
            {
                col.Item().Text("Lưu ý quan trọng / Important Notice:").SemiBold().FontSize(8).FontColor(Colors.Red.Darken2);
                col.Item().Text("Hợp đồng này được lập thành 02 bản có giá trị pháp lý như nhau, mỗi bên giữ 01 bản.").FontSize(7).FontColor(Colors.Grey.Darken2);
                col.Item().Text("This contract is made in 02 copies with equal legal validity, each party keeps 01 copy.").FontSize(7).FontColor(Colors.Grey.Darken2);
            });
        });
    }

    private static string GetStatusDisplayName(BookingStatus status)
    {
        return status switch
        {
            BookingStatus.Pending => "Chờ xử lý",
            BookingStatus.DepositPaid => "Đã đặt cọc",
            BookingStatus.InProgress => "Đang thuê",
            BookingStatus.Completed => "Hoàn thành",
            BookingStatus.Cancelled => "Đã hủy",
            _ => status.ToString()
        };
    }
}
