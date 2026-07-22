# Luxera Hotel Management System (HMS)

A comprehensive, enterprise-grade Hotel Management System designed to streamline hospitality operations. This project showcases a robust corporate architecture, utilizing a standalone backend services layer decoupled from a desktop client management interface.

---

##  Architecture & Tech Stack

The system is built using a **Layered Architecture** adhering to clean code practices and separation of concerns.

* **Backend (REST API):** Developed with **ASP.NET Web API** to handle core business logic, secure data transactions, and expose RESTful endpoints.
* **Frontend (Desktop Client):** A rich, responsive UI built using Windows Forms (**WinForms**) in **C#**, communicating asynchronously with the Web API.
* **Database & Storage:** **SQL Server (T-SQL)** handles relational data persistence, optimized with stored procedures and performance-focused schemas.

---

##  Key Features

* ** Advanced Room Management:** Full control over room inventory, types, pricing tiers, and real-time maintenance/cleaning status tracking.
* ** Dynamic Reservation System:** Seamless booking engine managing check-ins, check-outs, and scheduling conflicts.
* ** Integrated Gantt Chart:** Visual interactive timeline for rooms and reservations, providing receptionists with instant operational oversight.
* ** Comprehensive Client Management:** Centralized guest profiling, historical logs, and billing management.
* ** Secure REST API:** Fully decoupled endpoints ensuring scalability for future web or mobile client migrations.

---

##  System Design & Database Schema

The core design centers around modern database management principles and strategic system modularity:
* **Data Integrity:** Implemented cascading rules, explicit data types, and transactional safety to prevent double-booking.
* **Separation of Concerns:** Business Logic Layer (BLL), Data Access Layer (DAL), and the Presentation Layer operate independently to guarantee maintainability.

---

##  Getting Started

### Prerequisites
* .NET SDK (compatible with Visual Studio 2022)
* SQL Server Management Studio (SSMS)
