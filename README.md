# Expense Tracker Desktop Application

A comprehensive desktop application built with VB.NET for managing personal and business expenses with support for recurring payments, multiple currencies, and tax-deductible tracking.

## Features

### 1. User Authentication
- Secure login with username and password
- Password hashing using BCrypt
- User registration with validation
- Session management
- Change password functionality

### 2. Expense Management
- Add, edit, and delete expenses
- Track expenses with the following attributes:
  - Description
  - Amount
  - Currency (USD, EUR, GBP, AUD, CAD, INR, JPY, CNY)
  - Category (12 predefined categories)
  - Date
  - Tax-Deductible flag
  - Recurring payment flag
  - Recurring frequency (Weekly, Fortnightly, Monthly, Quarterly, Annually)

### 3. Recurring Expenses
- Automatic expansion of recurring expenses in reports
- Support for multiple frequencies
- Visual indication of recurring vs non-recurring expenses

### 4. Search & Filtering
- Filter by date range
- Filter by currency
- Filter by category
- Filter by tax-deductible status
- Filter by recurring/non-recurring
- Keyword search in descriptions
- Option to expand recurring expenses in the list

### 5. Summary Reports
Three types of comprehensive summaries:

#### Monthly Summary
- Select any month/year
- View totals by currency
- Category breakdown
- Tax-deductible totals
- Recurring vs non-recurring breakdown

#### Calendar Year Summary
- Select any calendar year
- Annual totals by currency
- Category-wise analysis
- Tax-deductible summary

#### Financial Year Summary (July-June)
- Select financial year (e.g., FY 2024-25)
- FY totals by currency
- Category breakdown
- Tax-deductible analysis
- Complete recurring expense instances

### 6. Settings
- Change password
- Set default currency
- User preferences

## Technical Architecture

### Database
- **SQLite** database stored in user's AppData folder
- Tables:
  - Users (authentication and user management)
  - Expenses (expense records)
  - Categories (expense categories)
  - Settings (user preferences)

### Security
- Passwords hashed using **BCrypt.Net**
- SQL parameterization to prevent injection
- Session-based authentication

### Technologies
- **VB.NET** (.NET 8.0)
- **Windows Forms** for UI
- **SQLite** for data storage
- **BCrypt.Net** for password hashing

## Installation & Setup

### Prerequisites
- Windows OS
- .NET 8.0 SDK or later
- Visual Studio 2022 (or later) with VB.NET support

### Build Instructions

1. **Open the solution**
   ```powershell
   cd "c:\Users\ravi.cheetirala\OneDrive - Avanade\Work\GHCP ACM\ATO\ghcp-bus-analyst-demo"
   start ExpenseTracker.sln
   ```

2. **Restore NuGet packages**
   - In Visual Studio: Right-click solution → Restore NuGet Packages
   - Or via command line:
   ```powershell
   dotnet restore
   ```

3. **Build the solution**
   ```powershell
   dotnet build ExpenseTracker\ExpenseTracker.vbproj
   ```

4. **Run the application**
   ```powershell
   dotnet run --project ExpenseTracker\ExpenseTracker.vbproj
   ```

### CLI Build & Run (copy-paste)

If you prefer to run the commands exactly as used in the project CI/logging, use these (they redirect output and can be copied into PowerShell):

```powershell
dotnet build ExpenseTracker\ExpenseTracker.vbproj 2>&1
dotnet run --project ExpenseTracker\ExpenseTracker.vbproj
```

## First-Time Usage

1. **Launch the application** - You'll see the login screen
2. **Click "New User? Register"** to create your first account
3. **Enter a username** (minimum 3 characters)
4. **Enter a password** (minimum 6 characters)
5. **Confirm password** and click Register
6. **Login** with your new credentials

## Database Location

The SQLite database is automatically created at:
```
C:\Users\{YourUsername}\AppData\Roaming\ExpenseTracker\ExpenseTracker.db
```

## Project Structure

```
ExpenseTracker/
├── Data/
│   └── DatabaseHelper.vb          # Database operations and schema
├── Models/
│   ├── User.vb                    # User entity
│   ├── Expense.vb                 # Expense entity
│   ├── Category.vb                # Category entity
│   ├── AppSettings.vb             # Settings entity
│   └── Enums.vb                   # Enumerations
├── Services/
│   ├── AuthenticationService.vb   # Login/registration logic
│   ├── ExpenseService.vb          # Expense CRUD and business logic
│   ├── CategoryService.vb         # Category operations
│   └── SettingsService.vb         # Settings management
├── Forms/
│   ├── LoginForm.vb               # Login interface
│   ├── RegisterForm.vb            # Registration interface
│   ├── MainDashboard.vb           # Main application dashboard
│   ├── ExpenseForm.vb             # Add/Edit expense form
│   ├── SummaryForm.vb             # Summary reports
│   └── SettingsForm.vb            # User settings
├── Program.vb                     # Application entry point
└── ExpenseTracker.vbproj          # Project file
```

## Default Categories

The application includes these predefined categories:
- Food & Dining
- Transportation
- Utilities
- Healthcare
- Entertainment
- Shopping
- Education
- Housing
- Insurance
- Business
- Travel
- Other

## Key Features Explained

### Recurring Expenses
When you mark an expense as recurring:
1. The original expense is stored once in the database
2. When generating reports, the system automatically calculates instances based on:
   - Start date (expense date)
   - End date (report period)
   - Frequency (weekly, fortnightly, monthly, quarterly, annually)
3. This ensures accurate reporting without data duplication

### Financial Year Calculation
- FY runs from July 1 to June 30
- FY 2024-25 = July 1, 2024 to June 30, 2025
- Reports automatically calculate all instances of recurring expenses within the FY

### Multi-Currency Support
- Track expenses in different currencies
- Summaries group by currency
- No automatic conversion (each currency reported separately)
- Select default currency in Settings

## Troubleshooting

### Database Issues
If you encounter database errors:
1. Close the application
2. Delete the database file at: `%AppData%\ExpenseTracker\ExpenseTracker.db`
3. Restart the application (it will recreate the database)

### Build Errors
If you get missing reference errors:
```powershell
dotnet restore
dotnet clean
dotnet build
```

## Future Enhancements (Not in MVP)

- Export reports to PDF/Excel
- Currency conversion with exchange rates
- Budget tracking and alerts
- Expense attachments (receipts)
- Multi-user with admin panel
- Data backup and restore
- Charts and visualizations
- Mobile companion app
- Cloud sync

## License

This is a demonstration/educational project.

## Support

For issues or questions, please create an issue in the repository.
