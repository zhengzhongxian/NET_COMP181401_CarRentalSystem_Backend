# Branch Statistics API Contract
Tài liệu này mô tả các API endpoints mà Backend đã cung cấp để phục vụ cho trang "Chi Tiết Chi Nhánh" ở Frontend.

Tất cả các API này đều yêu cầu xác thực và quyền truy cập cấp quản lý (Admin).
Base URL: `http://localhost:5000` (hoặc URL tương ứng của môi trường của bạn).

---

## 1. Thống kê tổng quan các chi nhánh

**Endpoint:** `GET /api/dashboard/branch-stats-overview`
**Authorization:** Bearer Token (Role: Admin)

**Response Body (JSON):**
```json
{
  "success": true,
  "message": "Lấy thống kê tổng quan chi nhánh thành công",
  "data": {
    "totalRevenueToday": 45200000.0,
    "topRevenueBranch": "TP. Hồ Chí Minh",
    "activeVehicles": 156,
    "totalVehicles": 200,
    "topVehicleBranch": "Hà Nội",
    "newCustomersToday": 89,
    "topCustomerBranch": "Đà Nẵng",
    "completedTrips": 234,
    "totalTrips": 267,
    "topCompletionBranch": "TP. Hồ Chí Minh",
    "totalProfit": 12800000.0,
    "profitMargin": 28.3,
    "topProfitBranch": "TP. Hồ Chí Minh"
  },
  "errors": [],
  "statusCode": 200,
  "timestamp": "2026-03-17T10:00:00.000Z"
}
```

---

## 2. So sánh chi nhánh (Radar Chart)

**Endpoint:** `GET /api/dashboard/branch-comparison`
**Authorization:** Bearer Token (Role: Admin)

**Response Body (JSON):**
```json
{
  "success": true,
  "message": "Lấy dữ liệu so sánh chi nhánh thành công",
  "data": {
    "branches": [
      {
        "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
        "name": "Chi Nhánh Hà Nội",
        "shortName": "HN"
      },
      {
        "id": "4b928f64-5717-4562-b3fc-2c963f66abc9",
        "name": "Chi Nhánh TP.HCM",
        "shortName": "HCM"
      }
    ],
    "criteria": [
      {
        "name": "Doanh Thu",
        "values": {
          "HN": 120.0,
          "HCM": 110.0
        }
      },
      {
        "name": "Số Lượng Xe",
        "values": {
          "HN": 98.0,
          "HCM": 130.0
        }
      },
      {
        "name": "Khách Hàng",
        "values": {
          "HN": 86.0,
          "HCM": 130.0
        }
      },
      {
        "name": "Hiệu Suất",
        "values": {
          "HN": 85.0,
          "HCM": 90.0
        }
      },
      {
        "name": "Bảo Dưỡng",
        "values": {
          "HN": 65.0,
          "HCM": 85.0
        }
      }
    ],
    "maxValue": 150.0
  },
  "errors": [],
  "statusCode": 200,
  "timestamp": "2026-03-17T10:00:00.000Z"
}
```

---

## 3. Doanh thu tất cả chi nhánh (Bar Chart)

**Endpoint:** `GET /api/dashboard/branch-revenue-all`
**Query Parameters:**
*   `period` (string, optional): Khoảng thời gian thống kê. Các giá trị hợp lệ: `month`, `week`, `year`. Mặc định có thể là `month`.

**Authorization:** Bearer Token (Role: Admin)

**Response Body (JSON):**
```json
{
  "success": true,
  "message": "Lấy dữ liệu doanh thu các chi nhánh thành công",
  "data": {
    "data": [
      {
        "branchId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
        "name": "Chi Nhánh Hà Nội",
        "shortName": "HN",
        "revenue": 2500000000.0
      },
      {
        "branchId": "4b928f64-5717-4562-b3fc-2c963f66abc9",
        "name": "Chi Nhánh TP.HCM",
        "shortName": "HCM",
        "revenue": 2200000000.0
      }
    ],
    "totalBranches": 12
  },
  "errors": [],
  "statusCode": 200,
  "timestamp": "2026-03-17T10:00:00.000Z"
}
```

---

## 4. Doanh thu theo ngày của một chi nhánh (Area Chart)

**Endpoint:** `GET /api/dashboard/branches/{branchId}/revenue-daily`
**Path Parameters:**
*   `branchId` (guid): ID của chi nhánh cần lấy thống kê.
**Query Parameters:**
*   `days` (int, optional): Số ngày muốn xem thống kê. Mặc định là `30`.

**Authorization:** Bearer Token (Role: Admin)

**Response Body (JSON):**
```json
{
  "success": true,
  "message": "Lấy dữ liệu doanh thu hàng ngày của chi nhánh thành công",
  "data": {
    "branchName": "Chi Nhánh Hà Nội",
    "data": [
      {
        "date": "2026-03-01",
        "revenue": 45000000.0
      },
      {
        "date": "2026-03-02",
        "revenue": 52000000.0
      }
    ],
    "summary": {
      "totalRevenue": 2340000000.0,
      "avgRevenuePerDay": 78000000.0,
      "maxRevenue": 105000000.0
    }
  },
  "errors": [],
  "statusCode": 200,
  "timestamp": "2026-03-17T10:00:00.000Z"
}
```

---

## 5. Tình trạng xe của một chi nhánh (Radial Chart)

**Endpoint:** `GET /api/dashboard/branches/{branchId}/vehicle-status`
**Path Parameters:**
*   `branchId` (guid): ID của chi nhánh cần lấy thống kê.

**Authorization:** Bearer Token (Role: Admin)

**Response Body (JSON):**
```json
{
  "success": true,
  "message": "Lấy tình trạng xe của chi nhánh thành công",
  "data": {
    "branchName": "Chi Nhánh Hà Nội",
    "totalVehicles": 150,
    "statuses": [
      {
        "name": "Đang Thuê",
        "count": 85,
        "percentage": 56.7
      },
      {
        "name": "Sẵn Sàng",
        "count": 45,
        "percentage": 30.0
      },
      {
        "name": "Bảo Dưỡng",
        "count": 20,
        "percentage": 13.3
      }
    ]
  },
  "errors": [],
  "statusCode": 200,
  "timestamp": "2026-03-17T10:00:00.000Z"
}
```
