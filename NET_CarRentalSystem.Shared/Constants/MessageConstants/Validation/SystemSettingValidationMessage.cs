namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

public static class SystemSettingValidationMessage
{
    public static class DepositRatio
    {
        public const string Required = "Tỷ lệ đặt cọc là bắt buộc";
        public const string InvalidRange = "Tỷ lệ đặt cọc phải nằm trong khoảng 0 đến 1";
        public const string InvalidFormat = "Tỷ lệ đặt cọc phải là một số thập phân hợp lệ";
        public const string ConversionError = "Tỷ lệ đặt cọc không thể chuyển đổi định dạng";
    }

    public static class LatePenaltyRatio
    {
        public const string Required = "Tỷ lệ phạt trễ là bắt buộc";
        public const string InvalidRange = "Tỷ lệ phạt trễ phải nằm trong khoảng 0 đến 1";
        public const string InvalidFormat = "Tỷ lệ phạt trễ phải là một số thập phân hợp lệ";
        public const string ConversionError = "Tỷ lệ phạt trễ không thể chuyển đổi định dạng";
    }

    public static class MembershipThreshold
    {
        public const string Required = "Ngưỡng hội viên là bắt buộc";
        public const string InvalidFormat = "Ngưỡng hội viên phải là một số nguyên hợp lệ";
        public const string MustBePositive = "Ngưỡng hội viên phải lớn hơn 0";
        public const string InvalidOrder = "Ngưỡng phải tăng dần: Bronze < Silver < Gold < Platinum < Diamond";
        
        public static class ConversionError
        {
            public const string Bronze = "Ngưỡng Bronze không thể chuyển đổi định dạng";
            public const string Silver = "Ngưỡng Silver không thể chuyển đổi định dạng";
            public const string Gold = "Ngưỡng Gold không thể chuyển đổi định dạng";
            public const string Platinum = "Ngưỡng Platinum không thể chuyển đổi định dạng";
            public const string Diamond = "Ngưỡng Diamond không thể chuyển đổi định dạng";
        }
    }

    public static class MembershipDiscount
    {
        public const string Required = "Mức giảm giá hội viên là bắt buộc";
        public const string InvalidFormat = "Mức giảm giá phải là một số thập phân hợp lệ";
        public const string InvalidRange = "Mức giảm giá phải nằm trong khoảng 0 đến 1";
        public const string InvalidOrder = "Mức giảm giá phải tăng dần: Bronze ≤ Silver ≤ Gold ≤ Platinum ≤ Diamond";
        
        public static class ConversionError
        {
            public const string Bronze = "Mức giảm giá Bronze không thể chuyển đổi định dạng";
            public const string Silver = "Mức giảm giá Silver không thể chuyển đổi định dạng";
            public const string Gold = "Mức giảm giá Gold không thể chuyển đổi định dạng";
            public const string Platinum = "Mức giảm giá Platinum không thể chuyển đổi định dạng";
            public const string Diamond = "Mức giảm giá Diamond không thể chuyển đổi định dạng";
        }
    }
}


