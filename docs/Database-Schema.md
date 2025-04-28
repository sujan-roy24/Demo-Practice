
# 📄 Database Schema
This document describes the database design for the QR Code Metro Based Ticketing System.
It includes an ER diagram, table descriptions, and important indexes and constraints.

## 1. ER Diagram

![](Images/er-diagram.PNG)

## 2. Table Descriptions

Table	Description
Users	Stores passenger and admin user information including authentication data.
Tickets	Stores ticket details including journey info, fare, timestamps, and QR Code metadata.
Stations	Stores metro station information like station name, code, and location.
Journeys	(Optional, depending on design) Tracks completed journeys linking users, tickets, and stations.
➔ Users Table

Column	Type	Details
Id	GUID (Primary Key)	Unique user ID
FirstName	NVARCHAR(100)	First name
LastName	NVARCHAR(100)	Last name
Email	NVARCHAR(255)	Unique email address (with index)
PasswordHash	NVARCHAR(MAX)	Encrypted password
Role	NVARCHAR(20)	"Admin" / "Passenger"
CreatedAt	DATETIME	Registration date
LastSeen	DATETIME	Last online activity
➔ Stations Table

Column	Type	Details
Id	INT (Primary Key)	Unique station ID
Name	NVARCHAR(150)	Station name
Code	NVARCHAR(10)	Short code (e.g., "ST01")
Location	NVARCHAR(255)	Optional location address
➔ Tickets Table

Column	Type	Details
Id	GUID (Primary Key)	Unique ticket ID
UserId	GUID (Foreign Key)	Reference to Users table
FromStationId	INT (Foreign Key)	Starting station (Stations table)
ToStationId	INT (Foreign Key)	Ending station (Stations table)
QRCodeId	NVARCHAR(255)	Unique code for QR validation
IssueTime	DATETIME	When the ticket was issued
EntryTime	DATETIME (Nullable)	When the user entered (optional)
ExitTime	DATETIME (Nullable)	When the user exited (optional)
Fare	DECIMAL(10,2)	Ticket fare amount
Status	NVARCHAR(20)	"Issued", "Used", "Expired"
## 3. Indexes & Constraints
### ✅ Primary Keys:

Users.Id

Stations.Id

Tickets.Id

### ✅ Foreign Keys:

Tickets.UserId → Users.Id

Tickets.FromStationId → Stations.Id

Tickets.ToStationId → Stations.Id

### ✅ Indexes:

Users.Email — Unique Index for fast login.

Tickets.QRCodeId — Unique Index for secure QR code validation.

Tickets.Status — Non-Clustered Index for fast filtering ("Issued", "Used", etc.).

### ✅ Constraints:

Referential integrity between Tickets, Users, and Stations.

Cascading delete disabled to avoid accidental data loss.

## ✅ Summary
Normalized database design (no redundancy).

Optimized for high read/write performance (Redis fallback).

Indexes boost critical operations (QR code lookup, login).

Secure architecture with encryption and authentication.

