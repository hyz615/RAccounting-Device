

# Accounting App

## Project Overview

The Accounting App is a simple and user-friendly application designed to help users track and manage their personal finances. It supports recording daily expenses and income, and provides basic statistics to help users understand their financial status better.

## Features

- **Record Expenses and Income**: Users can add, edit, and delete records of expenses and income.
- **Category Management**: Supports categorizing expenses and income for better financial analysis.
- **Data Storage**: All data is stored in an SQLite database to ensure persistence.
- **Date Selection**: Use the intuitive MonthCalendar control to select and record dates.
- **Basic Statistics**: Displays total expenses, total income, and balance.

## Installation and Setup

1. **Clone the Repository**

   ```bash[
   git clone https://github.com/yourusername/accounting-app.git](https://github.com/hyz615/RAccounting-Device.git
   ```

2. **Install Dependencies**

   Ensure you have the .NET SDK installed. Then, run the following command in the project root directory:

   ```bash
   dotnet restore
   ```

3. **Build the Project**

   ```bash
   dotnet build
   ```

4. **Run the Application**

   ```bash
   dotnet run
   ```

## Usage

1. After starting the application, you will see buttons for “Add Expense” and “Add Income” on the main screen.
2. Click on “Add Expense” or “Add Income” to enter relevant financial information.
3. Use the MonthCalendar control to select dates.
4. Data will be saved to the SQLite database, and you can view recorded transactions and statistics from the main interface.



## Contributing

If you wish to contribute to this project, please start by creating an issue to discuss your ideas and then submit a pull request. We welcome improvements and bug fixes!


## Contact

For any questions or suggestions, please reach out via [issues](https://github.com/hyz615/RAccounting-Device/issues).
