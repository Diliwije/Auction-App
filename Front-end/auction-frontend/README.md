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
