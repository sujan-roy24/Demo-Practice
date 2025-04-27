# 🚇 QR Code Metro Based Ticketing System [![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](CONTRIBUTING.md)

![.NET Version](https://img.shields.io/badge/.NET-8.0-%23512bd4) 
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-9.0-%23642DE4) 
![EF Core](https://img.shields.io/badge/EF_Core-8.0-%23d6522b) 
![SQL Server](https://img.shields.io/badge/SQL_Server-2022-%23CC2927) 
![Redis](https://img.shields.io/badge/Redis-%23DD0031.svg?logo=redis&logoColor=white) 
![JWT](https://img.shields.io/badge/JWT-Auth-%23000000?logo=jsonwebtokens) 
![QRCoder](https://img.shields.io/badge/QR_Code-Generator-%23000000?logo=qrcode)
![Alt text](MetroSystem/UserApp/Images/train-anim1.svg)

## Team Information: NetNinjas

| Category        | Details                                               |
|-----------------|-------------------------------------------------------|
| **Mentor**      | [Jaber Kibria](https://github.com/mhsjaber)           |
| **Team Member** | [Rabbani Islam Refat](https://github.com/refat75)     |
|                 | [Md. Nazmul Hossain](https://github.com/nazmulhossin) |
|                 | [Sujan Roy](https://github.com/sujan-roy24)           |

## 📄 Project Description

**Project Name:** QR-Based Metro Ticketing System  
**Tech Stack:** ASP.NET MVC | C# | Entity Framework Core | SQL Server | Redis

---

The **QR-Based Metro Ticketing System** is designed to simplify metro station operations by eliminating the need for physical tickets.  
It leverages **secure QR codes** and **real-time caching** to provide a **fast, reliable, and secure** metro experience for passengers.

🔹 **Key Features:**
- 🔒 Secure generation of **single-use QR codes** for entry and exit stations.
- ⚡ High-performance **QR code validation** using **Redis in-memory caching** with SQL Server failover.
- 🔄 Real-time **tracking**, **transaction handling**, and **fare calculation**.
- 🛡️ Focus on **clean architecture**, **security**, and **scalability**.

---

✅ This project is ideal for organizations seeking to:
- **Modernize** their metro ticketing systems.
- **Increase efficiency** at metro entry and exit gates.
- **Enhance security** and **reduce operational costs**.

---
## 🌐 Live Demo
Experience QR Code Metro Based Ticketing System in action by visiting our live demo:

[![Live Demo](https://img.shields.io/badge/View%20Live-Click%20Here-brightgreen?style=for-the-badge&logo=googlechrome&logoColor=white)](https://dhakametro.bsite.net/)

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
     https://localhost:5001
     ```
---
## 🛠️ Tech Stack

### Backend
| Component               | Technology |
|-------------------------|------------|
| Framework               | ASP.NET Core 8.0 MVC |
| ORM                     | Entity Framework Core 8 |
| Database                | SQL Server 2022 |
| Caching                 | Redis |
| Authentication          | JWT Bearer Tokens |
| QR Generation           | QRCoder.NET |

### Architecture

## 🚀 Getting Started

### Prerequisites
- .NET 8.0 SDK
- SQL Server 2019+
- Redis Server
- Visual Studio 2022 / VS Code

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/your-repo/metro-ticketing.git
   cd metro-ticketing
