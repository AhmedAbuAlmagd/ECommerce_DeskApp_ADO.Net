# Product Management Desktop Application

## Overview

This is a Windows Forms application developed in C# using ADO.NET to interact with a Microsoft SQL Server database.
The application provides a user-friendly interface for user login/registration, product management, and favorite product tracking.
It includes separate functionalities for regular users and administrators, allowing them to manage profiles, products, categories, and favorites efficiently.

## Project Structure

🌟 **Welcome Page:**

- The entry point of the application, directing users to login or register.

🌟 **Login Form:**

- Handles user authentication (login) with credentials stored in the database.

🌟 **Registration Form:**

- Allows new users to register by providing user details (username, password, email, age, address, and role).

🌟 **User Pages:**

- Displays a list of products for users to browse.
- Allows users to add products to their favorites.
- Enables users to manage their profile (update password).

🌟 **Admin Pages:**

- Provides CRUD (Create, Read, Update, Delete) operations for users, products, and categories.
- Allows admins to manage the entire system, including user roles and product categorization.

## Database Design

The application uses a SQL Server database with these tables :-

- Users: Stores user details (UserId, Username, Password, Email, Age, Address, Role — "Admin" or "User").
- Categories: Holds product categories (CategoryId, CategoryName).
- Products: Tracks products with categories (ProductId, ProductName, Price, CategoryId).
- Favorites: Links users to their favorite products (UserId, ProductId).

🌟 **Relationships:**

- Products belong to one category.
- Categories can have many products.
- Users can have many favorite products.
  🌟 The schema is included in the folder (DataBase bak) -> ECommerce_ADO.bak backup

🌟 **Installation and Setup :**

- Clone the repository, open in Visual Studio, and restore packages.
- Use the included database backup (ECommerce_ADO.bak).
- Update the connection string in App.config and build/run the application.

🌟 **Technologies :**

- C#, .NET Framework (Windows Forms), ADO.NET (for database access), SQL Server.

## Explore my project on linkedin

[Project link](https://www.linkedin.com/posts/ahmed-abu-elmagd-308aa220a_csharp-windowsforms-adodotnet-activity-7299157629879136256-QO2J?utm_source=share&utm_medium=member_desktop&rcm=ACoAADUy0TgBAtdEO4y8tsD8VxYNdoBY8W6JEko)
