-- ========================================
-- COMPREHENSIVE SEED DATA - WriteDB
-- Car Rental System
-- 100+ Vehicles, Bookings, Transactions
-- Fixes: Vehicle vs VehicleModel Split
-- Generated: 2026-02-07
-- ========================================

SET NOCOUNT ON;
DECLARE @now DATETIME2 = GETUTCDATE();

PRINT '=== STARTING CLEANUP ===';

-- 1. CLEANUP (Delete in reverse dependency order)
-- Transaction & Booking related
DELETE FROM transaction_processing_logs;
DELETE FROM refund_processing_logs;
DELETE FROM payment_transactions;
DELETE FROM refund_requests;
DELETE FROM booking_insurances;
DELETE FROM booking_images;
DELETE FROM booking_violations;
DELETE FROM bookings;

-- Customer & User related
DELETE FROM customers;
DELETE FROM user_roles;
DELETE FROM role_claims; -- Added role_claims
DELETE FROM user_claims;
DELETE FROM user_tokens;
DELETE FROM user_sessions;
DELETE FROM user_logins; -- Added user_logins
DELETE FROM users;
DELETE FROM roles;

-- Vehicle related
DELETE FROM vehicle_attributes;
DELETE FROM vehicle_images;
DELETE FROM vehicle_return_images;
DELETE FROM vehicle_models;
DELETE FROM vehicles;
DELETE FROM vehicle_categories;
DELETE FROM fuels;
DELETE FROM transmissions;

-- System related
DELETE FROM locations;
DELETE FROM insurance_packages;
DELETE FROM system_settings;

PRINT '=== CLEANUP COMPLETED ===';
GO

DECLARE @now DATETIME2 = GETUTCDATE();

-- ========================================
-- 1. SYSTEM SETTINGS & INSURANCE & ROLES
-- ========================================
PRINT 'Inserting System Data...';

INSERT INTO roles (role_id, name, normalized_name, concurrency_stamp, is_deleted) VALUES 
('71af4b53-dcd0-4498-af4b-53dcd0249826', 'Admin', 'ADMIN', NEWID(), 0),
('1e46a445-4351-4d0a-86a4-454351dd0aa6', 'Manager', 'MANAGER', NEWID(), 0),
('2fd185ee-d561-4b48-9185-eed5617b4881', 'Staff', 'STAFF', NEWID(), 0),
('7a908619-1c82-4d16-9086-191c82fd1671', 'Customer', 'CUSTOMER', NEWID(), 0);

INSERT INTO insurance_packages (insurance_package_id, name, description, price, coverage_amount, coverage_details, is_active, display_order, created_at, updated_at, is_deleted) VALUES 
('10000000-0000-0000-0000-000000000001', N'Bảo hiểm cơ bản', N'Bảo hiểm TNDS bắt buộc', 50000, 50000000, N'TNDS 50tr', 1, 1, @now, @now, 0),
('10000000-0000-0000-0000-000000000002', N'Bảo hiểm tiêu chuẩn', N'Bảo hiểm vật chất + TNDS', 100000, 100000000, N'TNDS + Vật chất', 1, 2, @now, @now, 0),
('10000000-0000-0000-0000-000000000003', N'Bảo hiểm cao cấp', N'Bảo hiểm toàn diện', 200000, 200000000, N'Toàn diện VIP', 1, 3, @now, @now, 0);

INSERT INTO system_settings (setting_id, setting_key, setting_value, description, is_deleted) VALUES 
('019b5088-3895-7376-9e27-14a43c0df1d3', 'MembershipThresholds:Bronze', '10000', 'Points for Bronze', 0),
('019b5088-5aa1-70c5-954e-307f367c0ff2', 'MembershipThresholds:Silver', '20000', 'Points for Silver', 0),
('019b5088-6c4e-728e-b019-30b10d351c72', 'MembershipThresholds:Gold', '30000', 'Points for Gold', 0),
('019b5088-870d-72a6-9ab1-eadf6bf04999', 'MembershipThresholds:Platinum', '50000', 'Points for Platinum', 0),
('019b5088-9d8d-7041-83e3-ebc01f9d0a47', 'MembershipThresholds:Diamond', '100000', 'Points for Diamond', 0),
('019b50de-de75-72d8-88b9-a28c3da7fc00', 'BookingSettings:DepositRatio', '0.3', '30% Deposit', 0),
('019b50df-4567-7def-1234-456789001234', 'BookingSettings:LoyaltyPointsPerBooking', '100', '100 Points', 0);
GO

DECLARE @now DATETIME2 = GETUTCDATE();

-- ========================================
-- 2. MASTER DATA (Fuels, Trans, Cats, Locs)
-- ========================================
PRINT 'Inserting Master Data...';
-- (Rest is same)

INSERT INTO fuels (fuel_id, name, description, created_at, updated_at, is_deleted) VALUES 
('e1b2c3d4-a5f6-7890-1234-567890abcdef', 'Gasoline', N'Xăng RON 95', @now, @now, 0),
('f2c3d4e5-b6a7-8901-2345-67890abcdef0', 'Diesel', N'Dầu Diesel', @now, @now, 0),
('a3d4e5f6-c7b8-9012-3456-7890abcdef01', 'Electric', N'Điện', @now, @now, 0),
('b4e5f6a7-d8c9-0123-4567-890abcdef012', 'Hybrid', N'Xăng + Điện', @now, @now, 0),
('c5f6a7b8-e9d0-1234-5678-90abcdef0123', 'Gasoline 92', N'Xăng RON 92', @now, @now, 0),
('d6a7b8c9-f0e1-2345-6789-0abcdef01234', 'Gasoline 95-III', N'Xăng RON 95-III', @now, @now, 0),
('e7b8c9d0-a1f2-3456-7890-abcdef012345', 'E5 RON 92', N'Xăng sinh học E5 RON 92', @now, @now, 0),
('f8c9d0e1-b2a3-4567-8901-bcdef0123456', 'Plug-in Hybrid', N'Sạc điện + Xăng', @now, @now, 0),
('a9d0e1f2-c3b4-5678-9012-cdef01234567', 'LPG', N'Khí hóa lỏng', @now, @now, 0),
('b0e1f2a3-d4c5-6789-0123-def012345678', 'CNG', N'Khí nén tự nhiên', @now, @now, 0),
('c1f2a3b4-e5d6-7890-1234-ef0123456789', 'Hydrogen', N'Pin nhiên liệu Hydrogen', @now, @now, 0),
('d2a3b4c5-f6e7-8901-2345-f01234567890', 'Biodiesel', N'Dầu sinh học', @now, @now, 0),
('e3b4c5d6-a7f8-9012-3456-012345678901', 'Ethanol E85', N'Cồn Ethanol E85', @now, @now, 0),
('f4c5d6e7-b8a9-0123-4567-123456789012', 'Methanol', N'Methanol', @now, @now, 0),
('a5d6e7f8-c9b0-1234-5678-234567890123', 'Solar', N'Năng lượng mặt trời', @now, @now, 0),
('b6e7f8a9-d0c1-2345-6789-345678901234', 'Gasoline Premium', N'Xăng cao cấp RON 98', @now, @now, 0),
('c7f8a9b0-e1d2-3456-7890-456789012345', 'Mild Hybrid', N'Hệ thống Mild Hybrid 48V', @now, @now, 0),
('d8a9b0c1-f2e3-4567-8901-567890123456', 'Full Hybrid', N'Full Hybrid tự sạc', @now, @now, 0),
('e9b0c1d2-a3f4-5678-9012-678901234567', 'Extended Range EV', N'Xe điện tầm xa mở rộng', @now, @now, 0),
('f0c1d2e3-b4a5-6789-0123-789012345678', 'Synthetic Fuel', N'Nhiên liệu tổng hợp e-Fuel', @now, @now, 0);

-- ========================================
-- 3. TRANSMISSIONS
-- ========================================
PRINT 'Inserting Transmissions...';

INSERT INTO transmissions (transmission_id, name, code, description) VALUES 
('a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6', 'Automatic Transmission', 'AT', N'Hộp số tự động thường'),
('b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7', 'Manual Transmission', 'MT', N'Hộp số sàn'),
('c3d4e5f6-a7b8-c9d0-e1f2-a3b4c5d6e7f8', 'CVT', 'CVT', N'Hộp số vô cấp'),
('d4e5f6a7-b8c9-d0e1-f2a3-b4c5d6e7f8a9', 'DCT', 'DCT', N'Hộp số ly hợp kép'),
('e5f6a7b8-c9d0-e1f2-a3b4-c5d6e7f8a9b0', 'AMT', 'AMT', N'Hộp số sàn tự động'),
('f6a7b8c9-d0e1-f2a3-b4c5-d6e7f8a9b0c1', 'Tiptronic', 'TIP', N'Hộp số Tiptronic'),
('a7b8c9d0-e1f2-a3b4-c5d6-e7f8a9b0c1d2', 'DSG 6-speed', 'DSG6', N'DSG 6 cấp'),
('b8c9d0e1-f2a3-b4c5-d6e7-f8a9b0c1d2e3', 'DSG 7-speed', 'DSG7', N'DSG 7 cấp'),
('c9d0e1f2-a3b4-c5d6-e7f8-a9b0c1d2e3f4', 'PDK', 'PDK', N'Porsche Doppelkupplung'),
('d0e1f2a3-b4c5-d6e7-f8a9-b0c1d2e3f4a5', 'S-Tronic', 'STR', N'Audi S-Tronic'),
('e1f2a3b4-c5d6-e7f8-a9b0-c1d2e3f4a5b6', '8-speed AT', 'AT8', N'Hộp số tự động 8 cấp'),
('f2a3b4c5-d6e7-f8a9-b0c1-d2e3f4a5b6c7', '9-speed AT', 'AT9', N'Hộp số tự động 9 cấp'),
('a3b4c5d6-e7f8-a9b0-c1d2-e3f4a5b6c7d8', '10-speed AT', 'AT10', N'Hộp số tự động 10 cấp'),
('b4c5d6e7-f8a9-b0c1-d2e3-f4a5b6c7d8e9', '6-speed MT', 'MT6', N'Số sàn 6 cấp'),
('c5d6e7f8-a9b0-c1d2-e3f4-a5b6c7d8e9f0', '5-speed MT', 'MT5', N'Số sàn 5 cấp'),
('d6e7f8a9-b0c1-d2e3-f4a5-b6c7d8e9f0a1', 'iMT', 'IMT', N'Intelligent Manual Transmission'),
('e7f8a9b0-c1d2-e3f4-a5b6-c7d8e9f0a1b2', 'e-CVT', 'ECVT', N'CVT điện tử cho Hybrid'),
('f8a9b0c1-d2e3-f4a5-b6c7-d8e9f0a1b2c3', 'Single-Speed EV', 'EV1', N'Hộp số 1 cấp cho xe điện'),
('a9b0c1d2-e3f4-a5b6-c7d8-e9f0a1b2c3d4', 'ZF 8HP', 'ZF8', N'ZF 8-cấp tự động'),
('b0c1d2e3-f4a5-b6c7-d8e9-f0a1b2c3d4e5', 'Multitronic', 'MUL', N'Audi Multitronic CVT');


INSERT INTO vehicle_categories (vehicle_categorie_id, category_code, seat, description, created_at, updated_at, is_deleted) VALUES 
('f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01', 'SEDAN', 5, N'Xe sedan 4-5 chỗ, phổ thông', @now, @now, 0),
('f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02', 'SUV', 7, N'Xe thể thao đa dụng, gầm cao', @now, @now, 0),
('f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03', 'HATCHBACK', 5, N'Xe cỡ nhỏ cho đô thị', @now, @now, 0),
('f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04', 'MINIVAN', 7, N'Xe gia đình, rộng rãi', @now, @now, 0),
('f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a05', 'PICKUP', 5, N'Xe bán tải', @now, @now, 0),
('f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a06', 'COUPE', 4, N'Xe thể thao 2 cửa', @now, @now, 0),
('f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a07', 'CONVERTIBLE', 4, N'Xe mui trần', @now, @now, 0),
('f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a08', 'CROSSOVER', 5, N'Xe gầm cao cỡ nhỏ', @now, @now, 0),
('f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a09', 'MPV', 7, N'Xe đa dụng', @now, @now, 0),
('f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a10', 'LUXURY', 5, N'Xe sang, cao cấp', @now, @now, 0);

INSERT INTO locations (location_id, name, address, city, phone_number, opening_hours, latitude, longitude, description, created_at, updated_at, is_deleted) VALUES 
('10000000-0000-0000-0000-000000000001', N'Chi nhánh Quận 1', N'123 Lê Lợi, P. Bến Nghé', N'Hồ Chí Minh', '02838123456', '8:00 - 20:00', 10.7758, 106.702, N'Trung tâm TP.HCM', @now, @now, 0),
('10000000-0000-0000-0000-000000000002', N'Chi nhánh Cầu Giấy', N'456 Xuân Thủy, P. Dịch Vọng Hậu', N'Hà Nội', '02439123456', '7:30 - 19:30', 21.036, 105.782, N'Khu vực Cầu Giấy', @now, @now, 0),
('10000000-0000-0000-0000-000000000003', N'Chi nhánh Hải Châu', N'789 Hùng Vương, Hải Châu', N'Đà Nẵng', '023639123456', '8:00 - 20:00', 16.0544, 108.2022, N'Trung tâm Đà Nẵng', @now, @now, 0),
('10000000-0000-0000-0000-000000000004', N'Chi nhánh Nha Trang', N'12 Trần Phú, Lộc Thọ', N'Khánh Hòa', '025839123456', '8:00 - 20:00', 12.2388, 109.1967, N'Bãi biển Nha Trang', @now, @now, 0),
('10000000-0000-0000-0000-000000000005', N'Chi nhánh Quận 7', N'100 Nguyễn Thị Thập, Tân Phong', N'Hồ Chí Minh', '02838654321', '8:00 - 20:00', 10.7341, 106.7225, N'Phú Mỹ Hưng', @now, @now, 0),
('10000000-0000-0000-0000-000000000006', N'Chi nhánh Hoàn Kiếm', N'50 Hai Bà Trưng, Tràng Tiền', N'Hà Nội', '02439654321', '7:00 - 21:00', 21.025, 105.852, N'Phố cổ Hà Nội', @now, @now, 0),
('10000000-0000-0000-0000-000000000007', N'Chi nhánh Hội An', N'15 Trần Hưng Đạo, Minh An', N'Quảng Nam', '02353123456', '8:00 - 18:00', 15.8801, 108.338, N'Phố cổ Hội An', @now, @now, 0),
('10000000-0000-0000-0000-000000000008', N'Chi nhánh Đà Lạt', N'20 Trần Phú, Phường 3', N'Lâm Đồng', '02633123456', '7:00 - 19:00', 11.9404, 108.458, N'Thành phố ngàn hoa', @now, @now, 0),
('10000000-0000-0000-0000-000000000009', N'Chi nhánh Vũng Tàu', N'88 Thùy Vân, Thắng Tam', N'Bà Rịa - Vũng Tàu', '02543123456', '7:00 - 21:00', 10.345, 107.085, N'Bãi sau Vũng Tàu', @now, @now, 0),
('10000000-0000-0000-0000-000000000010', N'Chi nhánh Cần Thơ', N'30 Hòa Bình, Tân An', N'Cần Thơ', '02923123456', '8:00 - 20:00', 10.033, 105.782, N'Trung tâm miền Tây', @now, @now, 0);
GO

DECLARE @now DATETIME2 = GETUTCDATE();

-- ========================================
-- 3. STANDARD USERS & ROLES
-- ========================================
PRINT 'Inserting Standard Users...';

INSERT INTO users (user_id, user_name, password, email, is_verified, status, created_at, updated_at, is_deleted) VALUES 
('11111111-1111-1111-1111-111111111111', 'admin', '$2a$11$gqPb9ViGnJ3kW4Bz9V8q4OqnzXvN1CWXR5l8aY7WjHqQzKhj7mGJe', 'admin@example.com', 1, 1, @now, @now, 0),
('22222222-2222-2222-2222-222222222222', 'staff1', '$2a$11$E5DqMnN3s5eCa1LPXQ8yOu.4sZzK8wqMxkR3YGqHwTdU6VjCnB5Rm', 'staff1@example.com', 1, 1, @now, @now, 0),
('33333333-3333-3333-3333-333333333333', 'customer1', '$2a$11$F6ErNoO4t6fDb2MQYR9zPv.5tAaL9xrNylS4ZHrIxUeW7WkDpC6Sn', 'customer1@example.com', 1, 1, @now, @now, 0),
('44444444-4444-4444-4444-444444444444', 'customer2', '$2a$11$G7FsOpP5u7gEc3NRZS0aQw.6uBbM0ysOzmT5aIsJyVfX8XlEqD7To', 'customer2@example.com', 1, 1, @now, @now, 0);

INSERT INTO user_roles (user_role_id, user_id, role_id) VALUES 
(NEWID(), '11111111-1111-1111-1111-111111111111', '71af4b53-dcd0-4498-af4b-53dcd0249826'),
(NEWID(), '22222222-2222-2222-2222-222222222222', '1e46a445-4351-4d0a-86a4-454351dd0aa6'),
(NEWID(), '33333333-3333-3333-3333-333333333333', '2fd185ee-d561-4b48-9185-eed5617b4881'),
(NEWID(), '44444444-4444-4444-4444-444444444444', '7a908619-1c82-4d16-9086-191c82fd1671');
GO

DECLARE @now DATETIME2 = GETUTCDATE();

-- ========================================
-- 4. VEHICLES (20 records - General Models)
-- ========================================
PRINT 'Inserting Vehicles (General Types)...';

-- Delete if not already (moved to top)
DECLARE @manufacturers TABLE (id INT, name NVARCHAR(50));
INSERT INTO @manufacturers VALUES (1,'Toyota'),(2,'Honda'),(3,'Ford'),(4,'Mazda'),(5,'Hyundai'),(6,'Kia'),(7,'VinFast'),(8,'Mercedes-Benz'),(9,'BMW'),(10,'Audi');

DECLARE @models TABLE (mfr_id INT, name NVARCHAR(50));
INSERT INTO @models VALUES 
(1,'Camry'),(1,'Corolla'),(1,'Vios'),(1,'Fortuner'),(1,'Land Cruiser'),
(2,'Civic'),(2,'City'),(2,'Accord'),(2,'CR-V'),(2,'HR-V'),
(3,'Ranger'),(3,'Everest'),(3,'Territory'),(3,'Explorer'),(3,'Mustang'),
(4,'CX-5'),(4,'CX-8'),(4,'Mazda3'),(4,'Mazda6'),(4,'CX-30'),
(5,'Accent'),(5,'Elantra'),(5,'Tucson'),(5,'Santa Fe'),(5,'Palisade'),
(6,'Morning'),(6,'Seltos'),(6,'Sorento'),(6,'Carnival'),(6,'K5'),
(7,'VF5'),(7,'VF6'),(7,'VF7'),(7,'VF8'),(7,'VF9'),
(8,'C-Class'),(8,'E-Class'),(8,'S-Class'),(8,'GLC'),(8,'GLE'),
(9,'3 Series'),(9,'5 Series'),(9,'7 Series'),(9,'X3'),(9,'X5'),
(10,'A4'),(10,'A6'),(10,'A8'),(10,'Q5'),(10,'Q7');

DECLARE @i INT = 1;
DECLARE @vehicleId UNIQUEIDENTIFIER;
DECLARE @mfr NVARCHAR(50);
DECLARE @model NVARCHAR(50);
DECLARE @price DECIMAL(18,2);
DECLARE @catId UNIQUEIDENTIFIER;
DECLARE @fuelId UNIQUEIDENTIFIER;
DECLARE @transId UNIQUEIDENTIFIER;

WHILE @i <= 20
BEGIN
    SET @vehicleId = NEWID();
    
    -- Random manufacturer/model
    SELECT TOP 1 @mfr = m.name, @model = mo.name 
    FROM @manufacturers m
    CROSS JOIN @models mo
    WHERE mo.mfr_id = m.id
    ORDER BY NEWID();
    
    SET @price = 500000 + (ABS(CHECKSUM(NEWID())) % 2000000);
    SELECT TOP 1 @catId = vehicle_categorie_id FROM vehicle_categories ORDER BY NEWID();
    SELECT TOP 1 @fuelId = fuel_id FROM fuels ORDER BY NEWID();
    SELECT TOP 1 @transId = transmission_id FROM transmissions ORDER BY NEWID();
    
    INSERT INTO vehicles (
        vehicle_id, manufacturer, model, color, price_per_hour, 
        thumbnail, description, rating, available_count, required_license_class,
        vehicle_category_id, fuel_id, transmission_id,
        created_at, updated_at, is_deleted
    )
    VALUES (
        @vehicleId, @mfr, @model, 
        CASE ABS(CHECKSUM(NEWID())) % 5 WHEN 0 THEN N'Đen' WHEN 1 THEN N'Trắng' WHEN 2 THEN N'Bạc' ELSE N'Xám' END,
        @price,
        CONCAT('https://cdn.renticar.vn/vehicles/', LOWER(@mfr), '-', LOWER(REPLACE(@model, ' ', '-')), '.jpg'),
        CONCAT(@mfr, ' ', @model, N' - Dòng xe chất lượng cao'),
        4.5, 999, 0,
        @catId, @fuelId, @transId,
        @now, @now, 0
    );

    SET @i = @i + 1;
END
GO

DECLARE @now DATETIME2 = GETUTCDATE();

-- ========================================
-- 5. VEHICLE MODELS (100 records - Specific Cars)
-- ========================================
PRINT 'Inserting Vehicle Models (Specific Cars)...';

DECLARE @j INT = 1;
DECLARE @vmId UNIQUEIDENTIFIER;
DECLARE @vId2 UNIQUEIDENTIFIER;
DECLARE @locId2 UNIQUEIDENTIFIER;
DECLARE @plate NVARCHAR(20);

WHILE @j <= 100
BEGIN
    SET @vmId = NEWID();
    
    -- Select random parent Vehicle
    SELECT TOP 1 @vId2 = vehicle_id FROM vehicles ORDER BY NEWID();
    -- Select random Location
    SELECT TOP 1 @locId2 = location_id FROM locations ORDER BY NEWID();
    
    SET @plate = CONCAT(CAST(30 + (ABS(CHECKSUM(NEWID())) % 64) AS VARCHAR), 'A-', RIGHT('00000' + CAST(ABS(CHECKSUM(NEWID())) % 100000 AS VARCHAR), 5));
    
    INSERT INTO vehicle_models (
        vehicle_model_id, vehicle_id, mileage, number_plate, status, 
        last_available_at, real_time_location, location_id,
        created_at, updated_at, is_deleted
    )
    VALUES (
        @vmId, @vId2, 
        ABS(CHECKSUM(NEWID())) % 50000, 
        @plate,
        CASE ABS(CHECKSUM(NEWID())) % 5 WHEN 0 THEN 'Rented' WHEN 1 THEN 'Maintenance' ELSE 'Available' END,
        DATEADD(DAY, -ABS(CHECKSUM(NEWID())) % 30, @now),
        NULL, @locId2,
        @now, @now, 0
    );
    
    SET @j = @j + 1;
END
GO

DECLARE @now DATETIME2 = GETUTCDATE();

-- ========================================
-- 6. RANDOM CUSTOMERS (50 records)
-- ========================================
PRINT 'Inserting Random Customers (50 records)...';

DECLARE @k INT = 1;
DECLARE @custId UNIQUEIDENTIFIER;
DECLARE @userId UNIQUEIDENTIFIER;
DECLARE @custRole UNIQUEIDENTIFIER = '7a908619-1c82-4d16-9086-191c82fd1671'; -- Customer role

WHILE @k <= 50
BEGIN
    SET @custId = NEWID();
    SET @userId = NEWID();
    
    INSERT INTO users (user_id, user_name, password, email, is_verified, status, created_at, updated_at, is_deleted)
    VALUES (@userId, 
            CONCAT('user', @k + 2000), 
            '$2a$11$G7FsOpP5u7gEc3NRZS0aQw.6uBbM0ysOzmT5aIsJyVfX8XlEqD7To', -- Default password
            CONCAT('user', @k + 2000, '@example.com'), 
            1, 1, @now, @now, 0);
            
    INSERT INTO user_roles (user_role_id, user_id, role_id)
    VALUES (NEWID(), @userId, @custRole);
    
    INSERT INTO customers (Id, customer_id, user_id, first_name, last_name, phone_number, dob, address, cccd_number, driver_license_id, loyalty_points, created_at, updated_at, is_deleted)
    VALUES (NEWID(), @custId, @userId, 
            N'Khách hàng',
            CONCAT(N'', @k),
            CONCAT('09', RIGHT('00000000' + CAST(10000000 + @k * 12345 AS VARCHAR), 8)),
            DATEADD(YEAR, -(20 + ABS(CHECKSUM(NEWID())) % 40), @now),
            CONCAT(@k, N' Đường ABC, Quận XYZ, TP.HCM'),
            CONCAT('0', RIGHT('00000000000' + CAST(ABS(CHECKSUM(NEWID())) AS VARCHAR), 11)),
            CONCAT('B2-', RIGHT('000000' + CAST(ABS(CHECKSUM(NEWID())) % 1000000 AS VARCHAR), 6)),
            ABS(CHECKSUM(NEWID())) % 50000,
            DATEADD(DAY, -ABS(CHECKSUM(NEWID())) % 365, @now), @now, 0);
    
    SET @k = @k + 1;
END
GO

DECLARE @now DATETIME2 = GETUTCDATE();

-- ========================================
-- 7. BOOKINGS (100 records)
-- ========================================
PRINT 'Inserting Bookings (100 records)...';

DECLARE @m INT = 1;
DECLARE @bookId UNIQUEIDENTIFIER;
DECLARE @custId2 UNIQUEIDENTIFIER;
DECLARE @vId3 UNIQUEIDENTIFIER;
DECLARE @vmId3 UNIQUEIDENTIFIER;
DECLARE @pickupLocId UNIQUEIDENTIFIER;
DECLARE @returnLocId UNIQUEIDENTIFIER;
DECLARE @pickupDate DATETIME2;
DECLARE @returnDate DATETIME2;
DECLARE @price2 DECIMAL(18,2);
DECLARE @days INT;
DECLARE @totalPrice DECIMAL(18,2);
DECLARE @depositAmt DECIMAL(18,2);
DECLARE @status NVARCHAR(50);

WHILE @m <= 100
BEGIN
    SET @bookId = NEWID();
    
    -- Random customer
    SELECT TOP 1 @custId2 = customer_id FROM customers ORDER BY NEWID();
    
    -- Random vehicle model AND its parent vehicle (to ensure FK integrity)
    SELECT TOP 1 @vmId3 = vm.vehicle_model_id, @vId3 = vm.vehicle_id, @price2 = v.price_per_hour
    FROM vehicle_models vm
    JOIN vehicles v ON vm.vehicle_id = v.vehicle_id
    ORDER BY NEWID();
    
    -- Random locations
    SELECT TOP 1 @pickupLocId = location_id FROM locations ORDER BY NEWID();
    SELECT TOP 1 @returnLocId = location_id FROM locations ORDER BY NEWID();
    
    SET @days = 1 + ABS(CHECKSUM(NEWID())) % 14;
    SET @pickupDate = DATEADD(DAY, -30 + ABS(CHECKSUM(NEWID())) % 60, @now);
    SET @returnDate = DATEADD(DAY, @days, @pickupDate);
    SET @totalPrice = @price2 * 24 * @days; -- Assume price_per_hour * 24 * days (simplified)
    SET @depositAmt = @totalPrice * 0.3;
    
    -- Status based on dates
    IF @returnDate < @now
        SET @status = CASE ABS(CHECKSUM(NEWID())) % 10 WHEN 0 THEN 'Cancelled' ELSE 'Completed' END;
    ELSE IF @pickupDate <= @now
        SET @status = 'InProgress';
    ELSE
        SET @status = CASE ABS(CHECKSUM(NEWID())) % 5 WHEN 0 THEN 'Pending' ELSE 'Confirmed' END;
    
    INSERT INTO bookings (
        booking_id, customer_id, 
        vehicle_id, vehicle_model_id, 
        pickup_location_id, return_location_id, 
        start_date, end_date, 
        total_price, status, 
        deposit_ratio, late_penalty_ratio,
        mileage_start, fuel_level_start,
        condition_notes,
        created_at, updated_at, is_deleted
    )
    VALUES (
        @bookId, @custId2, 
        @vId3, @vmId3, 
        @pickupLocId, @returnLocId, 
        @pickupDate, @returnDate, 
        @totalPrice, @status, 
        0.3, 0.05,
        1000 + ABS(CHECKSUM(NEWID())) % 50000, 100,
        CASE WHEN ABS(CHECKSUM(NEWID())) % 3 = 0 THEN N'Ghi chú đặt xe' ELSE NULL END,
        DATEADD(DAY, -3, @pickupDate), @now, 0
    );
    
    SET @m = @m + 1;
END
GO

DECLARE @now DATETIME2 = GETUTCDATE();

-- ========================================
-- 8. PAYMENT TRANSACTIONS (Derived)
-- ========================================
PRINT 'Inserting Payment Transactions (Derived)...';

DECLARE @n INT = 1;
DECLARE @txnId UNIQUEIDENTIFIER;
DECLARE @bookId2 UNIQUEIDENTIFIER;
DECLARE @amount2 DECIMAL(18,2);
DECLARE @payMethod NVARCHAR(50);
DECLARE @bookStatus NVARCHAR(50);
DECLARE @bookCreated DATETIME2;

-- Cursor for deposit (for non-pending)
DECLARE booking_cursor CURSOR FOR 
SELECT booking_id, total_price, deposit_ratio, status, created_at FROM bookings;

DECLARE @totalPrice2 DECIMAL(18,2);
DECLARE @depositRatio2 DECIMAL(5,2);
DECLARE @depositAmt2 DECIMAL(18,2);
DECLARE @finalAmt DECIMAL(18,2);

OPEN booking_cursor;
FETCH NEXT FROM booking_cursor INTO @bookId2, @totalPrice2, @depositRatio2, @bookStatus, @bookCreated;

WHILE @@FETCH_STATUS = 0
BEGIN
    SET @payMethod = CASE ABS(CHECKSUM(NEWID())) % 3 WHEN 0 THEN 'PayOs' WHEN 1 THEN 'VNPay' ELSE 'Cash' END;
    
    -- Calculate amounts
    SET @depositAmt2 = @totalPrice2 * @depositRatio2;
    SET @finalAmt = @totalPrice2 - @depositAmt2;
    
    -- Deposit
    IF @bookStatus <> 'Pending'
    BEGIN
        INSERT INTO payment_transactions (transaction_id, booking_id, amount, transaction_type, payment_method, status, payment_date, transaction_code, created_at, updated_at, is_deleted)
        VALUES (NEWID(), @bookId2, @depositAmt2, 'Deposit', @payMethod, 'Success', DATEADD(HOUR, 1, @bookCreated), 
                20260000000 + ABS(CHECKSUM(NEWID())), -- Random transaction code
                @bookCreated, @now, 0);
    END
    
    -- Final Payment
    IF @bookStatus = 'Completed'
    BEGIN
        INSERT INTO payment_transactions (transaction_id, booking_id, amount, transaction_type, payment_method, status, payment_date, transaction_code, created_at, updated_at, is_deleted)
        VALUES (NEWID(), @bookId2, @finalAmt, 'FinalPayment', @payMethod, 'Success', DATEADD(DAY, 1, @bookCreated), 
                20260000000 + ABS(CHECKSUM(NEWID())), -- Random transaction code
                @bookCreated, @now, 0);
    END
    
    FETCH NEXT FROM booking_cursor INTO @bookId2, @totalPrice2, @depositRatio2, @bookStatus, @bookCreated;
END

CLOSE booking_cursor;
DEALLOCATE booking_cursor;
GO

DECLARE @now DATETIME2 = GETUTCDATE();

-- ========================================
-- 9. REFUND_REQUESTS (Derived from Cancelled Bookings)
-- ========================================
PRINT 'Inserting Refund Requests (Derived)...';

INSERT INTO refund_requests (refund_request_id, booking_id, customer_id, amount, reason, status, processed_at, created_at, updated_at, is_deleted)
SELECT 
    NEWID(),
    booking_id,
    customer_id,
    total_price * 0.3 * 0.7, -- 70% refund of deposit
    N'Khách hàng hủy booking',
    'Processed',
    DATEADD(DAY, 1, created_at),
    created_at,
    updated_at,
    0
FROM bookings
WHERE status = 'Cancelled';
GO

PRINT 'WriteDB Comprehensive Seed completed SUCCESSFULY!';
GO
