
# 🚂 Railway Management System - Phase 2

A comprehensive Windows Forms application built with **C#** and **Oracle Database** designed to handle train bookings, passenger management, and administrative reporting. This project was developed as part of a collaborative effort by **Team 19**.

## 🚀 Key Features

### **1. Connected Mode (Requirement A)**
*   **User Authentication:** Secure login system using bind variables to verify passenger credentials from the `PASSENGERS` table.
*   **Ticket Booking:** Real-time seat reservation system that updates seat status and calculates total fees based on travel class.
*   **Dynamic Search:** Search functionality for available trains based on source and destination stations.
*   **Stored Procedures:** Integration of PL/SQL procedures (e.g., `GetAvailableSeatCount`) to fetch real-time data directly from the Oracle schema.

### **2. Disconnected Mode (Requirement B)**
*   **Administrative Dashboard:** A dedicated interface for managing train schedules using `OracleDataAdapter` and `DataSet`.
*   **Batch Updates:** Administrators can search for trains by source station, modify data within a `DataGridView`, and save all changes back to the database in a single batch using `OracleCommandBuilder`.

### **3. Advanced Reporting (Requirement C)**
*   **Grouped Reports:** Crystal Reports integration that organizes train data grouped by source stations for better administrative overview.
*   **Parameter-Driven Reports:** Custom reports that allow users to filter data dynamically using multiple parameters selected through the UI.

### **4. Interactive GUI (Requirement D)**
*   **Main Control Hub:** A centralized form featuring a `MenuStrip` that acts as the entry point to all application modules, including booking, administration, and reports.

## 🛠️ Technical Stack
*   **Language:** C# (.NET Framework)
*   **Database:** Oracle Database (scott/tiger schema)
*   **Reporting:** Crystal Reports
*   **Architecture:** ADO.NET (Connected & Disconnected layers)


---
*Last Updated: May 1, 2026*
