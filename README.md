# Budget App

A C# Windows Forms desktop application for tracking personal income, expenses, and budget limits.

## Features
- Create and manage income and expense categories
- Add and review transactions with amount, date, category, and description
- Create period-based budgets
- Assign category-specific spending limits within a budget period
- View Dashboard summaries include:
    - Total Income
    - Total Expenses
    - Net Total
    - Period Limit
    - Remaining Budget
    - Table with specific Category Budgets

## Tech Stack
- C#
- Windows Forms
- .NET
- Object-oriented design
- Microsoft EF Core with SQLite

## Project Structure
- `Models/` – application data models
- `Data/` – Database management
- `CategoriesForm` – category management
- `TransactionsForm` – transaction entry and viewing
- `PeriodBudgetsForm` – budget period setup
- `CategoryBudgetsForm` – category spending limits
- `MainMenuForm` - dashboard for viewing periodic stats

## Why I Built This
I originally built this project for school, then continued developing it into a practical budgeting application that I can use in everyday life while strengthening my C# and desktop application development skills.

## Planned Improvements
- Periodic reports and charts
- Recurring transactions

## How to Run
1. Clone the repository
2. Open the solution in Visual Studio
3. Build and run the project

## License
This project is licensed under the MIT License.
