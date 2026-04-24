# Budget App

A C# Windows Forms desktop application for tracking personal income, expenses, and budget limits.

## Features
- Create and manage income and expense categories
- Add and review transactions with amount, date, category, and description
- Create period-based budgets
- Assign category-specific spending limits within a budget period

## Tech Stack
- C#
- Windows Forms
- .NET
- Object-oriented design
- In-memory data management using service classes

## Project Structure
- `Models/` – application data models
- `Services/` – shared in-memory application data
- `CategoriesForm` – category management
- `TransactionsForm` – transaction entry and viewing
- `PeriodBudgetsForm` – budget period setup
- `CategoryBudgetsForm` – category spending limits

## Why I Built This
I originally built this project for school, then continued developing it into a practical budgeting application that I can use in everyday life while strengthening my C# and desktop application development skills.

## Planned Improvements
- Save and load data from files or a database
- Dashboard for totals and spending summaries
- Monthly reports and charts
- Recurring transactions
- Budget alerts when limits are exceeded

## How to Run
1. Clone the repository
2. Open the solution in Visual Studio
3. Build and run the project

## License
This project is licensed under the MIT License.
