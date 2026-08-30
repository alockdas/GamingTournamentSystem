CREATE DATABASE IF NOT EXISTS GamingTournament;
USE GamingTournament;

--USERS TABLE

CREATE TABLE Users
(
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    FullName VARCHAR(100) NOT NULL,
    Username VARCHAR(50) UNIQUE NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    Password VARCHAR(255) NOT NULL,
    Role ENUM('Admin', 'Organizer', 'Player') NOT NULL
);

-- Default Admin Account
INSERT INTO Users
(FullName, Username, Email, Password, Role)
VALUES
('System Administrator', 'admin', 'admin@gmail.com', '1234', 'Admin');


--TOURNAMENTS TABLE

CREATE TABLE Tournaments
(
    TournamentID INT AUTO_INCREMENT PRIMARY KEY,
    TournamentName VARCHAR(100) NOT NULL,
    GameName VARCHAR(100) NOT NULL,
    StartDate DATE NOT NULL,
    EndDate DATE NOT NULL,
    PrizePool DECIMAL(10,2) NOT NULL,
    Status ENUM('Upcoming', 'Running', 'Completed') NOT NULL
);



--TEAMS TABLE

CREATE TABLE Teams
(
    TeamID INT AUTO_INCREMENT PRIMARY KEY,
    TournamentID INT NOT NULL,
    TeamName VARCHAR(100) NOT NULL,
    CaptainName VARCHAR(100) NOT NULL,
    GameName VARCHAR(100) NOT NULL,
    TotalPlayers INT NOT NULL,
    CoachName VARCHAR(100),
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP,

    MatchesPlayed INT DEFAULT 0,
    Wins INT DEFAULT 0,
    Losses INT DEFAULT 0,
    Draws INT DEFAULT 0,
    Points INT DEFAULT 0,

    FOREIGN KEY (TournamentID)
        REFERENCES Tournaments(TournamentID)
        ON DELETE CASCADE
);



--PLAYERS TABLE

CREATE TABLE Players
(
    PlayerID INT AUTO_INCREMENT PRIMARY KEY,
    TeamID INT NOT NULL,
    FullName VARCHAR(100) NOT NULL,
    InGameName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    Phone VARCHAR(20) NOT NULL,
    Age INT NOT NULL,
    Role ENUM('Captain', 'Player', 'Substitute') NOT NULL,

    UserID INT UNIQUE,

    FOREIGN KEY (TeamID)
        REFERENCES Teams(TeamID)
        ON DELETE CASCADE,

    FOREIGN KEY (UserID)
        REFERENCES Users(UserID)
        ON DELETE CASCADE
);


-- 
-- MATCHES TABLE
-- 
CREATE TABLE Matches
(
    MatchID INT AUTO_INCREMENT PRIMARY KEY,
    TournamentID INT NOT NULL,
    Team1ID INT NOT NULL,
    Team2ID INT NOT NULL,
    MatchDate DATE NOT NULL,
    MatchTime TIME NOT NULL,
    Venue VARCHAR(100) NOT NULL,
    WinnerTeamID INT NULL,

    Status ENUM('Scheduled', 'Ongoing', 'Completed') NOT NULL,

    IsLeaderboardUpdated BOOLEAN DEFAULT FALSE,

    FOREIGN KEY (TournamentID)
        REFERENCES Tournaments(TournamentID)
        ON DELETE CASCADE,

    FOREIGN KEY (Team1ID)
        REFERENCES Teams(TeamID)
        ON DELETE CASCADE,

    FOREIGN KEY (Team2ID)
        REFERENCES Teams(TeamID)
        ON DELETE CASCADE,

    FOREIGN KEY (WinnerTeamID)
        REFERENCES Teams(TeamID)
        ON DELETE SET NULL
);