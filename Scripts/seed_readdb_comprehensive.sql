-- ========================================
-- COMPREHENSIVE SEED DATA - ReadDB
-- Car Rental System
-- Fixes: Invalid Column Names (id -> vehicle_id, etc.)
-- Generated: 2026-02-07
-- ========================================

SET NOCOUNT ON;
DECLARE @now DATETIME2 = GETUTCDATE();

PRINT '=== STARTING CLEANUP ===';

DELETE FROM payment_transactions;
DELETE FROM refund_requests;
DELETE FROM booking_read_flat;
DELETE FROM vehicle_read_flat;
DELETE FROM locations;

PRINT '=== CLEANUP COMPLETED ===';
GO

DECLARE @now DATETIME2 = GETUTCDATE();

-- ========================================
-- 1. LOCATIONS (10 records)
-- ========================================
PRINT 'Inserting Locations...';

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
-- 2. VEHICLE_READ_FLAT (100 records)
-- ========================================
PRINT 'Inserting Vehicle Read Flat (100 records)...';

DECLARE @categories TABLE (code NVARCHAR(20), seat INT);
INSERT INTO @categories VALUES ('SEDAN',5),('SUV',7),('HATCHBACK',5),('MINIVAN',7),('PICKUP',5),('CROSSOVER',5),('MPV',7),('LUXURY',5),('COUPE',4),('CONVERTIBLE',4);

DECLARE @fuels TABLE (name NVARCHAR(50));
INSERT INTO @fuels VALUES ('Gasoline'),('Diesel'),('Electric'),('Hybrid'),('Gasoline 95'),('E5 RON 92');

DECLARE @trans TABLE (name NVARCHAR(50));
INSERT INTO @trans VALUES ('Automatic'),('Manual'),('CVT'),('DCT');

DECLARE @locs TABLE (id UNIQUEIDENTIFIER, name NVARCHAR(100), city NVARCHAR(50));
INSERT INTO @locs SELECT location_id, name, city FROM locations;

DECLARE @mfrs TABLE (name NVARCHAR(50));
INSERT INTO @mfrs VALUES ('Toyota'),('Honda'),('Ford'),('Mazda'),('Hyundai'),('Kia'),('VinFast'),('Mercedes-Benz'),('BMW'),('Audi');

DECLARE @models TABLE (mfr NVARCHAR(50), model NVARCHAR(50));
INSERT INTO @models VALUES 
('Toyota','Camry'),('Toyota','Corolla'),('Toyota','Vios'),('Toyota','Fortuner'),('Toyota','Land Cruiser'),
('Honda','Civic'),('Honda','City'),('Honda','Accord'),('Honda','CR-V'),('Honda','HR-V'),
('Ford','Ranger'),('Ford','Everest'),('Ford','Territory'),('Ford','Explorer'),('Ford','Mustang'),
('Mazda','CX-5'),('Mazda','CX-8'),('Mazda','Mazda3'),('Mazda','Mazda6'),('Mazda','CX-30'),
('Hyundai','Accent'),('Hyundai','Elantra'),('Hyundai','Tucson'),('Hyundai','Santa Fe'),('Hyundai','Palisade'),
('Kia','Morning'),('Kia','Seltos'),('Kia','Sorento'),('Kia','Carnival'),('Kia','K5'),
('VinFast','VF5'),('VinFast','VF6'),('VinFast','VF7'),('VinFast','VF8'),('VinFast','VF9'),
('Mercedes-Benz','C-Class'),('Mercedes-Benz','E-Class'),('Mercedes-Benz','S-Class'),('Mercedes-Benz','GLC'),('Mercedes-Benz','GLE'),
('BMW','3 Series'),('BMW','5 Series'),('BMW','7 Series'),('BMW','X3'),('BMW','X5'),
('Audi','A4'),('Audi','A6'),('Audi','A8'),('Audi','Q5'),('Audi','Q7');

DECLARE @i INT = 1;

WHILE @i <= 100
BEGIN
    DECLARE @vId UNIQUEIDENTIFIER = NEWID();
    DECLARE @mfr NVARCHAR(50), @mdl NVARCHAR(50);
    DECLARE @cat NVARCHAR(20), @seat INT;
    DECLARE @fuel NVARCHAR(50), @tran NVARCHAR(50);
    DECLARE @locId UNIQUEIDENTIFIER, @locName NVARCHAR(100), @locCity NVARCHAR(50);
    DECLARE @price DECIMAL(18,2) = 50000 + (ABS(CHECKSUM(NEWID())) % 200000); -- Hourly price approx
    
    SELECT TOP 1 @mfr = mfr, @mdl = model FROM @models ORDER BY NEWID();
    SELECT TOP 1 @cat = code, @seat = seat FROM @categories ORDER BY NEWID();
    SELECT TOP 1 @fuel = name FROM @fuels ORDER BY NEWID();
    SELECT TOP 1 @tran = name FROM @trans ORDER BY NEWID();
    
    -- Correct column names: vehicle_id, price_per_hour, fuel_name, transmission_name
    INSERT INTO vehicle_read_flat (
        vehicle_id, manufacturer, model, color, price_per_hour, 
        fuel_name, transmission_name, category_name,
        available_count, rating, required_license_class,
        thumbnail, created_at, updated_at, is_deleted
    )
    VALUES (
        @vId, @mfr, @mdl, 
        CASE ABS(CHECKSUM(NEWID())) % 5 WHEN 0 THEN N'Đen' WHEN 1 THEN N'Trắng' ELSE N'Bạc' END,
        @price,
        @fuel, @tran, @cat,
        1 + ABS(CHECKSUM(NEWID())) % 5, -- Available count
        4 + (ABS(CHECKSUM(NEWID())) % 10) / 10.0, -- Rating 4.0 - 5.0
        0, -- License class
        CONCAT('https://cdn.renticar.vn/vehicles/', LOWER(@mfr), '-', LOWER(REPLACE(@mdl, ' ', '-')), '.jpg'),
        DATEADD(DAY, -ABS(CHECKSUM(NEWID())) % 365, @now), @now, 0
    );
    
    SET @i = @i + 1;
END
GO

DECLARE @now DATETIME2 = GETUTCDATE();

-- ========================================
-- 3. BOOKING_READ_FLAT (100 records)
-- ========================================
PRINT 'Inserting Booking Read Flat (100 records)...';

DECLARE @j INT = 1;

WHILE @j <= 100
BEGIN
    DECLARE @bkId UNIQUEIDENTIFIER = NEWID();
    DECLARE @custId UNIQUEIDENTIFIER = NEWID();
    
    DECLARE @vehId UNIQUEIDENTIFIER, @mfrName NVARCHAR(50), @modelName NVARCHAR(50), @plateNum NVARCHAR(20), @catCode NVARCHAR(20);
    
    SELECT TOP 1 @vehId = vehicle_id, @mfrName = manufacturer, @modelName = model 
    FROM vehicle_read_flat ORDER BY NEWID();
    
    DECLARE @pickLocId UNIQUEIDENTIFIER, @pickLocName NVARCHAR(100);
    SELECT TOP 1 @pickLocId = location_id, @pickLocName = name FROM locations ORDER BY NEWID();
    
    DECLARE @startDate DATETIME2 = DATEADD(DAY, -30 + ABS(CHECKSUM(NEWID())) % 60, @now);
    DECLARE @days2 INT = 1 + ABS(CHECKSUM(NEWID())) % 14;
    DECLARE @endDate DATETIME2 = DATEADD(DAY, @days2, @startDate);
    DECLARE @dailyP DECIMAL(18,2) = 500000 + ABS(CHECKSUM(NEWID())) % 2000000;
    DECLARE @totPrice DECIMAL(18,2) = @dailyP * @days2;
    DECLARE @depAmt DECIMAL(18,2) = @totPrice * 0.3;
    DECLARE @stat NVARCHAR(50);
    
    IF @endDate < @now
        SET @stat = CASE ABS(CHECKSUM(NEWID())) % 8 WHEN 0 THEN 'Cancelled' ELSE 'Completed' END;
    ELSE IF @startDate <= @now
        SET @stat = 'InProgress';
    ELSE
        SET @stat = CASE ABS(CHECKSUM(NEWID())) % 3 WHEN 0 THEN 'Pending' ELSE 'Confirmed' END;
    
    -- Correct column names: booking_id, start_date, end_date, vehicle_id
    INSERT INTO booking_read_flat (
        booking_id, booking_id_src,
        customer_id, customer_name, customer_email,
        vehicle_id, vehicle_model_id,
        vehicle_price_per_hour, -- Added this
        pickup_location_id, pickup_location_name,
        return_location_id, return_location_name,
        start_date, end_date,
        total_price, status, deposit_ratio,
        discount_rate, late_penalty_ratio, -- Added these
        mileage_start, fuel_level_start, -- Added these (required)
        created_at, updated_at, is_deleted
    )
    VALUES (
        @bkId, NEWID(), -- booking_id_src (dummy)
        @custId, CONCAT(N'Khách hàng ', @j), CONCAT('customer', @j, '@gmail.com'),
        @vehId, NEWID(), -- vehicle_model_id (dummy)
        @dailyP / 24, -- Assume daily price, convert to hourly
        @pickLocId, @pickLocName,
        @pickLocId, @pickLocName, -- Return at same loc
        @startDate, @endDate,
        @totPrice, @stat, 0.3,
        0.05, 0.05, -- Discount 5%, Late Penalty 5%
        1000 + ABS(CHECKSUM(NEWID())) % 50000, 100, -- Mileage 1000+, Fuel 100%
        DATEADD(DAY, -3, @startDate), @now, 0
    );
    
    SET @j = @j + 1;
END
GO

DECLARE @now DATETIME2 = GETUTCDATE();

-- ========================================
-- 4. PAYMENT_TRANSACTIONS (150+ records)
-- ========================================
PRINT 'Inserting Payment Transactions...';

INSERT INTO payment_transactions (transaction_id, booking_id, amount, transaction_type, payment_method, status, payment_date, transaction_code, created_at, updated_at, is_deleted)
SELECT 
    NEWID(),
    booking_id_src,
    total_price * 0.3, -- Deposit amount
    'Deposit',
    CASE ABS(CHECKSUM(NEWID())) % 3 WHEN 0 THEN 'PayOs' WHEN 1 THEN 'VNPay' ELSE 'Cash' END,
    'Success',
    DATEADD(HOUR, 1, created_at),
    20260000000 + ABS(CHECKSUM(NEWID())), -- Random transaction code
    created_at,
    updated_at,
    0
FROM booking_read_flat
WHERE status NOT IN ('Pending');

-- Final payments for completed
INSERT INTO payment_transactions (transaction_id, booking_id, amount, transaction_type, payment_method, status, payment_date, transaction_code, created_at, updated_at, is_deleted)
SELECT 
    NEWID(),
    booking_id_src,
    total_price * 0.7, -- Final amount
    'FinalPayment',
    CASE ABS(CHECKSUM(NEWID())) % 3 WHEN 0 THEN 'PayOs' WHEN 1 THEN 'VNPay' ELSE 'Cash' END,
    'Success',
    end_date,
    20260000000 + ABS(CHECKSUM(NEWID())), -- Random transaction code
    created_at,
    updated_at,
    0
FROM booking_read_flat
WHERE status = 'Completed';
GO

DECLARE @now DATETIME2 = GETUTCDATE();

-- ========================================
-- 5. REFUND_REQUESTS (for cancelled bookings)
-- ========================================
PRINT 'Inserting Refund Requests...';

INSERT INTO refund_requests (refund_request_id, booking_id, customer_id, amount, reason, status, processed_at, created_at, updated_at, is_deleted)
SELECT 
    NEWID(),
    booking_id_src,
    customer_id, -- Added this
    total_price * 0.3 * 0.7, -- 70% refund of deposit
    N'Khách hàng hủy booking',
    'Processed',
    DATEADD(DAY, 1, created_at),
    created_at,
    updated_at,
    0
FROM booking_read_flat
WHERE status = 'Cancelled';
GO

PRINT 'ReadDB Comprehensive Seed completed SUCCESSFULY!';
GO
SET NOCOUNT ON;

PRINT '=== STARTING THUMBNAIL UPDATE ===';

-- Update thumbnails based on manufacturer
UPDATE vehicle_read_flat
SET thumbnail = 
    CASE 
        WHEN manufacturer = 'Toyota' THEN 'https://i.pinimg.com/736x/27/e3/25/27e325ebdb79c76411a81b00488ad3f1.jpg'
        WHEN manufacturer = 'VinFast' THEN 'https://i.pinimg.com/1200x/d5/0d/ca/d50dca69d1e873eec8d2b84ac7a25e07.jpg'
        WHEN manufacturer = 'Mercedes-Benz' THEN 'https://i.pinimg.com/avif/1200x/41/e3/03/41e303628044e0b5b38f2f5248c2410c.avf'
        WHEN manufacturer = 'Mazda' THEN 'https://i.pinimg.com/1200x/24/5e/ae/245eaefbf16cd7e01f324dedfeb7b8de.jpg'
        WHEN manufacturer = 'Kia' THEN 'https://i.pinimg.com/1200x/a9/f1/6c/a9f16c5d89023d08398ae505c2bc8f03.jpg'
        WHEN manufacturer = 'Hyundai' THEN 'https://i.pinimg.com/avif/1200x/63/5e/ae/635eae12bafef3fc0b12995f04f7241f.avf'
        WHEN manufacturer = 'Honda' THEN 'https://i.pinimg.com/736x/d9/38/1b/d9381ba6978193d435bac55f40efb8ba.jpg'
        WHEN manufacturer = 'Ford' THEN 'https://i.pinimg.com/736x/1a/42/df/1a42df7b906811bbf1d0b77f01449e89.jpg'
        WHEN manufacturer = 'BMW' THEN 'https://i.pinimg.com/avif/736x/ff/42/5c/ff425cd7458fc00313ad403830e57a3a.avf'
        WHEN manufacturer = 'Audi' THEN 'https://i.pinimg.com/736x/db/5b/15/db5b15e6c4b0702cf963187b76ca32dd.jpg'
        ELSE thumbnail -- Keep the old thumbnail if manufacturer doesn't match
    END;

PRINT '=== THUMBNAIL UPDATE COMPLETED ===';
GO
-- ========================================
-- UPDATE LOCATION THUMBNAILS WITH PINTEREST IMAGES
-- Car Rental System
-- Generated: 2026-03-30
-- ========================================

SET NOCOUNT ON;

PRINT '=== STARTING LOCATION THUMBNAIL UPDATE ===';

-- 1. Get ordered locations and update them one by one
-- We use a CTE to assign a row number to each location based on its name or ID
;WITH RankedLocations AS (
    SELECT location_id, ROW_NUMBER() OVER(ORDER BY name) AS row_num
    FROM locations
)
UPDATE l
SET l.Thumbnail = 
    CASE rl.row_num
        WHEN 1 THEN 'https://i.pinimg.com/736x/c8/3f/ed/c83feddba1cb4784092fc0906ea4fffe.jpg'
        WHEN 2 THEN 'https://i.pinimg.com/736x/e0/9f/49/e09f493cfe107ce34f6ca5a395ba2afa.jpg'
        WHEN 3 THEN 'https://i.pinimg.com/1200x/8a/e5/cd/8ae5cd0537d23836654d1fcedc8d41a7.jpg'
        WHEN 4 THEN 'https://i.pinimg.com/736x/09/9c/a0/099ca080eea762d2ac0f6d2b320fb064.jpg'
        WHEN 5 THEN 'https://i.pinimg.com/avif/1200x/72/7d/5f/727d5f4b6f5a52da1f1ff7a9ba842fc7.avf'
        WHEN 6 THEN 'https://i.pinimg.com/avif/736x/de/03/18/de0318053e135441e6e21f502de30a2b.avf'
        WHEN 7 THEN 'https://i.pinimg.com/736x/d5/25/33/d52533e3dc0c620805e9af3c0b8a8444.jpg'
        WHEN 8 THEN 'https://i.pinimg.com/736x/03/13/b0/0313b030396ad4fb49d441a1e99f1a73.jpg'
        WHEN 9 THEN 'https://i.pinimg.com/avif/1200x/3f/1e/6c/3f1e6c6478be5976296e91e171fa8455.avf'
        WHEN 10 THEN 'https://i.pinimg.com/1200x/2e/68/79/2e68796f8d7253558f81e45f901a32a8.jpg'
        ELSE 'https://i.pinimg.com/736x/c8/3f/ed/c83feddba1cb4784092fc0906ea4fffe.jpg' -- Default if more than 10 locations
    END
FROM locations l
JOIN RankedLocations rl ON l.location_id = rl.location_id;

PRINT '=== LOCATION THUMBNAIL UPDATE COMPLETED ===';
GO
