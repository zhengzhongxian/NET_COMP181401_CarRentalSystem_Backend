-- ========================================
-- SEED DATA FOR READ DATABASE
-- Car Rental System - ReadDB
-- Generated: 2026-02-07
-- ========================================
-- Run this script on your ReadDB (SQL Server)
-- ReadDB contains denormalized/flat tables for fast queries
-- Most data syncs from WriteDB via MassTransit consumers

SET NOCOUNT ON;
DECLARE @now DATETIME2 = GETUTCDATE();

-- ========================================
-- 1. LOCATIONS (Same as WriteDB)
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
-- NOTE: The following tables are populated via MassTransit consumers
-- when corresponding events are published from WriteDB:
-- 
-- - vehicle_read_flat: VehicleReadFlatCreatedConsumer, VehicleReadFlatUpdatedConsumer
-- - booking_read_flat: BookingCreatedConsumer, BookingUpdatedConsumer
-- - payment_transactions: PaymentTransactionCreatedConsumer
-- - refund_requests: RefundRequestCreatedConsumer, RefundProcessedConsumer
--
-- If you need sample data for testing, you can manually insert below:
-- ========================================

-- ========================================
-- 2. SAMPLE VEHICLE_READ_FLAT (Optional for testing)
-- ========================================
PRINT 'Inserting Sample Vehicle Read Flat data...';

IF NOT EXISTS (SELECT 1 FROM vehicle_read_flat WHERE vehicle_id_src = '00000000-0000-0000-0000-000000000001')
BEGIN
    INSERT INTO vehicle_read_flat (
        id,
        vehicle_id_src,
        manufacturer,
        model,
        year,
        number_plate,
        daily_price,
        category_code,
        fuel_name,
        transmission_code,
        location_id,
        location_name,
        location_city,
        status,
        seat,
        thumbnail_url,
        created_at,
        updated_at,
        is_deleted
    )
    VALUES 
        (NEWID(), '00000000-0000-0000-0000-000000000001', 'Toyota', 'Camry', 2023, '51A-12345', 800000, 'SEDAN', 'Gasoline', 'AT', '10000000-0000-0000-0000-000000000001', N'Chi nhánh Quận 1', N'Hồ Chí Minh', 'Available', 5, 'https://example.com/camry.jpg', @now, @now, 0),
        (NEWID(), '00000000-0000-0000-0000-000000000002', 'Honda', 'CR-V', 2023, '30A-67890', 1000000, 'SUV', 'Gasoline', 'AT', '10000000-0000-0000-0000-000000000002', N'Chi nhánh Cầu Giấy', N'Hà Nội', 'Available', 7, 'https://example.com/crv.jpg', @now, @now, 0),
        (NEWID(), '00000000-0000-0000-0000-000000000003', 'VinFast', 'VF8', 2024, '43A-11111', 1200000, 'SUV', 'Electric', 'AT', '10000000-0000-0000-0000-000000000003', N'Chi nhánh Hải Châu', N'Đà Nẵng', 'Available', 5, 'https://example.com/vf8.jpg', @now, @now, 0),
        (NEWID(), '00000000-0000-0000-0000-000000000004', 'Mazda', '3', 2022, '79A-22222', 650000, 'HATCHBACK', 'Gasoline', 'AT', '10000000-0000-0000-0000-000000000004', N'Chi nhánh Nha Trang', N'Khánh Hòa', 'Available', 5, 'https://example.com/mazda3.jpg', @now, @now, 0),
        (NEWID(), '00000000-0000-0000-0000-000000000005', 'Kia', 'Carnival', 2023, '51A-33333', 1500000, 'MINIVAN', 'Diesel', 'AT', '10000000-0000-0000-0000-000000000001', N'Chi nhánh Quận 1', N'Hồ Chí Minh', 'Available', 7, 'https://example.com/carnival.jpg', @now, @now, 0);
END
GO

-- ========================================
-- 3. SAMPLE BOOKING_READ_FLAT (Optional for testing dashboard)
-- ========================================
PRINT 'Inserting Sample Booking Read Flat data for dashboard testing...';

IF NOT EXISTS (SELECT 1 FROM booking_read_flat WHERE booking_id_src = 'B0000000-0000-0000-0000-000000000001')
BEGIN
    INSERT INTO booking_read_flat (
        id,
        booking_id_src,
        customer_id,
        customer_name,
        customer_email,
        vehicle_id,
        manufacturer,
        model,
        number_plate,
        category_code,
        pickup_location_id,
        pickup_location_name,
        pickup_date,
        return_date,
        total_price,
        deposit_amount,
        status,
        created_at,
        updated_at
    )
    VALUES 
        (NEWID(), 'B0000000-0000-0000-0000-000000000001', '33333333-3333-3333-3333-333333333333', 'customer1', 'customer1@example.com', '00000000-0000-0000-0000-000000000001', 'Toyota', 'Camry', '51A-12345', 'SEDAN', '10000000-0000-0000-0000-000000000001', N'Chi nhánh Quận 1', DATEADD(DAY, -10, @now), DATEADD(DAY, -7, @now), 2400000, 720000, 'Completed', DATEADD(DAY, -15, @now), @now),
        (NEWID(), 'B0000000-0000-0000-0000-000000000002', '44444444-4444-4444-4444-444444444444', 'customer2', 'customer2@example.com', '00000000-0000-0000-0000-000000000002', 'Honda', 'CR-V', '30A-67890', 'SUV', '10000000-0000-0000-0000-000000000002', N'Chi nhánh Cầu Giấy', DATEADD(DAY, -5, @now), DATEADD(DAY, -2, @now), 3000000, 900000, 'Completed', DATEADD(DAY, -7, @now), @now),
        (NEWID(), 'B0000000-0000-0000-0000-000000000003', '33333333-3333-3333-3333-333333333333', 'customer1', 'customer1@example.com', '00000000-0000-0000-0000-000000000003', 'VinFast', 'VF8', '43A-11111', 'SUV', '10000000-0000-0000-0000-000000000003', N'Chi nhánh Hải Châu', DATEADD(DAY, 2, @now), DATEADD(DAY, 5, @now), 3600000, 1080000, 'Confirmed', DATEADD(DAY, -1, @now), @now);
END
GO

-- ========================================
-- 4. SAMPLE PAYMENT_TRANSACTIONS (For dashboard revenue)
-- ========================================
PRINT 'Inserting Sample Payment Transactions for dashboard...';

IF NOT EXISTS (SELECT 1 FROM payment_transactions WHERE transaction_id = 'T0000000-0000-0000-0000-000000000001')
BEGIN
    INSERT INTO payment_transactions (
        transaction_id,
        booking_id,
        amount,
        transaction_type,
        payment_method,
        status,
        payment_date,
        created_at,
        updated_at
    )
    VALUES 
        -- HCM branch payments
        ('T0000000-0000-0000-0000-000000000001', 'B0000000-0000-0000-0000-000000000001', 720000, 'Deposit', 'PayOs', 'Success', DATEADD(DAY, -15, @now), DATEADD(DAY, -15, @now), @now),
        ('T0000000-0000-0000-0000-000000000002', 'B0000000-0000-0000-0000-000000000001', 1680000, 'FinalPayment', 'PayOs', 'Success', DATEADD(DAY, -7, @now), DATEADD(DAY, -7, @now), @now),
        -- Hanoi branch payments
        ('T0000000-0000-0000-0000-000000000003', 'B0000000-0000-0000-0000-000000000002', 900000, 'Deposit', 'VNPay', 'Success', DATEADD(DAY, -7, @now), DATEADD(DAY, -7, @now), @now),
        ('T0000000-0000-0000-0000-000000000004', 'B0000000-0000-0000-0000-000000000002', 2100000, 'FinalPayment', 'VNPay', 'Success', DATEADD(DAY, -2, @now), DATEADD(DAY, -2, @now), @now),
        -- Da Nang branch payment (pending)
        ('T0000000-0000-0000-0000-000000000005', 'B0000000-0000-0000-0000-000000000003', 1080000, 'Deposit', 'PayOs', 'Success', DATEADD(DAY, -1, @now), DATEADD(DAY, -1, @now), @now);
END
GO

PRINT 'ReadDB Seed completed successfully!';
GO
