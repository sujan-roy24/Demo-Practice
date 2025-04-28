
#  ⚙️System Design

The QR Code Metro Ticketing System is built to provide fast and secure metro entry/exit using QR codes, leveraging .NET 8, Redis, and SQL Server.

## 🎨System Architecture

![Alt text](Images/system-architecture-one.svg)

## 📈 ER Diagram

![Alt](Images/scahema-diagram.png)


### 🧩Database Table Descriptions

| Table           | Description                                                                                     |
|----------------|-------------------------------------------------------------------------------------------------|
| Users          | Stores passenger information including authentication and profile data        |
| Admins         | Stores admin credentials and access logs.                                              |
| Stations       | Stores metro station information like name, address, coordinates, and display order.             |
| StationDistances | Stores distance data between two stations for fare calculation.                               |
| Tickets        | Stores ticket details including journey info, fare, QR code metadata, and ticket status.         |
| Trips          | Stores trip records including entry/exit stations, timings, fare, and trip status.               |
| Wallets        | Stores user wallet balances for fare payment and ticket purchases.                               |
| Transactions   | Stores wallet transaction records like top-ups, fare deductions, and penalties.                  |
| SystemSettings | Stores system-wide settings like fare rates, ticket validity, and penalty fees.                  |


## 🎟️ Ticket Purchase Flow

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

