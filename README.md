# 🚇 QR Code Metro Based Ticketing System [![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

![.NET Version](https://img.shields.io/badge/.NET-8.0-%23512bd4) 
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-9.0-%23642DE4) 
![EF Core](https://img.shields.io/badge/EF_Core-8.0-%23d6522b) 
![SQL Server](https://img.shields.io/badge/SQL_Server-2022-%23CC2927) 
![Redis](https://img.shields.io/badge/Redis-%23DD0031.svg?logo=redis&logoColor=white) 
![JWT](https://img.shields.io/badge/JWT-Auth-%23000000?logo=jsonwebtokens) 
![QRCoder](https://img.shields.io/badge/QR_Code-Generator-%23000000?logo=qrcode)
![Alt text](docs/Images/train-anim1.svg)

## Team Information: NetNinjas

| Category        | Details                                               |
|-----------------|-------------------------------------------------------|
| **Mentor**      | [Jaber Kibria](https://github.com/mhsjaber)           |
| **Team Member** | [Rabbani Islam Refat](https://github.com/refat75)     |
|                 | [Md. Nazmul Hossain](https://github.com/nazmulhossin) |
|                 | [Sujan Roy](https://github.com/sujan-roy24)           |

## 📄 Project Description

The **QR Code Based Metro Ticketing System** is designed to simplify metro station operations by eliminating the need for physical tickets.  
It leverages **secure QR codes** and **real-time caching** to provide a **fast, reliable, and secure** metro experience for passengers.

🔹 **Key Features:**
- 🔒 Secure generation of **single-use QR codes** for entry and exit stations.
- ⚡ High-performance **QR code validation** using **Redis in-memory caching** with SQL Server failover.
- 🔄 Real-time **tracking**, **transaction handling**, and **fare calculation**.
- 🛡️ Focus on **clean architecture**, **security**, and **scalability**.


✅ This project is ideal for organizations seeking to:
- **Modernize** their metro ticketing systems.
- **Increase efficiency** at metro entry and exit gates.
- **Enhance security** and **reduce operational costs**.

---
## 🌐 Live Demo
Experience QR Code Metro Based Ticketing System in action by visiting our live demo:

[![Live Demo](https://img.shields.io/badge/View%20Live-Click%20Here-brightgreen?style=for-the-badge&logo=googlechrome&logoColor=white)](https://dhakametro.bsite.net/)

---
## 🛠️ Installation Instructions

Follow these steps to set up the project locally:

### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
- [SQL Server 2022](https://www.microsoft.com/sql-server)
- [Redis 7.4.2](https://redis.io/download)
- [Visual Studio 2022](https://visualstudio.microsoft.com/)

### ⚙️Setup Configuration
1. **Clone the repository:**
   ```sh
   git clone https://github.com/Learnathon-By-Geeky-Solutions/netninjas.git
   cd netninjas
   ```
2. **Configuration Settings:**
    ```sh
    {
      "ConnectionStrings": {
        "DefaultConnection":"your_sql_server_connection_string",
        "RedisConnectionString": "your_redis_connection_string"
      },
      "AdminSettings": {
        "DefaultEmail": "admin@gmail.com",
        "DefaultPassword": "admin123"
      },
      "EmailSettings": {
        "SmtpServer": "your-SmtpServer",
        "SmtpPort": your-SmtpPort,
        "SmtpUsername": "your-SmtpUsername",
        "SmtpPassword": "your-SmtpPassword",
      },
      "JwtSettings": {
        "SecretKey": "your-SecretKey",
      },
      "QRCodeSecretKey": "your-QRCodeSecretKey"
    }
    ```
3. **Database Setup:**
   - Run the SQL migration to set up the database schema:
     ```sh
     dotnet ef database update
     ```
4. **Build and Run the Application**
   - Now you are ready to build and run the project:
     ```sh
     dotnet build
     dotnet run
      ```
   - After building and running, open your browser and go to:
     ```sh
     https://localhost:7157
     ```
   You should now be able to access the application locally.
---
## Resources
- [Project Documentation](docs/)
- [Development Setup](docs/setup.md)
- [Contributing Guidelines](CONTRIBUTING.md)


# 🚇 QR Code Metro Based Ticketing System [![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

![.NET Version](https://img.shields.io/badge/.NET-8.0-%23512bd4) 
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-9.0-%23642DE4) 
![EF Core](https://img.shields.io/badge/EF_Core-8.0-%23d6522b) 
![SQL Server](https://img.shields.io/badge/SQL_Server-2022-%23CC2927) 
![Redis](https://img.shields.io/badge/Redis-%23DD0031.svg?logo=redis&logoColor=white) 
![JWT](https://img.shields.io/badge/JWT-Auth-%23000000?logo=jsonwebtokens) 
![QRCoder](https://img.shields.io/badge/QR_Code-Generator-%23000000?logo=qrcode)

<p align="center">
  <img src="MetroSystem/UserApp/Images/train-anim1.svg" alt="Metro System" width="500">
</p>

## 👥 Team Information: NetNinjas

| Category        | Details                                               |
|-----------------|-------------------------------------------------------|
| **Mentor**      | [Jaber Kibria](https://github.com/mhsjaber)           |
| **Team Member** | [Rabbani Islam Refat](https://github.com/refat75)     |
|                 | [Md. Nazmul Hossain](https://github.com/nazmulhossin) |
|                 | [Sujan Roy](https://github.com/sujan-roy24)           |

## 📄 Project Description

<p align="justify">
The <strong>QR Code Based Metro Ticketing System</strong> is designed to simplify metro station operations by eliminating the need for physical tickets. It generates a unique QR code for users upon each trip and records station entry and exit data when users scan their codes at respective gates. Fares are automatically calculated based on predefined rates and deducted from the user's account balance.
</p>

<p align="justify">
The system leverages <strong>secure QR codes</strong> and <strong>real-time caching</strong> to provide a <strong>fast, reliable, and secure</strong> metro experience for passengers. The architecture emphasizes high performance with Redis caching and SQL Server for data persistence.
</p>

## 🔹 Key Features

- 🔒 Secure generation of **single-use QR codes** for entry and exit stations
- ⚡ High-performance **QR code validation** using **Redis in-memory caching** with SQL Server failover
- 🔄 Real-time **tracking**, **transaction handling**, and **fare calculation**
- 💰 Account balance management with multiple payment options
- 📊 Comprehensive reporting and analytics dashboard
- 🛡️ Focus on **clean architecture**, **security**, and **scalability**

## 🎯 Target Use Case

✅ This project is ideal for organizations seeking to:
- **Modernize** their metro ticketing systems
- **Increase efficiency** at metro entry and exit gates
- **Enhance security** and **reduce operational costs**
- **Improve passenger experience** with digital solutions

## 🌐 Live Demo

Experience QR Code Metro Based Ticketing System in action by visiting our live demo:

[![Live Demo](https://img.shields.io/badge/View%20Live-Click%20Here-brightgreen?style=for-the-badge&logo=googlechrome&logoColor=white)](https://dhakametro.bsite.net/)

## 📋 Requirements

### User Requirements

1. Users must log in with their credentials (e.g., email & password or OTP) to access the system
2. Users can add funds to their account through an integrated payment gateway (e.g., credit/debit cards, digital wallets, or mobile banking)
3. Users can generate a unique QR code for each trip, which is valid for a single journey
4. Users can use the generated QR code to enter and exit the station by scanning it at the respective gates
5. Users can view detailed travel records, including entry/exit stations, travel time, fare deductions, and transaction history
6. Users can generate a QR code in advance in case of network issues
7. Users receive notifications about low balances and prompts to recharge before their next trip
8. Users can calculate the fare for a journey before starting their trip by selecting the entry and exit stations
9. Users can manage multiple tickets (e.g., for family or group travel)
10. Users can report lost items through the system
11. Users receive real-time updates about station closures, maintenance, delays, or other service disruptions

### Admin Requirements

1. Admins can add, update, or remove stations from the system as needed
2. Admins can set or adjust fare rates based on travel distances
3. Admins can monitor overall system activity, including income reports, passenger statistics, and trip records
4. Admins can block users involved in fraudulent activities and impose penalties for rule violations
5. Admins can access a live dashboard to view station occupancy, active users, and ongoing trips in real-time
6. Admins can handle refund requests and resolve transaction disputes efficiently
7. Admins can send real-time alerts to passengers in case of emergencies or unexpected disruptions
8. Admins can generate detailed reports on revenue, user visits, and other key metrics

## 🏗️ System Architecture

The system follows a clean, layered architecture with the following components:

### 📊 Sequence Diagram: Ticket Purchase Flow

```mermaid
sequenceDiagram
    actor Passenger as "Passenger"
    participant MobileApp as "Web App"
    participant API as "Controller"
    participant Auth as "Auth Service"
    participant Fare as "Fare Service"
    participant Ticket as "Ticket Service"
    participant Payment as "Payment Service"
    participant Redis as "Redis Cache"
    participant SQL as "SQL Database"
    participant Gateway as "Payment Gateway"
    
    Note over Passenger, MobileApp: Initiate Purchase Flow
    
    %% Initial request
    Passenger->>+MobileApp: Select Stations & Payment Method
    MobileApp->>+API: POST /api/tickets {originId, destId, paymentMethod}
    
    %% Authentication
    API->>+Auth: Validate JWT
    Auth-->>-API: ✔ Valid Token
    
    %% Fare calculation
    API->>+Fare: CalculateFare(originId, destId)
    Fare->>+SQL: SELECT distance FROM StationDistances
    SQL-->>-Fare: Distance in km
    Fare->>+SQL: SELECT fare_rules FROM SystemSettings
    SQL-->>-Fare: Base fare + per km rate
    Fare-->>-API: Calculated Fare (৳)
    
    %% Payment section
    API->>+Payment: InitiatePayment(userId, amount, method)
    
    alt Payment Method = Account Balance
        Payment->>+SQL: SELECT balance FROM Wallets WHERE userId
        SQL-->>-Payment: Current balance
        Payment->>SQL: UPDATE Wallets SET balance -= amount
        Payment->>SQL: INSERT Transaction
    else External Payment (BKash/Nagad/Visa)
        Payment->>+Gateway: CreatePaymentLink(amount)
        Gateway-->>-Payment: paymentUrl
        Payment-->>API: paymentUrl
        API-->>MobileApp: 302 Redirect
        MobileApp->>+Gateway: Process Payment UI
        Gateway-->>-Payment: Webhook Notification
    end
    
    Payment->>+SQL: INSERT Transactions (status=Completed)
    SQL-->>-Payment: transactionId
    Payment-->>-API: Payment Successful
    
    %% Ticket generation
    API->>+Ticket: GenerateQRTicket(userId, stations, fare)
    Ticket->>+SQL: INSERT Tickets (status=Active)
    SQL-->>-Ticket: ticketId
    Ticket->>Redis: SETEX ticket:{ticketId} 86400 {encryptedData}
    Ticket-->>-API: Ticket Generated
    
    API-->>-MobileApp: 201 Created + QR Code
    MobileApp-->>-Passenger: Display Ticket (Valid for 24h)
    
    %% Error Handling
    rect rgb(255, 240, 240)
        Note right of Payment: Failed Payment Flow
        Payment--xAPI: Payment Failed
        API->>SQL: UPDATE Transactions SET status=Failed
        API-->>MobileApp: 402 Payment Required
    end

