# Crime Simulation DevOps Pipeline

A containerized .NET Web API with full CI/CD pipeline — built to demonstrate DevOps practices.

## Tech Stack
- **App:** .NET 10 Web API (C#)
- **Containerization:** Docker (multi-stage build)
- **CI/CD:** GitHub Actions
- **Testing:** xUnit unit tests
- **Registry:** Docker Hub

## API Endpoints
- `GET /` — API status + timestamp
- `GET /health` — Health check (used by monitoring tools)
- `GET /orders` — Sample order data

## Pipeline Flow
Push to main branch → Run unit tests → Build Docker image → Push to Docker Hub

## How to Run Locally
```bash
docker pull areenarehman/crime-simulation-api:latest
docker run -p 8080:8080 areenarehman/crime-simulation-api
```
Then open: http://localhost:8080/health