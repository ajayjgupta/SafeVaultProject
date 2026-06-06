# 📄 SafeVault Secure Web Application

## 📌 Project Overview

SafeVault is a secure web application developed to protect sensitive user data such as credentials and financial records. This project demonstrates secure coding practices, authentication and authorization mechanisms, and protection against common web vulnerabilities like SQL Injection and Cross-Site Scripting (XSS).

---

## ✅ Project Checklist

✔ Created a GitHub-ready project repository  
✔ Used Copilot to generate secure input validation and SQL injection prevention  
✔ Implemented authentication with secure password hashing (BCrypt)  
✔ Implemented Role-Based Access Control (RBAC)  
✔ Identified and fixed SQL Injection and XSS vulnerabilities  
✔ Generated and executed security tests  
✔ Included summary of vulnerabilities, fixes, and Copilot assistance  

---

## 🔐 Security Features Implemented

### ✅ Input Validation & Sanitization
- Inputs validated using regular expressions  
- Malicious HTML/script tags removed  
- Output encoded using HtmlEncode to prevent XSS  

---

### ✅ SQL Injection Prevention
- Replaced unsafe string concatenation  
- Used parameterized queries for database operations  

---

### ✅ Authentication System
- Password hashing using BCrypt  
- Secure comparison for password verification  
- No plaintext password storage  

---

### ✅ Role-Based Authorization (RBAC)
- Roles implemented: Admin and User  
- Admin-only access control enforced  
- Unauthorized users blocked from restricted features  

---

## ⚠️ Vulnerabilities Identified

### 🔴 SQL Injection
- Cause: String concatenation in SQL queries  
- Risk: Attackers could manipulate database or bypass authentication  

### 🔴 Cross-Site Scripting (XSS)
- Cause: Rendering unsanitized user input  
- Risk: Malicious scripts executed in browser  

---

## 🔧 Fixes Applied

- SQL Injection → Fixed using parameterized queries  
- XSS → Fixed using input sanitization and HTML encoding  
- Input Validation → Added regex-based validation  

---

## 🧪 Testing & Verification

Tests were implemented using NUnit to simulate attack scenarios:

- SQL Injection attack test  
- XSS attack test  
- Invalid input validation test  
- Password hashing test  
- Authorization (admin/user) test  

✅ All tests passed successfully  

---

## 🤖 Role of Microsoft Copilot

Microsoft Copilot helped in:

- Generating secure coding patterns  
- Suggesting parameterized queries  
- Providing input validation strategies  
- Assisting with password hashing implementation  
- Generating test cases for vulnerabilities  
- Helping debug insecure code  

---

## ▶️ How to Run the Project (VS Code)

### ✅ Requirements
- .NET SDK installed  
- VS Code with C# extension  

---

### ✅ Steps

Run the following commands:

    cd SafeVaultProject
    dotnet new nunit
    dotnet add package BCrypt.Net-Next
    dotnet add package NUnit
    dotnet add package NUnit3TestAdapter
    dotnet add package Microsoft.NET.Test.Sdk
    dotnet build
    dotnet test

---

## 📂 Project Structure

    SafeVaultProject/
     ├── InputSecurity.cs
     ├── PasswordHasher.cs
     ├── Roles.cs
     ├── User.cs
     ├── AuthService.cs
     ├── AuthorizationService.cs
     ├── Tests.cs
     ├── README.md

---

## ✅ Final Outcome

✔ Application secured against SQL Injection  
✔ XSS vulnerabilities eliminated  
✔ Authentication and RBAC implemented  
✔ Security tests verified and passed  

---

## 🚀 Future Improvements

- Add JWT-based authentication  
- Implement multi-factor authentication (MFA)  
- Add logging and monitoring  
- Deploy as full web application  

---

## ✅ Project Ready for Submission 🎉