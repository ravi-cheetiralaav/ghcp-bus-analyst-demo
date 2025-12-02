# Quick Start Guide

## Building and Running the Expense Tracker Application

### Step 1: Restore Dependencies
Open PowerShell in the project directory and run:
```powershell
dotnet restore ExpenseTracker\ExpenseTracker.vbproj
```

### Step 2: Build the Project
```powershell
dotnet build ExpenseTracker\ExpenseTracker.vbproj --configuration Release
```

### Step 3: Run the Application
```powershell
dotnet run --project ExpenseTracker\ExpenseTracker.vbproj
```

Or open in Visual Studio:
```powershell
start ExpenseTracker.sln
```
Then press F5 to run.

## First Login

1. Click "New User? Register"
2. Create a username (min 3 characters)
3. Create a password (min 6 characters)
4. Login with your credentials

## Adding Your First Expense

1. Click "Add Expense" button
2. Fill in:
   - Description (e.g., "Grocery shopping")
   - Amount (e.g., 125.50)
   - Currency (default: USD)
   - Category (select from dropdown)
   - Date
   - Check "Tax Deductible" if applicable
   - Check "Recurring Expense" if it repeats
   - Select frequency if recurring
3. Click "Save"

## Viewing Summaries

1. Click "View Summaries" button
2. Choose tab:
   - **Monthly**: Select month/year
   - **Calendar Year**: Select year
   - **Financial Year**: Select FY (July-June)
3. Click "Generate" button

## Key Features to Try

### Recurring Expenses
- Add a monthly rent payment
- Mark it as "Recurring" with "Monthly" frequency
- View monthly or yearly summary - it will appear in each month automatically!

### Multi-Currency
- Add expenses in different currencies (USD, EUR, GBP, etc.)
- Summaries will group by currency

### Tax Tracking
- Mark business expenses as "Tax Deductible"
- View summaries to see total deductible amount

### Filters & Search
- Use date range filters
- Filter by category
- Search by description keyword
- Filter recurring/non-recurring
- Check "Expand Recurring Items" to see all instances

## Database Location

Your data is stored at:
```
C:\Users\{YourUsername}\AppData\Roaming\ExpenseTracker\ExpenseTracker.db
```

## Common Tasks

### Change Your Password
1. Settings → Change Password section
2. Enter current password
3. Enter new password
4. Confirm new password
5. Click "Change Password"

### Set Default Currency
1. Settings → Preferences
2. Select default currency
3. Click "Save Settings"

### Edit an Expense
1. Select expense in grid
2. Click "Edit Expense" (or double-click row)
3. Make changes
4. Click "Save"

### Delete an Expense
1. Select expense in grid
2. Click "Delete"
3. Confirm deletion

## Tips

- **Financial Year**: Runs July 1 - June 30 (e.g., FY 2024-25 = Jul 1, 2024 - Jun 30, 2025)
- **Recurring Expenses**: Store once, appear automatically in reports for the entire period
- **Categories**: 12 predefined categories cover most expense types
- **Date Filters**: Use "From" and "To" dates to filter expenses in dashboard
- **Statistics**: Bottom of dashboard shows total expenses, total amount, and tax-deductible amount

## Troubleshooting

**Can't login?**
- Make sure you registered first
- Check Caps Lock
- Password is case-sensitive

**No expenses showing?**
- Check date filter range
- Click "Clear" to reset all filters

**Summary is empty?**
- Make sure you have expenses in the selected period
- Check that recurring expenses have a start date in the period

## Need Help?

Refer to the main README.md for detailed documentation and troubleshooting.
