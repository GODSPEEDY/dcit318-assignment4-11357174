# DCIT 318: Programming II - Assignment 4  
## Medical & Pharmacy Management Systems

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)  
![.NET Framework](https://img.shields.io/badge/.NET_Framework-5C2D91?style=for-the-badge&logo=.net&logoColor=white)  
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)  
![Windows Forms](https://img.shields.io/badge/Windows_Forms-007ACC?style=for-the-badge&logo=windows&logoColor=white)

This repository contains the solution for **DCIT 318: Programming II - Assignment 4**, consisting of two Windows Forms applications that interact with SQL Server databases using **ADO.NET** and **Stored Procedures**.

---

## Table of Contents

- [Overview](#overview)
- [Question 1: Medical Appointment Booking System](#question-1-medical-appointment-booking-system)
  - [Database Design](#database-design)
  - [Features](#features)
  - [Technologies Used](#technologies-used)
- [Question 2: Pharmacy Inventory & Sales System](#question-2-pharmacy-inventory--sales-system)
  - [Database Design](#database-design-1)
  - [Stored Procedures](#stored-procedures)
  - [Features](#features-1)
  - [Technologies Used](#technologies-used-1)
- [How to Run the Project](#how-to-run-the-project)
- [Screenshots](#screenshots)
- [Author](#author)

---

## Overview

This assignment demonstrates proficiency in **Windows Forms**, **ADO.NET**, **SQL Server**, and **event-driven programming**. Two full-featured desktop applications were developed:

1. **Medical Appointment Booking System**
2. **Pharmacy Inventory and Sales Management System**

Both applications use **parameterized queries**, **stored procedures**, **DataGridView binding**, and **robust exception handling** to ensure secure and efficient database interactions.

---

## Question 1: Medical Appointment Booking System

A Windows Forms application that allows patients to book, view, modify, and delete medical appointments using a SQL Server backend.

### Database Design

**Database Name:** `MedicalDB`

#### Tables:
```sql
Doctors
- DoctorID (int, PK)
- FullName (varchar)
- Specialty (varchar)
- Availability (bit)

Patients
- PatientID (int, PK)
- FullName (varchar)
- Email (varchar)

Appointments
- AppointmentID (int, PK)
- DoctorID (int, FK)
- PatientID (int, FK)
- AppointmentDate (datetime)
- Notes (varchar)
