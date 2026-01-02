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
