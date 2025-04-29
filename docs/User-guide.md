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
 - URL: https://localhost:7157/Admin/
 - Add / Manage Metro Stations
 - Manage Fare Rules (Distance or Zone-based)
 - Manage User Accounts
 - View Passenger Travel Histories
 - View Revenue and Travel Reports
