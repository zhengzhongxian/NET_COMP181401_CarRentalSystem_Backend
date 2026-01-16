using FluentValidation;
using NET_CarRentalSystem.Application.Models.DTOs.SystemSettingDTOs;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.SystemSettings.Commands.UpdateSystemSettingsCommand;

public class UpdateBookingSettingsValidator : AbstractValidator<BookingSettingsDto>
{
    public UpdateBookingSettingsValidator()
    {
        RuleFor(x => x.DepositRatio)
            .NotEmpty()
            .WithMessage(SystemSettingValidationMessage.DepositRatio.Required)
            .GreaterThanOrEqualTo(0)
            .LessThanOrEqualTo(1)
            .WithMessage(SystemSettingValidationMessage.DepositRatio.InvalidRange);

        RuleFor(x => x.LatePenaltyRatio)
            .NotEmpty()
            .WithMessage(SystemSettingValidationMessage.LatePenaltyRatio.Required)
            .GreaterThanOrEqualTo(0)
            .LessThanOrEqualTo(1)
            .WithMessage(SystemSettingValidationMessage.LatePenaltyRatio.InvalidRange);
    }
}

public class UpdateMembershipThresholdsValidator : AbstractValidator<MembershipThresholdsDto>
{
    public UpdateMembershipThresholdsValidator()
    {
        RuleFor(x => x.Bronze)
            .NotEmpty()
            .WithMessage(SystemSettingValidationMessage.MembershipThreshold.Required)
            .GreaterThan(0)
            .WithMessage(SystemSettingValidationMessage.MembershipThreshold.MustBePositive);

        RuleFor(x => x.Silver)
            .NotEmpty()
            .WithMessage(SystemSettingValidationMessage.MembershipThreshold.Required)
            .GreaterThan(0)
            .WithMessage(SystemSettingValidationMessage.MembershipThreshold.MustBePositive);

        RuleFor(x => x.Gold)
            .NotEmpty()
            .WithMessage(SystemSettingValidationMessage.MembershipThreshold.Required)
            .GreaterThan(0)
            .WithMessage(SystemSettingValidationMessage.MembershipThreshold.MustBePositive);

        RuleFor(x => x.Platinum)
            .NotEmpty()
            .WithMessage(SystemSettingValidationMessage.MembershipThreshold.Required)
            .GreaterThan(0)
            .WithMessage(SystemSettingValidationMessage.MembershipThreshold.MustBePositive);

        RuleFor(x => x.Diamond)
            .NotEmpty()
            .WithMessage(SystemSettingValidationMessage.MembershipThreshold.Required)
            .GreaterThan(0)
            .WithMessage(SystemSettingValidationMessage.MembershipThreshold.MustBePositive);

        RuleFor(x => x)
            .Custom((req, context) =>
            {
                if (!(req.Bronze < req.Silver && req.Silver < req.Gold && req.Gold < req.Platinum && req.Platinum < req.Diamond))
                {
                    context.AddFailure(SystemSettingValidationMessage.MembershipThreshold.InvalidOrder);
                }
            });
    }
}

public class UpdateMembershipDiscountsValidator : AbstractValidator<MembershipDiscountsDto>
{
    public UpdateMembershipDiscountsValidator()
    {
        RuleFor(x => x.Bronze)
            .NotEmpty()
            .WithMessage(SystemSettingValidationMessage.MembershipDiscount.Required)
            .GreaterThanOrEqualTo(0)
            .LessThanOrEqualTo(1)
            .WithMessage(SystemSettingValidationMessage.MembershipDiscount.InvalidRange);

        RuleFor(x => x.Silver)
            .NotEmpty()
            .WithMessage(SystemSettingValidationMessage.MembershipDiscount.Required)
            .GreaterThanOrEqualTo(0)
            .LessThanOrEqualTo(1)
            .WithMessage(SystemSettingValidationMessage.MembershipDiscount.InvalidRange);

        RuleFor(x => x.Gold)
            .NotEmpty()
            .WithMessage(SystemSettingValidationMessage.MembershipDiscount.Required)
            .GreaterThanOrEqualTo(0)
            .LessThanOrEqualTo(1)
            .WithMessage(SystemSettingValidationMessage.MembershipDiscount.InvalidRange);

        RuleFor(x => x.Platinum)
            .NotEmpty()
            .WithMessage(SystemSettingValidationMessage.MembershipDiscount.Required)
            .GreaterThanOrEqualTo(0)
            .LessThanOrEqualTo(1)
            .WithMessage(SystemSettingValidationMessage.MembershipDiscount.InvalidRange);

        RuleFor(x => x.Diamond)
            .NotEmpty()
            .WithMessage(SystemSettingValidationMessage.MembershipDiscount.Required)
            .GreaterThanOrEqualTo(0)
            .LessThanOrEqualTo(1)
            .WithMessage(SystemSettingValidationMessage.MembershipDiscount.InvalidRange);

        RuleFor(x => x)
            .Custom((req, context) =>
            {
                if (!(req.Bronze <= req.Silver && req.Silver <= req.Gold && req.Gold <= req.Platinum && req.Platinum <= req.Diamond))
                {
                    context.AddFailure(SystemSettingValidationMessage.MembershipDiscount.InvalidOrder);
                }
            });
    }
}

public class UpdateAllSystemSettingsCommandValidator : AbstractValidator<UpdateAllSystemSettingsCommand>
{
    public UpdateAllSystemSettingsCommandValidator()
    {
        RuleFor(x => x.BookingSettings)
            .NotNull()
            .SetValidator(new UpdateBookingSettingsValidator());

        RuleFor(x => x.MembershipThresholds)
            .NotNull()
            .SetValidator(new UpdateMembershipThresholdsValidator());

        RuleFor(x => x.MembershipDiscounts)
            .NotNull()
            .SetValidator(new UpdateMembershipDiscountsValidator());

        // Validate toàn bộ command - check if tất cả giá trị có thể quy đổi về string rồi parse lại mà không lỗi
        RuleFor(x => x)
            .Custom((cmd, context) =>
            {
                try
                {
                    ValidateDecimalConversion(cmd.BookingSettings.DepositRatio, 
                        SystemSettingValidationMessage.DepositRatio.ConversionError, context);
                    
                    ValidateDecimalConversion(cmd.BookingSettings.LatePenaltyRatio, 
                        SystemSettingValidationMessage.LatePenaltyRatio.ConversionError, context);

                    // Test Thresholds
                    ValidateIntConversion(cmd.MembershipThresholds.Bronze, 
                        SystemSettingValidationMessage.MembershipThreshold.ConversionError.Bronze, context);
                    ValidateIntConversion(cmd.MembershipThresholds.Silver, 
                        SystemSettingValidationMessage.MembershipThreshold.ConversionError.Silver, context);
                    ValidateIntConversion(cmd.MembershipThresholds.Gold, 
                        SystemSettingValidationMessage.MembershipThreshold.ConversionError.Gold, context);
                    ValidateIntConversion(cmd.MembershipThresholds.Platinum, 
                        SystemSettingValidationMessage.MembershipThreshold.ConversionError.Platinum, context);
                    ValidateIntConversion(cmd.MembershipThresholds.Diamond, 
                        SystemSettingValidationMessage.MembershipThreshold.ConversionError.Diamond, context);

                    // Test Discounts
                    ValidateDecimalConversion(cmd.MembershipDiscounts.Bronze, 
                        SystemSettingValidationMessage.MembershipDiscount.ConversionError.Bronze, context);
                    ValidateDecimalConversion(cmd.MembershipDiscounts.Silver, 
                        SystemSettingValidationMessage.MembershipDiscount.ConversionError.Silver, context);
                    ValidateDecimalConversion(cmd.MembershipDiscounts.Gold, 
                        SystemSettingValidationMessage.MembershipDiscount.ConversionError.Gold, context);
                    ValidateDecimalConversion(cmd.MembershipDiscounts.Platinum, 
                        SystemSettingValidationMessage.MembershipDiscount.ConversionError.Platinum, context);
                    ValidateDecimalConversion(cmd.MembershipDiscounts.Diamond, 
                        SystemSettingValidationMessage.MembershipDiscount.ConversionError.Diamond, context);
                }
                catch (Exception ex)
                {
                    context.AddFailure($"Lỗi định dạng dữ liệu: {ex.Message}");
                }
            });
    }

    private static void ValidateDecimalConversion(decimal value, string errorMessage, ValidationContext<UpdateAllSystemSettingsCommand> context)
    {
        if (!decimal.TryParse(value.ToString("G", System.Globalization.CultureInfo.InvariantCulture), out _))
        {
            context.AddFailure(errorMessage);
        }
    }

    private static void ValidateIntConversion(int value, string errorMessage, ValidationContext<UpdateAllSystemSettingsCommand> context)
    {
        if (!int.TryParse(value.ToString(), out _))
        {
            context.AddFailure(errorMessage);
        }
    }
}


