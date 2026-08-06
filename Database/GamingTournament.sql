-- MySQL dump 10.13  Distrib 9.5.0, for macos15 (arm64)
--
-- Host: localhost    Database: GamingTournament
-- ------------------------------------------------------
-- Server version	9.5.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
SET @MYSQLDUMP_TEMP_LOG_BIN = @@SESSION.SQL_LOG_BIN;
SET @@SESSION.SQL_LOG_BIN= 0;

--
-- GTID state at the beginning of the backup 
--

SET @@GLOBAL.GTID_PURGED=/*!80000 '+'*/ 'e79ffb8c-d64f-11f0-ae3d-b42fd18a41a6:1-194';

--
-- Table structure for table `Matches`
--

DROP TABLE IF EXISTS `Matches`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Matches` (
  `MatchID` int NOT NULL AUTO_INCREMENT,
  `TournamentID` int NOT NULL,
  `Team1ID` int NOT NULL,
  `Team2ID` int NOT NULL,
  `MatchDate` date NOT NULL,
  `MatchTime` time NOT NULL,
  `Venue` varchar(100) NOT NULL,
  `WinnerTeamID` int DEFAULT NULL,
  `Status` enum('Scheduled','Ongoing','Completed') NOT NULL,
  `IsLeaderboardUpdated` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`MatchID`),
  KEY `TournamentID` (`TournamentID`),
  KEY `Team1ID` (`Team1ID`),
  KEY `Team2ID` (`Team2ID`),
  KEY `WinnerTeamID` (`WinnerTeamID`),
  CONSTRAINT `matches_ibfk_1` FOREIGN KEY (`TournamentID`) REFERENCES `Tournaments` (`TournamentID`) ON DELETE CASCADE,
  CONSTRAINT `matches_ibfk_2` FOREIGN KEY (`Team1ID`) REFERENCES `Teams` (`TeamID`) ON DELETE CASCADE,
  CONSTRAINT `matches_ibfk_3` FOREIGN KEY (`Team2ID`) REFERENCES `Teams` (`TeamID`) ON DELETE CASCADE,
  CONSTRAINT `matches_ibfk_4` FOREIGN KEY (`WinnerTeamID`) REFERENCES `Teams` (`TeamID`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Matches`
--

LOCK TABLES `Matches` WRITE;
/*!40000 ALTER TABLE `Matches` DISABLE KEYS */;
INSERT INTO `Matches` VALUES (1,2,3,5,'2026-08-30','72:00:00','AIUB',3,'Completed',1),(2,3,5,6,'2001-08-26','72:00:00','AIUB',NULL,'Completed',0);
/*!40000 ALTER TABLE `Matches` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Players`
--

DROP TABLE IF EXISTS `Players`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Players` (
  `PlayerID` int NOT NULL AUTO_INCREMENT,
  `TeamID` int NOT NULL,
  `FullName` varchar(100) NOT NULL,
  `InGameName` varchar(50) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Phone` varchar(20) NOT NULL,
  `Age` int NOT NULL,
  `Role` enum('Captain','Player','Substitute') NOT NULL,
  `UserID` int DEFAULT NULL,
  PRIMARY KEY (`PlayerID`),
  UNIQUE KEY `Email` (`Email`),
  UNIQUE KEY `UserID` (`UserID`),
  KEY `TeamID` (`TeamID`),
  CONSTRAINT `FK_Player_User` FOREIGN KEY (`UserID`) REFERENCES `Users` (`UserID`) ON DELETE CASCADE,
  CONSTRAINT `players_ibfk_1` FOREIGN KEY (`TeamID`) REFERENCES `Teams` (`TeamID`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Players`
--

LOCK TABLES `Players` WRITE;
/*!40000 ALTER TABLE `Players` DISABLE KEYS */;
INSERT INTO `Players` VALUES (1,3,'Alock Das','Fifa','alockdas@gmail.com','01608919298',21,'Captain',NULL),(2,3,'Alock','Fifa','a@gmail.com','01608919298',21,'Player',7);
/*!40000 ALTER TABLE `Players` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Teams`
--

DROP TABLE IF EXISTS `Teams`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Teams` (
  `TeamID` int NOT NULL AUTO_INCREMENT,
  `TournamentID` int NOT NULL,
  `TeamName` varchar(100) NOT NULL,
  `CaptainName` varchar(100) NOT NULL,
  `GameName` varchar(100) NOT NULL,
  `TotalPlayers` int NOT NULL,
  `CoachName` varchar(100) DEFAULT NULL,
  `CreatedAt` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `MatchesPlayed` int DEFAULT '0',
  `Wins` int DEFAULT '0',
  `Losses` int DEFAULT '0',
  `Draws` int DEFAULT '0',
  `Points` int DEFAULT '0',
  PRIMARY KEY (`TeamID`),
  KEY `TournamentID` (`TournamentID`),
  CONSTRAINT `teams_ibfk_1` FOREIGN KEY (`TournamentID`) REFERENCES `Tournaments` (`TournamentID`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Teams`
--

LOCK TABLES `Teams` WRITE;
/*!40000 ALTER TABLE `Teams` DISABLE KEYS */;
INSERT INTO `Teams` VALUES (3,2,'Brazil','alock','Fifa',10,'alock','2026-08-04 11:53:44',1,1,0,0,3),(5,2,'A','A','Fifa',3,'A','2026-08-04 17:46:39',1,0,1,0,0),(6,3,'B','B','Fifa',10,'B','2026-08-04 18:13:53',0,0,0,0,0);
/*!40000 ALTER TABLE `Teams` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Tournaments`
--

DROP TABLE IF EXISTS `Tournaments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Tournaments` (
  `TournamentID` int NOT NULL AUTO_INCREMENT,
  `TournamentName` varchar(100) NOT NULL,
  `GameName` varchar(100) NOT NULL,
  `StartDate` date NOT NULL,
  `EndDate` date NOT NULL,
  `PrizePool` decimal(10,2) NOT NULL,
  `Status` enum('Upcoming','Running','Completed') NOT NULL,
  PRIMARY KEY (`TournamentID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Tournaments`
--

LOCK TABLES `Tournaments` WRITE;
/*!40000 ALTER TABLE `Tournaments` DISABLE KEYS */;
INSERT INTO `Tournaments` VALUES (2,'AIUB Football World Cup','Fifa','2026-08-01','2026-08-30',50000.00,'Running'),(3,'AIUB Summer Cup ','Valorant','2026-08-10','2026-08-30',10000.00,'Upcoming');
/*!40000 ALTER TABLE `Tournaments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Users`
--

DROP TABLE IF EXISTS `Users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Users` (
  `UserID` int NOT NULL AUTO_INCREMENT,
  `FullName` varchar(100) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Role` enum('Admin','Organizer','Player') NOT NULL,
  PRIMARY KEY (`UserID`),
  UNIQUE KEY `Username` (`Username`),
  UNIQUE KEY `Email` (`Email`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Users`
--

LOCK TABLES `Users` WRITE;
/*!40000 ALTER TABLE `Users` DISABLE KEYS */;
INSERT INTO `Users` VALUES (1,'Alock Das Joy','alock','alockdasjoy302@gmail.com','1234','Admin'),(4,'Alock','alock1','alockdasjoy508@gmail.com','1234','Organizer'),(5,'','','','1234','Admin'),(6,'Alock','alock2','alockdasjoy','1234','Player'),(7,'Alock','alock3','a@gmail.com','1234','Player'),(8,'System Administrator','admin','admin@gmail.com','1234','Admin');
/*!40000 ALTER TABLE `Users` ENABLE KEYS */;
UNLOCK TABLES;
SET @@SESSION.SQL_LOG_BIN = @MYSQLDUMP_TEMP_LOG_BIN;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-08-06 10:36:21
