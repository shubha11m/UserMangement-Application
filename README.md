# VB.NET Login Application

This is a Windows Forms application built with VB.NET that provides a login page and user dashboard with user details.

## Features

### Login Page
- Username and password input fields
- Input validation (minimum 3 characters)
- Error message display
- Login and Exit buttons

### Dashboard
- Welcome message with username
- User information display:
  - Email
  - Phone Number
  - Address
  - Join Date
- Edit functionality to update user information
- Save changes feature
- Logout button to return to login page

## Sample Users (for Demo)

You can log in with any of these sample usernames (password can be anything with 3+ characters):

1. **admin**
   - Email: admin@example.com
   - Phone: +1-800-111-1111
   - Address: 100 Admin Street, New York, NY 10001

2. **john**
   - Email: john.doe@example.com
   - Phone: +1-800-222-2222
   - Address: 200 John Avenue, Los Angeles, CA 90001

3. **jane**
   - Email: jane.smith@example.com
   - Phone: +1-800-333-3333
   - Address: 300 Jane Road, Chicago, IL 60601

## Project Structure

```
VBNetLoginApp/
├── VBNetLoginApp.vbproj      # Project file
├── Program.vb                  # Entry point
├── LoginForm.vb                # Login form implementation
├── DashboardForm.vb            # Dashboard form implementation
├── User.vb                     # User model class
└── UserDatabase.vb             # Database helper class
```

## Building and Running

### Prerequisites
- Visual Studio 2022 or later (Community, Professional, or Enterprise)
- .NET 6.0 SDK or later
- Windows Forms Desktop Development workload

### Steps

1. Open Visual Studio
2. Open the solution file: `VBNetLoginApp.sln`
3. Build the solution (Ctrl+Shift+B)
4. Run the application (F5)
5. Log in with any sample username and a password of 3+ characters

## Usage

1. **Login**
   - Enter a username (e.g., admin, john, or jane)
   - Enter a password (minimum 3 characters)
   - Click "Login" to proceed to the dashboard
   - Click "Exit" to close the application

2. **Dashboard**
   - View user information
   - Click "Edit" to modify user details
   - Click "Save" to save changes
   - Click "Logout" to return to the login page

## Future Enhancements

- Integration with SQL Server database
- Password hashing and encryption
- User registration functionality
- Forgot password feature
- Role-based access control
- Session management
- Audit logging
- Two-factor authentication

## Technology Stack

- **Language**: VB.NET
- **Framework**: .NET 6.0
- **UI**: Windows Forms
- **IDE**: Visual Studio 2022

