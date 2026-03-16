-- ========================================
-- SEED DATA FOR WRITE DATABASE
-- Car Rental System - WriteDB
-- Generated: 2026-02-07
-- ========================================
-- Run this script on your WriteDB (SQL Server)
-- Make sure tables exist before running this script

SET NOCOUNT ON;
DECLARE @now DATETIME2 = GETUTCDATE();

-- ========================================
-- 1. VEHICLE CATEGORIES
-- ========================================
PRINT 'Inserting Vehicle Categories...';

IF NOT EXISTS (SELECT 1 FROM vehicle_categories WHERE vehicle_categorie_id = 'f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01')
BEGIN
    SET IDENTITY_INSERT vehicle_categories OFF;
    INSERT INTO vehicle_categories (vehicle_categorie_id, category_code, seat, description, created_at, updated_at, is_deleted)
    VALUES 
        ('f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01', 'SEDAN', 5, N'Xe sedan 4-5 chỗ, phổ thông', @now, @now, 0),
        ('f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02', 'SUV', 7, N'Xe thể thao đa dụng, gầm cao', @now, @now, 0),
        ('f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03', 'HATCHBACK', 5, N'Xe cỡ nhỏ cho đô thị', @now, @now, 0),
        ('f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04', 'MINIVAN', 7, N'Xe gia đình, rộng rãi', @now, @now, 0);
END
GO

-- ========================================
-- 2. FUELS
-- ========================================
PRINT 'Inserting Fuels...';

IF NOT EXISTS (SELECT 1 FROM fuels WHERE fuel_id = 'e1b2c3d4-a5f6-7890-1234-567890abcdef')
BEGIN
    INSERT INTO fuels (fuel_id, name, description, created_at, updated_at)
    VALUES 
        ('e1b2c3d4-a5f6-7890-1234-567890abcdef', 'Gasoline', N'Sử dụng xăng', @now, @now),
        ('f2c3d4e5-b6a7-8901-2345-67890abcdef0', 'Diesel', N'Sử dụng dầu Diesel', @now, @now),
        ('a3d4e5f6-c7b8-9012-3456-7890abcdef01', 'Electric', N'Sử dụng năng lượng điện', @now, @now);
END
GO

-- ========================================
-- 3. TRANSMISSIONS
-- ========================================
PRINT 'Inserting Transmissions...';

IF NOT EXISTS (SELECT 1 FROM transmissions WHERE transmission_id = 'a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6')
BEGIN
    INSERT INTO transmissions (transmission_id, name, code, description)
    VALUES 
        ('a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6', 'Automatic Transmission', 'AT', N'Hộp số tự động'),
        ('b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7', 'Manual Transmission', 'MT', N'Hộp số sàn');
END
GO

-- ========================================
-- 4. LOCATIONS
-- ========================================
PRINT 'Inserting Locations...';

IF NOT EXISTS (SELECT 1 FROM locations WHERE location_id = '10000000-0000-0000-0000-000000000001')
BEGIN
    INSERT INTO locations (location_id, name, address, city, phone_number, opening_hours, latitude, longitude, description, created_at, updated_at, is_deleted)
    VALUES 
        ('10000000-0000-0000-0000-000000000001', N'Chi nhánh Quận 1', N'123 Lê Lợi, P. Bến Nghé', N'Hồ Chí Minh', '02838123456', '8:00 - 20:00', 10.7758, 106.702, NULL, @now, @now, 0),
        ('10000000-0000-0000-0000-000000000002', N'Chi nhánh Cầu Giấy', N'456 Xuân Thủy, P. Dịch Vọng Hậu', N'Hà Nội', '02439123456', '7:30 - 19:30', 21.036, 105.782, NULL, @now, @now, 0),
        ('10000000-0000-0000-0000-000000000003', N'Chi nhánh Hải Châu', N'789 Hùng Vương, Hải Châu', N'Đà Nẵng', '023639123456', '8:00 - 20:00', 16.0544, 108.2022, NULL, @now, @now, 0),
        ('10000000-0000-0000-0000-000000000004', N'Chi nhánh Nha Trang', N'12 Trần Phú, Lộc Thọ', N'Khánh Hòa', '025839123456', '8:00 - 20:00', 12.2388, 109.1967, NULL, @now, @now, 0);
END
GO

-- ========================================
-- 5. ROLES
-- ========================================
PRINT 'Inserting Roles...';

IF NOT EXISTS (SELECT 1 FROM roles WHERE id = '71af4b53-dcd0-4498-af4b-53dcd0249826')
BEGIN
    INSERT INTO roles (id, name, normalized_name)
    VALUES 
        ('71af4b53-dcd0-4498-af4b-53dcd0249826', 'Admin', 'ADMIN'),
        ('1e46a445-4351-4d0a-86a4-454351dd0aa6', 'Manager', 'MANAGER'),
        ('2fd185ee-d561-4b48-9185-eed5617b4881', 'Staff', 'STAFF'),
        ('7a908619-1c82-4d16-9086-191c82fd1671', 'Customer', 'CUSTOMER');
END
GO

-- ========================================
-- 6. USERS (Password: BCrypt hashed)
-- admin: Admin@123, staff1: Staff1@123, customer1: Customer1@123, customer2: Customer2@123
-- ========================================
PRINT 'Inserting Users...';

IF NOT EXISTS (SELECT 1 FROM users WHERE id = '11111111-1111-1111-1111-111111111111')
BEGIN
    INSERT INTO users (id, user_name, password, email, is_verified, status, created_at, updated_at, is_deleted)
    VALUES 
        ('11111111-1111-1111-1111-111111111111', 'admin', '$2a$11$gqPb9ViGnJ3kW4Bz9V8q4OqnzXvN1CWXR5l8aY7WjHqQzKhj7mGJe', 'admin@example.com', 1, 1, @now, @now, 0),
        ('22222222-2222-2222-2222-222222222222', 'staff1', '$2a$11$E5DqMnN3s5eCa1LPXQ8yOu.4sZzK8wqMxkR3YGqHwTdU6VjCnB5Rm', 'staff1@example.com', 1, 1, @now, @now, 0),
        ('33333333-3333-3333-3333-333333333333', 'customer1', '$2a$11$F6ErNoO4t6fDb2MQYR9zPv.5tAaL9xrNylS4ZHrIxUeW7WkDpC6Sn', 'customer1@example.com', 1, 1, @now, @now, 0),
        ('44444444-4444-4444-4444-444444444444', 'customer2', '$2a$11$G7FsOpP5u7gEc3NRZS0aQw.6uBbM0ysOzmT5aIsJyVfX8XlEqD7To', 'customer2@example.com', 1, 1, @now, @now, 0);
END
GO

-- ========================================
-- 7. USER_ROLES
-- ========================================
PRINT 'Inserting User Roles...';

IF NOT EXISTS (SELECT 1 FROM user_roles WHERE user_id = '11111111-1111-1111-1111-111111111111')
BEGIN
    INSERT INTO user_roles (user_role_id, user_id, role_id)
    VALUES 
        (NEWID(), '11111111-1111-1111-1111-111111111111', '71af4b53-dcd0-4498-af4b-53dcd0249826'),    -- admin -> Admin
        (NEWID(), '22222222-2222-2222-2222-222222222222', '1e46a445-4351-4d0a-86a4-454351dd0aa6'),    -- staff1 -> Manager
        (NEWID(), '33333333-3333-3333-3333-333333333333', '2fd185ee-d561-4b48-9185-eed5617b4881'),    -- customer1 -> Staff
        (NEWID(), '44444444-4444-4444-4444-444444444444', '7a908619-1c82-4d16-9086-191c82fd1671');    -- customer2 -> Customer
END
GO

-- ========================================
-- 8. INSURANCE PACKAGES
-- ========================================
PRINT 'Inserting Insurance Packages...';

IF NOT EXISTS (SELECT 1 FROM insurance_packages WHERE insurance_package_id = '10000000-0000-0000-0000-000000000001')
BEGIN
    INSERT INTO insurance_packages (insurance_package_id, name, description, price, coverage_amount, coverage_details, is_active, display_order, created_at, updated_at, is_deleted)
    VALUES 
        ('10000000-0000-0000-0000-000000000001', N'Bảo hiểm cơ bản', N'Bảo hiểm trách nhiệm dân sự bắt buộc, bảo vệ bạn trước các chi phí pháp lý cơ bản.', 50000, 50000000, N'- Bảo hiểm trách nhiệm dân sự bên thứ 3\n- Thiệt hại tài sản tối đa 50 triệu\n- Chi phí y tế cơ bản\n- Hỗ trợ pháp lý 24/7', 1, 1, @now, @now, 0),
        ('10000000-0000-0000-0000-000000000002', N'Bảo hiểm tiêu chuẩn', N'Bảo vệ toàn diện cho xe và hành khách với mức bồi thường cao hơn.', 100000, 100000000, N'- Tất cả quyền lợi gói Cơ bản\n- Bảo hiểm vật chất xe\n- Bảo hiểm tai nạn lái xe và hành khách\n- Hỗ trợ cứu hộ 24/7\n- Không khấu trừ khi xảy ra sự cố', 1, 2, @now, @now, 0),
        ('10000000-0000-0000-0000-000000000003', N'Bảo hiểm cao cấp', N'Gói bảo hiểm toàn diện nhất với mức bồi thường tối đa và nhiều quyền lợi đặc biệt.', 200000, 200000000, N'- Tất cả quyền lợi gói Tiêu chuẩn\n- Bảo hiểm mất trộm xe\n- Bảo hiểm thiên tai, hỏa hoạn\n- Xe thay thế khi sửa chữa\n- Bồi thường không giới hạn cho bên thứ 3\n- Hỗ trợ VIP 24/7', 1, 3, @now, @now, 0);
END
GO

-- ========================================
-- 9. SYSTEM SETTINGS
-- ========================================
PRINT 'Inserting System Settings...';

IF NOT EXISTS (SELECT 1 FROM system_settings WHERE system_setting_id = '019b5088-3895-7376-9e27-14a43c0df1d3')
BEGIN
    INSERT INTO system_settings (system_setting_id, setting_key, setting_value, description)
    VALUES 
        -- Membership Thresholds
        ('019b5088-3895-7376-9e27-14a43c0df1d3', 'MembershipThresholds:Bronze', '10000', 'Points required for Bronze tier'),
        ('019b5088-5aa1-70c5-954e-307f367c0ff2', 'MembershipThresholds:Silver', '20000', 'Points required for Silver tier'),
        ('019b5088-6c4e-728e-b019-30b10d351c72', 'MembershipThresholds:Gold', '30000', 'Points required for Gold tier'),
        ('019b5088-870d-72a6-9ab1-eadf6bf04999', 'MembershipThresholds:Platinum', '50000', 'Points required for Platinum tier'),
        ('019b5088-9d8d-7041-83e3-ebc01f9d0a47', 'MembershipThresholds:Diamond', '100000', 'Points required for Diamond tier'),
        -- Membership Discounts
        ('019b5088-c214-77e3-8e6d-7b68b0ee7f90', 'MembershipDiscounts:Bronze', '0', 'Discount ratio for Bronze tier'),
        ('019b5088-e037-780b-98f8-b1dd868ca193', 'MembershipDiscounts:Silver', '0.05', 'Discount ratio for Silver tier'),
        ('019b5088-f455-70e7-818f-341025ede937', 'MembershipDiscounts:Gold', '0.1', 'Discount ratio for Gold tier'),
        ('019b5089-05bb-739e-a4d3-bae8cff04983', 'MembershipDiscounts:Platinum', '0.15', 'Discount ratio for Platinum tier'),
        ('019b5089-20ac-7253-85c6-3a4367442414', 'MembershipDiscounts:Diamond', '0.2', 'Discount ratio for Diamond tier'),
        -- Booking Settings
        ('019b50de-de75-72d8-88b9-a28c3da7fc00', 'BookingSettings:DepositRatio', '0.3', 'Default deposit ratio for all bookings (0.3 = 30%)'),
        ('019b50de-f123-7a4b-9c12-d3e4f5a6b789', 'BookingSettings:LatePenaltyRatio', '0.1', 'Late penalty ratio per day (0.1 = 10% of booking price per day late)'),
        ('019b50df-4567-7def-1234-456789001234', 'BookingSettings:LoyaltyPointsPerBooking', '100', 'Loyalty points awarded per completed booking (default: 100 points)'),
        -- Cancellation Settings
        ('019b50df-1234-7abc-8def-123456789001', 'CancellationSettings:MaxCancellationsPerMonth', '3', 'Maximum number of booking cancellations allowed per month'),
        ('019b50df-2345-7bcd-9ef0-234567890012', 'CancellationSettings:RefundableHoursLimit', '24', 'Number of hours after booking creation within which refund is allowed');
END
GO

PRINT 'WriteDB Seed completed successfully!';
GO
