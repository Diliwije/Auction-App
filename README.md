# AuctionApi (BiddingBoom API)

Server-side API for the Auction/App used by the BiddingBoom front-end. Provides endpoints for managing auction items, bids and users, plus real-time notifications using SignalR.

---

## Tech stack
- .NET 9 (C# 13)
- ASP.NET Core Web API
- Entity Framework Core (SQL Server)
- SignalR for real-time notifications
- MailKit for sending email

## Project layout
- `Program.cs` - app startup and DI registration
- `Hubs/NotificationHub.cs` - SignalR hub (`/notificationHub`)
- `Controllers/AuctionItemsController.cs` - auction endpoints
- `Controllers/UsersController.cs` - admin user management
- `wwwroot/images` - uploaded auction images

## Requirements
- .NET 9 SDK
- SQL Server instance

## Configuration
Add the required settings to `appsettings.json` or environment variables:

- `ConnectionStrings:DefaultConnection` - SQL Server connection string
- `Jwt:Issuer`, `Jwt:Audience`, `Jwt:Key` - JWT settings
- SMTP settings used by `EmailService` (e.g. `Smtp:Host`, `Smtp:Port`, `Smtp:User`, `Smtp:Pass`, `Smtp:From`)
- CORS: frontend origin (default development origin is `http://localhost:5173`)

Tip: use `dotnet user-secrets` or environment variables for secrets like `Jwt:Key` and SMTP credentials.

## Common commands
- Restore and build:

  `dotnet restore`
  `dotnet build`

- Apply EF migrations (from project folder):

  `dotnet ef database update`

- Run locally:

  `dotnet run`

The API will be available at `https://localhost:{port}` and the SignalR hub at `https://localhost:{port}/notificationHub`.

## Important endpoints (summary)
- `GET /api/auctionitems` - list items
- `GET /api/auctionitems/{id}` - get item details
- `POST /api/auctionitems` - create item (requires authenticated `User` role)
- `PUT /api/auctionitems/start-bid/{id}` - start bidding (requires `Admin`)
- `PUT /api/auctionitems/end-auction/{id}` - end auction and notify (requires `Admin`)
- `DELETE /api/auctionitems/{id}` - delete item (requires `Admin`)
- `GET /api/users` - list users (requires `Admin`)
- `DELETE /api/users/{id}` - delete user (requires `Admin`)

## SignalR
Client should connect to `https://{host}/notificationHub` and listen to messages such as `ReceiveBid` and `ReceiveAuction`.

## Notes and troubleshooting
- Ensure `builder.Services.AddSignalR()` is present in `Program.cs` (required for `MapHub`).
- Static images are stored in `wwwroot/images` and served by the app; ensure the folder is writable.
- If using migrations, ensure EF tools are available and the `DefaultConnection` points to an accessible SQL Server.

## Contributing
- Fork, create a feature branch, implement changes and open a PR.

## License
This repository does not include a license file by default. Add a `LICENSE` file if you intend to open-source the project.


# Auction App Frontend

A comprehensive, real-time auction platform built with modern web technologies. This application allows users to bid on items in real-time, manage auctions, and process payments securely.

## 🚀 Features

- **Real-Time Bidding**: Experience live updates on bids immediately using **SignalR**.
- **User Authentication**: Secure Login and Registration functionality for personalized user experiences.
- **Auction Management**: 
  - Browse available auctions in `AuctionList`.
  - Create new auctions via `AddAuction`.
- **Payment Integration**: Seamless payment processing with **PayPal**.
- **Admin Dashboard**: A dedicated dashboard for administrators to manage the platform (`AdminDashboard`).
- **Responsive Design**: Built to work across devices.

## 🛠️ Tech Stack

This project leverages a robust stack of libraries and tools:

- **Core Framework**: [React](https://react.dev/) (v19)
- **Build Tool**: [Vite](https://vitejs.dev/)
- **Routing**: [React Router DOM](https://reactrouter.com/) (v7)
- **State & Data Fetching**: [Axios](https://axios-http.com/)
- **Real-Time Communication**: [@microsoft/signalr](https://www.npmjs.com/package/@microsoft/signalr)
- **Payments**: [@paypal/react-paypal-js](https://www.npmjs.com/package/@paypal/react-paypal-js)
- **Linting**: ESLint

## 📦 Installation & Getting Started

Follow these steps to set up the project locally:

1.  **Clone the repository** (if you haven't already):
    ```bash
    git clone <repository-url>
    ```

2.  **Navigate to the project directory**:
    ```bash
    cd d:/Projects/Auction-App/Auction-App-main/Front-end/auction-frontend
    ```
    *(Adjust the path if you simply opened the folder directly)*

3.  **Install dependencies**:
    ```bash
    npm install
    ```

4.  **Run the development server**:
    ```bash
    npm run dev
    ```

    The app should now be running at `http://localhost:5173` (or the port shown in your terminal).

## 📜 Available Scripts

- `npm run dev`: Starts the development server with Hot Module Replacement (HMR).
- `npm run build`: Builds the app for production.
- `npm run lint`: Runs ESLint to check for code quality issues.
- `npm run preview`: Locally previews the production build.

## 📂 Project Structure

- `src/pages`: Contains main view components (`HomePage`, `Login`, `Register`, `AuctionList`, `AddAuction`, `AdminDashboard`, `PaymentPage`).
- `src/components`: Reusable UI components.
- `src/services`: API services and SignalR connection logic.
- `src/assets`: Static assets like images and icons.

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.
