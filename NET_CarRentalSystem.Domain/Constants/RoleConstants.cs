namespace NET_CarRentalSystem.Domain.Constants;

public static class RoleConstants
{
    public const string Admin = "Admin";

    // Vai trò Quản lý: Quản lý chi nhánh, nhân viên, báo cáo
    public const string Manager = "Manager";

    // Vai trò Nhân viên: Xử lý nghiệp vụ hàng ngày (tạo đơn, quản lý xe)
    public const string Staff = "Staff";

    // Vai trò Khách hàng: Người dùng cuối, đặt xe
    public const string Customer = "Customer";
}