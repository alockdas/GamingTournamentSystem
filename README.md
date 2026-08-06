# Gaming Tournament Management System

## Overview
Gaming Tournament Management System is a C# Console Application with MySQL Database for managing gaming tournaments, teams, players, matches, leaderboards, and reports.

## Features
- Admin Login
- Tournament Management
- Team Management
- Player Management
- Match Management
- Leaderboard
- Reports
- Player Dashboard

## Requirements
- .NET 11 SDK
- MySQL Server 8+
- MySql.Data Package

## Database Setup
1. Open MySQL.
2. Import `Database/GamingTournament.sql`.
3. Make sure the database name is `GamingTournament`.
4. Update the connection string in `DatabaseManager.cs` if needed.

## Default Admin Account
Username: admin

Password: 1234

## Run Project

```bash
dotnet restore
dotnet build
dotnet run
```