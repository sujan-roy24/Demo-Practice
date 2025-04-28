# 📄 User Guide
## 🚇 User Web Application
**✨ Features**
 - URL: https://localhost:7157/home
 - Register / Login
 - Purchase Prepaid Tickets
 - Use Rapid Pass (Postpaid Account)
 - Generate and Scan QR Code at Gates
 - View Travel History and Fare Details

## ⚙️ System Operations (Gate Scanning)
**✨ Entry And Exit Scanning**
 - URL: https://localhost:7157/System/Scanner/index

  **Entry Process:**
  
   - Scan QR code at Entry Gate
   - If Valid → Gate Opens
   - If Invalid → Show Error Message
  
  **Exit Process:**
  
   - Scan QR code at Exit Gate
   - Fare is calculated and deducted
   - Gate Opens upon Successful Validation

## 🛠️ Admin Dashboard
**✨ Features**

Add / Manage Metro Stations

Manage Fare Rules (Distance or Zone-based)

Manage User Accounts

View Passenger Travel Histories

View Revenue and Travel Reports

💼 Admin Flow
Login to Admin Dashboard

URL: /admin/login

Station Management

Add Station: /admin/stations/add

Update Station: /admin/stations/edit/{stationId}

Fare Management

Set Base Fare: /admin/fares/set-base

Set Per-Kilometer Fare: /admin/fares/set-per-km

Manage Fare Zones: /admin/fares/manage-zones

User Management

View Users: /admin/users

Block User: /admin/users/block/{userId}

Suspend User: /admin/users/suspend/{userId}

Reports

Travel Statistics: /admin/reports/travel

Revenue Reports: /admin/reports/revenue
