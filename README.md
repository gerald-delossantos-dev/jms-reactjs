# DVM Vircon JMS Dashboard - React + .NET 10 Web API

A deployment-ready sample Job Management System dashboard for BIM engineering teams.

## Tech Stack
- React 19 + TypeScript + Vite
- CSS responsive dashboard layout
- .NET 10 Web API sample backend
- API-driven dashboard data

## Run Backend
```bash
cd server
dotnet restore
dotnet run
```
API runs at `https://localhost:7055` or `http://localhost:5055`.

## Run Frontend
```bash
cd client
npm install
npm run dev
```
Frontend runs at `http://localhost:5173`.

## Production Build
```bash
cd client
npm run build
```

## API Endpoint
```http
GET /api/dashboard
```

## Notes
- Update `client/.env.production` when deploying the API to a real domain.
- The frontend falls back to local sample data if the API is unavailable.
