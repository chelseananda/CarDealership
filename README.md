# Car Dealership Management System
<img width="1009" alt="Screenshot 2025-05-03 at 3 06 15 PM" src="https://github.com/user-attachments/assets/c1f76909-04e1-4ced-bbb6-e25e5e1908a4" />

A robust ASP.NET Core MVC application for managing car dealerships, inventory, and customer relationships.

## Features

- **Car Management**
  - Add, edit, and remove cars from inventory
  - Track car details including name, serial number, make year, and pricing
  - Automatic validation for car details (serial numbers, make year, pricing)
  - Car status tracking (new/used based on make year)

- **Dealer Management**
  - Dealer profiles and inventory management
  - Track dealer-specific car listings
  - Dealer authentication and authorization

- **Customer Management**
  - Customer registration and profiles
  - Customer interaction tracking
  - Secure authentication system

- **Memo System**
  - Internal communication system
  - Track and manage customer interactions
  - Recent memos display on dashboard

## Technology Stack

- **Backend**
  - ASP.NET Core MVC
  - Entity Framework Core
  - C# 11.0
  - SQL Database (via Entity Framework)

- **Frontend**
  - Razor Views
  - Bootstrap 5
  - JavaScript/jQuery
  - HTML5/CSS3

## Prerequisites

- .NET 7.0 SDK or later
- SQL Server (or compatible database)
- Visual Studio 2022 or VS Code with C# extensions

## Getting Started

1. **Clone the Repository**
   ```bash
   git clone [repository-url]
   cd CarDealership
   ```

2. **Database Setup**
   - Update connection string in `appsettings.json`
   - Run Entity Framework migrations:
   ```bash
   dotnet ef database update
   ```

3. **Run the Application**
   ```bash
   dotnet run
   ```
   Navigate to `https://localhost:5001` or `http://localhost:5000`

## Project Structure

- **/Controllers** - MVC Controllers handling business logic
- **/Models** - Data models and business logic
  - Entity models (Car, Dealer, Customer)
  - ViewModels for form handling
  - Repository implementations
- **/Views** - Razor views for the user interface
- **/wwwroot** - Static files (CSS, JavaScript, images)

## Features in Detail

### Car Management
- Comprehensive car details tracking
- Validation rules for car data:
  - Serial numbers must be uppercase alphanumeric with hyphens
  - Make year validation (1900-2100)
  - Price validation
  - Automatic new/used car classification

### Authentication & Authorization
- Secure user authentication
- Role-based authorization
- Remember me functionality
- Email verification

### Data Validation
- Server-side validation
- Client-side validation
- Custom validation attributes
- Model state validation

## Contributing

1. Fork the repository
2. Create a feature branch
3. Commit your changes
4. Push to the branch
5. Create a Pull Request

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Support

For support, please open an issue in the repository or contact the development team.
