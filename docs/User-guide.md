
# 📄 . User Guides
## Passenger Web Application
**Features**
 - User Registration / Login
 - Purchase Prepaid Ticket
 - Use Rapid Pass (Postpaid Account)
 - Scan QR at Entry and Exit Gates
 - View Travel History & Fare Details

**User Flow with Screenshots**
1. Home Screen
 [Screenshot: Home Page]

2. Buy Ticket
 [Screenshot: Ticket Purchase Page]

3. Generate QR
 [Screenshot: QR Code Display Page]

4. Entry Validation

   - Scan the QR at Entry Gate
   -  Validation Successful => Gate Opens
   -   If invalid => Error Message

5. Exit Validation

   - Scan the QR at Exit Gate
   -  System calculates fare and deducts balance
   -   Gate opens on success.

## Admin Dashboard
**Features**
 - Add/Manage Metro Stations
 - Manage Fare Rules (by Distance/Zone)
 - Manage Users
 - View Passenger Travel History
 - View Revenue Reports

**Admin Flow**
1. Login to Admin Dashboard
 - URL: /admin/login

2. Station Management

 - Add new stations
 - Update existing station info

3. Fare Management

 - Set base fare
 - Set per-kilometer fare
 - Define fare zones if applicable

4. User Management

 - View list of passengers
 - Block/Suspend accounts if necessary

5. Reports

 - View real-time travel statistics
 - View revenue reports (daily, monthly)
