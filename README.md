"# Auction-App" 

# 🎉 BiddingBoom – Online Auction Platform

![License](https://img.shields.io/badge/license-MIT-blue.svg)
![Built With](https://img.shields.io/badge/built%20with-.NET%20Core%20&%20React-blueviolet)

**BiddingBoom** is a full-stack online auction platform built with **ASP.NET Core Web API** and **React + Vite**, designed to provide a secure, real-time, and automated bidding experience. This project was developed as part of a university capstone at NSBM Green University.

🎯 Live demo: [https://biddingboom.netlify.app](https://biddingboom.netlify.app)  
🔧 Backend API: `https://localhost:7252/api/`  
🎥 Watch the demo video → [Demo Video Link](#demo-video)

---

## ✨ Features

✅ **User Authentication**  
- Email-based login with JWT tokens  
- Role-based access: **User** and **Admin**

✅ **Real-Time Bidding**  
- Instant bid updates via **SignalR**  
- No page refresh needed

✅ **Automated Auction Lifecycle**  
- Admin sets start/end time  
- Background service auto-closes auctions  
- Winner declared automatically

✅ **Email Notifications**  
- Winner receives "You Won!" email  
- Other bidders notified via SendGrid

✅ **Secure Payment Gateway**  
- Only winner sees **PayPal Sandbox** button  
- Simulated payment flow for demo

✅ **Admin Dashboard**  
- Manage users, items, and bid timing  
- View winners and closed auctions

✅ **Responsive UI**  
- Clean design using React & Tailwind CSS  
- Works on desktop and mobile

---

## 🛠️ Tech Stack

| Layer | Technology |
|------|-----------|
| **Frontend** | React, Vite, JavaScript, Tailwind CSS |
| **Backend** | ASP.NET Core Web API, C# |
| **Database** | SQL Server, Entity Framework Core |
| **Authentication** | JWT, Claims-based Authorization |
| **Real-Time** | SignalR |
| **Email** | SendGrid |
| **Payment** | PayPal Sandbox |
| **Deployment** | Netlify (Frontend), Local/IIS (Backend) |

---

## 🖼️ Screenshots

### 🏠 Home Page
![Home Page](screenshots/home.png)

### 💰 Real-Time Bidding
![Bidding](screenshots/bidding.png)

### 🏆 Winner Declared
![Winner](screenshots/winner.png)

### 👨‍💼 Admin Dashboard
![Admin](screenshots/admin.png)

> _Note: Add actual screenshots to `/screenshots` folder_

---

## ▶️ Demo Video

🎬 [Watch Full Demo Video](https://drive.google.com/file/d/your-video-id/view)  
A 5-minute walkthrough showing:
- User registration & login
- Admin creating an auction
- Real-time bidding
- Auto-close & winner declaration
- Email notifications
- Winner payment via PayPal sandbox

---

## 🚀 Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/)
- SQL Server or LocalDB
- Visual Studio / VS Code

### 1. Clone the Repository
```bash
git clone https://github.com/yourusername/BiddingBoom.git
cd BiddingBoom
```

### 2. Run Backend
```bash
cd AuctionApi
dotnet restore
dotnet build
dotnet run
```
👉 Backend runs on `https://localhost:7252`

### 3. Run Frontend
```bash
cd ../auction-frontend
npm install
npm run dev
```
👉 Frontend runs on `http://localhost:5173`

### 4. Database Setup
Run migrations:
```bash
dotnet ef database update
```
Or seed sample data manually.

---

## 🔐 Environment Variables

Create `.env` in frontend and backend:

### `AuctionApi/.env` (use in `appsettings.json`)
```json
"Jwt": {
  "Key": "your-super-secret-jwt-key",
  "Issuer": "auctionapi",
  "Audience": "auctionusers"
}
```

### `auction-frontend/.env`
```env
VITE_API_BASE_URL=http://localhost:7252/api
```

---

## 👥 Team Members & Contributions

| Name | Role | Key Contributions |
|------|------|------------------|
| DTD Wijerathna | Backend Lead | Auth, SignalR, Bid Logic, File Architecture |
| Member 2 | DB Specialist | EF Migrations, Schema Optimization |
| Member 3 | Frontend Dev | UI Components, State Management, Routing |
| Member 4 | UI Designer | Admin Dashboard, Responsive Layout |
| Member 5 | Automation Engineer | Auto-End Service, PayPal Integration |
| Member 6 | QA & Security | Endpoint Security, Postman Testing |
| Member 7 | Report Writer | Email Integration, Final Report |
| Member 8 | Frontend Integrator | SignalR Frontend, Form Validation |

---

## 📜 License

This project is licensed under the **MIT License** – see the [LICENSE](LICENSE) file for details.

---

## 🙌 Acknowledgments

- NSBM Green University  
- Microsoft .NET Documentation  
- SendGrid & PayPal Developer Platforms  
- Stack Overflow Community

---

🚀 **Built with ❤️ by the BiddingBoom Team**  
📧 Contact: biddingboom@gmail.com
```

---

## 📂 Folder Structure Suggestion

```
BiddingBoom/
├── AuctionApi/               # Backend (.NET Core)
├── auction-frontend/         # Frontend (React + Vite)
├── screenshots/              # App images
├── docs/                     # Reports, diagrams
├── LICENSE
├── README.md
└── contribution.docx
```

---


- Animated GIFs instead of screenshots

You're ready to impress! 🚀
