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

                        table.Cell().Padding(5).Text($"Tiền đặt cọc / Deposit ({booking.DepositRatio * 100:N0}%) - giữ riêng").FontSize(9);
                        table.Cell().Padding(5).AlignRight().Text($"{depositAmount:N0}").FontSize(9).FontColor(Colors.Orange.Darken2);

                        table.Cell().BorderTop(1).BorderColor(Colors.Grey.Lighten2).Padding(5).Text("Thanh toán khi nhận xe / Payment on Pickup (100%)").FontSize(9).SemiBold();
                        table.Cell().BorderTop(1).BorderColor(Colors.Grey.Lighten2).Padding(5).AlignRight().Text($"{booking.TotalPrice:N0}").FontSize(10).Bold().FontColor(Colors.Red.Darken2);
                    });

                    innerCol.Item().PaddingTop(8).Background(Colors.Orange.Lighten5).Border(1).BorderColor(Colors.Orange.Lighten2).Padding(8).Column(noteCol =>
                    {
                        noteCol.Item().Text("⚠ Lưu ý về thanh toán / Payment Notice:").FontSize(9).SemiBold().FontColor(Colors.Orange.Darken3);
                        noteCol.Item().PaddingTop(3).Text("• Tiền đặt cọc và tiền thuê xe là hai khoản riêng biệt.").FontSize(8);
                        noteCol.Item().Text("  Deposit and rental fee are two separate payments.").FontSize(7).FontColor(Colors.Grey.Darken1).Italic();
                        noteCol.Item().PaddingTop(2).Text("• Khi nhận xe, Bên B thanh toán 100% giá trị hợp đồng (chưa trừ cọc).").FontSize(8);
                        noteCol.Item().Text("  Upon pickup, Party B pays 100% of contract value (deposit not deducted).").FontSize(7).FontColor(Colors.Grey.Darken1).Italic();
                        noteCol.Item().PaddingTop(2).Text("• Tiền cọc sẽ được giữ tối thiểu 30 ngày sau khi trả xe và hoàn trả nếu không có vi phạm.").FontSize(8);
                        noteCol.Item().Text("  Deposit will be held for at least 30 days after return and refunded if no violations.").FontSize(7).FontColor(Colors.Grey.Darken1).Italic();
                    });

                    innerCol.Item().PaddingTop(5).Background(Colors.Green.Lighten5).Padding(5).Row(row =>
                    {
                        row.AutoItem().Text("✓").FontSize(10).FontColor(Colors.Green.Darken2);
                        row.RelativeItem().PaddingLeft(5).Text($"Trạng thái: {GetStatusDisplayName(booking.Status)}").FontSize(9).FontColor(Colors.Green.Darken2).SemiBold();
                    });
                });
            });

            // Section 5: Legal Basis
            column.Item().Border(1).BorderColor(borderColor).Column(col =>
            {
                col.Item().Background(primaryColor).Padding(8).Text("CĂN CỨ PHÁP LÝ / LEGAL BASIS").Bold().FontSize(10).FontColor(Colors.White);
                col.Item().Padding(10).Column(innerCol =>
                {
                    innerCol.Item().Text("Hợp đồng này được lập trên cơ sở các văn bản pháp luật sau:").FontSize(8).Italic();
                    innerCol.Item().PaddingTop(5).PaddingLeft(10).Text("• Bộ luật Dân sự 2015 (Luật số 91/2015/QH13), Phần thứ ba, Chương XVI - Hợp đồng thuê tài sản (Điều 472 - Điều 482).").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Luật Đường bộ 2024 (Luật số 35/2024/QH15) - Quy định về kinh doanh và điều kiện cho thuê xe tự lái.").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Nghị định 100/2019/NĐ-CP (sửa đổi bởi NĐ 123/2021/NĐ-CP) - Xử phạt vi phạm hành chính trong lĩnh vực giao thông đường bộ.").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Luật Bảo vệ quyền lợi người tiêu dùng 2023 (Luật số 19/2023/QH15).").FontSize(8);
                });
            });

            // Section 6: Terms and Conditions
            column.Item().Border(1).BorderColor(borderColor).Column(col =>
            {
                col.Item().Background(accentColor).Padding(8).Text("ĐIỀU KHOẢN VÀ ĐIỀU KIỆN / TERMS AND CONDITIONS").Bold().FontSize(10).FontColor(primaryColor);
                col.Item().Padding(10).Column(innerCol =>
                {
                    // Điều 1
                    innerCol.Item().Text("Điều 1: Quyền và nghĩa vụ của Bên A (Bên cho thuê)").SemiBold().FontSize(9);
                    innerCol.Item().PaddingLeft(10).Text("• Cung cấp xe đúng như mô tả trong hợp đồng, đảm bảo xe trong tình trạng kỹ thuật tốt, đã đăng kiểm và có bảo hiểm TNDS còn hiệu lực.").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Giao xe đúng thời gian, địa điểm đã thỏa thuận kèm đầy đủ giấy tờ xe (bản sao công chứng đăng ký xe, bảo hiểm).").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Hỗ trợ Bên B 24/7 trong suốt thời gian thuê xe. Cung cấp xe thay thế trong trường hợp xe bị hỏng do lỗi kỹ thuật.").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Không được đơn phương thu hồi xe khi hợp đồng còn hiệu lực, trừ trường hợp Bên B vi phạm nghiêm trọng điều khoản hợp đồng.").FontSize(8);
                    
                    // Điều 2
                    innerCol.Item().PaddingTop(5).Text("Điều 2: Quyền và nghĩa vụ của Bên B (Bên thuê)").SemiBold().FontSize(9);
                    innerCol.Item().PaddingLeft(10).Text("• Sử dụng xe đúng mục đích, tuân thủ pháp luật về giao thông đường bộ Việt Nam.").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Bên B phải có Giấy phép lái xe còn hiệu lực, phù hợp với loại xe thuê theo quy định tại Luật Đường bộ 2024.").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Chịu trách nhiệm bảo quản xe, không tự ý sửa chữa, thay đổi kết cấu, trang thiết bị của xe.").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Chịu mọi chi phí nhiên liệu, phí cầu đường, phí đỗ xe phát sinh trong thời gian thuê.").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Chịu trách nhiệm về mọi vi phạm giao thông, tai nạn và thiệt hại trong thời gian thuê theo Điều 601 Bộ luật Dân sự 2015 (trách nhiệm bồi thường thiệt hại do nguồn nguy hiểm cao độ gây ra).").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Thanh toán đầy đủ và đúng hạn các khoản phí theo hợp đồng.").FontSize(8);

                    // Điều 3
                    innerCol.Item().PaddingTop(5).Text("Điều 3: Đặt cọc và hoàn trả").SemiBold().FontSize(9);
                    innerCol.Item().PaddingLeft(10).Text($"• Tiền đặt cọc ({booking.DepositRatio * 100:N0}% giá trị hợp đồng) được giữ riêng biệt, không khấu trừ vào tiền thuê xe (theo Điều 328 Bộ luật Dân sự 2015 về đặt cọc).").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Khi nhận xe, Bên B thanh toán 100% giá trị hợp đồng thuê xe. Tiền cọc là khoản bảo đảm riêng biệt.").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Tiền cọc sẽ được hoàn trả sau tối thiểu 30 ngày kể từ ngày trả xe, nếu xe không có hư hỏng, không có vi phạm giao thông chưa xử lý.").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Trường hợp Bên B vi phạm hợp đồng hoặc gây thiệt hại, tiền cọc sẽ bị khấu trừ tương ứng. Nếu thiệt hại vượt quá tiền cọc, Bên B có nghĩa vụ bồi thường phần chênh lệch.").FontSize(8);

                    // Điều 4
                    innerCol.Item().PaddingTop(5).Text("Điều 4: Bảo hiểm và trách nhiệm bồi thường").SemiBold().FontSize(9);
                    innerCol.Item().PaddingLeft(10).Text("• Xe được bảo hiểm trách nhiệm dân sự bắt buộc (TNDS) theo quy định pháp luật. Bên A chịu trách nhiệm duy trì bảo hiểm TNDS.").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Trường hợp xảy ra tai nạn: Bên B phải thông báo ngay cho Bên A và cơ quan công an. Bên B chịu trách nhiệm bồi thường phần thiệt hại không được bảo hiểm chi trả.").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Bên B chịu hoàn toàn trách nhiệm về các khoản phạt vi phạm giao thông (\"phạt nguội\") phát sinh trong thời gian thuê xe.").FontSize(8);

                    // Điều 5
                    innerCol.Item().PaddingTop(5).Text("Điều 5: Hạn chế sử dụng xe").SemiBold().FontSize(9);
                    innerCol.Item().PaddingLeft(10).Text("• Bên B không được sử dụng xe thuê để kinh doanh vận tải hành khách hoặc hàng hóa có thu tiền (theo Luật Đường bộ 2024).").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Không được cho người thứ ba thuê lại, cầm cố, thế chấp hoặc sử dụng xe làm tài sản bảo đảm dưới mọi hình thức.").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Không được mang xe ra khỏi lãnh thổ Việt Nam nếu không có sự đồng ý bằng văn bản của Bên A.").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Không lái xe khi sử dụng rượu bia, chất kích thích hoặc trong tình trạng sức khỏe không đảm bảo an toàn.").FontSize(8);

                    // Điều 6
                    innerCol.Item().PaddingTop(5).Text("Điều 6: Chấm dứt hợp đồng trước hạn").SemiBold().FontSize(9);
                    innerCol.Item().PaddingLeft(10).Text("• Bên B có quyền trả xe trước hạn. Thời gian thuê thực tế sẽ được tính theo số ngày thực thuê, phần chênh lệch sẽ không được hoàn lại.").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Bên A có quyền đơn phương chấm dứt hợp đồng nếu Bên B vi phạm nghiêm trọng (sử dụng sai mục đích, gây hư hỏng nặng, vi phạm pháp luật).").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Trường hợp chấm dứt do lỗi Bên B, Bên B không được hoàn lại tiền thuê và tiền cọc.").FontSize(8);

                    // Điều 7
                    innerCol.Item().PaddingTop(5).Text("Điều 7: Giải quyết tranh chấp").SemiBold().FontSize(9);
                    innerCol.Item().PaddingLeft(10).Text("• Mọi tranh chấp phát sinh từ hợp đồng này trước hết được giải quyết bằng thương lượng, hòa giải giữa hai bên.").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Trường hợp không thương lượng được, tranh chấp sẽ được đưa ra Tòa án nhân dân có thẩm quyền tại TP. Hồ Chí Minh để giải quyết theo quy định pháp luật Việt Nam.").FontSize(8);

                    // Điều 8
                    innerCol.Item().PaddingTop(5).Text("Điều 8: Hiệu lực hợp đồng").SemiBold().FontSize(9);
                    innerCol.Item().PaddingLeft(10).Text("• Hợp đồng có hiệu lực kể từ ngày ký và kết thúc khi Bên B hoàn tất việc trả xe, thanh toán đầy đủ các khoản phí, và Bên A xác nhận tình trạng xe.").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Các phụ lục, biên bản giao nhận xe, biên bản kiểm tra tình trạng xe là phần không tách rời của hợp đồng này.").FontSize(8);
                    innerCol.Item().PaddingLeft(10).Text("• Hợp đồng được lập thành 02 bản có giá trị pháp lý như nhau, mỗi bên giữ 01 bản.").FontSize(8);
                });
            });

            // Section 7: Signatures
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
            column.Item().PaddingTop(10).Background(Colors.Grey.Lighten4).Border(1).BorderColor(Colors.Grey.Lighten2).Padding(8).Column(col =>
            {
                col.Item().Text("Lưu ý quan trọng / Important Notice:").SemiBold().FontSize(8).FontColor(Colors.Red.Darken2);
                col.Item().PaddingTop(3).Text("Hợp đồng này được lập căn cứ theo Bộ luật Dân sự 2015, Luật Đường bộ 2024 và các văn bản hướng dẫn thi hành. " +
                    "Các bên đã đọc, hiểu rõ và đồng ý với toàn bộ nội dung hợp đồng trước khi ký.").FontSize(7).FontColor(Colors.Grey.Darken2);
                col.Item().PaddingTop(2).Text("This contract is governed by the Civil Code 2015, Road Traffic Law 2024 and related regulations. " +
                    "Both parties have read, understood, and agreed to all terms before signing.").FontSize(7).FontColor(Colors.Grey.Darken2).Italic();
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
