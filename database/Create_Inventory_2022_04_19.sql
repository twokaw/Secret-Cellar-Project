CREATE DATABASE  IF NOT EXISTS `inventory` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `inventory`;
-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: inventory
-- ------------------------------------------------------
-- Server version	8.0.28

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `customerID` int NOT NULL AUTO_INCREMENT,
  `customer_discount` double DEFAULT '0',
  `first_name` varchar(46) DEFAULT NULL,
  `last_name` varchar(46) DEFAULT NULL,
  `business_name` varchar(46) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `isWholesale` tinyint DEFAULT '0',
  `addr1` varchar(46) DEFAULT NULL,
  `addr2` varchar(46) DEFAULT NULL,
  `city` varchar(50) DEFAULT NULL,
  `state` varchar(2) DEFAULT NULL,
  `zip` varchar(10) DEFAULT NULL,
  `phone` varchar(15) DEFAULT NULL,
  `credit` double DEFAULT '0',
  PRIMARY KEY (`customerID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (0,0,'None',NULL,NULL,NULL,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1,0,'Bob','Roberts','','Bob@burgers.com',1,'123 burger st','','Springville','IA','52231','555-123-4567',55.75),(2,0,'Jane','Doe','None','Jane.Doe@None.Com',1,'string','string','Solon','IA','52333','555-123-4567',NULL),(3,0,'Bill','Pitcher','','Bill@Pitcher.com',0,'','','','','','555-621-4333',0),(4,0,'Monica','Schmidt','Scherlock','sweeper887@gmail.com',0,'','','','','','621-387-3153',0),(5,0,'Some','Person','','',0,'','','','','','   -   -',0),(6,0,'Another','Person','','',0,'','','','','','   -   -',0);
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_Customer_BI` BEFORE INSERT ON `customer` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'Customer' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_Customer_BU` BEFORE UPDATE ON `customer` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'Customer' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_Customer_BD` BEFORE DELETE ON `customer` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'Customer' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `customerfavorite`
--

DROP TABLE IF EXISTS `customerfavorite`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customerfavorite` (
  `InventoryID` int NOT NULL,
  `CustomerID` int NOT NULL,
  PRIMARY KEY (`CustomerID`,`InventoryID`),
  KEY `FK_CustomerFav_InventoryID_idx` (`InventoryID`),
  CONSTRAINT `FK_CustomerFav_CustomerID` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`customerID`),
  CONSTRAINT `FK_CustomerFav_InventoryID` FOREIGN KEY (`InventoryID`) REFERENCES `inventory_description` (`inventoryID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customerfavorite`
--

LOCK TABLES `customerfavorite` WRITE;
/*!40000 ALTER TABLE `customerfavorite` DISABLE KEYS */;
INSERT INTO `customerfavorite` VALUES (1056,1),(1879,3),(2326,1),(2462,3),(2524,3),(2524,4),(2527,3),(2529,4),(2656,3),(3604,3),(3653,4),(3941,1),(4388,3);
/*!40000 ALTER TABLE `customerfavorite` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_customerfavorite_BI` BEFORE INSERT ON `customerfavorite` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'customerfavorite' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_customerfavorite_BU` BEFORE UPDATE ON `customerfavorite` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'customerfavorite' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_customerfavorite_BD` BEFORE DELETE ON `customerfavorite` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'customerfavorite' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `customernote`
--

DROP TABLE IF EXISTS `customernote`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customernote` (
  `CustomerNoteID` int NOT NULL AUTO_INCREMENT,
  `CustomerID` int NOT NULL,
  `NoteTypeID` int NOT NULL,
  `Note` varchar(750) DEFAULT NULL,
  `NoteDate` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`CustomerNoteID`),
  KEY `idCustomer_idx` (`CustomerID`),
  KEY `FK_Customernote_NoteTyperID_idx` (`NoteTypeID`),
  CONSTRAINT `FK_Customernote_CustomerID` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`customerID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_Customernote_NoteTyperID` FOREIGN KEY (`NoteTypeID`) REFERENCES `notetype` (`NoteTypeID`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customernote`
--

LOCK TABLES `customernote` WRITE;
/*!40000 ALTER TABLE `customernote` DISABLE KEYS */;
INSERT INTO `customernote` VALUES (2,0,2,'Silly string','2021-05-12 00:40:11'),(5,3,2,'','0001-01-01 00:00:00'),(6,3,2,'Wine','0001-01-01 00:00:00');
/*!40000 ALTER TABLE `customernote` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_customernote_BI` BEFORE INSERT ON `customernote` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'customernote' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_customernote_BU` BEFORE UPDATE ON `customernote` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'customernote' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_customernote_BD` BEFORE DELETE ON `customernote` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'customernote' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `customerorder`
--

DROP TABLE IF EXISTS `customerorder`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customerorder` (
  `CustomerOrderID` int NOT NULL AUTO_INCREMENT,
  `CustomerID` int DEFAULT NULL,
  `InvoiceAmount` double DEFAULT NULL,
  `PaidAmount` double DEFAULT NULL,
  `RequestDate` datetime DEFAULT NULL,
  `DeliverDate` datetime DEFAULT NULL,
  `OrderNote` varchar(1000) DEFAULT NULL,
  PRIMARY KEY (`CustomerOrderID`)
) ENGINE=InnoDB AUTO_INCREMENT=377 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customerorder`
--

LOCK TABLES `customerorder` WRITE;
/*!40000 ALTER TABLE `customerorder` DISABLE KEYS */;
INSERT INTO `customerorder` VALUES (1,1,0,0,'2021-06-23 00:24:34','2021-06-23 00:24:34','string'),(2,1,0,0,'2021-06-23 00:24:34','2021-06-23 00:24:34','string'),(3,1,0,0,'2021-06-23 00:24:34','2021-06-23 00:24:34','string'),(4,1,0,0,'2021-06-23 00:24:34','2021-06-23 00:24:34','string'),(5,1,0,0,'2021-06-23 00:38:31','2021-06-23 00:38:31','first order'),(6,1,0,0,'0001-01-01 00:00:00','0001-01-01 00:00:00',NULL),(7,1,0,0,'0001-01-01 00:00:00','0001-01-01 00:00:00',NULL),(8,0,NULL,NULL,'2021-11-09 20:12:19',NULL,NULL),(9,0,NULL,NULL,'2021-11-09 20:15:22',NULL,NULL),(10,0,NULL,NULL,'2021-11-09 20:15:22',NULL,NULL),(11,0,NULL,NULL,'2021-11-09 20:31:59',NULL,NULL),(12,6,NULL,NULL,'2021-11-09 20:32:17',NULL,NULL),(13,0,NULL,NULL,'2021-11-16 17:33:31',NULL,NULL),(14,0,NULL,NULL,'2021-11-18 18:08:42',NULL,NULL),(15,0,NULL,NULL,'2021-11-18 18:22:01',NULL,NULL),(16,0,NULL,NULL,'2021-11-18 18:35:42',NULL,NULL),(17,0,NULL,NULL,'2021-11-18 18:47:45',NULL,NULL),(18,0,NULL,NULL,'2021-11-18 19:15:40',NULL,NULL),(19,0,NULL,NULL,'2021-11-23 18:29:33',NULL,NULL),(20,0,NULL,NULL,'2021-11-23 18:36:41',NULL,NULL),(21,0,NULL,NULL,'2021-11-23 18:43:27',NULL,NULL),(22,0,NULL,NULL,'2021-11-30 18:34:22',NULL,NULL),(23,0,NULL,NULL,'2021-11-30 19:44:24',NULL,NULL),(24,0,NULL,NULL,'2021-12-07 18:06:50',NULL,NULL),(25,0,NULL,NULL,'2021-12-07 18:13:40',NULL,NULL),(26,0,NULL,NULL,'2021-12-07 18:16:14',NULL,NULL),(27,0,NULL,NULL,'2021-12-07 18:17:07',NULL,NULL),(28,0,NULL,NULL,'2021-12-07 18:19:28',NULL,NULL),(29,0,NULL,NULL,'2021-12-07 18:20:23',NULL,NULL),(30,0,NULL,NULL,'2021-12-07 18:21:16',NULL,NULL),(31,0,NULL,NULL,'2021-12-07 18:25:52',NULL,NULL),(32,0,NULL,NULL,'2021-12-07 18:39:27',NULL,NULL),(33,0,NULL,NULL,'2021-12-07 18:42:35',NULL,NULL),(34,0,NULL,NULL,'2021-12-07 18:49:56',NULL,NULL),(35,0,NULL,NULL,'2021-12-07 18:56:27',NULL,NULL),(36,0,NULL,NULL,'2021-12-07 18:58:40',NULL,NULL),(37,0,NULL,NULL,'2021-12-07 18:59:46',NULL,NULL),(38,0,NULL,NULL,'2021-12-07 19:30:00',NULL,NULL),(39,0,NULL,NULL,'2021-12-07 20:26:28',NULL,NULL),(40,0,NULL,NULL,'2021-12-14 18:26:11',NULL,NULL),(41,0,NULL,NULL,'2021-12-14 19:28:43',NULL,NULL),(42,0,NULL,NULL,'2021-12-14 19:29:39',NULL,NULL),(43,0,NULL,NULL,'2021-12-14 19:33:10',NULL,NULL),(44,0,NULL,NULL,'2021-12-14 19:45:35',NULL,NULL),(45,0,NULL,NULL,'2021-12-14 19:47:45',NULL,NULL),(46,0,NULL,NULL,'2021-12-14 20:13:16',NULL,NULL),(47,0,NULL,NULL,'2021-12-14 20:14:08',NULL,NULL),(48,0,NULL,NULL,'2021-12-14 20:15:53',NULL,NULL),(49,0,NULL,NULL,'2021-12-14 20:18:05',NULL,NULL),(50,0,NULL,NULL,'2021-12-14 20:18:39',NULL,NULL),(51,0,NULL,NULL,'2021-12-14 20:22:57',NULL,NULL),(52,0,NULL,NULL,'2021-12-16 19:38:54',NULL,NULL),(53,0,NULL,NULL,'2021-12-16 19:40:41',NULL,NULL),(54,0,NULL,NULL,'2021-12-16 19:42:36',NULL,NULL),(55,0,NULL,NULL,'2021-12-16 19:44:55',NULL,NULL),(56,0,NULL,NULL,'2021-12-16 19:45:41',NULL,NULL),(57,0,NULL,NULL,'2021-12-16 19:49:20',NULL,NULL),(58,0,NULL,NULL,'2021-12-16 19:53:14',NULL,NULL),(59,0,NULL,NULL,'2021-12-16 19:55:30',NULL,NULL),(60,0,NULL,NULL,'2021-12-16 19:56:43',NULL,NULL),(61,0,NULL,NULL,'2021-12-16 19:58:31',NULL,NULL),(62,0,NULL,NULL,'2021-12-16 19:59:22',NULL,NULL),(63,0,NULL,NULL,'2021-12-16 20:11:21',NULL,NULL),(64,0,NULL,NULL,'2021-12-21 18:06:09',NULL,NULL),(65,0,NULL,NULL,'2021-12-21 18:16:20',NULL,NULL),(66,0,NULL,NULL,'2021-12-21 18:46:35',NULL,NULL),(67,0,NULL,NULL,'2021-12-21 19:15:15',NULL,NULL),(68,0,NULL,NULL,'2021-12-21 20:46:03',NULL,NULL),(69,0,NULL,NULL,'2021-12-21 20:47:31',NULL,NULL),(70,0,NULL,NULL,'2021-12-21 20:49:23',NULL,NULL),(71,0,NULL,NULL,'2021-12-21 20:51:09',NULL,NULL),(72,0,NULL,NULL,'2021-12-21 20:57:21',NULL,NULL),(73,0,NULL,NULL,'2021-12-21 21:03:39',NULL,NULL),(74,0,NULL,NULL,'2021-12-21 21:04:32',NULL,NULL),(75,0,NULL,NULL,'2021-12-21 21:06:35',NULL,NULL),(76,0,NULL,NULL,'2021-12-21 21:13:35',NULL,NULL),(77,0,NULL,NULL,'2021-12-21 21:14:45',NULL,NULL),(78,0,NULL,NULL,'2021-12-21 21:15:55',NULL,NULL),(79,0,NULL,NULL,'2021-12-21 21:18:41',NULL,NULL),(80,0,NULL,NULL,'2021-12-23 18:36:36',NULL,NULL),(81,0,NULL,NULL,'2021-12-23 19:01:00',NULL,NULL),(82,0,NULL,NULL,'2021-12-23 19:01:35',NULL,NULL),(83,0,NULL,NULL,'2021-12-23 19:30:54',NULL,NULL),(84,0,NULL,NULL,'2021-12-28 18:49:36',NULL,NULL),(85,0,NULL,NULL,'2021-12-28 19:10:11',NULL,NULL),(86,0,NULL,NULL,'2021-12-28 20:31:23',NULL,NULL),(87,0,NULL,NULL,'2022-01-04 18:27:45',NULL,NULL),(88,0,NULL,NULL,'2022-01-04 18:30:05',NULL,NULL),(89,0,NULL,NULL,'2022-01-04 18:30:25',NULL,NULL),(90,0,NULL,NULL,'2022-01-04 18:37:48',NULL,NULL),(91,0,NULL,NULL,'2022-01-04 18:44:47',NULL,NULL),(92,0,NULL,NULL,'2022-01-04 18:46:16',NULL,NULL),(93,0,NULL,NULL,'2022-01-04 18:47:28',NULL,NULL),(94,0,NULL,NULL,'2022-01-04 18:48:03',NULL,NULL),(95,0,NULL,NULL,'2022-01-04 18:49:54',NULL,NULL),(96,0,NULL,NULL,'2022-01-04 18:51:21',NULL,NULL),(97,0,NULL,NULL,'2022-01-04 18:53:53',NULL,NULL),(98,0,NULL,NULL,'2022-01-04 19:00:49',NULL,NULL),(99,0,NULL,NULL,'2022-01-04 19:07:38',NULL,NULL),(100,0,NULL,NULL,'2022-01-04 19:13:16',NULL,NULL),(101,0,NULL,NULL,'2022-01-04 19:13:52',NULL,NULL),(102,0,NULL,NULL,'2022-01-04 19:24:32',NULL,NULL),(103,0,NULL,NULL,'2022-01-04 19:39:38',NULL,NULL),(104,0,NULL,NULL,'2022-01-04 19:53:54',NULL,NULL),(105,0,NULL,NULL,'2022-01-04 20:02:57',NULL,NULL),(106,0,NULL,NULL,'2022-01-04 20:05:32',NULL,NULL),(107,0,NULL,NULL,'2022-01-04 20:09:14',NULL,NULL),(108,0,NULL,NULL,'2022-01-04 20:11:01',NULL,NULL),(109,0,NULL,NULL,'2022-01-04 20:11:50',NULL,NULL),(110,0,NULL,NULL,'2022-01-04 20:30:14',NULL,NULL),(111,0,NULL,NULL,'2022-01-04 20:32:31',NULL,NULL),(112,0,NULL,NULL,'2022-01-11 19:10:15',NULL,NULL),(113,0,NULL,NULL,'2022-01-11 19:26:01',NULL,NULL),(114,0,NULL,NULL,'2022-01-11 19:36:31',NULL,NULL),(115,0,NULL,NULL,'2022-01-11 19:38:05',NULL,NULL),(116,0,NULL,NULL,'2022-01-11 20:44:38',NULL,NULL),(117,0,NULL,NULL,'2022-01-11 20:45:25',NULL,NULL),(118,0,NULL,NULL,'2022-01-13 18:37:22',NULL,NULL),(119,0,NULL,NULL,'2022-01-13 18:46:11',NULL,NULL),(120,0,NULL,NULL,'2022-01-13 18:48:30',NULL,NULL),(121,0,NULL,NULL,'2022-01-13 18:50:29',NULL,NULL),(122,0,NULL,NULL,'2022-01-13 18:51:50',NULL,NULL),(123,0,NULL,NULL,'2022-01-13 18:52:56',NULL,NULL),(124,0,NULL,NULL,'2022-01-13 18:53:36',NULL,NULL),(125,0,NULL,NULL,'2022-01-13 18:54:06',NULL,NULL),(126,0,NULL,NULL,'2022-01-13 18:55:16',NULL,NULL),(127,0,NULL,NULL,'2022-01-13 18:59:03',NULL,NULL),(128,0,NULL,NULL,'2022-01-13 19:04:00',NULL,NULL),(129,0,NULL,NULL,'2022-01-13 19:05:52',NULL,NULL),(130,0,NULL,NULL,'2022-01-13 19:08:21',NULL,NULL),(131,0,NULL,NULL,'2022-01-13 19:11:53',NULL,NULL),(132,0,NULL,NULL,'2022-01-13 19:12:49',NULL,NULL),(133,0,NULL,NULL,'2022-01-13 19:16:37',NULL,NULL),(134,0,NULL,NULL,'2022-01-13 19:30:56',NULL,NULL),(135,0,NULL,NULL,'2022-01-13 19:32:18',NULL,NULL),(136,0,NULL,NULL,'2022-01-13 19:33:21',NULL,NULL),(137,0,NULL,NULL,'2022-01-13 19:34:56',NULL,NULL),(138,0,NULL,NULL,'2022-01-13 19:36:53',NULL,NULL),(139,0,NULL,NULL,'2022-01-13 19:37:34',NULL,NULL),(140,0,NULL,NULL,'2022-01-13 19:38:19',NULL,NULL),(141,0,NULL,NULL,'2022-01-13 19:39:22',NULL,NULL),(142,0,NULL,NULL,'2022-01-13 19:41:42',NULL,NULL),(143,0,NULL,NULL,'2022-01-13 19:43:29',NULL,NULL),(144,0,NULL,NULL,'2022-01-13 19:44:10',NULL,NULL),(145,0,NULL,NULL,'2022-01-13 19:52:14',NULL,NULL),(146,0,NULL,NULL,'2022-01-13 19:54:02',NULL,NULL),(147,0,NULL,NULL,'2022-01-13 19:56:53',NULL,NULL),(148,0,NULL,NULL,'2022-01-13 19:59:04',NULL,NULL),(149,0,NULL,NULL,'2022-01-13 20:04:59',NULL,NULL),(150,0,NULL,NULL,'2022-01-13 20:08:51',NULL,NULL),(151,0,NULL,NULL,'2022-01-13 20:12:46',NULL,NULL),(152,0,NULL,NULL,'2022-01-13 20:17:09',NULL,NULL),(153,0,NULL,NULL,'2022-01-13 20:17:59',NULL,NULL),(154,0,NULL,NULL,'2022-01-13 20:18:42',NULL,NULL),(155,0,NULL,NULL,'2022-01-13 20:20:04',NULL,NULL),(156,0,NULL,NULL,'2022-01-13 20:23:31',NULL,NULL),(157,0,NULL,NULL,'2022-01-13 20:26:47',NULL,NULL),(158,0,NULL,NULL,'2022-01-13 20:28:03',NULL,NULL),(159,0,NULL,NULL,'2022-01-13 20:29:05',NULL,NULL),(160,0,NULL,NULL,'2022-01-13 20:30:10',NULL,NULL),(161,0,NULL,NULL,'2022-01-13 20:30:52',NULL,NULL),(162,0,NULL,NULL,'2022-01-13 20:31:30',NULL,NULL),(163,0,NULL,NULL,'2022-01-13 20:32:33',NULL,NULL),(164,0,NULL,NULL,'2022-01-13 20:34:06',NULL,NULL),(165,0,NULL,NULL,'2022-01-13 20:37:54',NULL,NULL),(166,0,NULL,NULL,'2022-01-13 20:41:33',NULL,NULL),(167,0,NULL,NULL,'2022-01-18 17:39:35',NULL,NULL),(168,0,NULL,NULL,'2022-01-18 18:18:42',NULL,NULL),(169,0,NULL,NULL,'2022-01-18 18:19:16',NULL,NULL),(170,0,NULL,NULL,'2022-01-18 18:27:10',NULL,NULL),(171,0,NULL,NULL,'2022-01-18 18:30:02',NULL,NULL),(172,0,NULL,NULL,'2022-01-18 18:35:58',NULL,NULL),(173,0,NULL,NULL,'2022-01-18 18:40:40',NULL,NULL),(174,0,NULL,NULL,'2022-01-18 18:52:49',NULL,NULL),(175,0,NULL,NULL,'2022-01-18 19:05:15',NULL,NULL),(176,0,NULL,NULL,'2022-01-18 19:10:25',NULL,NULL),(177,6,NULL,NULL,'2022-01-18 19:11:56',NULL,NULL),(178,0,NULL,NULL,'2022-01-18 19:16:47',NULL,NULL),(179,0,NULL,NULL,'2022-01-18 19:17:14',NULL,NULL),(180,2,NULL,NULL,'2022-01-18 19:17:53',NULL,NULL),(181,0,NULL,NULL,'2022-01-18 19:23:26',NULL,NULL),(182,0,NULL,NULL,'2022-01-18 19:24:37',NULL,NULL),(183,0,NULL,NULL,'2022-01-18 19:30:59',NULL,NULL),(184,0,NULL,NULL,'2022-01-18 19:38:36',NULL,NULL),(185,0,NULL,NULL,'2022-01-18 19:45:15',NULL,NULL),(186,0,NULL,NULL,'2022-01-18 20:02:14',NULL,NULL),(187,0,NULL,NULL,'2022-01-18 20:15:14',NULL,NULL),(188,0,NULL,NULL,'2022-01-18 20:17:44',NULL,NULL),(189,0,NULL,NULL,'2022-01-18 20:42:43',NULL,NULL),(190,3,NULL,NULL,'2022-01-18 20:42:55',NULL,NULL),(191,3,NULL,NULL,'2022-01-18 20:43:42',NULL,NULL),(192,0,NULL,NULL,'2022-01-20 19:10:16',NULL,NULL),(193,3,NULL,NULL,'2022-01-20 19:14:30',NULL,NULL),(194,3,NULL,NULL,'2022-01-20 19:14:38',NULL,NULL),(195,194,NULL,NULL,'2022-01-20 19:14:38',NULL,NULL),(196,194,NULL,NULL,'2022-01-20 19:14:39',NULL,NULL),(197,3,NULL,NULL,'2022-01-20 19:14:41',NULL,NULL),(198,3,NULL,NULL,'2022-01-20 19:14:49',NULL,NULL),(199,3,NULL,NULL,'2022-01-20 19:14:49',NULL,NULL),(200,3,NULL,NULL,'2022-01-20 19:14:49',NULL,NULL),(201,3,NULL,NULL,'2022-01-20 19:14:52',NULL,NULL),(202,3,NULL,NULL,'2022-01-20 19:15:09',NULL,NULL),(203,0,NULL,NULL,'2022-01-20 19:23:30',NULL,NULL),(204,3,NULL,NULL,'2022-01-20 19:23:47',NULL,NULL),(205,3,NULL,NULL,'2022-01-20 19:23:59',NULL,NULL),(206,3,NULL,NULL,'2022-01-20 19:23:59',NULL,NULL),(207,3,NULL,NULL,'2022-01-20 19:23:59',NULL,NULL),(208,3,NULL,NULL,'2022-01-20 19:25:12',NULL,NULL),(209,3,NULL,NULL,'2022-01-20 19:27:04',NULL,NULL),(210,0,NULL,NULL,'2022-01-20 19:29:02',NULL,NULL),(211,3,NULL,NULL,'2022-01-20 19:29:13',NULL,NULL),(212,3,NULL,NULL,'2022-01-20 19:30:13',NULL,NULL),(213,3,NULL,NULL,'2022-01-20 19:36:54',NULL,NULL),(214,3,NULL,NULL,'2022-01-20 19:36:56',NULL,NULL),(215,3,NULL,NULL,'2022-01-20 19:38:55',NULL,NULL),(216,0,NULL,NULL,'2022-01-20 19:39:42',NULL,NULL),(217,3,NULL,NULL,'2022-01-20 19:39:58',NULL,NULL),(218,3,NULL,NULL,'2022-01-20 19:40:23',NULL,NULL),(219,3,NULL,NULL,'2022-01-20 19:40:28',NULL,NULL),(220,0,NULL,NULL,'2022-01-20 19:46:28',NULL,NULL),(221,3,NULL,NULL,'2022-01-20 19:47:21',NULL,NULL),(222,3,NULL,NULL,'2022-01-20 19:47:39',NULL,NULL),(223,3,NULL,NULL,'2022-01-20 19:47:41',NULL,NULL),(224,3,NULL,NULL,'2022-01-20 19:47:43',NULL,NULL),(225,3,NULL,NULL,'2022-01-20 19:47:45',NULL,NULL),(226,3,NULL,NULL,'2022-01-20 19:48:34',NULL,NULL),(227,3,NULL,NULL,'2022-01-20 19:49:00',NULL,NULL),(228,0,NULL,NULL,'2022-01-20 20:03:35',NULL,NULL),(229,3,NULL,NULL,'2022-01-20 20:03:52',NULL,NULL),(230,3,NULL,NULL,'2022-01-20 20:04:00',NULL,NULL),(231,3,NULL,NULL,'2022-01-20 20:04:04',NULL,NULL),(232,3,NULL,NULL,'2022-01-20 20:04:06',NULL,NULL),(233,3,NULL,NULL,'2022-01-20 20:04:16',NULL,NULL),(234,3,NULL,NULL,'2022-01-20 20:04:17',NULL,NULL),(235,0,NULL,NULL,'2022-01-20 20:05:32',NULL,NULL),(236,0,NULL,NULL,'2022-01-25 18:35:51',NULL,NULL),(237,0,NULL,NULL,'2022-01-25 18:49:12',NULL,NULL),(238,0,NULL,NULL,'2022-01-25 19:04:45',NULL,NULL),(239,0,NULL,NULL,'2022-01-25 19:08:05',NULL,NULL),(240,0,NULL,NULL,'2022-01-25 19:32:42',NULL,NULL),(241,0,NULL,NULL,'2022-01-25 19:34:06',NULL,NULL),(242,0,NULL,NULL,'2022-01-25 19:37:26',NULL,NULL),(243,0,NULL,NULL,'2022-01-25 19:40:12',NULL,NULL),(244,0,NULL,NULL,'2022-01-25 19:41:41',NULL,NULL),(245,0,NULL,NULL,'2022-01-25 19:42:58',NULL,NULL),(246,0,NULL,NULL,'2022-01-25 19:44:24',NULL,NULL),(247,0,NULL,NULL,'2022-01-27 18:39:06',NULL,NULL),(248,0,NULL,NULL,'2022-01-27 18:41:58',NULL,NULL),(249,0,NULL,NULL,'2022-01-27 19:08:02',NULL,NULL),(250,0,NULL,NULL,'2022-01-27 19:14:35',NULL,NULL),(251,0,NULL,NULL,'2022-01-27 19:21:59',NULL,NULL),(252,0,NULL,NULL,'2022-02-08 19:43:06',NULL,NULL),(253,5,NULL,NULL,'2022-02-08 19:44:15',NULL,NULL),(254,2,NULL,NULL,'2022-02-08 19:44:17',NULL,NULL),(255,0,NULL,NULL,'2022-02-08 20:17:45',NULL,NULL),(256,0,NULL,NULL,'2022-02-08 20:23:00',NULL,NULL),(257,0,NULL,NULL,'2022-02-10 20:49:39',NULL,NULL),(258,0,NULL,NULL,'2022-02-15 18:10:11',NULL,NULL),(259,0,NULL,NULL,'2022-02-15 18:11:14',NULL,NULL),(260,0,NULL,NULL,'2022-02-15 18:27:06',NULL,NULL),(261,0,NULL,NULL,'2022-02-15 18:32:16',NULL,NULL),(262,0,NULL,NULL,'2022-02-15 18:37:17',NULL,NULL),(263,0,NULL,NULL,'2022-02-15 18:49:39',NULL,NULL),(264,0,NULL,NULL,'2022-02-15 18:56:24',NULL,NULL),(265,0,NULL,NULL,'2022-02-15 19:15:18',NULL,NULL),(266,0,NULL,NULL,'2022-02-15 19:25:32',NULL,NULL),(267,0,NULL,NULL,'2022-02-15 19:37:22',NULL,NULL),(268,0,NULL,NULL,'2022-02-15 19:40:36',NULL,NULL),(269,0,NULL,NULL,'2022-02-15 20:17:58',NULL,NULL),(270,0,NULL,NULL,'2022-02-17 18:08:46',NULL,NULL),(271,0,NULL,NULL,'2022-02-17 20:01:27',NULL,NULL),(272,0,NULL,NULL,'2022-02-17 20:04:35',NULL,NULL),(273,0,NULL,NULL,'2022-02-17 20:12:03',NULL,NULL),(274,0,NULL,NULL,'2022-02-17 20:34:12',NULL,NULL),(275,0,NULL,NULL,'2022-02-17 20:38:31',NULL,NULL),(276,0,NULL,NULL,'2022-02-17 20:47:32',NULL,NULL),(277,0,NULL,NULL,'2022-02-17 20:47:48',NULL,NULL),(278,0,NULL,NULL,'2022-02-22 20:40:10',NULL,NULL),(279,0,NULL,NULL,'2022-03-01 18:17:53',NULL,NULL),(280,0,NULL,NULL,'2022-03-01 18:22:05',NULL,NULL),(281,0,NULL,NULL,'2022-03-01 18:25:27',NULL,NULL),(282,0,NULL,NULL,'2022-03-01 18:30:22',NULL,NULL),(283,0,NULL,NULL,'2022-03-01 18:36:15',NULL,NULL),(284,0,NULL,NULL,'2022-03-01 18:54:53',NULL,NULL),(285,0,NULL,NULL,'2022-03-01 19:04:35',NULL,NULL),(286,0,NULL,NULL,'2022-03-01 19:07:56',NULL,NULL),(287,0,NULL,NULL,'2022-03-01 19:11:59',NULL,NULL),(288,0,NULL,NULL,'2022-03-01 19:56:17',NULL,NULL),(289,0,NULL,NULL,'2022-03-02 17:32:42',NULL,NULL),(290,0,NULL,NULL,'2022-03-02 17:34:01',NULL,NULL),(291,0,NULL,NULL,'2022-03-03 18:41:36',NULL,NULL),(292,0,NULL,NULL,'2022-03-03 19:07:33',NULL,NULL),(293,0,NULL,NULL,'2022-03-03 19:18:06',NULL,NULL),(294,0,NULL,NULL,'2022-03-03 20:05:16',NULL,NULL),(295,0,NULL,NULL,'2022-03-08 18:23:30',NULL,NULL),(296,0,NULL,NULL,'2022-03-08 18:34:02',NULL,NULL),(297,0,NULL,NULL,'2022-03-08 18:35:10',NULL,NULL),(298,0,NULL,NULL,'2022-03-08 18:37:01',NULL,NULL),(299,0,NULL,NULL,'2022-03-08 18:43:40',NULL,NULL),(300,0,NULL,NULL,'2022-03-08 20:34:28',NULL,NULL),(301,0,NULL,NULL,'2022-03-10 18:46:07',NULL,NULL),(302,0,NULL,NULL,'2022-03-10 19:12:22',NULL,NULL),(303,0,NULL,NULL,'2022-03-10 19:17:51',NULL,NULL),(304,0,NULL,NULL,'2022-03-10 19:24:13',NULL,NULL),(305,0,NULL,NULL,'2022-03-10 19:31:47',NULL,NULL),(306,0,NULL,NULL,'2022-03-10 19:48:26',NULL,NULL),(307,0,NULL,NULL,'2022-03-15 20:19:56',NULL,NULL),(308,0,NULL,NULL,'2022-03-17 19:06:32',NULL,NULL),(309,0,NULL,NULL,'2022-03-17 19:08:58',NULL,NULL),(310,0,NULL,NULL,'2022-03-17 19:27:25',NULL,NULL),(311,0,NULL,NULL,'2022-03-17 19:29:15',NULL,NULL),(312,0,NULL,NULL,'2022-03-17 19:32:43',NULL,NULL),(313,0,NULL,NULL,'2022-03-17 19:33:13',NULL,NULL),(314,0,NULL,NULL,'2022-03-17 19:35:11',NULL,NULL),(315,0,NULL,NULL,'2022-03-17 19:35:40',NULL,NULL),(316,0,NULL,NULL,'2022-03-17 19:37:37',NULL,NULL),(317,0,NULL,NULL,'2022-03-17 19:38:22',NULL,NULL),(318,0,NULL,NULL,'2022-03-17 19:40:04',NULL,NULL),(319,0,NULL,NULL,'2022-03-17 19:42:43',NULL,NULL),(320,0,NULL,NULL,'2022-03-17 19:44:15',NULL,NULL),(321,0,NULL,NULL,'2022-03-17 19:48:01',NULL,NULL),(322,0,NULL,NULL,'2022-03-17 19:57:42',NULL,NULL),(323,0,NULL,NULL,'2022-03-17 19:58:29',NULL,NULL),(324,0,NULL,NULL,'2022-03-22 18:32:49',NULL,NULL),(325,0,NULL,NULL,'2022-03-22 19:09:26',NULL,NULL),(326,0,NULL,NULL,'2022-03-22 19:11:35',NULL,NULL),(327,0,NULL,NULL,'2022-03-22 19:16:38',NULL,NULL),(328,0,NULL,NULL,'2022-03-29 17:52:10',NULL,NULL),(329,0,NULL,NULL,'2022-03-29 17:59:43',NULL,NULL),(330,0,NULL,NULL,'2022-03-29 18:05:07',NULL,NULL),(331,0,NULL,NULL,'2022-03-29 18:30:55',NULL,NULL),(332,0,NULL,NULL,'2022-03-29 18:37:13',NULL,NULL),(333,0,NULL,NULL,'2022-03-29 18:42:55',NULL,NULL),(334,0,NULL,NULL,'2022-03-29 19:21:58',NULL,NULL),(335,0,NULL,NULL,'2022-03-29 19:40:27',NULL,NULL),(336,0,NULL,NULL,'2022-03-29 19:42:28',NULL,NULL),(337,0,NULL,NULL,'2022-03-29 19:58:13',NULL,NULL),(338,0,NULL,NULL,'2022-03-29 20:02:13',NULL,NULL),(339,0,NULL,NULL,'2022-03-29 20:04:27',NULL,NULL),(340,0,NULL,NULL,'2022-03-29 20:05:26',NULL,NULL),(341,0,NULL,NULL,'2022-03-29 20:08:55',NULL,NULL),(342,0,NULL,NULL,'2022-03-29 20:15:01',NULL,NULL),(343,0,NULL,NULL,'2022-03-29 20:18:27',NULL,NULL),(344,0,NULL,NULL,'2022-04-05 18:18:32',NULL,NULL),(345,0,NULL,NULL,'2022-04-05 18:22:59',NULL,NULL),(346,0,NULL,NULL,'2022-04-05 18:31:26',NULL,NULL),(347,0,NULL,NULL,'2022-04-05 18:36:48',NULL,NULL),(348,0,NULL,NULL,'2022-04-05 18:44:04',NULL,NULL),(349,0,NULL,NULL,'2022-04-05 19:11:52',NULL,NULL),(350,0,NULL,NULL,'2022-04-05 19:34:14',NULL,NULL),(351,0,NULL,NULL,'2022-04-05 20:06:55',NULL,NULL),(352,0,NULL,NULL,'2022-04-05 20:07:20',NULL,NULL),(353,0,NULL,NULL,'2022-04-05 20:26:27',NULL,NULL),(354,0,NULL,NULL,'2022-04-05 20:27:24',NULL,NULL),(355,0,NULL,NULL,'2022-04-05 20:28:12',NULL,NULL),(356,0,NULL,NULL,'2022-04-05 20:28:22',NULL,NULL),(357,0,NULL,NULL,'2022-04-07 18:18:36',NULL,NULL),(358,0,NULL,NULL,'2022-04-07 18:46:13',NULL,NULL),(359,0,NULL,NULL,'2022-04-07 20:11:23',NULL,NULL),(360,0,NULL,NULL,'2022-04-07 20:44:31',NULL,NULL),(361,0,NULL,NULL,'2022-04-12 17:46:07',NULL,NULL),(362,0,NULL,NULL,'2022-04-12 18:02:06',NULL,NULL),(363,0,NULL,NULL,'2022-04-12 19:32:29',NULL,NULL),(364,0,NULL,NULL,'2022-04-12 19:34:39',NULL,NULL),(365,0,NULL,NULL,'2022-04-12 19:37:36',NULL,NULL),(366,0,NULL,NULL,'2022-04-12 19:50:44',NULL,NULL),(367,0,NULL,NULL,'2022-04-12 20:05:28',NULL,NULL),(368,0,NULL,NULL,'2022-04-12 20:13:12',NULL,NULL),(369,0,NULL,NULL,'2022-04-12 20:14:52',NULL,NULL),(370,0,NULL,NULL,'2022-04-12 20:19:53',NULL,NULL),(371,0,NULL,NULL,'2022-04-19 10:08:21',NULL,NULL),(372,0,NULL,NULL,'2022-04-19 10:08:58',NULL,NULL),(373,0,NULL,NULL,'2022-04-19 10:09:08',NULL,NULL),(374,0,NULL,NULL,'2022-04-19 10:09:23',NULL,NULL),(375,0,NULL,NULL,'2022-04-19 10:09:28',NULL,NULL),(376,0,NULL,NULL,'2022-04-19 10:09:47',NULL,NULL);
/*!40000 ALTER TABLE `customerorder` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_customerorder_BI` BEFORE INSERT ON `customerorder` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'customerorder' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_customerorder_BU` BEFORE UPDATE ON `customerorder` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'customerorder' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_CustomerOrder` BEFORE DELETE ON `customerorder` FOR EACH ROW BEGIN
  INSERT INTO CustomerOrderHist
  ( CustomerOrderID, CustomerID, InvoiceAmount, PaidAmount, RequestDate, DeliverDate, OrderNote, paidDate)
  VALUES
  ( old.CustomerOrderID, old.CustomerID, old.InvoiceAmount, old.PaidAmount, old.RequestDate, old.DeliverDate, old.OrderNote, sysdate()  );
  
  INSERT INTO CustomerOrderItemHist
  (CustomerOrderItemID, CustomerOrderID, InventoryID, OrderQTY, DeliverQTY, Deliverdate )
  SELECT CustomerOrderItemID, CustomerOrderID, InventoryID, OrderQTY, DeliverQTY, Deliverdate 
  FROM CustomerOrderItem
  WHERE customerorderID = old.CustomerOrderId;
  
  DELETE FROM  CustomerOrderItemHist
  WHERE customerorderID = old.CustomerOrderId;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_customerorder_BD` BEFORE DELETE ON `customerorder` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'customerorder' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `customerorderhist`
--

DROP TABLE IF EXISTS `customerorderhist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customerorderhist` (
  `CustomerOrderID` int NOT NULL,
  `CustomerID` int DEFAULT NULL,
  `InvoiceAmount` double DEFAULT NULL,
  `PaidAmount` double DEFAULT NULL,
  `RequestDate` datetime DEFAULT NULL,
  `DeliverDate` datetime DEFAULT NULL,
  `OrderNote` varchar(1000) DEFAULT NULL,
  `PaidDate` datetime DEFAULT NULL,
  PRIMARY KEY (`CustomerOrderID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customerorderhist`
--

LOCK TABLES `customerorderhist` WRITE;
/*!40000 ALTER TABLE `customerorderhist` DISABLE KEYS */;
/*!40000 ALTER TABLE `customerorderhist` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_customerorderhist_BI` BEFORE INSERT ON `customerorderhist` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'customerorderhist' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_customerorderhist_BU` BEFORE UPDATE ON `customerorderhist` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'customerorderhist' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_customerorderhist_BD` BEFORE DELETE ON `customerorderhist` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'customerorderhist' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `customerorderitem`
--

DROP TABLE IF EXISTS `customerorderitem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customerorderitem` (
  `CustomerOrderItemID` int NOT NULL AUTO_INCREMENT,
  `InventoryID` int NOT NULL,
  `RequestQTY` int DEFAULT NULL,
  `DeliverQTY` int DEFAULT NULL,
  `Deliverdate` datetime DEFAULT NULL,
  `CustomerID` int NOT NULL,
  `Price` double DEFAULT NULL,
  `Paid` double DEFAULT NULL,
  `RequestDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `PaidDate` datetime DEFAULT NULL,
  PRIMARY KEY (`CustomerOrderItemID`),
  KEY `FK_CustomerOrderItem_idx` (`InventoryID`),
  KEY `FK_CustomerOrderItem_CustomerId_idx` (`CustomerID`),
  CONSTRAINT `FK_CustomerOrderItem_CustomerId` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`customerID`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `FK_CustomerOrderItem_InventoryID` FOREIGN KEY (`InventoryID`) REFERENCES `inventory_description` (`inventoryID`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customerorderitem`
--

LOCK TABLES `customerorderitem` WRITE;
/*!40000 ALTER TABLE `customerorderitem` DISABLE KEYS */;
INSERT INTO `customerorderitem` VALUES (1,1056,0,0,'0001-01-01 00:00:00',3,0,0,'2021-07-22 19:34:26',NULL),(10,4315,0,NULL,'0001-01-01 00:00:00',1,21.99,0,'2021-07-22 19:34:26',NULL),(11,3085,0,0,'0001-01-01 00:00:00',1,NULL,NULL,'2021-07-22 19:34:26',NULL),(19,2524,0,0,'0001-01-01 00:00:00',3,0,0,'2021-08-24 18:54:04','0001-01-01 00:00:00'),(20,1672,0,0,'0001-01-01 00:00:00',3,0,0,'2021-09-14 18:30:08','0001-01-01 00:00:00'),(21,1541,0,0,'0001-01-01 00:00:00',3,0,0,'2021-09-14 20:31:34','0001-01-01 00:00:00'),(22,3941,0,0,'0001-01-01 00:00:00',3,0,0,'2021-09-14 20:34:11','0001-01-01 00:00:00'),(24,2524,0,0,'0001-01-01 00:00:00',4,26.83,0,'2021-10-22 23:31:45','0001-01-01 00:00:00'),(25,2529,8,0,'0001-01-01 00:00:00',4,35.75,0,'2021-10-22 23:37:49','0001-01-01 00:00:00'),(29,1879,0,0,'0001-01-01 00:00:00',3,79.99,0,'2022-01-20 20:04:04','0001-01-01 00:00:00'),(30,1879,0,NULL,'0001-01-01 00:00:00',3,79.99,0,'2022-01-20 20:04:17','0001-01-01 00:00:00'),(31,2524,0,3,'0001-01-01 00:00:00',3,26.83,0,'2022-01-20 20:04:53','0001-01-01 00:00:00'),(32,4388,2,3,'0001-01-01 00:00:00',3,39.99,0,'2022-02-08 19:45:03','0001-01-01 00:00:00'),(33,2527,6,NULL,'0001-01-01 00:00:00',3,18.99,0,'2022-02-15 19:44:38','0001-01-01 00:00:00'),(34,2462,0,NULL,'0001-01-01 00:00:00',3,14.99,0,'2022-02-17 18:16:31','0001-01-01 00:00:00'),(35,2524,10,0,'0001-01-01 00:00:00',3,26.83,0,'2022-02-17 20:02:15','0001-01-01 00:00:00');
/*!40000 ALTER TABLE `customerorderitem` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_customerorderitem_BI` BEFORE INSERT ON `customerorderitem` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'customerorderitem' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `customerorderitem_AFTER_INSERT` AFTER INSERT ON `customerorderitem` FOR EACH ROW BEGIN
       INSERT INTO customerorderitemhist
  (`CustomerOrderItemID`, `InventoryID`, `RequestQTY`, `DeliverQTY`, 
   `Transactiondate`, `Paid`, `CustomerID`, `Price`)
  VALUES  
  (new.CustomerOrderItemID, new.InventoryID, new.RequestQTY, new.DeliverQTY,
   NOW(), new.Paid, new.CustomerID,  new.Price);

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_customerorderitem_BU` BEFORE UPDATE ON `customerorderitem` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'customerorderitem' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `customerorderitem_BEFORE_UPDATE` BEFORE UPDATE ON `customerorderitem` FOR EACH ROW BEGIN
       INSERT INTO customerorderitemhist
  (`CustomerOrderItemID`, `InventoryID`, `RequestQTY`, `DeliverQTY`, 
   `Transactiondate`, `Paid`, `CustomerID`, `Price`)
  VALUES  
  (new.CustomerOrderItemID, new.InventoryID, new.RequestQTY, new.DeliverQTY,
   NOW(), new.Paid, new.CustomerID,  new.Price);
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `customerorderitem_BEFORE_DELETE` BEFORE DELETE ON `customerorderitem` FOR EACH ROW BEGIN
  INSERT INTO customerorderitemhist
  (`CustomerOrderItemID`, `InventoryID`, `RequestQTY`, `DeliverQTY`, 
   `Transactiondate`, `Paid`, `CustomerID`, `Price`)
  VALUES  
  (old.CustomerOrderItemID, old.InventoryID, 0, 0,
   NOW(), 0, old.CustomerID,  old.Price);
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_customerorderitem_BD` BEFORE DELETE ON `customerorderitem` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'customerorderitem' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `customerorderitemhist`
--

DROP TABLE IF EXISTS `customerorderitemhist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customerorderitemhist` (
  `CustomerOrderItemHistID` int NOT NULL AUTO_INCREMENT,
  `CustomerOrderItemID` int NOT NULL,
  `InventoryID` int DEFAULT NULL,
  `RequestQTY` int DEFAULT NULL,
  `DeliverQTY` int DEFAULT NULL,
  `Transactiondate` datetime DEFAULT NULL,
  `Paid` double DEFAULT NULL,
  `CustomerID` int NOT NULL,
  `Price` double DEFAULT NULL,
  PRIMARY KEY (`CustomerOrderItemHistID`)
) ENGINE=InnoDB AUTO_INCREMENT=79 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customerorderitemhist`
--

LOCK TABLES `customerorderitemhist` WRITE;
/*!40000 ALTER TABLE `customerorderitemhist` DISABLE KEYS */;
INSERT INTO `customerorderitemhist` VALUES (1,17,2326,0,0,'2021-08-10 20:14:06',0,1,15),(2,17,2326,0,0,'2021-08-10 20:16:30',0,1,0),(3,17,2326,1,0,'2021-08-10 20:18:04',0,1,0),(4,17,2326,0,0,'2021-08-10 20:18:43',0,1,0),(5,1,1024,1,0,'2021-08-24 18:42:58',0,3,0),(6,19,2524,3,0,'2021-08-24 18:54:04',0,3,0),(7,19,2524,0,1,'2021-08-26 19:03:40',0,3,0),(8,19,2524,1,1,'2021-08-26 19:03:42',0,3,0),(9,20,1672,1,0,'2021-09-14 18:30:08',0,3,0),(10,20,1672,1,0,'2021-09-14 18:30:31',0,3,0),(11,21,1541,1,0,'2021-09-14 20:31:34',0,3,0),(12,22,3941,1,0,'2021-09-14 20:34:11',0,3,0),(13,22,3941,-1,0,'2021-09-14 20:34:58',0,3,0),(14,20,1672,0,1,'2021-09-16 19:54:47',0,3,0),(15,20,1672,1,1,'2021-09-16 19:55:23',0,3,0),(16,1,1024,0,1,'2021-09-16 19:56:49',0,3,0),(17,1,1024,1,1,'2021-09-16 19:57:33',0,3,0),(18,1,1024,0,1,'2021-09-16 19:59:07',0,3,0),(19,20,1672,0,1,'2021-09-16 20:02:05',0,3,0),(20,19,2524,0,1,'2021-09-16 20:05:31',0,3,0),(21,19,2524,9,0,'2021-10-12 19:53:38',0,3,0),(22,23,3027,1,0,'2021-10-21 19:11:59',0,4,0),(23,24,2524,5,0,'2021-10-22 23:31:45',0,4,0),(24,25,2529,10,0,'2021-10-22 23:37:49',0,4,0),(25,26,1843,1,0,'2021-10-23 10:19:52',0,4,0),(26,26,1841,1,0,'2021-10-23 10:24:09',0,4,0),(27,27,1841,1,0,'2021-10-23 10:44:44',0,4,0),(28,28,3941,1,0,'2021-10-23 11:02:34',0,4,7.99),(29,28,3941,1,0,'2021-10-23 11:04:41',0,4,7.99),(30,28,3941,1,0,'2021-10-23 11:48:49',0,4,7.99),(31,10,4315,1,0,'2021-11-04 21:29:03',0,1,0),(32,1,1024,0,1,'2021-11-04 22:59:24',0,3,0),(33,1,1024,1,1,'2021-11-04 22:59:31',0,3,0),(34,1,1056,10,0,'2022-01-04 19:13:36',0,3,0),(35,21,1541,0,1,'2022-01-18 18:50:04',0,3,0),(36,21,1541,1,1,'2022-01-18 18:50:43',0,3,0),(37,19,2524,0,1,'2022-01-18 18:53:33',0,3,0),(38,1,1056,0,1,'2022-01-18 18:55:15',0,3,0),(39,1,1056,0,1,'2022-01-18 18:55:42',0,3,0),(40,19,2524,0,9,'2022-01-18 18:57:49',0,3,0),(41,19,2524,9,9,'2022-01-18 18:58:40',0,3,0),(42,1,1056,0,8,'2022-01-18 19:32:09',0,3,0),(43,1,1056,8,8,'2022-01-18 19:32:14',0,3,0),(44,1,1056,8,8,'2022-01-18 19:32:55',0,3,0),(45,23,3027,0,1,'2022-01-18 19:39:46',0,4,0),(46,23,3027,0,0,'2022-01-18 19:39:52',0,4,0),(47,28,3941,0,15,'2022-01-18 19:41:03',0,4,7.99),(48,28,3941,0,0,'2022-01-18 19:43:49',0,4,7.99),(49,25,2529,0,1,'2022-01-18 20:15:44',0,4,35.75),(50,27,1841,0,1,'2022-01-18 20:16:11',0,4,17.99),(51,25,2529,0,1,'2022-01-18 20:16:41',0,4,35.75),(52,27,1841,0,1,'2022-01-18 20:18:02',0,4,17.99),(53,27,1841,0,0,'2022-01-18 20:18:13',0,4,17.99),(54,26,1843,0,1,'2022-01-18 20:18:35',0,4,15.99),(55,26,1843,0,0,'2022-01-18 20:19:05',0,4,15.99),(56,24,2524,0,5,'2022-01-18 20:20:24',0,4,26.83),(57,24,2524,5,5,'2022-01-18 20:29:25',0,4,26.83),(58,24,2524,5,5,'2022-01-18 20:29:30',0,4,26.83),(59,29,1879,0,0,'2022-01-20 20:04:04',0,3,79.99),(60,30,1879,5,0,'2022-01-20 20:04:17',0,3,79.99),(61,31,2524,6,0,'2022-01-20 20:04:53',0,3,26.83),(62,32,4388,5,0,'2022-02-08 19:45:03',0,3,39.99),(63,31,2524,5,1,'2022-02-15 19:18:37',0,3,26.83),(64,31,2524,3,2,'2022-02-15 19:27:00',0,3,26.83),(65,30,1879,4,1,'2022-02-15 19:31:51',0,3,79.99),(66,32,4388,2,3,'2022-02-15 19:33:09',0,3,39.99),(67,31,2524,0,3,'2022-02-15 19:33:59',0,3,26.83),(68,30,1879,2,NULL,'2022-02-15 19:41:06',0,3,79.99),(69,30,1879,1,NULL,'2022-02-15 19:43:21',0,3,79.99),(70,33,2527,10,0,'2022-02-15 19:44:38',0,3,18.99),(71,33,2527,9,NULL,'2022-02-15 19:45:43',0,3,18.99),(72,30,1879,0,NULL,'2022-02-15 19:45:59',0,3,79.99),(73,33,2527,8,NULL,'2022-02-15 19:46:07',0,3,18.99),(74,33,2527,6,NULL,'2022-02-15 19:46:11',0,3,18.99),(75,34,2462,10,0,'2022-02-17 18:16:31',0,3,14.99),(76,35,2524,10,0,'2022-02-17 20:02:15',0,3,26.83),(77,10,4315,0,NULL,'2022-04-07 18:47:22',0,1,21.99),(78,34,2462,0,NULL,'2022-04-07 20:12:53',0,3,14.99);
/*!40000 ALTER TABLE `customerorderitemhist` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_customerorderitemhist_BI` BEFORE INSERT ON `customerorderitemhist` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'customerorderitemhist' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_customerorderitemhist_BU` BEFORE UPDATE ON `customerorderitemhist` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'customerorderitemhist' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_customerorderitemhist_BD` BEFORE DELETE ON `customerorderitemhist` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'customerorderitemhist' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `discount`
--

DROP TABLE IF EXISTS `discount`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `discount` (
  `DiscountID` int NOT NULL AUTO_INCREMENT,
  `DiscountName` varchar(50) NOT NULL,
  `minQty` int NOT NULL,
  `maxQty` int DEFAULT NULL,
  `Discount` double NOT NULL,
  PRIMARY KEY (`DiscountID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `discount`
--

LOCK TABLES `discount` WRITE;
/*!40000 ALTER TABLE `discount` DISABLE KEYS */;
INSERT INTO `discount` VALUES (1,'Half Case Discount',6,11,0.05),(2,'Case Discount',12,0,0.1);
/*!40000 ALTER TABLE `discount` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_discount_BI` BEFORE INSERT ON `discount` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'discount' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_discount_BU` BEFORE UPDATE ON `discount` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'discount' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_discount_BD` BEFORE DELETE ON `discount` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'discount' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `discount_inventory`
--

DROP TABLE IF EXISTS `discount_inventory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `discount_inventory` (
  `DiscountID` int NOT NULL,
  `InventoryID` int NOT NULL,
  PRIMARY KEY (`DiscountID`,`InventoryID`),
  KEY `Discount_Inventory_fk_Inventory_Description` (`InventoryID`),
  CONSTRAINT `Discount_Inventory_fk_Discount` FOREIGN KEY (`DiscountID`) REFERENCES `discount` (`DiscountID`) ON DELETE CASCADE,
  CONSTRAINT `Discount_Inventory_fk_Inventory_Description` FOREIGN KEY (`InventoryID`) REFERENCES `inventory_description` (`inventoryID`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `discount_inventory`
--

LOCK TABLES `discount_inventory` WRITE;
/*!40000 ALTER TABLE `discount_inventory` DISABLE KEYS */;
INSERT INTO `discount_inventory` VALUES (1,1030),(2,1030),(1,1031),(2,1031),(1,1032),(2,1032),(1,1034),(2,1034),(1,1035),(2,1035),(1,1036),(2,1036),(1,1044),(2,1044),(1,1050),(2,1050),(1,1053),(2,1053),(1,1056),(2,1056),(1,1059),(2,1059),(1,1060),(2,1060),(1,1061),(2,1061),(1,1066),(2,1066),(1,1067),(2,1067),(1,1069),(2,1069),(1,1092),(2,1092),(1,1093),(2,1093),(1,1094),(2,1094),(1,1095),(2,1095),(1,1096),(2,1096),(1,1108),(2,1108),(1,1109),(2,1109),(1,1110),(2,1110),(1,1129),(2,1129),(1,1130),(2,1130),(1,1131),(2,1131),(1,1132),(2,1132),(1,1133),(2,1133),(1,1155),(2,1155),(1,1159),(2,1159),(1,1179),(2,1179),(1,1180),(2,1180),(1,1190),(2,1190),(1,1191),(2,1191),(1,1195),(2,1195),(1,1260),(2,1260),(1,1261),(2,1261),(1,1273),(2,1273),(1,1278),(2,1278),(1,1279),(2,1279),(1,1296),(2,1296),(1,1360),(2,1360),(1,1361),(2,1361),(1,1439),(2,1439),(1,1440),(2,1440),(1,1441),(2,1441),(1,1442),(2,1442),(1,1444),(2,1444),(1,1445),(2,1445),(1,1446),(2,1446),(1,1447),(2,1447),(1,1448),(2,1448),(1,1449),(2,1449),(1,1450),(2,1450),(1,1451),(2,1451),(1,1452),(2,1452),(1,1453),(2,1453),(1,1454),(2,1454),(1,1455),(2,1455),(1,1456),(2,1456),(1,1457),(2,1457),(1,1458),(2,1458),(1,1459),(2,1459),(1,1460),(2,1460),(1,1461),(2,1461),(1,1462),(2,1462),(1,1463),(2,1463),(1,1464),(2,1464),(1,1465),(2,1465),(1,1466),(2,1466),(1,1467),(2,1467),(1,1468),(2,1468),(1,1469),(2,1469),(1,1470),(2,1470),(1,1471),(2,1471),(1,1472),(2,1472),(1,1473),(2,1473),(1,1479),(2,1479),(1,1480),(2,1480),(1,1481),(2,1481),(1,1482),(2,1482),(1,1483),(2,1483),(1,1484),(2,1484),(1,1485),(2,1485),(1,1486),(2,1486),(1,1487),(2,1487),(1,1488),(2,1488),(1,1489),(2,1489),(1,1490),(2,1490),(1,1491),(2,1491),(1,1492),(2,1492),(1,1493),(2,1493),(1,1494),(2,1494),(1,1495),(2,1495),(1,1496),(2,1496),(1,1497),(2,1497),(1,1498),(2,1498),(1,1499),(2,1499),(1,1500),(2,1500),(1,1501),(2,1501),(1,1502),(2,1502),(1,1503),(2,1503),(1,1504),(2,1504),(1,1505),(2,1505),(1,1506),(2,1506),(1,1508),(2,1508),(1,1509),(2,1509),(1,1510),(2,1510),(1,1511),(2,1511),(1,1512),(2,1512),(1,1513),(2,1513),(1,1514),(2,1514),(1,1515),(2,1515),(1,1516),(2,1516),(1,1517),(2,1517),(1,1518),(2,1518),(1,1519),(2,1519),(1,1520),(2,1520),(1,1521),(2,1521),(1,1522),(2,1522),(1,1523),(2,1523),(1,1524),(2,1524),(1,1525),(2,1525),(1,1526),(2,1526),(1,1527),(2,1527),(1,1528),(2,1528),(1,1529),(2,1529),(1,1530),(2,1530),(1,1531),(2,1531),(1,1532),(2,1532),(1,1533),(2,1533),(1,1536),(2,1536),(1,1537),(2,1537),(1,1538),(2,1538),(1,1539),(2,1539),(1,1540),(2,1540),(1,1541),(2,1541),(1,1542),(2,1542),(1,1543),(2,1543),(1,1545),(2,1545),(1,1546),(2,1546),(1,1547),(2,1547),(1,1548),(2,1548),(1,1549),(2,1549),(1,1550),(2,1550),(1,1551),(2,1551),(1,1552),(2,1552),(1,1553),(2,1553),(1,1554),(2,1554),(1,1555),(2,1555),(1,1556),(2,1556),(1,1557),(2,1557),(1,1558),(2,1558),(1,1559),(2,1559),(1,1560),(2,1560),(1,1561),(2,1561),(1,1562),(2,1562),(1,1563),(2,1563),(1,1564),(2,1564),(1,1565),(2,1565),(1,1567),(2,1567),(1,1568),(2,1568),(1,1569),(2,1569),(1,1570),(2,1570),(1,1571),(2,1571),(1,1572),(2,1572),(1,1573),(2,1573),(1,1574),(2,1574),(1,1575),(2,1575),(1,1576),(2,1576),(1,1577),(2,1577),(1,1578),(2,1578),(1,1580),(2,1580),(1,1581),(2,1581),(1,1583),(2,1583),(1,1584),(2,1584),(1,1585),(2,1585),(1,1586),(2,1586),(1,1587),(2,1587),(1,1588),(2,1588),(1,1589),(2,1589),(1,1590),(2,1590),(1,1591),(2,1591),(1,1592),(2,1592),(1,1593),(2,1593),(1,1594),(2,1594),(1,1595),(2,1595),(1,1596),(2,1596),(1,1597),(2,1597),(1,1598),(2,1598),(1,1601),(2,1601),(1,1602),(2,1602),(1,1603),(2,1603),(1,1607),(2,1607),(1,1608),(2,1608),(1,1610),(2,1610),(1,1611),(2,1611),(1,1612),(2,1612),(1,1613),(2,1613),(1,1614),(2,1614),(1,1615),(2,1615),(1,1616),(2,1616),(1,1617),(2,1617),(1,1618),(2,1618),(1,1620),(2,1620),(1,1621),(2,1621),(1,1622),(2,1622),(1,1623),(2,1623),(1,1624),(2,1624),(1,1625),(2,1625),(1,1626),(2,1626),(1,1627),(2,1627),(1,1628),(2,1628),(1,1629),(2,1629),(1,1630),(2,1630),(1,1631),(2,1631),(1,1632),(2,1632),(1,1634),(2,1634),(1,1635),(2,1635),(1,1636),(2,1636),(1,1637),(2,1637),(1,1639),(2,1639),(1,1640),(2,1640),(1,1641),(2,1641),(1,1642),(2,1642),(1,1643),(2,1643),(1,1645),(2,1645),(1,1649),(2,1649),(1,1650),(2,1650),(1,1651),(2,1651),(1,1652),(2,1652),(1,1653),(2,1653),(1,1654),(2,1654),(1,1655),(2,1655),(1,1656),(2,1656),(1,1658),(2,1658),(1,1659),(2,1659),(1,1660),(2,1660),(1,1661),(2,1661),(1,1662),(2,1662),(1,1663),(2,1663),(1,1664),(2,1664),(1,1665),(2,1665),(1,1666),(2,1666),(1,1667),(2,1667),(1,1668),(2,1668),(1,1669),(2,1669),(1,1670),(2,1670),(1,1671),(2,1671),(1,1672),(2,1672),(1,1673),(2,1673),(1,1674),(2,1674),(1,1675),(2,1675),(1,1676),(2,1676),(1,1677),(2,1677),(1,1678),(2,1678),(1,1679),(2,1679),(1,1680),(2,1680),(1,1681),(2,1681),(1,1682),(2,1682),(1,1683),(2,1683),(1,1684),(2,1684),(1,1686),(2,1686),(1,1687),(2,1687),(1,1688),(2,1688),(1,1689),(2,1689),(1,1690),(2,1690),(1,1691),(2,1691),(1,1692),(2,1692),(1,1693),(2,1693),(1,1694),(2,1694),(1,1695),(2,1695),(1,1696),(2,1696),(1,1697),(2,1697),(1,1698),(2,1698),(1,1699),(2,1699),(1,1700),(2,1700),(1,1701),(2,1701),(1,1702),(2,1702),(1,1703),(2,1703),(1,1704),(2,1704),(1,1705),(2,1705),(1,1706),(2,1706),(1,1707),(2,1707),(1,1710),(2,1710),(1,1711),(2,1711),(1,1712),(2,1712),(1,1713),(2,1713),(1,1714),(2,1714),(1,1715),(2,1715),(1,1717),(2,1717),(1,1718),(2,1718),(1,1719),(2,1719),(1,1720),(2,1720),(1,1721),(2,1721),(1,1722),(2,1722),(1,1723),(2,1723),(1,1724),(2,1724),(1,1725),(2,1725),(1,1726),(2,1726),(1,1727),(2,1727),(1,1728),(2,1728),(1,1729),(2,1729),(1,1730),(2,1730),(1,1731),(2,1731),(1,1732),(2,1732),(1,1733),(2,1733),(1,1734),(2,1734),(1,1735),(2,1735),(1,1736),(2,1736),(1,1737),(2,1737),(1,1738),(2,1738),(1,1739),(2,1739),(1,1740),(2,1740),(1,1741),(2,1741),(1,1742),(2,1742),(1,1743),(2,1743),(1,1744),(2,1744),(1,1745),(2,1745),(1,1746),(2,1746),(1,1747),(2,1747),(1,1748),(2,1748),(1,1749),(2,1749),(1,1750),(2,1750),(1,1751),(2,1751),(1,1752),(2,1752),(1,1753),(2,1753),(1,1754),(2,1754),(1,1755),(2,1755),(1,1756),(2,1756),(1,1757),(2,1757),(1,1758),(2,1758),(1,1759),(2,1759),(1,1760),(2,1760),(1,1761),(2,1761),(1,1762),(2,1762),(1,1763),(2,1763),(1,1764),(2,1764),(1,1765),(2,1765),(1,1767),(2,1767),(1,1768),(2,1768),(1,1769),(2,1769),(1,1770),(2,1770),(1,1771),(2,1771),(1,1772),(2,1772),(1,1773),(2,1773),(1,1774),(2,1774),(1,1775),(2,1775),(1,1776),(2,1776),(1,1777),(2,1777),(1,1778),(2,1778),(1,1785),(2,1785),(1,1786),(2,1786),(1,1787),(2,1787),(1,1788),(2,1788),(1,1789),(2,1789),(1,1790),(2,1790),(1,1791),(2,1791),(1,1792),(2,1792),(1,1793),(2,1793),(1,1794),(2,1794),(1,1795),(2,1795),(1,1798),(2,1798),(1,1799),(2,1799),(1,1800),(2,1800),(1,1801),(2,1801),(1,1802),(2,1802),(1,1803),(2,1803),(1,1804),(2,1804),(1,1805),(2,1805),(1,1806),(2,1806),(1,1807),(2,1807),(1,1808),(2,1808),(1,1809),(2,1809),(1,1810),(2,1810),(1,1811),(2,1811),(1,1812),(2,1812),(1,1813),(2,1813),(1,1814),(2,1814),(1,1815),(2,1815),(1,1816),(2,1816),(1,1817),(2,1817),(1,1818),(2,1818),(1,1819),(2,1819),(1,1820),(2,1820),(1,1821),(2,1821),(1,1826),(2,1826),(1,1827),(2,1827),(1,1828),(2,1828),(1,1829),(2,1829),(1,1831),(2,1831),(1,1832),(2,1832),(1,1833),(2,1833),(1,1834),(2,1834),(1,1835),(2,1835),(1,1836),(2,1836),(1,1837),(2,1837),(1,1838),(2,1838),(1,1839),(2,1839),(1,1840),(2,1840),(1,1841),(2,1841),(1,1842),(2,1842),(1,1843),(2,1843),(1,1844),(2,1844),(1,1845),(2,1845),(1,1846),(2,1846),(1,1847),(2,1847),(1,1848),(2,1848),(1,1849),(2,1849),(1,1850),(2,1850),(1,1851),(2,1851),(1,1852),(2,1852),(1,1853),(2,1853),(1,1854),(2,1854),(1,1855),(2,1855),(1,1856),(2,1856),(1,1857),(2,1857),(1,1858),(2,1858),(1,1859),(2,1859),(1,1860),(2,1860),(1,1861),(2,1861),(1,1862),(2,1862),(1,1863),(2,1863),(1,1864),(2,1864),(1,1865),(2,1865),(1,1866),(2,1866),(1,1867),(2,1867),(1,1868),(2,1868),(1,1869),(2,1869),(1,1870),(2,1870),(1,1871),(2,1871),(1,1872),(2,1872),(1,1873),(2,1873),(1,1874),(2,1874),(1,1878),(2,1878),(1,1879),(2,1879),(1,1880),(2,1880),(1,1881),(2,1881),(1,1882),(2,1882),(1,1883),(2,1883),(1,1884),(2,1884),(1,1886),(2,1886),(1,1888),(2,1888),(1,1892),(2,1892),(1,1893),(2,1893),(1,1895),(2,1895),(1,1896),(2,1896),(1,1900),(2,1900),(1,1901),(2,1901),(1,1902),(2,1902),(1,1903),(2,1903),(1,1904),(2,1904),(1,1905),(2,1905),(1,1906),(2,1906),(1,1907),(2,1907),(1,1910),(2,1910),(1,1918),(2,1918),(1,1921),(2,1921),(1,1922),(2,1922),(1,1923),(2,1923),(1,1924),(2,1924),(1,1925),(2,1925),(1,1926),(2,1926),(1,1927),(2,1927),(1,1928),(2,1928),(1,1929),(2,1929),(1,1930),(2,1930),(1,1939),(2,1939),(1,1987),(2,1987),(1,1990),(2,1990),(1,1992),(2,1992),(1,1995),(2,1995),(1,1996),(2,1996),(1,1997),(2,1997),(1,1998),(2,1998),(1,1999),(2,1999),(1,2000),(2,2000),(1,2004),(2,2004),(1,2005),(2,2005),(1,2006),(2,2006),(1,2008),(2,2008),(1,2009),(2,2009),(1,2010),(2,2010),(1,2012),(2,2012),(1,2015),(2,2015),(1,2025),(2,2025),(1,2026),(2,2026),(1,2027),(2,2027),(1,2028),(2,2028),(1,2029),(2,2029),(1,2037),(2,2037),(1,2038),(2,2038),(1,2099),(2,2099),(1,2100),(2,2100),(1,2101),(2,2101),(1,2102),(2,2102),(1,2103),(2,2103),(1,2104),(2,2104),(1,2105),(2,2105),(1,2106),(2,2106),(1,2107),(2,2107),(1,2108),(2,2108),(1,2109),(2,2109),(1,2110),(2,2110),(1,2111),(2,2111),(1,2114),(2,2114),(1,2115),(2,2115),(1,2118),(2,2118),(1,2119),(2,2119),(1,2122),(2,2122),(1,2123),(2,2123),(1,2124),(2,2124),(1,2126),(2,2126),(1,2128),(2,2128),(1,2129),(2,2129),(1,2130),(2,2130),(1,2131),(2,2131),(1,2132),(2,2132),(1,2133),(2,2133),(1,2135),(2,2135),(1,2136),(2,2136),(1,2137),(2,2137),(1,2138),(2,2138),(1,2139),(2,2139),(1,2140),(2,2140),(1,2141),(2,2141),(1,2143),(2,2143),(1,2145),(2,2145),(1,2146),(2,2146),(1,2147),(2,2147),(1,2150),(2,2150),(1,2151),(2,2151),(1,2152),(2,2152),(1,2153),(2,2153),(1,2154),(2,2154),(1,2155),(2,2155),(1,2162),(2,2162),(1,2163),(2,2163),(1,2164),(2,2164),(1,2165),(2,2165),(1,2166),(2,2166),(1,2170),(2,2170),(1,2171),(2,2171),(1,2172),(2,2172),(1,2173),(2,2173),(1,2174),(2,2174),(1,2175),(2,2175),(1,2176),(2,2176),(1,2177),(2,2177),(1,2178),(2,2178),(1,2179),(2,2179),(1,2180),(2,2180),(1,2181),(2,2181),(1,2182),(2,2182),(1,2183),(2,2183),(1,2184),(2,2184),(1,2185),(2,2185),(1,2186),(2,2186),(1,2191),(2,2191),(1,2195),(2,2195),(1,2201),(2,2201),(1,2202),(2,2202),(1,2203),(2,2203),(1,2204),(2,2204),(1,2205),(2,2205),(1,2206),(2,2206),(1,2208),(2,2208),(1,2218),(2,2218),(1,2219),(2,2219),(1,2221),(2,2221),(1,2222),(2,2222),(1,2226),(2,2226),(1,2229),(2,2229),(1,2232),(2,2232),(1,2233),(2,2233),(1,2235),(2,2235),(1,2236),(2,2236),(1,2238),(2,2238),(1,2239),(2,2239),(1,2240),(2,2240),(1,2241),(2,2241),(1,2242),(2,2242),(1,2246),(2,2246),(1,2253),(2,2253),(1,2254),(2,2254),(1,2255),(2,2255),(1,2257),(2,2257),(1,2259),(2,2259),(1,2260),(2,2260),(1,2261),(2,2261),(1,2262),(2,2262),(1,2263),(2,2263),(1,2264),(2,2264),(1,2265),(2,2265),(1,2266),(2,2266),(1,2267),(2,2267),(1,2269),(2,2269),(1,2270),(2,2270),(1,2271),(2,2271),(1,2287),(2,2287),(1,2288),(2,2288),(1,2292),(2,2292),(1,2297),(2,2297),(1,2301),(2,2301),(1,2302),(2,2302),(1,2303),(2,2303),(1,2305),(2,2305),(1,2306),(2,2306),(1,2307),(2,2307),(1,2309),(2,2309),(1,2310),(2,2310),(1,2314),(2,2314),(1,2319),(2,2319),(1,2320),(2,2320),(1,2322),(2,2322),(1,2323),(2,2323),(1,2324),(2,2324),(1,2325),(2,2325),(1,2326),(2,2326),(1,2327),(2,2327),(1,2328),(2,2328),(1,2329),(2,2329),(1,2330),(2,2330),(1,2331),(2,2331),(1,2332),(2,2332),(1,2334),(2,2334),(1,2335),(2,2335),(1,2337),(2,2337),(1,2338),(2,2338),(1,2339),(2,2339),(1,2340),(2,2340),(1,2341),(2,2341),(1,2342),(2,2342),(1,2343),(2,2343),(1,2344),(2,2344),(1,2345),(2,2345),(1,2346),(2,2346),(1,2353),(2,2353),(1,2354),(2,2354),(1,2356),(2,2356),(1,2358),(2,2358),(1,2359),(2,2359),(1,2360),(2,2360),(1,2361),(2,2361),(1,2362),(2,2362),(1,2363),(2,2363),(1,2366),(2,2366),(1,2367),(2,2367),(1,2368),(2,2368),(1,2369),(2,2369),(1,2370),(2,2370),(1,2371),(2,2371),(1,2372),(2,2372),(1,2374),(2,2374),(1,2376),(2,2376),(1,2377),(2,2377),(1,2378),(2,2378),(1,2379),(2,2379),(1,2380),(2,2380),(1,2382),(2,2382),(1,2383),(2,2383),(1,2384),(2,2384),(1,2385),(2,2385),(1,2386),(2,2386),(1,2387),(2,2387),(1,2388),(2,2388),(1,2389),(2,2389),(1,2390),(2,2390),(1,2394),(2,2394),(1,2398),(2,2398),(1,2400),(2,2400),(1,2401),(2,2401),(1,2402),(2,2402),(1,2403),(2,2403),(1,2404),(2,2404),(1,2406),(2,2406),(1,2407),(2,2407),(1,2408),(2,2408),(1,2411),(2,2411),(1,2412),(2,2412),(1,2413),(2,2413),(1,2414),(2,2414),(1,2415),(2,2415),(1,2417),(2,2417),(1,2422),(2,2422),(1,2423),(2,2423),(1,2424),(2,2424),(1,2428),(2,2428),(1,2429),(2,2429),(1,2430),(2,2430),(1,2432),(2,2432),(1,2433),(2,2433),(1,2434),(2,2434),(1,2442),(2,2442),(1,2443),(2,2443),(1,2447),(2,2447),(1,2448),(2,2448),(1,2449),(2,2449),(1,2462),(2,2462),(1,2464),(2,2464),(1,2465),(2,2465),(1,2466),(2,2466),(1,2467),(2,2467),(1,2468),(2,2468),(1,2470),(2,2470),(1,2471),(2,2471),(1,2476),(2,2476),(1,2478),(2,2478),(1,2479),(2,2479),(1,2480),(2,2480),(1,2481),(2,2481),(1,2487),(2,2487),(1,2490),(2,2490),(1,2491),(2,2491),(1,2492),(2,2492),(1,2493),(2,2493),(1,2494),(2,2494),(1,2498),(2,2498),(1,2500),(2,2500),(1,2501),(2,2501),(1,2503),(2,2503),(1,2505),(2,2505),(1,2506),(2,2506),(1,2507),(2,2507),(1,2509),(2,2509),(1,2510),(2,2510),(1,2511),(2,2511),(1,2512),(2,2512),(1,2513),(2,2513),(1,2514),(2,2514),(1,2521),(2,2521),(1,2522),(2,2522),(1,2523),(2,2523),(1,2524),(2,2524),(1,2525),(2,2525),(1,2526),(2,2526),(1,2527),(2,2527),(1,2528),(2,2528),(1,2529),(2,2529),(1,2530),(2,2530),(1,2531),(2,2531),(1,2532),(2,2532),(1,2533),(2,2533),(1,2534),(2,2534),(1,2535),(2,2535),(1,2536),(2,2536),(1,2537),(2,2537),(1,2538),(2,2538),(1,2539),(2,2539),(1,2540),(2,2540),(1,2541),(2,2541),(1,2542),(2,2542),(1,2545),(2,2545),(1,2548),(2,2548),(1,2549),(2,2549),(1,2554),(2,2554),(1,2555),(2,2555),(1,2578),(2,2578),(1,2585),(2,2585),(1,2586),(2,2586),(1,2587),(2,2587),(1,2588),(2,2588),(1,2589),(2,2589),(1,2590),(2,2590),(1,2591),(2,2591),(1,2592),(2,2592),(1,2593),(2,2593),(1,2597),(2,2597),(1,2598),(2,2598),(1,2599),(2,2599),(1,2600),(2,2600),(1,2601),(2,2601),(1,2602),(2,2602),(1,2603),(2,2603),(1,2604),(2,2604),(1,2607),(2,2607),(1,2608),(2,2608),(1,2609),(2,2609),(1,2611),(2,2611),(1,2612),(2,2612),(1,2613),(2,2613),(1,2614),(2,2614),(1,2615),(2,2615),(1,2616),(2,2616),(1,2617),(2,2617),(1,2618),(2,2618),(1,2619),(2,2619),(1,2620),(2,2620),(1,2621),(2,2621),(1,2622),(2,2622),(1,2623),(2,2623),(1,2625),(2,2625),(1,2626),(2,2626),(1,2627),(2,2627),(1,2628),(2,2628),(1,2629),(2,2629),(1,2630),(2,2630),(1,2631),(2,2631),(1,2632),(2,2632),(1,2633),(2,2633),(1,2634),(2,2634),(1,2635),(2,2635),(1,2637),(2,2637),(1,2638),(2,2638),(1,2639),(2,2639),(1,2777),(2,2777),(1,2795),(2,2795);
/*!40000 ALTER TABLE `discount_inventory` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_discount_inventory_BI` BEFORE INSERT ON `discount_inventory` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'discount_inventory' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_discount_inventory_BU` BEFORE UPDATE ON `discount_inventory` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'discount_inventory' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_discount_inventory_BD` BEFORE DELETE ON `discount_inventory` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'discount_inventory' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `discount_type`
--

DROP TABLE IF EXISTS `discount_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `discount_type` (
  `DiscountID` int NOT NULL,
  `typeID` int NOT NULL,
  PRIMARY KEY (`DiscountID`,`typeID`),
  KEY `Discount_Type_fk_Inventory_Type` (`typeID`),
  CONSTRAINT `Discount_Type_fk_Discount` FOREIGN KEY (`DiscountID`) REFERENCES `discount` (`DiscountID`) ON DELETE CASCADE,
  CONSTRAINT `Discount_Type_fk_Inventory_Type` FOREIGN KEY (`typeID`) REFERENCES `inventory_type` (`typeID`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `discount_type`
--

LOCK TABLES `discount_type` WRITE;
/*!40000 ALTER TABLE `discount_type` DISABLE KEYS */;
/*!40000 ALTER TABLE `discount_type` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_discount_type_BI` BEFORE INSERT ON `discount_type` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'discount_type' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_discount_type_BU` BEFORE UPDATE ON `discount_type` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'discount_type' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_discount_type_BD` BEFORE DELETE ON `discount_type` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'discount_type' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee` (
  `emp_id` int NOT NULL AUTO_INCREMENT,
  `pin_number` int NOT NULL,
  `first_name` varchar(40) DEFAULT NULL,
  `last_name` varchar(40) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `addr1` varchar(40) DEFAULT NULL,
  `addr2` varchar(40) DEFAULT NULL,
  `city` varchar(50) DEFAULT NULL,
  `state` varchar(2) DEFAULT NULL,
  `zip` varchar(10) DEFAULT NULL,
  `phone` varchar(15) DEFAULT NULL,
  `typeID` int NOT NULL,
  PRIMARY KEY (`emp_id`),
  UNIQUE KEY `emp_id_UNIQUE` (`emp_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (0,1997613874,'Employee','',NULL,NULL,NULL,NULL,NULL,NULL,NULL,3),(1,123,'Lauren','Chalupsky-Cannon',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1);
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_employee_BI` BEFORE INSERT ON `employee` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'employee' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_employee_BU` BEFORE UPDATE ON `employee` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'employee' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_employee_BD` BEFORE DELETE ON `employee` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'employee' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `employeerole`
--

DROP TABLE IF EXISTS `employeerole`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employeerole` (
  `roleId` int NOT NULL AUTO_INCREMENT,
  `roleName` varchar(255) NOT NULL,
  `roleDescription` varchar(1000) DEFAULT NULL,
  PRIMARY KEY (`roleId`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employeerole`
--

LOCK TABLES `employeerole` WRITE;
/*!40000 ALTER TABLE `employeerole` DISABLE KEYS */;
INSERT INTO `employeerole` VALUES (1,'Lookup','Lookup give you the ability to lookup unknown items'),(2,'Employee Admin','Employee Admin give you the ability to add, delete, modify and change permissions for any employee'),(3,'Cash Drawer','Cash drawer give the ability to open the cash drawer at any time'),(4,'Orders','Orders gives you access to Customer and Vendor orders'),(5,'Event','Event gives you the ability to modify events'),(6,'Shipping','Shipping give you the ability to add shipping to an order'),(7,'Custom','Custom gives you the ability to add a custom item to a transaction'),(8,'Discount','Discount gives you the ability to add discounts to a transaction'),(9,'Customer','Customer give you the ability to add and edit customers'),(10,'Settings','Settings gives you access to hardware changes and other preferences');
/*!40000 ALTER TABLE `employeerole` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employeetype`
--

DROP TABLE IF EXISTS `employeetype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employeetype` (
  `typeId` int NOT NULL AUTO_INCREMENT,
  `typeName` varchar(255) NOT NULL,
  PRIMARY KEY (`typeId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employeetype`
--

LOCK TABLES `employeetype` WRITE;
/*!40000 ALTER TABLE `employeetype` DISABLE KEYS */;
INSERT INTO `employeetype` VALUES (1,'admin'),(2,'manager'),(3,'cashier');
/*!40000 ALTER TABLE `employeetype` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employeetyperole`
--

DROP TABLE IF EXISTS `employeetyperole`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employeetyperole` (
  `typeId` int NOT NULL,
  `roleId` int NOT NULL,
  PRIMARY KEY (`typeId`,`roleId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employeetyperole`
--

LOCK TABLES `employeetyperole` WRITE;
/*!40000 ALTER TABLE `employeetyperole` DISABLE KEYS */;
INSERT INTO `employeetyperole` VALUES (1,1),(1,2),(1,3),(1,4),(1,5),(1,6),(1,7),(1,8),(1,9),(1,10),(2,1),(2,2),(2,3),(2,4),(2,5),(2,6),(2,7),(2,8),(2,9),(2,10),(3,1),(3,2),(3,3),(3,4),(3,5),(3,6),(3,7),(3,8),(3,9),(3,10);
/*!40000 ALTER TABLE `employeetyperole` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `event_waitlist`
--

DROP TABLE IF EXISTS `event_waitlist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `event_waitlist` (
  `eventId` int NOT NULL,
  `customerId` int NOT NULL,
  `customerName` varchar(45) NOT NULL,
  `dateAdded` datetime NOT NULL,
  PRIMARY KEY (`eventId`,`customerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='		';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `event_waitlist`
--

LOCK TABLES `event_waitlist` WRITE;
/*!40000 ALTER TABLE `event_waitlist` DISABLE KEYS */;
INSERT INTO `event_waitlist` VALUES (2885,1,'Bob Roberts','2021-05-13 20:06:02'),(2886,2,'Jane Doe','2021-05-20 18:55:25');
/*!40000 ALTER TABLE `event_waitlist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `events`
--

DROP TABLE IF EXISTS `events`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `events` (
  `inventoryID` int NOT NULL,
  `EventDate` datetime DEFAULT NULL,
  `Duration` datetime DEFAULT NULL,
  `Preorder` double DEFAULT NULL,
  `AtDoor` double DEFAULT NULL,
  PRIMARY KEY (`inventoryID`),
  CONSTRAINT `fk_Event_InventoryID` FOREIGN KEY (`inventoryID`) REFERENCES `inventory_description` (`inventoryID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `events`
--

LOCK TABLES `events` WRITE;
/*!40000 ALTER TABLE `events` DISABLE KEYS */;
INSERT INTO `events` VALUES (2883,'2021-03-26 01:10:05','2021-03-26 01:10:05',0,0),(2885,'2021-04-02 00:07:09','2021-04-02 00:07:09',0,0),(4428,'2021-08-27 18:37:46','2021-08-27 18:37:46',20,25),(4430,'2022-01-04 19:08:05','2022-01-04 19:08:05',10,15),(4448,'2022-04-09 20:44:47','2022-04-10 20:44:47',10,15);
/*!40000 ALTER TABLE `events` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_events_BI` BEFORE INSERT ON `events` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'events' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_events_BU` BEFORE UPDATE ON `events` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'events' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_events_BD` BEFORE DELETE ON `events` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'events' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `inventory_description`
--

DROP TABLE IF EXISTS `inventory_description`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `inventory_description` (
  `inventoryID` int NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `supplierID` int DEFAULT NULL,
  `barcode` varchar(50) NOT NULL,
  `retail_price` double NOT NULL,
  `description` varchar(100) DEFAULT NULL,
  `typeID` int NOT NULL,
  `bottle_deposit_qty` int DEFAULT NULL,
  `nontaxable` tinyint DEFAULT '0',
  `nontaxable_local` tinyint DEFAULT '0',
  `hidden` tinyint(1) DEFAULT '0',
  `InvMin` int DEFAULT '0',
  `InvMax` int DEFAULT '0',
  `OrderQty` int NOT NULL DEFAULT '0',
  `DefaultsupplyPrice` double DEFAULT NULL,
  `orderIncrement` int NOT NULL DEFAULT '1',
  PRIMARY KEY (`inventoryID`),
  UNIQUE KEY `barcode_UNIQUE` (`barcode`),
  KEY `typeID` (`typeID`),
  CONSTRAINT `Inventory_Description_fk_Inventory_type` FOREIGN KEY (`typeID`) REFERENCES `inventory_type` (`typeID`)
) ENGINE=InnoDB AUTO_INCREMENT=4450 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventory_description`
--

LOCK TABLES `inventory_description` WRITE;
/*!40000 ALTER TABLE `inventory_description` DISABLE KEYS */;
INSERT INTO `inventory_description` VALUES (1024,'Private Preserve',12,'000231904863',10.99,'Private Preserve',1,0,0,0,0,1,0,0,NULL,1),(1025,'Saranac Ginger Beer',12,'009450040253',6.99,'Saranac Ginger Beer',15,6,0,0,0,0,0,0,6.99,1),(1026,'Lindor Milk Chocolate',12,'009542015855',1.25,'Lindor Milk Chocolate',3,NULL,0,0,0,0,0,0,1.25,1),(1027,'Lindor 8.8oz Chocolate',12,'009542035501',9.99,'Lindor 8.8oz Chocolate',3,NULL,0,0,0,0,0,0,9.99,1),(1028,'Corn pasta',12,'00963398',2.99,'Corn pasta',4,NULL,1,0,0,0,0,0,2.99,1),(1029,'Glaze, Balsamic',12,'00978927',6.99,'Glaze, Balsamic',4,NULL,1,0,0,0,0,0,6.99,1),(1030,'Joseph Phelps Insignia 2012',21,'010465709608',239.99,'Joseph Phelps Insignia 2012',5,1,0,0,0,0,2,0,190,12),(1031,'Martini & Rossi 375ml Dry Vermouth',10,'011034420078',8.99,'Martini & Rossi 375ml Dry Vermouth',5,1,0,0,0,0,2,0,6,12),(1032,'Martini & Rossi Asti Sparkling Wine',12,'011034500053',11.99,'Martini & Rossi Asti Sparkling Wine',5,1,0,0,0,0,2,0,11.99,12),(1033,'Tobasco 2oz',12,'011210000018',3.99,'Tobasco 2oz',4,NULL,1,0,0,0,0,0,2.99,1),(1034,'Whitehall Lane Napa Valley Cabernet Sauvignon 2010',12,'011628375012',24.99,'Whitehall Lane Napa Valley Cabernet Sauvignon 2010',5,1,0,0,0,0,2,0,24.99,12),(1035,'Beaujolais Nouveau',12,'011699008741',7.99,'Beaujolais Nouveau',5,1,0,0,0,0,2,0,7.99,12),(1036,'Les Ursulines Bourgogne Chardonnay 2013',19,'011699012090',19.99,'Les Ursulines Bourgogne Chardonnay 2013',5,1,0,0,0,0,2,0,13.99,12),(1037,'Bubly Grapefruit 12oz',12,'012000171277',1,'Bubly Grapefruit 12oz',2,NULL,0,0,0,0,0,0,1,1),(1038,'Bubly Strawberry 12oz',12,'012000171321',1,'Bubly Strawberry 12oz',15,20,0,0,0,0,0,0,1,1),(1039,'Gift Basket',21,'012000171475',145,'Mississippi Mud',6,NULL,0,0,0,0,0,0,110,1),(1040,'Starbucks Frappuccino Vanilla',12,'01241000',2.75,'Starbucks Frappuccino Vanilla',4,NULL,1,0,0,0,0,0,2.75,1),(1041,'Trident Gum',12,'012546612296',1.49,'Trident Gum',3,NULL,0,0,0,0,0,0,1.49,1),(1042,'Trident Tropical Twist',12,'012546619592',1.49,'Trident Tropical Twist',3,NULL,0,0,0,0,0,0,1.49,1),(1043,'ID BerryMelon',12,'012546685016',1.89,'ID BerryMelon',3,NULL,0,0,0,0,0,0,1.89,1),(1044,'Flore de Moscato',12,'013022000392',12.99,'Flore de Moscato',5,1,0,0,0,0,2,0,12.99,12),(1045,'Pistachios',12,'014113911856',1.75,'Pistachios',4,NULL,1,0,0,0,0,0,1,1),(1046,'Cotton Candy',12,'014200003259',2.5,'Cotton Candy',2,NULL,0,0,0,0,0,0,1.25,1),(1047,'Sugar Babies',12,'014200535453',1.99,'Sugar Babies',2,NULL,0,0,0,0,0,0,1,1),(1048,'Creamy Delight Hard Candy',12,'014272466259',2.99,'Creamy Delight Hard Candy',4,NULL,1,0,0,0,0,0,2.99,1),(1049,'Fuzz Peach Kolch',12,'015024626211',1.99,'Fuzz Peach Kolch',6,1,0,0,0,0,0,0,1.99,1),(1050,'Freemark Abbey Napa Cabernet 2015',13,'015917026968',56.99,'Freemark Abbey Napa Cabernet 2015',5,1,0,0,0,0,2,0,37.5,12),(1051,'Millstream Schokolade Bock',1,'015925321680',10.99,'Fuzz Peach Kolch 6 Pack',6,6,0,0,0,0,0,0,7.25,1),(1052,'Back Road Stout 6 Pack',10,'015925346218',10.99,'Back Road Stout 6 Pack',6,6,0,0,0,0,0,0,7.25,1),(1053,'Chulk Hill Chardonnay',12,'016236001032',38.99,'Chulk Hill Chardonnay',5,1,0,0,0,0,2,0,38.99,12),(1054,'Rose\'s Sweetened Lime Juice',12,'016600000739',6.99,'Rose\'s Sweetened Lime Juice',4,NULL,1,0,0,0,0,0,6.99,1),(1055,'Rose Sweetend Lime Juice',21,'01660433',4.99,'Rose Sweetend Lime Juice',4,NULL,1,0,0,0,0,0,4.99,1),(1056,'DeLoach Merlot 2015',19,'016697000766',6.99,'DeLoach Merlot 2015',5,1,0,0,0,6,2,0,6,12),(1057,'Jack Link\'s, Original',12,'017082000033',1.99,'Jack Link\'s, Original',4,NULL,1,0,0,0,0,0,1.99,1),(1058,'Jack Link\'s Beef Stips',12,'017082885166',1.99,'Jack Link\'s Beef Stips',4,NULL,1,0,0,0,0,0,1.99,1),(1059,'Caymus Cabernet Sauvignon 2016',19,'017224712107',89.99,'Caymus Cabernet Sauvignon 2016',5,1,0,0,0,0,2,0,64.8,12),(1060,'Caymus special selection Cabernet Sauvignon 2014',12,'017224720102',179.99,'Caymus special selection Cabernet Sauvignon 2014',5,1,0,0,0,0,2,0,179.99,12),(1061,'Caymus Conundrum',12,'017224750123',17.99,'Caymus Conundrum',5,1,0,0,0,0,2,0,17.99,12),(1062,'Band-aids 20ct',12,'017276229998',1.89,'Band-aids 20ct',1,NULL,0,0,0,0,0,0,1.89,1),(1063,'Band-aids 20ct',12,'017276230963',1.89,'Band-aids 20ct',1,NULL,0,0,0,0,0,0,1.89,1),(1064,'Transformers Bandaids',21,'017276233544',2.5,'Transformers Bandaids',1,NULL,0,0,0,0,0,0,1.5,1),(1065,'Pets 2 Bandaids',21,'017276235425',2.5,'Pets 2 Bandaids',1,NULL,0,0,0,0,0,0,1.5,1),(1066,'Don Simon Sangria',19,'017619009096',8.99,'Don Simon Sangria',5,1,0,0,0,0,2,0,5,12),(1067,'Pata Negra Ribera Del Duero Crianza',19,'017619041010',13.99,'Pata Negra Ribera Del Duero Crianza',5,1,0,0,0,0,2,0,10,12),(1068,'Bud Light Can 12 oz',1,'01810622',1.99,'Bud Light Can 12 oz',6,NULL,0,0,0,0,0,0,0.99,1),(1069,'Gavilan Pinot Noir 2014',19,'018138104057',18.99,'Gavilan Pinot Noir 2014',5,1,0,0,0,0,2,0,12,12),(1070,'Busch Light 12oz Can',1,'01818828',1.99,'Busch Light 12oz Can',6,NULL,0,0,0,0,0,0,0.92,1),(1071,'Busch Lite 12 Pack',1,'018200008016',14.99,'Busch Lite 12 Pack',6,12,0,0,0,0,0,0,10,1),(1072,'Shock Top',12,'018200008672',1.99,'Shock Top',6,1,0,0,0,0,0,0,1.99,1),(1073,'Michelob Amber Bock',1,'018200009747',10.99,'Michelob Amber Bock',6,NULL,0,0,0,0,0,0,7.5,1),(1074,'Michelob Ultra 6-pack Bottles',1,'018200059896',9.99,'Michelob Ultra 6-pack Bottles',6,6,0,0,0,0,0,0,7.25,1),(1075,'Michelob Ultra 12 pack cans',1,'018200069918',17.99,'Michelob Ultra 12 pack cans',6,NULL,0,0,0,0,0,0,13.4,1),(1076,'Land Shark Lager 6 Pack',1,'018200129827',9.99,'Land Shark Lager 6 Pack',6,6,0,0,0,0,0,0,7.05,1),(1077,'Shock Top 6 Pack',1,'018200139864',10.99,'Shock Top 6 Pack',6,6,0,0,0,0,0,0,7.5,1),(1078,'Bud light Lime 6 pack',1,'018200149917',10.99,'Bud light Lime 6 pack',6,6,0,0,0,0,0,0,10.99,1),(1079,'Lime-a-Rita Classic Margarita 12 Pack',12,'018200199875',17.99,'Lime-a-Rita Classic Margarita 12 Pack',6,12,0,0,0,0,0,0,17.99,1),(1080,'Bud Light Orange Lager 6 Pack',12,'018200200793',9.99,'Bud Light Orange Lager 6 Pack',6,6,0,0,0,0,0,0,9.99,1),(1081,'Bud Light Lemon tea',1,'018200201400',8.99,'Bud Light Lemon tea',6,NULL,0,0,0,0,0,0,10.99,1),(1082,'Mang-o-rita Mango Margarita 12 Pack',12,'018200229893',17.99,'Mang-o-rita Mango Margarita 12 Pack',6,12,0,0,0,0,0,0,17.99,1),(1083,'Pomegranate-Rita 12 pack',12,'018200229923',17.99,'Pomegranate-Rita 12 pack',6,12,0,0,0,0,0,0,17.99,1),(1084,'Stella Cidre Stella Artois',1,'018200240010',10.99,'Stella Cidre Stella Artois',6,NULL,0,0,0,0,0,0,7.53,1),(1085,'Lime-A-Rita 25oz',12,'018200250149',4.99,'Lime-A-Rita 25oz',6,NULL,0,0,0,0,0,0,4.99,1),(1086,'Bud Light Orange Lager',12,'018200259029',1.99,'Bud Light Orange Lager',6,1,0,0,0,0,0,0,1.99,1),(1087,'Bud Light 12 Pack Cans',1,'018200530470',14.99,'Bud Light 12 Pack Cans',6,12,0,0,0,0,0,0,10.98,1),(1088,'Lemon-ade-Rita Margarita 12 pack',12,'018200970078',17.99,'Lemon-ade-Rita Margarita 12 pack',6,12,0,0,0,0,0,0,17.99,1),(1089,'Bud Light Chelada 6-pack',1,'01823024',11.99,'Bud Light Chelada 6-pack',6,NULL,0,0,0,0,0,0,8.5,1),(1090,'Michelob Ultra 12oz Can',1,'01833429',2.25,'Michelob Ultra 12oz Can',6,NULL,0,0,0,0,0,0,1.02,1),(1091,'Chelada 16oz 4 pack',1,'01886625',12.99,'Chelada 16oz 4 pack',6,NULL,0,0,0,0,0,0,12.99,1),(1092,'Fiori Moscato Veneto',8,'020106202962',11.99,'Fiori Moscato Veneto',5,1,0,0,0,0,2,0,7,12),(1093,'Don Ramon',8,'020106501171',11.99,'Don Ramon',5,1,0,0,0,0,2,0,7,12),(1094,'Clear Night Riesling',8,'020106502482',14.99,'Clear Night Riesling',5,1,0,0,0,0,2,0,10,12),(1095,'Bastide De Beauvert Cotes Du Rhone 2016',8,'020106502505',13.99,'Bastide De Beauvert Cotes Du Rhone 2016',5,1,0,0,0,0,2,0,7.5,12),(1096,'Domaine Del Sol Picpoul De Pinet',8,'020106502796',12.5,'Domaine Del Sol Picpoul De Pinet',5,1,0,0,0,0,2,0,8.25,12),(1097,'Gift Bag',12,'020173178993',2.99,'Gift Bag',1,NULL,0,0,0,0,0,0,2.99,1),(1098,'Horseradish Amana',4,'021285002718',5.99,'Horseradish Amana',4,NULL,1,0,0,0,0,0,3.75,1),(1099,'Amana Summer Sausage, Old World',4,'021285004507',11.99,'Amana Summer Sausage, Old World',4,NULL,1,0,0,0,0,0,6.25,1),(1100,'Amana Roasted Field Corn',12,'021285006099',3.5,'Amana Roasted Field Corn',4,NULL,1,0,0,0,0,0,3.5,1),(1101,'Amana Dill Mustard',12,'021285006617',4.99,'Amana Dill Mustard',4,NULL,1,0,0,0,0,0,4.99,1),(1102,'Amana Caramel Corn Nuggets',4,'021285007041',5.5,'Amana Caramel Corn Nuts',4,NULL,1,0,0,0,0,0,3.08,1),(1103,'Amana Summer Sausage, Traditional',4,'021285300135',6.99,'Amana Summer Sausage, Traditional',4,NULL,1,0,0,0,0,0,3.75,1),(1104,'Amana Summer Sausage, Double Smoke',4,'021285300142',6.99,'Amana Summer Sausage, Double Smoke',4,NULL,1,0,0,0,0,0,6.99,1),(1105,'Amana Beef Sticks',4,'021285300579',6.99,'Amana Beef Sticks',4,NULL,1,0,0,0,0,0,4.01,1),(1106,'Amana Pepper Relish',12,'021285553111',4.99,'Amana Pepper Relish',4,NULL,1,0,0,0,0,0,4.99,1),(1107,'Amana Pickled Asparagus',4,'021285560027',9.99,'Amana Pickled Asparagus',4,NULL,1,0,0,0,0,0,5.45,1),(1108,'Cracker Barrel Cheddar',12,'02190503',5.99,'Cracker Barrel Cheddar',5,1,0,0,0,0,2,0,5.99,12),(1109,'Venge Silencieux Red 2015',15,'021908112510',52.99,'Venge Silencieux Red 2015',5,1,0,0,0,0,2,0,40,12),(1110,'Silver Oak Cabernet Napa Valley',13,'021908112558',129.99,'Silver Oak Cabernet Napa Valley',5,1,0,0,0,0,2,0,99.8,12),(1111,'Eclipse, Winterfrost',12,'022000013200',1.59,'Eclipse, Winterfrost',3,NULL,0,0,0,0,0,0,1.59,1),(1112,'Eclipse, Polar Ice',12,'022000013279',1.59,'Eclipse, Polar Ice',3,NULL,0,0,0,0,0,0,1.59,1),(1113,'Eclips Spearmint',12,'022000013316',1.59,'Eclips Spearmint',3,NULL,0,0,0,0,0,0,1.59,1),(1114,'Flying Wish Paper',12,'022099577225',8.99,'Flying Wish Paper',1,NULL,0,0,0,0,0,0,3.99,1),(1115,'Wine Stopper, Rabbit 2 pack',12,'022578061191',3.99,'Wine Stopper, Rabbit 2 pack',1,NULL,0,0,0,0,0,0,3.99,1),(1116,'Palm Rabbit Aerator',12,'022578102320',23.99,'Palm Rabbit Aerator',1,NULL,0,0,0,0,0,0,23.99,1),(1117,'Houdini Dluxe Aerator',12,'022578107707',19.99,'Houdini Dluxe Aerator',1,NULL,0,0,0,0,0,0,19.99,1),(1118,'Book, Cocktail Party journal',12,'02261804',16,'Book, Cocktail Party journal',1,NULL,0,0,0,0,0,0,16,1),(1119,'Extra, Peppermint',12,'02289106',1.49,'Extra, Peppermint',3,NULL,0,0,0,0,0,0,1.49,1),(1120,'Extra, Polar Ice',12,'02289805',1.49,'Extra, Polar Ice',3,NULL,0,0,0,0,0,0,1.49,1),(1121,'Extra, Spearmint',12,'02289902',1.49,'Extra, Spearmint',3,NULL,0,0,0,0,0,0,1.49,1),(1122,'Twang a Rita Salt',12,'023604301007',4.5,'Twang a Rita Salt',4,NULL,1,0,0,0,0,0,4.5,1),(1123,'Twang Bloody Mary Salt',12,'023604305005',4.89,'Twang Bloody Mary Salt',4,NULL,1,0,0,0,0,0,4.89,1),(1124,'Name Your Drink Tags',12,'024055210825',1.99,'Name Your Drink Tags',1,NULL,0,0,0,0,0,0,1.99,1),(1125,'Lemonade',21,'025000044984',4.99,'Lemonade',4,NULL,1,0,0,0,0,0,2.99,1),(1126,'Hat, Total Dad Move',12,'026217261133',12.99,'Hat, Total Dad Move',1,NULL,0,0,0,0,0,0,12.99,1),(1127,'Hat, Best Dad Ever',12,'026217261201',12.99,'Hat, Best Dad Ever',1,NULL,0,0,0,0,0,0,12.99,1),(1128,'Hat, Drink Local',12,'026217261485',12.99,'Hat, Drink Local',1,NULL,0,0,0,0,0,0,12.99,1),(1129,'Silver Oak Cabernet Alexander Valley 2012',13,'026229775079',99.99,'Silver Oak Cabernet Alexander Valley 2012',5,1,0,0,0,0,2,0,64.8,12),(1130,'Ardeche Chardonnay',13,'026861100109',12.99,'Ardeche Chardonnay',5,1,0,0,0,0,2,0,9,12),(1131,'Latour Chameroy Beaujolais-Villages 2017',10,'026861100291',14.99,'Latour Chameroy Beaujolais-Villages 2017',5,1,0,0,0,0,2,0,9,12),(1132,'Pink Pirate blush',12,'027551180463',13.99,'Pink Pirate blush',5,1,0,0,0,0,2,0,13.99,12),(1133,'St. George Green Chile Vodka',12,'027724037501',36.99,'St. George Green Chile Vodka',7,1,0,0,0,0,0,0,36.99,1),(1134,'Laffy Taffy Bag',12,'028000031428',1.99,'Laffy Taffy Bag',2,NULL,0,0,0,0,0,0,1,1),(1135,'Stax BBQ Lay\'s',21,'028400055109',2.25,'Stax BBQ Lay\'s',2,NULL,0,0,0,0,0,0,1.5,1),(1136,'Lay\'s Cheddar Stax',12,'028400055116',2.25,'Lay\'s Cheddar Stax',2,NULL,0,0,0,0,0,0,1.25,1),(1137,'Tostitos Salsa, Med',12,'028400055987',5.99,'Tostitos Salsa, Med',4,NULL,1,0,0,0,0,0,5.99,1),(1138,'Lay\'s Chips, Beer Cheese',12,'028400244251',5.99,'Lay\'s Chips, Beer Cheese',4,NULL,1,0,0,0,0,0,5.99,1),(1139,'Label Lift',12,'028588001103',9.99,'Label Lift',1,NULL,0,0,0,0,0,0,9.99,1),(1140,'Frilly Party Picks',12,'028588004081',1.99,'Frilly Party Picks',1,NULL,0,0,0,0,0,0,1.99,1),(1141,'Plate Clips 4 cnt',12,'028588024010',4.99,'Plate Clips 4 cnt',1,NULL,0,0,0,0,0,0,4.99,1),(1142,'Garden Stake, Black',12,'028588033609',35.99,'Garden Stake, Black',1,NULL,0,0,0,0,0,0,35.99,1),(1143,'Insulated Jute Tote',12,'028588040119',12.99,'Insulated Jute Tote',1,NULL,0,0,0,0,0,0,12.99,1),(1144,'Insulated wine tote',12,'028588040300',8.99,'Insulated wine tote',1,NULL,0,0,0,0,0,0,8.99,1),(1145,'Bottle Tote, Wool Felt',12,'028588042267',7.99,'Bottle Tote, Wool Felt',1,NULL,0,0,0,0,0,0,7.99,1),(1146,'Wine Bag',12,'028588045817',2.49,'Wine Bag',1,NULL,0,0,0,0,0,0,2.49,1),(1147,'See No Vino',12,'028588310076',11.99,'See No Vino',1,NULL,0,0,0,0,0,0,11.99,1),(1148,'Oeno vi-no!',12,'028588310083',4.99,'Oeno vi-no!',1,NULL,0,0,0,0,0,0,4.99,1),(1149,'Cork Trivet Kit',12,'028588490082',16.99,'Cork Trivet Kit',1,NULL,0,0,0,0,0,0,16.99,1),(1150,'Bamboo Cheese Knife',12,'028588701720',4.99,'Bamboo Cheese Knife',1,NULL,0,0,0,0,0,0,4.99,1),(1151,'Toasteds Sesame',12,'030100119616',3.75,'Toasteds Sesame',4,NULL,1,0,0,0,0,0,3.75,1),(1152,'Toasteds Harvest Wheat',12,'030100119630',3.75,'Toasteds Harvest Wheat',4,NULL,1,0,0,0,0,0,3.75,1),(1153,'Toasteds Buttercrisp',12,'030100322924',3.75,'Toasteds Buttercrisp',4,NULL,1,0,0,0,0,0,3.75,1),(1154,'Ocean Spray Cran Mango 3 L',12,'031200023636',6.99,'Ocean Spray Cran Mango 3 L',4,NULL,1,0,0,0,0,0,6.99,1),(1155,'Calling Chardonnay',12,'031259045283',31.99,'Calling Chardonnay',5,1,0,0,0,0,2,0,31.99,12),(1156,'Collins Maraschino Cherries',12,'031439001627',5.99,'Collins Maraschino Cherries',2,NULL,0,0,0,0,0,0,3.87,1),(1157,'Win Bag, Dog',12,'031439010773',1.99,'Win Bag, Dog',1,NULL,0,0,0,0,0,0,1.99,1),(1158,'Tony Packo\'s Pickles & Peppers',12,'032063104012',7.99,'Tony Packo\'s Pickles & Peppers',4,NULL,1,0,0,0,0,0,7.99,1),(1159,'Segura Viudas',12,'033293655008',48.99,'Segura Viudas',5,1,0,0,0,0,2,0,48.99,12),(1160,'Corona Familiar Lager 6 pack',12,'033544950517',10.99,'Corona Familiar Lager 6 pack',6,6,0,0,0,0,0,0,10.99,1),(1161,'Corona Familiar',12,'033544950555',1.99,'Corona Familiar',6,1,0,0,0,0,0,0,1.99,1),(1162,'Smores Kit',12,'034000291199',13.99,'Smores Kit',4,NULL,1,0,0,0,0,0,13.99,1),(1163,'Rolo',12,'034000376124',1.99,'Rolo',3,NULL,0,0,0,0,0,0,1.99,1),(1164,'Redd\'s Apple Ale 6 Pack',12,'034100087166',10.99,'Redd\'s Apple Ale 6 Pack',6,6,0,0,0,0,0,0,10.99,1),(1165,'Miller Genuine Draft 12 Pack',12,'034100176365',13.99,'Miller Genuine Draft 12 Pack',6,12,0,0,0,0,0,0,13.99,1),(1166,'Leinenkugel\'s Summer Shandy 6 Pack',17,'034100516055',10.99,'Leinenkugel\'s Summer Shandy 6 Pack',6,6,0,0,0,0,0,0,7.8,1),(1167,'Leinenkugel\'s Summer Shandy',17,'034100516079',18.99,'Leinenkugel\'s Summer Shandy',6,NULL,0,0,0,0,0,0,13.8,1),(1168,'Miller Lite 12 pack',12,'034100576363',14.99,'Miller Lite 12 pack',6,NULL,0,0,0,0,0,0,11,1),(1169,'Miller Lite 16oz 12 Pack',12,'034100576530',13.99,'Miller Lite 16oz 12 Pack',6,12,0,0,0,0,0,0,13.99,1),(1170,'Hershey\'s Milk Chocolate',12,'03424005',1.49,'Hershey\'s Milk Chocolate',3,NULL,0,0,0,0,0,0,1.49,1),(1171,'Italiano Dip',12,'035342240241',6.99,'Italiano Dip',4,NULL,1,0,0,0,0,0,6.99,1),(1172,'McGinnis Shortbread Fingers',12,'035549970781',4.99,'McGinnis Shortbread Fingers',4,NULL,1,0,0,0,0,0,4.99,1),(1173,'Sanders Extra Dark Hot Fundge',12,'035900171062',6.99,'Sanders Extra Dark Hot Fundge',4,NULL,1,0,0,0,0,0,6.99,1),(1174,'Sanders Extra Dark Hot Fundge',12,'035900171307',6.99,'Sanders Extra Dark Hot Fundge',4,NULL,1,0,0,0,0,0,6.99,1),(1175,'Book, The Wine maker\'s Anwer Book',12,'037038176568',14.95,'Book, The Wine maker\'s Anwer Book',1,NULL,0,0,0,0,0,0,14.95,1),(1176,'Mushrooms, Marinated',12,'037102644887',11.99,'Mushrooms, Marinated',4,NULL,1,0,0,0,0,0,11.99,1),(1177,'Lindt 70% Cocoa',12,'037466017631',3.99,'Lindt 70% Cocoa',4,NULL,1,0,0,0,0,0,3.99,1),(1178,'Pringles BBQ',12,'038000188657',2.25,'Pringles BBQ',3,NULL,0,0,0,0,0,0,1.25,1),(1179,'Verdi Spumante',12,'038075202302',8.99,'Verdi Spumante',5,1,0,0,0,0,2,0,8.99,12),(1180,'Raspberry Sparklentini',12,'038075205303',8.99,'Raspberry Sparklentini',5,1,0,0,0,0,2,0,8.99,12),(1181,'Drink Charm, Bride',12,'038521104860',1.99,'Drink Charm, Bride',1,NULL,0,0,0,0,0,0,1.99,1),(1182,'Pineapple Juice 8.4 fl oz',23,'038900009632',1.25,'Pineapple Juice 8.4 fl oz',3,NULL,0,0,0,0,0,0,0.5,1),(1183,'Amarena Fabbri wild Cherries',12,'039815110031',7.99,'Amarena Fabbri wild Cherries',4,NULL,1,0,0,0,0,0,7.99,1),(1184,'Lime',12,'039938195748',0.99,'Lime',4,NULL,1,0,0,0,0,0,0.5,1),(1185,'Snickers',23,'040000424314',1.49,'Snickers',3,NULL,0,0,0,0,0,0,0.75,1),(1186,'M&M, Carmamel',12,'040000508830',1.49,'M&M, Carmamel',3,NULL,0,0,0,0,0,0,1.49,1),(1187,'Dove Milk Cocolate',12,'040000525028',2.99,'Dove Milk Cocolate',3,NULL,0,0,0,0,0,0,2.99,1),(1188,'Bottle of Candy',12,'040000541103',5.99,'Bottle of Candy',4,NULL,1,0,0,0,0,0,5.99,1),(1189,'M & M\'s',23,'04003100',1.49,'M&M',3,NULL,0,0,0,0,0,0,0.65,1),(1190,'Four Roses Single Barrel',18,'040063400027',49.99,'Four Roses Single Barrel',7,NULL,0,0,0,0,0,0,32.25,1),(1191,'Four Roses Small Batch Bourbon',18,'040063400317',44.99,'Four Roses Small Batch Bourbon',7,NULL,0,0,0,0,0,0,24.75,1),(1192,'Skittles',12,'04016007',1.49,'Skittles',3,NULL,0,0,0,0,0,0,1.49,1),(1193,'Skittles, Tropical',12,'04016308',1.49,'Skittles, Tropical',3,NULL,0,0,0,0,0,0,1.49,1),(1194,'Drop it',12,'040232551529',12.99,'Drop it',1,NULL,0,0,0,0,0,0,12.99,1),(1195,'Calvados Morin Apple Brandy',10,'040232582707',26.99,'Calvados Morin Apple Brandy',7,NULL,0,0,0,0,0,0,19,1),(1196,'StarBurst',12,'04097002',1.49,'StarBurst',3,NULL,0,0,0,0,0,0,1.49,1),(1197,'Ringpop',12,'041116011320',0.75,'Ringpop',3,NULL,0,0,0,0,0,0,0.25,1),(1198,'Candy Lights',12,'041396000977',0.5,'Candy Lights',4,NULL,1,0,0,0,0,0,NULL,1),(1199,'Party Sweets, Buttermint Creams',12,'041412176600',2.75,'Party Sweets, Buttermint Creams',4,NULL,1,0,0,0,0,0,2.75,1),(1200,'Now and Later Bag Candy',12,'041420028113',2.75,'Now and Later Bag Candy',2,NULL,0,0,0,0,0,0,1.5,1),(1201,'Savoritz',12,'041498110895',3.99,'Savoritz',4,NULL,1,0,0,0,0,0,3.99,1),(1202,'Savoritz',12,'041498110918',3.99,'Savoritz',4,NULL,1,0,0,0,0,0,3.99,1),(1203,'Happy Farms Brie',3,'041498111328',6.99,'Happy Farms Brie',4,NULL,1,0,0,0,0,0,2.99,1),(1204,'Pepperoni Cheese',3,'041498114060',6.99,'Pepperoni Cheese',4,NULL,1,0,0,0,0,0,5,1),(1205,'Berry Hill Raspberry Spread',12,'041498115029',3.99,'Berry Hill Raspberry Spread',4,NULL,1,0,0,0,0,0,3.99,1),(1206,'Goat Cheese, Plain',3,'041498115654',3.99,'Goat Cheese, Plain',4,NULL,1,0,0,0,0,0,2.75,1),(1207,'Goat Cheese, Garlic & Herb',12,'041498115661',3.99,'Goat Cheese, Garlic & Herb',4,NULL,1,0,0,0,0,0,3.99,1),(1208,'Specially Selected, Black Bean & Corn Salsa',12,'041498115982',4.99,'Specially Selected, Black Bean & Corn Salsa',4,NULL,1,0,0,0,0,0,4.99,1),(1209,'Goat Cheese, Honey',12,'041498116033',3.99,'Goat Cheese, Honey',4,NULL,1,0,0,0,0,0,3.99,1),(1210,'Minced Garlic',12,'041498132439',4.99,'Minced Garlic',4,NULL,1,0,0,0,0,0,4.99,1),(1211,'White Cheddar Cheese',3,'041498134563',7.99,'SS Manchego Cheese 7oz',4,NULL,1,0,0,0,0,0,4.25,1),(1212,'Fusia Sesame Teriyaki',12,'041498136093',3.99,'Fusia Sesame Teriyaki',4,NULL,1,0,0,0,0,0,3.99,1),(1213,'Blue Cheese Stuffed Olives',23,'041498140793',7.99,'Blue Cheese Stuffed Olives',4,NULL,1,0,0,0,0,0,4.99,1),(1214,'Spec Selct Jalapeno Olives',3,'041498140861',7.99,'Spec Selct Jalapeno Olives',4,NULL,1,0,0,0,0,0,3.75,1),(1215,'Olives, Garlic Stuffed',12,'041498143336',7.99,'Olives, Garlic Stuffed',4,NULL,1,0,0,0,0,0,7.99,1),(1216,'Casa Mamita Salsa, Med',12,'041498145095',5.99,'Casa Mamita Salsa, Med',4,NULL,1,0,0,0,0,0,5.99,1),(1217,'Gouda Cheese, Specially Selected',12,'041498149130',6.99,'Gouda Cheese, Specially Selected',4,NULL,1,0,0,0,0,0,6.99,1),(1218,'Edam, Specially Selected',12,'041498149147',6.99,'Edam, Specially Selected',4,NULL,1,0,0,0,0,0,6.99,1),(1219,'Smoked Gouda, Specially Selected',3,'041498149154',6.99,'Smoked Gouda, Specially Selected',4,NULL,1,0,0,0,0,0,4,1),(1220,'Crofton 3 pc Corkscrew',12,'041498150822',15.99,'Crofton 3 pc Corkscrew',1,NULL,0,0,0,0,0,0,15.99,1),(1221,'Clancy\'s Chips, Hint of Lime',12,'041498165680',3.99,'Clancy\'s Chips, Hint of Lime',4,NULL,1,0,0,0,0,0,3.99,1),(1222,'HF Havarti with Dill Cheese',3,'041498177065',6.99,'HF Havarti with Dill Cheese',4,NULL,1,0,0,0,0,0,3.75,1),(1223,'Casa Mamita Con Queso',12,'041498193195',4.99,'Casa Mamita Con Queso',4,NULL,1,0,0,0,0,0,4.99,1),(1224,'Happy Farms Cream Cheese',12,'041498193539',2.99,'Happy Farms Cream Cheese',4,NULL,1,0,0,0,0,0,2.79,1),(1225,'Beverage Stake',12,'041498203283',3.99,'Beverage Stake',1,NULL,0,0,0,0,0,0,3.99,1),(1226,'Crinkle Cut Ribbon Noodles',12,'041498212131',4.99,'Crinkle Cut Ribbon Noodles',4,NULL,1,0,0,0,0,0,4.99,1),(1227,'Extra Sharp Chedder, Cracker Cuts',12,'041498212780',7.99,'Extra Sharp Chedder, Cracker Cuts',4,NULL,1,0,0,0,0,0,7.99,1),(1228,'Cheese Curds',21,'041498213190',6.99,'Cheese Curds',4,NULL,1,0,0,0,0,0,5,1),(1229,'Glaze, Balsamic Vinegar',3,'041498221454',6.99,'Glaze, Balsamic Vinegar',4,NULL,1,0,0,0,0,0,3.5,1),(1230,'Tikka Masala',12,'041498229429',4.99,'Tikka Masala',4,NULL,1,0,0,0,0,0,4.99,1),(1231,'Jalfrezi Simmer Sauce',12,'041498229443',4.99,'Jalfrezi Simmer Sauce',4,NULL,1,0,0,0,0,0,4.99,1),(1232,'Artisan Crackers Rosemary',12,'041498239855',5.25,'Artisan Crackers Rosemary',4,NULL,1,0,0,0,0,0,5.25,1),(1233,'Tikka Masala',12,'041498242152',5.99,'Tikka Masala',4,NULL,1,0,0,0,0,0,5.99,1),(1234,'Korma Curry Sauce',12,'041498242169',5.99,'Korma Curry Sauce',4,NULL,1,0,0,0,0,0,5.99,1),(1235,'Stonemill Bread Dipping',12,'041498248901',7.99,'Stonemill Bread Dipping',4,NULL,1,0,0,0,0,0,7.99,1),(1236,'Beverage Tub, Clear',12,'041498250553',14.99,'Beverage Tub, Clear',1,NULL,0,0,0,0,0,0,14.99,1),(1237,'Beverage Tub, Red',12,'041498250577',14.99,'Beverage Tub, Red',1,NULL,0,0,0,0,0,0,14.99,1),(1238,'Beverage Tub, Blue',12,'041498250584',14.99,'Beverage Tub, Blue',1,NULL,0,0,0,0,0,0,14.99,1),(1239,'Tomato Basil Feta',3,'041498251192',6.5,'Tomato Basil Feta',4,NULL,1,0,0,0,0,0,3.25,1),(1240,'Mango Chutney',12,'041498266363',4.99,'Mango Chutney',4,NULL,1,0,0,0,0,0,4.99,1),(1241,'Onion Chutney',12,'041498266394',4.99,'Onion Chutney',4,NULL,1,0,0,0,0,0,4.99,1),(1242,'Clancy\'s Pretzel',12,'041498266745',3.99,'Clancy\'s Pretzel',4,NULL,1,0,0,0,0,0,3.99,1),(1243,'Fusia Hoisin',12,'041498283834',3.99,'Fusia Hoisin',4,NULL,1,0,0,0,0,0,3.99,1),(1244,'Butter Popcorn Seasoning',12,'041498286217',5.99,'Butter Popcorn Seasoning',4,NULL,1,0,0,0,0,0,5.99,1),(1245,'Cracker Cuts Gouda',3,'041498287368',5.99,'Cracker Cuts Gouda',4,NULL,1,0,0,0,0,0,3.49,1),(1246,'Priano Marinated Mozzarella',12,'041498292362',4.99,'Priano Marinated Mozzarella',4,NULL,1,0,0,0,0,0,4.99,1),(1247,'Clancy\'s Cantina Tortilla Chips',3,'041498293130',3.99,'Clancy\'s Cantina Tortilla Chips',2,NULL,0,0,0,0,0,0,1.99,1),(1248,'Crofton Cocktail Shaker set',12,'041498294496',19.99,'Crofton Cocktail Shaker set',1,NULL,0,0,0,0,0,0,13.98,1),(1249,'SS Garden Vegetable Cheese',3,'041498295790',6.99,'SS Garden Vegetable Cheese',4,NULL,1,0,0,0,0,0,4,1),(1250,'Crofton Flatware Caddy',12,'041498328450',15.99,'Crofton Flatware Caddy',1,NULL,0,0,0,0,0,0,15.99,1),(1251,'Barissimo Bourbon Coffee',3,'041498333607',7.99,'Barissimo Bourbon Coffee',2,NULL,0,0,0,0,0,0,3.99,1),(1252,'Bread Knife & Cutting Board',12,'041498340506',14.99,'Bread Knife & Cutting Board',1,NULL,0,0,0,0,0,0,14.99,1),(1253,'Welch\'s Sparkling Blueberry',12,'041800704194',4.99,'Welch\'s Sparkling Blueberry',15,1,0,0,0,0,0,0,4.99,1),(1254,'Welch\'s Sparkling Cranberry',12,'041800704200',4.99,'Welch\'s Sparkling Cranberry',15,1,0,0,0,0,0,0,4.99,1),(1255,'Welch\'s Sparkling White Grape',23,'041800715008',4.99,'Welch\'s Sparkling White Grape',15,1,0,0,0,0,0,0,2.3,1),(1256,'Welch\'s Sparkling Red Grape',23,'041800716005',4.99,'Welch\'s Sparkling Red Grape',15,1,0,0,0,0,0,0,2.5,1),(1257,'Pirouline Stawberry',12,'042456000135',2.99,'Pirouline Stawberry',4,NULL,1,0,0,0,0,0,2.99,1),(1258,'Pirouline Dark Chocolate',21,'042456058037',3.5,'Pirouline Dark Chocolate',2,NULL,0,0,0,0,0,0,1.25,1),(1259,'Crystal Light Appletini',12,'043000041574',4.99,'Crystal Light Appletini',4,NULL,1,0,0,0,0,0,4.99,1),(1260,'ZD Chardonnay',12,'044956001018',38.99,'ZD Chardonnay',5,1,0,0,0,0,2,0,38.99,12),(1261,'Josh Cellars Cabernet Joseph Carr Hopland, CA',13,'048307177629',15,'Josh Cellars Cabernet Joseph Carr Hopland, CA',5,1,0,0,0,0,2,0,NULL,12),(1262,'Ybarra Olives',12,'048327971610',7.99,'Ybarra Olives',4,NULL,1,0,0,0,0,0,6,1),(1263,'Gift Bag',12,'048419871897',2.99,'Gift Bag',1,NULL,0,0,0,0,0,0,2.99,1),(1264,'Photo Stand',12,'048637235693',6.25,'Photo Stand',1,NULL,0,0,0,0,0,0,6.25,1),(1265,'Propane',5,'PROPANENEW',14.5,'Propane Exchange',8,NULL,0,0,0,0,0,0,NULL,1),(1266,'Coke Zero',12,'049000042566',1,'Coke Zero',2,NULL,0,0,0,0,0,0,0.5,1),(1267,'Coke 2 Liter',21,'049000050103',2.89,'Coke 2 L',15,1,0,0,0,0,0,0,1.35,1),(1268,'Diet Coke 2 L',12,'049000050110',2.69,'Diet Coke 2 L',15,1,0,0,0,0,0,0,2.69,1),(1269,'Sprite',12,'049000050158',2.75,'Sprite',2,NULL,0,0,0,0,0,0,1.89,1),(1270,'Coke mini 10 pack',12,'049000067217',5.99,'Coke mini 10 pack',15,10,0,0,0,0,0,0,5.99,1),(1271,'Spider-man Bottle Opener',12,'049022049062',10.99,'Spider-man Bottle Opener',1,NULL,0,0,0,0,0,0,10.99,1),(1272,'Sprite 12oz',12,'04913207',1,'Sprite 12oz',2,NULL,0,0,0,0,0,0,1,1),(1273,'La Crema Monterey Pinot Noir',13,'049331010968',22.99,'La Crema Monterey',5,1,0,0,0,0,2,0,15,12),(1274,'Coca-cola 1 can',12,'04963406',1,'Coca-cola 1 can',2,NULL,0,0,0,0,0,0,1,1),(1275,'Flipezze Pillow',12,'049696405164',3.5,'Flipezze Pillow',1,NULL,0,0,0,0,0,0,1.25,1),(1276,'Book, Best of the Best vol. 5',12,'049725003743',18.99,'Book, Best of the Best vol. 5',1,NULL,0,0,0,0,0,0,18.99,1),(1277,'Book, Best of the Best vol. 7',12,'049725214002',18.99,'Book, Best of the Best vol. 7',1,NULL,0,0,0,0,0,0,18.99,1),(1278,'Amaretto Disaronno',18,'050037014501',31.99,'Amaretto Disaronno',7,NULL,0,0,0,0,0,0,22.77,1),(1279,'Disaronno wears Trussadi',12,'050037094480',32.99,'Disaronno wears Trussadi',7,1,0,0,0,0,0,0,32.99,1),(1280,'V8 original 12oz',12,'051000012920',1.25,'V8 original 12oz',4,NULL,1,0,0,0,0,0,1.25,1),(1281,'Gatorade',21,'052000102475',1.89,'Gatorade',2,NULL,0,0,0,0,0,0,1.25,1),(1282,'Gatorade',12,'052000324815',1.89,'Gatorade',4,NULL,1,0,0,0,0,0,1.69,1),(1283,'Gatorage Frost',12,'052000324884',1.69,'Gatorage Frost',4,NULL,1,0,0,0,0,0,1.69,1),(1284,'Gatorage, Fruit Punch',12,'052000328660',1.89,'Gatorage, Fruit Punch',4,NULL,1,0,0,0,0,0,1.69,1),(1285,'Schogetten',12,'053035036407',4.5,'Schogetten',4,NULL,1,0,0,0,0,0,4.5,1),(1286,'Breton Multigrain 8.8oz',16,'055653630104',4.99,'Breton Multigrain 8.8oz',4,NULL,1,0,0,0,0,0,2.5,1),(1287,'Dare Grains First WHole Grain Crackers',16,'055653669302',4.99,'Dare Grains First WHole Grain Crackers',4,NULL,1,0,0,0,0,0,2.52,1),(1288,'Carr\'s Tabke Water Crackers',12,'059290573220',2.99,'Carr\'s Tabke Water Crackers',2,NULL,0,0,0,0,0,0,1.25,1),(1289,'Razzles',12,'059642938301',1.99,'Razzles',2,NULL,0,0,0,0,0,0,1.07,1),(1290,'ppd Cheese Knives',12,'063362250032',7.99,'ppd Cheese Knives',1,NULL,0,0,0,0,0,0,7.99,1),(1291,'Card',24,'064319375600',3.89,'Card',1,NULL,0,0,0,0,0,0,3.89,1),(1292,'Jo!o Corkscrew',12,'067742209665',10.99,'Jo!o Corkscrew',1,NULL,0,0,0,0,0,0,10.99,1),(1293,'Wine Stopper, Silicone Grape',12,'067742413130',7.99,'Wine Stopper, Silicone Grape',1,NULL,0,0,0,0,0,0,7.99,1),(1294,'Fun on Glass',12,'067742493538',7.99,'Fun on Glass',1,NULL,0,0,0,0,0,0,7.99,1),(1295,'Joie Cheese Knife',12,'067742760012',5.99,'Joie Cheese Knife',1,NULL,0,0,0,0,0,0,5.99,1),(1296,'Courvoisiser VS',18,'0686961048',0,'Courvoisiser VS',7,NULL,0,0,0,0,0,0,0,1),(1297,'GooGone Wine Out',12,'070048018015',1.99,'GooGone Wine Out',1,NULL,0,0,0,0,0,0,1.99,1),(1298,'Wine Out',12,'070048029646',9.99,'Wine Out',1,NULL,0,0,0,0,0,0,9.99,1),(1299,'Finest Call Bar Syrup 1 L',19,'070491021754',5.99,'Finest Call Bar Syrup 1 L',4,NULL,1,0,0,0,0,0,5.99,1),(1300,'Finest Call Mango puree 1 L',19,'070491112209',5.99,'Finest Call Mango puree 1 L',4,NULL,1,0,0,0,0,0,3.75,1),(1301,'Finest Call Raspberry Puree 1 L',19,'070491113961',5.99,'Finest Call Raspberry Puree 1 L',4,NULL,1,0,0,0,0,0,3.75,1),(1302,'Finest Call Lime Juice 1 L',19,'070491114968',5.99,'Finest Call Lime Juice 1 L',2,NULL,0,0,0,0,0,0,3.25,1),(1303,'Master of Mixes Marg Salt',21,'070491522923',3.99,'Description to show on screen and receipt',2,NULL,0,0,0,0,0,0,1.25,1),(1304,'Finest Call Red Sangria 1 L',12,'070491553002',5.99,'Finest Call Red Sangria 1 L',4,NULL,1,0,0,0,0,0,5.99,1),(1305,'Finest Call White Sangria blend 1 L',12,'070491554009',5.99,'Finest Call White Sangria blend 1 L',4,NULL,1,0,0,0,0,0,5.99,1),(1306,'Finest Call Single Press Lime Juice 1 L',12,'070491569003',7.99,'Finest Call Single Press Lime Juice 1 L',4,NULL,1,0,0,0,0,0,7.99,1),(1307,'Finest Call Michelada 1 L',12,'070491571006',6.99,'Finest Call Michelada 1 L',4,NULL,1,0,0,0,0,0,6.99,1),(1308,'Finest Call Sweet & Sour 1 L',19,'070491801950',5.99,'Finest Call Sweet & Sour 1 L',4,NULL,1,0,0,0,0,0,3.75,1),(1309,'Finest Call Strawberry 1 L',19,'070491803954',5.99,'Finest Call Strawberry 1 L',4,NULL,1,0,0,0,0,0,3.75,1),(1310,'Finest Call Grenadine 1 L',12,'070491807952',5.99,'Finest Call Grenadine 1 L',15,1,0,0,0,0,0,0,5.99,1),(1311,'Bottle Bag, Martini Lounge',12,'070508562485',2.99,'Bottle Bag, Martini Lounge',1,NULL,0,0,0,0,0,0,2.99,1),(1312,'Cow Tales',12,'070622751017',1.99,'Cow Tales',2,NULL,0,0,0,0,0,0,1.07,1),(1313,'Mr. & Mrs. T Blood Mary Mix 1 L',19,'070655901304',5.75,'Mr. & Mrs. T Blood Mary Mix 1 L',3,NULL,0,0,0,0,0,0,4.16,1),(1314,'Mr & Mrs. T Bloody Mary Mix',12,'070655901786',1.25,'Mr & Mrs. T Bloody Mary Mix',4,NULL,1,0,0,0,0,0,0.5,1),(1315,'Old South Pickled Asparagus',16,'070759124111',9.99,'Old South Pickled Asparagus',4,NULL,1,0,0,0,0,0,4.99,1),(1316,'Green Beans, Pickled',12,'070759126122',8.99,'Green Beans, Pickled',4,NULL,1,0,0,0,0,0,8.99,1),(1317,'Brussels Sprouts, Pickled',16,'070759127129',6.99,'Brussels Sprouts, Pickled',4,NULL,1,0,0,0,0,0,3.4,1),(1318,'Old South Pickled Okra',16,'070759128119',5.99,'Old South Pickled Okra',4,NULL,1,0,0,0,0,0,2.96,1),(1319,'Monster Energy Drink 16oz',12,'070847811169',2.99,'Monster Energy Drink 16oz',2,NULL,0,0,0,0,0,0,2.99,1),(1320,'Biale Black Chicken',22,'070847811237',47.99,'Greeting Card',1,NULL,0,0,0,0,0,0,33.75,1),(1321,'Hot Tamales',21,'070970471230',1.99,'Hot Tamales',2,NULL,0,0,0,0,0,0,1.25,1),(1322,'Aceto Balsamico',12,'071072011294',4.99,'Aceto Balsamico',4,NULL,1,0,0,0,0,0,4.99,1),(1323,'Alouette Garlic & Herb Spread',3,'071448405016',5.99,'Alouette Garlic & Herb Spread',4,NULL,1,0,0,0,0,0,2.99,1),(1324,'Alouette Parmesan & Basil Spread',3,'071448405078',5.99,'Alouette Parmesan & Basil Spread',4,NULL,1,0,0,0,0,0,3.2,1),(1325,'Goft Bag',12,'071623194803',1.99,'Goft Bag',1,NULL,0,0,0,0,0,0,1.99,1),(1326,'Wine journal',12,'071623237999',4.99,'Wine journal',1,NULL,0,0,0,0,0,0,4.99,1),(1327,'Horeradish, Extra Hot',12,'071828001012',2.75,'Horeradish, Extra Hot',4,NULL,1,0,0,0,0,0,2.75,1),(1328,'Inglehoffer Extra Hot Horseradish',16,'071828009018',3.99,'Inglehoffer Extra Hot Horseradish',4,NULL,1,0,0,0,0,0,1.68,1),(1329,'Coors Light 12-Pack Cans',17,'071990000486',14.99,'Coors Light 12-Pack Cans',6,NULL,0,0,0,0,0,0,10.98,1),(1330,'Blue moon 6 Pack',17,'071990095116',10.99,'Blue moon 6 Pack',6,6,0,0,0,0,0,0,7.25,1),(1331,'Fine Truffles, Milk Chocolate',12,'072799054687',6.99,'Fine Truffles, Milk Chocolate',3,NULL,0,0,0,0,0,0,6.99,1),(1332,'Moser Roth Milk Caramel 5oz',12,'072799056728',4.99,'Moser Roth Milk Caramel 5oz',3,NULL,0,0,0,0,0,0,4.99,1),(1333,'Moser Roth Dark Sea Salt Caramel',3,'072799441098',4.5,'Moser Roth Dark Sea Salt Caramel',2,NULL,0,0,0,0,0,0,2.99,1),(1334,'Moser Roth Dark Chili',12,'072799762889',4.5,'Moser Roth Dark Chili',4,NULL,1,0,0,0,0,0,4.5,1),(1335,'Moser Roth Dark Mint/',3,'072799762896',4.5,'Moser Roth Dark Mint/',2,NULL,0,0,0,0,0,0,2.99,1),(1336,'chocolate bar',12,'072799830298',4.5,'chocolate bar',9,NULL,0,0,0,0,0,0,NULL,1),(1337,'Moser Roth Peru 62%',12,'072799830380',4.5,'Moser Roth Peru 62%',4,NULL,1,0,0,0,0,0,4.5,1),(1338,'Moser Roth Dominican Republic 75%',12,'072799830397',4.5,'Moser Roth Dominican Republic 75%',4,NULL,1,0,0,0,0,0,4.5,1),(1339,'Moser Roth Milk',12,'072799830540',4.5,'Moser Roth Milk',2,NULL,0,0,0,0,0,0,2.99,1),(1340,'Moser Roth Dark 70%',3,'072799830564',4.5,'Moser Roth Dark 70%',2,NULL,0,0,0,0,0,0,2.99,1),(1341,'Moser Roth Dark Almond',12,'072799830687',4.5,'Moser Roth Dark Almond',2,NULL,0,0,0,0,0,0,2.99,1),(1342,'Moser Roth Milk Toffe Crunch',3,'072799830694',4.5,'Moser Roth Milk Toffe Crunch',4,NULL,1,0,0,0,0,0,2.99,1),(1343,'Moser Roth Dark 85%',3,'072799830717',4.5,'Moser Roth Dark 85%',2,NULL,0,0,0,0,0,0,2.99,1),(1344,'Heineken',12,'072890000118',9.99,'Heineken',6,6,0,0,0,0,0,0,9.99,1),(1345,'Amstel Light',12,'072890100115',10.99,'Amstel Light',6,1,0,0,0,0,0,0,10.99,1),(1346,'Cock \'n Bull Ginger beer 4 pack',19,'072924012049',6.99,'Cock \'n Bull Ginger beer 4 pack',15,4,0,0,0,0,0,0,4.5,1),(1347,'Pepper Rings',12,'073214001620',4.5,'Pepper Rings',4,NULL,1,0,0,0,0,0,3,1),(1348,'Capers',12,'073214004034',4.99,'Capers',4,NULL,1,0,0,0,0,0,4.99,1),(1349,'Jalapeno Stuffed Olives',12,'073214006168',9.99,'Jalapeno Stuffed Olives',4,NULL,1,0,0,0,0,0,9.99,1),(1350,'Mississippi Mud Black & Tan 1 quart',12,'073360512049',5.99,'Mississippi Mud Black & Tan 1 quart',6,1,0,0,0,0,0,0,5.99,1),(1351,'Napkins',12,'073525129396',3.99,'Napkins',1,NULL,0,0,0,0,0,0,3.99,1),(1352,'Napkins',12,'073525547893',3.99,'Napkins',1,NULL,0,0,0,0,0,0,3.99,1),(1353,'Coasters, bubbly banter',12,'073525924335',2.99,'Coasters, bubbly banter',1,NULL,0,0,0,0,0,0,2.99,1),(1354,'Kitchen Towel',12,'073558657736',4.99,'Kitchen Towel',1,NULL,0,0,0,0,0,0,4.99,1),(1355,'Angostura Aromatic Bitters',21,'075496000407',9.99,'Angostura Aromatic Bitters',2,NULL,0,0,0,0,0,0,8,1),(1356,'Angostura Orange Bitters',12,'075496331143',9.99,'Angostura Orange Bitters',2,NULL,0,0,0,0,0,0,6.98,1),(1357,'Cheese Fusions Sour Cream & Onion 2oz',3,'075501961310',3.5,'Cheese Fusions Sour Cream & Onion 2oz',4,NULL,1,0,0,0,0,0,1.5,1),(1358,'Big Bold Buffalo Cheese Fusions',3,'075501961327',3.5,'Big Bold Buffalo Cheese Fusions',4,NULL,1,0,0,0,0,0,1.5,1),(1359,'Jose Cuervo Margarita Salt',21,'076381123454',5.99,'Jose Cuervo Margarita Salt',4,NULL,1,0,0,0,0,0,2.99,1),(1360,'Snoqualmie Cabernet Sauvignon',13,'077190000516',13.99,'Snoqualmie Cabernet Sauvignon',5,1,0,0,0,0,2,0,13.99,12),(1361,'Snoqualmie Riesing',12,'077190001407',13.99,'Snoqualmie Riesing',5,1,0,0,0,0,2,0,13.99,12),(1362,'Russell Stover Mint Patties',12,'077260097095',2.99,'Russell Stover Mint Patties',4,NULL,1,0,0,0,0,0,NULL,1),(1363,'Button, Brides Brew Crew',12,'077757011061',2.69,'Button, Brides Brew Crew',1,NULL,0,0,0,0,0,0,2.69,1),(1364,'Wine Glass Favor',12,'077757021541',4.99,'Wine Glass Favor',1,NULL,0,0,0,0,0,0,4.99,1),(1365,'Bottle Stopper',12,'077757201318',9.99,'Bottle Stopper',1,NULL,0,0,0,0,0,0,9.99,1),(1366,'Wine Stopper, VIP',12,'077757204364',9.99,'Wine Stopper, VIP',1,NULL,0,0,0,0,0,0,9.99,1),(1367,'Brooch, Margarita',12,'077757230004',6.5,'Brooch, Margarita',1,NULL,0,0,0,0,0,0,6.5,1),(1368,'Brooch, Martini',12,'077757230028',5.5,'Brooch, Martini',1,NULL,0,0,0,0,0,0,5.5,1),(1369,'Earrings',12,'077757230141',5,'Earrings',1,NULL,0,0,0,0,0,0,5,1),(1370,'Earrings, Margarita',12,'077757230165',6.99,'Earrings, Margarita',1,NULL,0,0,0,0,0,0,6.99,1),(1371,'Earrings',12,'077757230189',4.5,'Earrings',1,NULL,0,0,0,0,0,0,4.5,1),(1372,'Hair Clip, Martini',12,'077757230196',2.99,'Hair Clip, Martini',1,NULL,0,0,0,0,0,0,2.99,1),(1373,'Hair Clip, Gold Grape',12,'077757230202',2.99,'Hair Clip, Gold Grape',1,NULL,0,0,0,0,0,0,2.99,1),(1374,'Hair Clip, Red Bottle',12,'077757230219',2.99,'Hair Clip, Red Bottle',1,NULL,0,0,0,0,0,0,2.99,1),(1375,'Hair Clip, Vineyard',12,'077757230226',2.5,'Hair Clip, Vineyard',1,NULL,0,0,0,0,0,0,2.5,1),(1376,'Hair Clip, Martini',12,'077757230233',2.99,'Hair Clip, Martini',1,NULL,0,0,0,0,0,0,2.99,1),(1377,'Hair Clip, Green Bottle',12,'077757230257',2.99,'Hair Clip, Green Bottle',1,NULL,0,0,0,0,0,0,2.99,1),(1378,'Pin, Wine',12,'077757230325',2.99,'Pin, Wine',1,NULL,0,0,0,0,0,0,2.99,1),(1379,'Necklace, Green Grapes',12,'077757230394',6.5,'Necklace, Green Grapes',1,NULL,0,0,0,0,0,0,6.5,1),(1380,'Beer Epicoozie',12,'077757402074',5.99,'Beer Epicoozie',1,NULL,0,0,0,0,0,0,5.99,1),(1381,'Holdups, Wine Rack',12,'077757403064',4.99,'Holdups, Wine Rack',1,NULL,0,0,0,0,0,0,4.99,1),(1382,'Epic Wine Bottle Tags',12,'077757411250',5.99,'Epic Wine Bottle Tags',1,NULL,0,0,0,0,0,0,5.99,1),(1383,'Bottle Candle',12,'077757421204',5.99,'Bottle Candle',1,NULL,0,0,0,0,0,0,5.99,1),(1384,'Wine Glass Lampshades',12,'077757421792',11.99,'Wine Glass Lampshades',1,NULL,0,0,0,0,0,0,11.99,1),(1385,'Floating Candle',12,'077757422003',7.99,'Floating Candle',1,NULL,0,0,0,0,0,0,7.99,1),(1386,'Bottle Bag, Fabric',12,'077757430121',3.99,'Bottle Bag, Fabric',1,NULL,0,0,0,0,0,0,3.99,1),(1387,'Bottle Bag, Cloth Bag',12,'077757430169',3.99,'Bottle Bag, Cloth Bag',1,NULL,0,0,0,0,0,0,3.99,1),(1388,'Bottle Bag, Cloth',12,'077757430268',3.99,'Bottle Bag, Cloth',1,NULL,0,0,0,0,0,0,3.99,1),(1389,'Epic  Wine Gift back Sheer Green',12,'077757430282',3.99,'Epic Wine Gift back Sheer Green',1,NULL,0,0,0,0,0,0,3.99,1),(1390,'Bottle Bag',12,'077757430572',2.75,'Bottle Bag',1,NULL,0,0,0,0,0,0,2.75,1),(1391,'Bottle Bag',12,'077757430671',2.5,'Bottle Bag',1,NULL,0,0,0,0,0,0,2.5,1),(1392,'Bottle carrier',12,'077757430701',3.99,'Bottle carrier',1,NULL,0,0,0,0,0,0,3.99,1),(1393,'Bottle Bag, Mini',12,'077757430787',0.99,'Bottle Bag, Mini',1,NULL,0,0,0,0,0,0,0.99,1),(1394,'Bottle Bag',12,'077757431036',3.49,'Bottle Bag',1,NULL,0,0,0,0,0,0,3.49,1),(1395,'Wine Bag',12,'077757433177',2.99,'Wine Bag',1,NULL,0,0,0,0,0,0,2.99,1),(1396,'Bottle Bag',12,'077757433214',2.99,'Bottle Bag',1,NULL,0,0,0,0,0,0,2.99,1),(1397,'Bottle Bag',12,'077757433221',2.99,'Bottle Bag',1,NULL,0,0,0,0,0,0,2.99,1),(1398,'Wine Bag',12,'077757433306',2.99,'Wine Bag',1,NULL,0,0,0,0,0,0,2,1),(1399,'Bottle and Ice Bag',12,'077757433788',5,'Bottle and Ice Bag',1,NULL,0,0,0,0,0,0,5,1),(1400,'Wine Bag, Love Wine',12,'077757433931',2.99,'Wine Bag, Love Wine',1,NULL,0,0,0,0,0,0,2.99,1),(1401,'Bottle Bag, Wine Shop',12,'077757433948',2.99,'Bottle Bag, Wine Shop',1,NULL,0,0,0,0,0,0,2.99,1),(1402,'Epic wine Bottle Gift tags',12,'077757436284',2.99,'Epic wine Bottle Gift tags',1,NULL,0,0,0,0,0,0,2.99,1),(1403,'Bottle Bag',12,'077757440762',3.99,'Bottle Bag',1,NULL,0,0,0,0,0,0,3.99,1),(1404,'Bottle Box, Silver',12,'077757440908',3.99,'Bottle Box, Silver',1,NULL,0,0,0,0,0,0,3.99,1),(1405,'Bottle Box, Gold',12,'077757440946',3.99,'Bottle Box, Gold',1,NULL,0,0,0,0,0,0,3.99,1),(1406,'Bottle Gift Box',12,'077757441257',2.69,'Bottle Gift Box',1,NULL,0,0,0,0,0,0,2.69,1),(1407,'Wine Bottle Gift Box',12,'077757441271',3.99,'Wine Bottle Gift Box',1,NULL,0,0,0,0,0,0,3.99,1),(1408,'Epic Keep it Hot Sake Set',12,'077757751233',21.99,'Epic Keep it Hot Sake Set',1,NULL,0,0,0,0,0,0,21.99,1),(1409,'Cheese Knives',12,'077757752001',12.99,'Cheese Knives',1,NULL,0,0,0,0,0,0,12.99,1),(1410,'Bottle Chees server & spreader',12,'077757752278',12.99,'Bottle Chees server & spreader',1,NULL,0,0,0,0,0,0,12.99,1),(1411,'Epic Stem Glass Slippers',12,'077757821004',5.99,'Epic Stem Glass Slippers',1,NULL,0,0,0,0,0,0,5.99,1),(1412,'My Glass Charms',12,'077757830501',5.99,'My Glass Charms',1,NULL,0,0,0,0,0,0,5.99,1),(1413,'Wine Accessories Glass Stick\'ems',12,'077757830945',3.99,'Wine Accessories Glass Stick\'ems',1,NULL,0,0,0,0,0,0,3.99,1),(1414,'Epic Champagne Stopper',12,'077757901003',7.99,'Epic Champagne Stopper',1,NULL,0,0,0,0,0,0,7.99,1),(1415,'Cork Cage, Water Can',12,'077757910715',31.99,'Cork Cage, Water Can',1,NULL,0,0,0,0,0,0,31.99,1),(1416,'Cork Cage, White Corset',12,'077757910845',25.99,'Cork Cage, White Corset',1,NULL,0,0,0,0,0,0,25.99,1),(1417,'Bota Bag',12,'077757912405',9.99,'Bota Bag',1,NULL,0,0,0,0,0,0,9.99,1),(1418,'Martini picks',12,'077757932212',12.99,'Martini picks',1,NULL,0,0,0,0,0,0,12.99,1),(1419,'7up 2 L',21,'078000000344',2.99,'7up 2 L',15,1,0,0,0,0,0,0,1.8,1),(1420,'Squirt 2  liter',12,'078000016468',2.69,'Squirt 2 liter',2,NULL,0,0,0,0,0,0,1.29,1),(1421,'Schweppes Club Soda',12,'078000203455',2.5,'Schweppes Club Soda',3,NULL,0,0,0,0,0,0,1.25,1),(1422,'Schweppes Tonic Water 1 L',21,'078000218459',2.99,'Schweppes Tonic Water 1 L',15,1,0,0,0,0,0,0,1.58,1),(1423,'Schweppes Diet Tonic',12,'078000219456',2.5,'Schweppes Diet Tonic',3,NULL,0,0,0,0,0,0,1.25,1),(1424,'7-up 12oz',12,'07803802',1,'7-up 12oz',2,NULL,0,0,0,0,0,0,1,1),(1425,'Ginger Ale',12,'07811403',4.99,'Ginger Ale',2,NULL,0,0,0,0,0,0,3,1),(1426,'Wine Journal',12,'078228346071',9.99,'Wine Journal',1,NULL,0,0,0,0,0,0,9.99,1),(1427,'Habanero Cheddar Cheese, Cabot',12,'078354719183',6.99,'Habanero Cheddar Cheese, Cabot',4,NULL,1,0,0,0,0,0,6.99,1),(1428,'Canfield\'s Diet Tonic Water 1 L',12,'078400000371',2.5,'Canfield\'s Diet Tonic Water 1 L',15,1,0,0,0,0,0,0,2.5,1),(1429,'Canfield\'s Club Soda',21,'078400000579',2.99,'Canfield\'s Club Soda',15,1,0,0,0,0,0,0,2.5,1),(1430,'Tonic Water',12,'078400000586',2.5,'Tonic Water',2,NULL,0,0,0,0,0,0,2.5,1),(1431,'Daily Chef Spacghetti',12,'078742003474',2.99,'Daily Chef Spacghetti',4,NULL,1,0,0,0,0,0,2.99,1),(1432,'Hummus, Classic',12,'078742058825',5.99,'Hummus, Classic',4,NULL,1,0,0,0,0,0,5.99,1),(1433,'Club Soda Low Sodium 1 L',12,'078742087146',2.5,'Club Soda Low Sodium 1 L',15,1,0,0,0,0,0,0,2.5,1),(1434,'Clear American Lemon Sparkling Water 1 L',12,'078742088945',2.5,'Clear American Lemon Sparkling Water 1 L',15,1,0,0,0,0,0,0,2.5,1),(1435,'Tonic Water 1 L',12,'078742089256',2.5,'Tonic Water 1 L',15,1,0,0,0,0,0,0,2.5,1),(1436,'Diet Tonic Water 1 L',12,'078742091532',2.5,'Diet Tonic Water 1 L',15,1,0,0,0,0,0,0,2.5,1),(1437,'Artichoke Hearts, Whole',23,'078742146515',12.99,'Artichoke Hearts, Whole',4,NULL,1,0,0,0,0,0,7,1),(1438,'Pixy Stix',12,'079200183172',1.99,'Pixy Stix',2,NULL,0,0,0,0,0,0,1.07,1),(1439,'Blanton\'s Bourbon',18,'080244002039',125,'Blanton\'s Bourbon',7,NULL,0,0,0,0,0,0,44.13,1),(1440,'Ancient Age Bourbon',10,'080244002138',17.99,'Ancient Age Bourbon',7,NULL,0,0,0,0,0,0,10.25,1),(1441,'Buffalo Trace Bourbon',18,'080244009236',30.99,'Buffalo Trace Bourbon',7,NULL,0,0,0,0,0,0,19.99,1),(1442,'Mozart Chocolate Cream',12,'080368937019',31.99,'Mozart Chocolate Cream',7,1,0,0,0,0,0,0,31.99,1),(1443,'Seagram\'s Jamaican Me Happy',17,'080432103463',5.99,'Seagram\'s Jamaican Me Happy',6,NULL,0,0,0,0,0,0,4.25,1),(1444,'Green Spot Irish Whiskey',18,'080432105993',75.99,'Green Spot Irish Whiskey',7,1,0,0,0,0,0,0,52.97,1),(1445,'Becherovka Herbal Liqueur',12,'080432106624',25.99,'Becherovka Herbal Liqueur',7,NULL,0,0,0,0,0,0,25.99,1),(1446,'Chivas Regal 12 Year Scotch',18,'080432400395',41.99,'Chivas Regal 12 Year Scotch',7,1,0,0,0,0,0,0,30.34,1),(1447,'Glenlivet 12 Year Scotch 1 L',18,'080432400708',61.99,'Glenlivet 12 Year Scotch 1 L',7,1,0,0,0,0,0,0,44.47,1),(1448,'Jameson Irish Whiskey 50ml',12,'080432500101',4.5,'Jameson Irish Whiskey 50ml',7,NULL,0,0,0,0,0,0,3.75,1),(1449,'Jameson Irish Whiskey 1 L',12,'080432500118',40.86,'Jameson Irish Whiskey 1 L',7,1,0,0,0,0,0,0,40.86,1),(1450,'Washington Hills Riesling',13,'080438192942',11.99,'Washington Hills Riesling',5,1,0,0,0,0,2,0,9,12),(1451,'Bacardi Oakheart Spiced Rum',18,'080480001520',16.99,'Bacardi Oakheart Spiced Rum',7,1,0,0,0,0,0,0,11.75,1),(1452,'Bacardi White Rum 50ml',12,'080480007201',1.99,'Bacardi White Rum 50ml',7,NULL,0,0,0,0,0,0,1.99,1),(1453,'Bacardi Blanca Rum 1.75 L',12,'080480015206',32.5,'Bacardi Blanca Rum 1.75 L',7,1,0,0,0,0,0,0,32.5,1),(1454,'Bacardi 1 L',12,'080480015305',20.95,'Bacardi 1 L',7,1,0,0,0,0,0,0,20.95,1),(1455,'Bacardi Supior 50ml',12,'080480016210',1.75,'Bacardi Supior 50ml',7,NULL,0,0,0,0,0,0,1.75,1),(1456,'Dewar\'s White Label Scotch 1.75 L',18,'080480230005',56.65,'Dewar\'s White Label Scotch 1.75 L',7,1,0,0,0,0,0,0,56.65,1),(1457,'Dewar\'s White Label Scotch 1 L',10,'080480230012',0,'Dewar\'s White Label Scotch 1 L',7,1,0,0,0,0,0,0,0,1),(1458,'Grey Goose Vodka 1 Liter',1,'080480280017',48.25,'Grey Goose Vodka 1 Liter',7,NULL,0,0,0,0,0,0,35,1),(1459,'Grey Goose Vodka 50ml',18,'080480280055',4.99,'Grey Goose Vodka 50ml',7,NULL,0,0,0,0,0,0,4.99,1),(1460,'Bombay Sapphire Gin 1 L',12,'080480301019',35.65,'Bombay Sapphire Gin 1 L',7,1,0,0,0,0,0,0,35.65,1),(1461,'Bacardi Limon 1 L',18,'080480355302',21.99,'Bacardi Limon 1 L',7,1,0,0,0,0,0,0,15.25,1),(1462,'B&B Benedictine',12,'080480545406',41.95,'B&B Benedictine',7,1,0,0,0,0,0,0,41.95,1),(1463,'St. Germain Spiritz',12,'080480983598',47.99,'St. Germain Spiritz',7,1,0,0,0,0,0,0,47.99,1),(1464,'Move do Moscato',13,'080516055640',10.99,'Move do Moscato',5,1,0,0,0,0,2,0,6.75,12),(1465,'Riunite Lambrusco',12,'080516135144',8.99,'Riunite Lambrusco',5,1,0,0,0,0,2,0,8.99,12),(1466,'Chaucer\'s Mead',11,'080600400028',15.99,'Chaucer\'s Mead',5,1,0,0,0,0,2,0,11.25,12),(1467,'99 Pepper',12,'080660000022',16.36,'99 Pepper',7,1,0,0,0,0,0,0,16.36,1),(1468,'99 Pinapples Liquer 50ml',12,'080660010700',2.99,'99 Pinapples Liquer 50ml',7,NULL,0,0,0,0,0,0,2.99,1),(1469,'90 Meukow Cognac',12,'080660130255',46.99,'90 Meukow Cognac',7,1,0,0,0,0,0,0,46.99,1),(1470,'Trn High Bourbon 1 L',12,'080660203034',11.99,'Trn High Bourbon 1 L',7,1,0,0,0,0,0,0,11.99,1),(1471,'Barton Gin 1 L',12,'080660411330',10.99,'Barton Gin 1 L',7,1,0,0,0,0,0,0,10.99,1),(1472,'Barton Vodka 1.75 L',12,'080660472614',15.53,'Barton Vodka 1.75 L',7,1,0,0,0,0,0,0,15.53,1),(1473,'Barton Vodka 1 L',12,'080660472638',9.99,'Barton Vodka 1 L',7,1,0,0,0,0,0,0,9.99,1),(1474,'Pacifico 6-pack',1,'080660953014',11.99,'Pacifico 6-pack',6,NULL,0,0,0,0,0,0,7.99,1),(1475,'Corona Extra Lager 6 Pack',1,'080660956053',10.99,'Corona Extra Lager 6 Pack',6,6,0,0,0,0,0,0,7.75,1),(1476,'Corona Light',1,'080660956251',10.99,'Corona Light',6,NULL,0,0,0,0,0,0,7.75,1),(1477,'St. Pauli Girl Lager 6 Pack',1,'080660959351',9.99,'St. Pauli Girl Lager 6 Pack',6,6,0,0,0,0,0,0,9.99,1),(1478,'Pacifico Single Beer',1,'08066640',2.99,'Pacifico Single Beer',6,NULL,0,0,0,0,0,0,1.25,1),(1479,'Jim Beam Bourbon 1.75 L',12,'080686001102',45.09,'Jim Beam Bourbon 1.75 L',7,1,0,0,0,0,0,0,45.09,1),(1480,'Jim Beam',18,'080686001119',45.09,'Jim Beam',7,NULL,0,0,0,0,0,0,38,1),(1481,'Jim Beam Bourbon 1 L',12,'080686001201',27.45,'Jim Beam Bourbon 1 L',7,1,0,0,0,0,0,0,27.45,1),(1482,'Mini Jim Beam 50ml',10,'080686001904',1.85,'Mini Jim Beam 50ml',7,NULL,0,0,0,0,0,0,1.4,1),(1483,'Jim Beam Kentuky Fire 50ml',12,'080686006367',1.49,'Jim Beam Kentuky Fire 50ml',7,NULL,0,0,0,0,0,0,1.49,1),(1484,'Jim Beam Vanilla 100 mL',12,'080686006886',2.99,'Jim Beam Vanilla 100 mL',7,1,0,0,0,0,0,0,2.99,1),(1485,'Knob Creek Whiskey 100 Proof Small Batch',18,'080686016205',53.99,'Knob Creek Whiskey 1 L',7,1,0,0,0,0,0,0,37.99,1),(1486,'Knob Creek Rye Old Fashioned Kit',10,'080686016656',42.99,'Knob Creek Rye Old Fashioned Kit',7,NULL,0,0,0,0,0,0,30,1),(1487,'Jim Beam Peach Whiskey 50ml',12,'080686021179',1.75,'Jim Beam Peach Whiskey 50ml',7,NULL,0,0,0,0,0,0,1.75,1),(1488,'Jim Beam Black gift box',12,'080686034155',30.99,'Jim Beam Black gift box',7,1,0,0,0,0,0,0,30.99,1),(1489,'Pucker Cherry Vodka',12,'080686119074',1.99,'Pucker Cherry Vodka',7,NULL,0,0,0,0,0,0,1.99,1),(1490,'DeKuyper Blue Curacao',18,'080686316022',13.99,'DeKuyper Blue Curacao',7,NULL,0,0,0,0,0,0,9,1),(1491,'DeKuyper   Schnapps 1 L',12,'080686319207',17.53,'DeKuyper Schnapps 1 L',7,1,0,0,0,0,0,0,17.53,1),(1492,'DeKuyper Creme de Banana Schnapps',12,'080686333029',15.99,'DeKuyper Creme de Banana Schnapps',7,1,0,0,0,0,0,0,15.99,1),(1493,'DeKuyper Hot Damn!',10,'080686373209',17.53,'DeKuyper Hot Damn!',7,NULL,0,0,0,0,0,0,12,1),(1494,'DeKuyper  Triple Sec 1 L',12,'080686381204',10.99,'DeKuyper Triple Sec 1 L',7,1,0,0,0,0,0,0,10.99,1),(1495,'DeKuyper  Vanilla Schnapps',12,'080686391401',15.99,'DeKuyper Vanilla Schnapps',7,1,0,0,0,0,0,0,15.99,1),(1496,'DeKuyper Grape  Schnapps 1 L',12,'080686393207',17.53,'DeKuyper Grape Schnapps 1 L',7,1,0,0,0,0,0,0,17.53,1),(1497,'DeKuyper  Sour Apple Schnapps 1 L',12,'080686395201',17.53,'DeKuyper Sour Apple Schnapps 1 L',7,1,0,0,0,0,0,0,17.53,1),(1498,'DeKuyper Watermelon  Schnapps 1 L',12,'080686396208',17.53,'DeKuyper Watermelon Schnapps 1 L',7,1,0,0,0,0,0,0,17.53,1),(1499,'Cockburns Tawny Porto',12,'080686740131',47.99,'Cockburns Tawny Porto',5,1,0,0,0,0,2,0,47.99,12),(1500,'El Tesoro Anejo Tequila',18,'080686761402',72.99,'El Tesoro Anejo Tequila',7,NULL,0,0,0,0,0,0,52,1),(1501,'Laphroaig 10 Year Scotch',18,'080686813019',61.99,'Laphroaig 10 year Scotch',7,1,0,0,0,0,0,0,44.75,1),(1502,'Canadian Club',12,'080686821021',21.4,'Canadian Club',7,1,0,0,0,0,0,0,21.4,1),(1503,'Sauza Silver Tequila',12,'080686832010',21.94,'Sauza Silver Tequila',7,1,0,0,0,0,0,0,21.94,1),(1504,'Hornitos Reposado Tequila',12,'080686835028',25.99,'Hornitos Reposado Tequila',7,1,0,0,0,0,0,0,25.99,1),(1505,'Hornitos Lime Shot',10,'080686835486',29.99,'Hornitos Lime Shot',7,NULL,0,0,0,0,0,0,21.25,1),(1506,'Sauza Silver',10,'080686839033',21.94,'Sauza Silver',7,NULL,0,0,0,0,0,0,15.99,1),(1507,'Sauza Margarita Mix',18,'080686841012',5.99,'Sauza Margarita Mix',2,NULL,0,0,0,0,0,0,4,1),(1508,'Pinnacle Vodka 1.75 L',12,'080686929451',27.45,'Pinnacle Vodka 1.75 L',7,1,0,0,0,0,0,0,27.45,1),(1509,'Pinnacle Peach Vodka 200 mL',10,'080686931348',4.99,'Pinnacle Peach Vodka 200 mL',7,1,0,0,0,0,0,0,3.75,1),(1510,'Courvoisier Cognac VS',18,'080686961048',36.27,'Courvoisier Cognac VS',7,1,0,0,0,0,0,0,36.27,1),(1511,'Courvoisier Cognac VSOP',12,'080686962045',44.99,'Courvoisier Cognac VSOP',7,1,0,0,0,0,0,0,44.99,1),(1512,'Courvoisier VSOP Cognac 50ml',12,'080686962076',4.99,'Courvoisier VSOP Cognac 50ml',7,NULL,0,0,0,0,0,0,4.99,1),(1513,'Cruzan Black Cherry Rum',12,'080686970132',15.35,'Cruzan Black Cherry Rum',7,1,0,0,0,0,0,0,15.35,1),(1514,'Richard grant Brut Pinot Noir',11,'081054003162',32.99,'Richard grant Brut Pinot Noir',5,1,0,0,0,0,2,0,28,12),(1515,'JJJ Almond',11,'081054024570',14.99,'JJJ Almond',5,1,0,0,0,0,2,0,8.25,12),(1516,'Napa Ridge Cabernet',12,'081054064958',18.99,'Napa Ridge Cabernet',5,1,0,0,0,0,2,0,18.99,12),(1517,'Woodford Reserve Bourbon',18,'081128001506',47.99,'Woodford Reserve Bourbon',7,1,0,0,0,0,0,0,34,1),(1518,'Kah Reposado Tequila',12,'081240750269',69.99,'Kah Reposado Tequila',7,1,0,0,0,0,0,0,69.99,1),(1519,'Pinot Evil Pinot Noir',19,'081308570075',12.99,'Pinot Evil Pinot Noir',5,1,0,0,0,0,2,0,6.5,12),(1520,'Veuve Clicquot Champagne Brut',13,'081753050207',69.99,'Veuve Clicquot Champagne Brut',5,1,0,0,0,0,2,0,48.75,12),(1521,'Nvmanthia',12,'081753814090',49.99,'Nvmanthia',5,1,0,0,0,0,2,0,49.99,12),(1522,'Moet et Chandon Champagne Dom Perignon',13,'081753822422',199.99,'Moet et Chandon Champagne Dom Perignon',5,1,0,0,0,0,2,0,138.9,12),(1523,'Glenmorange',12,'081753828936',49.99,'Glenmorange',7,1,0,0,0,0,0,0,49.99,1),(1524,'Ardbeg Islay Single Malt Ten Year',10,'081753831677',57.99,'Ardbeg Islay Single Malt Ten Year',7,NULL,0,0,0,0,0,0,40.74,1),(1525,'Crown Royal XO Whiskey',18,'082000003823',54.99,'Crown Royal XO Whiskey',7,1,0,0,0,0,0,0,37.49,1),(1526,'Bailey\'s Strawberries & Cream 50ml',18,'082000005582',3.5,'Bailey\'s Strawberries & Cream 50ml',7,NULL,0,0,0,0,0,0,1.9,1),(1527,'Smirnoff Vodka 1.75 L',12,'082000727606',31.98,'Smirnoff Vodka 1.75 L',7,1,0,0,0,0,0,0,31.98,1),(1528,'Smirnoff Strawberry',18,'082000729358',21.99,'Smirnoff Strawberry',7,NULL,0,0,0,0,0,0,14.88,1),(1529,'Smirnoff Blueberry Vodka',12,'082000732914',19.99,'Smirnoff Blueberry Vodka',7,1,0,0,0,0,0,0,24.485,1),(1530,'Bullet 95 Rye 1L',18,'082000752974',43.99,'Bullet 95 Rye 1L',7,1,0,0,0,0,0,0,31.25,1),(1531,'Crown Royal Regal Apple Whisky 1 L',12,'082000771586',40.68,'Crown Royal Regal Apple Whisky 1 L',7,1,0,0,0,0,0,0,40.68,1),(1532,'Baileys Almande Liqueur',18,'082000776284',33.99,'Baileys Almande Liqueur',7,1,0,0,0,0,0,0,25.5,1),(1533,'The Whisky Enthusiast',12,'082000781752',44.99,'The Whisky Enthusiast',7,NULL,0,0,0,0,0,0,44.99,1),(1534,'Smirnoff Ice Single',1,'082000782490',1.99,'Smirnoff Ice Single',6,NULL,0,0,0,0,0,0,1.25,1),(1535,'Smirnoff Red, White & Berry 6-pack',17,'082000782506',10.99,'Smirnoff Red, White & Berry 6-pack',6,NULL,0,0,0,0,0,0,7.8,1),(1536,'Crown Royal Peach 750ml',18,'082000782919',36.99,'Crown Royal Peach 750ml',7,NULL,0,0,0,0,0,0,25.14,1),(1537,'Crown Royal Noble Collection',12,'082000785262',62.99,'Crown Royal Noble Collection',7,1,0,0,0,0,0,0,62.99,1),(1538,'Smirnoff Love Wins Vodka',12,'082000788133',34.99,'Smirnoff Love Wins Vodka',7,1,0,0,0,0,0,0,34.99,1),(1539,'Smirnoff Moscow Mule',12,'082000788416',17.99,'Smirnoff Moscow Mule',7,1,0,0,0,0,0,0,17.99,1),(1540,'Captain Morgan Spiced Rum 1.75 L',12,'082000789277',38.8,'Captain Morgan Spiced Rum 1.75 L',7,1,0,0,0,0,0,0,38.8,1),(1541,'Captain Morgan 1.75L',18,'082000791126',38.8,'1.75 Captain margan',7,1,0,0,0,1,3,0,4,1),(1542,'Captain Morgan 1.75 Liter',18,'082000791133',37.99,'Captain Morgan 1.75 Liter',7,NULL,0,0,0,0,0,0,27,1),(1543,'Mini Jack Daniels 50ml',10,'082184000052',1.99,'Mini Jack Daniels 50ml',7,NULL,0,0,0,0,0,0,1.5,1),(1544,'Jack Daniel\'s Watermelon Punch',12,'082184000915',2.99,'Jack Daniel\'s Watermelon Punch',6,1,0,0,0,0,0,0,2.99,1),(1545,'Jack Daniel\'s Whiskey 1.75 L',18,'082184090428',65.43,'Jack Daniel\'s Whiskey 1.75 L',7,1,0,0,0,0,0,0,65.43,1),(1546,'Jack Daniel\'s Whiskey 1 L',12,'082184090442',40.68,'Jack Daniel\'s Whiskey 1 L',7,1,0,0,0,0,0,0,40.68,1),(1547,'Jack Daniel\'s Whiskey 375 mL',10,'082184090510',15.75,'Jack Daniel\'s Whiskey 375 mL',7,1,0,0,0,0,0,0,11.25,1),(1548,'Jeremiah Weed Sweet Tea Vodka 1L',18,'08220408',23.99,'Jeremiah Weed Sweet Tea Vodka 1L',7,NULL,0,0,0,0,0,0,16.75,1),(1549,'Bota Box Cabernet',13,'082242010450',21.99,'Bota Box Cabernet',5,1,0,0,0,0,2,0,15,12),(1550,'Bota Box Chardonnay',13,'082242011051',21.99,'Bota Box Chardonnay',5,1,0,0,0,0,2,0,16,12),(1551,'Bota Box Pino Noir',10,'082242012362',18,'Bota Box Pino Noir',5,1,0,0,0,0,2,0,15,12),(1552,'Bota Box Pinot Grigio',13,'082242013253',21.99,'Bota Box Pinot Grigio',5,1,0,0,0,0,2,0,15,12),(1553,'Seagram\'s Dark Honey Mini 50ml',10,'08225306',1.75,'Seagram\'s Dark Honey Mini 50ml',7,NULL,0,0,0,0,0,0,1.25,1),(1554,'Do Q Cristal Rum',12,'082301750020',14.99,'Do Q Cristal Rum',7,1,0,0,0,0,0,0,14.99,1),(1555,'Captain Morgan White Rum 50ml',12,'08237806',1.99,'Captain Morgan White Rum 50ml',7,NULL,0,0,0,0,0,0,1.99,1),(1556,'Seagram\'s Apple Mini 50ml',10,'08238407',1.75,'Seagram\'s Apple Mini 50ml',7,NULL,0,0,0,0,0,0,1.25,1),(1557,'Smirnoff Raspberry 50ml',12,'08240004',1.99,'Smirnoff Raspberry 50ml',7,NULL,0,0,0,0,0,0,1.99,1),(1558,'Smironoff 50ml',18,'08247201',1.85,'Smironoff 50ml',7,NULL,0,0,0,0,0,0,1.1,1),(1559,'Captain Morgan Cannon Blast 50ml',12,'08247803',1.99,'Captain Morgan Cannon Blast 50ml',7,NULL,0,0,0,0,0,0,1.99,1),(1560,'Mariner Dry Creek Maritage 2006 1.5 L',12,'082491070137',89.99,'Mariner Dry Creek Maritage 2006 1.5 L',5,1,0,0,0,0,2,0,89.99,12),(1561,'Bailys Almande 50ml',12,'08252009',3.25,'Bailys Almande 50ml',7,NULL,0,0,0,0,0,0,3.25,1),(1562,'OZV Old Vine Zinfandel Lodi California',10,'082544009046',15.99,'OZV Old Vine Zinfandel Lodi California',5,1,0,0,0,0,2,0,9,12),(1563,'Smirnoff Vodka 375ml',18,'08256102',10.99,'Smirnoff Vodka 375ml',7,NULL,0,0,0,0,0,0,7.63,1),(1564,'Captain Morgan Apple Smash 50ml',12,'08257208',1.99,'Captain Morgan Apple Smash 50ml',7,NULL,0,0,0,0,0,0,1.99,1),(1565,'Smirnoff Moscow Mule 50ml',12,'08258906',1.99,'Smirnoff Moscow Mule 50ml',7,NULL,0,0,0,0,0,0,1.99,1),(1566,'Glow Bars',12,'082676110610',1.69,'Glow Bars',1,NULL,0,0,0,0,0,0,1.69,1),(1567,'Wisdom & Warter Amontillado Sherry',13,'082734001317',17.99,'Extra Amontillado Sherry',5,1,0,0,0,0,2,0,13,12),(1568,'Villa Cerna Chianti Riserva',12,'082734192343',40,'Villa Cerna Chianti Riserva',5,1,0,0,0,0,2,0,40,12),(1569,'Frontera Chargonnay 187ml',12,'082734314097',2.79,'Frontera Chargonnay 187ml',5,1,0,0,0,0,2,0,2.79,12),(1570,'Frontera Chardonnay 4 pack',12,'082734314196',8.99,'Frontera Chardonnay 4 pack',5,4,0,0,0,0,2,0,8.99,8),(1571,'Trivento Malbec Reserve',13,'082734341246',13.99,'Trivento Malbec Reserve',5,1,0,0,0,0,2,0,13.99,12),(1572,'Trivento Golden Reserve Malbec',13,'082734344049',25.99,'Trivento Golden Reserve Malbec',5,1,0,0,0,0,2,0,19,12),(1573,'Bonterra Equinox Red',12,'082896003044',13.99,'Bonterra Equinox Red',5,1,0,0,0,0,2,0,13.99,12),(1574,'Bonterra Merlot',13,'082896077793',16.75,'Bonterra Merlot',5,1,0,0,0,0,2,0,16.75,12),(1575,'Fetzer Gewurztraminer',12,'082896700257',11.99,'Fetzer Gewurztraminer',5,1,0,0,0,0,2,0,5.36,12),(1576,'Fetzer Riesling',13,'082896710232',11.99,'Fetzer Riesling',5,1,0,0,0,0,2,0,8.55,12),(1577,'Bonterra Cabernet Sauvignon',12,'082896780402',15.99,'Bonterra Cabernet Sauvignon',5,1,0,0,0,0,2,0,15.99,12),(1578,'Bonterra Chardonnay',10,'082896780419',14.99,'Bonterra Chardonnay',5,1,0,0,0,0,2,0,9.75,12),(1579,'Ice Mountain Water',23,'083046453375',1.5,'Water',4,NULL,1,0,0,0,0,0,0.5,1),(1580,'Quintessa Napa Valley Red 375 mL',12,'083085003517',89.99,'Quintessa Napa Valley Red 375 mL',5,1,0,0,0,0,2,0,89.99,12),(1581,'Rosatello Rose',12,'083085430016',14.5,'Rosatello Rose',5,1,0,0,0,0,2,0,14.5,12),(1583,'Jagermeister 1 L',12,'083089660150',33.93,'Jagermeister 1 L',7,1,0,0,0,0,0,0,33.93,1),(1584,'Franzia White Zinfandel 5L',12,'083120103196',21.99,'Franzia White Zinfandel 5L',5,1,0,0,0,0,2,0,21.99,12),(1585,'Don Eduardo Silver Tequlia',12,'083300032551',47.99,'Don Eduardo Silver Tequlia',7,1,0,0,0,0,0,0,47.99,1),(1586,'Amarula Cream Liqueur',18,'083300048729',24.99,'Amarula Cream Liqueur',7,1,0,0,0,0,0,0,17.64,1),(1587,'Da Luca Prosecco',13,'083417006612',14.99,'Da Luca Prosecco',5,1,0,0,0,0,2,0,11.78429,12),(1588,'Mud House Sauvignon Blanc 2017 New Zealand',10,'083417007022',14.99,'Mud House Sauvignon Blanc 2017 New Zealand',5,1,0,0,0,0,2,0,11.25,12),(1589,'Geyser Peak Cabernet Sauvignon Reserve',12,'083417023206',39.99,'Geyser Peak Cabernet Sauvignon Reserve',5,1,0,0,0,0,2,0,39.99,12),(1590,'Gibson Marsala',11,'083420127571',10.99,'Gibson Marsala',5,1,0,0,0,0,2,0,6.75,12),(1591,'Gibson pale Dry Sherry',12,'083420151699',11.99,'Gibson pale Dry Sherry',5,1,0,0,0,0,2,0,11.99,12),(1592,'Elk Cove Pinot Blanc',12,'083648842584',19.99,'Elk Cove Pinot Blanc',5,1,0,0,0,0,2,0,19.99,12),(1593,'Sailor Jerry Spice Rum 1 L',12,'083664868377',25.99,'Sailor Jerry Spice Rum 1 L',7,1,0,0,0,0,0,0,25.99,1),(1594,'Hendrick\'s Gin 1 L',12,'083664868780',45.46,'Hendrick\'s Gin 1 L',7,1,0,0,0,0,0,0,45.46,1),(1595,'Milagro Silver Tequila',12,'083664868919',33.99,'Milagro Silver Tequila',7,1,0,0,0,0,0,0,33.99,1),(1596,'Monkey Shoulder Scotch',12,'083664872541',37.75,'Monkey Shoulder Scotch',7,1,0,0,0,0,0,0,37.75,1),(1597,'Balvenie 15 Sherry Cask',10,'083664873197',118.99,'Balvenie 15 Sherry Cask',7,NULL,0,0,0,0,0,0,94.75,1),(1598,'Drambuie Spiced Whiskey',12,'083664873623',45.8,'Drambuie Spiced Whiskey',7,1,0,0,0,0,0,0,45.8,1),(1599,'Hazy Little thing IPA',1,'083783110104',11.99,'Hazy Little thing IPA',6,NULL,0,0,0,0,0,0,8.25,1),(1600,'Torpedo Extra Pale Ale 12 Pack',12,'083783381023',19.99,'Torpedo Extra Pale Ale 12 Pack',6,12,0,0,0,0,0,0,19.99,1),(1601,'Cook\'s Extra Dry Sparkling Wine 187 mL',12,'083804074507',2.99,'Cook\'s Extra Dry Sparkling Wine 187 mL',5,1,0,0,0,0,2,0,2.99,12),(1602,'Cook\'s Extra Dry 4-Pack 187ml\'s',19,'083804074699',11.99,'Cook extra dry 4 pack',5,4,0,0,0,0,2,0,8.5,8),(1603,'Cooks Spumante',12,'083804074729',10.99,'Cooks Spumante',5,1,0,0,0,0,2,0,10.99,12),(1604,'Harp Irish Lager',17,'083820234732',9.99,'Harp Irish Lager',6,NULL,0,0,0,0,0,0,6.67,1),(1605,'Guinness Kaliber',12,'083820725520',1.99,'Guinness Kaliber',6,1,0,0,0,0,0,0,1.99,1),(1606,'Guinness Kaliber 6 Pack',12,'083820725537',8.99,'Guinness Kaliber 6 Pack',6,6,0,0,0,0,0,0,8.99,1),(1607,'Castle Rock Zinfandel',12,'083837006308',11.99,'Castle Rock Zinfandel',5,1,0,0,0,0,2,0,11.99,12),(1608,'Hinman Sweet Rose',12,'084002000121',9.99,'Hinman Sweet Rose',5,1,0,0,0,0,2,0,9.99,12),(1609,'Wine Saver Gift Set',12,'084256098813',19.99,'Wine Saver Gift Set',1,NULL,0,0,0,0,0,0,19.99,1),(1610,'Kinky Aloha Vodka 50ml',12,'084279002118',1.75,'Kinky Aloha Vodka 50ml',7,NULL,0,0,0,0,0,0,1.75,1),(1611,'Trader Vics Spiced Rum 1.75 Liter',18,'084279971247',22.99,'Trader Vics Spiced Rum 1.75 Liter',7,NULL,0,0,0,0,0,0,16,1),(1612,'Risata Moscato d\'Asti',19,'084279977638',17.99,'Risata Moscato d\'Asti',5,1,0,0,0,0,2,0,12.75,12),(1613,'084279985978',18,'084279985978',1.99,'Kinky Pink Vodka 50ml',7,0,0,0,1,0,0,0,1,1),(1614,'Rondiaz Spicke Black Cherry Rum 50ml',12,'084279993553',1.85,'Rondiaz Spicke Black Cherry Rum 50ml',7,NULL,0,0,0,0,0,0,1.85,1),(1615,'Kinky Green Vodka 50ml',12,'084279996684',1.85,'Kinky Green Vodka 50ml',7,NULL,0,0,0,0,0,0,1.85,1),(1616,'Pennsylvania Dutch Eggnog',12,'084380360947',12.99,'Pennsylvania Dutch Eggnog',7,1,0,0,0,0,0,0,12.99,1),(1617,'Pennsylvania Dutch 200 mL',12,'084380360961',4.99,'Pennsylvania Dutch 200 mL',7,1,0,0,0,0,0,0,4.99,1),(1618,'Kikkoman Plum Wine California',11,'084391123999',13.99,'Kikkoman Plum',5,1,0,0,0,0,2,0,8.25,12),(1619,'Singha 6 Pack',12,'084543800075',13.99,'Singha 6 Pack',6,6,0,0,0,0,0,0,13.99,1),(1620,'Croft Port 2009',12,'084692000234',39.99,'Croft Port 2009',5,1,0,0,0,0,2,0,29.99,12),(1621,'Louis Jadot Pouilly-Fuisse',10,'084692424542',33.99,'Louis Jadot Pouilly-Fuisse',5,1,0,0,0,0,2,0,24.3,12),(1622,'Michele Chiarlo',12,'084692441341',15.99,'Michele Chiarlo',5,1,0,0,0,0,2,0,15.99,12),(1623,'Louis Jadot Pinot Noir',12,'084692458745',20.99,'Louis Jadot Pinot Noir',5,1,0,0,0,0,2,0,20.99,12),(1624,'Brunello Di Montalcino',12,'084692483907',49.99,'Brunello Di Montalcino',5,1,0,0,0,0,2,0,49.99,12),(1625,'Taitinger Champagne Brut',12,'084692501649',62.99,'Taitinger Champagne Brut',5,1,0,0,0,0,2,0,62.99,12),(1626,'Korbel Brandy',12,'084704000078',14.99,'Korbel Brandy',7,1,0,0,0,0,0,0,14.99,1),(1627,'E&J VSOP Brandy 50ml',12,'085000003862',1.99,'E&J VSOP Brandy 50ml',7,NULL,0,0,0,0,0,0,1.99,1),(1628,'Bridlewood Chardonnay',12,'085000016473',14.99,'Bridlewood Chardonnay',5,1,0,0,0,0,2,0,14.99,12),(1629,'Sutter Home Merlot 187ml',12,'08500229',2.79,'Sutter Home Merlot 187ml',5,1,0,0,0,0,2,0,2.79,12),(1630,'Chandon Brut 187ml',12,'085155001010',6.99,'Chandon Brut 187ml',5,1,0,0,0,0,2,0,6.99,12),(1631,'Ketel One Vodka 50ml',12,'085156404957',2.99,'Ketel One Vodka 50ml',7,NULL,0,0,0,0,0,0,2.99,1),(1632,'Ketel One Vodka 1 L',12,'085156610419',35.65,'Ketel One Vodka 1 L',7,1,0,0,0,0,0,0,35.65,1),(1633,'Diet Tonic',21,'085239014790',2.99,'Diet Tonic',2,NULL,0,0,0,0,0,0,2,1),(1634,'Maker\'s Mark Whisky 1 L',12,'085246139424',47.28,'Maker\'s Mark Whisky 1 L',7,1,0,0,0,0,0,0,47.28,1),(1635,'Red Shank Irish Whiskey',12,'085254900351',34.99,'Red Shank Irish Whiskey',7,1,0,0,0,0,0,0,34.99,1),(1636,'Red Shank Irish Whiskey',10,'085254901198',30.99,'Red Shank Irish Whiskey',7,NULL,0,0,0,0,0,0,22.09,1),(1637,'Zing 72 Botanical Gin Gift Box',12,'085316860104',29.99,'Zing 72 Botanical Gin Gift Box',7,1,0,0,0,0,0,0,29.99,1),(1638,'Travel Bottle',12,'085455216305',3.99,'Travel Bottle',1,NULL,0,0,0,0,0,0,3.99,1),(1639,'New Amsterdam Red Berry',18,'08557500',0,'New Amsterdam Red Berry',7,NULL,0,0,0,0,0,0,0.89,1),(1640,'Tequila Rose Strawberry Cream',12,'085592121036',24.99,'Tequila Rose Strawberry Cream',7,1,0,0,0,0,0,0,24.99,1),(1641,'Tequila Rose Strawberry Cream 50ml',12,'085592121081',1.85,'Tequila Rose Strawberry Cream 50ml',7,NULL,0,0,0,0,0,0,1.85,1),(1642,'360 Double Chocolate vodka',18,'085592138553',16.99,'360 Double Chocolate vodka',7,1,0,0,0,0,0,0,11.5,1),(1643,'New Amserdam Mango Vodka 50ml',18,'08563404',1.95,'New Amserdam Mango Vodka 50ml',7,NULL,0,0,0,0,0,0,1.2,1),(1644,'Framboise Lambic',12,'085725108149',11.99,'Framboise Lambic',6,1,0,0,0,0,0,0,11.99,1),(1645,'Lindeman\'s Framboise',12,'085725108408',3.99,'Lindeman\'s Framboise',5,1,0,0,0,0,2,0,3.99,12),(1646,'Ayinger Oktober Fest',12,'085725122138',0,'Ayinger Oktober Fest',6,1,0,0,0,0,0,0,0,1),(1647,'Ayinger Oktober Fest 4 Pack',12,'085725422139',12.99,'Ayinger Oktober Fest 4 Pack',6,4,0,0,0,0,0,0,12.99,1),(1648,'Glow Squigglets',12,'085761196018',2.69,'Glow Squigglets',1,NULL,0,0,0,0,0,0,2.69,1),(1649,'Arbor crest Cliff house commemorative edition',12,'085817310139',13.99,'Arbor crest Cliff house commemorative edition',5,1,0,0,0,0,2,0,13.99,12),(1650,'Kung Fu Girl Riesling',19,'086003253001',14.99,'Kung Fu Girl Riesling',5,1,0,0,0,0,2,0,10.5,12),(1651,'Saldo',12,'086003258006',30.99,'Saldo',5,1,0,0,0,0,2,0,30.99,12),(1652,'Robert Mondavi Chardonney',12,'086003780248',0,'Robert Mondavi Chardonney',5,1,0,0,0,0,2,0,0,12),(1653,'7 Siete Leguas Tequila',12,'086024001919',69.99,'7 Siete Leguas Tequila',7,NULL,0,0,0,0,0,0,69.99,1),(1654,'Christian Brothers VS Brandy 50ml',12,'086036100198',1.99,'Christian Brothers VS Brandy 50ml',7,NULL,0,0,0,0,0,0,1.99,1),(1655,'Christian Brothers Meloso Cream Sherry',12,'086036186598',15.99,'Christian Brothers Meloso Cream Sherry',5,1,0,0,0,0,2,0,15.99,12),(1656,'Christian Brothers Brandy 1 L',18,'086036815559',16.99,'Christian Brothers Brandy 1 L',7,1,0,0,0,0,0,0,11.67,1),(1657,'Wall Art',12,'086131321085',3.99,'Wall Art',1,NULL,0,0,0,0,0,0,3.99,1),(1658,'Bailey\'s Irish Cream',18,'086767210043',43.99,'Bailey\'s Irish Cream',7,1,0,0,0,0,0,0,31.99,1),(1659,'Bailey\'s 50ml',12,'086767210128',3.75,'Bailey\'s 50ml',7,NULL,0,0,0,0,0,0,3.75,1),(1660,'Goldschlager',12,'086767500069',28.3,'Goldschlager',7,1,0,0,0,0,0,0,28.3,1),(1661,'Baileys Pumpkim Spice',12,'086767704665',26.99,'Baileys Pumpkim Spice',7,1,0,0,0,0,0,0,26.99,1),(1662,'Rocca delle 1macie 2015',10,'086785120331',26.99,'Rocca delle 1macie 2015',5,1,0,0,0,0,2,0,21,12),(1663,'Giulio Straccali Chianti',13,'086785130071',11.99,'Giulio Straccali',5,1,0,0,0,0,2,0,11.36667,12),(1664,'Straccali Chianti 1.5Liter Italy',10,'086785130095',19.99,'Straccali Chianti 1.5Liter Italy',5,1,0,0,0,0,2,0,12,12),(1665,'Rocca Delle Macie Moonlight',13,'086785141879',9.99,'Rocca Delle macie Moonlight',5,1,0,0,0,0,2,0,5,12),(1666,'Peter Yealands Sauvignon Blanc',12,'086785170008',16.99,'Peter Yealands Sauvignon Blanc',5,1,0,0,0,0,2,0,16.99,12),(1667,'Paul Mas Picpoul Du Pinet',12,'086785192185',13.99,'Paul Mas Picpoul Du Pinet',5,1,0,0,0,0,2,0,13.99,12),(1668,'Artesis Cote du Rhone',12,'086785246819',15.99,'Artesis Cote du Rhone',5,1,0,0,0,0,2,0,15.99,12),(1669,'Artesis Cote du Rhone 2016',12,'086785246871',16.99,'Artesis Cote du Rhone 2016',5,1,0,0,0,0,2,0,16.99,12),(1670,'Planteta La Segreta',12,'086785250007',5.99,'Planteta La Segreta',5,1,0,0,0,0,2,0,5.99,12),(1671,'Jean-Luc Colombo Rose',12,'086785350530',4.99,'Jean-Luc Colombo Rose',5,1,0,0,0,0,2,0,8,12),(1672,'120 Reserva Especial Pinot Noir',12,'086785470801',10.99,'120 Reserva Especial Pinot Noir',5,1,0,0,0,0,2,0,10.99,12),(1673,'Chic Barelona',12,'086785638102',4.99,'Chic Barelona',5,1,0,0,0,0,2,0,4.99,12),(1674,'Cinzano Rosso',12,'086785900179',13.99,'Cinzano Rosso',7,1,0,0,0,0,0,0,13.99,1),(1675,'Cinzano Extra Dry',13,'086785900209',14.99,'Cinzano Extra Dry',7,1,0,0,0,0,0,0,10.99,1),(1676,'Hahn GSM Central Coast 2017',13,'086788000470',14.99,'Hahn GSM Central Coast 2017',5,1,0,0,0,0,2,0,10.5,12),(1677,'Smith & Hook',13,'086788000906',22.99,'Smith & Hook',5,1,0,0,0,0,2,0,16,12),(1678,'Hahn Pinot Noir',13,'086788888023',14.99,'Hahn Pinot Noir',5,1,0,0,0,0,2,0,11,12),(1679,'Paramount Creme de Cacao',18,'086816100943',13.99,'Paramount Creme de Cacao',7,1,0,0,0,0,0,0,8,1),(1680,'Paramount Peach Schnapps 1 L',12,'086816106532',13.99,'Paramount Peach Schnapps 1 L',7,1,0,0,0,0,0,0,13.99,1),(1681,'Paramount Blackberry Flavored Brandy 1 L',12,'086816108734',14.99,'Paramount Blackberry Flavored Brandy 1 L',7,1,0,0,0,0,0,0,14.99,1),(1682,'Paramount Cherry Flavored Brandy',18,'086816109144',12.99,'Paramount Cherry Flavored Brandy',7,1,0,0,0,0,0,0,8.75,1),(1683,'Paramount Light Rum 1L',12,'086816124536',11.99,'Paramount Light Rum 1L',7,1,0,0,0,0,0,0,11.99,1),(1684,'Paramount Amaretto 1 L',12,'086816600931',13.99,'Paramount Amaretto 1 L',7,1,0,0,0,0,0,0,13.99,1),(1685,'Jimmy\'s Dill Vegetable Dip',12,'086824312802',7.99,'Jimmy\'s Dill Vegetable Dip',4,NULL,1,0,0,0,0,0,7.99,1),(1686,'Grace lane Riesling',12,'086891081564',10.99,'Grace lane Riesling',5,1,0,0,0,0,2,0,10.99,12),(1687,'Captain Morgan 1 Liter',18,'087000002708',25.99,'Captain Morgan 1 Liter',7,NULL,0,0,0,0,0,0,18.63,1),(1688,'Bulleit Bourbon 1L',18,'087000005549',43.99,'Bulleit Bourbon 1L',7,NULL,0,0,0,0,0,0,31.25,1),(1689,'Crown Royal 1 L',18,'087000007246',39.99,'Crown Royal 1 L',7,1,0,0,0,0,0,0,28.84,1),(1690,'Seagram\'s 7 1L',18,'087000007321',17.99,'Seagram\'s 7 1L',7,1,0,0,0,0,0,0,17.99,1),(1691,'Captian Morgan Mini 10x12',10,'087000506336',17.5,'Captian Morgan Mini 10x12',7,NULL,0,0,0,0,0,0,17.5,1),(1692,'Seagram\'s 7 Whiskey 1.75 L',12,'087000700703',27.76,'Seagram\'s 7 Whiskey 1.75 L',7,1,0,0,0,0,0,0,27.76,1),(1693,'UV Ruby Red Vodka 50ml',12,'087116000445',1.99,'UV Ruby Red Vodka 50ml',7,NULL,0,0,0,0,0,0,1.99,1),(1694,'Revel Stoke',12,'087116001732',1.99,'Revel Stoke',7,NULL,0,0,0,0,0,0,1.99,1),(1695,'UV Apple Vodka',12,'087116014428',14.99,'UV Apple Vodka',7,1,0,0,0,0,0,0,14.99,1),(1696,'UV Cherry Vodka 1 L',12,'087116014435',16.75,'UV Cherry Vodka 1 L',7,1,0,0,0,0,0,0,16.75,1),(1697,'UV Blue Vodka 1.75 L',12,'087116014527',24.09,'UV Blue Vodka 1.75 L',7,1,0,0,0,0,0,0,24.09,1),(1698,'UV Cake Vodka 50ml',18,'087116015470',1.99,'UV Cake Vodka 50ml',7,NULL,0,0,0,0,0,0,0.95,1),(1699,'Phillips Rootbeer Schnapps 1 L',12,'087116034617',15.99,'Phillips Rootbeer Schnapps 1 L',7,1,0,0,0,0,0,0,15.99,1),(1700,'Crown Royal Canadian Whiskey 50ml',18,'08719902',3.5,'Crown Royal Canadian Whiskey 50ml',7,NULL,0,0,0,0,0,0,1.92,1),(1701,'Porto Tellu\'s Ruby',12,'087202008058',15.99,'Porto Tellu\'s Ruby',5,1,0,0,0,0,2,0,15.99,12),(1702,'Tellus Port',12,'087202008065',15.99,'Tellus Port',5,1,0,0,0,0,2,0,13,12),(1703,'Metaxa Ouzo',18,'087236210359',23.99,'Metaxa Ouzo',7,1,0,0,0,0,0,0,15.74,1),(1704,'Cointreau Liqueur',12,'087236565107',45.5,'Cointreau Liqueur',7,1,0,0,0,0,0,0,45.5,1),(1705,'Mezzacorona Pinot Grigio',13,'087241881063',11.99,'Mezzacorona Pinot Grigio',5,1,0,0,0,0,2,0,8.25,12),(1706,'Captain Morgan Spiced Rum 50ml',12,'08731409',1.85,'Captain Morgan Spiced Rum 50ml',7,NULL,0,0,0,0,0,0,1.5,1),(1707,'Mini Seagrams 7 50ml',10,'08732602',1.89,'Mini Seagrams 7 50ml',7,NULL,0,0,0,0,0,0,1.25,1),(1708,'Truly Berry Mix Pack',12,'087692006862',19.99,'Truly Berry Mix Pack',6,12,0,0,0,0,0,0,19.99,1),(1709,'Sam Adams',12,'087692100126',10.99,'Sam Adams',6,NULL,0,0,0,0,0,0,8,1),(1710,'Hogue Late Harvest Riesling',21,'087754000159',12.99,'Hogue Late Harvest Riesling',5,1,0,0,0,0,2,0,9,12),(1711,'Seagram\'s 7 Whiskey 375ml',1,'08776509',7.99,'Seagram\'s 7 Whiskey 375ml',7,NULL,0,0,0,0,0,0,5,1),(1712,'Maddalena',12,'087872057097',13.99,'Maddalena',5,1,0,0,0,0,2,0,13.99,12),(1713,'Stella Rossa Rosso',22,'087872630139',14.99,'Stella Rossa Rosso',5,1,0,0,0,0,2,0,14.99,12),(1714,'Stella Rosa Black 250ml',12,'087872633116',5.75,'Stella Rosa Black 250ml',5,1,0,0,0,0,2,0,5.75,12),(1715,'Stella Rosa Platinum 250 ml',12,'087872633147',5.75,'Stella Rosa Platinum 250 ml',5,1,0,0,0,0,2,0,5.75,12),(1716,'Blue Moon 12oz Bottle',17,'08787337',2.99,'Blue Moon 12oz Bottle',6,NULL,0,0,0,0,0,0,1.45,1),(1717,'EH Taylor Single Barrel',18,'088004005511',79.99,'Taylor Bourbon',7,1,0,0,0,0,0,0,50.75,1),(1718,'Dr. McGillicuddy\'s Wild Grape',12,'088004009557',18.99,'Dr. McGillicuddy\'s Wild Grape',7,1,0,0,0,0,0,0,18.99,1),(1719,'Dr. McGillicuddy\'s Apple Pie 50ml',12,'088004009755',1.99,'Dr. McGillicuddy\'s Apple Pie 50ml',7,NULL,0,0,0,0,0,0,1.99,1),(1720,'Dr. McGillicuddy\'s Peach 50ml',12,'088004009793',1.99,'Dr. McGillicuddy\'s Peach 50ml',7,NULL,0,0,0,0,0,0,1.99,1),(1721,'Tortilla Silver Tequila',10,'088004015114',11.99,'Tortilla Silver Tequila',7,NULL,0,0,0,0,0,0,8.75,1),(1722,'Benchmark Egg Nog',18,'088004015695',9.99,'Benchmark Egg Nog',7,1,0,0,0,0,0,0,6.5,1),(1723,'Tijuana Sweet Heat 50ml',12,'088004020972',1.99,'Tijuana Sweet Heat 50ml',7,NULL,0,0,0,0,0,0,1.99,1),(1724,'Tuaca Brandy',18,'088004025984',24.99,'Tuaca Brandy',7,1,0,0,0,0,0,0,17.66,1),(1725,'Dr. McGillicuddy\'s Raw Vanilla 1 L',12,'088004144630',24.1,'Dr. McGillicuddy\'s Raw Vanilla 1 L',7,1,0,0,0,0,0,0,24.1,1),(1726,'Fireball Cinnamon Whiskey 1L',12,'088004144678',24.81,'Fireball Cinnamon Whiskey 1L',7,1,0,0,0,0,0,0,24.81,1),(1727,'FireBall 50 ml',10,'088004144708',1.85,'FireBall 50 ml',7,NULL,0,0,0,0,0,0,1.4,1),(1728,'Fireball  200ml',12,'088004144739',6.99,'Fireball 200ml',7,NULL,0,0,0,0,0,0,4,1),(1729,'Cherry McGillicuddy\'s 1L',12,'088004148218',24.1,'Cherry McGillicuddy\'s 1L',5,1,0,0,0,0,2,0,24.1,12),(1730,'Dr. McGillicuddy\'s Cherry 50ml',12,'088004148263',1.99,'Dr. McGillicuddy\'s Cherry 50ml',7,NULL,0,0,0,0,0,0,1.99,1),(1731,'Dickel Tennessee Sour Mash Whisky',18,'088076006232',29.35,'Dickel Tennessee Sour Mash Whisky',7,1,0,0,0,0,0,0,29.35,1),(1732,'Ciro Vodka',12,'088076161863',38.99,'Ciro Vodka',7,1,0,0,0,0,0,0,38.99,1),(1733,'Bailey\'s Minis 100ml 3-pack',18,'088076182448',10.99,'Bailey\'s Minis 100ml 3-pack',7,NULL,0,0,0,0,0,0,7.83,1),(1734,'Johnnie Walker White Walker Scotch',12,'088076182783',48.99,'Johnnie Walker White Walker Scotch',7,1,0,0,0,0,0,0,48.99,1),(1735,'Johnnie Walker A Song of Fire Scotch',10,'088076184114',47.99,'Johnnie Walker A Song of Fire Scotch',7,NULL,0,0,0,0,0,0,34.25,1),(1736,'Black Velvet 1.75 L',18,'088100134511',22.95,'Black Velvet 1.75 L',7,1,0,0,0,0,0,0,15.68,1),(1737,'Black Velvet 1 L',12,'088100134535',15.4,'Black Velvet 1 L',7,1,0,0,0,0,0,0,15.4,1),(1738,'Black Velvet 375 mL',10,'088100134573',7.99,'Black Velvet 375 mL',7,1,0,0,0,0,0,0,7.99,1),(1739,'Mini Black Velvet 50ml',10,'088100134597',1.85,'Mini Black Velvet 50ml',7,NULL,0,0,0,0,0,0,1.4,1),(1740,'Black Velvet Toasted Carmel',18,'088100134856',14.99,'Black Velvet Toasted Carmel',7,1,0,0,0,0,0,0,10.13,1),(1741,'Dalwhinnie 15 Year Scotch',18,'088110100056',85.99,'Dalwhinnie 15 Year Scotch',7,NULL,0,0,0,0,0,0,60.5,1),(1742,'Tanqueray Gin 1 L',12,'088110110406',33.55,'Tanqueray Gin 1 L',7,1,0,0,0,0,0,0,33.55,1),(1743,'Lagavulin 16 year Scotch',10,'088110140052',99.99,'Lagavulin 16 year Scotch',7,1,0,0,0,0,0,0,76.74,1),(1744,'Oban 14 Single Malt Whisky',18,'088110160050',83.99,'Oban 14 Single Malt Whisky',7,NULL,0,0,0,0,0,0,60,1),(1745,'Mini Moet 187ml',12,'088110551025',11.99,'Mini Moet 187ml',5,1,0,0,0,0,2,0,11.99,12),(1746,'Sebastiani Cabernet Sauvignon',13,'088232002610',18.99,'Sebastiani Cabernet Sauvignon',5,1,0,0,0,0,2,0,13.5,12),(1747,'Sabastini Merlot',12,'088232002634',18.99,'Sabastini Merlot',5,1,0,0,0,0,2,0,18.99,12),(1748,'Juarez Gold Tequila',10,'088352100272',17.99,'Juarez Gold Tequila',7,NULL,0,0,0,0,0,0,12.75,1),(1749,'Extra Brooks Bourbon 50ml',12,'088352115368',1.85,'Extra Brooks Bourbon 50ml',7,NULL,0,0,0,0,0,0,1.85,1),(1750,'Old Medley Bourbon Whiskey 12 Year',12,'088352116907',68.99,'Old Medley Bourbon Whiskey 12 Year',7,NULL,0,0,0,0,0,0,68.99,1),(1751,'Arrow Peppermint Schnapps 50ml',12,'088352117539',1.85,'Arrow Peppermint Schnapps 50ml',7,NULL,0,0,0,0,0,0,1.85,1),(1752,'Arrow Peppermint Schnapps 1 L',12,'088352118482',14.99,'Arrow Peppermint Schnapps 1 L',7,1,0,0,0,0,0,0,14.99,1),(1753,'Arrow Apricot Brandy',12,'088352118604',11.29,'Arrow Apricot Brandy',7,1,0,0,0,0,0,0,11.29,1),(1754,'Arrow Sloe Gin',12,'088352118871',10.99,'Arrow Sloe Gin',7,1,0,0,0,0,0,0,10.99,1),(1755,'Everclear 151 Proof',18,'088352123097',22.99,'Everclear 151 Proof',7,1,0,0,0,0,0,0,15.99,1),(1756,'Mini Pearl Vodka',10,'088352123127',1.85,'Mini Pearl Vodka',7,NULL,0,0,0,0,0,0,1.4,1),(1757,'Pearl Vodka, Cucumber',12,'088352125275',17.99,'Pearl Vodka, Cucumber',7,1,0,0,0,0,0,0,11.5,1),(1758,'Pearl Vodka, Wedding Cake',12,'088352126975',15.99,'Pearl Vodka, Wedding Cake',7,NULL,0,0,0,0,0,0,15.99,1),(1759,'Pearl Peach Vodka',18,'088352127156',16.99,'Pearl Peach Vodka',7,1,0,0,0,0,0,0,11.5,1),(1760,'Pearl Vodka, Wedding two Pack',12,'088352127194',39.99,'Pearl Vodka, Wedding two Pack',7,1,0,0,0,0,0,0,39.99,1),(1761,'Pearl Chocolate Covered Cherry Vodka 50ml',12,'088352127941',1.75,'Pearl Chocolate Covered Cherry Vodka 50ml',7,NULL,0,0,0,0,0,0,1.75,1),(1762,'Rebel Yell Root Beer',12,'088352131498',1.99,'Rebel Yell Root Beer',7,NULL,0,0,0,0,0,0,1.99,1),(1763,'Exra Brooks Bourbon Cream 50ml',12,'088352132020',1.75,'Exra Brooks Bourbon Cream 50ml',7,NULL,0,0,0,0,0,0,1.75,1),(1764,'Southern Comfort 50ml',12,'088544000021',1.85,'Southern Comfort 50ml',7,NULL,0,0,0,0,0,0,1.5,1),(1765,'Southern Comfort 1 L',12,'088544018941',28.24,'Southern Comfort 1 L',7,1,0,0,0,0,0,0,28.24,1),(1766,'Shiner Bock 6 pack',17,'088573331011',10.99,'Shiner Bock 6 pack',6,6,0,0,0,0,0,0,8.05,1),(1767,'St James Peach',12,'088582000502',11.99,'St James Peach',5,1,0,0,0,0,2,0,11.99,12),(1768,'St James Cherry',12,'088582000519',11.99,'St James Cherry',5,1,0,0,0,0,2,0,11.99,12),(1769,'St James Strawberry',13,'088582000526',11.99,'St James Strawberry',5,1,0,0,0,0,2,0,7.5,12),(1770,'St.James Raspberry Wine',10,'088582000663',11.99,'St.James Raspberry Wine',5,1,0,0,0,0,2,0,7.5,12),(1771,'Two Vines Merot',12,'088586001109',10.99,'Two Vines Merot',5,1,0,0,0,0,2,0,10.99,12),(1772,'H3 Merlot',12,'088586003431',15.5,'H3 Merlot',5,1,0,0,0,0,2,0,15.5,12),(1773,'Nicolas Feuillatte Brut Reserve',12,'088586003899',39.99,'Nicolas Feuillatte Brut Reserve',5,1,0,0,0,0,2,0,39.99,12),(1774,'Columbia Crest Chardonnay',12,'088586005671',13.75,'Columbia Crest Chardonnay',5,1,0,0,0,0,2,0,13.75,12),(1775,'Motto Red Blend',12,'088586007194',14.99,'Motto Red Blend',5,1,0,0,0,0,2,0,14.99,12),(1776,'Intrinsic Cabernet Sauvignon',12,'088586007859',22,'Intrinsic Cabernet Sauvignon',5,1,0,0,0,0,2,0,22,12),(1777,'Intrinsic Wine Box Set',13,'088586010101',22.99,'Intrinsic Wine Box Set',5,1,0,0,0,0,2,0,17,12),(1778,'Chateau ste Michelle',12,'088586621840',12.5,'Chateau ste Michelle',5,1,0,0,0,0,2,0,12.5,12),(1779,'Red Wine Stain Emergency Kit',12,'088621660100',11.99,'Red Wine Stain Emergency Kit',1,NULL,0,0,0,0,0,0,11.99,1),(1780,'Cider Boys First Press',12,'088733900019',1.99,'Cider Boys First Press',6,1,0,0,0,0,0,0,1.99,1),(1781,'Cider Boys First Press',12,'088733900026',10.75,'Cider Boys First Press',6,1,0,0,0,0,0,0,10.75,1),(1782,'Cider Boys Strawberry 6 Pack',1,'088733900125',10.99,'Cider Boys Strawberry 6 Pack',6,NULL,0,0,0,0,0,0,7.75,1),(1783,'Cider boys Cranberry Road CranApple Cider',12,'088733900217',1.99,'Cider boys Cranberry Road CranApple Cider',6,1,0,0,0,0,0,0,1.99,1),(1784,'Cider Boys Raspberry Smash',1,'088733900224',10.99,'Cider Boys Tiki Colada',6,6,0,0,0,0,0,0,7.75,1),(1785,'Stone Hill Pink Catawba',12,'088790216481',7.75,'Stone Hill Pink Catawba',5,1,0,0,0,0,2,0,7.75,12),(1786,'Stone Hill Concord',12,'088790217495',7.99,'Stone Hill Concord',5,1,0,0,0,0,2,0,7.99,12),(1787,'Mr. Boston Rock & Rye',12,'089000013586',10.99,'Mr. Boston Rock & Rye',7,1,0,0,0,0,0,0,10.99,1),(1788,'Chi-chi\'s Margarita 1.75 L',18,'089000018758',15.99,'Chi-chi\'s Margarita 1.75 L',7,1,0,0,0,0,0,0,15.99,1),(1789,'Chi-Chi\'s Strawberry Margarita 1.75 Liter',18,'089000019182',15.99,'Chi-chi\'s Strawberry Margarita',7,1,0,0,0,0,0,0,10.5,1),(1790,'Chi-chi\'s Pina Colada',18,'089000500307',15.99,'Chi-chi\'s Pina Colada',7,1,0,0,0,0,0,0,10.75,1),(1791,'Clear Spring grain Alcohol 190 Proof',12,'089000604548',21.99,'Clear Spring grain Alcohol 190 Proof',7,1,0,0,0,0,0,0,21.99,1),(1792,'Sobieski Vodka 1.75 L',12,'089016008491',24.09,'Sobieski Vodka 1.75 L',7,1,0,0,0,0,0,0,24.09,1),(1793,'Uncle Bob\'s Root beer Whiskey',12,'089105870022',1.75,'Uncle Bob\'s Root beer Whiskey',7,NULL,0,0,0,0,0,0,1.75,1),(1794,'Cypress Chardonnay',12,'089121058527',9.5,'Cypress Chardonnay',5,1,0,0,0,0,2,0,9.5,12),(1795,'Ariel nCabernet Dealcoholized',10,'089121850022',11.99,'Ariel nCabernet Dealcoholized',5,1,0,0,0,0,2,0,8,12),(1796,'Santa Barbara SUn Dried Tomato Stuffed Olives',16,'089156801808',6.99,'Santa Barbara SUn Dried Tomato Stuffed Olives',4,NULL,1,0,0,0,0,0,3.53,1),(1797,'Santa Barbara Maraschino Cherries',12,'089156801914',1.99,'Santa Barbara Maraschino Cherries',4,NULL,1,0,0,0,0,0,1.99,1),(1798,'Yalumba viognier',12,'089208400089',12.99,'Yalumba viognier',5,1,0,0,0,0,2,0,12.99,12),(1799,'Warren\'s Otima 20 year Tawny Porto',12,'089419003178',52,'Warren\'s Otima 20 year Tawny Porto',5,1,0,0,0,0,2,0,52,12),(1800,'Famille Perrin Cote du Rhone',12,'089419015942',10.99,'Famille Perrin Cote du Rhone',5,1,0,0,0,0,2,0,10.99,12),(1801,'Man Vintners Chenin Blanc',13,'089419151039',12.5,'Man Vintners Chenin Blanc',5,1,0,0,0,0,2,0,8.99,12),(1802,'Chateau de Beacastel',12,'089419212150',99.99,'Chateau de Beacastel',5,1,0,0,0,0,2,0,99.99,12),(1803,'Miraval Cote de Provence',13,'089419235111',27.99,'Miraval Cote de Provence',5,1,0,0,0,0,2,0,18.99,12),(1804,'Symington Altano Douro Red Blend 2016',13,'089419315998',12.5,'Symington Altano Douro Red Blend 2016',5,1,0,0,0,0,2,0,8.25,12),(1805,'Kahlua Rum & Coffee Liqueur 1 L',12,'089540122700',32.49,'Kahlua Rum & Coffee Liqueur 1 L',7,1,0,0,0,0,0,0,32.49,1),(1806,'Kuhlua 50ml',12,'089540122748',2.5,'Kuhlua 50ml',7,NULL,0,0,0,0,0,0,2.5,1),(1807,'Beefeater Gin 1 L',12,'089540333489',31.44,'Beefeater Gin 1 L',7,1,0,0,0,0,0,0,31.44,1),(1808,'Kahlua Mudslide 1.75 L',12,'089540416373',17.79,'Kahlua Mudslide 1.75 L',7,1,0,0,0,0,0,0,17.79,1),(1809,'Malibu Coconut Rum 1 L',18,'089540448978',23.04,'Malibu Coconut Rum 1 L',7,1,0,0,0,0,0,0,23.04,1),(1810,'Malibu Rum',21,'089540453927',1.85,'Malibu Coconut Rum 50ml',7,NULL,0,0,0,0,0,0,1.25,1),(1811,'Kahlua French Vanilla',12,'089540493398',28.99,'Kahlua French Vanilla',7,1,0,0,0,0,0,0,28.99,1),(1812,'Wente Riverbank Dry Riesling',10,'089636160005',17.99,'Wente Riverbank Dry Riesling',5,1,0,0,0,0,2,0,10.5,12),(1813,'Murrieta\'s Well The Spur Red Blend',10,'089636955007',25.99,'Murrieta\'s Well The Spur Red Blend',5,1,0,0,0,0,2,0,18.66,12),(1814,'Beringer',12,'089819003358',49.99,'Beringer',5,1,0,0,0,0,2,0,49.99,12),(1815,'Beringer White Zinfandel',12,'089819006526',9.99,'Beringer White Zinfandel',5,1,0,0,0,0,2,0,9.99,12),(1816,'Colby Red Blend',13,'089819541645',13.99,'Colby Red Blend',5,1,0,0,0,0,2,0,11,12),(1817,'Beringer Red Moscato',12,'089819541874',8.99,'Beringer Red Moscato',5,1,0,0,0,0,2,0,7,12),(1818,'Beringer Knights Valley Reserve Cabernet Sauvignon',12,'089819732623',62.99,'Beringer Knights Valley Reserve Cabernet Sauvignon',5,1,0,0,0,0,2,0,62.99,12),(1819,'Beringer White Zinfandel 4 pack',12,'089819784639',8.99,'Beringer White Zinfandel 4 pack',5,4,0,0,0,0,2,0,8.99,8),(1820,'Santa Julia Reserva Malbec',12,'089832845706',14.99,'Santa Julia Reserva Malbec',5,1,0,0,0,0,2,0,14.99,12),(1821,'Bellafina Prosecco',22,'089832901129',10.99,'Bellafina Prosecco',5,1,0,0,0,0,2,0,8.5,12),(1822,'Stainless steel wine collar',12,'090782256115',2.99,'Stainless steel wine collar',1,NULL,0,0,0,0,0,0,2.99,1),(1823,'Sauce Dish, Green',12,'091758575032',3.99,'Sauce Dish, Green',1,NULL,0,0,0,0,0,0,3.99,1),(1824,'TsingTao Lager 6 Pack',12,'092000013067',10.99,'TsingTao Lager 6 Pack',6,6,0,0,0,0,0,0,10.99,1),(1825,'Kunde Cabernet',13,'093432212615',25.99,'Quark Cheese',4,NULL,1,0,0,0,0,0,15,1),(1826,'Graham\'s Tawny Porto',12,'094799010012',22.99,'Graham\'s Tawny Porto',5,1,0,0,0,0,2,0,22.99,12),(1827,'Graham\'s 6 Grapes Reserve Porto',10,'094799010043',31.15,'Graham\'s 6 Grapes Reserve Porto',5,1,0,0,0,0,2,0,22.25,12),(1828,'W&J Graham\'s Porto',12,'094799010401',22.99,'W&J Graham\'s Porto',5,1,0,0,0,0,2,0,22.99,12),(1829,'Fireside Frontenac Gris',12,'094922036292',14.5,'Fireside Frontenac Gris',5,1,0,0,0,0,2,0,14.5,12),(1830,'Dirty Blonde Chocolate Ale 4 pack',12,'094922437471',9.99,'Dirty Blonde Chocolate Ale 4 pack',6,4,0,0,0,0,0,0,9.99,1),(1831,'El Caribe white',12,'094922482150',14.75,'El Caribe white',5,1,0,0,0,0,2,0,14.75,12),(1832,'Another place in Time',12,'094922482211',13.99,'Another place in Time',5,1,0,0,0,0,2,0,13.99,12),(1833,'Van Wijk Crimson swirl',12,'094922482303',15.75,'Van Wijk Crimson swirl',5,1,0,0,0,0,2,0,15.75,12),(1834,'Fireside Blu',21,'094922893017',15.99,'Fireside Blu',5,1,0,0,0,0,2,0,11.5,12),(1835,'Blackheart Spiced Rum',10,'096749011681',17.99,'Blackheart Spiced Rum',7,NULL,0,0,0,0,0,0,12.91,1),(1836,'Evan Williams Bourbon',12,'096749021345',17.25,'Evan Williams Bourbon',7,1,0,0,0,0,0,0,17.25,1),(1837,'Evan Williams Kentucky Cider',10,'096749083763',12.99,'Evan Williams Kentucky Cider',7,NULL,0,0,0,0,0,0,8.44,1),(1838,'Admiral Nelson\'s Cherry Spiced Rum 50ml',12,'096749086375',2.49,'Admiral Nelson\'s Cherry Spiced Rum 50ml',7,NULL,0,0,0,0,0,0,2.49,1),(1839,'Roederer Estate Brut',12,'097546102008',25.99,'Roederer Estate Brut',5,1,0,0,0,0,2,0,25.99,12),(1840,'Rombauer Chardonnay',12,'097921970109',38.99,'Rombauer Chardonnay',5,1,0,0,0,0,2,0,38.99,12),(1841,'Cline Syrah',13,'098652130022',17.99,'Cline Syrah',5,1,0,0,0,0,2,0,12.75,12),(1842,'Cline Viognier',10,'098652180027',13.99,'Cline Viognier',5,1,0,0,0,0,2,0,9.24,12),(1843,'Cline Ancient Vines',10,'098652300029',15.99,'Cline Ancient Vines',5,1,0,0,0,0,2,0,12,12),(1844,'Giuseppe Cortese',12,'098709010543',29.99,'Giuseppe Cortese',5,1,0,0,0,0,2,0,29.99,12),(1845,'Ciro Rosso Classico',12,'098709252004',12.99,'Ciro Rosso Classico',5,1,0,0,0,0,2,0,12.99,12),(1846,'Librandi Ciro Bianco 2018',13,'098709252158',12.99,'Librandi Ciro Bianco 2018',5,1,0,0,0,0,2,0,8,12),(1847,'Prager Gruner Veltliner',21,'098709300132',29.99,'Prager Gruner Veltliner',5,1,0,0,0,0,2,0,29.99,12),(1848,'Zenato Pinot Grigio delle Venezie 2018',10,'098709434004',14.99,'Zenato Pinot Grigio delle Venezie 2018',5,1,0,0,0,0,2,0,10.5,12),(1849,'Tilia Malbec Mendoza Argentina',10,'098709670150',11.99,'Tilia Malbec Mendoza Argentina',5,1,0,0,0,0,2,0,10,12),(1850,'Orin Swift Fragile',12,'10000001',15,'Orin Swift Fragile',5,1,0,0,0,0,2,0,15,12),(1851,'Orin Swift Machete',12,'10000002',49.99,'Orin Swift Machete',5,1,0,0,0,0,2,0,49.99,12),(1852,'Nouveau-Nez Vigneron',12,'10000003',0,'Nouveau-Nez Vigneron',5,1,0,0,0,0,2,0,0,12),(1853,'Brady Petite Sirah',12,'10000004',23.99,'Brady Petite Sirah',5,1,0,0,0,0,2,0,23.99,12),(1854,'Josh Cabernet Sauvignon',12,'10000005',18.99,'Josh Cabernet Sauvignon',5,1,0,0,0,0,2,0,18.99,12),(1855,'Smith & Hook Cabernet Sauvignon',12,'10000006',21.99,'Smith & Hook Cabernet Sauvignon',5,1,0,0,0,0,2,0,21.99,12),(1856,'Silencieux Cabernet Sauvignon',12,'10000007',56.99,'Silencieux Cabernet Sauvignon',5,1,0,0,0,0,2,0,56.99,12),(1857,'Treana Cabernet Sauvignon',12,'10000008',27.99,'Treana Cabernet Sauvignon',5,1,0,0,0,0,2,0,27.99,12),(1858,'Brassfields Cabernet Sauvignon',12,'10000009',89.99,'Brassfields Cabernet Sauvignon',5,1,0,0,0,0,2,0,89.99,12),(1859,'Kirkwood My First Crush',12,'10000010',19.99,'Kirkwood My First Crush',5,1,0,0,0,0,2,0,19.99,12),(1860,'Kirkwood Blue Bell Sparkling Wine',12,'10000011',18.99,'Kirkwood Blue Bell Sparkling Wine',5,1,0,0,0,0,2,0,18.99,12),(1861,'Modus Toscana',12,'10000012',24.99,'Modus Toscana',5,1,0,0,0,0,2,0,24.99,12),(1862,'Butternut Chardonnay',12,'10000013',18.99,'Butternut Chardonnay',5,1,0,0,0,0,2,0,18.99,12),(1863,'Washington Hills Riesling',12,'10000014',11.99,'Washington Hills Riesling',5,1,0,0,0,0,2,0,11.99,12),(1864,'Gerard Bertrand',12,'10000015',15.99,'Gerard Bertrand',5,1,0,0,0,0,2,0,15.99,12),(1865,'Nautica Notre Dame du Quatourze',12,'10000016',16.99,'Nautica Notre Dame du Quatourze',5,1,0,0,0,0,2,0,16.99,12),(1866,'Orin Swift Shatter',12,'10000017',23.99,'Orin Swift Shatter',5,1,0,0,0,0,2,0,23.99,12),(1867,'Ringneck Red',12,'10000018',13.25,'Ringneck Red',5,1,0,0,0,0,2,0,13.25,12),(1868,'Kirkwood Masters Cuvee',12,'10000019',12.99,'Kirkwood Masters Cuvee',5,1,0,0,0,0,2,0,12.99,12),(1869,'Winneshiek Wildberry Winnery Hunga Dunga Bird',12,'10000020',11.99,'Winneshiek Wildberry Winnery Hunga Dunga Bird',5,1,0,0,0,0,2,0,11.99,12),(1870,'Cedar Ridge Port',12,'10000021',17.99,'Cedar Ridge Port',5,1,0,0,1,0,2,0,17.99,12),(1871,'Captain Morgan Spiced Rum 1 L',12,'10000022',25.68,'Captain Morgan Spiced Rum 1 L',7,1,0,0,0,0,0,0,25.68,1),(1872,'Johnnie Walker Red Label Whiskey 1 L',12,'10000023',36.91,'Johnnie Walker Red Label Whiskey 1 L',7,1,0,0,0,0,0,0,36.91,1),(1873,'Calvados Morin Apple Brandy',12,'10000024',26.99,'Calvados Morin Apple Brandy',7,1,0,0,0,0,0,0,26.99,1),(1874,'Comisario Reposado Tequila',12,'10000025',53.99,'Comisario Reposado Tequila',7,1,0,0,0,0,0,0,53.99,1),(1875,'Betterbody Agave',12,'10000026',7.99,'Betterbody Agave',4,NULL,1,0,0,0,0,0,7.99,1),(1876,'Wine collector Martini pics',12,'10000027',12.99,'Wine collector Martini pics',1,NULL,0,0,0,0,0,0,12.99,1),(1877,'Birthday candles 60',12,'10000028',2.99,'Birthday candles 60',1,NULL,0,0,0,0,0,0,2.99,1),(1878,'Velvet Glove',12,'10000029',180,'Velvet Glove',5,1,0,0,0,0,2,0,180,12),(1879,'Silver Oak Cabernet Sauvignon Alexander Valley',12,'10000030',79.99,'Silver Oak Cabernet Sauvignon Alexander Valley',5,1,0,0,0,0,2,0,79.99,12),(1880,'Silver Oak Napa Valley Cabernet Sauvignon',12,'10000031',124.99,'Silver Oak Napa Valley Cabernet Sauvignon',5,1,0,0,0,0,2,0,124.99,12),(1881,'Venge Bone Ash Napa Cabernet Sauvignon',12,'10000032',115,'Venge Bone Ash Napa Cabernet Sauvignon',5,1,0,0,0,0,2,0,115,12),(1882,'Bien Nacido Syrah',12,'10000033',49.99,'Bien Nacido Syrah',5,1,0,0,0,0,2,0,49.99,12),(1883,'Cakebread Cellars Napa Valley Chardonnay',12,'10000034',49.99,'Cakebread Cellars Napa Valley Chardonnay',5,1,0,0,0,0,2,0,49.99,12),(1884,'Pahlmeyer Napa Chardonnay',12,'10000035',72.99,'Pahlmeyer Napa Chardonnay',5,1,0,0,0,0,2,0,72.99,12),(1885,'BigMoutch xl Wine Glass 750 mL',12,'10000036',19.99,'BigMoutch xl Wine Glass 750 mL',1,NULL,0,0,0,0,0,0,19.99,1),(1886,'Vollereaux Champagne Brut 375 mL',12,'10000037',19.99,'Vollereaux Champagne Brut 375 mL',5,1,0,0,0,0,2,0,19.99,12),(1887,'Cheese House',12,'11',8.49,'Cheese House',9,NULL,0,0,0,0,0,0,NULL,1),(1888,'Johnnie Walker Blue Label Whiskey',12,'1110470877008',174,'Johnnie Walker Blue Label Whiskey',7,1,0,0,0,0,0,0,174,1),(1890,'Pepsi 2 L',12,'1223004',2.69,'Pepsi 2 L',15,1,0,0,0,0,0,0,2.69,1),(1891,'Diet Pepsi 2 L',12,'1223101',2.69,'Diet Pepsi 2 L',15,1,0,0,0,0,0,0,2.69,1),(1892,'La Romantica Permonte Branchetto',12,'130227059823',13.99,'La Romantica Permonte Branchetto',5,1,0,0,0,0,2,0,13.99,12),(1893,'Hogue Riesling',12,'14173783',0,'Hogue Riesling',5,1,0,0,0,0,2,0,0,12),(1894,'Rose\'s Sweetened Lime Juice 12 oz',12,'1660433',4.99,'Rose\'s Sweetened Lime Juice 12 oz',4,NULL,1,0,0,0,0,0,4.99,1),(1895,'Choya Plum Wine',10,'1682114024',15.99,'Choya Plum Wine',5,1,0,0,0,0,2,0,12,12),(1896,'Dr. McGillicuddy\'s Cherry 1 L',12,'1744148218',24.1,'Dr. McGillicuddy\'s Cherry 1 L',7,1,0,0,0,0,0,0,24.1,1),(1897,'Fabulous Flask 147ml',12,'179943622041',4.99,'Fabulous Flask 147ml',1,NULL,0,0,0,0,0,0,4.99,1),(1898,'Bottle stopper',12,'179943622058',6.99,'Bottle stopper',1,NULL,0,0,0,0,0,0,6.99,1),(1899,'Chelada 6 pack',12,'1823024',12.99,'Chelada 6 pack',6,6,0,0,0,0,0,0,12.99,1),(1900,'Tabor Home Barn Dance Red',21,'182976000076',11,'Tabor Home Barn Dance Red',5,1,0,0,0,0,2,0,NULL,12),(1901,'Tabor Hone Cheery cherry',12,'182976000151',12.99,'Tabor Hone Cheery cherry',5,1,0,0,0,0,2,0,NULL,12),(1902,'Tabor Home Cranberry Whistle',21,'182976000168',12.99,'Tabor Home Cranberry Whistle',5,1,0,0,0,0,2,0,10,12),(1903,'Shueyville\'s Reserve',21,'182976000205',10,'Shueyville\'s Reserve',5,1,0,0,0,0,2,0,NULL,12),(1904,'Dr. Losen Reisling',13,'183103000013',15.5,'Dr. Losen Reisling',5,1,0,0,0,0,2,0,10.5,12),(1905,'Clayhouse Adobe Red Blend 2014',13,'183276000612',14.99,'Clayhouse Adobe Red Blend 2014',5,1,0,0,0,0,2,0,9,12),(1906,'Kungfu Girl Riesling',12,'184745000041',13.99,'Kungfu Girl Riesling',5,1,0,0,0,0,2,0,13.99,12),(1907,'Machete Red Wine Orin Swift',19,'185094400001',51.99,'Machete Red Wine Orin Swift',5,1,0,0,0,0,2,0,37.75,12),(1908,'Land Shark Lager',12,'1877928',1.99,'Land Shark Lager',6,1,0,0,0,0,0,0,1.99,1),(1909,'Chelada 16oz 4 pack',12,'1886625',12.99,'Chelada 16oz 4 pack',6,4,0,0,0,0,0,0,12.99,1),(1910,'Cachette',12,'189113000616',4.99,'Cachette',5,1,0,0,0,0,2,0,6,12),(1911,'1921 Tequila',12,'1921 TEQUILA',49.99,'1921 Tequila',9,NULL,0,0,0,0,0,0,NULL,1),(1912,'Crofton Wine Cooling Stick',3,'20038892',14.99,'Crofton Wine Cooling Stick',1,NULL,0,0,0,0,0,0,10,1),(1913,'Cheese Knive Set, Black',12,'20061104',9.99,'Cheese Knive Set, Black',1,NULL,0,0,0,0,0,0,9.99,1),(1914,'Cheese knife Set, Metal',12,'20061111',9.99,'Cheese knife Set, Metal',1,NULL,0,0,0,0,0,0,9.99,1),(1915,'BackPocket Slingshot',1,'2131004040',9.99,'BackPocket Slingshot',6,NULL,0,0,0,0,0,0,7.5,1),(1916,'Dogfish Head 60 Minute IPA 6 pack',12,'220222617040',12.99,'Dogfish Head 60 Minute IPA 6 pack',6,6,0,0,0,0,0,0,12.99,1),(1917,'Olives',12,'222',9.99,'Olives',9,NULL,0,0,0,0,0,0,NULL,1),(1918,'Grey Goose Vodka 1 L',12,'22548887',48.25,'Grey Goose Vodka 1 L',7,1,0,0,0,0,0,0,48.25,1),(1919,'Redd\'s Apple Ale',12,'3477113',10.99,'Redd\'s Apple Ale',6,6,0,0,0,0,0,0,10.99,1),(1920,'Leinenkugel\'s Summer Shandy',12,'3477414',1.99,'Leinenkugel\'s Summer Shandy',6,1,0,0,0,0,0,0,1.99,1),(1921,'Saint Cosme Cotes Du Rhone Red',14,'3483812150007',16.75,'Description to show on screen and receipt',5,1,0,0,0,0,2,0,16.75,12),(1922,'Saint Cosme',12,'3483812150106',16.75,'Saint Cosme',5,1,0,0,0,0,2,0,16.75,12),(1923,'Saint Come Chateauneuf-Du-Pape 2016',14,'3483814000003',63,'Saint Come Chateauneuf-Du-Pape 2016',5,1,0,0,0,0,2,0,45,12),(1924,'Beaucharme Chardonnay',12,'3485851511115',19.99,'Beaucharme Chardonnay',5,1,0,0,0,0,2,0,19.99,12),(1925,'Bastide Miraflores Syrah & Genache',22,'3760031472913',16.99,'Bastide Miraflores Syrah & Genache',5,1,0,0,0,0,2,0,10.5,12),(1926,'Famaey Malbec',6,'3760078860018',15.99,'Famaey Malbec',5,1,0,0,0,0,2,0,10.99,12),(1927,'Domaine LA Barroche chateauneuf-du-pape',12,'3760158260028',56.99,'Domaine LA Barroche chateauneuf-du-pape',5,1,0,0,0,0,2,0,56.99,12),(1928,'Laurent Perrachon Beaujolais Villages',6,'3760174754532',14.99,'Laurent Perrachon Beaujolais Villages',5,1,0,0,0,0,2,0,9.5,12),(1929,'Gevrey-Chambertin Petit Chapelle 1er Cru',6,'3760200090818',149.99,'Gevrey-Chambertin Petit Chapelle 1er Cru',5,1,0,0,0,0,2,0,99.99,12),(1930,'Gracevina Dry White',12,'3850112163219',11.99,'Gracevina Dry White',5,1,0,0,0,0,2,0,11.99,12),(1931,'4 Alarm Cheddar',21,'4 ALARM CHEDDAR',6.99,'4 Alarm Cheddar',9,NULL,0,0,0,0,0,0,NULL,1),(1933,'Weinflaschenverdchluss',12,'4000530485960',9.99,'Weinflaschenverdchluss',1,NULL,0,0,0,0,0,0,9.99,1),(1934,'Picture, B&W Photo',12,'400100102619',5.99,'Picture, B&W Photo',1,NULL,0,0,0,0,0,0,5.99,1),(1935,'Picture, B&W Photo',12,'400100102633',5.99,'Picture, B&W Photo',1,NULL,0,0,0,0,0,0,5.99,1),(1936,'Kitchen Towel',12,'400874558711',6.99,'Kitchen Towel',1,NULL,0,0,0,0,0,0,6.99,1),(1937,'Kitchen Towel',12,'400874561384',6.99,'Kitchen Towel',1,NULL,0,0,0,0,0,0,6.99,1),(1938,'Napa Valley Grape seed oil',12,'405000009662',13.99,'Napa Valley Grape seed oil',4,NULL,1,0,0,0,0,0,13.99,1),(1939,'Schwarzhow',12,'405580018399',20.99,'Schwarzhow',7,NULL,0,0,0,0,0,0,20.99,1),(1940,'Sweet English Cheddar HF',3,'4099100000061',7.99,'Sweet English Cheddar HF',4,NULL,1,0,0,0,0,0,3.99,1),(1941,'HF Mango Ginger Stilton',3,'4099100000078',7.99,'HF Mango Ginger Stilton',4,NULL,1,0,0,0,0,0,3.99,1),(1942,'Scalloped Crackers Sea Salt',12,'4099100000726',3.99,'Scalloped Crackers Sea Salt',4,NULL,1,0,0,0,0,0,3.99,1),(1943,'Cheddar Truffle Cheese',3,'4099100011029',7.99,'Cheddar Truffle Cheese',4,NULL,1,0,0,0,0,0,3.75,1),(1944,'two Year Aged English Cheddar',3,'4099100011036',7.99,'two Year Aged English Cheddar',4,NULL,1,0,0,0,0,0,3.99,1),(1945,'Wensleydale & Cranberries',3,'4099100011043',7.5,'Wensleydale & Cranberries',4,NULL,1,0,0,0,0,0,3.75,1),(1946,'Birthday Card',3,'4099100011296',4.5,'Birthday Card',1,NULL,0,0,0,0,0,0,2,1),(1947,'Birthday Card',3,'4099100011319',4.5,'Birthday Card',1,NULL,0,0,0,0,0,0,2,1),(1948,'Birthday Card',3,'4099100011326',4.5,'Birthday Card',1,NULL,0,0,0,0,0,0,2,1),(1949,'Birthday Card',3,'4099100011333',4.5,'Birthday Card',1,NULL,0,0,0,0,0,0,2,1),(1950,'Birthday Card',3,'4099100011357',4.5,'Birthday Card',1,NULL,0,0,0,0,0,0,2,1),(1951,'Birthday Card',3,'4099100011364',4.5,'Birthday Card',1,NULL,0,0,0,0,0,0,2,1),(1952,'Engagement Card',3,'4099100011388',4.5,'Engagement Card',1,NULL,0,0,0,0,0,0,2,1),(1953,'Theme Sock',3,'4099100011401',3.99,'Thinking of You Greeting Card',1,NULL,0,0,0,0,0,0,2,1),(1954,'Thank You Card',3,'4099100011418',4.5,'Thank You Card',1,NULL,0,0,0,0,0,0,2,1),(1955,'New Home Greeting Card',3,'4099100011425',4.5,'New Home Greeting Card',1,NULL,0,0,0,0,0,0,2,1),(1956,'Pueblo Lindo Tortilla Triangles',3,'4099100016338',5.99,'Pueblo Lindo Tortilla Triangles',2,NULL,0,0,0,0,0,0,2.99,1),(1957,'Red Wine Cheese, Specially Selected',12,'4099100018417',8.99,'Red Wine Cheese, Specially Selected',4,NULL,1,0,0,0,0,0,8.99,1),(1958,'Cocktail Stirrers, Spicy',12,'4099100018431',6.99,'Cocktail Stirrers, Spicy',4,NULL,1,0,0,0,0,0,6.99,1),(1959,'Sparkling Wine Cheese, Specially Selected',12,'4099100018448',8.99,'Sparkling Wine Cheese, Specially Selected',4,NULL,1,0,0,0,0,0,8.99,1),(1960,'Mature Cheddar with Balsmic Red Onion',12,'4099100030426',7.99,'Mature Cheddar with Balsmic Red Onion',4,NULL,1,0,0,0,0,0,7.99,1),(1961,'Happy Farms Fondue',12,'4099100031003',9.99,'Happy Farms Fondue',4,NULL,1,0,0,0,0,0,9.99,1),(1962,'Rustic Red Cheddar',3,'4099100037296',8.99,'Rustic Red Cheddar',4,NULL,1,0,0,0,0,0,3.99,1),(1963,'Cave Aged Cheddar',12,'4099100037319',7.99,'Cave Aged Cheddar',4,NULL,1,0,0,0,0,0,3.99,1),(1964,'Olive Tepenade Hummus',3,'4099100041842',4.99,'Olive Tepenade Hummus',4,NULL,1,0,0,0,0,0,1.89,1),(1965,'Laviana Double Chocolate',12,'4099100049893',4.5,'Laviana Double Chocolate',4,NULL,1,0,0,0,0,0,4.5,1),(1966,'Metal Animal Planter',21,'4099100051285',9.99,'Metal Animal Planter',1,NULL,0,0,0,0,0,0,7,1),(1967,'Pesto Gouda',3,'4099100054446',7.99,'Pesto Gouda',4,NULL,1,0,0,0,0,0,3.99,1),(1968,'Bottle Bag',12,'4099100056075',2.59,'Bottle Bag',1,NULL,0,0,0,0,0,0,2.59,1),(1969,'Wine Bag, Party Time',12,'4099100056099',2.49,'Wine Bag, Party Time',1,NULL,0,0,0,0,0,0,2.49,1),(1970,'Bottle Bag',12,'4099100056112',2.59,'Bottle Bag',1,NULL,0,0,0,0,0,0,2.59,1),(1971,'Together Forever Anniversary Card',3,'4099100056440',4.75,'Together Forever Anniversary Card',1,NULL,0,0,0,0,0,0,1.75,1),(1972,'Welcome Baby Card',3,'4099100056457',4.5,'Welcome Baby Card',1,NULL,0,0,0,0,0,0,1.75,1),(1973,'Party Animal Birthday Card',3,'4099100056464',4.75,'Party Animal Birthday Card',1,NULL,0,0,0,0,0,0,1.75,1),(1974,'Party Time Birthday Card',3,'4099100056488',4.5,'Party Time Birthday Card',1,NULL,0,0,0,0,0,0,1.75,1),(1975,'Awesome Birthday Club Card',3,'4099100056532',4.75,'Awesome Birthday Club Card',1,NULL,0,0,0,0,0,0,1.75,1),(1976,'Have a Rockin\' Birthday Card',3,'4099100056556',4.75,'Have a Rockin\' Birthday Card',1,NULL,0,0,0,0,0,0,1.75,1),(1977,'Lattice Cut Kettle Chips',3,'4099100062250',4.99,'Lattice Cut Kettle Chips',2,NULL,0,0,0,0,0,0,3,1),(1978,'Vintage English Cheddar',12,'4099100063387',7.99,'Vintage English Cheddar',4,NULL,1,0,0,0,0,0,3.99,1),(1979,'Clancy\'s Pretzel Slims',3,'4099100064254',4.25,'Clancy\'s Pretzel Slims',10,NULL,0,0,0,0,0,0,1.99,1),(1980,'Lemon Juicer',3,'4099100065213',9.99,'Lemon Juicer',1,NULL,0,0,0,0,0,0,6,1),(1981,'Burman\'s Steak Sauce',3,'4099100074833',3.5,'Burman\'s Steak Sauce',2,NULL,0,0,0,0,0,0,1.75,1),(1982,'Lip Balm, Be Kissed',12,'4099100088724',4.99,'Lip Balm, Be Kissed',1,NULL,0,0,0,0,0,0,4.99,1),(1983,'Feta Cheese Cubes',3,'4099100107227',6.99,'Feta Cheese Cubes',4,NULL,1,0,0,0,0,0,3.59,1),(1984,'Martinellis Sparkling Cider',12,'4124467',4.99,'Martinellis Sparkling Cider',15,1,0,0,0,0,0,0,4.99,1),(1985,'Burman\'s Hot sauce',12,'4141877',2.99,'Burman\'s Hot sauce',4,NULL,1,0,0,0,0,0,2.99,1),(1986,'Ice Balls',12,'48858854',6.99,'Ice Balls',1,NULL,0,0,0,0,0,0,6.99,1),(1987,'Kirkwood WInery My First Crush',10,'490750812860',19.99,'Kirkwood WInery My First Crush',5,1,0,0,0,0,2,0,15,12),(1988,'Secret Cellar Hat',21,'492090700081',14.99,'Secret Cellar Hat',1,NULL,0,0,0,0,0,0,10,1),(1989,'Secret Cellar White Hat',21,'492090700098',14.99,'Secret Cellar White Hat',1,NULL,0,0,0,0,0,0,10,1),(1990,'La Crema Pinot Noir',12,'4930709',22.99,'La Crema Pinot Noir',5,1,0,0,0,0,2,0,22.99,12),(1991,'5 Cent Candy',21,'5 CENT CANDY',0.05,'5 Cent Candy',2,NULL,0,0,0,0,0,0,0.03,1),(1992,'Timorois Beastie Scotch',12,'5014218796056',67.99,'Timorois Beastie Scotch',7,1,0,0,0,0,0,0,67.99,1),(1993,'Belgian Truffles 16oz',23,'5410291007636',14.99,'Belgian Truffles 16oz',2,NULL,0,0,0,0,0,0,5,1),(1994,'Crabbies Ginger Beer',19,'557000001',11.99,'Crabbies Ginger Beer',6,NULL,0,0,0,0,0,0,9,1),(1995,'Meet & Meat',14,'5600228155107',13.99,'Meet & Meat',5,1,0,0,0,0,2,0,13.99,12),(1996,'Paxis red blend',12,'5600312192049',12.99,'Paxis red blend',5,1,0,0,0,0,2,0,12.99,12),(1997,'Paxis Rose Blend',14,'5600312192278',12.99,'Paxis Rose Blend',5,1,0,0,0,0,2,0,8.25,12),(1998,'Vinha do Putto',12,'5600392560851',11.99,'Vinha do Putto',5,1,0,0,0,0,2,0,10,12),(1999,'Red Blend Portugal',14,'5604424429017',11.99,'Red Blend Portugal',5,1,0,0,0,0,2,0,9.35,12),(2000,'Cabriz Red Blend',12,'5604575110024',12.99,'Cabriz Red Blend',5,1,0,0,0,0,2,0,12.99,12),(2002,'Water Bottle, 17oz',12,'6006937135314',14.99,'Water Bottle, 17oz',1,NULL,0,0,0,0,0,0,14.99,1),(2003,'Hatch Valley Salsa, Med',12,'602050010871',4.99,'Hatch Valley Salsa, Med',4,NULL,1,0,0,0,0,0,4.99,1),(2004,'Chronic Cellars, Suite Petite',13,'603012005065',15.99,'Chronic Cellars, Suite Petite',5,1,0,0,0,0,2,0,11,12),(2005,'Chronic Cellars purple Paradise',13,'603012005089',16.99,'Chronic Cellars purple Paradise',5,1,0,0,0,0,2,0,10.75,12),(2006,'Red cat',12,'605330000135',14.99,'Red cat',5,1,0,0,0,0,2,0,14.99,12),(2007,'Old Speckled Hen English Ale 4 Pack',12,'605800000184',19.99,'Old Speckled Hen English Ale 4 Pack',6,4,0,0,0,0,0,0,12.99,1),(2008,'Gancia Brachetto D\'Acqui',12,'606508024175',12.99,'Gancia Brachetto D\'Acqui',5,1,0,0,0,0,2,0,12.99,12),(2009,'Fritz de Katz Reisling',12,'607054120090',11.99,'Fritz de Katz Reisling',5,1,0,0,0,0,2,0,11.99,12),(2010,'Sweet Bitch Moscato Rose Bubbly',12,'607054492319',14.99,'Sweet Bitch Moscato Rose Bubbly',5,1,0,0,0,0,2,0,14.99,12),(2011,'Hobgoblin English Ale 4 Pack',12,'608359005006',10.99,'Hobgoblin English Ale 4 Pack',6,4,0,0,0,0,0,0,10.99,1),(2012,'1921 Blanco Tequila',12,'608604000015',49.99,'1921 Blanco Tequila',7,1,0,0,0,0,0,0,49.99,1),(2013,'Bottle Chees server',12,'608814252396',11.99,'Bottle Chees server',1,NULL,0,0,0,0,0,0,11.99,1),(2014,'Bottle Chees server',12,'608814263491',11.99,'Bottle Chees server',1,NULL,0,0,0,0,0,0,11.99,1),(2015,'Are de Medeiros',11,'609465862835',13.99,'Are de Medeiros',5,1,0,0,0,0,2,0,9,12),(2016,'Donostia Extra Virgin Olive Oil',12,'609503707012',9.99,'Donostia Extra Virgin Olive Oil',4,NULL,1,0,0,0,0,0,9.99,1),(2017,'Red Bull 12oz',12,'611269818994',3.75,'Red Bull 12oz',15,1,0,0,0,0,0,0,3.75,1),(2018,'Bottle Bag, Natural',12,'612933936006',1.99,'Bottle Bag, Natural',1,NULL,0,0,0,0,0,0,1.99,1),(2019,'Coin Purse',21,'613153784279',2.75,'Coin Purse',1,NULL,0,0,0,0,0,0,1.5,1),(2020,'Dirty Martini Mix',12,'613961908027',5.99,'Dirty Martini Mix',4,NULL,1,0,0,0,0,0,5.99,1),(2021,'New Holland Dragon\'s Milk Stout 4 pack',12,'614036124113',16.99,'New Holland Dragon\'s Milk Stout 4 pack',6,4,0,0,0,0,0,0,16.99,1),(2022,'Gift Bag',12,'614577332824',2.99,'Gift Bag',1,NULL,0,0,0,0,0,0,2.99,1),(2023,'ZingZang 6 pack',13,'616003559928',10.99,'ZingZang 6 pack',4,6,1,0,0,0,0,0,6.75,1),(2024,'ZingZang Bloody Mary Mix',13,'616003814225',5.99,'ZingZang Bloody Mary Mix',4,NULL,1,0,0,0,0,0,4,1),(2025,'Tito\'s Vodka 1 L',12,'619947000013',26.56,'Tito\'s Vodka 1 L',7,1,0,0,0,0,0,0,26.56,1),(2026,'Tito\'s Vodka 1.75 L',18,'619947000037',39.88,'Tito\'s Vodka 1.75 L',7,1,0,0,0,0,0,0,39.88,1),(2027,'Titos 375ml',18,'619947000051',12.99,'Titos 375ml',7,NULL,0,0,0,0,0,0,8.63,1),(2028,'Tito\'s Vodka 50ml',18,'619947000068',2.5,'Tito\'s Vodka 50ml',7,NULL,0,0,0,0,0,0,1.6,1),(2029,'Stolichnaya Stoli Razberi 1 L',12,'6277551020441',34.54,'Stolichnaya Stoli Razberi 1 L',7,1,0,0,0,0,0,0,34.54,1),(2030,'Art Glass Bottle Stopper 2pc',12,'630613026601',17.99,'Art Glass Bottle Stopper 2pc',1,NULL,0,0,0,0,0,0,17.99,1),(2031,'Wine Stopper, Art Glass',12,'630613029602',9.95,'Wine Stopper, Art Glass',1,NULL,0,0,0,0,0,0,9.95,1),(2032,'Bordeaux Wine Aerator',12,'630613030844',10.99,'Bordeaux Wine Aerator',1,NULL,0,0,0,0,0,0,10.99,1),(2033,'Cheese Knife, Alligator',12,'630613033036',1,'Cheese Knife, Alligator',1,NULL,0,0,0,0,0,0,1,1),(2034,'Wine Stopper, Crystal',12,'630613034132',14.99,'Wine Stopper, Crystal',1,NULL,0,0,0,0,0,0,14.99,1),(2035,'wine stopper',12,'630613034460',9.99,'wine stopper',1,NULL,0,0,0,0,0,0,9.99,1),(2036,'Wine Bottle Stopper, Destinations',12,'630613035344',9.99,'Wine Bottle Stopper, Destinations',1,NULL,0,0,0,0,0,0,9.99,1),(2037,'Santa Margherita Pinot Grigio 375 mL',12,'632987200052',18.99,'Santa Margherita Pinot Grigio 375 mL',5,1,0,0,0,0,2,0,18.99,12),(2038,'Santa Margherita Pinot Grigio 2018',19,'632987200205',27.99,'Santa Margherita Pinot Grigio 2018',5,1,0,0,0,0,2,0,19.5,12),(2039,'Mikes Harder Strawberry',12,'635985132196',1.99,'Mikes Harder Strawberry',6,NULL,0,0,0,0,0,0,1.99,1),(2040,'Mike\'s Harder Lemonade',12,'635985258759',1.99,'Mike\'s Harder Lemonade',6,1,0,0,0,0,0,0,1.99,1),(2041,'White Claw Variety 12-Pack',17,'635985548904',18.99,'White Claw Variety 12-Pack',6,NULL,0,0,0,0,0,0,14,1),(2042,'Dogfish Head Burton Baton',12,'638489000671',16.8,'Dogfish Head Burton Baton',6,4,0,0,0,0,0,0,16.8,1),(2043,'Dogfish Head Burton Baton 4 Pack',12,'638489000695',16.8,'Dogfish Head Burton Baton 4 Pack',6,4,0,0,0,0,0,0,16.8,1),(2044,'Mini Solo Shot Cups',21,'639277009531',2.99,'Mini Solo Shot Cups',1,NULL,0,0,0,0,0,0,1.5,1),(2045,'Glow Play, Blue',12,'639277057167',1.99,'Glow Play, Blue',1,NULL,0,0,0,0,0,0,1.99,1),(2046,'Glow Play, Pink',12,'639277057181',1.99,'Glow Play, Pink',1,NULL,0,0,0,0,0,0,1.99,1),(2047,'Glow Play, Purple',12,'639277057228',1.99,'Glow Play, Purple',1,NULL,0,0,0,0,0,0,1.99,1),(2048,'Glow Play, variety',12,'639277057273',1.99,'Glow Play, variety',1,NULL,0,0,0,0,0,0,1.99,1),(2049,'Bottle Pours 2 Pack',12,'639277104410',4.99,'Bottle Pours 2 Pack',1,NULL,0,0,0,0,0,0,4.99,1),(2050,'Candle, 60 count',12,'639277122360',2.99,'Candle, 60 count',1,NULL,0,0,0,0,0,0,2.99,1),(2051,'Napkins',12,'639277139245',2.99,'Napkins',1,NULL,0,0,0,0,0,0,2.99,1),(2052,'Water\'s Corkscrew',12,'639277161529',8.99,'Water\'s Corkscrew',1,NULL,0,0,0,0,0,0,8.99,1),(2053,'Gift Bag',12,'639277169457',3.99,'Gift Bag',1,NULL,0,0,0,0,0,0,3.99,1),(2054,'Home Store Kitchen Towel',12,'639277208804',2.99,'Home Store Kitchen Towel',1,NULL,0,0,0,0,0,0,2.99,1),(2055,'Portable wine Glass',12,'639277217066',3.99,'Portable wine Glass',1,NULL,0,0,0,0,0,0,3.99,1),(2056,'Goofy String',12,'639277232557',2.49,'Goofy String',1,NULL,0,0,0,0,0,0,NULL,1),(2057,'Goofy String',12,'639277232571',2.49,'Goofy String',1,NULL,0,0,0,0,0,0,2.49,1),(2058,'Coffee Stirrers 250 cnt',12,'639277237644',2.99,'Coffee Stirrers 250 cnt',1,NULL,0,0,0,0,0,0,2.99,1),(2059,'Pasta & Pizza Seasoning',12,'639277300904',3.99,'Pasta & Pizza Seasoning',4,NULL,1,0,0,0,0,0,3.99,1),(2060,'Glow wand, Avengers',12,'639277304261',1.99,'Glow wand, Avengers',1,NULL,0,0,0,0,0,0,1.99,1),(2061,'Wrapping paper',12,'639277304452',2.99,'Wrapping paper',1,NULL,0,0,0,0,0,0,2.99,1),(2062,'Wraping paper',12,'639277338952',2.99,'Wraping paper',1,NULL,0,0,0,0,0,0,2.99,1),(2063,'Glow Play Bracelets 20 pcs',12,'639277355348',2.99,'Glow Play Bracelets 20 pcs',1,NULL,0,0,0,0,0,0,2.99,1),(2064,'Glow Play Bracelets 20 pcs',12,'639277355362',2.99,'Glow Play Bracelets 20 pcs',1,NULL,0,0,0,0,0,0,2.99,1),(2065,'Fairy Doll',12,'639277373946',2.99,'Fairy Doll',1,NULL,0,0,0,0,0,0,2.99,1),(2066,'Fake Mustaches',12,'639277374400',2.99,'Fake Mustaches',1,NULL,0,0,0,0,0,0,2.99,1),(2067,'Coin Purse',12,'639277400987',3.99,'Coin Purse',1,NULL,0,0,0,0,0,0,3.99,1),(2068,'Pony Toy',21,'639277403551',2.99,'Pony Toy',1,NULL,0,0,0,0,0,0,1.5,1),(2069,'Mermaid Sirene',21,'639277403735',2.99,'Mermaid Sirene',1,NULL,0,0,0,0,0,0,1.5,1),(2070,'Growing Crystals',21,'639277443137',2.99,'Growing Crystals',1,NULL,0,0,0,0,0,0,1.5,1),(2071,'Emoticon',12,'639277483867',2.99,'Emoticon',1,NULL,0,0,0,0,0,0,2.99,1),(2072,'Silly Sound Phone',21,'639277499769',3.99,'Silly Sound Phone',1,NULL,0,0,0,0,0,0,1.5,1),(2073,'Unicorn Headband',21,'639277527769',2.99,'Unicorn Headband',1,NULL,0,0,0,0,0,0,1.5,1),(2074,'Gift Bag',12,'639277532985',4.99,'Gift Bag',1,NULL,0,0,0,0,0,0,4.99,1),(2075,'Marshmallow Unicorn Poop',12,'639277533159',2.75,'Marshmallow Unicorn Poop',2,NULL,0,0,0,0,0,0,1.25,1),(2076,'Gift Bag',12,'639277542045',1.99,'Gift Bag',1,NULL,0,0,0,0,0,0,1.99,1),(2077,'Lap Leaders',12,'639277578648',2.99,'Lap Leaders',1,NULL,0,0,0,0,0,0,2.99,1),(2078,'Poo Doo',21,'639277578952',2.99,'Poo Doo',1,NULL,0,0,0,0,0,0,1.5,1),(2079,'Poo Doo Toy',21,'639277580283',2.75,'Poo Doo Toy',1,NULL,0,0,0,0,0,0,1.5,1),(2080,'Foam Plane',12,'639277628954',2.99,'Foam Plane',1,NULL,0,0,0,0,0,0,2.99,1),(2081,'Ninja Wall Crawler',21,'639277630278',2.99,'Ninja Wall Crawler',1,NULL,0,0,0,0,0,0,1.5,1),(2082,'Cocktail cutting board, Bamboo',12,'639277647412',2.99,'Cocktail cutting board, Bamboo',1,NULL,0,0,0,0,0,0,2.99,1),(2083,'Poo Head Squirter',21,'639277665553',2.99,'Poo Head Squirter',1,NULL,0,0,0,0,0,0,1.5,1),(2084,'Long Flex Straws',10,'639277666062',2.99,'Long Flex Straws',1,NULL,0,0,0,0,0,0,1.5,1),(2085,'Grad gift, 2019',12,'639277669827',2.99,'Grad gift, 2019',1,NULL,0,0,0,0,0,0,2.99,1),(2086,'Sticky Hands Toy',21,'639277726711',2.99,'Sticky Hands Toy',1,NULL,0,0,0,0,0,0,1.5,1),(2087,'Gift Bag',12,'639277735461',3.99,'Gift Bag',1,NULL,0,0,0,0,0,0,3.99,1),(2088,'Champagne Flutes, 2pc',12,'639277741516',3.99,'Champagne Flutes, 2pc',1,NULL,0,0,0,0,0,0,3.99,1),(2089,'Toy Pony',21,'639277744678',2.99,'Toy Pony',1,NULL,0,0,0,0,0,0,1.5,1),(2090,'Troll Hair Toy',21,'639277745095',2.99,'Troll Hair Toy',1,NULL,0,0,0,0,0,0,1.5,1),(2091,'Gift Bag',12,'639277748256',2.99,'Gift Bag',1,NULL,0,0,0,0,0,0,2.99,1),(2092,'Gift Bag',12,'639277754684',2.99,'Gift Bag',1,NULL,0,0,0,0,0,0,2.99,1),(2093,'Glow in the Dark Latern',12,'639277756350',2.99,'Glow in the Dark Latern',1,NULL,0,0,0,0,0,0,2.99,1),(2094,'Hot Glasses 24 pack',12,'639277779144',2.89,'Hot Glasses 24 pack',1,NULL,0,0,0,0,0,0,2.89,1),(2095,'Tea, Apple Spice',12,'639277780515',2.99,'Tea, Apple Spice',4,NULL,1,0,0,0,0,0,2.99,1),(2096,'Unicaorn Ooze',12,'639277816627',2.75,'Unicaorn Ooze',1,NULL,0,0,0,0,0,0,1.25,1),(2097,'Non-spill cup',12,'639277900746',6.99,'Non-spill cup',1,NULL,0,0,0,0,0,0,6.99,1),(2098,'Birthday Candles',12,'639277962447',3.99,'Birthday Candles',1,NULL,0,0,0,0,0,0,3.99,1),(2099,'Buchanan House Buggy Ride',12,'640626903646',14.75,'Buchanan House Buggy Ride',5,1,0,0,0,0,2,0,10,12),(2100,'Buchanan House Frontenac',7,'640626903653',14.99,'Buchanan House Frontenac',5,1,0,0,0,0,2,0,9.75,12),(2101,'Buchanan House Miss Sarah',12,'640626903677',14.75,'Buchanan House Miss Sarah',5,1,0,0,0,0,2,0,10,12),(2102,'Buchanan House white',12,'640626903905',14.75,'Buchanan House white',5,1,0,0,0,0,2,0,14.75,12),(2103,'Buchanan House Marquette Reserve',12,'640626903929',15.99,'Buchanan House Marquette Reserve',5,1,0,0,0,0,2,0,15.99,12),(2104,'Buchanan House Lazy Afternoon',12,'640626904209',9.99,'Buchanan House Lazy Afternoon',5,1,0,0,0,0,2,0,9.99,12),(2105,'Buchanan House Red Field Blend',21,'640626904230',9.99,'Buchanan House Red Field Blend',5,1,0,0,0,0,2,0,7,12),(2106,'Buchanan House Red',7,'640626904452',13.99,'Buchanan House Red',5,1,0,0,0,0,2,0,9,12),(2107,'Grand Marnier Mini 50ml',18,'649188900360',4.99,'Grand Marnier Mini 50ml',7,NULL,0,0,0,0,0,0,2.56,1),(2108,'Grand Marnier 1 L',18,'649188900483',54.99,'Grand Marnier 1 L',7,1,0,0,0,0,0,0,39.33,1),(2109,'Seven deadly sins Zinfandel',12,'652935100012',18.99,'Seven deadly sins Zinfandel',5,1,0,0,0,0,2,0,18.99,12),(2110,'Earthquake Cabernet Sauvignon',13,'652935100067',27.99,'Earthquake Cabernet Sauvignon',5,1,0,0,0,0,2,0,12,12),(2111,'6th Sense Syrah',12,'652935100098',16.99,'6th Sense Syrah',5,1,0,0,0,0,2,0,16.99,12),(2112,'GooZooka',21,'653899766955',2.99,'GooZooka',1,NULL,0,0,0,0,0,0,1.5,1),(2113,'Mrs. Fields Chocolate Chip Cookies',12,'655956008220',2.25,'Mrs. Fields Chocolate Chip Cookies',2,NULL,0,0,0,0,0,0,1.5,1),(2114,'Troublemaker Red Blend',13,'657891702423',15.99,'Troublemaker Red Blend',5,1,0,0,0,0,2,0,10,12),(2115,'Treana Cabernet',13,'657891716147',29.99,'Treana Paso Robles Cabernet 2016',5,1,0,0,0,0,2,0,18.75,12),(2116,'LaPanzanella Mini Rosemary Croccantini',16,'659000406000',5.99,'LaPanzanella Mini Rosemary Croccantini',2,NULL,0,0,0,0,0,0,3.37,1),(2117,'Remake it Wine Cork Trivet',12,'659549214098',12.99,'Remake it Wine Cork Trivet',1,NULL,0,0,0,0,0,0,12.99,1),(2118,'Figuiere Le Saint Andre Vermentino 2016',14,'659760090112',13.99,'Figuiere Le Saint Andre Vermentino 2016',5,1,0,0,0,0,2,0,8,12),(2119,'Campus Oaks',12,'659994001205',14.99,'Campus Oaks',5,1,0,0,0,0,2,0,14.99,12),(2120,'Bamboo Cocktail picks 75ct',12,'661371903729',3.99,'Bamboo Cocktail picks 75ct',1,NULL,0,0,0,0,0,0,3.99,1),(2121,'Gift Bag',12,'661526575771',2.99,'Gift Bag',1,NULL,0,0,0,0,0,0,2.99,1),(2122,'Beach House rose',12,'663194000951',10.99,'Beach House rose',5,1,0,0,0,0,2,0,10.99,12),(2123,'Zoe Greek Dry',11,'663997000257',13.99,'Zoe Greek Dry',5,1,0,0,0,0,2,0,13.99,12),(2124,'Merry Irish Cream gift Boc',12,'665203200604',19.99,'Merry Irish Cream gift Boc',7,1,0,0,0,0,0,0,19.99,1),(2125,'wine Glass and Dog Stopper',12,'665613272055',14.99,'wine Glass and Dog Stopper',1,NULL,0,0,0,0,0,0,14.99,1),(2126,'Catena Vista Flores Malbec 2016 Mendoza',13,'667528048336',18.99,'Catena Vista Flores Malbec 2016 Mendoza',5,1,0,0,0,0,2,0,13.5,12),(2127,'Body lotion, Vineyard Kiss',12,'667539047878',11.99,'Body lotion, Vineyard Kiss',1,NULL,0,0,0,0,0,0,11.99,1),(2128,'Paraduxx Red Wine',12,'669576018682',44.99,'Paraduxx Red Wine',5,1,0,0,0,0,2,0,44.99,12),(2129,'Duckhorn Napa Valley Merlot 2014',19,'669576019283',54,'Duckhorn Napa Valley Merlot 2014',5,1,0,0,0,0,2,0,40,12),(2130,'Canvasback Cabernet Sauvignon',12,'669576040003',36.99,'Canvasback Cabernet Sauvignon',5,1,0,0,0,0,2,0,36.99,12),(2131,'Don Julio Reposado Tequila',18,'674545000414',64.99,'Don Julio Reposado Tequila',7,1,0,0,0,0,0,0,47.99,1),(2132,'Finca Luzon',14,'678801000040',14.99,'Finca Luzon',5,1,0,0,0,0,2,0,11.99,12),(2133,'Zinzilla',12,'681416803005',15.99,'Zinzilla',5,1,0,0,0,0,2,0,15.99,12),(2134,'Hammered Moscow Mule Mug',12,'682833608419',14.99,'Hammered Moscow Mule Mug',1,NULL,0,0,0,0,0,0,14.99,1),(2135,'Rare Red Blend',11,'684586204085',12.99,'Rare Red Blend',5,1,0,0,0,0,2,0,8.25,12),(2136,'Johny Bootlegger, Raspberry',12,'684746355107',3.99,'Johny Bootlegger, Raspberry',7,NULL,0,0,0,0,0,0,3.99,1),(2137,'Ardeche',10,'6861100109',10.99,'Ardeche',5,1,0,0,0,0,2,0,8,12),(2138,'Manzanita Creek Zinfandel',12,'689076851343',20.99,'Manzanita Creek Zinfandel',5,1,0,0,0,0,2,0,20.99,12),(2139,'Kim Crawford Sauvignon Blanc',13,'689352009611',19.99,'Kim Crawford Sauvignon Blanc',5,1,0,0,0,0,2,0,10.99,12),(2140,'Magellan Gin',12,'689768903008',35.99,'Magellan Gin',7,1,0,0,0,0,0,0,35.99,1),(2141,'Craggy Ridge Pinot Noir',12,'690300550611',44.99,'Craggy Ridge Pinot Noir',5,1,0,0,0,0,2,0,44.99,12),(2142,'Glo 6\" Light Stick',12,'6932373166035',1.79,'Glo 6\" Light Stick',1,NULL,0,0,0,0,0,0,1.79,1),(2143,'Thomas George Pinot Noir',12,'696859158995',37.99,'Thomas George Pinot Noir',5,1,0,0,0,0,2,0,37.99,12),(2144,'Wine Botle Pepper Grinder',12,'698617500398',18.99,'Wine Botle Pepper Grinder',1,NULL,0,0,0,0,0,0,18.99,1),(2145,'Mural Red Blend',12,'698843003052',13.99,'Mural Red Blend',5,1,0,0,0,0,2,0,13.99,12),(2146,'Portal Tawny Porto',12,'698843131014',24.99,'Portal Tawny Porto',5,1,0,0,0,0,2,0,24.99,12),(2147,'Portal Ruby Porto',12,'698843133018',23.99,'Portal Ruby Porto',5,1,0,0,0,0,2,0,23.99,12),(2148,'Funny Faces Sticker Book',12,'699284101567',1.99,'Funny Faces Sticker Book',1,NULL,0,0,0,0,0,0,1.99,1),(2149,'Moose Drool Brown Ale 6 Pack',12,'700283010030',10.25,'Moose Drool Brown Ale 6 Pack',6,6,0,0,0,0,0,0,10.25,1),(2150,'Gruet Brut',12,'701253002000',19.99,'Gruet Brut',5,1,0,0,0,0,2,0,19.99,12),(2151,'Gruet Demi sec Sparking Wine 375 mL',12,'701253004011',12.99,'Gruet Demi sec Sparking Wine 375 mL',5,1,0,0,0,0,2,0,12.99,12),(2152,'Gruet Brut Rose',13,'701253006008',19.99,'Gruet Brut Rose',5,1,0,0,0,0,2,0,12.99,12),(2153,'Willamette Valley Pinot Gris',13,'7071919703',17.99,'Willamette Valley Pinot Gris',5,1,0,0,0,0,2,0,12,12),(2154,'Blue Nun Riesling',13,'707596001021',11.99,'Blue Nun Riesling',5,1,0,0,0,0,2,0,7.99,12),(2155,'Lassegue Saint Emilion Grand Cru',13,'709793000111',65.99,'Lassegue Saint Emilion Grand Cru',5,1,0,0,0,0,2,0,53.438,12),(2156,'Sharper Image Bar Cutting Board',12,'709996760966',6.99,'Sharper Image Bar Cutting Board',1,NULL,0,0,0,0,0,0,6.99,1),(2157,'Stonewall Strawberry Jam',12,'711381000663',5.99,'Stonewall Strawberry Jam',4,NULL,1,0,0,0,0,0,5.99,1),(2158,'Freshies Bloody Mary Mix Original',12,'713035087501',8.99,'Freshies Bloody Mary Mix Original',2,NULL,0,0,0,0,0,0,5.25,1),(2159,'Freshies Peach-Mango',12,'713035087556',8.99,'Freshies Peach-Mango',4,NULL,1,0,0,0,0,0,8.99,1),(2160,'Freshies Tangerita',12,'713035087617',7.99,'Freshies Tangerita',4,NULL,1,0,0,0,0,0,7.99,1),(2161,'Spicy Red Picante',12,'713035142637',4.99,'Spicy Red Picante',4,NULL,1,0,0,0,0,0,4.99,1),(2162,'Carlson Charade Red Wine',22,'714119800009',28.99,'Carlson GSM',5,1,0,0,0,0,2,0,20.17,12),(2163,'Willamette Valley Whole Cluster Pinot Noir',13,'717071911714',21.99,'Willamette Valley Whole Cluster Pinot Noir',5,1,0,0,0,0,2,0,21.99,12),(2164,'Willamette Valley Pinot Gris',12,'717071919703',17.99,'Willamette Valley Pinot Gris',5,1,0,0,0,0,2,0,17.99,12),(2165,'1895 Coleccion Malbec',12,'717888790120',11.99,'1895 Coleccion Malbec',5,1,0,0,0,0,2,0,11.99,12),(2166,'Fess Parker Riesling',12,'718038555743',13.99,'Fess Parker Riesling',5,1,0,0,0,0,2,0,13.99,12),(2167,'Wine Wipes',12,'718122165384',5.99,'Wine Wipes',1,NULL,0,0,0,0,0,0,5.99,1),(2168,'Trio Pouch Set',12,'718540481158',19.99,'Trio Pouch Set',1,NULL,0,0,0,0,0,0,19.99,1),(2169,'5-Hour Energy, Extra Strength',12,'719410720018',2.89,'5-Hour Energy, Extra Strength',2,NULL,0,0,0,0,0,0,2.89,1),(2170,'India Ink Red Blend',12,'720815150225',20.99,'India Ink Red Blend',5,1,0,0,0,0,2,0,20.99,12),(2171,'Templeton Rye Whiskey',18,'720815920101',39.99,'Templeton Rye Whiskey',7,1,0,0,0,0,0,0,27.64,1),(2172,'Templeton Rye Barrel Strength',12,'720815921030',59.99,'Templeton Rye Barrel Strength',7,NULL,0,0,0,0,0,0,59.99,1),(2173,'Corralejo Reposado Tequila',18,'720815930131',31.99,'Corralejo Reposado Tequila',7,1,0,0,0,0,0,0,31.99,1),(2174,'Seagrams Watermelon Vodka 50ml',12,'720815980402',1.75,'Seagrams Watermelon Vodka 50ml',7,NULL,0,0,0,0,0,0,1.75,1),(2175,'Mini Seagram\'s Lime 50ml',10,'720815981201',1.75,'Mini Smirnoff Lime',7,NULL,0,0,0,0,0,0,1.25,1),(2176,'Seagram\'s Vodka 1.75 L',18,'720815986046',21.99,'Seagram\'s Vodka 1.75 L',7,1,0,0,0,0,0,0,16,1),(2177,'Aperol',12,'721059001311',26.99,'Aperol',7,NULL,0,0,0,0,0,0,26.99,1),(2178,'Appleton Estate Signature Blend Rum',12,'721059001502',23.05,'Appleton Estate Signature Blend Rum',7,1,0,0,0,0,0,0,23.05,1),(2179,'Wild Turkey Longbranch',12,'721059002844',42,'Wild Turkey Longbranch',7,1,0,0,0,0,0,0,42,1),(2180,'Campari',12,'721059047500',30.99,'Campari',7,NULL,0,0,0,0,0,0,30.99,1),(2181,'Frangelico Liqueur',12,'721059987509',31.45,'Frangelico Liqueur',7,1,0,0,0,0,0,0,31.45,1),(2182,'Gosling Black Seal Rum',12,'721094199059',20.99,'Gosling Black Seal Rum',7,1,0,0,0,0,0,0,20.99,1),(2183,'L\'Ecole Chenin Blanc',12,'721354890023',15.99,'L\'Ecole Chenin Blanc',5,1,0,0,0,0,2,0,15.99,12),(2184,'Patron Silver Tequila',12,'721733000029',57.7,'Patron Silver Tequila',7,1,0,0,0,0,0,0,57.7,1),(2185,'Patron Silver Tequila 50ml',12,'721733000234',6.99,'Patron Silver Tequila 50ml',7,NULL,0,0,0,0,0,0,5,1),(2186,'Patron Rainbow 3-Pack',10,'721733000241',22.99,'Patron Rainbow 3-Pack',7,NULL,0,0,0,0,0,0,15.38,1),(2187,'Pop Rocks 3 Pack',12,'721874009905',2.25,'Pop Rocks 3 Pack',2,NULL,0,0,0,0,0,0,1.25,1),(2188,'90 Shilling ODell Brewing COmpany',19,'722160222534',11.99,'90 Shilling ODell Brewing COmpany',6,NULL,0,0,0,0,0,0,8.25,1),(2189,'Demitris bloody Mary Seasoning Extra Horshradish',12,'722782477855',8.99,'Demitris bloody Mary Seasoning Extra Horshradish',4,NULL,1,0,0,0,0,0,8.99,1),(2190,'Lagunitas IPA',17,'723830000094',10.99,'Lagunitas IPA',6,NULL,0,0,0,0,0,0,7.25,1),(2191,'J Cuvee 20',19,'724624114010',36.99,'J Cuvee 20',5,1,0,0,0,0,2,0,25.8,12),(2192,'Boulevard Unfiltered Wheat Beer',12,'726959901204',12.99,'Boulevard Unfiltered Wheat Beer',6,6,0,0,0,0,0,0,12.99,1),(2193,'Dark Truth Imperial Stout',12,'726959909774',10.99,'Dark Truth Imperial Stout',6,6,0,0,0,0,0,0,10.99,1),(2194,'Boulevard Space Camper',1,'726959911074',10.99,'Boulevard Space Camper',6,NULL,0,0,0,0,0,0,7.5,1),(2195,'Mionetto Lambrusco',12,'727760501331',8.99,'Mionetto Lambrusco',5,1,0,0,0,0,2,0,8.99,12),(2196,'Cherry Bomb Blonde 4 Pack',17,'728028438239',10.99,'Cherry Bomb Blonde 4 Pack',6,4,0,0,0,0,0,0,7.66,1),(2197,'Tank Puncher IPA 6 pack',1,'728028451535',11.99,'Tank Puncher IPA 6 pack',6,6,0,0,0,0,0,0,8.5,1),(2198,'Amstel Light',12,'7289848',1.99,'Amstel Light',6,1,0,0,0,0,0,0,1.99,1),(2199,'Fred Wine Lines, Subtle',12,'728987012785',10.99,'Fred Wine Lines, Subtle',1,NULL,0,0,0,0,0,0,10.99,1),(2200,'Fred Wine Lines, Sturdy',12,'728987012792',10.99,'Fred Wine Lines, Sturdy',1,NULL,0,0,0,0,0,0,10.99,1),(2201,'Zocker gruner Veltliner',12,'730429851104',15.99,'Zocker gruner Veltliner',5,1,0,0,0,0,2,0,15.99,12),(2202,'Saintsbury',12,'732458960970',14.99,'Saintsbury',5,1,0,0,0,0,2,0,14.99,12),(2203,'Chateau Montelena Chardonnay',19,'733555351326',57.99,'Chateau Montelena Chardonnay',5,1,0,0,0,0,2,0,44.55,12),(2204,'Justin Cabernet Sauvignon',12,'733952997103',25.99,'Justin Cabernet Sauvignon',5,1,0,0,0,0,2,0,25.99,12),(2205,'Nuvo Sparkling Liqueur',12,'736040506898',20.99,'Nuvo Sparkling Liqueur',7,1,0,0,0,0,0,0,20.99,1),(2206,'Passiomento',12,'736040532385',21.99,'Passiomento',5,1,0,0,0,0,2,0,21.99,12),(2207,'Roth Grand Cru Alpine-style Cheese',12,'736547566715',7.99,'Roth Grand Cru Alpine-style Cheese',4,NULL,1,0,0,0,0,0,7.99,1),(2208,'Poizin Zinfandel 2014',19,'736585222451',18.99,'Poizin Zinfandel 2014',5,1,0,0,0,0,2,0,12,12),(2209,'Goose 312 Wheat Ale single',12,'736920111815',2.99,'Goose 312 Wheat Ale single',6,1,0,0,0,0,0,0,2.99,1),(2210,'312 wheat Ale',1,'736920111822',10.99,'312 wheat Ale',6,6,0,0,0,0,0,0,10.99,1),(2211,'Aventinus Dobbelbock Ale',12,'737398018200',6.99,'Aventinus Dobbelbock Ale',6,1,0,0,0,0,0,0,6.99,1),(2212,'Christmas Ornament',12,'738449412657',4.99,'Christmas Ornament',1,NULL,0,0,0,0,0,0,4.99,1),(2213,'Christmas Ornament',12,'738449412978',4.99,'Christmas Ornament',1,NULL,0,0,0,0,0,0,4.99,1),(2214,'Vinderpants',12,'739048123272',10.99,'Vinderpants',1,NULL,0,0,0,0,0,0,10.99,1),(2215,'Wine Bottle Stopper',12,'739048123432',7.99,'Wine Bottle Stopper',1,NULL,0,0,0,0,0,0,7.99,1),(2216,'Googly Eyes Drink Markers',12,'739048123746',5.99,'Googly Eyes Drink Markers',1,NULL,0,0,0,0,0,0,5.99,1),(2217,'Narcissist Mints',12,'739048126679',4.75,'Narcissist Mints',4,NULL,1,0,0,0,0,0,4.75,1),(2218,'Gazella Vinho Verde Portugal',13,'739949010404',10.99,'Gazella Vinho Verde',5,1,0,0,0,0,2,0,5.75,12),(2219,'Silk & Spice Portugal Red Blend 2017',13,'739949026320',13.99,'Silk & Spice Portugal Red Blend 2017',5,1,0,0,0,0,2,0,8,12),(2220,'S\'well Insulated water bottle',12,'741360387737',35.99,'S\'well Insulated water bottle',1,NULL,0,0,0,0,0,0,35.99,1),(2221,'Ferrari Carano Fume Blanc',12,'742651123102',16.99,'Ferrari Carano Fume Blanc',5,1,0,0,0,0,2,0,16.99,12),(2222,'Amarone Della Valpolicella',12,'745163231006',39.99,'Amarone Della Valpolicella',5,1,0,0,0,0,2,0,39.99,12),(2223,'Gift Bag',12,'745402420024',2.99,'Gift Bag',1,NULL,0,0,0,0,0,0,2.99,1),(2224,'Gift Bag',12,'745402420031',1.99,'Gift Bag',1,NULL,0,0,0,0,0,0,1.99,1),(2225,'Lakefront New Grist Ginger Ale 6 Pack',12,'746546000783',10.99,'Lakefront New Grist Ginger Ale 6 Pack',6,6,0,0,0,0,0,0,10.99,1),(2226,'Marietta Old Vine Red',12,'746751687137',15.99,'Marietta Old Vine Red',5,1,0,0,0,0,2,0,15.99,12),(2227,'Napkins',12,'746851043956',3.99,'Napkins',1,NULL,0,0,0,0,0,0,3.99,1),(2228,'Wall Art',12,'746851219795',14.99,'Wall Art',1,NULL,0,0,0,0,0,0,14.99,1),(2229,'Benromach 10 YearScotch',12,'747020192413',63.99,'Benromach 10 YearScotch',7,1,0,0,0,0,0,0,55.99,1),(2230,'6 Piece Cheese Hosting Set',12,'747552300676',19.99,'6 Piece Cheese Hosting Set',1,NULL,0,0,0,0,0,0,19.99,1),(2231,'Wine Marker',12,'747585306126',5.99,'Wine Marker',1,NULL,0,0,0,0,0,0,5.99,1),(2232,'Petit chapeau Bordeaux',21,'747736472458',13.99,'Petit chapeau Bordeaux',5,1,0,0,0,0,2,0,10,12),(2233,'Hakutsuru Sake',22,'747846010144',13.99,'Hakutsuru Sake',5,1,0,0,0,0,2,0,8.25,12),(2234,'Wine Diamonds DVD',12,'748252054036',9.99,'Wine Diamonds DVD',1,NULL,0,0,0,0,0,0,9.99,1),(2235,'Saracco Moscoato D\'Atsi',12,'748789705012',17.99,'Saracco Moscoato D\'Atsi',5,1,0,0,0,0,2,0,17.99,12),(2236,'Enrico Serafino Gavi de Gavi 2017',11,'748789740136',18.99,'Enrico Serafino Gavi de Gavi 2017',5,1,0,0,0,0,2,0,13.5,12),(2237,'Gemware',12,'749258700101',7.99,'Gemware',1,NULL,0,0,0,0,0,0,7.99,1),(2238,'Cakebread Chardonnay',13,'749826763668',49.99,'Cakebread Chardonnay',5,1,0,0,0,0,2,0,38,12),(2239,'Don Nacho Extra Premium Tequila',12,'7502219450346',49.99,'Don Nacho Extra Premium Tequila',7,NULL,0,0,0,0,0,0,49.99,1),(2240,'Sotol Silver Tequila',12,'7503013018077',52.75,'Sotol Silver Tequila',7,1,0,0,0,0,0,0,52.75,1),(2241,'Cupreata Machetazo Mezcal',12,'7503018511207',48.99,'Cupreata Machetazo Mezcal',7,1,0,0,0,0,0,0,48.99,1),(2242,'Clean Slate',12,'750625653012',9.99,'Clean Slate',5,1,0,0,0,0,2,0,9.99,12),(2243,'Big Grove Summer Jam 4pack',12,'752830090583',10.99,'Big Grove Summer Jam 4pack',6,4,0,0,0,0,0,0,7.5,1),(2244,'Big Grove Easy Eddie',1,'752830090880',13.99,'Big Grove Easy Eddie',6,NULL,0,0,0,0,0,0,9,1),(2245,'Big Grove IPA',12,'752830777163',12.99,'Big Grove IPA',6,6,0,0,0,0,0,0,12.99,1),(2246,'FireSteed Riesling',12,'753526300009',12.99,'FireSteed Riesling',5,1,0,0,0,0,2,0,12.99,12),(2247,'Fat Tire',12,'754527000219',10.99,'Fat Tire',6,6,0,0,0,0,0,0,10.99,1),(2248,'Fat Tire 6 pack',12,'754527000226',10.5,'Fat Tire 6 pack',6,6,0,0,0,0,0,0,10.5,1),(2249,'Invitations',12,'755979145619',0.35,'Invitations',1,NULL,0,0,0,0,0,0,0.35,1),(2250,'Invitations',12,'755979145657',0.35,'Invitations',1,NULL,0,0,0,0,0,0,0.35,1),(2251,'Napkins',12,'758347909240',3.99,'Napkins',1,NULL,0,0,0,0,0,0,3.99,1),(2252,'Lion Bridge Compensation English Ale 6 pack',17,'758913883349',12.99,'Lion Bridge Compensation English Ale 6 pack',6,6,0,0,0,0,0,0,8.75,1),(2253,'Ball Buster, The',12,'760999989037',21.99,'Ball Buster, The',5,1,0,0,0,0,2,0,21.99,12),(2254,'Reuilly \"Les Pierre\'s Plates\"',12,'761503442444',19.99,'Reuilly \"Les Pierre\'s Plates\"',5,1,0,0,0,0,2,0,19.99,12),(2255,'Borsao Garnacha 2018',13,'763159120035',11.99,'Borsao Garnacha',5,1,0,0,0,0,2,0,6.75,12),(2256,'Jubelale Winter Ale',12,'763176800019',1.99,'Jubelale Winter Ale',6,1,0,0,0,0,0,0,1.99,1),(2257,'Alvear',12,'766238809777',29.75,'Alvear',5,1,0,0,0,0,2,0,29.75,12),(2258,'Bottle Box',12,'767014303731',6.99,'Bottle Box',1,NULL,0,0,0,0,0,0,6.99,1),(2259,'Stump Jump GSM',12,'767749002275',12.99,'Stump Jump GSM',5,1,0,0,0,0,2,0,12.99,12),(2260,'The Stump Jump White',12,'767749002282',12.99,'The Stump Jump White',5,1,0,0,0,0,2,0,12.99,12),(2261,'Stump Jump Riesling',12,'767749002602',12.99,'Stump Jump Riesling',5,1,0,0,0,0,2,0,12.99,12),(2262,'Silver Palm Cabernet Sauvignon',13,'768035203000',20.99,'Silver Palm Cabernet Sauvignon',5,1,0,0,0,0,2,0,12.75,12),(2263,'Silver Palm Merlot',12,'768035203079',17.99,'Silver Palm Merlot',5,1,0,0,0,0,2,0,17.99,12),(2264,'King Estate Pinot Gris',12,'768675960127',20.99,'King Estate Pinot Gris',5,1,0,0,0,0,2,0,20.99,12),(2265,'Le Cigare Volant',12,'769434103267',35.75,'Le Cigare Volant',5,1,0,0,0,0,2,0,35.75,12),(2266,'Casa Rivas carmenerr',12,'7809558500245',14.99,'Casa Rivas carmenerr',5,1,0,0,0,0,2,0,14.99,12),(2267,'Antiyal chili red blend',12,'7809590500012',49.99,'Antiyal chili red blend',5,1,0,0,0,0,2,0,49.99,12),(2268,'On the Border Chips',12,'781138710176',5.99,'On the Border Chips',4,NULL,1,0,0,0,0,0,5.99,1),(2269,'Choya Umeshu Plum Wine Osaka Japan',11,'781682114024',15.99,'Choya Umeshu plum wine',5,1,0,0,0,0,2,0,11.25,12),(2270,'Cat Bottle Reisling',22,'784255600085',15.99,'Cat Bottle Reisling',5,1,0,0,0,0,2,0,11,12),(2271,'Moselland Arsvitis Riesling Castle Scene',22,'784255600092',15.99,'Moselland Arsvitis Riesling',5,1,0,0,0,0,2,0,11.25,12),(2272,'Book, White Wine for Dummies',12,'785555550117',12.99,'Book, White Wine for Dummies',1,NULL,0,0,0,0,0,0,12.99,1),(2273,'Book, Red wine for Dummies',12,'785555550124',14.99,'Book, Red wine for Dummies',1,NULL,0,0,0,0,0,0,14.99,1),(2274,'Book, Wine for Dummies',12,'785555862944',21.99,'Book, Wine for Dummies',1,NULL,0,0,0,0,0,0,21.99,1),(2275,'Stella Artois 6 Pack',1,'786150000014',10.99,'Stella Artois 6 Pack',6,6,0,0,0,0,0,0,7.75,1),(2276,'Stella Artois',12,'786150000021',42,'Stella Artois',6,NULL,0,0,0,0,0,0,42,1),(2277,'Stella Artois',12,'786150000052',10.5,'Stella Artois',6,6,0,0,0,0,0,0,10.5,1),(2278,'Leffe Blonde Ale 6 pack',12,'786150000304',10.99,'Leffe Blonde Ale 6 pack',6,6,0,0,0,0,0,0,10.99,1),(2279,'Heavy Weights Beer Bag',12,'786309131354',1.99,'Heavy Weights Beer Bag',1,NULL,0,0,0,0,0,0,1.99,1),(2280,'Winelight',12,'787812678909',10.99,'Winelight',1,NULL,0,0,0,0,0,0,10.99,1),(2281,'Yeti Imperial Stout',19,'790586130122',14.99,'Yeti Imperial Stout',6,NULL,0,0,0,0,0,0,10.5,1),(2282,'Fliptop Pourer',12,'79094726',3.75,'Fliptop Pourer',1,NULL,0,0,0,0,0,0,3.75,1),(2283,'Wine Bag',12,'790979130517',3.99,'Wine Bag',1,NULL,0,0,0,0,0,0,3.99,1),(2284,'Wine Tasting Party Kit',12,'790979190801',14.99,'Wine Tasting Party Kit',1,NULL,0,0,0,0,0,0,14.99,1),(2285,'Double Hinge Corkscrew',12,'790979264922',9.99,'Double Hinge Corkscrew',1,NULL,0,0,0,0,0,0,9.99,1),(2286,'Pourer',21,'790979266582',3.75,'Pourer',1,NULL,0,0,0,0,0,0,2,1),(2287,'Our Daily Red',10,'791784901736',13.99,'Our Daily Red',5,1,0,0,0,0,2,0,9.99,12),(2288,'Brady Vineyards Petite Sirah',12,'793573145239',23.99,'Brady Vineyards Petite Sirah',5,1,0,0,0,0,2,0,23.99,12),(2289,'Roller Dam Red 4 Pack',12,'793573765147',13.99,'Roller Dam Red 4 Pack',6,4,0,0,0,0,0,0,13.99,1),(2290,'Left Hand Milk Stout 6 pack',12,'793866360028',10.99,'Left Hand Milk Stout 6 pack',6,6,0,0,0,0,0,0,10.99,1),(2291,'Koko Brown',12,'796030314995',10.99,'Koko Brown',6,NULL,0,0,0,0,0,0,10.99,1),(2292,'The Other White Blend',12,'796238020018',13.99,'The Other White Blend',5,1,0,0,0,0,2,0,13.99,12),(2293,'Book, Wine with CD',12,'797307137309',12.99,'Book, Wine with CD',1,NULL,0,0,0,0,0,0,12.99,1),(2294,'Wine Journal (Purple)',12,'797307151602',3.99,'Wine Journal (Purple)',1,NULL,0,0,0,0,0,0,2,1),(2295,'Cards, Wines of world',12,'797307151701',2.99,'Cards, Wines of world',1,NULL,0,0,0,0,0,0,2.99,1),(2296,'Hat, Weekend',12,'797642747676',11.99,'Hat, Weekend',1,NULL,0,0,0,0,0,0,11.99,1),(2297,'Scout\'s Honor',12,'798304041934',38.99,'Scout\'s Honor',5,1,0,0,0,0,2,0,38.99,12),(2298,'Ace Pearry hard Cider',1,'798449002111',11.99,'Ace Pearry hard Cider',6,NULL,0,0,0,0,0,0,8,1),(2299,'Ace Pineapple Cider',1,'798449008113',13.99,'Ace Pineapple Cider',6,NULL,0,0,0,0,0,0,9.42,1),(2300,'Gift Bag',12,'799227263694',2.99,'Gift Bag',1,NULL,0,0,0,0,0,0,2.99,1),(2301,'DeLille D2 Red',21,'799419020128',45.99,'DeLille D2 Red',5,1,0,0,0,0,2,0,35,12),(2302,'Benvolio Pinot Grigio Fruili Italy 2017',10,'799987003004',11.99,'Benvolio Pinot Grigio Fruili Italy 2017',5,1,0,0,0,0,2,0,9,12),(2303,'Giancarlo Montepulciano',12,'8000128193020',11.99,'Giancarlo Montepulciano',5,1,0,0,0,0,2,0,11.99,12),(2304,'Bormioli Limoncino Glass 3 pcs',12,'8004360025309',12.99,'Bormioli Limoncino Glass 3 pcs',1,NULL,0,0,0,0,0,0,12.99,1),(2305,'UV Blue Vodka 1 L',12,'8007776074473',16.75,'UV Blue Vodka 1 L',7,1,0,0,0,0,0,0,16.75,1),(2306,'Stefano Farina Moscato d\'Asti',11,'8008366221789',16.99,'Stefano Farina Moscato d\'Asti',5,1,0,0,0,0,2,0,12,12),(2307,'Alasia',12,'8010471000586',13.99,'Alasia',5,1,0,0,0,0,2,0,13.99,12),(2308,'Ranieri Grape Seed Oil',12,'8018154004296',9.99,'Ranieri Grape Seed Oil',4,NULL,1,0,0,0,0,0,9.99,1),(2309,'Barone di Valforte Montepulciano',12,'8033413001090',16.99,'Barone di Valforte Montepulciano',5,1,0,0,0,0,2,0,16.99,12),(2310,'Le Monde',12,'8034013470064',19.99,'Le Monde',5,1,0,0,0,0,2,0,19.99,12),(2311,'Beer Chiller',21,'804879436676',18.99,'Beer Chiller',1,NULL,0,0,0,0,0,0,18.99,1),(2312,'Book End',12,'805572120503',12.99,'Book End',1,NULL,0,0,0,0,0,0,12.99,1),(2313,'Bottle Bag',12,'806008662321',1.75,'Bottle Bag',1,NULL,0,0,0,0,0,0,1.75,1),(2314,'Altos Las Hormigas Mendoza Malbec',12,'806145000109',79.99,'Altos Las Hormigas Mendoza Malbec',5,1,0,0,0,0,2,0,79.99,12),(2315,'Corona Extra Lager single',12,'8066145',2.99,'Corona Extra Lager single',6,1,0,0,0,0,0,0,2.99,1),(2316,'Wall Art',12,'807472051567',27.99,'Wall Art',1,NULL,0,0,0,0,0,0,27.99,1),(2317,'Decorative Wine Cover',12,'808990027720',3.99,'Decorative Wine Cover',1,NULL,0,0,0,0,0,0,3.99,1),(2318,'Pseudo Sue Pale',12,'810458030647',3.99,'Pseudo Sue Pale',6,1,0,0,0,0,0,0,3.99,1),(2319,'Richard Grant Pinot Noir',12,'81050031',32.99,'Richard Grant Pinot Noir',5,1,0,0,0,0,2,0,32.99,12),(2320,'Nautica',21,'810537021153',16.99,'Nautica',5,1,0,0,0,0,2,0,15,12),(2321,'Exile Bohemian Fruit Revue Sour Ale',12,'810631030020',10.99,'Exile Bohemian Fruit Revue Sour Ale',6,6,0,0,0,0,0,0,10.99,1),(2322,'Van Ruiten Pinot Grigio',12,'810845004008',13.99,'Van Ruiten Pinot Grigio',5,1,0,0,0,0,2,0,13.99,12),(2323,'Van Ruiten Shiraz',12,'810845005364',24.99,'Van Ruiten Shiraz',5,1,0,0,0,0,2,0,24.99,12),(2324,'Charles Baur Cremant D\'Alsace',6,'811416001808',22.99,'Charles Baur Cremant D\'Alsace',5,1,0,0,0,0,2,0,14.5,12),(2325,'Baur Alsace Riesling 2015',6,'811416007022',18.99,'Baur Alsace Riesling 2015',5,1,0,0,0,0,2,0,13,12),(2326,'1800 Silver Mini 50ml',10,'811538010115',4.99,'1800 Silver Mini 50ml',7,NULL,0,0,0,0,0,0,3.51,1),(2327,'1800 Reposado Tequila',12,'811538010238',33.47,'1800 Reposado Tequila',7,1,0,0,0,0,0,0,33.47,1),(2328,'Jose Cuervo Especial 1 L',12,'811538010801',28.3,'Jose Cuervo Especial 1 L',7,1,0,0,0,0,0,0,28.3,1),(2329,'Jose Cuervo Silver 1 L',12,'811538010825',28.3,'Jose Cuervo Silver 1 L',7,1,0,0,0,0,0,0,28.3,1),(2330,'Jose Cuervo Silver 750ml',18,'811538010856',24.99,'jose Cuervo Silver 750ml',7,NULL,0,0,0,0,0,0,17.61,1),(2331,'Jose Cuervo Gold 50ml',18,'811538010948',2.75,'Jose Cuervo Gold 50ml',7,NULL,0,0,0,0,0,0,2.75,1),(2332,'Jose Cuervo Golden Margarita 1.75 L',12,'811538010962',24.18,'Jose Cuervo Golden Margarita 1.75 L',7,1,0,0,0,0,0,0,24.18,1),(2333,'Jose Cuervo Margarita Mix 1Liter',10,'811538011211',4.99,'Jose Cuervo Margarita Mix 1Liter',2,NULL,0,0,0,0,0,0,3.5,1),(2334,'Tin Cup Whiskey',12,'811538011877',28.99,'Tin Cup Whiskey',7,1,0,0,0,0,0,0,28.99,1),(2335,'Jose Cuervo Coconut-Pineapple Marharita',18,'811538012836',19.99,'Jose Cuervo Coconut-Pineapple Marharita',7,1,0,0,0,0,0,0,13.61,1),(2336,'Jose Cuervo',12,'811538013307',9.99,'Jose Cuervo',6,4,0,0,0,0,0,0,9.99,1),(2337,'Bushmills Irish Whiskey',10,'811538016155',37.99,'Bushmills Irish Whiskey',7,NULL,0,0,0,0,0,0,26.88,1),(2338,'Bushmills Irish Whiskey 750ml',18,'811538016162',30.99,'Bushmills Irish Whiskey 750ml',7,NULL,0,0,0,0,0,0,21.75,1),(2339,'1800 Watermelon Margarita 1.75L',18,'811538016445',22.99,'1800 Watermelon Margarita 1.75 L',7,1,0,0,0,0,0,0,16.06,1),(2340,'Jose Cuervo Rose Margarita 1.75 L',12,'811538018760',24.99,'Jose Cuervo Rose Margarita 1.75 L',5,1,0,0,0,0,2,0,24.99,12),(2341,'1800 Ultimate Margarita',10,'811538019156',22.99,'1800 Ultimate Margarita',7,NULL,0,0,0,0,0,0,16.06,1),(2342,'Stoli Razberi 1 Liter',10,'811751020441',34.54,'Stoli Razberi 1 Liter',7,NULL,0,0,0,0,0,0,25,1),(2343,'Stoli Mini Lime Vodka 50ml',18,'811751022896',1.99,'Stoli Mini Lime Vodka 50ml',7,NULL,0,0,0,0,0,0,1.2,1),(2344,'Macallan 12 Year Double Cask',12,'812066021598',66.99,'Macallan 12 Year Double Cask',7,1,0,0,0,0,0,0,66.99,1),(2345,'Bird Dog Peach Whiskey 50ml',18,'812459010697',1.99,'Bird Dog Peach Whiskey 50ml',7,NULL,0,0,0,0,0,0,1.15,1),(2346,'Bird Dog Peach Whiskey',18,'812459014251',22.99,'Bird Dog Peach Whiskey',7,NULL,0,0,0,0,0,0,16,1),(2347,'Olli Genoa Mild Salame',12,'813039020204',2.99,'Olli Genoa Mild Salame',4,NULL,1,0,0,0,0,0,2.99,1),(2348,'Wine Glass, Therapy',12,'813293024048',2.99,'Wine Glass, Therapy',6,NULL,0,0,0,0,0,0,2.99,1),(2349,'Beer Glass',12,'813293024642',2.99,'Beer Glass',1,NULL,0,0,0,0,0,0,2.99,1),(2350,'Wine Glass, Breakfast',12,'813293026066',2.99,'Wine Glass, Breakfast',1,NULL,0,0,0,0,0,0,2.99,1),(2351,'Shot Glass',12,'813293026721',2.99,'Shot Glass',1,NULL,0,0,0,0,0,0,2.99,1),(2352,'Cody The Frog',12,'813387012548',4.99,'Cody The Frog',1,NULL,0,0,0,0,0,0,4.99,1),(2353,'Zorzal Gran Terroir Pinot Noir',12,'813495010771',22.99,'Zorzal Gran Terroir Pinot Noir',5,1,0,0,0,0,2,0,22.99,12),(2354,'Bumbu Rum',18,'813497006109',39.99,'Bumbu Rum',7,NULL,0,0,0,0,0,0,28.35,1),(2355,'Savvi Serve Shot Glass 50 ct',12,'813515010859',3.99,'Savvi Serve Shot Glass 50 ct',1,NULL,0,0,0,0,0,0,3.99,1),(2356,'Finca El Origen',12,'813942010552',14.99,'Finca El Origen',5,1,0,0,0,0,2,0,14.99,12),(2357,'Woozie',12,'814001019110',5.99,'Woozie',1,NULL,0,0,0,0,0,0,5.99,1),(2358,'Luna Sangiovese',12,'814617002001',18.99,'Luna Sangiovese',5,1,0,0,0,0,2,0,20.99,12),(2359,'Luna Merlot',12,'814617003008',20.99,'Luna Merlot',5,1,0,0,0,0,2,0,20.99,12),(2360,'Asylum Zin',12,'814617007037',16.99,'Asylum Zin',5,1,0,0,0,0,2,0,16.99,12),(2361,'Luna Cabernet Sauvignon',12,'814617009307',20.99,'Luna Cabernet Sauvignon',5,1,0,0,0,0,2,0,20.99,12),(2362,'Jefferson\'s Ocean Aged at Sea',10,'814794010646',89.99,'Jefferson\'s Ocean Aged at Sea',7,NULL,0,0,0,0,0,0,63.75,1),(2363,'Masi Brolo Campfiorin',21,'815132010083',34.99,'Masi Brolo Campfiorin',5,1,0,0,0,0,2,0,22,12),(2364,'Czechvar Lager',12,'815833002004',10.99,'Czechvar Lager',6,6,0,0,0,0,0,0,10.99,1),(2365,'Czechvar Lager 6 pack',1,'815833002028',10.99,'Czechvar Lager 6 pack',6,6,0,0,0,0,0,0,8.75,1),(2366,'EQ Pinot Noir',12,'815992010025',41.99,'EQ Pinot Noir',5,1,0,0,0,0,2,0,41.99,12),(2367,'EQ Sauvignon Blanc',12,'815992010070',16.99,'EQ Sauvignon Blanc',5,1,0,0,0,0,2,0,16.99,12),(2368,'The Corker Dessert Wine',14,'817421001093',11.99,'The Corker Dessert Wine',5,1,0,0,0,0,2,0,6,12),(2369,'Smashberry Red Blend',12,'818013010257',13.99,'Smashberry Red Blend',5,1,0,0,0,0,2,0,13.99,12),(2370,'Smashberry white blend',12,'818013010448',13.99,'Smashberry white blend',5,1,0,0,0,0,2,0,13.99,12),(2371,'Terre Rouge Syrah',12,'8187114',39.99,'Terre Rouge Syrah',5,1,0,0,0,0,2,0,39.99,12),(2372,'Mosketto',12,'819046010122',12.5,'Mosketto',5,1,0,0,0,0,2,0,12.5,12),(2373,'Holy Grail Amber Ale',12,'819538005131',2.99,'Holy Grail Amber Ale',6,1,0,0,0,0,0,0,2.99,1),(2374,'Jeremiah Weed 1 L',12,'8220408',0,'Jeremiah Weed 1 L',7,1,0,0,0,0,0,0,0,1),(2375,'Book, Guide to Wine',12,'824921003540',12.99,'Book, Guide to Wine',1,NULL,0,0,0,0,0,0,12.99,1),(2376,'Balletto Syrah',12,'826498081600',29.99,'Balletto Syrah',5,1,0,0,0,0,2,0,29.99,12),(2377,'Robert Hall rose de Robles',12,'830949000126',9.99,'Robert Hall rose de Robles',5,1,0,0,0,0,2,0,9.99,12),(2378,'The Crusher Pinot Noir 2017',8,'833302001655',14.99,'The Crusher Pinot Noir 2017',5,1,0,0,0,0,2,0,9,12),(2379,'Big Smooth Zinfandel',12,'833302005363',16.99,'Big Smooth Zinfandel',5,1,0,0,0,0,2,0,16.99,12),(2380,'Big Smooth Cabernet Sauvignon',12,'833302005387',16.99,'Big Smooth Cabernet Sauvignon',5,1,0,0,0,0,2,0,16.99,12),(2381,'Absolute Vodka 50ml',12,'835229000001',2.99,'Absolute Vodka 50ml',3,NULL,0,0,0,0,0,0,2.99,1),(2382,'Absolut Vodka 375ml',18,'835229000209',11.99,'Absolut Vodka 375ml',7,NULL,0,0,0,0,0,0,7.79,1),(2383,'Absolute Vodka 1 L',12,'835229000407',32.49,'Absolute Vodka 1 L',7,1,0,0,0,0,0,0,32.49,1),(2384,'Absolute Wild Tea 50ml',12,'835229000742',2.99,'Absolute Wild Tea 50ml',7,NULL,0,0,0,0,0,0,2.99,1),(2385,'small vodka',12,'835229001039',2.99,'small vodka',7,NULL,0,0,0,0,0,0,2.99,1),(2386,'Absolut Citron 1 Liter',18,'835229001404',32.99,'Absolut Citron 1 Liter',7,NULL,0,0,0,0,0,0,22.99,1),(2387,'Absolut Mandrin Vodka 50ml',12,'835229002005',2.99,'Absolut Mandrin Vodka 50ml',7,NULL,0,0,0,0,0,0,2.99,1),(2388,'Glenfiddich 12 Year Scotch',12,'8361073',49.26,'Glenfiddich 12 Year Scotch',7,1,0,0,0,0,0,0,49.26,1),(2389,'Cigar Zinfandel',12,'839146005903',16.5,'Cigar Zinfandel',5,1,0,0,0,0,2,0,16.5,12),(2390,'Frescobaldi remole Toscana 2017',13,'839183000183',13.99,'Frescobaldi remole Toscana 2017',5,1,0,0,0,0,2,0,9.75,12),(2391,'Rhinestone Words',12,'840341541332',2.99,'Rhinestone Words',1,NULL,0,0,0,0,0,0,2.99,1),(2392,'Wine Journal',12,'840341660781',2.75,'Wine Journal',1,NULL,0,0,0,0,0,0,2.75,1),(2393,'Photo Album',12,'840663000579',2.99,'Photo Album',1,NULL,0,0,0,0,0,0,2.99,1),(2394,'Battle hill single malt Scotch 22 year',12,'841119013068',128.99,'Battle hill single malt Scotch 22 year',7,1,0,0,0,0,0,0,128.99,1),(2395,'Invitations',12,'841769098323',1.99,'Invitations',1,NULL,0,0,0,0,0,0,1.99,1),(2396,'Wine Journal',12,'841769098330',2.99,'Wine Journal',1,NULL,0,0,0,0,0,0,2.99,1),(2397,'Insulated Tote, 2 Bottle',12,'842094158119',4.99,'Insulated Tote, 2 Bottle',1,NULL,0,0,0,0,0,0,4.99,1),(2398,'Tremenda 2017',13,'8424671001265',15.99,'Tremenda 2016',5,1,0,0,0,0,2,0,9.92,12),(2399,'Trophy Bottle Opener',12,'843479150278',12.99,'Trophy Bottle Opener',1,NULL,0,0,0,0,0,0,12.99,1),(2400,'Pruno',12,'8437005373099',20.99,'Pruno',5,1,0,0,0,0,2,0,20.99,12),(2401,'Romanico Tempranillo',12,'8437010272318',16.99,'Romanico Tempranillo',5,1,0,0,0,0,2,0,16.99,12),(2402,'Garnacha de Fuego',12,'8437012538016',10.99,'Garnacha de Fuego',5,1,0,0,0,0,2,0,10.99,12),(2403,'Casa Santos El Goru Red Blend',14,'8437013527057',14.99,'Casa Santos El Goru Red Blend',5,1,0,0,0,0,2,0,9,12),(2404,'Harken Chardonnay 2018',13,'847159001812',15.99,'Harken Chardonnay 2018',5,1,0,0,0,0,2,0,9.75,12),(2405,'Tub, Oval Hammered',12,'848202000561',13.99,'Tub, Oval Hammered',1,NULL,0,0,0,0,0,0,13.99,1),(2406,'House Wine Chardonnay 375ml',12,'848375004564',6.99,'House Wine Chardonnay 375ml',5,1,0,0,0,0,2,0,6.99,12),(2407,'House wine Red Blend 375ml',12,'848375004588',6.99,'House wine Red Blend 375ml',5,1,0,0,0,0,2,0,6.99,12),(2408,'House wine Rose Bubbles 375ml',12,'848375004991',6.99,'House wine Rose Bubbles 375ml',5,1,0,0,0,0,2,0,6.99,12),(2409,'Crabbies Ginger Beer',19,'848557000001',9.99,'Crabbies Ginger Beer',6,NULL,0,0,0,0,0,0,6.75,1),(2410,'Crabbies Raspberry',19,'848557000094',11.99,'Crabbies Raspberry',6,NULL,0,0,0,0,0,0,9,1),(2411,'Shatter Grenache',19,'848656000018',23.99,'Shatter Grenache',5,1,0,0,0,0,2,0,18,12),(2412,'Angel\'s Envy Port Finished Bourbon',18,'850047003003',52.99,'Angel\'s Envy Port Finished Bourbon',7,NULL,0,0,0,0,0,0,37.25,1),(2413,'Domaine De Couron Cote du Rhone',12,'850189004005',14.99,'Domaine De Couron Cote du Rhone',5,1,0,0,0,0,2,0,14.99,12),(2414,'Hell Hound Red blend',12,'850432006022',23,'Hell Hound Red blend',5,1,0,0,0,0,2,0,23,12),(2415,'Sola Pinot Noir',12,'850440002849',15.5,'Sola Pinot Noir',5,1,0,0,0,0,2,0,15.5,12),(2416,'Book',12,'850440005208',3.99,'Book',1,NULL,0,0,0,0,0,0,3,1),(2417,'Glen Garioch',12,'850483000901',145.99,'Glen Garioch',7,1,0,0,0,0,0,0,145.99,1),(2418,'Exile Ruthie Gold Lager 6-pack',1,'850992005015',10.99,'Exile Ruthie Gold Lager 6-pack',6,NULL,0,0,0,0,0,0,8,1),(2419,'Exile Hannah Bavarian Wheat',12,'850992005039',1.99,'Exile Hannah Bavarian Wheat',6,1,0,0,0,0,0,0,1.99,1),(2420,'Exile Hannah Bavarian Wheat 6 Pack',1,'850992005046',10.99,'Exile Hannah Bavarian Wheat 6 Pack',6,6,0,0,0,0,0,0,10.99,1),(2421,'Exile Beatnik Sour Ale 6 pack',12,'850992005237',12.99,'Exile Beatnik Sour Ale 6 pack',6,6,0,0,0,0,0,0,12.99,1),(2422,'Fre Bru alcohol free',12,'8510527',13.99,'Fre Bru alcohol free',5,1,0,0,0,0,2,0,13.99,12),(2423,'Pisa Liqeur',12,'851066003661',27.99,'Pisa Liqeur',7,1,0,0,0,0,0,0,27.99,1),(2424,'Cristo Syrah',12,'851573001136',22.99,'Cristo Syrah',5,1,0,0,0,0,2,0,22.99,12),(2425,'White Wine Vinegar',12,'851609006012',3.99,'White Wine Vinegar',4,NULL,1,0,0,0,0,0,3.99,1),(2426,'Lucky Buddha Single Beer',1,'851626003001',2.75,'Lucky Buddha Single Beer',6,NULL,0,0,0,0,0,0,1.75,1),(2427,'Lucky Buddha 6 pack',19,'851626003018',13.99,'Lucky Buddha 6 pack',6,6,0,0,0,0,0,0,9.75,1),(2428,'Locations Italy',12,'851645004096',18.99,'Locations Italy',5,1,0,0,0,0,2,0,18.99,12),(2429,'Locations E',12,'851645004126',18.99,'Locations E',5,1,0,0,0,0,2,0,18.99,12),(2430,'Slices White Sangria',14,'851675003519',8.99,'Slices White Sangria',5,1,0,0,0,0,2,0,5.5,12),(2431,'Q Tonic Water 4-pack',16,'851694003606',6.99,'Q Tonic Water 4-pack',2,NULL,0,0,0,0,0,0,3.96,1),(2432,'Butternut',19,'851919004005',18.99,'Butternut',5,1,0,0,0,0,2,0,12,12),(2433,'Richard Grant Pinot Noir',12,'852024001828',42,'Richard Grant Pinot Noir',5,1,0,0,0,0,2,0,42,12),(2434,'Ammunition Chardonnay',19,'852116005161',17.99,'Ammunition Chardonnay',5,1,0,0,0,0,2,0,11.51,12),(2435,'Slingshot Dunkel',12,'852131004002',10.99,'Slingshot Dunkel',6,6,0,0,0,0,0,0,10.99,1),(2436,'Slingshot Dunkel 6 pack',1,'852131004040',9.99,'Slingshot Dunkel 6 pack',6,6,0,0,0,0,0,0,7,1),(2437,'Gold Coin',12,'852131004057',10.99,'Gold Coin',6,NULL,0,0,0,0,0,0,10.99,1),(2438,'Raygun IPA',12,'852131004149',10.99,'Raygun IPA',6,6,0,0,0,0,0,0,10.99,1),(2439,'Murderhorn Belgian Ale 6 pack',1,'852131004347',11.99,'Murderhorn Belgian Ale 6 pack',6,6,0,0,0,0,0,0,7.99,1),(2440,'Murderhorn Golden Ale',12,'852131004354',10.99,'Murderhorn Golden Ale',6,6,0,0,0,0,0,0,10.99,1),(2441,'Raygun IPA 6 Pack',12,'852131004415',11.99,'Raygun IPA 6 Pack',6,6,0,0,0,0,0,0,7.99,1),(2442,'Chateau Godeau Saint-Emilion Grand cru',12,'852187012808',34.99,'Chateau Godeau Saint-Emilion Grand cru',5,1,0,0,0,0,2,0,34.99,12),(2443,'Hannah Nicole Zinfandel',12,'852195001146',12.99,'Hannah Nicole Zinfandel',5,1,0,0,0,0,2,0,12.99,12),(2444,'Dorothy\'s Lager 4 pack',12,'852211003277',10.99,'Dorothy\'s Lager 4 pack',6,4,0,0,0,0,0,0,10.99,1),(2445,'Pseudo Sue Pale Ale 4 Pack',19,'852211003321',11.99,'Pseudo Sue Pale Ale 4 Pack',6,4,0,0,0,0,0,0,9,1),(2446,'Toppling Goliath King Sue 4-Pack',19,'852211003697',19.99,'Toppling Goliath King Sue 4-Pack',6,NULL,0,0,0,0,0,0,14.25,1),(2447,'Zolo Malbec',12,'852282002162',14.99,'Zolo Malbec',5,1,0,0,0,0,2,0,14.99,12),(2448,'Zolo Merlot',12,'852282002179',12.99,'Zolo Merlot',5,1,0,0,0,0,2,0,12.99,12),(2449,'GEN5',21,'852282002803',12.99,'Gen 5 Cabernet Sauvignon',5,1,0,0,0,0,2,0,9,12),(2450,'Press Pomegranate Ginger Single',1,'852313004387',2.75,'Press Pomegranate Ginger Single',6,NULL,0,0,0,0,0,0,1.35,1),(2451,'Press Blackberry Hibiscus Single Can',1,'852313004530',1.99,'Press Blackberry Hibiscus Single Can',6,NULL,0,0,0,0,0,0,1.5,1),(2452,'Press Lemongrass Single',1,'852313004547',2.75,'Press Lemongrass Single',6,NULL,0,0,0,0,0,0,1.35,1),(2453,'Press 12-Pack',1,'852313004837',19.99,'Press 12-Pack',6,NULL,0,0,0,0,0,0,14.1,1),(2454,'Press Blackberry Hibiscus 6-Pack',1,'852313004844',11.99,'Press Blackberry Hibiscus 6-Pack',6,NULL,0,0,0,0,0,0,7.4,1),(2455,'Wilson\'s Orchard Spiced Up Cider 4 Pack',1,'852380004143',9.99,'Wilson\'s Orchard Spiced Up Cider 4 Pack',6,4,0,0,0,0,0,0,7.99,1),(2456,'Wilson\'s Orchard Cherry Crush 4-pack',19,'852380004167',11.99,'Wilson\'s Orchard Cherry Crush 4-pack',6,NULL,0,0,0,0,0,0,8.25,1),(2457,'Wilson\'s Orchard Peach Fizz single',12,'852380004198',2.99,'Wilson\'s Orchard Peach Fizz single',6,1,0,0,0,0,0,0,2.99,1),(2458,'Wilson Orchard Peach Fizz 4 Pack',12,'852380004204',11.75,'Wilson Orchard Peach Fizz 4 Pack',6,4,0,0,0,0,0,0,11.75,1),(2459,'Wilson\'s Orchard Old Blue 4 Pack',19,'852380004211',11.99,'Wilson\'s Orchard Old Blue 4 Pack',6,4,0,0,0,0,0,0,8.5,1),(2460,'Wilson\'s Orchard Old Blue Blueberry Cider',12,'852380004228',1.99,'Wilson\'s Orchard Old Blue Blueberry Cider',6,1,0,0,0,0,0,0,1.99,1),(2461,'Sutliff Cider 6 Pack',1,'852380004266',12.99,'Sutliff Cider 6 Pack',6,6,0,0,0,0,0,0,9.63,1),(2462,'French Blue Bordeaux Rose',13,'852393005298',14.99,'French Blue Bordeaux Rose',5,1,0,0,0,0,2,0,6,12),(2463,'Hi ball Energy Wildberry Energy Water',12,'852421006341',0,'Hi ball Energy Wildberry Energy Water',15,1,0,0,0,0,0,0,0,1),(2464,'Gran Campo Viejo Caba Brut Rose',12,'852832105848',14.99,'Gran Campo Viejo Caba Brut Rose',5,1,0,0,0,0,2,0,14.99,12),(2465,'Helwig Round up Red',12,'853013003021',11.99,'Helwig Round up Red',5,1,0,0,0,0,2,0,11.99,12),(2466,'Hollen Family Cabernet',12,'853124003231',8.99,'Hollen Family Cabernet',5,1,0,0,0,0,2,0,11.99,12),(2467,'Forbidden Secret Darm Mocha 50ml',12,'853452003156',3.5,'Forbidden Secret Darm Mocha 50ml',7,NULL,0,0,0,0,0,0,3.5,1),(2468,'Butter Chardonnay',13,'853706002034',18.99,'Butter Chardonnay',5,1,0,0,0,0,2,0,13.5,12),(2469,'Joia Spirt Sparkling Greyhound 4 Pack',12,'853797003262',13.99,'Joia Spirt Sparkling Greyhound 4 Pack',6,4,0,0,0,0,0,0,13.99,1),(2470,'Tarima Hill',12,'853891002154',15.75,'Tarima Hill',5,1,0,0,0,0,2,0,15.75,12),(2471,'Tarima Monastrell',12,'853891002161',11.99,'Tarima Monastrell',5,1,0,0,0,0,2,0,11.99,12),(2472,'Spiked Seltzer',12,'853897002288',11.99,'Spiked Seltzer',6,6,0,0,0,0,0,0,11.99,1),(2473,'Spiked Seltzer Grapefruit 6 Pack',12,'853897002318',10.99,'Spiked Seltzer Grapefruit 6 Pack',6,6,0,0,0,0,0,0,10.99,1),(2474,'Repour',12,'854107007000',1.99,'Repour',1,NULL,0,0,0,0,0,0,2.5,1),(2475,'Repour 4pack',12,'854107007017',8.99,'Repour 4pack',1,NULL,0,0,0,0,0,0,8.99,1),(2476,'E&J Brandy 1 L',12,'8541800',0,'E&J Brandy 1 L',7,1,0,0,0,0,0,0,0,1),(2477,'Coravin Screw Caps',12,'854318006915',29.99,'Coravin Screw Caps',1,NULL,0,0,0,0,0,0,29.99,1),(2478,'High West Double Rye',12,'854396005008',44.99,'High West Double Rye',7,1,0,0,0,0,0,0,44.99,1),(2479,'High West Campfire',12,'854396005046',76.99,'High West Campfire',7,1,0,0,0,0,0,0,76.99,1),(2480,'High West American Prairie',18,'854396005220',48.99,'High West American Prairie',7,NULL,0,0,0,0,0,0,31.99,1),(2481,'High West Yippee Ki-Yay Whiskey',10,'854396005268',84.99,'High West Yippee Ki-Yay Whiskey',7,NULL,0,0,0,0,0,0,61,1),(2482,'Vinituri wine Aerator',12,'854397002006',43.99,'Vinituri wine Aerator',1,NULL,0,0,0,0,0,0,43.99,1),(2483,'Vinturi',12,'854397002150',14.99,'Vinturi',9,NULL,0,0,0,0,0,0,NULL,1),(2484,'Mary me bloody Mary Party Set',12,'854781004548',25.99,'Mary me bloody Mary Party Set',6,1,0,0,0,0,0,0,25.99,1),(2485,'Asparagus, Pickled',12,'855150002011',10.99,'Asparagus, Pickled',4,NULL,1,0,0,0,0,0,10.99,1),(2486,'Alli&Rose Dark Chocolate Pomegranate',12,'855378004125',1.49,'Alli&Rose Dark Chocolate Pomegranate',3,NULL,0,0,0,0,0,0,1.49,1),(2487,'Bricco Riella Moscato D\'Atsi',12,'855380003017',15.99,'Bricco Riella Moscato D\'Atsi',5,1,0,0,0,0,2,0,15.99,12),(2488,'Dot\'s Pretzels 5oz',16,'855712008000',5.75,'Dot\'s Pretzels',4,NULL,1,0,0,0,0,0,3.15,1),(2489,'Coaster Sliper',12,'856016001551',6.25,'Coaster Sliper',1,NULL,0,0,0,0,0,0,6.25,1),(2490,'Underwood The Bubbles',12,'856036001098',7.99,'Underwood The Bubbles',5,1,0,0,0,0,2,0,7.99,12),(2491,'Deep Eddy Ruby Red Vodka 50ml',12,'856065002110',1.99,'Deep Eddy Ruby Red Vodka 50ml',7,NULL,0,0,0,0,0,0,1.99,1),(2492,'Deep Eddy Cranberry Vodka 50ml',12,'856065002158',1.75,'Deep Eddy Cranberry Vodka 50ml',7,NULL,0,0,0,0,0,0,1.75,1),(2493,'Deep Eddy ruby red grapefruit vodka',12,'856065002974',19.99,'Deep Eddy ruby red grapefruit vodka',7,1,0,0,0,0,0,0,19.99,1),(2494,'Oak Farm Tievoli Lodi California Red Blend',14,'856065006071',16.99,'Oak Farm Tievoli Lodi California Red Blend',5,1,0,0,0,0,2,0,12,12),(2495,'Madame Mary Spicy Bloody Mary Mix 32oz',21,'856165004014',7.99,'Madame Mary Spicy Bloody Mary Mix 1 L',4,NULL,1,0,0,0,0,0,5.45,1),(2496,'Blonde Fatale Blonde Ale',12,'856411002184',13.99,'Blonde Fatale Blonde Ale',6,1,0,0,0,0,0,0,13.99,1),(2497,'Blonde Fatale Blonde Ale 6 Pack',17,'856411002191',13.99,'Blonde Fatale Blonde Ale 6 Pack',6,6,0,0,0,0,0,0,9.5,1),(2498,'Plungerhead Petite Sirah',12,'856442005536',14.99,'Plungerhead Petite Sirah',5,1,0,0,0,0,2,0,14.99,12),(2499,'Lily\'s 85% Dark Chocolate',12,'856481003883',4.99,'Lily\'s 85% Dark Chocolate',4,NULL,1,0,0,0,0,0,4.99,1),(2500,'Ocean Organic Vodka',12,'856695001002',30.99,'Ocean Organic Vodka',7,NULL,0,0,0,0,0,0,30.99,1),(2501,'Blue Chair Coconut Rum',12,'856881004015',20.99,'Blue Chair Coconut Rum',7,1,0,0,0,0,0,0,20.99,1),(2502,'Golden Road Melon Cart',12,'856895003950',13.99,'Golden Road Melon Cart',6,6,0,0,0,0,0,0,13.99,1),(2503,'Wine Sisterhood',12,'857151003387',8.99,'Wine Sisterhood',5,1,0,0,0,0,2,0,8.99,12),(2504,'Lindemann Gift Box',12,'8573810',25.99,'Lindemann Gift Box',6,1,0,0,0,0,0,0,25.99,1),(2505,'Elicio Grenache & Syrah',12,'857488005023',13.99,'Elicio Grenache & Syrah',5,1,0,0,0,0,2,0,13.99,12),(2506,'Chateaumar Cotes-Du-Rhone',12,'857488005535',15.99,'Chateaumar Cotes-Du-Rhone',5,1,0,0,0,0,2,0,15.99,12),(2507,'Bellula Rose',12,'857488005542',13.99,'Bellula Rose',5,1,0,0,0,0,2,0,13.99,12),(2508,'Aged Gouda',12,'857529006361',8.75,'Aged Gouda',4,NULL,1,0,0,0,0,0,6,1),(2509,'Gemma di Luna Pinot GrigioDelle Venezie',13,'857660004592',13.99,'Gemma di Luna Pinot GrigioDelle Venezie',5,1,0,0,0,0,2,0,9,12),(2510,'Shannon Ridge Petite Sirah',12,'857680001021',21.99,'Shannon Ridge Petite Sirah',5,1,0,0,0,0,2,0,21.99,12),(2511,'Steel Horse Sweet Ride',25,'858150004177',14.99,'Steel Horse Sweet Ride',5,1,0,0,0,0,2,0,9,12),(2512,'Wooden wheel leathers',25,'858150004207',14.99,'Wooden wheel leathers',5,1,0,0,0,0,2,0,8,12),(2513,'Wooden Wheel Zoom Sweet Rose',25,'858150004221',14.99,'Wooden Wheel Zoom Sweet Rose',5,1,0,0,0,0,2,0,9,12),(2514,'McCulley\'s Dessert Wine',12,'858150004238',13.99,'McCulley\'s Dessert Wine',5,1,0,0,0,0,2,0,13.99,12),(2515,'LED Lite Flite',12,'858201006013',9.99,'LED Lite Flite',1,NULL,0,0,0,0,0,0,9.99,1),(2516,'Crespini',12,'858218007874',2.99,'Crespini',4,NULL,1,0,0,0,0,0,2.99,1),(2517,'Dolcezze Sapori Crespini Bread Sticks',21,'858218007898',2.99,'Dolcezze Sapori Crespini Bread Sticks',2,NULL,0,0,0,0,0,0,1.25,1),(2518,'Coravin, 2 Capsules',12,'858976004023',17.95,'Coravin, 2 Capsules',1,NULL,0,0,0,0,0,0,17.95,1),(2519,'Coravin Model Two',12,'858976004665',296.99,'Coravin Model Two',1,NULL,0,0,0,0,0,0,296.99,1),(2520,'Coravin Faster Pour Needle',12,'858976004764',29.99,'Coravin Faster Pour Needle',1,NULL,0,0,0,0,0,0,29.99,1),(2521,'McClelland\'s Scotch',18,'859141004008',42.99,'McClelland\'s Scotch',7,1,0,0,0,0,0,0,30.5,1),(2522,'Woop Woop Cabernet',12,'859367003847',11.99,'Woop Woop Cabernet',5,1,0,0,0,0,2,0,11.99,12),(2523,'Western Son Blueberry Vodka',21,'859685005035',1.85,'Western Son Blueberry Vodka',7,NULL,0,0,0,0,0,0,1.5,1),(2524,'Cedar Ridge Clearheart Vodka',12,'859824001003',26.83,'Cedar Ridge Clearheart Vodka',7,1,0,0,0,1,6,0,26.83,6),(2525,'Cedar Ridge Reserve White Chardonnay',9,'859824001027',18.99,'Cedar Ridge Reserve White Chardonnay',5,1,0,0,0,0,2,0,13,12),(2526,'Cedar Ridge Harvest Blush',12,'859824001041',10.99,'Cedar Ridge Harvest Blush',5,1,0,0,0,0,2,0,10.99,12),(2527,'Cedar Ridge Port',9,'859824001157',18.99,'Cedar Ridge Port',5,1,0,0,0,0,2,0,13,12),(2528,'Clearheart Gin',12,'859824001232',26.83,'Clearheart Gin',7,1,0,0,0,0,0,0,26.83,1),(2529,'Cedar Ridge Dark Rum',18,'859824001294',35.75,'Cedar Ridge Dark Rum',7,1,0,0,0,0,0,0,35.75,1),(2530,'Cedar Ridge Bourbon',18,'859824001300',38.99,'Cedar Ridge Bourbon',7,1,0,0,0,0,0,0,27.65,1),(2531,'Cedar Ridge Single Malt Whiskey',18,'859824001317',53.99,'Cedar Ridge Single Malt Whiskey',7,1,0,0,0,0,0,0,38.5,1),(2532,'Cedar Ridge Apple Brandy',2,'859824001331',40.38,'Cedar Ridge Apple Brandy',7,1,0,0,0,0,0,0,40.38,1),(2533,'Cedar RidgBourbon Barrel Maple Syrup',9,'859824001393',19.99,'Cedar Ridge Age your own Whiskey Kit',7,1,0,0,0,0,0,0,13.75,1),(2534,'Cedar Ridge Atlas',9,'859824001447',14.99,'Cedar Ridge Atlas',5,1,0,0,0,0,2,0,14.99,12),(2535,'Cedar Ridge Grain to Glass Sampler',18,'859824001461',47.99,'Cedar Ridge Grain to Glass Sampler',7,1,0,0,0,0,0,0,33.75,1),(2536,'Cedar Ridge Blanc de Blanc',9,'859824001492',24.5,'Cedar Ridge Blanc de Blanc',5,1,0,0,0,0,2,0,17.5,12),(2537,'Howdy\'s Apple Pie Cedar Ridge',9,'859824001508',19.99,'Howdy\'s Apple Pie Cedar Ridge',7,NULL,0,0,0,0,0,0,12.25,1),(2538,'Short\'s Whiskey',12,'859824001553',30.05,'Short\'s Whiskey',7,1,0,0,0,0,0,0,30.05,1),(2539,'Cedar Ridge Bourbon Port cask finish',12,'859824001676',52,'Cedar Ridge Bourbon Port cask finish',7,1,0,0,0,0,0,0,52,1),(2540,'Cedar Ridge Lost Pirate',9,'859824001683',49.99,'Cedar Ridge Lost Pirate',7,1,0,0,0,0,0,0,40,1),(2541,'Cedar Ridge Bourbon 200ml',18,'859824001799',14.99,'Cedar Ridge Bourbon 200ml',7,NULL,0,0,0,0,0,0,12.25,1),(2542,'Cedar Ridge Double Oak',9,'859824001843',24.99,'Cedar Ridge Double Oak',5,1,0,0,0,0,2,0,17.5,12),(2543,'Singlespeed Tip the Cow 6-pack Cans',1,'860342001505',11.99,'Singlespeed Tip the Cow 6-pack Cans',6,1,0,0,0,0,0,0,7.8,1),(2544,'SingleSpeed Tricycle',12,'860342001512',0,'SingleSpeed Tricycle',6,NULL,0,0,0,0,0,0,0,1),(2545,'Colorado High Hemp Vodka',18,'861478000103',24.99,'Colorado High Hemp Vodka',7,NULL,0,0,0,0,0,0,17.5,1),(2546,'Miss Mary\'s Bloody Mary Mixer',16,'862875000345',7.5,'Miss Mary\'s Bloody Mary Mixer',2,NULL,0,0,0,0,0,0,4.49,1),(2547,'Chateau Spill Red Wine remover',12,'865169000106',9.99,'Chateau Spill Red Wine remover',1,NULL,0,0,0,0,0,0,9.99,1),(2548,'Elouan Pinot Noir',12,'865776000070',22.99,'Elouan Pinot Noir',5,1,0,0,0,0,2,0,22.99,12),(2549,'Holy Hell spiced Rum',12,'867971000305',20.95,'Holy Hell spiced Rum',7,1,0,0,0,0,0,0,20.95,1),(2550,'Galen Sun Dried Tomatoes',12,'8680426814454',2.99,'Galen Sun Dried Tomatoes',4,NULL,1,0,0,0,0,0,1.5,1),(2551,'Vacu Vin Active Wine Cooler 2 pack',12,'8714793388239',19.99,'Vacu Vin Active Wine Cooler 2 pack',1,NULL,0,0,0,0,0,0,19.99,1),(2552,'Bottle Bag, Watermellon',12,'872197637310',3.99,'Bottle Bag, Watermellon',1,NULL,0,0,0,0,0,0,3.99,1),(2553,'Malteasers 1.31oz',16,'872513001696',1.99,'Malteasers 1.31oz',2,NULL,0,0,0,0,0,0,1.1,1),(2554,'Antigal 2015 Uno Malbec Mendoza, Argentina',10,'874390001035',15.99,'Antigal 2015 Uno Malbec Mendoza, Argentina',5,1,0,0,0,0,2,0,13.25,12),(2555,'Damaine San Payre Provence Rose',6,'874562000514',15.99,'Damaine San Payre Provence Rose',5,1,0,0,0,0,2,0,10.5,12),(2556,'True Wine Gift Bag Red Sheer',12,'876718001307',2.99,'True Wine Gift Bag Red Sheer',1,NULL,0,0,0,0,0,0,2.99,1),(2557,'Bottle Bag',12,'876718001444',2.79,'Bottle Bag',1,NULL,0,0,0,0,0,0,2.79,1),(2558,'True Wine Gift back Sheer Green',12,'876718001666',2.99,'True Wine Gift back Sheer Green',1,NULL,0,0,0,0,0,0,2.99,1),(2559,'Bottle Bag',12,'876718002298',2.99,'Bottle Bag',1,NULL,0,0,0,0,0,0,2.99,1),(2560,'True tools Champaign Stopper',12,'876718004322',5.99,'True tools Champaign Stopper',1,NULL,0,0,0,0,0,0,5.99,1),(2561,'True Cocktail picks',12,'876718004759',6.99,'True Cocktail picks',1,NULL,0,0,0,0,0,0,6.99,1),(2562,'True Foil cutter corkscrew, Black',12,'876718005176',10.99,'True Foil cutter corkscrew, Black',1,NULL,0,0,0,0,0,0,10.99,1),(2563,'True Corkscrew, Brown',12,'876718005190',10.99,'True Corkscrew, Brown',1,NULL,0,0,0,0,0,0,10.99,1),(2564,'Wine Charms',12,'876718005947',4.99,'Wine Charms',1,NULL,0,0,0,0,0,0,4.99,1),(2565,'True Chalice Stopper',12,'876718007071',6.99,'True Chalice Stopper',1,NULL,0,0,0,0,0,0,6.99,1),(2566,'Napkins',12,'876718008320',3.99,'Napkins',1,NULL,0,0,0,0,0,0,3.99,1),(2567,'Picnic Stix',12,'876718008528',19.99,'Picnic Stix',1,NULL,0,0,0,0,0,0,19.99,1),(2568,'TrueTote',12,'876718008986',8.99,'TrueTote',1,NULL,0,0,0,0,0,0,8.99,1),(2569,'Bottle Bag, Luxury wine Sack',12,'876718009563',5.99,'Bottle Bag, Luxury wine Sack',1,NULL,0,0,0,0,0,0,5.99,1),(2570,'True Wine Charms',12,'876718021565',9.99,'True Wine Charms',1,NULL,0,0,0,0,0,0,9.99,1),(2571,'True Wine Charm Clings 12 ct',12,'876718021633',2.99,'True Wine Charm Clings 12 ct',1,NULL,0,0,0,0,0,0,2.99,1),(2572,'True Big Swig',12,'876718021954',19.66,'True Big Swig',1,NULL,0,0,0,0,0,0,19.66,1),(2573,'Host Chill Pour Spout',12,'876718029523',15.99,'Host Chill Pour Spout',1,NULL,0,0,0,0,0,0,15.99,1),(2574,'Wine Bag, Birthday',12,'876718037351',1.99,'Wine Bag, Birthday',1,NULL,0,0,0,0,0,0,1.99,1),(2575,'True Flume 10 ct',12,'876718039720',4.99,'True Flume 10 ct',1,NULL,0,0,0,0,0,0,4.99,1),(2576,'Dark Chocolate Bar',21,'876941009170',1.99,'Dark Chocolate Bar',2,NULL,0,0,0,0,0,0,1.07,1),(2577,'Milk Chocolate Bar',21,'876941009187',1.99,'Milk Chocolate Bar',2,NULL,0,0,0,0,0,0,1.07,1),(2578,'Seagram\'s 7 Whiskey 375 mL',12,'8776509',7.99,'Seagram\'s 7 Whiskey 375 mL',7,1,0,0,0,0,0,0,7.99,1),(2579,'LandOLakes Cocoa',12,'878326002011',4.99,'LandOLakes Cocoa',4,NULL,1,0,0,0,0,0,4.99,1),(2580,'LandOLakes Cocoa French Vanilla',12,'878326002059',4.99,'LandOLakes Cocoa French Vanilla',4,NULL,1,0,0,0,0,0,4.99,1),(2581,'LandOLakes Arctic White',12,'878326002073',4.99,'LandOLakes Arctic White',4,NULL,1,0,0,0,0,0,4.99,1),(2582,'Blue Moon',12,'8787337',1.99,'Blue Moon',6,1,0,0,0,0,0,0,1.99,1),(2583,'Cristal D\'Arques',12,'883314215007',87.99,'Cristal D\'Arques',1,NULL,0,0,0,0,0,0,87.99,1),(2584,'Final Touch Wine Traveller',12,'886245003019',9.99,'Final Touch Wine Traveller',1,NULL,0,0,0,0,0,0,9.99,1),(2585,'Penny Stamp Prosecco',19,'886822088002',11.99,'Penny Stamp Prosecco',5,1,0,0,0,0,2,0,6.33,12),(2586,'Rum Chata 1 L',12,'890355001018',35.31,'Rum Chata 1 L',7,1,0,0,0,0,0,0,35.31,1),(2587,'Rum Chata',18,'890355001049',1.99,'Rum Chata',7,NULL,0,0,0,0,0,0,1.33,1),(2588,'Rumchata Iced Coffee Tumbler',18,'890355001186',11.99,'Rumchata Iced Coffee Tumbler',7,NULL,0,0,0,0,0,0,8.5,1),(2589,'Tippy Cow Variety Pack',12,'890355001209',10.99,'Tippy Cow Variety Pack',5,4,0,0,0,0,2,0,10.99,8),(2590,'Daou 2018 Chardonay Paso Robles',13,'890409002619',21.99,'Daou 2018 Chardonay Paso Robles',5,1,0,0,0,0,2,0,15,12),(2591,'Winneshiek Sunrise Seyval Blanc',21,'890455002229',11.99,'Winneshiek Sunrise Seyval Blanc',5,1,0,0,0,0,2,0,9,12),(2592,'Winnesheik Hunga Dunga',21,'890455002250',11.99,'Winnesheik Hunga Dunga',5,1,0,0,0,0,2,0,9,12),(2593,'The Big Mouth',12,'890751000967',16.99,'The Big Mouth',5,1,0,0,0,0,2,0,16.99,12),(2594,'Camembert Cheese Spread',12,'890791000446',4.5,'Camembert Cheese Spread',4,NULL,1,0,0,0,0,0,4.5,1),(2595,'Brie Cheese Spread',12,'890791000460',4.5,'Brie Cheese Spread',4,NULL,1,0,0,0,0,0,4.5,1),(2596,'Regatta Ginger Beer 6 pack',17,'891236001042',8.99,'Regatta Ginger Beer 6 pack',15,6,0,0,0,0,0,0,6.25,1),(2597,'Fabre Montmayor Grand Vin',12,'891518001708',54.99,'Fabre Montmayor Grand Vin',5,1,0,0,0,0,2,0,54.99,12),(2598,'Fabre Montmayou',12,'891518001722',15.99,'Fabre Montmayou',5,1,0,0,0,0,2,0,15.99,12),(2599,'LangeTwins Cabernet',14,'891540001226',14.99,'LangeTwins Cabernet',5,1,0,0,0,0,2,0,11,12),(2600,'Caricature Cabernet Sauvignon',14,'891540001462',15.99,'Caricature Cabernet Sauvignon',5,1,0,0,0,0,2,0,15.99,12),(2601,'Save italia',12,'892339002172',14.99,'Save italia',5,1,0,0,0,0,2,0,14.99,12),(2602,'Jardin en fleurs vouvray',12,'892696001719',17.99,'Jardin en fleurs vouvray',5,1,0,0,0,0,2,0,17.99,12),(2603,'Les Trois Couronnes Cote du Rhone 2017',14,'892903002201',12.99,'Les Trois Couronnes Cote du Rhone 2017',5,1,0,0,0,0,2,0,8.25,12),(2604,'Les Trois Couronnes cote du Rhone 2014',12,'89294451',13.99,'Les Trois Couronnes cote du Rhone 2014',5,1,0,0,0,0,2,0,13.99,12),(2605,'Surly Furious IPA 4pack',12,'893354001027',11.99,'Surly Furious IPA 4pack',6,4,0,0,0,0,0,0,11.99,1),(2606,'Surly Blakkr Black Ale',21,'893354001157',17.99,'Blakkr Imperial Black Ale 4 Pack',6,4,0,0,0,0,0,0,12,1),(2607,'Gerard Bertrand Corbieres 2015',13,'894254002923',17.99,'Gerard Bertrand Corbieres 2015',5,1,0,0,0,0,2,0,11.75,12),(2608,'Long Meadow Ranch',12,'894591002525',16.99,'Long Meadow Ranch',5,1,0,0,0,0,2,0,16.99,12),(2609,'Rhuby Dooby',21,'895250001323',13.99,'Rhuby Dooby',5,1,0,0,0,0,2,0,9.99,12),(2610,'Buffalo Sweat Oatmeal Stout 1',12,'895531002292',2.99,'Buffalo Sweat Oatmeal Stout 1',6,1,0,0,0,0,0,0,2.99,1),(2611,'Savigny les Beaune Chardonnay',12,'896016001588',23,'Savigny les Beaune Chardonnay',5,1,0,0,0,0,2,0,23,12),(2612,'Ca\'del Bosco Franciacorta Cuvee Prestige',12,'896383000016',41.99,'Ca\'del Bosco Franciacorta Cuvee Prestige',5,1,0,0,0,0,2,0,41.99,12),(2613,'Layer Cake Primitivo',12,'896599002002',17.99,'Layer Cake Primitivo',5,1,0,0,0,0,2,0,17.99,12),(2614,'Layer Cake Shiraz 2017 South Australia',10,'896599002026',17.99,'Layer Cake Shiraz 2017 South Australia',5,1,0,0,0,0,2,0,12.75,12),(2615,'Layer Cake Malbec',13,'896599002033',17.99,'Layer Cake Malbec',5,1,0,0,0,0,2,0,6.9,12),(2616,'If you see Kay Red Blen',13,'896599002149',21.99,'If you see Kay Red Blen',5,1,0,0,0,0,2,0,12.75,12),(2617,'Snuss Hill Catnip',21,'897075001076',13.99,'Snuss Hill Catnip',5,1,0,0,0,0,2,0,8.99,12),(2618,'Snus Hill Edelweiss',20,'897075001090',13.99,'Snus Hill Edelweiss',5,1,0,0,0,0,2,0,9.25,12),(2619,'Snus Hill spinna',12,'897075001182',13.99,'Snus Hill spinna',5,1,0,0,0,0,2,0,13.99,12),(2620,'High Trestle Taille',21,'897075001267',12.99,'High Trestle Taille',5,1,0,0,0,0,2,0,9,12),(2621,'Bulldog Gin',12,'897076002003',26.99,'Bulldog Gin',7,1,0,0,0,0,0,0,26.99,1),(2622,'Mercer Horse Heaven Hills Cabernet',10,'898012002705',0,'Mercer Horse Heaven Hills Cabernet',5,1,0,0,0,0,2,0,0,12),(2623,'Mercer Horse Heaven HIlls Merlot',13,'898012002750',19.99,'Mercer Horse Heaven HIlls Merlot',5,1,0,0,0,0,2,0,15,12),(2624,'Fever-Tree Tonic Water 4 pack',13,'898195001014',6.99,'Fever-Tree Tonic Water 4 pack',15,4,0,0,0,0,0,0,4,1),(2625,'Dulce Vida Lime',12,'898432002477',27.99,'Dulce Vida Lime',7,NULL,0,0,0,0,0,0,27.99,1),(2626,'Slow & Low Rock and Rye',12,'898804009004',26.99,'Slow & Low Rock and Rye',7,1,0,0,0,0,0,0,26.99,1),(2627,'Tassel Ridge Red, White, & Blue',12,'899054001046',11.99,'Tassel Ridge Red, White, & Blue',5,1,0,0,0,0,2,0,11.99,12),(2628,'Tassel Ridge Star Spangled White',21,'899054001466',11.99,'Tassel Ridge Star Spangled White',5,1,0,0,0,0,2,0,11.99,12),(2629,'Tassel Ridge In the Dark',12,'899054001725',18.5,'Tassel Ridge In the Dark',5,1,0,0,0,0,2,0,18.5,12),(2630,'Pacific rim',12,'899552001173',12.99,'Pacific rim',5,1,0,0,0,0,2,0,12.99,12),(2631,'Pacific Rim Dry Riesling',12,'899552001197',13.99,'Pacific Rim Dry Riesling',5,1,0,0,0,0,2,0,13.99,12),(2632,'New Age Red',12,'899911000304',12.75,'New Age Red',5,1,0,0,0,0,2,0,12.75,12),(2633,'New Age White',22,'899911000465',12.75,'New age white',5,1,0,0,0,0,2,0,8,12),(2634,'New Age Sweet Gold',12,'899911000854',9.99,'New Age Sweet Gold',5,1,0,0,0,0,2,0,9.99,12),(2635,'Orchard Apricot',12,'9024153040479',25.99,'Orchard Apricot',7,1,0,0,0,0,0,0,25.99,1),(2636,'Wilson\'s Orchard Spiced Up Cider',12,'9031104614771',11.99,'Wilson\'s Orchard Spiced Up Cider',6,4,0,0,0,0,0,0,11.99,1),(2637,'Wallace Shiraz',12,'9322246002008',27.99,'Wallace Shiraz',5,1,0,0,0,0,2,0,27.99,12),(2638,'Mollydooker Enchanted Path 2011',12,'9336975000020',79.99,'Mollydooker Enchanted Path 2011',5,1,0,0,0,0,2,0,79.99,12),(2639,'Greywacke Chardonnay',12,'9421901925062',30.99,'Greywacke Chardonnay',5,1,0,0,0,0,2,0,30.99,12),(2640,'Saranac Ginger Beer',12,'9450040253',6.99,'Saranac Ginger Beer',15,1,0,0,0,0,0,0,6.99,1),(2641,'Book, Pocket Idiot\'s guide to Choosing Wine',12,'9780028620169',8.99,'Book, Pocket Idiot\'s guide to Choosing Wine',1,NULL,0,0,0,0,0,0,8.99,1),(2642,'Book, Complete Idiot\'s Guide to Wine',12,'9780028636610',18.95,'Book, Complete Idiot\'s Guide to Wine',1,NULL,0,0,0,0,0,0,18.95,1),(2643,'Book, Diving into Wine',12,'9780615331997',11.95,'Book, Diving into Wine',1,NULL,0,0,0,0,0,0,11.95,1),(2644,'Book, Sniffing the Cork',12,'9780743438001',12.99,'Book, Sniffing the Cork',1,NULL,0,0,0,0,0,0,12.99,1),(2645,'Book, Wine lovers Journal',12,'9781407519043',10.99,'Book, Wine lovers Journal',1,NULL,0,0,0,0,0,0,10.99,1),(2646,'Book, The Everything Wine Book',12,'9781558508088',14.95,'Book, The Everything Wine Book',1,NULL,0,0,0,0,0,0,14.95,1),(2647,'Book, The Wine Bible',12,'9781563054341',19.95,'Book, The Wine Bible',1,NULL,0,0,0,0,0,0,19.95,1),(2648,'Book, 101 Wines',12,'9781594868825',19.95,'Book, 101 Wines',1,NULL,0,0,0,0,0,0,19.95,1),(2649,'Book, Vino',12,'9781844131877',19.99,'Book, Vino',1,NULL,0,0,0,0,0,0,19.99,1),(2650,'Book, Best of the Best vol. 9',12,'9781932624144',18.99,'Book, Best of the Best vol. 9',1,NULL,0,0,0,0,0,0,18.99,1),(2651,'Book, The Complete Encyclopedia of Wine',12,'9789036615914',16.99,'Book, The Complete Encyclopedia of Wine',1,NULL,0,0,0,0,0,0,16.99,1),(2652,'Abstract',21,'ABSTRACT',34.99,'Abstract',9,NULL,0,0,0,0,0,0,NULL,1),(2653,'Freisian Farms Aged Gouda',12,'AGED GOUDA',8.75,'Freisian Farms Aged Gouda',4,NULL,1,0,0,0,0,0,8.75,1),(2654,'ardeche',21,'ARDECHE',10.99,'ardeche',9,NULL,0,0,0,0,0,0,NULL,1),(2655,'arrow',21,'ARROW',14.99,'arrow',9,NULL,0,0,0,0,0,0,NULL,1),(2656,'Backpocket Slingshot Dunkel',12,'BACKPOCKET SLINGSHOT DUNKEL',9.99,'Backpocket Slingshot Dunkel',9,NULL,0,0,0,0,0,0,NULL,1),(2657,'bag',21,'BAG',4.99,'bag',9,NULL,0,0,0,0,0,0,NULL,1),(2658,'Beer, Mixed 6 Pack',12,'BEER MIXED 6 PACK',10.99,'Beer, Mixed 6 Pack',6,6,0,0,0,0,0,0,10.99,1),(2659,'Beer Pong',21,'BEER PONG',24.99,'Beer Pong',9,NULL,0,0,0,0,0,0,NULL,1),(2660,'Bitters',12,'BITTERS',7.99,'Bitters',9,NULL,0,0,0,0,0,0,NULL,1),(2661,'Black Velvet',12,'BLACK VELVET',20,'Black Velvet',9,NULL,0,0,0,0,0,0,NULL,1),(2662,'Blanton\'s',21,'BLANTON\'S',66.99,'Blanton\'s',9,NULL,0,0,0,0,0,0,NULL,1),(2664,'Bloody Mary salt',12,'BLOODY MARY SALT',4.99,'Bloody Mary salt',9,NULL,0,0,0,0,0,0,NULL,1),(2665,'blue',21,'BLUE',10.99,'blue',9,NULL,0,0,0,0,0,0,NULL,1),(2666,'Blue Bell',12,'BLUE BELL',18.99,'Blue Bell',9,NULL,0,0,0,0,0,0,NULL,1),(2667,'Blue Bell Bubbly',21,'BLUE BELL BUBBLY',18.99,'Blue Bell Bubbly',9,NULL,0,0,0,0,0,0,NULL,1),(2668,'BLue Cheese olives',12,'BLUE CHEESE OLIVES',7.99,'BLue Cheese olives',9,NULL,0,0,0,0,0,0,NULL,1),(2671,'Bottle Stopper',12,'BOTTLE STOPPER',1.99,'Bottle Stopper',9,NULL,0,0,0,0,0,0,NULL,1),(2672,'Bracelet',21,'BRACELET',6.9902289106,'Bracelet',9,NULL,0,0,0,0,0,0,NULL,1),(2673,'Brie Cheese',21,'BRIE CHEESE',6.99,'Brie Cheese',9,NULL,0,0,0,0,0,0,NULL,1),(2674,'BST Wholesale',21,'BST WHOLESALE',415.84,'BST Wholesale',9,NULL,0,0,0,0,0,0,NULL,1),(2675,'BST Wholesale 8/13/19',21,'BST WHOLESALE 8/13/19',325.43,'BST Wholesale 8/13/19',9,NULL,0,0,0,0,0,0,NULL,1),(2676,'BST Wholesale 2019',21,'BST WHOLESALE AUG 2019',336.08,'BST Wholesale 2019',9,NULL,0,0,0,0,0,0,NULL,1),(2677,'BST Wholesale Sept 2019',21,'BST WHOLESALE SEPT 2019',423.49,'BST Wholesale Sept 2019',9,NULL,0,0,0,0,0,0,NULL,1),(2678,'Bubbly',12,'BUBBLY',1,'Bubbly',9,NULL,0,0,0,0,0,0,NULL,1),(2679,'buble',21,'BUBLE',0.99,'buble',9,NULL,0,0,0,0,0,0,NULL,1),(2680,'Sparkling Water',12,'BUBLY SPARKLING WATER',1,'Sparkling Water',9,NULL,0,0,0,0,0,0,NULL,1),(2681,'bubly water',12,'BUBLY WATER',1,'bubly water',9,NULL,0,0,0,0,0,0,NULL,1),(2682,'bud',21,'BUD LIGHT',14.99,'bud',9,NULL,0,0,0,0,0,0,NULL,1),(2683,'Buttery Nipple Twisted Shotz',21,'BUTTERY NIPPLE TWISTED SHOTZ',7.99,'Buttery Nipple Twisted Shotz',9,NULL,0,0,0,0,0,0,NULL,1),(2685,'Cakebread Cabernet',12,'CABERNET CABERNET',89.99,'Cakebread Cabernet',9,NULL,0,0,0,0,0,0,NULL,1),(2687,'can deposit',21,'CAN DEPOSIT',0.05,'can deposit',9,NULL,0,0,0,0,0,0,NULL,1),(2688,'Candy',12,'CANDY',0.35,'Candy',9,NULL,0,0,0,0,0,0,NULL,1),(2689,'Candy Cigarettes',21,'CANDY CIGS',0.75,'Candy Cigarettes',9,NULL,0,0,0,0,0,0,NULL,1),(2690,'Cantalope',21,'CANTALOPE',1.99,'Cantalope',9,NULL,0,0,0,0,0,0,NULL,1),(2691,'card',21,'CARD',3.75,'card',9,NULL,0,0,0,0,0,0,NULL,1),(2692,'Cave Aged Cheddar',12,'CAVE AGED CHEDDAR',7.99,'Cave Aged Cheddar',9,NULL,0,0,0,0,0,0,NULL,1),(2693,'CC',12,'CC',1.99,'CC',9,NULL,0,0,0,0,0,0,NULL,1),(2694,'Ced Rel Wholesale 8/6/19',21,'CED REL WHOLESALE',753.02,'Ced Rel Wholesale 8/6/19',9,NULL,0,0,0,0,0,0,NULL,1),(2695,'Ced Rel Wholesale Sept 2019',21,'CED REL WHOLESALE SEPT 2019',704.21,'Ced Rel Wholesale Sept 2019',9,NULL,0,0,0,0,0,0,NULL,1),(2696,'Cedar Ridge Wine',12,'CEDAR RIDGE WINE',17.99,'Cedar Ridge Wine',9,NULL,0,0,0,0,0,0,NULL,1),(2697,'CedRel Wholesale 8/13/19',21,'CEDREL WHOLESALE 8/13/19',379.87,'CedRel Wholesale 8/13/19',9,NULL,0,0,0,0,0,0,NULL,1),(2698,'CedRel Wholesale 8/20/19',21,'CEDREL WHOLESALE 8/20/19',482.42,'CedRel Wholesale 8/20/19',9,NULL,0,0,0,0,0,0,NULL,1),(2699,'CedRel Wholesale Aug 27',21,'CEDREL WHOLESALE AUG 27',367.52,'CedRel Wholesale Aug 27',9,NULL,0,0,0,0,0,0,NULL,1),(2700,'CedRel Wholesale Sept 2019',21,'CEDREL WHOLESALE SEPT 2019',360.64,'CedRel Wholesale Sept 2019',9,NULL,0,0,0,0,0,0,NULL,1),(2701,'Cheese',21,'CHEESE',4.79,'Cheese',9,NULL,0,0,0,0,0,0,NULL,1),(2702,'Chips',21,'CHIPS',5.99,'Chips',9,NULL,0,0,0,0,0,0,NULL,1),(2703,'Choc Bar',12,'CHOC BAR',4.5,'Choc Bar',9,NULL,0,0,0,0,0,0,NULL,1),(2704,'chocolate',12,'CHOCOLATE',6.99,'chocolate',9,NULL,0,0,0,0,0,0,NULL,1),(2705,'Vodka',12,'CLEARHEART',26.83,'Vodka',9,NULL,0,0,0,0,0,0,NULL,1),(2706,'Clearkeart',12,'CLEARHEART VODKA',26.83,'Clearkeart',9,NULL,0,0,0,0,0,0,NULL,1),(2707,'Club Soda',12,'CLUB SODA',2.5,'Club Soda',9,NULL,0,0,0,0,0,0,NULL,1),(2708,'Candy',12,'CNADY',0.69,'Candy',9,NULL,0,0,0,0,0,0,NULL,1),(2709,'Coke',12,'COKE',0.99,'Coke',9,NULL,0,0,0,0,0,0,NULL,1),(2710,'coors light 12 pk',21,'COORS LIGHT 12 PK',14.99,'coors light 12 pk',9,NULL,0,0,0,0,0,0,NULL,1),(2711,'Crackers',12,'CRACKERS',2.99,'Crackers',9,NULL,0,0,0,0,0,0,NULL,1),(2712,'straws',12,'CRAZY STRAWS',2.75,'straws',9,NULL,0,0,0,0,0,0,NULL,1),(2713,'Cream Cheese',12,'CREAM CHEESE',2,'Cream Cheese',9,NULL,0,0,0,0,0,0,NULL,1),(2714,'Crown peach',21,'CROWN PEACH',39.99,'Crown peach',9,NULL,0,0,0,0,0,0,NULL,1),(2716,'decantur',12,'DECANTUR',16.99,'decantur',9,NULL,0,0,0,0,0,0,NULL,1),(2718,'Scotch',12,'DEWAR\'S SCOTCH',36.75,'Scotch',9,NULL,0,0,0,0,0,0,NULL,1),(2719,'Diet Tonic',12,'DIET TONIC',2.5,'Diet Tonic',9,NULL,0,0,0,0,0,0,NULL,1),(2720,'Dog Mom Hat',21,'DOG MOM',15.99,'Dog Mom Hat',9,NULL,0,0,0,0,0,0,NULL,1),(2721,'Don Julio',12,'DON JULIO',62.99,'Don Julio',9,NULL,0,0,0,0,0,0,NULL,1),(2722,'Dry Cleaning',12,'DRY CLEANING',0,'Dry Cleaning',13,NULL,0,0,0,0,0,0,0,1),(2723,'sdjn',12,'DSSDNJF',7.99,'sdjn',9,NULL,0,0,0,0,0,0,NULL,1),(2725,'Eiffel Tower Cork Cage',12,'EIFFEL TOWER CORK CAGE',25.99,'Eiffel Tower Cork Cage',9,NULL,0,0,0,0,0,0,NULL,1),(2726,'Elouan',12,'ELOUAN',22.99,'Elouan',9,NULL,0,0,0,0,0,0,NULL,1),(2727,'Fireball',12,'FIREBALL',24.81,'Fireball',9,NULL,0,0,0,0,0,0,NULL,1),(2728,'fliptop pourer',12,'FLIPTOP POURER',3.75,'fliptop pourer',9,NULL,0,0,0,0,0,0,NULL,1),(2729,'Fre',12,'FRE',13.99,'Fre',9,NULL,0,0,0,0,0,0,NULL,1),(2730,'Frisian Farms Aged Gouda',12,'FRISIAN FARMS GOUDA',8.75,'Frisian Farms Aged Gouda',9,NULL,0,0,0,0,0,0,NULL,1),(2731,'Frisk',12,'FRISK',4.99,'Frisk',9,NULL,0,0,0,0,0,0,NULL,1),(2732,'Frontera',12,'FRONTERA',8.99,'Frontera',9,NULL,0,0,0,0,0,0,NULL,1),(2733,'Greeting Card',12,'GC',3.75,'Greeting Card',9,NULL,0,0,0,0,0,0,NULL,1),(2734,'Gemma Luna',21,'GEMMA LUNA',13.99,'Gemma Luna',9,NULL,0,0,0,0,0,0,NULL,1),(2735,'Gift $100',24,'GIFT $100',100,'Gift $100',1,NULL,0,0,0,0,0,0,100,1),(2736,'Gift Certificate',12,'GIFT$25',25.77,'Gift Certificate',10,0,0,0,0,0,0,0,25,1),(2737,'Gift Certificate',12,'GIFT$40',41.24,'Gift Certificate',10,0,0,0,0,0,0,0,40,1),(2738,'Gift Certificate',12,'GIFT$50',51.55,'Gift Certificate',10,0,0,0,0,0,0,0,50,1),(2739,'Gift Basket',12,'GIFT BASKET',100,'Gift Basket',9,NULL,0,0,0,0,0,0,NULL,1),(2740,'Gift Box',12,'GIFT BOX',3.99,'Gift Box',9,NULL,0,0,0,0,0,0,NULL,1),(2741,'Gift Card',12,'GIFT CARD',3.75,'Gift Card',1,NULL,0,0,0,0,0,0,3.75,1),(2742,'ginger ale',21,'GINGER ALE',2.69,'ginger ale',9,NULL,0,0,0,0,0,0,NULL,1),(2743,'Glass',12,'GLASS',1.99,'Glass',9,NULL,0,0,0,0,0,0,NULL,1),(2745,'Greeting Card',12,'GREETING CARD',3.75,'Greeting Card',9,NULL,0,0,0,0,0,0,NULL,1),(2746,'Gum',21,'GUM',1.45,'Gum',9,NULL,0,0,0,0,0,0,NULL,1),(2747,'Hat',21,'HAT',12.99,'Hat',9,NULL,0,0,0,0,0,0,NULL,1),(2748,'Hawkeye Cooler',12,'HAWKEYE COOLER',23.99,'Hawkeye Cooler',9,NULL,0,0,0,0,0,0,NULL,1),(2749,'Asparagus',12,'HOT PICKLED ASPARAGUS',10.99,'Asparagus',9,NULL,0,0,0,0,0,0,NULL,1),(2750,'hot Sopressata',12,'HOT SOPRESSATA',5.99,'hot Sopressata',9,NULL,0,0,0,0,0,0,NULL,1),(2751,'Intrinsic',12,'INTRINSIC',22.99,'Intrinsic',9,NULL,0,0,0,0,0,0,NULL,1),(2752,'Intrinsic Box set',12,'INTRINSIC BOX SET',22.99,'Intrinsic Box set',9,NULL,0,0,0,0,0,0,NULL,1),(2753,'Jigger',12,'JIGGER',3.99,'Jigger',9,NULL,0,0,0,0,0,0,NULL,1),(2754,'jim Beam',12,'JIM BEAM',38.8,'jim Beam',9,NULL,0,0,0,0,0,0,NULL,1),(2755,'Josh Cab',12,'JOSH',19.99,'Josh Cab',9,NULL,0,0,0,0,0,0,NULL,1),(2756,'Kirkwood Wine White',12,'KIRKWOOD WINE WHITE',12.99,'Kirkwood Wine White',9,NULL,0,0,0,0,0,0,NULL,1),(2758,'Ice, Large',12,'LARGE ICE',5.5,'Ice, Large',4,NULL,1,0,0,0,0,0,4,1),(2759,'Legends Show 6/1',12,'LEGENDS SHOW 6/1',15,'Legends Show 6/1',10,NULL,0,0,0,0,0,0,NULL,1),(2760,'Lemonade',12,'LEMONADE',4.99,'Lemonade',9,NULL,0,0,0,0,0,0,NULL,1),(2761,'Lime',12,'LIME',0.99,'Lime',9,NULL,0,0,0,0,0,0,NULL,1),(2762,'cho candy',12,'LINDOR CHO BALL',0.69,'cho candy',9,NULL,0,0,0,0,0,0,NULL,1),(2763,'lollipop',12,'LOLLIPOP',0.99,'lollipop',9,NULL,0,0,0,0,0,0,NULL,1),(2764,'Vintorio Win Aerator',12,'LPNRR362352660',12.99,'Vintorio Win Aerator',1,NULL,0,0,0,0,0,0,12.99,1),(2765,'Lucky Buddha',12,'LUCKY BUDDHA',2.99,'Lucky Buddha',9,NULL,0,0,0,0,0,0,NULL,1),(2766,'Mango',21,'MANGO',1.75,'Mango',9,NULL,0,0,0,0,0,0,NULL,1),(2767,'Marble Chiller',12,'MARBLE CHILLER',28.99,'Marble Chiller',9,NULL,0,0,0,0,0,0,NULL,1),(2768,'Marg Mix',21,'MARG MIX',5.99,'Marg Mix',9,NULL,0,0,0,0,0,0,NULL,1),(2769,'Marg Salt',12,'MARG SALT',4.99,'Marg Salt',9,NULL,0,0,0,0,0,0,NULL,1),(2770,'Margarita',12,'MARGARITA',24.19,'Margarita',9,NULL,0,0,0,0,0,0,NULL,1),(2772,'Misc Chocolates',12,'MISC CHOCOLATES',0.69,'Misc Chocolates',2,NULL,0,0,0,0,0,0,0.5,1),(2773,'Miss Sarah Red Wine',12,'MISS SARAH RED WINE',14.75,'Miss Sarah Red Wine',9,NULL,0,0,0,0,0,0,NULL,1),(2774,'Mom Fuel Cup',12,'MOM FUEL CUP',14.99,'Mom Fuel Cup',9,NULL,0,0,0,0,0,0,NULL,1),(2775,'Mozz Cheese',21,'MOZZ CHEESE',7.99,'Mozz Cheese',9,NULL,0,0,0,0,0,0,NULL,1),(2776,'Mushrooms',12,'MUSHROOMS',7.99,'Mushrooms',9,NULL,0,0,0,0,0,0,NULL,1),(2777,'wine',10,'NAPA RIDGE CAB',19,'wine',5,1,0,0,0,0,2,0,19,12),(2778,'Napkins',21,'NAPKINS',3.99,'Napkins',9,NULL,0,0,0,0,0,0,NULL,1),(2779,'cab',12,'NAPPA RIDGE CAB',19,'cab',9,NULL,0,0,0,0,0,0,NULL,1),(2780,'new age',21,'NEW AGE',12.75,'new age',9,NULL,0,0,0,0,0,0,NULL,1),(2782,'olives',12,'OLIVES',7.99,'olives',9,NULL,0,0,0,0,0,0,NULL,1),(2783,'open beer charge',21,'OPEN BEER CHARGE',4,'open beer charge',9,NULL,0,0,0,0,0,0,NULL,1),(2784,'Ornament',12,'ORNAMENT',5,'Ornament',9,NULL,0,0,0,0,0,0,NULL,1),(2785,'Pahlmeyer Chardonnay',21,'PAHLMEYER CHARDONNAY',72.99,'Pahlmeyer Chardonnay',9,NULL,0,0,0,0,0,0,NULL,1),(2786,'Palm Aerator',12,'PALM AERATOR',23.99,'Palm Aerator',9,NULL,0,0,0,0,0,0,NULL,1),(2787,'Palmeyer',21,'PALMEYER',76.99,'Palmeyer',9,NULL,0,0,0,0,0,0,NULL,1),(2788,'Parmesan Cheese',12,'PARM CHEESE',7.99,'Parmesan Cheese',9,NULL,0,0,0,0,0,0,NULL,1),(2789,'Pen',21,'PEN',0.99,'Pen',9,NULL,0,0,0,0,0,0,NULL,1),(2790,'Pineapple Juice',12,'PINEAPPLE JUICE',1.25,'Pineapple Juice',9,NULL,0,0,0,0,0,0,NULL,1),(2791,'plush',21,'PLUSH',3.99,'plush',9,NULL,0,0,0,0,0,0,NULL,1),(2792,'Pop Rocks',12,'POP ROCKS',0.75,'Pop Rocks',9,NULL,0,0,0,0,0,0,NULL,1),(2793,'Porn Star Twisted Shotz',21,'PORN STAR',7.99,'Porn Star Twisted Shotz',9,NULL,0,0,0,0,0,0,NULL,1),(2794,'Porpane',12,'PORPANE',20.99,'Porpane',9,NULL,0,0,0,0,0,0,NULL,1),(2795,'Portavita',12,'PORTAVITA',14.99,'Portavita',5,1,0,0,0,0,2,0,14.99,12),(2796,'Prairie Breeze',21,'PRAIRIE BREEZE',8.75,'Prairie Breeze',9,NULL,0,0,0,0,0,0,NULL,1),(2798,'pringles',12,'PRINGLES',2.25,'pringles',9,NULL,0,0,0,0,0,0,NULL,1),(2799,'Propane',12,'PROPANE',20.99,'Propane',9,NULL,0,0,0,0,0,0,NULL,1),(2800,'Propane Exchange',5,'PROPANEEXCHANGE',14.5,'Propane',8,NULL,0,0,0,0,0,0,NULL,1),(2803,'Pseudo Ale',21,'PSEUDO ALE',4,'Pseudo Ale',9,NULL,0,0,0,0,0,0,NULL,1),(2804,'Quark cheese',12,'QUARK',4.99,'Quark cheese',9,NULL,0,0,0,0,0,0,NULL,1),(2805,'RePour',12,'REPOUR',1.99,'RePour',9,NULL,0,0,0,0,0,0,NULL,1),(2807,'Salami',12,'SALAMI',5.99,'Salami',9,NULL,0,0,0,0,0,0,NULL,1),(2808,'Salmon Creek',12,'SALMON CREEK',5.99,'Salmon Creek',9,NULL,0,0,0,0,0,0,NULL,1),(2809,'Salsa',21,'SALSA',4.99,'Salsa',9,NULL,0,0,0,0,0,0,NULL,1),(2810,'Sausage',21,'SAUSAGE',6.99,'Sausage',9,NULL,0,0,0,0,0,0,NULL,1),(2811,'Seagrams 7',12,'SEAGRAMS 7',1.75,'Seagrams 7',9,NULL,0,0,0,0,0,0,NULL,1),(2812,'Seagrams Vodka',12,'SEAGRAMS VODKA',20.99,'Seagrams Vodka',9,NULL,0,0,0,0,0,0,NULL,1),(2813,'Stella Artois 24pack',12,'SELLA ARTOIS 24PACK',42,'Stella Artois 24pack',9,NULL,0,0,0,0,0,0,NULL,1),(2814,'Sign',12,'SIGN',3.99,'Sign',9,NULL,0,0,0,0,0,0,NULL,1),(2815,'Silver Oak 2012',12,'SILVER OAK 2012',99.99,'Silver Oak 2012',9,NULL,0,0,0,0,0,0,NULL,1),(2816,'Silver Oak Alexander Valley 2014',12,'SILVER OAK ALEXANDER VALLEY 2014',79.99,'Silver Oak Alexander Valley 2014',9,NULL,0,0,0,0,0,0,NULL,1),(2817,'Beer, Single',12,'SINGLE BEER',2.99,'Beer, Single',6,1,0,0,0,0,0,0,2.99,1),(2818,'Single Chocolates',12,'SINGLE CHOCOLATES',0.69,'Single Chocolates',2,NULL,0,0,0,0,0,0,0.45,1),(2819,'SingleSpeed Tricycle 6 pack',21,'SINGLESPEED TRICYCLE',10.99,'SingleSpeed Tricycle 6 pack',9,NULL,0,0,0,0,0,0,NULL,1),(2820,'Skittles',12,'SKITTLES',1.49,'Skittles',9,NULL,0,0,0,0,0,0,NULL,1),(2821,'Ice, Small',12,'SMALL ICE',2.99,'Ice, Small',4,NULL,1,0,0,0,0,0,2.99,1),(2822,'Sock',12,'SOCK',1.99,'Sock',9,NULL,0,0,0,0,0,0,NULL,1),(2823,'Soda',21,'SODA',1,'Soda',9,NULL,0,0,0,0,0,0,NULL,1),(2824,'Soft Toffees',12,'SOFT TOFFEES',2.99,'Soft Toffees',9,NULL,0,0,0,0,0,0,NULL,1),(2825,'Moscato D\'Asti',12,'STEFANO FARINA MOSCATO D\'ASTI',15.99,'Moscato D\'Asti',9,NULL,0,0,0,0,0,0,NULL,1),(2826,'Stickers',21,'STICKERS',2.99,'Stickers',9,NULL,0,0,0,0,0,0,NULL,1),(2827,'Stoli Razberi',12,'STOLI RAZBERI',34.54,'Stoli Razberi',9,NULL,0,0,0,0,0,0,NULL,1),(2828,'Sucker',12,'SUCKER',0.25,'Sucker',2,NULL,0,0,0,0,0,0,NULL,1),(2829,'Summer Sausage',12,'SUMMER SAUSAGE',6.99,'Summer Sausage',9,NULL,0,0,0,0,0,0,NULL,1),(2830,'Sutliff Cider',12,'SUTLIFF CIDER',12.99,'Sutliff Cider',9,NULL,0,0,0,0,0,0,NULL,1),(2831,'tag card',12,'TAG CARD',0.99,'tag card',9,NULL,0,0,0,0,0,0,NULL,1),(2832,'Teq Rose',12,'TEQ ROSE',1.99,'Teq Rose',9,NULL,0,0,0,0,0,0,NULL,1),(2833,'test',12,'TEST',9.99,'test',9,NULL,0,0,0,0,0,0,NULL,1),(2834,'Tomatoes',21,'TOMATOES',2.99,'Tomatoes',9,NULL,0,0,0,0,0,0,NULL,1),(2835,'Tomolives',12,'TOMOLIVES',3.99,'Tomolives',9,NULL,0,0,0,0,0,0,NULL,1),(2836,'Toms',21,'TOMS',2.99,'Toms',9,NULL,0,0,0,0,0,0,NULL,1),(2837,'Tonic',12,'TONIC',2.5,'Tonic',9,NULL,0,0,0,0,0,0,NULL,1),(2838,'Tonic Water',12,'TONIC WATER',2.5,'Tonic Water',9,NULL,0,0,0,0,0,0,NULL,1),(2839,'Tootsie',21,'TOOTSIE',0.05,'Tootsie',9,NULL,0,0,0,0,0,0,NULL,1),(2840,'Tootsie Roll',21,'TOOTSIE ROLL',0.05,'Tootsie Roll',9,NULL,0,0,0,0,0,0,NULL,1),(2841,'Tootsie',12,'TOTSIE',0.15,'Tootsie',9,NULL,0,0,0,0,0,0,NULL,1),(2842,'Towel',21,'TOWEL',5.99,'Towel',9,NULL,0,0,0,0,0,0,NULL,1),(2843,'toy',12,'TOY',2.99,'toy',9,NULL,0,0,0,0,0,0,NULL,1),(2844,'Treana Cabernet',12,'TREANA CABERNET',27.99,'Treana Cabernet',9,NULL,0,0,0,0,0,0,NULL,1),(2845,'Brandy turtle',12,'TURTLE',39.99,'Brandy turtle',9,NULL,0,0,0,0,0,0,NULL,1),(2846,'Unicorn POOp',12,'UNICORN POOP',2.75,'Unicorn POOp',9,NULL,0,0,0,0,0,0,NULL,1),(2847,'Venge Silencieux',12,'VENGE',64.99,'Venge Silencieux',9,NULL,0,0,0,0,0,0,NULL,1),(2848,'Vinegar',12,'VINEGAR',4.99,'Vinegar',9,NULL,0,0,0,0,0,0,NULL,1),(2850,'49.99',12,'WARRESPORT',49.99,'49.99',9,0,0,0,1,0,0,0,NULL,1),(2851,'Water',12,'WATER',1,'Water',9,NULL,0,0,0,0,0,0,NULL,1),(2852,'Wholesale 05/19',12,'WHOLESALE 05/19',1786.65,'Wholesale 05/19',9,NULL,0,0,0,0,0,0,NULL,1),(2853,'Wholesale BST 7/29/19',12,'WHOLESALE BST 7/29/19',249.14,'Wholesale BST 7/29/19',9,NULL,0,0,0,0,0,0,NULL,1),(2854,'Wholesale BST 8/19/19',21,'WHOLESALE BST 8/19/19',429.45,'Wholesale BST 8/19/19',9,NULL,0,0,0,0,0,0,NULL,1),(2855,'Wholesale CedRel',12,'WHOLESALE CEDREL 7/29/19',299.47,'Wholesale CedRel',9,NULL,0,0,0,0,0,0,NULL,1),(2856,'Wholesale Liquor 06/19',12,'WHOLESALE LIQUOR 06/19',2431.39,'Wholesale Liquor 06/19',9,NULL,0,0,0,0,0,0,NULL,1),(2857,'Wholesale Liquor 07/19',12,'WHOLESALE LIQUOR 07/19',3205.29,'Wholesale Liquor 07/19',9,NULL,0,0,0,0,0,0,NULL,1),(2859,'Wine Bag',12,'WINE BAG',0.99,'Wine Bag',9,NULL,0,0,0,0,0,0,NULL,1),(2860,'Wine Bottle Ornament',12,'WINE BOTTLE CHRISTMAS ORNAMENT',5.49,'Wine Bottle Ornament',9,NULL,0,0,0,0,0,0,NULL,1),(2861,'Wine Glass',12,'WINE GLASS',5.99,'Wine Glass',9,NULL,0,0,0,0,0,0,NULL,1),(2862,'Wine Sock',21,'WINE SOCK',1.99,'Wine Sock',9,NULL,0,0,0,0,0,0,NULL,1),(2863,'Wine Tasting',24,'WINE TASTING',25,'Wine Tasting',10,NULL,0,0,0,0,0,0,25,1),(2864,'Wine Tasting',12,'WINE TICKETS',20,'Wine Tasting',9,NULL,0,0,0,0,0,0,NULL,1),(2865,'Wine Vacuum',12,'WINE VACUUM',9.99,'Wine Vacuum',9,NULL,0,0,0,0,0,0,NULL,1),(2866,'wine wipes',12,'WINE WIPES',0.99,'wine wipes',9,NULL,0,0,0,0,0,0,NULL,1),(2867,'Wooden Serving Board',12,'WOODEN SERVING BOARD',20.99,'Wooden Serving Board',9,NULL,0,0,0,0,0,0,NULL,1),(2868,'Procelain Cheese Buttons',12,'X000B9QP69',14.99,'Procelain Cheese Buttons',1,NULL,0,0,0,0,0,0,14.99,1),(2869,'Ybarra Olives',12,'YBARRA',7.99,'Ybarra Olives',9,NULL,0,0,0,0,0,0,NULL,1),(2873,'Custom',21,'CUSTOM',0,NULL,9,0,0,0,0,0,0,0,NULL,1),(2883,'event Name',NULL,'MYEVENTS',0,NULL,26,NULL,1,1,0,0,0,0,NULL,1),(2885,'Sprint Wine Tasting',NULL,'SPRINTWINETASTING',0,NULL,26,NULL,1,1,0,0,0,0,NULL,1),(2887,'Dole Pineapple Juice',12,'038900009472',1.25,'Dole Pineapple Juice',4,NULL,0,0,0,0,0,0,1.25,1),(2888,'Sahara Burst Cranberry Juice',12,'074865682169',1.25,'Sahara Burst Cranberry Juice',4,NULL,0,0,0,0,0,0,1.25,1),(2889,'Generic wine',12,'5435435435',10.99,'Generic wine',5,1,0,0,0,0,2,0,NULL,12),(2894,'Propane Exchange',5,'049000027624',20.99,NULL,8,NULL,0,0,0,0,0,0,14.5,1),(2895,'Ayinger Octoberfest',17,'5725422139',12.99,NULL,6,NULL,0,0,0,0,0,0,9.99,1),(2897,'Hpy Frms Stilton with Blueberry',3,'4099100124439',7.99,NULL,4,NULL,0,0,0,0,0,0,3.99,1),(2898,'Hpy Frms Stilton with Mango & Ginger',3,'4099100124446',7.99,NULL,4,NULL,0,0,0,0,0,0,3.99,1),(2899,'Sprakling Lemon & Pomegranate Italian Soda',3,'4099100010022',5.99,NULL,59,NULL,0,0,0,0,0,0,2.99,1),(2900,'Stoli Blueberry 1 Liter',18,'811751020083',34.54,NULL,7,NULL,0,0,0,0,0,0,23.96,1),(2901,'Johnnie Walker A Song of Ice',18,'088076184121',48.99,NULL,7,NULL,0,0,0,0,0,0,33.74,1),(2902,'Jack Daniel\'s WinterJack',18,'082184056110',22.99,NULL,7,NULL,0,0,0,0,0,0,15.51,1),(2903,'Tippy Cow Chocolate Shake',18,'857359008016',21.99,NULL,7,NULL,0,0,0,0,0,0,15.75,1),(2904,'Elijah Craig Small Batch Barrel Proof Bourbon',18,'096749472215',64.99,NULL,7,NULL,0,0,0,0,0,0,45.99,1),(2905,'Slipknot No 9 Whiskey',18,'859824001959',41.99,NULL,7,NULL,0,0,0,0,0,0,29.99,1),(2906,'Steeple Ridge Bourbon Whiskey',18,'019962231612',48.99,NULL,7,NULL,0,0,0,0,0,0,34.75,1),(2907,'Love  Card',3,'4099100011395',4.75,NULL,1,NULL,0,0,0,0,0,0,1.75,1),(2908,'Sweetest Person Card',3,'4099100011340',4.75,NULL,1,NULL,0,0,0,0,0,0,1.75,1),(2909,'Mr & Mrs  Wedding Card',3,'4099100056518',4.75,NULL,1,NULL,0,0,0,0,0,0,1.75,1),(2910,'Bavarian Oktoberfest Spread',3,'4099100108590',5.99,NULL,4,NULL,0,0,0,0,0,0,2.99,1),(2911,'Educated Guess Cabernet',22,'898079001000',29.99,NULL,5,1,0,0,0,0,2,0,17.5,12),(2912,'A by Acacia Unoaked Chardonnay',19,'018138509821',13.99,NULL,5,1,0,0,0,0,2,0,8.25,12),(2913,'Penfolds Bin 389 Cabernet Shiraz Blend',19,'012354071209',68.89,NULL,5,1,0,0,0,0,2,0,51,12),(2914,'MillsReef Reserve Merlot Malbec',22,'658568207043',15.99,NULL,5,1,0,0,0,0,2,0,8.25,12),(2915,'Sam Adams Octoberfest',17,'087692300502',10.99,NULL,6,NULL,0,0,0,0,0,0,7.25,1),(2916,'Short Fuse Bear-IE White',21,'859665007141',2.99,NULL,6,NULL,0,0,0,0,0,0,1.99,1),(2917,'Whiner Miaou Belgian Wheat Ale',21,'858423006082',14.99,NULL,6,NULL,0,0,0,0,0,0,12.99,1),(2918,'Redd\'s Black Cherry Ale',17,'03433410',10.99,NULL,6,NULL,0,0,0,0,0,0,7.25,1),(2919,'Peach Tre Red Rambler',17,'856411002030',11.99,NULL,6,NULL,0,0,0,0,0,0,7.95,1),(2920,'Manchego Cheese',3,'041498291372',8.99,NULL,4,NULL,0,0,0,0,0,0,4.99,1),(2921,'Creamy Havarti Cheese',3,'041498177058',6.99,NULL,4,NULL,0,0,0,0,0,0,3.75,1),(2922,'Jameson Caskmates Irish Whiskey',18,'080432109922',40.99,NULL,7,NULL,0,0,0,0,0,0,28.74,1),(2923,'Deep Eddy Vodka with Flask',18,'856065002226',20.99,NULL,7,NULL,0,0,0,0,0,0,14.5,1),(2924,'Ole Smoky Apple Pie Moonshine Mini 50ml',18,'856011004151',3.99,NULL,7,NULL,0,0,0,0,0,0,2.35,1),(2925,'Balvenie 12Yr Double Oak',18,'083664112210',72.99,NULL,7,NULL,0,0,0,0,0,0,49.75,1),(2926,'Frangelico with Coffee Press',18,'721059001373',31.99,NULL,7,NULL,0,0,0,0,0,0,22.75,1),(2927,'Western Son Cucumber Vodka Mini 50ml',17,'859685005363',1.99,NULL,7,NULL,0,0,0,0,0,0,1.25,1),(2928,'Sparkling Limoncello',3,'4099100010008',5.99,NULL,59,NULL,0,0,0,0,0,0,3.99,1),(2929,'Black Stallion Napa Chardonnay',13,'082242162234',17.99,NULL,5,1,0,0,0,0,2,0,11.95,12),(2930,'Rosemary Crackers',21,'078742263373',3.99,NULL,59,NULL,0,0,0,0,0,0,1.99,1),(2931,'Love You Anniversary Card',3,'4099100011548',4.75,NULL,1,NULL,0,0,0,0,0,0,1.99,1),(2932,'Old Fashioned Birthday',3,'4099100011500',4.75,NULL,1,NULL,0,0,0,0,0,0,1.99,1),(2933,'Oyster Bay',22,'870661008055',14.99,NULL,5,1,0,0,0,0,2,0,9.99,12),(2934,'Berentzen Apple Liquor',18,'852176003466',22.99,NULL,7,NULL,0,0,0,0,0,0,16.51,1),(2935,'Goat Cheese Pumpkin Spice',3,'4099100128857',3.99,NULL,4,NULL,0,0,0,0,0,0,2.25,1),(2936,'Transylvanian Romanian Cave Cheese',3,'041498293086',7.99,NULL,4,NULL,0,0,0,0,0,0,3.99,1),(2937,'Michter\'s Small Batch Bourbon',18,'039383007184',49.99,NULL,7,NULL,0,0,0,0,0,0,34.63,1),(2938,'Winning at Life Card',3,'4099100011555',4.5,NULL,1,NULL,0,0,0,0,0,0,1.99,1),(2939,'Get Well Soon Card',3,'4099100011586',4.5,NULL,1,NULL,0,0,0,0,0,0,1.99,1),(2940,'Double Creme Brie',3,'4099100133998',8.99,NULL,4,NULL,0,0,0,0,0,0,3.99,1),(2941,'Bat Knit Crazy Aged Cheddar',3,'4099100120578',7.99,NULL,4,NULL,0,0,0,0,0,0,4.25,1),(2942,'Dark Chocolate Espresso Beans',3,'4099100130331',6.99,NULL,59,NULL,0,0,0,0,0,0,3.25,1),(2943,'Kalamata Olives',3,'041498173739',5.99,NULL,4,NULL,0,0,0,0,0,0,2.75,1),(2944,'Happy Birthday Card',3,'4099100011746',4.75,NULL,1,NULL,0,0,0,0,0,0,1.99,1),(2945,'Make a Wish',3,'4099100011753',4.75,NULL,1,NULL,0,0,0,0,0,0,1.99,1),(2946,'Corvus Cabernet',14,'865585000285',17.99,NULL,5,1,0,0,0,0,2,0,12.75,12),(2947,'Gekkeikan Nigori Saki',13,'088320700022',11.99,NULL,5,1,0,0,0,0,2,0,8.05,12),(2948,'Corralejo with Shot Glasses',18,'720815932036',33.99,NULL,7,NULL,0,0,0,0,0,0,23.5,1),(2949,'Gerard Bertrand Cremant De Limoux',13,'812147020007',19.99,NULL,5,1,0,0,0,0,2,0,12.75,12),(2950,'Jean Vincent 2018 Sancerre',13,'086785651026',24.99,NULL,5,1,0,0,0,0,2,0,17,12),(2951,'Roku Japanese Gin',18,'080686958031',34.99,NULL,7,NULL,0,0,0,0,0,0,23.5,1),(2952,'Laphroaig Triple Wood',18,'080686815013',75.99,NULL,7,NULL,0,0,0,0,0,0,60.06,1),(2953,'Evan Williams Egg Nog 1.75Liter',18,'096749021918',19.99,NULL,7,NULL,0,0,0,0,0,0,13.75,1),(2954,'Kids Dress Up',21,'639277772633',1.99,NULL,1,NULL,0,0,0,0,0,0,1.2,1),(2955,'Mrs. Fields Oatmeal raisin Cookies',21,'655956013644',2.99,NULL,59,NULL,0,0,0,0,0,0,1.25,1),(2956,'Greta Olive & Oregano Crackers',21,'190104088070',2.99,NULL,59,NULL,0,0,0,0,0,0,1.5,1),(2957,'Regal Blueberry Cherries',21,'400012361456',7.99,NULL,59,NULL,0,0,0,0,0,0,4.75,1),(2958,'Hoshi Plum Wine',19,'084279976204',13.99,NULL,5,1,0,0,0,0,2,0,8.8,12),(2960,'Regal Marschino Cherries',21,'400012361418',7.99,NULL,59,NULL,0,0,0,0,0,0,4.75,1),(2961,'Crook & Marker 4-pack Black Cherry',17,'855310008075',8.99,NULL,6,NULL,0,0,0,0,0,0,6.2,1),(2962,'Crook & Marker Mixed 8-pack',17,'855310008068',17.99,NULL,6,NULL,0,0,0,0,0,0,12.8,1),(2963,'Frank Family Napa Cabernet',22,'894910000409',56.99,NULL,5,1,0,0,0,0,2,0,40.5,12),(2964,'Overa Negra Cab Franc Carmenere',22,'858472000949',11.99,NULL,5,1,0,0,0,0,2,0,7.75,12),(2965,'Shafer Relentless 2016',22,'013528700024',98.99,NULL,5,1,0,0,0,0,2,0,71.25,12),(2966,'Lustau Solera Sherry',22,'097985287007',27.99,NULL,5,1,0,0,0,0,2,0,19.5,12),(2967,'Lustau Deluxe Cream Sherry',22,'097985280008',22.99,NULL,5,1,0,0,0,0,2,0,16,12),(2968,'Hakutsuru Plum Wine',22,'747846030029',14.99,NULL,5,1,0,0,0,0,2,0,10.5,12),(2969,'Molly Dooker Blue Eyed Boy',22,'9336975000303',54.99,NULL,5,1,0,0,0,0,2,0,39,12),(2970,'Press 12-Pack Variety',1,'2313004837',19.99,NULL,6,NULL,0,0,0,0,0,0,14.1,1),(2971,'Babich 2018 Sauvignon Blanc',14,'634445000020',13.99,NULL,5,1,0,0,0,0,2,0,9.75,12),(2972,'Overa negra malbec Petit Verdot',22,'858472002288',11.99,NULL,5,1,0,0,0,0,2,0,7.75,12),(2973,'Mature Irish Cheddar',3,'041498253271',6.99,NULL,4,NULL,0,0,0,0,0,0,3.5,1),(2974,'Borgonzola Triple Cream Blue Cheese',3,'4099100134001',7.99,NULL,4,NULL,0,0,0,0,0,0,3.99,1),(2975,'Remy Martin VSOP',18,'087236001162',49.99,NULL,7,NULL,0,0,0,0,0,0,36.97,1),(2976,'Maker\'s Mark 6-pack Minis',18,'085246500941',21.99,NULL,7,NULL,0,0,0,0,0,0,13,1),(2977,'Maker\'s Mark 50ml Mini',18,'085246171561',4.25,NULL,7,NULL,0,0,0,0,0,0,2.33,1),(2978,'Evan WIlliams Egg Nog',18,'096749025336',10.99,NULL,7,NULL,0,0,0,0,0,0,7.71,1),(2979,'Single Speed lo-pHizz Kettle Sour',1,'860342001536',13.99,NULL,6,NULL,0,0,0,0,0,0,9.3,1),(2980,'Broadbent Rainwater Madiera',22,'611482980096',18.99,NULL,5,1,0,0,0,0,2,0,13.5,12),(2981,'Arendsig South Africa Cabernet',22,'6009808940291',24.99,NULL,5,1,0,0,0,0,2,0,18,12),(2982,'Honig Sauvignon Blanc',22,'083837010008',19.95,NULL,5,1,0,0,0,0,2,0,14.25,12),(2983,'Tomato Basil Cheese',3,'041498127688',6.99,NULL,4,NULL,0,0,0,0,0,0,3.99,1),(2984,'TYKU Junmai Ginjo Sake 330ml',13,'736040520986',15.99,NULL,5,1,0,0,0,0,2,0,11.25,12),(2985,'Jim Beam Whiskies of the Season 12-Pack 50ml',18,'080686000068',18.99,NULL,7,NULL,0,0,0,0,0,0,10.75,1),(2986,'Jim Beam 4-Pack Minis 50ml',18,'080686023562',6.99,NULL,7,NULL,0,0,0,0,0,0,4,1),(2987,'Blue Moon Pumpkin Wheat 12-Pack',17,'071990095369',19.99,NULL,6,NULL,0,0,0,0,0,0,13.75,1),(2988,'Amaretto Disaronno with Flutes',18,'050037094497',32.99,NULL,7,NULL,0,0,0,0,0,0,21.79,1),(2989,'Bird Dog Strawberry Whiskey Mini 50ml',18,'812459013902',1.99,NULL,7,NULL,0,0,0,0,0,0,1.25,1),(2990,'Bird Dog Blk Cherry Whiskey Mini 50ml',18,'812459014411',1.99,NULL,7,NULL,0,0,0,0,0,0,1.25,1),(2991,'Bird Dog Peach Whiskey 750ml',18,'812459010659',21.99,NULL,7,NULL,0,0,0,0,0,0,16,1),(2992,'Stopper',21,'661371633510',4.99,NULL,1,NULL,0,0,0,0,0,0,4.99,1),(2993,'734599043055',10,'734599043055',249.99,NULL,5,1,0,0,1,0,2,0,249.99,12),(2994,'Gemma Di Luna mini Moscato',23,'857660004554',5.75,NULL,5,1,0,0,0,0,2,0,3.56,12),(2995,'Spirits of the Apocalypse Bourbon',18,'082000790969',38.99,NULL,7,NULL,0,0,0,0,0,0,27.24,1),(2996,'Christmas Wine Bag',21,'018697120666',2.27,NULL,1,NULL,0,0,0,0,0,0,1.25,1),(2997,'Meiomi Pinot Noir',13,'855165005076',21.99,NULL,5,1,0,0,0,0,2,0,12,12),(2998,'Pearl Cucumber 1Liter',18,'088352128245',17.99,NULL,7,NULL,0,0,0,0,0,0,12.25,1),(2999,'Ole Smoky Moonshine Pickles',18,'853915008247',27.75,NULL,7,NULL,0,0,0,0,0,0,19.75,1),(3000,'Jager Gift Set',18,'083089000109',29.99,NULL,7,NULL,0,0,0,0,0,0,19.68,1),(3001,'Crown Royal Vanilla 1 Liter',18,'082000776604',40.99,NULL,7,NULL,0,0,0,0,0,0,29.34,1),(3002,'Mocha Mint Coffee',3,'4099100143584',7.99,NULL,4,NULL,0,0,0,0,0,0,4.25,1),(3003,'Caramel Macchiato Coffee',3,'041498298685',7.99,NULL,4,NULL,0,0,0,0,0,0,4.25,1),(3004,'Vintage Irish Cheddar',3,'4099100151824',7.99,NULL,4,NULL,0,0,0,0,0,0,4.25,1),(3005,'George DuBoeuf Beaujolais Nouveau',22,'815629028003',13.99,NULL,5,1,0,0,0,0,2,0,12.56,12),(3006,'Scorpoin Pepper Gouda',3,'4099100131086',7.99,NULL,4,NULL,0,0,0,0,0,0,3.99,1),(3007,'Truffle Cheddar',3,'4099100135848',8.99,NULL,4,NULL,0,0,0,0,0,0,4.99,1),(3008,'English Blue Stilton',3,'4099100128796',6.99,NULL,4,NULL,0,0,0,0,0,0,3.75,1),(3009,'Swiss Fondue Cheeses',3,'4099100140231',10.99,NULL,4,NULL,0,0,0,0,0,0,5.75,1),(3010,'Goat Cheese with Truffles',3,'4099100136128',7.99,NULL,4,NULL,0,0,0,0,0,0,3.99,1),(3011,'Embrazen Sonoma Cabernet',19,'089819721856',16.99,NULL,5,1,0,0,0,0,2,0,12,12),(3012,'Beringer Pinot Noir',19,'089819001972',11.99,NULL,5,1,0,0,0,0,2,0,7.75,12),(3013,'Absolut Strawberry 750ml',18,'835229010611',21.99,NULL,7,NULL,0,0,0,0,0,0,14.99,1),(3014,'Booker\'s Bourbon 2020-02',18,'080686011408',96.99,NULL,7,NULL,0,0,0,0,0,0,64,1),(3015,'Stellina Di Note Prosecco',19,'087000363731',12.99,NULL,5,1,0,0,0,0,2,0,9,12),(3016,'Basil Hayden Bourbon 375ml',18,'080686012122',24.99,NULL,7,NULL,0,0,0,0,0,0,17.43,1),(3017,'Jim Beam Cubs Edition 750ml',18,'080686001409',23.99,NULL,7,NULL,0,0,0,0,0,0,16.75,1),(3018,'Bagger 1 L Vodka',18,'859824001942',27.99,NULL,7,NULL,0,0,0,0,0,0,19.75,1),(3019,'Five Farms Irish Cream',18,'085592161568',24.99,NULL,7,NULL,0,0,0,0,0,0,18.25,1),(3020,'Absolut Grapefruit',18,'835229010437',22.99,NULL,7,NULL,0,0,0,0,0,0,15.99,1),(3021,'Dubliner irish Whiskey',18,'084279996325',32.99,NULL,7,NULL,0,0,0,0,0,0,23.5,1),(3022,'Levendi Stagecoach Syrah',14,'894713002280',42.99,NULL,5,1,0,0,0,0,2,0,32,12),(3023,'Durand Cornas \"Empreintes\"',6,'810595011677',44.99,NULL,5,1,0,0,0,0,2,0,32,12),(3024,'Bird Dog Peach Whiskey with 2 Shooters',18,'812459014435',21.99,NULL,7,NULL,0,0,0,0,0,0,15.75,1),(3025,'Terlan Pinot Grigio',22,'745163446301',24.99,NULL,5,1,0,0,0,0,2,0,15,12),(3026,'Milbrandt Merlot Columbia Valley',22,'896280001055',16.99,NULL,5,1,0,0,0,0,2,0,11.25,12),(3027,'Cedar Ridge Single Malt',18,'859824001768',18.99,NULL,7,NULL,0,0,0,0,0,0,12.25,1),(3028,'Cedar Ridge Malted Rye',18,'859824001751',14.99,NULL,7,NULL,0,0,0,0,0,0,12.25,1),(3029,'Cedar Ridge Single Malt Whiskey 200ml',18,'9824001768',15.99,NULL,7,NULL,0,0,0,0,0,0,11,1),(3030,'Cristom Willamette Valley Pinot Noir',22,'851573001112',37.99,NULL,5,1,0,0,0,0,2,0,27,12),(3031,'OTT Am Berg Gruner Veltliner',22,'9120013374132',22.99,NULL,5,1,0,0,0,0,2,0,16.5,12),(3032,'G.D.Vajra barolo Albe 2015',22,'695798111320',41.99,NULL,5,1,0,0,0,0,2,0,27,12),(3033,'Crystal Head Vodka 750ml',18,'627040411414',49.99,NULL,7,NULL,0,0,0,0,0,0,34.98,1),(3034,'Fifty Pounds Dry Gin',18,'088320560503',42.99,NULL,7,NULL,0,0,0,0,0,0,31.26,1),(3035,'Creme de Menthe',18,'088352118741',13.99,NULL,7,NULL,0,0,0,0,0,0,8.11,1),(3036,'Christian Brothers Holiday Nog 750ml',18,'086036205602',11.99,NULL,7,NULL,0,0,0,0,0,0,7.71,1),(3037,'Creme De Cacao White',18,'086816101148',13.99,NULL,7,NULL,0,0,0,0,0,0,8.5,1),(3038,'Dry Creek heritage Wines Zinfandel',13,'082491176020',25.99,NULL,5,1,0,0,0,0,2,0,18,12),(3039,'Bonanza Cabernet',19,'017224710202',24.99,NULL,5,1,0,0,0,0,2,0,17.25,12),(3040,'Caymus Conondrum Red Blend',19,'017224760122',25.99,NULL,5,1,0,0,0,0,2,0,18,12),(3041,'Mt. Beautiful Sauvignon Blanc',14,'9421901690007',17.99,NULL,5,1,0,0,0,0,2,0,11.75,12),(3042,'Castellare Di Castellina Chianti Classico 375ml',13,'B00N8YQEJ6',17.99,NULL,5,1,0,0,0,0,2,0,12.75,12),(3043,'Got Wine Mitt',3,'844527042828',6.99,NULL,1,NULL,0,0,0,0,0,0,4.5,1),(3044,'Whitman\'s Sampler 12oz',21,'076740078425',11.99,NULL,59,NULL,0,0,0,0,0,0,9,1),(3045,'Virginia Chocolate Penuts',3,'4099100056952',4.5,NULL,59,NULL,0,0,0,0,0,0,2.5,1),(3046,'Galliano 375ml',18,'080915112111',23.99,NULL,7,NULL,0,0,0,0,0,0,17.13,1),(3047,'Titos Vodka 200ml',18,'619947000044',8.99,NULL,7,NULL,0,0,0,0,0,0,6.24,1),(3048,'Glenfiddich 15 Year',18,'083664990405',71.99,NULL,7,NULL,0,0,0,0,0,0,52,1),(3049,'Blue Chair Bay Commerative Bottle 2019',18,'856881004664',21.99,NULL,7,NULL,0,0,0,0,0,0,15.13,1),(3050,'Bieler Pere & Fils 2018 Bandol Rose',19,'856622001020',25.99,NULL,5,1,0,0,0,0,2,0,18,12),(3051,'Three Thieves Cabernet Sauvignon',19,'894509008809',13.99,NULL,5,1,0,0,0,0,2,0,9,12),(3052,'E&J Brandy',18,'085000004135',14.99,NULL,7,NULL,0,0,0,0,0,0,12,1),(3053,'You & Me Card',3,'/4099100011692',4.75,NULL,1,NULL,0,0,0,0,0,0,2.5,1),(3054,'Goat Milk Brie',3,'4099100136135',7.99,NULL,4,NULL,0,0,0,0,0,0,4.5,1),(3055,'Vintage Cheddar',3,'4099100135855',8.99,NULL,4,NULL,0,0,0,0,0,0,4.75,1),(3056,'Double Smoked Cheddar',3,'4099100135695',8.5,NULL,4,NULL,0,0,0,0,0,0,4.75,1),(3057,'Cheddar & Gruyere',3,'4099100135688',8.25,NULL,4,NULL,0,0,0,0,0,0,4.75,1),(3058,'Almond Roca Cream',13,'848375000351',9.99,NULL,5,1,0,0,0,0,2,0,1,12),(3059,'Saint Brendan\'s Irish Cream Set',18,'088352133041',18.99,NULL,7,NULL,0,0,0,0,0,0,12.54,1),(3060,'Closet Freak Moscato',13,'855759006847',8.99,NULL,5,1,0,0,0,0,2,0,4.75,12),(3061,'Whiplash Malbec',13,'858698002765',9.99,NULL,5,1,0,0,0,0,2,0,5.25,12),(3062,'Whiplash Zin',13,'858698002628',9.99,NULL,5,1,0,0,0,0,2,0,5.25,12),(3063,'Roscato Two-Pack',13,'086785212906',21.99,NULL,5,2,0,0,0,0,2,0,12,8),(3064,'Outer Space Vodka',18,'085316601196',34.99,NULL,7,NULL,0,0,0,0,0,0,23.5,1),(3065,'Templeton Rye 1.75',18,'720815920248',53.99,NULL,7,NULL,0,0,0,0,0,0,37.99,1),(3066,'Wild Turkey 81',18,'721059847506',24.99,NULL,7,NULL,0,0,0,0,0,0,18.1,1),(3067,'Buzz Balls Pumpkin Spice',13,'855200005672',2.99,NULL,5,1,0,0,0,0,2,0,1,12),(3068,'Big Grove Boomtown',1,'752830090484',10.99,NULL,6,NULL,0,0,0,0,0,0,7.25,1),(3069,'Exile Sir Moch-A-Lot',1,'850992005572',10.99,NULL,6,NULL,0,0,0,0,0,0,7.83,1),(3070,'New Grist Ginger Ale',21,'746546000486',1.75,NULL,6,NULL,0,0,0,0,0,0,1.25,1),(3071,'Wine Sweater',21,'041498335755',5.99,NULL,1,NULL,0,0,0,0,0,0,4,1),(3072,'Backposket Copper Coin Coffee Vanilla Lager',1,'852131004637',11.99,NULL,6,NULL,0,0,0,0,0,0,7.99,1),(3073,'Hendricks Gin 750ml',18,'083664990436',39.99,NULL,7,NULL,0,0,0,0,0,0,28,1),(3074,'Single Speed Zach\'s Mexican Donuts Stout',1,'860342001598',12.99,NULL,6,NULL,0,0,0,0,0,0,9.2,1),(3076,'Boulevard Nutcracker',1,'726959901303',10.99,NULL,6,NULL,0,0,0,0,0,0,7.35,1),(3077,'Oilver Apple Pie',13,'012584020015',8.99,NULL,5,1,0,0,0,0,2,0,6,12),(3078,'D\'Usse Xo Cognac',21,'080480002947',195,NULL,7,NULL,0,0,0,0,0,0,195,1),(3079,'Wine Tube',21,'192598051202',5.99,NULL,1,NULL,0,0,0,0,0,0,2.99,1),(3080,'Wine Tube',21,'192598060402',5.99,NULL,1,NULL,0,0,0,0,0,0,3.99,1),(3081,'Pint Gift Bag',21,'077757430824',1.85,NULL,1,NULL,0,0,0,0,0,0,1.25,1),(3082,'Bottle Sweater',21,'98335700',5.99,NULL,1,NULL,0,0,0,0,0,0,3.99,1),(3083,'Ardbeg Ten Single Malt',18,'081753831523',56.99,NULL,7,NULL,0,0,0,0,0,0,40.74,1),(3084,'George T Stagg Bourbon',18,'088004027841',499.99,NULL,7,NULL,0,0,0,0,0,0,79,1),(3085,'1792 Full Proof',18,'080660001159',39.99,NULL,7,0,0,0,0,0,0,0,24.68,1),(3086,'Inkblot Cabernet Franc',13,'652935100326',36.99,NULL,5,1,0,0,0,0,2,0,26.3,12),(3087,'Glenmorangie Nectar D\'Or',18,'081753831493',73.99,NULL,7,NULL,0,0,0,0,0,0,52.99,1),(3088,'Whistle Pig 15 year',18,'851460002369',249.99,NULL,7,NULL,0,0,0,0,0,0,187.99,1),(3089,'Turtle brandy',18,'877358001610',39.99,NULL,7,NULL,0,0,0,0,0,0,30,1),(3090,'Crown Royal 375ml',18,'087000007604',17.99,NULL,7,NULL,0,0,0,0,0,0,12.5,1),(3091,'Bulleit Bourbon 375ml',18,'087000004122',17.99,NULL,7,NULL,0,0,0,0,0,0,12.5,1),(3092,'Johnnie Walker Red 375ml',18,'088110021191',17.99,NULL,7,NULL,0,0,0,0,0,0,12.5,1),(3093,'The Balvenie 12 Year Aged American Oak',18,'083664874132',73.99,NULL,7,NULL,0,0,0,0,0,0,52.99,1),(3094,'Rum Chata 375ml',18,'890355001032',16.75,NULL,7,NULL,0,0,0,0,0,0,11.75,1),(3095,'Mr. Boston Holiday Nog',18,'089000016952',9.99,NULL,7,NULL,0,0,0,0,0,0,5.96,1),(3096,'Butcher\'s Block Vodka 750ml',18,'850826008250',19.99,NULL,7,NULL,0,0,0,0,0,0,13.75,1),(3097,'Peppermint Schnapps 375ml',18,'088352119038',6.75,NULL,7,NULL,0,0,0,0,0,0,3.99,1),(3098,'Drumheller Chardonnay',13,'088586007989',16.99,NULL,5,1,0,0,0,0,2,0,12,12),(3099,'Roscato Smooth',13,'086785212777',12.99,NULL,5,1,0,0,0,0,2,0,8.75,12),(3100,'Roscato Dark',13,'086785212760',11.99,NULL,5,1,0,0,0,0,2,0,8.75,12),(3101,'Unknown Item',13,'9419151039',11.99,NULL,5,1,0,0,0,0,2,0,8,12),(3102,'Josh Cabernet',13,'857744001318',19.99,NULL,5,1,0,0,0,0,2,0,14,12),(3103,'Sassicaia Italy',13,'084692492008',195.99,NULL,5,1,0,0,0,0,2,0,150,12),(3104,'Boulevard Brandy Land 4-Pack',1,'726959911449',15.99,NULL,6,NULL,0,0,0,0,0,0,11,1),(3105,'Eagle Rare 10 Year Aged Bourbon',18,'088004021344',69.99,NULL,7,NULL,0,0,0,0,0,0,26.74,1),(3106,'Ridgemont Reserve 1792 Small Batch Bourbon',18,'080660001203',39.99,NULL,7,NULL,0,0,0,0,0,0,25.18,1),(3107,'Jefferson\'s Reserve Bourbon',18,'655709000013',59.99,NULL,7,NULL,0,0,0,0,0,0,40.74,1),(3108,'Old Forrester Statesman',18,'081128001735',61.99,NULL,7,NULL,0,0,0,0,0,0,42.22,1),(3109,'Yellowstone Bourbon',18,'088352130798',44.99,NULL,7,NULL,0,0,0,0,0,0,31,1),(3110,'Crown Royal French Oak Cask Finished',18,'082000789499',66.99,NULL,7,NULL,0,0,0,0,0,0,45.99,1),(3111,'Stanahan\'s Single Malt Whiskey',18,'811538013574',64.99,NULL,7,NULL,0,0,0,0,0,0,44.68,1),(3112,'Nefarious Bourbon',18,'854647008338',39.99,NULL,7,NULL,0,0,0,0,0,0,27.25,1),(3113,'Ketel One 375ml',18,'085156122158',14.99,NULL,7,NULL,0,0,0,0,0,0,9.99,1),(3114,'Captain Morgan 375ml',18,'08727707',12.99,NULL,7,NULL,0,0,0,0,0,0,8.5,1),(3115,'Skrewball Peanut Butter Whiskey',18,'860265002405',40.99,NULL,7,NULL,0,0,0,0,0,0,28.75,1),(3116,'WhistlePig 12 Year Aged Rye',18,'851460002253',138.99,NULL,7,NULL,0,0,0,0,0,0,97.26,1),(3117,'Whistlepig 10 Year rye',18,'793573797940',85.99,NULL,7,NULL,0,0,0,0,0,0,59.76,1),(3118,'Grey Goose 375ml',18,'080480280031',20.99,NULL,7,NULL,0,0,0,0,0,0,14.88,1),(3119,'Bulleit Bourbon Barrel Strength',18,'082000778516',54.99,NULL,7,NULL,0,0,0,0,0,0,38.49,1),(3120,'Seagram\'s VO Whisky',18,'087000007369',15.99,NULL,7,NULL,0,0,0,0,0,0,10.95,1),(3121,'Johnnie Walker Discover Pack',18,'088076183230',46.99,NULL,7,NULL,0,0,0,0,0,0,33.25,1),(3122,'Gentleman Jack Set',18,'082184232170',43.99,NULL,7,NULL,0,0,0,0,0,0,31.02,1),(3123,'Molly Dooker The Boxer Shiraz',22,'9336975000051',32.99,NULL,5,1,0,0,0,0,2,0,22.5,12),(3124,'Innocent Bystander Moscato',22,'767749008796',14.99,NULL,7,NULL,0,0,0,0,0,0,9,1),(3125,'Shots Shots Shots Cocktail Napkins',21,'876718049309',3.5,NULL,1,NULL,0,0,0,0,0,0,1.5,1),(3126,'Two-Bottle Wine Bag',21,'876718032523',2.99,NULL,1,NULL,0,0,0,0,0,0,1.5,1),(3127,'Chalkboard Signs',21,'842094161669',2.99,NULL,1,NULL,0,0,0,0,0,0,1.5,1),(3128,'Wine Socks',21,'192936048185',6.99,NULL,5,1,0,0,0,0,2,0,4.99,12),(3129,'Mature Cheddar Cheese',3,'4099100151817',7.99,NULL,4,NULL,0,0,0,0,0,0,3.75,1),(3130,'Olives with Feta',3,'4099100125795',7.99,NULL,4,NULL,0,0,0,0,0,0,3.99,1),(3131,'Personalized Ornament',21,'888733007233',4.99,NULL,1,NULL,0,0,0,0,0,0,2.5,1),(3132,'Candy-Filled Bottle',21,'040000550648',5.99,NULL,59,NULL,0,0,0,0,0,0,2.75,1),(3133,'Coffee Drink Sleeve',21,'697153690655',4.99,NULL,1,NULL,0,0,0,0,0,0,2.5,1),(3134,'Lion\'s Bridge Yard Sale',17,'758913883356',11.99,NULL,6,NULL,0,0,0,0,0,0,8.55,1),(3135,'Effen Vodka',18,'080686938057',26.99,NULL,7,NULL,0,0,0,0,0,0,19.25,1),(3136,'Romana Sambuca',18,'086767220066',29.99,NULL,7,NULL,0,0,0,0,0,0,21.25,1),(3137,'Midnight Moon Moonshine Cherries',18,'851767001157',24.99,NULL,7,NULL,0,0,0,0,0,0,17.75,1),(3138,'Knob Creek Smoked Maple',18,'080686016182',42.99,NULL,7,NULL,0,0,0,0,0,0,30.5,1),(3139,'Breckenridge Strawberry Sky',1,'745432600014',10.99,NULL,6,NULL,0,0,0,0,0,0,7.3,1),(3140,'Bouldvard Chill Vibes Sour Cucumber',1,'726959911128',8.99,NULL,6,NULL,0,0,0,0,0,0,5,1),(3141,'Stella Spritzer Dry Cider',1,'018200201325',7.99,NULL,6,NULL,0,0,0,0,0,0,5,1),(3142,'Basil Infused Olive Oil',3,'041498128647',7.99,NULL,4,NULL,0,0,0,0,0,0,4,1),(3143,'Tomato garlic basil oilve oil',3,'041498216399',7.99,NULL,4,NULL,0,0,0,0,0,0,4.5,1),(3144,'Garlic Infused Oilve Oil',3,'041498128586',7.99,NULL,4,NULL,0,0,0,0,0,0,4.5,1),(3145,'Ghirardelli Peppermint Bark Squares',21,'747599315633',5.99,NULL,59,NULL,0,0,0,0,0,0,2.99,1),(3146,'Cocktail Sauce',21,'4099100138689',3.99,NULL,59,NULL,0,0,0,0,0,0,1.99,1),(3147,'Cheese Flight of Three',3,'088231417965',18.99,NULL,4,NULL,0,0,0,0,0,0,10.5,1),(3148,'Faux Fur Wine Bag',21,'4099100132632',6.99,NULL,1,NULL,0,0,0,0,0,0,3.99,1),(3149,'Smoked Gouda & Cheddar',3,'4099100152371',7.99,NULL,4,NULL,0,0,0,0,0,0,3.99,1),(3150,'Boozeberry Vodka Cheddar',3,'4099100127010',7.99,NULL,4,NULL,0,0,0,0,0,0,4.5,1),(3151,'Birthday Card',3,'4099100011791',4.75,NULL,1,NULL,0,0,0,0,0,0,1.5,1),(3152,'Birthday Card',3,'4099100011852',4.75,NULL,1,NULL,0,0,0,0,0,0,1.5,1),(3153,'Birthday Card',3,'4099100011869',4.75,NULL,1,NULL,0,0,0,0,0,0,1.5,1),(3154,'You and Me Card',3,'4099100011692',4.75,NULL,1,NULL,0,0,0,0,0,0,1.5,1),(3155,'Peanut Butter Porter',21,'850829008141',2.75,NULL,6,NULL,0,0,0,0,0,0,1.5,1),(3156,'Chateau Les Trois Croix Grand Vin De Bordeaux',13,'3760103480563',31.99,NULL,5,1,0,0,0,0,2,0,21.55,12),(3157,'Cervaro della Sala Antinori',13,'088586002533',49.99,NULL,5,1,0,0,0,0,2,0,33,12),(3158,'Ochdamh-mor Bruchladdich 10.1',18,'087236700904',209.99,NULL,7,NULL,0,0,0,0,0,0,143,1),(3159,'Les Cadrans Lassegue Saint Emillion Grand Cru',13,'709793000180',33.99,NULL,5,1,0,0,0,0,2,0,23.5,12),(3160,'Antinori Tignanello',13,'088586002465',124.99,NULL,5,1,0,0,0,0,2,0,93.75,12),(3161,'Creme De Menthe White',13,'088352118734',13.99,NULL,7,NULL,0,0,0,0,0,0,8.5,1),(3162,'Gemma de Luna Prosecco',13,'857660004646',14.99,NULL,5,1,0,0,0,0,2,0,9,12),(3163,'Bass Pale Ale',1,'762274071314',10.99,NULL,6,NULL,0,0,0,0,0,0,7.5,1),(3164,'Ballast Point Lager',1,'672438002613',8.99,NULL,6,NULL,0,0,0,0,0,0,5,1),(3165,'Old Forrester 1870 Original Batch',18,'081128000707',49.99,NULL,7,NULL,0,0,0,0,0,0,34.74,1),(3166,'Elijah craig Small Batch Bourbon 375ml',18,'096749001873',18.99,NULL,7,NULL,0,0,0,0,0,0,13.5,1),(3167,'Luxardo Cherries',21,'8000353007901',21.99,NULL,59,NULL,0,0,0,0,0,0,16,1),(3168,'Knob Creek Quarter Oak',18,'080686016663',53.99,NULL,7,NULL,0,0,0,0,0,0,38.5,1),(3169,'Cylde Mays Bourbon',18,'089016016915',43.99,NULL,7,NULL,0,0,0,0,0,0,31,1),(3170,'Russell\'s reverve Bourbon',18,'721059957502',43.99,NULL,7,NULL,0,0,0,0,0,0,31,1),(3171,'David Nicholson 1843 Bourbon',18,'088352113920',32.99,NULL,7,NULL,0,0,0,0,0,0,23.5,1),(3172,'LeadSlingers Bourbon Whiskey',18,'727908999655',41.99,NULL,7,NULL,0,0,0,0,0,0,29.5,1),(3173,'Basil Hayden 8 Year',18,'080686012405',46.99,NULL,7,NULL,0,0,0,0,0,0,32.5,1),(3174,'Evan WIliams 1783 Small Batch',18,'096749141326',24.99,NULL,7,NULL,0,0,0,0,0,0,17.49,1),(3175,'Buchanan House Port Wine',7,'640626904094',16.99,NULL,5,1,0,0,0,0,2,0,11,12),(3176,'Big Grove 1939 Amber Ale 6-Pack',1,'644216220076',11.99,NULL,6,NULL,0,0,0,0,0,0,8.5,1),(3177,'Johnnie Wlker Blue 750ml',18,'088110070052',269.99,NULL,7,NULL,0,0,0,0,0,0,199.99,1),(3178,'Fancy Pants Prosecco',19,'085200027965',16.75,NULL,5,1,0,0,0,0,2,0,12,12),(3179,'Fancy Pants Prosecco',19,'4056816903734',16.99,NULL,5,1,0,0,0,0,2,0,12.75,12),(3180,'Segura Viudas Aria Brut Pinot Noir',19,'033293666004',11.99,NULL,5,1,0,0,0,0,2,0,9,12),(3181,'Surf Swim Chardonnay 8.4oz Can',19,'734352000271',3.99,NULL,5,1,0,0,0,0,2,0,2.22,12),(3182,'Deakin Estate Moscato',19,'636662057719',8.99,NULL,5,1,0,0,0,0,2,0,6.16,12),(3183,'Genoa Salame',23,'736436851755',7.99,NULL,4,NULL,0,0,0,0,0,0,4,1),(3184,'Iowa Legendary Rye',18,'858133008079',51.99,NULL,7,NULL,0,0,0,0,0,0,36.75,1),(3185,'Remo Farina',22,'745163231204',18.99,NULL,5,1,0,0,0,0,2,0,13.5,12),(3186,'Firetrucker Burnout Brown 4-Pack',17,'868425000209',9.75,NULL,6,NULL,0,0,0,0,0,0,6.95,1),(3187,'Lagunitas Maximus',17,'723830000179',10.99,NULL,6,NULL,0,0,0,0,0,0,7.85,1),(3188,'Davis Bynum Russian River Sonoma Pinot Noir 2017',13,'087512887459',34.99,NULL,5,1,0,0,0,0,2,0,13.5,12),(3189,'Chateau saint Roch 2016',22,'3760031472265',22.99,NULL,5,1,0,0,0,0,2,0,15.75,12),(3190,'DAOU Pessimist Red Blend Paso Robles',13,'890409002794',26.99,NULL,5,1,0,0,0,0,2,0,12.6,12),(3191,'Underwood Rose Bubbly 375ml Can',22,'856036001197',7.99,NULL,5,1,0,0,0,0,2,0,5.5,12),(3192,'Poliziano Vino Noble di Montepulciano',11,'748789400085',33.99,NULL,5,1,0,0,0,0,2,0,23.25,12),(3193,'Evodia Garnacha Altovinum Spain',22,'8424703501923',13.99,NULL,5,1,0,0,0,0,2,0,9,12),(3194,'Hall Napa Valley Cabernet',13,'892159000570',59.99,NULL,5,1,0,0,0,0,2,0,25,12),(3195,'DeKuyper Raspberry Pucker',18,'080686398202',17.99,NULL,7,NULL,0,0,0,0,0,0,12.81,1),(3196,'The Quiet Man Single Malt Irish Whiskey',18,'088352130842',46.99,NULL,7,NULL,0,0,0,0,0,0,33.25,1),(3197,'The Sexton Single malt Irish Whiskey',18,'811538018098',33.99,NULL,7,NULL,0,0,0,0,0,0,23.5,1),(3198,'Surf Swim Chardonnay 4-Pack',19,'734352000288',15.99,NULL,5,4,0,0,0,0,2,0,9,8),(3199,'VIla Maria Sauvignon Blanc New Zealand',13,'088586004421',14.99,NULL,5,1,0,0,0,0,2,0,8.5,12),(3200,'Barton Naturals Vodka',18,'088004027919',10.99,NULL,7,NULL,0,0,0,0,0,0,6.96,1),(3201,'St. Germain Elderflower Liqueur',18,'080480004699',43.99,NULL,7,NULL,0,0,0,0,0,0,31,1),(3202,'Woodford Reserve Double Oaked',18,'081128001209',66.99,NULL,7,NULL,0,0,0,0,0,0,46.74,1),(3203,'Buffalo Trace Bourbon Cream',18,'080244003715',27.99,NULL,7,NULL,0,0,0,0,0,0,16.6,1),(3204,'Bibb & Tucker Aged 6 years Bourbon Whiskey',18,'031259003542',61.99,NULL,7,NULL,0,0,0,0,0,0,43.51,1),(3205,'Les trois Couronnes Cotes-du-Rhone Red Blend',14,'892903002072',13.99,NULL,5,1,0,0,0,0,2,0,8.25,12),(3206,'Austin Hope Paso Robles Cabernet',13,'657891715591',52.99,NULL,5,1,0,0,0,0,2,0,25,12),(3207,'Casa Mamita Medium Chunky Salsa',3,'4099100062045',4.99,NULL,4,NULL,0,0,0,0,0,0,1.99,1),(3208,'Priano Fettucini',3,'4099100137514',3.99,NULL,4,NULL,0,0,0,0,0,0,2.5,1),(3209,'Priano Spaghetti',3,'4099100137491',3.99,NULL,4,NULL,0,0,0,0,0,0,2.5,1),(3210,'Mulitseed Flatbread',3,'4099100122831',4.99,NULL,59,NULL,0,0,0,0,0,0,2.25,1),(3211,'Moser Roth Sea Salt Dark Chocolate Bar',3,'4099100086294',4.5,NULL,59,NULL,0,0,0,0,0,0,2.99,1),(3212,'Clamato 64oz',21,'014800516470',6.99,NULL,59,NULL,0,0,0,0,0,0,3.99,1),(3213,'Game of Thrones Mortlach 15 Year',18,'088076184633',153.99,NULL,7,NULL,0,0,0,0,0,0,113.49,1),(3214,'Calvert Whiskey',18,'088352129006',15.99,NULL,7,NULL,0,0,0,0,0,0,11.43,1),(3215,'Absolut Peach 1 Liter',18,'835229001145',29.99,NULL,7,NULL,0,0,0,0,0,0,22,1),(3216,'Gift Bag with Disco Ball',21,'763795596331',2.99,NULL,1,NULL,0,0,0,0,0,0,1.25,1),(3217,'Bowling & Birch Gin',18,'088352134369',43.99,NULL,7,NULL,0,0,0,0,0,0,30.99,1),(3218,'Malibu Splash Mix 8-Pack',1,'089540535388',19.99,NULL,6,NULL,0,0,0,0,0,0,14,1),(3219,'Big Grove Swirl Sour',1,'787790149309',10.99,NULL,6,NULL,0,0,0,0,0,0,7.5,1),(3220,'Absolut Vanilla 1Liter',1,'835229006409',29.99,NULL,7,NULL,0,0,0,0,0,0,21.99,1),(3221,'Wolfgang Puck Rechargeable Wine Opener',21,'602190903699',19.99,NULL,1,NULL,0,0,0,0,0,0,7,1),(3222,'White Claw Variety 12-Pack',17,'635985800064',20.99,NULL,6,NULL,0,0,0,0,0,0,14.5,1),(3223,'Killians Irish Red',1,'071990700027',10.99,NULL,6,NULL,0,0,0,0,0,0,7.25,1),(3224,'Lagunitas Hazy Memory IPA',1,'723830981645',11.99,NULL,6,NULL,0,0,0,0,0,0,7.7,1),(3225,'Dalmore Single Malt Port Wood Oak Aged',18,'087647113409',99.99,NULL,7,NULL,0,0,0,0,0,0,75.75,1),(3226,'Ice Box Mudslide 175 Liter',18,'088004015947',14.99,NULL,7,NULL,0,0,0,0,0,0,8.25,1),(3227,'John Bowman Bourbon',18,'080996002752',54.99,NULL,7,NULL,0,0,0,0,0,0,38.25,1),(3228,'Ardbeg Corryvreckan',18,'081753816247',93.99,NULL,7,NULL,0,0,0,0,0,0,69.75,1),(3229,'Casamigos Mezcal',18,'856724006329',71.99,NULL,7,NULL,0,0,0,0,0,0,51,1),(3230,'Jose Cuervo Cherry Limeade Margarita',18,'811538019026',14.99,NULL,7,NULL,0,0,0,0,0,0,14.11,1),(3231,'The Quiet Man Dry Cask Irish Whiskey',18,'088352130859',34.99,NULL,7,NULL,0,0,0,0,0,0,24.75,1),(3232,'Weller Special Reserve 7YR Wheated Bourbon',18,'088004025748',48.99,NULL,7,NULL,0,0,0,0,0,0,14.5,1),(3233,'Ardbeg AN OA Islay Single Malt Scotch Whisky',18,'081753829315',61.99,NULL,7,NULL,0,0,0,0,0,0,43.99,1),(3234,'Mount Gay Black barrel Double Cask Deeply Charred ',18,'087236950538',42.99,NULL,7,NULL,0,0,0,0,0,0,30.22,1),(3235,'360 Bing Cherry Mini Vodka 50ml',18,'085592138683',1.99,NULL,7,NULL,0,0,0,0,0,0,0.95,1),(3236,'Willakenzie Estate Pinot Noir Rose Willamette Vall',13,'603110970043',15.99,NULL,5,1,0,0,0,0,2,0,8.5,12),(3237,'Lion Bridge Olde 17',18,'758913883455',11.99,NULL,7,NULL,0,0,0,0,0,0,8.5,1),(3238,'Lunch mate Salami',3,'041498178109',6.99,NULL,4,NULL,0,0,0,0,0,0,3.5,1),(3239,'Specially Selected Blue Cheese Olives',3,'4099100122336',7.99,NULL,4,NULL,0,0,0,0,0,0,3.5,1),(3240,'Clynelish Single Malt Scotch 750ml',18,'088076183094',88.99,NULL,7,NULL,0,0,0,0,0,0,63.24,1),(3241,'Knappogue Castle Single Malt Irish Whiskey Ireland',18,'814794011223',41.99,NULL,7,NULL,0,0,0,0,0,0,28.96,1),(3242,'Game of Thrones The NIght\'s Watch Oban Bay Reserve',18,'088076183063',79.99,NULL,7,NULL,0,0,0,0,0,0,59.49,1),(3243,'Peychauds Cocktail Bitters',21,'088004190187',12.99,NULL,59,NULL,0,0,0,0,0,0,9.5,1),(3244,'Gibson Sherry',11,'083420119996',9.99,NULL,5,1,0,0,0,0,2,0,5.25,12),(3245,'Woodford Reserve Kentucky Derby',18,'081128022280',61.99,NULL,7,NULL,0,0,0,0,0,0,40.5,1),(3246,'Glenfiddich 12 Year',18,'083664107360',49.99,NULL,7,NULL,0,0,0,0,0,0,39,1),(3247,'Lagunitas Hop Stoopid Ale 6pk',17,'723830100015',11.99,NULL,6,NULL,0,0,0,0,0,0,8.99,1),(3248,'Skippy Super Chunk 48oz',23,'037600223348',9.99,NULL,4,NULL,0,0,0,0,0,0,4.5,1),(3249,'Ragu Old World Sauce',23,'036200014011',8.99,NULL,4,NULL,0,0,0,0,0,0,4,1),(3250,'Tropicana Orange Juice',23,'048500001745',1.3,NULL,4,NULL,0,0,0,0,0,0,0.65,1),(3251,'Sweet Baby Ray\'s Honey BBQ Sauce 40oz',23,'013409451335',8.99,NULL,4,NULL,0,0,0,0,0,0,4,1),(3252,'Canada Dry Tonic Water',21,'078000153453',2.99,NULL,59,NULL,0,0,0,0,0,0,1.75,1),(3253,'2 Liter Pepsi',23,'01223004',2.99,NULL,59,NULL,0,0,0,0,0,0,1.8,1),(3254,'Garlic Stuffed Olives',3,'4099100122350',7.99,NULL,4,NULL,0,0,0,0,0,0,3.75,1),(3255,'Fair Trade Medium Roast Coffee',3,'041498171254',7.99,NULL,59,NULL,0,0,0,0,0,0,4.5,1),(3256,'Smoked Gouda Cheese',3,'4099100166484',6.99,NULL,4,NULL,0,0,0,0,0,0,3.5,1),(3257,'Chi-Chi\'s Gold Margarita',18,'089000546916',15.99,NULL,7,NULL,0,0,0,0,0,0,10,1),(3258,'Wither Hills Sauvignon Blanc',13,'633438000122',14.99,NULL,5,1,0,0,0,0,2,0,11.25,12),(3259,'Johnny Walker Red',18,'088110021405',37.99,NULL,7,NULL,0,0,0,0,0,0,26.65,1),(3260,'Pearl Red Berry',18,'088352127071',16.99,NULL,7,NULL,0,0,0,0,0,0,11.5,1),(3261,'Aalborg Taffel Akavit',18,'817469010293',24.99,NULL,7,NULL,0,0,0,0,0,0,17.5,1),(3262,'Rutherford Hill Barrel Select Red Blend',19,'086891080468',25.99,NULL,5,1,0,0,0,0,2,0,15,12),(3263,'Fatty Pope Red Blend',19,'853567004093',14.99,NULL,5,1,0,0,0,0,2,0,10,12),(3264,'Movendo Moscato',13,'089744766045',10.99,NULL,5,1,0,0,0,0,2,0,8,12),(3265,'Frizzy Frizzante',19,'017619046008',8.99,NULL,5,1,0,0,0,0,2,0,7,12),(3266,'Uppercut Cabernet',19,'080720961010',17.99,NULL,5,1,0,0,0,0,2,0,11.99,12),(3267,'Sho Chiku Bai Gingo Nigori Sake',19,'086395201000',17.99,NULL,5,1,0,0,0,0,2,0,11.99,12),(3268,'Bells Oberon Wheat Ale 6-Pack',19,'740522110688',10.99,NULL,6,NULL,0,0,0,0,0,0,7.75,1),(3269,'Beringer Pink Moscato',19,'089819542543',8.99,NULL,5,1,0,0,0,0,2,0,5.5,12),(3270,'Tostitos Bite Size',23,'028400174862',5.99,NULL,59,NULL,0,0,0,0,0,0,3.99,1),(3271,'Tostitos Scoops',23,'028400174404',5.99,NULL,59,NULL,0,0,0,0,0,0,3.99,1),(3272,'Barossa Ink Shiraz',13,'083417007671',16.99,NULL,5,1,0,0,0,0,2,0,5.25,12),(3273,'Barossa Ink Cabernet',13,'083417007688',13.99,NULL,5,1,0,0,0,0,2,0,8.5,12),(3274,'Domaine Canton French Ginger Liqueur',18,'793573762764',40.99,NULL,7,NULL,0,0,0,0,0,0,28.72,1),(3275,'Imperia Russian Vodka',18,'736040018674',43.99,NULL,7,NULL,0,0,0,0,0,0,31,1),(3276,'Banhez Mezcal Artesanal',18,'736040538073',44.99,NULL,7,NULL,0,0,0,0,0,0,31.75,1),(3277,'Diplomatico Rum Extra Anejo',18,'7594003626631',31.99,NULL,7,NULL,0,0,0,0,0,0,21.25,1),(3278,'Finagren\'s Irish Wiskey Mini 50ml',18,'087116003408',1.99,NULL,7,NULL,0,0,0,0,0,0,1.25,1),(3404,'Captain Morgan Pineapple',18,'082000004929',17.99,NULL,7,NULL,0,0,0,0,0,0,13.39,1),(3405,'Paramount Triple Sec',18,'086816102732',10.99,NULL,7,NULL,0,0,0,0,0,0,6.76,1),(3406,'Licor 43',18,'029929115411',30.99,NULL,7,NULL,0,0,0,0,0,0,21.65,1),(3407,'Bols Triple Sec',18,'080915039197',10.99,NULL,7,NULL,0,0,0,0,0,0,6.63,1),(3408,'Tinkerman\'s Bright Complex Gin',18,'088004027117',27.99,NULL,7,NULL,0,0,0,0,0,0,19.75,1),(3409,'Juarez Gold Tequila & Liqueur',18,'088352119519',11.99,NULL,7,NULL,0,0,0,0,0,0,8.5,1),(3410,'Libeula Tequila',18,'736040539742',29.99,NULL,7,NULL,0,0,0,0,0,0,20.38,1),(3411,'Game of Thrones Cardhu Gold Reserve',18,'088076183049',55.99,NULL,7,NULL,0,0,0,0,0,0,39.99,1),(3412,'Truly Hard Seltzer Mixed 12 Pack',17,'087692009917',19.99,NULL,6,NULL,0,0,0,0,0,0,14.2,1),(3413,'Breckenridge Bourbon Whiskey',18,'853826005007',61.99,NULL,7,NULL,0,0,0,0,0,0,43.75,1),(3414,'Mud House Pinot Noir',13,'083417007084',15.99,NULL,5,1,0,0,0,0,2,0,9,12),(3415,'Veuve Du Vernay',13,'810885011226',15.99,NULL,5,1,0,0,0,0,2,0,10,12),(3416,'Dill havarti',3,'4099100133721',6.99,NULL,4,NULL,0,0,0,0,0,0,3.5,1),(3417,'Cedar Ridge Rye',18,'859824001584',42.99,NULL,7,NULL,0,0,0,0,0,0,30.51,1),(3418,'Petite Dill Pickles 46oz',23,'078742321721',8.99,NULL,4,NULL,0,0,0,0,0,0,4.78,1),(3419,'Steeple Ridge Bourbon Whiskey',18,'019962231414',64.99,NULL,7,NULL,0,0,0,0,0,0,46,1),(3420,'Original Mother\'s Cherry',18,'084279979014',11.99,NULL,7,NULL,0,0,0,0,0,0,7.75,1),(3421,'Elijah Craig Single Barrel 18 Years',18,'096749010189',138.99,NULL,7,NULL,0,0,0,0,0,0,97.26,1),(3422,'Macallan 12 Year Sherry Oak Cask',18,'812066020553',85.99,NULL,7,NULL,0,0,0,0,0,0,61.02,1),(3423,'Remy Martin 1738',18,'087236002114',60.99,NULL,7,NULL,0,0,0,0,0,0,43.72,1),(3424,'Old Forrester 1920',18,'081128001155',66.99,NULL,7,NULL,0,0,0,0,0,0,45.97,1),(3425,'Mark West Pinot Noir',19,'851718000048',11.99,NULL,5,1,0,0,0,0,2,0,5.75,12),(3426,'Gen 5 SAuvignon Blanc',14,'859481003396',12.99,NULL,5,1,0,0,0,0,2,0,7.99,12),(3427,'Pavao Vinho Verde',14,'787202000174',10.99,NULL,5,1,0,0,0,0,2,0,6,12),(3428,'Baron Fini Pinot Grigio',13,'031259021911',12.99,NULL,5,1,0,0,0,0,2,0,9,12),(3429,'Saved Magic Maker Rose',19,'086003904194',14.99,NULL,5,1,0,0,0,0,2,0,8.75,12),(3430,'Fuerza Monastrell and Cabernet',14,'8437013527033',14.99,NULL,5,1,0,0,0,0,2,0,9.75,12),(3431,'Zolo Torrontes',14,'852282002704',12.99,NULL,5,1,0,0,0,0,2,0,7.5,12),(3432,'Corona Hard Seltzer Variety Pack',1,'033544000434',21.99,NULL,6,NULL,0,0,0,0,0,0,15.58,1),(3433,'2 Liter Diet Pepsi',21,'012000171765',2.99,NULL,59,NULL,0,0,0,0,0,0,1.8,1),(3434,'UV Blue 1 Liter',18,'087116014473',16.75,NULL,7,NULL,0,0,0,0,0,0,11,1),(3435,'Rare Pinot Noir',11,'684586204160',12.99,NULL,5,1,0,0,0,0,2,0,8,12),(3436,'Applewood Smoked Cheddar',3,'4099100134421',7.99,NULL,4,NULL,0,0,0,0,0,0,3.99,1),(3437,'Parmesan Cheese 8oz',3,'4099100070118',7.99,NULL,4,NULL,0,0,0,0,0,0,4.06,1),(3438,'Asiago Cheese 8oz',3,'4099100070125',7.99,NULL,4,NULL,0,0,0,0,0,0,4.06,1),(3439,'Kinky Blue Mini 50ml',18,'084279991528',1.99,NULL,7,NULL,0,0,0,0,0,0,0.99,1),(3440,'New Ansterdam Pink Lemonade',18,'08567507',1.85,NULL,7,NULL,0,0,0,0,0,0,0.8,1),(3441,'Cuervo Grapefruit Tangerine Margarita',18,'811538016971',10.99,NULL,7,NULL,0,0,0,0,0,0,7,1),(3442,'Ardbeg Blaaack',18,'081753832605',159,NULL,7,NULL,0,0,0,0,0,0,105.99,1),(3443,'Uncle Val\'s Botanical Gin',18,'856442005314',41.99,NULL,7,NULL,0,0,0,0,0,0,29.88,1),(3444,'Novaterra Organic Vodka',18,'087116002968',19.99,NULL,7,NULL,0,0,0,0,0,0,13.77,1),(3445,'Hatozaki Japanese Whisky',18,'080368000027',49.99,NULL,7,NULL,0,0,0,0,0,0,35.73,1),(3446,'Blue Moon Light Sky 6-Pack Cans',17,'071990095918',9.99,NULL,6,NULL,0,0,0,0,0,0,7,1),(3447,'Prince Alexandre Cremant De Loire',6,'185961000723',15.99,NULL,5,1,0,0,0,0,2,0,11,12),(3448,'Crook and Marker Variety Pack',17,'855310008273',17.99,NULL,6,NULL,0,0,0,0,0,0,12,1),(3449,'Coors Light 16oz Wide-Mouth Cans',17,'071990095277',21.99,NULL,6,NULL,0,0,0,0,0,0,16.05,1),(3450,'Chateau Tour De Luchey Bordeaux',6,'852187012952',14.99,NULL,5,1,0,0,0,0,2,0,8.25,12),(3451,'Ca Furlan Prosecco',6,'610746000693',15.99,NULL,5,1,0,0,0,0,2,0,10.5,12),(3452,'Giuliano Rosati Pinot Grigio Friuli',6,'610746000853',12.99,NULL,5,1,0,0,0,0,2,0,8,12),(3453,'Giuliano Rosati Chianti',6,'610746000860',13.99,NULL,5,1,0,0,0,0,2,0,8.99,12),(3454,'Laila Biancoperla Verdicchio',6,'8056304400079',12.99,NULL,5,1,0,0,0,0,2,0,8.75,12),(3455,'Chateau St Bernard Bordeaux',6,'3760043480159',16.99,NULL,5,1,0,0,0,0,2,0,10,12),(3456,'La Yunta Torrontes',22,'736040012511',11.99,NULL,5,1,0,0,0,0,2,0,5,12),(3457,'Evolucio Dry Furmint',22,'875359002537',12.99,NULL,5,1,0,0,0,0,2,0,8.25,12),(3458,'La Fiera Soave',22,'089832901136',12.99,NULL,5,1,0,0,0,0,2,0,7.5,12),(3459,'Plumpjack Cabernet 750ml',22,'4099100015072',145,NULL,5,1,0,0,0,0,2,0,108.75,12),(3460,'Plumpjack Napa Chardonnay',22,'017082873637',54,NULL,5,1,0,0,0,0,2,0,39,12),(3461,'Deep Eddy Ruby Red',18,'856065002103',32.99,NULL,7,NULL,0,0,0,0,0,0,22.74,1),(3462,'Slipknot No 9 Reserve',18,'008598240013',84.99,NULL,7,NULL,0,0,0,0,0,0,60.25,1),(3463,'Amado Sur Malbec Blend',13,'082734754244',14.99,NULL,5,1,0,0,0,0,2,0,10,12),(3464,'2016 Trackers Crossing Chardonnay',13,'081434031020',7.99,NULL,5,1,0,0,0,0,2,0,3.75,12),(3465,'The Bachelorette Chardonnay',13,'811265024799',6.99,NULL,5,1,0,0,0,0,2,0,2,12),(3466,'Old Soul Petite Syrah',13,'082544990047',14.99,NULL,5,1,0,0,0,0,2,0,9,12),(3467,'Mexican Mudslide Chi-Chi\'s',18,'089000547814',15.99,NULL,7,NULL,0,0,0,0,0,0,10.75,1),(3468,'Boulevard Radler',1,'726959907855',10.99,NULL,6,NULL,0,0,0,0,0,0,7.5,1),(3469,'Hopler Pannonica Rose',11,'739211000423',14.99,NULL,5,1,0,0,0,0,2,0,9.75,12),(3470,'Ulrich\'s Pella Beef Sticks',21,'736313575798',5.99,NULL,4,NULL,0,0,0,0,0,0,3.75,1),(3471,'Back Pocket Pink Denim',1,'852131004804',14.99,NULL,6,NULL,0,0,0,0,0,0,10.25,1),(3472,'VacuVin Wine Cooler',21,'084256388235',19.99,NULL,1,NULL,0,0,0,0,0,0,12,1),(3473,'Redds Black Cherry Ale',21,'034100989309',10.99,NULL,6,NULL,0,0,0,0,0,0,6.75,1),(3474,'Butter Cookie with Chocolate',3,'4099100062663',4.25,NULL,59,NULL,0,0,0,0,0,0,2.15,1),(3475,'Hpnotiq Mini 50ml',18,'736040012870',3.75,NULL,7,NULL,0,0,0,0,0,0,1.75,1),(3476,'Garlic Herb Goat Cheese 4oz',3,'4099100133912',3.99,NULL,4,NULL,0,0,0,0,0,0,2.25,1),(3477,'Plain Goat Cheese 4oz',3,'4099100133905',3.99,NULL,4,NULL,0,0,0,0,0,0,2.25,1),(3478,'Manchego Cheese 7oz',3,'4099100085624',8.99,NULL,4,NULL,0,0,0,0,0,0,4.25,1),(3479,'Spanish Manzanilla Olives',3,'041498000059',3.99,NULL,4,NULL,0,0,0,0,0,0,1.99,1),(3480,'Diora La Petite Grace Pinot Noir',13,'082242013079',24.99,NULL,5,1,0,0,0,0,2,0,14.05,12),(3481,'Wine by Joe Pinot Blanc',13,'180937000011',14.99,NULL,5,1,0,0,0,0,2,0,9.75,12),(3482,'Anna Codorniu 187ml Singles',13,'012976990988',3.99,NULL,5,1,0,0,0,0,2,0,2.5,12),(3483,'Cuervo Coconut-Pineapple Marg',18,'-811538012836',19.99,NULL,7,NULL,0,0,0,0,0,0,13.75,1),(3484,'Zac brown Uncaged Red Blend',13,'082242013932',18.99,NULL,5,1,0,0,0,0,2,0,12.25,12),(3485,'Skrewball Peanut Butter Whiskey',18,'860265002429',3.99,NULL,7,NULL,0,0,0,0,0,0,2.1,1),(3486,'Uno Mas Margarita Straw Lime',13,'860000183192',9.99,NULL,5,1,0,0,0,0,2,0,6.96,12),(3487,'Bollicini Sparkling Wine',13,'816253011492',11.99,NULL,5,1,0,0,0,0,2,0,5.5,12),(3488,'Bollicini Sparkling Rose 4-Pack 187\'s',13,'816253011515',11.99,NULL,5,4,0,0,0,0,2,0,5.5,8),(3489,'Rain Cucumber Vodka',18,'080244002541',17.99,NULL,7,NULL,0,0,0,0,0,0,12.25,1),(3490,'Three Finger Jack',13,'082242014847',19.99,NULL,5,1,0,0,0,0,2,0,13,12),(3491,'Daviess County Bourbon',18,'088352134291',48.99,NULL,7,NULL,0,0,0,0,0,0,34.75,1),(3492,'Just Another Vodka',18,'855810007127',22.99,NULL,7,NULL,0,0,0,0,0,0,15.22,1),(3493,'Teeling Small Batch Irish Whiskey',18,'813219020048',40.99,NULL,7,NULL,0,0,0,0,0,0,28.99,1),(3494,'Blue Maui Hawaiian',18,'088004016104',11.99,NULL,7,NULL,0,0,0,0,0,0,6.51,1),(3495,'Cigar City Maduro Brown Ale',17,'897853002943',11.99,NULL,6,NULL,0,0,0,0,0,0,7.5,1),(3496,'Cigar City Jai Alai IPA',17,'897853002936',11.99,NULL,6,NULL,0,0,0,0,0,0,7.75,1),(3497,'Lagavulin 8 Year',18,'088076180635',79.99,NULL,7,NULL,0,0,0,0,0,0,57.25,1),(3498,'Captain Morgan 1.75',18,'082000759102',38.8,NULL,7,NULL,0,0,0,0,0,0,28,1),(3499,'Theme Socks',23,'4099100009224',3.99,NULL,1,NULL,0,0,0,0,0,0,1.5,1),(3500,'Martini & Rossi Sweet Vermouth 750ml',13,'011034410055',12.99,NULL,5,1,0,0,0,0,2,0,6.75,12),(3501,'Root: 1 Cabernet 2018',13,'750625651018',12.99,NULL,5,1,0,0,0,0,2,0,7.5,12),(3502,'Cambria Julia\'s Vineyard Rose of Pinot Noir',13,'726319004194',15.99,NULL,5,1,0,0,0,0,2,0,10,12),(3503,'Le Poggere Est! Est! Est!',13,'098709438750',12.99,NULL,5,1,0,0,0,0,2,0,8.5,12),(3504,'Outlot Chardonnay 2016',13,'083417007343',11.99,NULL,5,1,0,0,0,0,2,0,6,12),(3505,'Chateau Bonnet Bordeaux Rose',13,'721298260913',9.99,NULL,5,1,0,0,0,0,2,0,5,12),(3506,'Newton Skyside Claret 2016',13,'081753801847',19.99,NULL,5,1,0,0,0,0,2,0,8,12),(3507,'Vina Pomal Reserva 2013',13,'8411543111511',18.99,NULL,5,1,0,0,0,0,2,0,8,12),(3508,'Redbreast 12 Years',18,'080432586174',71.99,NULL,7,NULL,0,0,0,0,0,0,51.22,1),(3509,'Just Another Vodka Red Yellow',18,'855810007110',21.99,NULL,7,NULL,0,0,0,0,0,0,15.22,1),(3510,'Meyers Rum 750ml',18,'088004036546',21.99,NULL,7,NULL,0,0,0,0,0,0,15.25,1),(3511,'Exile G.G. Dunkel',1,'850992005077',10.99,NULL,6,NULL,0,0,0,0,0,0,7.75,1),(3512,'Paulaner Hefe-Weizen',1,'080157611946',11.75,NULL,6,NULL,0,0,0,0,0,0,8.25,1),(3513,'Jumbo Ice Cube Tray',3,'4099100048636',6.99,NULL,1,NULL,0,0,0,0,0,0,2.75,1),(3514,'Sea Salt Almonds',3,'4099100060140',7.99,NULL,59,NULL,0,0,0,0,0,0,4.5,1),(3515,'Gourmet Deli Meats',3,'4099100038163',8.99,NULL,4,NULL,0,0,0,0,0,0,4.8,1),(3516,'Tomatin Dualchas Single Malt',18,'084279994130',39.99,NULL,7,NULL,0,0,0,0,0,0,27.25,1),(3517,'Grand Marnier Cuveee Louis-Alexandre',18,'649188900551',74.99,NULL,7,NULL,0,0,0,0,0,0,53.5,1),(3518,'Sparkling Strawberry Daquiri',3,'041800704606',4.99,NULL,59,NULL,0,0,0,0,0,0,1.99,1),(3519,'Gran Gala Liqueur',18,'086024018832',21.99,NULL,7,NULL,0,0,0,0,0,0,15.7,1),(3520,'Midnight Moon Watermelon',18,'850015676017',24.99,NULL,7,NULL,0,0,0,0,0,0,18.25,1),(3521,'Burn the Boats Rye Whiskey',18,'757817999958',39.99,NULL,7,NULL,0,0,0,0,0,0,27.25,1),(3522,'Bumbu XO Rum',18,'813497006147',46.99,NULL,7,NULL,0,0,0,0,0,0,33.24,1),(3523,'Aberfeldy 12 Year Scotch',18,'080480220006',51.99,NULL,7,NULL,0,0,0,0,0,0,37,1),(3524,'Tenuta Di Nozole La Forna Chianti Classico Riserva',13,'084692448340',35.99,NULL,5,1,0,0,0,0,2,0,23.5,12),(3525,'Michele Chiarlo Barolo',13,'084692441501',45.99,NULL,5,1,0,0,0,0,2,0,28,12),(3526,'Tenuta Di Nozzole La Forna',13,'_084692448340',34.99,NULL,5,1,0,0,0,0,2,0,23.5,12),(3527,'Septima Gran Reserva Malbec Blend',13,'819614000401',18.99,NULL,5,1,0,0,0,0,2,0,6,12),(3528,'Urban Provence Rose',13,'818252020277',15.99,NULL,5,1,0,0,0,0,2,0,5.33,12),(3529,'Fistful of Bourbon',18,'083664873906',32.99,NULL,7,NULL,0,0,0,0,0,0,23.5,1),(3530,'Biserno Il Pino Red Blend',13,'084692614196',54.99,NULL,5,1,0,0,0,0,2,0,34.5,12),(3531,'Blood Oath Bourbon',18,'088352134833',118.99,NULL,7,NULL,0,0,0,0,0,0,83.5,1),(3532,'North Coast Scrimshaw',19,'727344000076',10.99,NULL,6,NULL,0,0,0,0,0,0,7.5,1),(3533,'Tilia Malbec',13,'098709670204',11.99,NULL,5,1,0,0,0,0,2,0,9,12),(3534,'Whistlepig 6 Year Rye',18,'850001901116',54.99,NULL,7,NULL,0,0,0,0,0,0,38.5,1),(3535,'Ardbeg Wee Beastie 5 year',18,'081753832902',49.99,NULL,7,NULL,0,0,0,0,0,0,34.74,1),(3536,'Fireside Glow',21,'094922003584',15.99,NULL,5,1,0,0,0,0,2,0,11.5,12),(3537,'La Croix 6-Pack',23,'012993441111',4.99,NULL,4,NULL,0,0,0,0,0,0,2.5,1),(3538,'La Croix 6-Pack',23,'012993441098',4.99,NULL,4,NULL,0,0,0,0,0,0,2.5,1),(3539,'Domaine Carneros Pinot Noir Carneros Estate',13,'084692430949',39.99,NULL,5,1,0,0,0,0,2,0,26,12),(3540,'SkyFair Lodi Zinfandel',13,'082242015110',10.99,NULL,5,1,0,0,0,0,2,0,5.75,12),(3541,'Jesse James Bourbon',18,'089105510331',19.99,NULL,7,NULL,0,0,0,0,0,0,14.28,1),(3542,'Louisiana Hot Sauce',21,'190298000209',2.75,NULL,4,NULL,0,0,0,0,0,0,1.25,1),(3543,'Hennessey Cognac 50ml Mini',18,'088110150501',5.99,NULL,7,NULL,0,0,0,0,0,0,3.75,1),(3544,'Crystal Head Rainbow',18,'627040412497',56.99,NULL,7,NULL,0,0,0,0,0,0,40,1),(3545,'Kraft Large Marshmallows',21,'600699003285',3.99,NULL,59,NULL,0,0,0,0,0,0,2,1),(3546,'Honey Maid Graham Crackers',21,'04446307',5.99,NULL,59,NULL,0,0,0,0,0,0,3.98,1),(3547,'Nabisco Graham Crackers',21,'04448800',5.99,NULL,59,NULL,0,0,0,0,0,0,3.99,1),(3548,'Redemption Rye Whiskey',18,'031259000695',32.99,NULL,7,NULL,0,0,0,0,0,0,21.99,1),(3549,'Daviess County Bourbon in Cabernet Casks',18,'088352134796',54.99,NULL,7,NULL,0,0,0,0,0,0,38.5,1),(3550,'Carolans Salted Caramel',18,'810845030083',20.99,NULL,7,NULL,0,0,0,0,0,0,14.5,1),(3551,'Sparkler Candles',21,'607772231498',2.99,NULL,1,NULL,0,0,0,0,0,0,1.25,1),(3552,'Single Speed Gable Helles',1,'860342001574',10.99,NULL,6,NULL,0,0,0,0,0,0,7.75,1),(3553,'Michelob Golden Light 12-Pack',1,'018200006975',20.99,NULL,6,NULL,0,0,0,0,0,0,14.3,1),(3554,'Ciderboys Peach',1,'088733902501',10.99,NULL,6,NULL,0,0,0,0,0,0,8,1),(3555,'Blue Moon Light Sky 12-Pack',17,'071990095925',18.99,NULL,6,NULL,0,0,0,0,0,0,13.4,1),(3556,'Kenwood Jack London Sonoma Cabernet 2016',13,'010986000024',29.99,NULL,5,1,0,0,0,0,2,0,17.42,12),(3557,'Brancott Estate Sauvignon Blanc',13,'852832104711',13.99,NULL,5,1,0,0,0,0,2,0,8.5,12),(3558,'Oskar Blues Can-O-Bliss Hazy IPA',17,'819942003044',10.99,NULL,6,NULL,0,0,0,0,0,0,7.25,1),(3559,'Peace Tree Orange Goose Sour',17,'856411002627',11.99,NULL,6,NULL,0,0,0,0,0,0,8,1),(3560,'Ryan\'s Irish Cream Liqueur',18,'086024015435',14.99,NULL,7,NULL,0,0,0,0,0,0,7.5,1),(3561,'Campo Viejo Rioja Reserva 2014',13,'852832104810',15.99,NULL,5,1,0,0,0,0,2,0,9.25,12),(3562,'Mumm Napa Cuvee M',13,'852832000310',23.99,NULL,5,1,0,0,0,0,2,0,14.25,12),(3563,'Louis Latour Bourgogne Pinot Noir',13,'026861102974',22.99,NULL,5,1,0,0,0,0,2,0,14.25,12),(3564,'Pop-Its',23,'027736022977',0.75,NULL,1,NULL,0,0,0,0,0,0,0.3,1),(3565,'Kitchen Sink Red Blend',13,'653408100522',11.99,NULL,5,1,0,0,0,0,2,0,8.25,12),(3566,'Talisker Single Malt',18,'088076171657',99.99,NULL,7,NULL,0,0,0,0,0,0,75.99,1),(3567,'Modelo Especial 12-Pack Cans',1,'080660957159',20.99,NULL,6,NULL,0,0,0,0,0,0,14.75,1),(3568,'Corona Familiar 24oz Can',1,'033544000250',4.5,NULL,6,NULL,0,0,0,0,0,0,2.6,1),(3569,'Cabreo Toscana',13,'084692422005',44.99,NULL,5,1,0,0,0,0,2,0,26,12),(3570,'Black Diamond 4 Year Cheddar',23,'070153203436',15.99,NULL,4,NULL,0,0,0,0,0,0,10,1),(3571,'Four-Cheese Variety Pack',23,'220721909875',15.99,NULL,4,NULL,0,0,0,0,0,0,10,1),(3572,'Dewars 50ml',18,'080480230074',3.75,NULL,7,NULL,0,0,0,0,0,0,1.9,1),(3573,'James E. Pepper Bourbon',18,'9962789632',35.99,NULL,7,NULL,0,0,0,0,0,0,25.5,1),(3574,'James E. Pepper 1776 Rye',18,'736211596093',35.99,NULL,7,NULL,0,0,0,0,0,0,25.5,1),(3575,'Darenger Rabbit Hole Bourbon',18,'856581006142',88.99,NULL,7,NULL,0,0,0,0,0,0,60.97,1),(3576,'Fuzzy\'s Vodka',18,'0183002007',26.99,NULL,7,NULL,0,0,0,0,0,0,19,1),(3577,'Kinky Aloha',18,'4279002118',1.99,NULL,7,NULL,0,0,0,0,0,0,0.85,1),(3578,'Bombay Sapphire Mini 50ml',18,'08048840',3.99,NULL,7,NULL,0,0,0,0,0,0,2.3,1),(3579,'Dalmore Port Wood Reserve',18,'7647113409',97.99,NULL,7,NULL,0,0,0,0,0,0,75,1),(3580,'Chateau Des Jacques Moulin-A-Vent 2017',13,'084692451142',37.99,NULL,5,1,0,0,0,0,2,0,20.17,12),(3581,'Spanish Manzanilla Olives',3,'4099100091397',3.99,NULL,4,NULL,0,0,0,0,0,0,1.25,1),(3582,'99 Peanut Butter',18,'088004038557',1.99,NULL,7,NULL,0,0,0,0,0,0,1,1),(3583,'Reunion Juice Factory',1,'728028437652',11.99,NULL,6,NULL,0,0,0,0,0,0,8,1),(3584,'Diet Tonic 1 Liter',21,'075450064063',2.99,NULL,59,NULL,0,0,0,0,0,0,1,1),(3585,'Club Soda 1 Liter',21,'075450064049',2.99,NULL,59,NULL,0,0,0,0,0,0,1,1),(3586,'Zoe Roditis & Moscofilero',11,'3997000257',15.99,NULL,5,1,0,0,0,0,2,0,11.25,12),(3587,'George Skouras Moscofilero',11,'663997000172',19.99,NULL,5,1,0,0,0,0,2,0,14.25,12),(3588,'Ritz Toasted Veggie Crisps',3,'044000051099',4.99,NULL,59,NULL,0,0,0,0,0,0,3.25,1),(3589,'Eyzaguirre Syrah',22,'091771013344',12.99,NULL,5,1,0,0,0,0,2,0,7.5,12),(3590,'Dr. Konstantin Frank Semi-Dry Riesling',22,'723388000034',17.99,NULL,5,1,0,0,0,0,2,0,12.75,12),(3591,'Diama Rose Prosecco',22,'087872632904',14.99,NULL,5,1,0,0,0,0,2,0,7.5,12),(3592,'Terrunyo',21,'082734305149',46.99,NULL,5,1,0,0,0,0,2,0,46.99,12),(3593,'Bollicini Sparking Cuvee',21,'816253011485',3.99,NULL,5,1,0,0,0,0,2,0,3.99,12),(3594,'Ferrero Rocher 3-Pack',23,'009800123018',2.75,NULL,59,NULL,0,0,0,0,0,0,1.25,1),(3595,'Habanero Salsa',3,'4099100079487',4.99,NULL,4,NULL,0,0,0,0,0,0,1.75,1),(3596,'BL Tall Boy',1,'01853025',1.5,NULL,6,NULL,0,0,0,0,0,0,1,1),(3597,'Cape Mentelle SB/Semillon 2018',13,'081753050078',16.99,NULL,5,1,0,0,0,0,2,0,10.75,12),(3598,'Jacuzzi Pinot Grigio',13,'899165001003',7.99,NULL,5,1,0,0,0,0,2,0,4,12),(3599,'Cass CAB 2014',13,'895008001452',29.99,NULL,5,1,0,0,0,0,2,0,15,12),(3600,'Chi-Chi\'s Peach Margarita',18,'088004024291',15.99,NULL,7,NULL,0,0,0,0,0,0,9.75,1),(3601,'Margaritaville Skinny Marg',18,'086024009991',13.99,NULL,7,NULL,0,0,0,0,0,0,9.25,1),(3602,'Ardon Creek Rosemary\'s Rose',21,'094922090355',15.75,NULL,5,1,0,0,0,0,2,0,11.19,12),(3603,'Ardon Creek Wings',21,'094922192158',15.75,NULL,5,1,0,0,0,0,2,0,11.19,12),(3604,'2015 Cheval des Andes Cab/Malbec',13,'7790975018492',65.99,NULL,5,1,0,0,0,0,2,0,46.8,12),(3605,'Chateau St. Michelle Red Mountain Cab',13,'088586009372',39.99,NULL,5,1,0,0,0,0,2,0,19,12),(3606,'Kamiki Japanese Whiskey',18,'4589858890125',94.99,NULL,7,NULL,0,0,0,0,0,0,67.86,1),(3607,'Bacardi Lime Mini 50ml',18,'080480984281',1.99,NULL,7,NULL,0,0,0,0,0,0,1.27,1),(3608,'Bacardi Coconut Mini 50ml',18,'080480400668',1.99,NULL,7,NULL,0,0,0,0,0,0,1.27,1),(3609,'Canon 13 Chardonnay',13,'088586008429',14.99,NULL,5,1,0,0,0,0,2,0,10,12),(3610,'Vollereaux Champagne Brut',6,'086785761022',35.99,NULL,5,1,0,0,0,0,2,0,24,12),(3611,'Finest Call Margarita Mix',19,'070491802957',5.99,NULL,59,NULL,0,0,0,0,0,0,3.75,1),(3612,'Amana Pickled Ham',4,'021285300555',11.99,NULL,4,NULL,0,0,0,0,0,0,6.99,1),(3613,'Coors Light 16oz 24-Pack',17,'1990301033',38.99,NULL,6,NULL,0,0,0,0,0,0,29,1),(3614,'Torres Mas La Plana Cabernet 2013',13,'86006470',62.99,NULL,5,1,0,0,0,0,2,0,36,12),(3615,'Single Dorothy\'s Lager',19,'810458030685',3.5,NULL,5,1,0,0,0,0,2,0,2.5,12),(3616,'Avery Barrel-Aged Cucumber Hibiscus Sour',19,'796363071213',8.99,NULL,6,NULL,0,0,0,0,0,0,6,1),(3617,'Altitude Project Cabernet',13,'848375002737',8.99,NULL,5,1,0,0,0,0,2,0,4.5,12),(3618,'Presto Prosecco Brut',13,'727760501607',11.99,NULL,5,1,0,0,0,0,2,0,7.33,12),(3619,'The Originals/Cabernet',13,'848375003147',12.99,NULL,5,1,0,0,0,0,2,0,6.71,12),(3620,'Badia A Passignano Chianti Classico Gran Selezione',13,'088586002502',42.99,NULL,5,1,0,0,0,0,2,0,21,12),(3621,'Jam Jar Sweet White',13,'755738000661',6.99,NULL,5,1,0,0,0,0,2,0,1,12),(3622,'Presto Sparkling Rose',13,'816253011676',14.99,NULL,5,1,0,0,0,0,2,0,7.33,12),(3623,'Foodies Caberbnet',13,'839728002689',10.99,NULL,5,1,0,0,0,0,2,0,4.69,12),(3624,'Haiku Gekkeikan Sake',13,'728817199570',11.99,NULL,5,1,0,0,0,0,2,0,7.43,12),(3625,'Kobai Plum Sake',13,'728817200016',14.99,NULL,5,1,0,0,0,0,2,0,7.05,12),(3626,'Gekkeikan Saki',13,'728817199129',13.99,NULL,5,1,0,0,0,0,2,0,7.05,12),(3627,'High Roller Cabernet 2016',13,'852260004546',19.99,NULL,5,1,0,0,0,0,2,0,3,12),(3628,'I\'m Bananas Over You',18,'084380424618',19.99,NULL,5,1,0,0,0,0,2,0,13.97,12),(3629,'Powers Gold Label',18,'080432530115',34.99,NULL,7,NULL,0,0,0,0,0,0,24.74,1),(3630,'1776 Bourbon',18,'019962789632',38.99,NULL,7,0,0,0,0,0,0,0,25,1),(3631,'Josh Phelps Grounded',13,'839146083529',15.99,NULL,5,1,0,0,0,0,2,0,8.44,12),(3632,'14 Hands Rose Bubbles 375ml Can',13,'088586011108',6.99,NULL,5,1,0,0,0,0,2,0,4.5,12),(3633,'Jalapeno Havarti',3,'4099100133738',6.99,NULL,4,NULL,0,0,0,0,0,0,3.25,1),(3634,'Pepperoni Marinara',3,'4099100166620',6.99,NULL,4,NULL,0,0,0,0,0,0,3.25,1),(3635,'Garden Vegetable Sweet Basil Cheese',3,'4099100166637',6.99,NULL,4,NULL,0,0,0,0,0,0,3.25,1),(3636,'Cipotle Lime Salsa',3,'4099100079463',4.99,NULL,59,NULL,0,0,0,0,0,0,2.25,1),(3637,'Highlands Forty One Paso Cab',22,'087872843294',14.99,NULL,5,1,0,0,0,0,2,0,9.75,12),(3638,'Domaine Du Gros Nore Bandol',22,'761503541437',43.99,NULL,5,1,0,0,0,0,2,0,31.5,12),(3639,'Whistle Pig Farmstock Rye',18,'850001901161',79.99,NULL,7,NULL,0,0,0,0,0,0,55.75,1),(3640,'Pickled Okra Talk O\'Texas',16,'070573666668',6.99,NULL,4,NULL,0,0,0,0,0,0,3.25,1),(3641,'LaPanzanella Garlic Crackers',16,'659000406055',5.75,NULL,4,NULL,0,0,0,0,0,0,2.93,1),(3642,'Jardines Corn Relish',16,'022531502020',6.99,NULL,4,NULL,0,0,0,0,0,0,3.58,1),(3643,'Orange Cherries',21,'400012361470',7.99,NULL,59,NULL,0,0,0,0,0,0,4.5,1),(3644,'4 in 1 BBQ Seasonings',3,'4099100170474',8.25,NULL,59,NULL,0,0,0,0,0,0,4.25,1),(3645,'Priano Pesto 6.7oz',3,'4099100044683',4.99,NULL,59,NULL,0,0,0,0,0,0,2.49,1),(3646,'Coors Light 9-pack 16oz Aluminum',17,'1990301040',14.99,NULL,6,NULL,0,0,0,0,0,0,11.85,1),(3647,'Tabali Vetas Blancas Sauvignon Blanc',13,'833202001878',15.99,NULL,5,1,0,0,0,0,2,0,11.46,12),(3648,'Yago Sangria',13,'088352115351',7.99,NULL,5,1,0,0,0,0,2,0,3.95,12),(3649,'Martini Rossi Moscato',13,'011034500008',8.99,NULL,5,1,0,0,0,0,2,0,4,12),(3650,'RumChata Frappa Chata',18,'890355001414',11.99,NULL,7,NULL,0,0,0,0,0,0,7.75,1),(3651,'Tenuta Sette Ponti Oreno 2014',13,'084692482801',64.99,NULL,5,1,0,0,0,0,2,0,45,12),(3652,'Corvinum Red Blend',13,'712038744817',8.99,NULL,5,1,0,0,0,0,2,0,4.21,12),(3653,'Cedar Ridge Quintessential Single Malt',18,'859824001980',62.99,NULL,7,NULL,0,0,0,0,0,0,42.75,1),(3654,'Gran Centenario Anejo',18,'811538014038',65.99,NULL,7,NULL,0,0,0,0,0,0,46.96,1),(3655,'Tanqueray 750ml',18,'088110110307',29.99,NULL,7,NULL,0,0,0,0,0,0,21.25,1),(3656,'Jameson Whiskey 750ml',18,'080432500170',35.99,NULL,7,NULL,0,0,0,0,0,0,25.74,1),(3657,'Midori Melon',18,'088857003306',25.99,NULL,7,NULL,0,0,0,0,0,0,18.24,1),(3658,'Uncle Nearest Small-Batch Whiskey',18,'040232379123',57.99,NULL,7,NULL,0,0,0,0,0,0,40.99,1),(3659,'Easy Eddy 4-Pack 16oz',1,'787790149101',12.99,NULL,6,NULL,0,0,0,0,0,0,7.5,1),(3660,'Hoegarden Witbier',1,'6150001462',10.99,NULL,6,NULL,0,0,0,0,0,0,7.5,1),(3661,'Labatt Blue',17,'062067051722',9.99,NULL,6,NULL,0,0,0,0,0,0,7,1),(3662,'Blue Cheese Olives',3,'4099100192742',7.99,NULL,4,NULL,0,0,0,0,0,0,3.5,1),(3663,'Hand Sanitizer',21,'850010842387',9.99,NULL,1,NULL,0,0,0,0,0,0,5,1),(3664,'Louis Jadot Chablis',13,'084692433148',28.99,NULL,5,1,0,0,0,0,2,0,20,12),(3665,'Modelo Negra 12-Pack Bottles',1,'080660957876',20.99,NULL,6,NULL,0,0,0,0,0,0,15,1),(3666,'Siesta Key Spiced Rum',18,'852010002020',33.99,NULL,7,NULL,0,0,0,0,0,0,24,1),(3667,'Bitter Truth Orange Flower Water',13,'810255020322',2.99,NULL,4,NULL,0,0,0,0,0,0,1.25,1),(3668,'UV Blue Vodka',18,'087116014381',1.75,NULL,7,NULL,0,0,0,0,0,0,0.75,1),(3669,'Parrot Bay Strawberry Rum',18,'082000002253',15.99,NULL,7,NULL,0,0,0,0,0,0,11.5,1),(3670,'Rebel Yell 100 Bourbon',18,'088352133942',24.99,NULL,7,NULL,0,0,0,0,0,0,16,1),(3671,'Jumbo Queen Pimiento Stuffed Olives',21,'078742236421',6.99,NULL,13,NULL,0,0,0,0,0,0,3.75,1),(3672,'Chateau St. Michelle Mimi Chardonnay',13,'088586005633',18.99,NULL,5,1,0,0,0,0,2,0,11.25,12),(3673,'Hayes Ranch Pinot Grigio',13,'9636175207',13.99,NULL,5,1,0,0,0,0,2,0,7.5,12),(3674,'Barbi Brunello Di Montalcino',13,'089744760937',55.99,NULL,5,1,0,0,0,0,2,0,37.75,12),(3675,'Los Vascos Chardonnay',13,'722358411504',12.99,NULL,5,1,0,0,0,0,2,0,7.5,12),(3676,'Blue Cheese Wedge',21,'681131296427',7.99,NULL,4,NULL,0,0,0,0,0,0,5,1),(3677,'Ring Pop',21,'041116005190',0.75,NULL,59,NULL,0,0,0,0,0,0,0.4,1),(3678,'Le Petit Clos Apalta 2014',13,'088110832254',61.99,NULL,5,1,0,0,0,0,2,0,45,12),(3679,'Hayes Ranch Pinot Grigio',13,'089636175207',13.99,NULL,5,1,0,0,0,0,2,0,9,12),(3680,'Blue Corn Chips',21,'4099100019254',4.99,NULL,59,NULL,0,0,0,0,0,0,2.99,1),(3681,'Cayman Jack Margarita 12-Pack',17,'815829011119',19.99,NULL,6,NULL,0,0,0,0,0,0,14,1),(3682,'Founders All Day IPA',17,'642860150244',10.99,NULL,6,NULL,0,0,0,0,0,0,6.75,1),(3683,'Fishback First Crush',17,'856527008001',11.99,NULL,6,NULL,0,0,0,0,0,0,7.5,1),(3684,'Fishback Salty Sailor',17,'856527008032',11.99,NULL,6,NULL,0,0,0,0,0,0,8,1),(3685,'Cheese Curds',3,'4099100145236',6.99,NULL,4,NULL,0,0,0,0,0,0,4.25,1),(3686,'Cheese Curds',3,'4099100145199',6.99,NULL,4,NULL,0,0,0,0,0,0,4.25,1),(3687,'Edam Cheese Wheel',3,'4099100166491',6.99,NULL,4,NULL,0,0,0,0,0,0,3.25,1),(3688,'White Stilton with Lemon',3,'4099100194180',6.99,NULL,4,NULL,0,0,0,0,0,0,3.75,1),(3689,'Dasani Water',21,'049000026566',1.99,NULL,4,NULL,0,0,0,0,0,0,1.25,1),(3690,'WB Saffell Bourbon',18,'721059002943',59.99,NULL,7,NULL,0,0,0,0,0,0,38.5,1),(3691,'Wild Turkey Kentucky Spirit Sigle Barrel',18,'721059947503',68.99,NULL,7,NULL,0,0,0,0,0,0,46,1),(3692,'Don Julio Blanco',18,'674545000001',63.99,NULL,7,NULL,0,0,0,0,0,0,45.25,1),(3693,'Nipozzano Chianti Riserva 2015',13,'877397000018',23.99,NULL,5,1,0,0,0,0,2,0,16.5,12),(3694,'Caravella Limoncello',18,'088004024468',26.99,NULL,7,NULL,0,0,0,0,0,0,17.88,1),(3695,'Restaurant Style Chips',3,'4099100066944',2.99,NULL,59,NULL,0,0,0,0,0,0,1.75,1),(3696,'Germ-X Sanitizer',3,'072785138643',4.99,NULL,1,NULL,0,0,0,0,0,0,2.89,1),(3697,'Feta Cheese Stuffed Olives',3,'078742236452',6.99,NULL,4,NULL,0,0,0,0,0,0,3,1),(3698,'Hugel Acsase Pinot Blanc',13,'089744757227',23.99,NULL,5,1,0,0,0,0,2,0,16.5,12),(3699,'Old Soul Pinot Noir',13,'082544990474',12.99,NULL,5,1,0,0,0,0,2,0,9,12),(3700,'719 Rose',13,'082242015158',8.99,NULL,5,1,0,0,0,0,2,0,4.75,12),(3701,'Sign',21,'826635201700',4.99,NULL,1,NULL,0,0,0,0,0,0,3,1),(3702,'Inniskillin Ice Wine',13,'620654011230',59.99,NULL,5,1,0,0,0,0,2,0,36,12),(3703,'Hogue Gewurtztraminer',19,'087754000500',10.99,NULL,5,1,0,0,0,0,2,0,5.61,12),(3704,'Gloden Road Mango Cart',1,'856895003844',11.99,NULL,6,NULL,0,0,0,0,0,0,7.75,1),(3705,'Corona Extra 12-Pack Cans',1,'080660956954',21.99,NULL,6,NULL,0,0,0,0,0,0,15.58,1),(3706,'Fresh Mozzerella',23,'031142000689',7.99,NULL,4,NULL,0,0,0,0,0,0,4,1),(3707,'Bud Light Lemonade 12-Pack Cans',1,'018200202094',17.99,NULL,6,NULL,0,0,0,0,0,0,13.34,1),(3708,'Starmont Pinot Noir Rose',21,'040426992114',21.99,NULL,5,1,0,0,0,0,2,0,12,12),(3709,'Pommery Brut Royal',13,'694190002847',43.99,NULL,5,1,0,0,0,0,2,0,25.83,12),(3710,'Basil Hayden Rye',18,'080686012146',48.99,NULL,7,NULL,0,0,0,0,0,0,35.93,1),(3711,'Starmont Sauvignon Blanc',13,'040426992213',10.99,NULL,5,1,0,0,0,0,2,0,5,12),(3712,'Michael David Petite Petit',13,'652935100210',18.99,NULL,5,1,0,0,0,0,2,0,13,12),(3713,'Pink Whitney 750ml',18,'085000031353',16.99,NULL,7,NULL,0,0,0,0,0,0,11.75,1),(3714,'Pirouline Creme-Filled Wafers Hazelnut',21,'042456058044',3.5,NULL,59,NULL,0,0,0,0,0,0,1.25,1),(3715,'Plastic Drink Swords',21,'011225139567',3.95,NULL,1,NULL,0,0,0,0,0,0,2.25,1),(3716,'Las Mulas Cabernet',13,'088586006838',9.99,NULL,5,1,0,0,0,0,2,0,4,12),(3717,'Legaris Crianza',13,'8437003962004',13.99,NULL,5,1,0,0,0,0,2,0,6,12),(3718,'Galena Priorat 2015',13,'8437006680028',24.99,NULL,5,1,0,0,0,0,2,0,15,12),(3719,'Moet & Chandon Brut',13,'088110551056',65.99,NULL,5,1,0,0,0,0,2,0,46.8,12),(3720,'Ciderboys Peach 4-Oack Cans',1,'088733902167',8.99,NULL,6,NULL,0,0,0,0,0,0,5.5,1),(3721,'Sutliff Rose Cider',1,'852380004396',12.99,NULL,6,NULL,0,0,0,0,0,0,9.5,1),(3722,'Black Velvet',18,'096749003044',22.25,NULL,7,NULL,0,0,0,0,0,0,18,1),(3723,'Big grove Straw Lemonade Sour',1,'644216220274',10.99,NULL,6,NULL,0,0,0,0,0,0,8,1),(3724,'Shock Top Lemon Shandy',1,'018200179938',10.99,NULL,6,NULL,0,0,0,0,0,0,7.25,1),(3725,'Canada Dry Diet Tonic 1 Liter',21,'078000149456',2.99,NULL,59,NULL,0,0,0,0,0,0,1.58,1),(3726,'Mini Cornichons',21,'00006163',5.99,NULL,4,NULL,0,0,0,0,0,0,3.99,1),(3727,'Arrow Peach',18,'088352118475',13.99,NULL,7,NULL,0,0,0,0,0,0,8.5,1),(3728,'Pyrat XO Reserve Rum',18,'721733100026',29.99,NULL,7,NULL,0,0,0,0,0,0,20.64,1),(3729,'Disaronno Velvet Cream',18,'050037597752',37.99,NULL,7,NULL,0,0,0,0,0,0,25.8,1),(3730,'Cincoro Reposado Tequila',18,'850008649035',98.99,NULL,7,NULL,0,0,0,0,0,0,76,1),(3731,'Farm Chard',13,'853706002089',19.99,NULL,5,1,0,0,0,0,2,0,13,12),(3732,'Blue Chair Bay Banana Rum',18,'856881004145',19.99,NULL,7,NULL,0,0,0,0,0,0,14.75,1),(3733,'Dulce Vita grapefruit Tequila',18,'898432002507',24.99,NULL,7,NULL,0,0,0,0,0,0,17.25,1),(3734,'Hatozaki Small-Batch Japanese Whiskey',18,'080368800801',73.99,NULL,7,NULL,0,0,0,0,0,0,52.94,1),(3735,'Kitchen Towel',21,'673078332771',3.99,NULL,1,NULL,0,0,0,0,0,0,1.5,1),(3736,'Villa Maria Pinot Noir',13,'088586004377',14.99,NULL,5,1,0,0,0,0,2,0,10,12),(3737,'Modelo Mango Chile 24oz Can',1,'033544000267',4.75,NULL,6,NULL,0,0,0,0,0,0,2.35,1),(3738,'Coors Light',17,'071990301040',14.99,NULL,6,NULL,0,0,0,0,0,0,10,1),(3739,'Saint Come Condrieu White',14,'3483819000008',79.99,NULL,5,1,0,0,0,0,2,0,63,12),(3740,'Saint Come Gigondas 2018',14,'3483811000006',54.99,NULL,5,1,0,0,0,0,2,0,42,12),(3741,'Saint Come Saint-Joseph 2018',14,'3483815000002',39.99,NULL,5,1,0,0,0,0,2,0,29.25,12),(3742,'Squoosh-Ohs',21,'765940943502',14.99,NULL,1,NULL,0,0,0,0,0,0,10,1),(3743,'Saint Roch Chimeres Grenache',22,'3760031472272',19.99,NULL,5,1,0,0,0,0,2,0,14.25,12),(3744,'Lolita Glass Leo',21,'704519064569',14.99,NULL,1,NULL,0,0,0,0,0,0,10,1),(3745,'Leewin Chard',22,'7749006617',79.63,NULL,5,1,0,0,0,0,2,0,61.25,12),(3746,'Leeuwin Chard',22,'767749006617',83.99,NULL,5,1,0,0,0,0,2,0,60,12),(3747,'Aquafina Water',21,'01215704',1.99,NULL,4,NULL,0,0,0,0,0,0,1,1),(3748,'Fun Dip',21,'079200005795',0.75,NULL,59,NULL,0,0,0,0,0,0,0.35,1),(3749,'Coke 12-Pack',21,'049000028904',6.99,NULL,59,NULL,0,0,0,0,0,0,4.5,1),(3750,'Mozzerella Pearls',23,'031142004960',5.99,NULL,4,NULL,0,0,0,0,0,0,4,1),(3751,'99 Lemon Lime',18,'088004039677',1.99,NULL,7,NULL,0,0,0,0,0,0,1.05,1),(3752,'Ole Smoky Moonshine Peaches',18,'856011004861',27.99,NULL,7,NULL,0,0,0,0,0,0,19.75,1),(3753,'Clos de los Siete Malbec Blend',13,'876987000018',20.99,NULL,5,1,0,0,0,0,2,0,12.75,12),(3754,'Lolea White Sangria Frizzante',13,'8437014256024',14.7,NULL,5,1,0,0,0,0,2,0,10.5,12),(3755,'Blue Curacao',18,'086816101445',12.99,NULL,7,NULL,0,0,0,0,0,0,8.5,1),(3756,'Tippy Cow 8-Pack Sampler',18,'857359008122',11.99,NULL,7,NULL,0,0,0,0,0,0,6.99,1),(3757,'Tippy Cow Shamrock Mint',18,'857359008078',21.99,NULL,7,NULL,0,0,0,0,0,0,15.5,1),(3758,'Elijah Craig Toasted Barrel',18,'096749002870',54.99,NULL,7,NULL,0,0,0,0,0,0,38.5,1),(3759,'Silver Palm Sauvignon Blanc',13,'768035815715',9.99,NULL,5,1,0,0,0,0,2,0,4,12),(3760,'Mandra Rossa Chardonnay',13,'086785581767',9.99,NULL,5,1,0,0,0,0,2,0,5,12),(3761,'99 Blue Raspberries Mini 50ml',18,'088004039660',1.99,NULL,7,NULL,0,0,0,0,0,0,1.1,1),(3762,'Fireball Party Cooler',18,'088004039042',24.99,NULL,7,NULL,0,0,0,0,0,0,16,1),(3763,'Steak Sauce',21,'078742429571',2.99,NULL,4,NULL,0,0,0,0,0,0,1.5,1),(3764,'Toffee Crunch Chocolate Bar',3,'4099100086317',4.5,NULL,59,NULL,0,0,0,0,0,0,1.99,1),(3765,'Milk Chocolate Bar',3,'4099100086300',4.5,NULL,59,NULL,0,0,0,0,0,0,2.5,1),(3766,'Dark Sea Salt & Caramel Bar',3,'4099100118575',4.5,NULL,59,NULL,0,0,0,0,0,0,2.5,1),(3767,'Big Grove Pineapple Cherry Swirl',1,'787790151104',11.99,NULL,6,NULL,0,0,0,0,0,0,7.8,1),(3768,'Loon Juice Variety 12-Pack',1,'857463006069',22.99,NULL,6,NULL,0,0,0,0,0,0,16,1),(3769,'Kosher Dill Spears',3,'4099100115284',4.99,NULL,4,NULL,0,0,0,0,0,0,1.75,1),(3770,'Bunny Blue Berry saki',22,'895736000086',11.99,NULL,5,1,0,0,0,0,2,0,7.25,12),(3771,'Vizzy',17,'03410001232',19.99,NULL,6,NULL,0,0,0,0,0,0,14.2,1),(3772,'Bud Light 18-Pack Cans',1,'018200532184',22.99,NULL,6,NULL,0,0,0,0,0,0,16.4,1),(3773,'Sea Salt & Black Pepper Crackers',21,'078742159973',3.99,NULL,4,NULL,0,0,0,0,0,0,1.99,1),(3774,'Mike\'s Harder Black Cherry',17,'635985010128',2.99,NULL,6,NULL,0,0,0,0,0,0,1.28,1),(3775,'Renwood BBQ Zinfandel',13,'087969380022',6.99,NULL,5,1,0,0,0,0,2,0,6,12),(3776,'Stemmari Rose',13,'854559000208',9.99,NULL,5,1,0,0,0,0,2,0,4,12),(3777,'Patient Cottat Sancerre',13,'089419140965',23.99,NULL,5,1,0,0,0,0,2,0,12.58,12),(3778,'Statti Arvino Red Blend',13,'716898961612',9.99,NULL,5,1,0,0,0,0,2,0,5,12),(3779,'Loureiro Vinho Verde',13,'098709443501',8.99,NULL,5,1,0,0,0,0,2,0,4,12),(3780,'Organic Medium Salsa',3,'4099100021615',4.99,NULL,4,NULL,0,0,0,0,0,0,2.5,1),(3781,'Absolut Citron 750ml',18,'835229001305',21.99,NULL,7,NULL,0,0,0,0,0,0,15,1),(3782,'Gluten Free Ancient Grains Crackers',3,'4099100004144',3.99,NULL,59,NULL,0,0,0,0,0,0,2.89,1),(3783,'Hickory Smoke Almonds',3,'4099100015065',7.99,NULL,4,NULL,0,0,0,0,0,0,4.5,1),(3784,'Lagunitas Hazy Wonder',17,'723830130067',11.99,NULL,6,NULL,0,0,0,0,0,0,8,1),(3785,'Valdo Numero Uno',14,'086785310008',12.99,NULL,5,1,0,0,0,0,2,0,8,12),(3786,'Dark Orange Almond Chocolate Bar',1,'4099100086287',4.5,NULL,59,NULL,0,0,0,0,0,0,2.25,1),(3787,'Vizzy Hard Seltzer',17,'034100012328',19.99,NULL,6,NULL,0,0,0,0,0,0,14.2,1),(3788,'Kinky Ruby Minis 50ml',18,'084279003061',1.99,NULL,7,NULL,0,0,0,0,0,0,1.05,1),(3789,'Masterson\'s',18,'856442005154',97.99,NULL,7,NULL,0,0,0,0,0,0,85,1),(3790,'St James Mango',13,'088582000137',14.99,NULL,5,1,0,0,0,0,2,0,10,12),(3791,'Blue Chair Bay Rum',18,'856881004596',20.99,NULL,7,NULL,0,0,0,0,0,0,20,1),(3792,'Precarious Rose',13,'839146078037',10.99,NULL,5,1,0,0,0,0,2,0,5.75,12),(3793,'Puff Pastry Twists',3,'4099100186093',4.99,NULL,59,NULL,0,0,0,0,0,0,2.25,1),(3794,'Korbel 1.75 Brandy',18,'084704000290',24.99,NULL,7,NULL,0,0,0,0,0,0,17.75,1),(3795,'Lapostolle Merlot',13,'088110831257',14.99,NULL,5,1,0,0,0,0,2,0,11,12),(3796,'Bourbon County Three-Pack',18,'080686000099',47.99,NULL,7,NULL,0,0,0,0,0,0,34,1),(3797,'Whistle Pig 50ml',18,'851460002642',8.99,NULL,7,NULL,0,0,0,0,0,0,6,1),(3798,'Tiki Lovers Rum',18,'8102550205132',27.99,NULL,7,NULL,0,0,0,0,0,0,19.75,1),(3799,'Whistle Pig Home Stock',18,'850001901543',77.99,NULL,5,1,0,0,0,0,2,0,55.75,12),(3800,'ET 51 Vodka',18,'8451609308',32.99,NULL,7,NULL,0,0,0,0,0,0,22.89,1),(3801,'Calumet 14 Year Bourbon',18,'812459014565',119.99,NULL,7,NULL,0,0,0,0,0,0,89.48,1),(3802,'Peach be with You',21,'895250001361',13.99,NULL,5,1,0,0,0,0,2,0,9.99,12),(3803,'Jim Beam mini 50ml',18,'080686006893',1.99,NULL,7,NULL,0,0,0,0,0,0,1,1),(3804,'Golden Pinot Noir',14,'850832004529',14.99,NULL,5,1,0,0,0,0,2,0,9.75,12),(3805,'Jalapeno Olives',3,'4099100192759',7.99,NULL,4,NULL,0,0,0,0,0,0,4,1),(3806,'Ciderboys Variety Pack',1,'088733900903',21.99,NULL,6,NULL,0,0,0,0,0,0,17,1),(3807,'Middle Sister Bubbly Pink',13,'857151003417',9.99,NULL,5,1,0,0,0,0,2,0,5,12),(3808,'Foodies Pinot Grigio',13,'839728009268',10.99,NULL,5,1,0,0,0,0,2,0,4.69,12),(3809,'Knob Creek Cask Strength',18,'0686016595',74.99,NULL,7,NULL,0,0,0,0,0,0,53.5,1),(3810,'BV Toasted Caramel 1.75ml',18,'088100135037',27.99,NULL,7,NULL,0,0,0,0,0,0,20.49,1),(3811,'Absente',18,'689768211028',48.99,NULL,7,NULL,0,0,0,0,0,0,35.01,1),(3812,'Saints & Sinners Mini 50ml',18,'854781004616',1.99,NULL,7,NULL,0,0,0,0,0,0,1,1),(3813,'The Bitter truth Traveler\'s Set',18,'810255020216',21.99,NULL,7,NULL,0,0,0,0,0,0,15.25,1),(3814,'The Bitter Truth Bar Pack',18,'810255020421',21.99,NULL,7,NULL,0,0,0,0,0,0,15.25,1),(3815,'Hakutsuru Nigori Saki',22,'20013',9.99,NULL,5,1,0,0,0,0,2,0,6.5,12),(3816,'Hakutsuru Draft Saki 300ml',22,'747846010083',7.99,NULL,5,1,0,0,0,0,2,0,4.5,12),(3817,'Hakutsuru Junmai Gingo Superior 300ml',22,'747846010021',11.99,NULL,5,1,0,0,0,0,2,0,7.5,12),(3818,'Kraken Black Rum',18,'811538014588',23.99,NULL,7,NULL,0,0,0,0,0,0,16.68,1),(3819,'Makers Mark Personalized Label',18,'085246501122',43.99,NULL,7,NULL,0,0,0,0,0,0,30.75,1),(3820,'Hahn SLH Pinot Noir',13,'086788018871',24.99,NULL,5,1,0,0,0,0,2,0,16.75,12),(3821,'Segram\'s Escapes Variety Pack',17,'0432802908',15.99,NULL,6,NULL,0,0,0,0,0,0,11,1),(3822,'Wine Tasting Party Kit',21,'-87-790979190801',14.99,NULL,1,NULL,0,0,0,0,0,0,14.99,1),(3823,'Busch Light Apple',1,'018200202483',18.99,NULL,6,NULL,0,0,0,0,0,0,11.56,1),(3824,'Valdo 1',13,'086785310015',12.99,NULL,5,1,0,0,0,0,2,0,6,12),(3825,'Pflucken Riesling',10,'756107169',16.99,NULL,5,1,0,0,0,0,2,0,11.55,12),(3826,'Korbel Brut',19,'084704091328',15.99,NULL,5,1,0,0,0,0,2,0,12,12),(3827,'Bacon Cheddar Jalapeno Cheddar',3,'99100211184',6.99,NULL,4,NULL,0,0,0,0,0,0,3.5,1),(3828,'Busch Light Apple 16oz 6-Pack',1,'018200261206',12.99,NULL,6,NULL,0,0,0,0,0,0,7,1),(3829,'Pflucken Riesling',22,'084756107169',17.99,NULL,5,1,0,0,0,0,2,0,13,12),(3830,'Busch Light Apple Single',1,'018200001598',2.5,NULL,6,NULL,0,0,0,0,0,0,1,1),(3831,'Malibu Splash Strawberry Coconut',1,'089540535364',11.99,NULL,6,NULL,0,0,0,0,0,0,8,1),(3832,'Godiva Chocolate Liqueur',18,'08731108',36.99,NULL,7,NULL,0,0,0,0,0,0,26,1),(3833,'Cedar Ridge Bottled in Bond',18,'859824001973',53.99,NULL,7,0,0,0,0,0,0,0,38.5,1),(3834,'Crystal head Three-Pack Vodka',19,'627040411667',28.99,NULL,7,NULL,0,0,0,0,0,0,20.74,1),(3835,'Crown Royal Salted Caramel',18,'082000783978',34.99,NULL,7,NULL,0,0,0,0,0,0,24.64,1),(3836,'Smirnoff Red White Berry Mini 50ml',18,'08253202',1.99,NULL,7,NULL,0,0,0,0,0,0,1.5,1),(3837,'Ole Smoky Salty Caramel Whiskey 50ml',18,'854628006841',4.75,NULL,7,NULL,0,0,0,0,0,0,2.37,1),(3838,'Crystal Head with Shot Glasses',18,'627040411643',53.99,NULL,7,NULL,0,0,0,0,0,0,38.49,1),(3839,'Cherry Pir Pinot Noir',13,'896599002118',48.99,NULL,5,1,0,0,0,0,2,0,26,12),(3840,'Firesteed Pinot Noir',13,'753526100005',15.99,NULL,5,1,0,0,0,0,2,0,11,12),(3841,'Daviess County French Oak Bourbon',18,'088352134802',53.99,NULL,7,NULL,0,0,0,0,0,0,38.5,1),(3842,'Little Book Chapter 04',19,'080686011293',118.99,NULL,3,NULL,0,0,0,0,0,0,94.5,1),(3843,'Rum Chata Limon',18,'890355001513',27.99,NULL,7,NULL,0,0,0,0,0,0,20,1),(3844,'Ice Hole Butterscotch',18,'087116035539',11.99,NULL,7,NULL,0,0,0,0,0,0,8.25,1),(3845,'Ice Hole Plum 1Liter',18,'087116035669',14.99,NULL,7,NULL,0,0,0,0,0,0,10.63,1),(3846,'Bulleit Rye 750ml',18,'082000752967',35.99,NULL,7,NULL,0,0,0,0,0,0,25.5,1),(3847,'Bacon Cheddar Jalapen Cheese',3,'4099100211184',6.99,NULL,4,NULL,0,0,0,0,0,0,5,1),(3848,'Ritz Whole Wheat',23,'044000031336',4.75,NULL,4,NULL,0,0,0,0,0,0,2.25,1),(3849,'Ritz Crackers',23,'044000031114',4.75,NULL,4,NULL,0,0,0,0,0,0,2.25,1),(3850,'Sociables Crackers',23,'044000030483',4.75,NULL,4,NULL,0,0,0,0,0,0,2.25,1),(3851,'Triscuit Crackers',23,'044000050986',4.75,NULL,4,NULL,0,0,0,0,0,0,2.25,1),(3852,'White Cheddar Cheese',3,'4099100121261',6.99,NULL,4,NULL,0,0,0,0,0,0,3,1),(3853,'Buttery Crisp Crackers',3,'041498110901',4.99,NULL,4,NULL,0,0,0,0,0,0,2.5,1),(3854,'Seagrams Escapes',17,'080432802908',15.99,NULL,6,NULL,0,0,0,0,0,0,11,1),(3855,'La Fleur Sauternes',11,'714320078693',27.99,NULL,5,1,0,0,0,0,2,0,19.5,12),(3856,'Tostitos',21,'028400036337',4.29,NULL,59,NULL,0,0,0,0,0,0,3,1),(3857,'Rock Wall 2016 Zinfandel',11,'899601002083',21,NULL,5,1,0,0,0,0,2,0,12.55,12),(3858,'Smith Madrone Napa Cabernet',11,'704470300003',59.99,NULL,5,1,0,0,0,0,2,0,42.8,12),(3859,'Falcone Chardonnay',11,'085030200309',37.99,NULL,5,1,0,0,0,0,2,0,27,12),(3860,'Alpha Omega Cabernet',11,'892283001344',109.99,NULL,5,1,0,0,0,0,2,0,84.05,12),(3861,'In Violas Merlot',11,'748789400016',18.99,NULL,5,1,0,0,0,0,2,0,12,12),(3862,'Weller Full Proof',18,'088004031497',69.99,NULL,7,NULL,0,0,0,0,0,0,38,1),(3863,'Stagg Jr. Bourbon',18,'088004018580',99.99,NULL,7,NULL,0,0,0,0,0,0,39.5,1),(3864,'Cass Marsanne',13,'895008001391',13.99,NULL,5,1,0,0,0,0,2,0,8.5,12),(3865,'Chocolate Cherry Baileys',18,'086767704436',34.99,NULL,7,NULL,0,0,0,0,0,0,25.25,1),(3866,'Fireball 375ml',18,'088004144722',11.99,NULL,7,NULL,0,0,0,0,0,0,8.5,1),(3867,'Ice Hole Salty Caramel',18,'087116036178',11.99,NULL,7,NULL,0,0,0,0,0,0,8.25,1),(3868,'Candy Dry Rose',13,'853706002188',12.99,NULL,5,1,0,0,0,0,2,0,4.5,12),(3869,'Blue Marble Bloody Mary',13,'856508007078',9.99,NULL,7,NULL,0,0,0,0,0,0,3.5,1),(3870,'Crown Apple 375ml',18,'082000771548',10.99,NULL,7,NULL,0,0,0,0,0,0,7.58,1),(3871,'Lodi Estates Cabernet',13,'082544007424',16.99,NULL,5,1,0,0,0,0,2,0,10.75,12),(3872,'Farmstead Pinot Noir',13,'894591002136',24.99,NULL,5,1,0,0,0,0,2,0,12.58,12),(3873,'Columbia Crest Reserve Cabernet',13,'088586419973',31.99,NULL,5,1,0,0,0,0,2,0,19,12),(3874,'Orbit Bubblemint Gum',23,'02248905',1.75,NULL,59,NULL,0,0,0,0,0,0,1,1),(3875,'Cuvaison Chardonnay',13,'082148019823',21.99,NULL,5,1,0,0,0,0,2,0,13.5,12),(3876,'Falcone Syrah',11,'085030200316',37.99,NULL,5,1,0,0,0,0,2,0,27,12),(3877,'Falcone Cabernet',11,'085030200323',45.99,NULL,5,1,0,0,0,0,2,0,33,12),(3878,'Enrico Serafino Brut Rose',11,'748789740112',34.99,NULL,5,1,0,0,0,0,2,0,24,12),(3879,'Dulce Vida 4-Pack Palomas',13,'898432002927',9.99,NULL,7,NULL,0,0,0,0,0,0,4,1),(3880,'Fuzzy\'s Vodke',18,'850183002007',25.99,NULL,7,NULL,0,0,0,0,0,0,18,1),(3881,'Garlic Stuffed Olives',3,'4099100192766',7.99,NULL,4,NULL,0,0,0,0,0,0,3.25,1),(3882,'Gluten Free Sea Salt Crackers',3,'4099100004137',3.99,NULL,4,NULL,0,0,0,0,0,0,2.25,1),(3883,'Frambois Set',1,'085725108330',25.99,NULL,6,NULL,0,0,0,0,0,0,18,1),(3884,'Blue Marble Mojito 4-Packs',13,'856508007085',9.99,NULL,5,4,0,0,0,0,2,0,7,8),(3885,'Revenant Rye Whiskey',18,'860003102411',30.99,NULL,7,NULL,0,0,0,0,0,0,22.5,1),(3886,'Revenant Rye',18,'860003102404',31.99,NULL,7,NULL,0,0,0,0,0,0,22.5,1),(3887,'Ghirardelli Raspberry Chocolates',21,'747599306532',5.99,NULL,59,NULL,0,0,0,0,0,0,4,1),(3888,'Ghirardelli Sea Salt Caramel',21,'747599303142',5.99,NULL,15,NULL,0,0,0,0,0,0,4,1),(3889,'Mixed Cheese Curds',3,'4099100145205',6.99,NULL,4,NULL,0,0,0,0,0,0,4.75,1),(3890,'Spekulstius Spiced Cookies',3,'4099100118667',4.99,NULL,59,NULL,0,0,0,0,0,0,1.99,1),(3891,'Titos Vodka 750ml',18,'619947000020',21.99,NULL,7,NULL,0,0,0,0,0,0,15.5,1),(3892,'Glen Moray Sherry Cask',18,'084279001517',37.99,NULL,7,NULL,0,0,0,0,0,0,27.26,1),(3893,'Glan Moray Cabernet Cask',18,'084279002828',37.99,NULL,7,NULL,0,0,0,0,0,0,27.26,1),(3894,'Haku Vodka 750ml',18,'080686958024',32.99,NULL,7,NULL,0,0,0,0,0,0,23,1),(3895,'Glass Manor Irish Whiskey',18,'088004042301',21.99,NULL,7,NULL,0,0,0,0,0,0,15.5,1),(3896,'Craigellachie 13 Year Scotch',18,'080480005382',58.99,NULL,7,NULL,0,0,0,0,0,0,41.75,1),(3897,'Plantation Original Dark Rum',18,'695521151456',24.99,NULL,7,NULL,0,0,0,0,0,0,14.75,1),(3898,'Sam Smith Nut Brown Ale',1,'085725317008',12.99,NULL,6,NULL,0,0,0,0,0,0,9.25,1),(3899,'Big Grove Double Blackberry',1,'644216268306',10.99,NULL,6,NULL,0,0,0,0,0,0,7.75,1),(3900,'Stags leap Artemis 2009',21,'088593700200',56.99,NULL,5,1,0,0,0,0,2,0,35,12),(3901,'Moscow Mule',13,'856508007719',9.99,NULL,7,NULL,0,0,0,0,0,0,6,1),(3902,'Clyde Mays Alabama Style Whiskey',18,'056160000015',35.53,NULL,7,NULL,0,0,0,0,0,0,25.38,1),(3903,'Dulce Vida Paloma',13,'898432002866',2.99,NULL,7,NULL,0,0,0,0,0,0,2,1),(3904,'Altesimo Brunello Di Montalcino',13,'098709082403',67.99,NULL,5,1,0,0,0,0,2,0,48,12),(3905,'Castel Giocondo Brunello Di Montalcino',13,'839183000053',69.99,NULL,5,1,0,0,0,0,2,0,43.04,12),(3906,'Mailbu 750ml',18,'089540448992',16.99,NULL,7,NULL,0,0,0,0,0,0,11.74,1),(3907,'Fever Tree Elderflower Tonic',13,'898195001656',6.99,NULL,59,NULL,0,0,0,0,0,0,4,1),(3908,'Kris Pnot Grigio',13,'098709436893',14.99,NULL,5,1,0,0,0,0,2,0,7.5,12),(3909,'Dole 24-Pack Pinealpple Juice',23,'038900773700',19.99,NULL,59,NULL,0,0,0,0,0,0,12.99,1),(3910,'Bruichladdich Classic Laddie Scottish Barley',18,'087236700386',63.99,NULL,7,NULL,0,0,0,0,0,0,45.5,1),(3911,'Ardbeg AN OA',18,'081753832964',60.99,NULL,7,NULL,0,0,0,0,0,0,43.25,1),(3912,'Makers Mark 750ml',19,'085246139431',37.99,NULL,7,NULL,0,0,0,0,0,0,26.75,1),(3913,'Deli Salame Trio Pack',23,'736436855807',18.99,NULL,4,NULL,0,0,0,0,0,0,12,1),(3914,'Secret Cellar T-Shirt 2020',21,'4099100121179',17.99,NULL,1,NULL,0,0,0,0,0,0,10,1),(3915,'99 Mangos',21,'088004030261',1.99,NULL,7,NULL,0,0,0,0,0,0,1.99,1),(3916,'Pepsi',21,'01280504',1,NULL,15,NULL,0,0,0,0,0,0,1,1),(3917,'The Whistler Double Oaked',18,'815755020285',37.99,NULL,7,NULL,0,0,0,0,0,0,26.75,1),(3918,'Nooku Bourbon Cream',18,'852045007069',35.99,NULL,7,NULL,0,0,0,0,0,0,25.5,1),(3919,'Angels Envy Finished Rye',18,'850047003065',94.99,NULL,7,NULL,0,0,0,0,0,0,68,1),(3920,'Crabbie\'s Orignal',21,'848557000025',3.99,NULL,6,NULL,0,0,0,0,0,0,3.99,1),(3921,'Richmond Rye Whiskey',18,'895412001093',73.99,NULL,7,NULL,0,0,0,0,0,0,52.23,1),(3922,'Jeppson\'s Bourbon',18,'50995005845',28.99,NULL,7,NULL,0,0,0,0,0,0,20.51,1),(3923,'Jeppson\'s Bourbon',18,'850995005845',28.99,NULL,7,NULL,0,0,0,0,0,0,20.51,1),(3924,'Caravella Limoncello',18,'080660776057',24.99,NULL,7,NULL,0,0,0,0,0,0,17.38,1),(3925,'99 Blackcherry',21,'080660113692',1.99,NULL,7,NULL,0,0,0,0,0,0,1.99,1),(3926,'Peanuts',23,'029000017931',1.49,NULL,4,NULL,0,0,0,0,0,0,0.89,1),(3927,'Quadro Vodka',18,'736040017547',27.99,NULL,7,NULL,0,0,0,0,0,0,19.5,1),(3928,'Cedar Ridge Sir Maple',18,'859824001454',48.99,NULL,7,NULL,0,0,0,0,0,0,35,1),(3929,'Skrewball 375ml',18,'860265002450',26.99,NULL,7,NULL,0,0,0,0,0,0,19.25,1),(3930,'Bailey\'s 750ml',18,'086767210067',35.99,NULL,7,NULL,0,0,0,0,0,0,25.25,1),(3931,'Diplomatico Reserva Rum',18,'7594003620394',42.99,NULL,7,NULL,0,0,0,0,0,0,30.5,1),(3932,'Sazerac Rye Whiskey',18,'088004139940',45.99,NULL,7,NULL,0,0,0,0,0,0,26,1),(3933,'Jack Daniels Single Barrel',18,'082184087008',58.99,NULL,7,NULL,0,0,0,0,0,0,41.89,1),(3934,'Crav\'n Multigrain Crackers',16,'036800474338',3.99,NULL,59,NULL,0,0,0,0,0,0,1.99,1),(3935,'Whiskey Business Cheddar',3,'4099100127003',7.99,NULL,4,NULL,0,0,0,0,0,0,3.89,1),(3936,'Gaelic Glory Irish Cheddar with Irish Creme',3,'4099100126990',7.99,NULL,4,NULL,0,0,0,0,0,0,3.89,1),(3937,'Boursin Garlic & Herb',3,'079813000118',7.99,NULL,4,NULL,0,0,0,0,0,0,3.89,1),(3938,'Rose All Day Cheese',3,'4099100215618',7.99,NULL,4,NULL,0,0,0,0,0,0,3.99,1),(3939,'Applewood Smoked Gouda 8oz',3,'4099100134438',7.99,NULL,4,NULL,0,0,0,0,0,0,3.99,1),(3940,'Cabot Seriously Sharp Cheddar',3,'078354719046',7.99,NULL,4,NULL,0,0,0,0,0,0,3.99,1),(3941,'1,000 Day Aged Gouda',3,'4099100139907',7.99,NULL,4,0,0,0,0,0,0,0,3.99,1),(3942,'Peanut M & M\'s',23,'040000000327',1.49,NULL,59,NULL,0,0,0,0,0,0,0.75,1),(3943,'Skittles',23,'040000001607',1.49,NULL,59,NULL,0,0,0,0,0,0,0.75,1),(3944,'Kit Kat',21,'03424607',1.49,NULL,59,NULL,0,0,0,0,0,0,0.75,1),(3945,'Hershey with Almonds',23,'03424102',1.49,NULL,59,NULL,0,0,0,0,0,0,0.75,1),(3946,'Reeces',23,'HTTP://HRSHYS.NET/UGTF0NK',1.49,NULL,59,NULL,0,0,0,0,0,0,0.75,1),(3947,'Negra Modelo',1,'080660957852',10.99,NULL,6,NULL,0,0,0,0,0,0,7.5,1),(3948,'Dr. McGillicuddy\'s Menthol Mint 1Liter',18,'088004144036',24.99,NULL,7,NULL,0,0,0,0,0,0,17.5,1),(3949,'Pinot Envy',13,'768675169728',23.99,NULL,5,1,0,0,0,0,2,0,16.5,12),(3950,'Chento Malbec',13,'814876010090',19.99,NULL,5,1,0,0,0,0,2,0,12.75,12),(3951,'Chateau Mont-Redon Chateauneuf du Pape',13,'089744764096',48.99,NULL,5,1,0,0,0,0,2,0,35.5,12),(3952,'Catena Alta Cabernet 2015',13,'098709088511',48.99,NULL,5,1,0,0,0,0,2,0,35.55,12),(3953,'Crown Royal with Glasses',18,'082000789215',33.99,NULL,7,NULL,0,0,0,0,0,0,23.89,1),(3954,'butterscotch 99 proof',18,'080660010113',1.99,NULL,7,NULL,0,0,0,0,0,0,1.99,1),(3955,'vodka',10,'628451609308',32.99,NULL,7,NULL,0,0,0,0,0,0,32.99,1),(3956,'Budeweiser Nitro Reserve',1,'018200202025',10.99,NULL,6,NULL,0,0,0,0,0,0,7.25,1),(3957,'Experience Red Blend',22,'019962019708',14.99,NULL,5,1,0,0,0,0,2,0,5,12),(3958,'Experience Pinot Noir',22,'019962019609',16.99,NULL,5,1,0,0,0,0,2,0,5,12),(3959,'Crown Royal 750ml',18,'087000007253',33.99,NULL,7,NULL,0,0,0,0,0,0,23.89,1),(3960,'Six Pack mmonshine Minis',18,'854628006315',21.99,NULL,7,NULL,0,0,0,0,0,0,18,1),(3961,'Pepsi 12-Pack',21,'012000809941',6.99,NULL,59,NULL,0,0,0,0,0,0,4.75,1),(3962,'Josh Cellars Cabernet',13,'850000651470',17.99,NULL,5,1,0,0,0,0,2,0,10,12),(3963,'Daou Cabernet',13,'890409002398',29.99,NULL,5,1,0,0,0,0,2,0,16,12),(3964,'Coffee French Press',21,'4099100136616',4.99,NULL,1,NULL,0,0,0,0,0,0,3,1),(3965,'French Press',21,'041498315481',4.99,NULL,1,NULL,0,0,0,0,0,0,3,1),(3966,'Domaine Serene Chardonnay 2012',22,'689192372975',32.99,NULL,5,1,0,0,0,0,2,0,20,12),(3967,'Wooden Wheel Isabella',25,'858150004009',14.99,NULL,5,1,0,0,0,0,2,0,9,12),(3968,'Glenlivet 50ml 4-Pack',18,'080432116197',14.99,NULL,7,NULL,0,0,0,0,0,0,5.97,1),(3969,'Glenlivet 1824',18,'080432901236',3.99,NULL,7,NULL,0,0,0,0,0,0,1.5,1),(3970,'Glenlivet 14',18,'080432114957',3.99,NULL,7,NULL,0,0,0,0,0,0,1.5,1),(3971,'Glenlevit 1824',18,'080432115800',3.99,NULL,7,NULL,0,0,0,0,0,0,1.5,1),(3972,'Prairie Organic Apple Pear Ginger Vodka',18,'087116004337',24.99,NULL,7,NULL,0,0,0,0,0,0,17.25,1),(3973,'Basil Hayden 10 Year Bourbon',18,'080686012207',74.99,NULL,7,NULL,0,0,0,0,0,0,53.25,1),(3974,'Gouda',3,'4099100166477',6.99,NULL,4,NULL,0,0,0,0,0,0,4,1),(3975,'Whistle Pig Rye Whiskey Three-Pack',18,'850001901703',21.99,NULL,7,NULL,0,0,0,0,0,0,15.5,1),(3976,'Red Bridge Glueten Free Beer',1,'018200119859',11.99,NULL,6,NULL,0,0,0,0,0,0,8,1),(3977,'Choco Sticks',21,'818850020297',0.99,NULL,59,NULL,0,0,0,0,0,0,0.5,1),(3978,'Monkey 47',24,'080432112908',54.99,NULL,7,NULL,0,0,0,0,0,0,38.97,1),(3979,'Classic Lime Margarita',18,'086024008086',14.99,NULL,7,NULL,0,0,0,0,0,0,10.53,1),(3980,'Esteva Red Blend Portugal',13,'611482961804',12.99,NULL,5,1,0,0,0,0,2,0,9,12),(3981,'Truffle Cheddar Cheese',3,'4099100205015',7.99,NULL,4,NULL,0,0,0,0,0,0,4.29,1),(3982,'Everything bagel Goat Cheese',3,'4099100216097',7.99,NULL,4,NULL,0,0,0,0,0,0,3.89,1),(3983,'Blue Cheese',3,'4099100152388',6.99,NULL,4,NULL,0,0,0,0,0,0,3.49,1),(3984,'Vegetable Crackers',3,'4099100063714',3.99,NULL,59,NULL,0,0,0,0,0,0,1.99,1),(3985,'Wheat Crackers',3,'4099100063691',3.99,NULL,59,NULL,0,0,0,0,0,0,1.99,1),(3986,'Crown Royal Salted Caramel Mini',19,'08255307',4.75,NULL,7,NULL,0,0,0,0,0,0,2.85,1),(3987,'Crown Royal Black Mini 50ml',18,'08227207',4.75,NULL,7,NULL,0,0,0,0,0,0,2.81,1),(3988,'Crown Royal Peach Mini',18,'08255103',4.99,NULL,7,NULL,0,0,0,0,0,0,2.85,1),(3989,'Baileys Red Velvet',18,'086767705013',35.5,NULL,7,NULL,0,0,0,0,0,0,25.25,1),(3990,'Captain Morgan Spiked Apple Mini 50ml',18,'08264305',1.75,NULL,7,NULL,0,0,0,0,0,0,1,1),(3991,'Jean Leon Cabernet',13,'088586008863',6.99,NULL,5,1,0,0,0,0,2,0,2,12),(3992,'Rosenblum Vintner\'s Cuvee XXXX',13,'081054995931',14.99,NULL,5,1,0,0,0,0,2,0,7.5,12),(3993,'Sophie\'s Shiraz',13,'811265022481',14.99,NULL,5,1,0,0,0,0,2,0,8,12),(3994,'Once Upon A Vine',13,'080720963113',8.99,NULL,5,1,0,0,0,0,2,0,3,12),(3995,'Kamiki Japanses Whiskey',18,'4589858890026',82.99,NULL,7,NULL,0,0,0,0,0,0,58.92,1),(3996,'Goat Cheddar',3,'4099100216080',7.99,NULL,4,NULL,0,0,0,0,0,0,4.25,1),(3997,'Jarlsberg Cheese',3,'075501960276',7.99,NULL,4,NULL,0,0,0,0,0,0,4.25,1),(3998,'Ghost Pepper Cheddar',21,'711565899557',6.99,NULL,4,NULL,0,0,0,0,0,0,3.99,1),(3999,'Craft Beer Cheddar',21,'828280001780',6.99,NULL,4,NULL,0,0,0,0,0,0,3.99,1),(4000,'Purple Moon Cheddar',21,'828280001650',6.99,NULL,4,NULL,0,0,0,0,0,0,3.99,1),(4001,'Mulderbosch Cab Rose',13,'6009803564034',9.99,NULL,5,1,0,0,0,0,2,0,2,12),(4002,'Whitehall Lane Cabernet',21,'011628314998',48.99,NULL,5,1,0,0,0,0,2,0,30,12),(4003,'Cakebread Cabernet',13,'4099100091199',96.99,NULL,5,1,0,0,0,0,2,0,75,12),(4004,'Mini Can Sparkling Wine',13,'816253011508',2.99,NULL,5,1,0,0,0,0,2,0,1.5,12),(4005,'Italian Dark Chocolate Truffles',21,'639277614339',5.99,NULL,1,NULL,0,0,0,0,0,0,3,1),(4006,'Holiday Cranberry Candle',3,'4099100109108',8.99,NULL,1,NULL,0,0,0,0,0,0,4.5,1),(4007,'Press Pomegranate Ginger',1,'852313004875',11.99,NULL,6,NULL,0,0,0,0,0,0,7.5,1),(4008,'Prieure Tavel Rose',13,'084692626083',10.99,NULL,5,1,0,0,0,0,2,0,3.99,12),(4009,'Arrow Blackberry brandy',18,'088352119823',14.99,NULL,7,NULL,0,0,0,0,0,0,10.25,1),(4010,'Oak & Eden Bourbon',18,'869673000416',49.99,NULL,7,NULL,0,0,0,0,0,0,35.5,1),(4011,'John Walker & Sons Scotch',18,'088076185166',86.99,NULL,7,NULL,0,0,0,0,0,0,60.5,1),(4012,'Cline Viognier',13,'8652180027',12.99,NULL,5,1,0,0,0,0,2,0,7.75,12),(4013,'Innocent Bystander Moscato 4-Pack',13,'7749008796',14.99,NULL,5,4,0,0,0,0,2,0,8,8),(4014,'Dooker Girl on the Go Sparkling Verdelho',22,'9336975000402',12.99,NULL,5,1,0,0,0,0,2,0,5,12),(4015,'Domaine Valmoissine Pinot Noir',13,'026861103018',14.99,NULL,5,1,0,0,0,0,2,0,9.75,12),(4016,'Dooker Two Left Feet',22,'9336975000044',31.99,NULL,5,1,0,0,0,0,2,0,22.5,12),(4017,'Fourrey Chablis Premier Cru',6,'3760129170059',33.99,NULL,5,1,0,0,0,0,2,0,22,12),(4018,'Christain Brothers Brandy',18,'086036815597',14.99,NULL,7,NULL,0,0,0,0,0,0,9.5,1),(4019,'Zede Labegorce Margaux 2015',6,'852187013782',40.99,NULL,5,1,0,0,0,0,2,0,29,12),(4020,'Les Allies Chateauneuf Du Pape',14,'3760204540838',45.99,NULL,5,1,0,0,0,0,2,0,32.25,12),(4021,'Tapiz Black Tears Malbec',14,'852282002438',50.99,NULL,5,1,0,0,0,0,2,0,33.75,12),(4022,'Aveleda Vinho Verde',6,'764793227302',11.99,NULL,5,1,0,0,0,0,2,0,8.5,12),(4023,'Border Bourbon',18,'895412001079',74.99,NULL,7,NULL,0,0,0,0,0,0,52.13,1),(4024,'Little James\' Basket Press',14,'3483813000004',14.99,NULL,5,1,0,0,0,0,2,0,9.75,12),(4025,'Richemer Piquepoul',6,'3760021480072',12.99,NULL,5,1,0,0,0,0,2,0,8.25,12),(4026,'Bubble Gun',21,'026404047021',9.99,NULL,1,NULL,0,0,0,0,0,0,6,1),(4027,'Playing Cards',21,'073854000885',2.99,NULL,1,NULL,0,0,0,0,0,0,1.5,1),(4028,'Josh Cellars Rose',13,'031259001043',13.99,NULL,5,1,0,0,0,0,2,0,10.5,12),(4029,'Ace Guava Cider',1,'798449020030',2.5,NULL,6,NULL,0,0,0,0,0,0,1.45,1),(4030,'Ace Guava Cider',1,'798449020047',11.99,NULL,6,NULL,0,0,0,0,0,0,8.55,1),(4031,'Gift Bag',21,'4099100121391',1.99,NULL,1,0,0,0,0,0,0,0,1,1),(4032,'Goose Island Bourbon County',1,'736920210594',18.99,NULL,6,NULL,0,0,0,0,0,0,9.15,1),(4033,'Two-Pack Gift Bags',21,'858442007718',3.99,NULL,1,NULL,0,0,0,0,0,0,1.99,1),(4034,'Two-pack Blue Gift Bags',21,'858442007701',3.99,NULL,1,NULL,0,0,0,0,0,0,1.99,1),(4035,'Heinz Cocktail Sauce',23,'01311307',4.99,NULL,4,NULL,0,0,0,0,0,0,2.25,1),(4036,'Front Street Mahalo',17,'728028467413',9.99,NULL,6,NULL,0,0,0,0,0,0,7,1),(4037,'Kahlua 375ml',18,'089540145631',14.99,NULL,7,NULL,0,0,0,0,0,0,10.25,1),(4038,'Ezra Brooks Bourbon Cream',18,'088352133782',16.99,NULL,7,NULL,0,0,0,0,0,0,11.75,1),(4039,'Whistlepig 10 Year 375ml',18,'851460002116',42.99,NULL,7,NULL,0,0,0,0,0,0,30.5,1),(4040,'Chateau De Bligny Champagne',13,'892363000472',40.99,NULL,5,1,0,0,0,0,2,0,21,12),(4041,'Jefferson\'s Chef\'s Collaboration',18,'814794010530',43.99,NULL,7,NULL,0,0,0,0,0,0,30.5,1),(4042,'Dr.McGill Wild Grape Mini 50ml',18,'088004009588',1.99,NULL,7,NULL,0,0,0,0,0,0,0.8,1),(4043,'Voga Rose of Pinot Grigio',13,'021893795958',8.99,NULL,5,1,0,0,0,0,2,0,3,12),(4044,'Day Drinking Rose Bubbles Can 375ml',13,'848375006001',6.99,NULL,5,1,0,0,0,0,2,0,3.5,12),(4045,'MezzaCorona Bubbly',13,'813297000628',13.99,NULL,5,1,0,0,0,0,2,0,7.5,12),(4046,'Matusalem Gran Reserva Rum',18,'811538017039',37.99,NULL,7,NULL,0,0,0,0,0,0,25.98,1),(4047,'Cruzan Vanilla',18,'080686967743',15.5,NULL,7,NULL,0,0,0,0,0,0,11,1),(4048,'Baileys Vanilla Cinnamon 750ml',18,'086767704382',34.99,NULL,7,NULL,0,0,0,0,0,0,25.25,1),(4049,'99 Fruit Variety Pack',18,'088004040529',14.99,NULL,7,NULL,0,0,0,0,0,0,8,1),(4050,'Lagunitas The Waldos\' Triple IPA',17,'723830400467',13.75,NULL,6,NULL,0,0,0,0,0,0,9.75,1),(4051,'Lagunitas Stereohopic',17,'723830000148',10.99,NULL,6,NULL,0,0,0,0,0,0,7.75,1),(4052,'GH Mumm Champagne',13,'852832104896',39.99,NULL,5,1,0,0,0,0,2,0,22,12),(4053,'Alaskan Amber',19,'040850140013',10.99,NULL,6,NULL,0,0,0,0,0,0,7.5,1),(4054,'Alaskan Icy Bay IPA',19,'040850140082',10.99,NULL,6,NULL,0,0,0,0,0,0,7.5,1),(4055,'Cedar Ridge Iowa Sparkling White',9,'9824001492',24.99,NULL,5,1,0,0,0,0,2,0,17.5,12),(4056,'Blue Marble Cosmo',13,'856508007009',9.99,NULL,5,1,0,0,0,0,2,0,7,12),(4057,'Wine Bag',21,'786309151338',1.97,NULL,1,NULL,0,0,0,0,0,0,1,1),(4058,'Focaccia Crisps',21,'604059000167',4.99,NULL,59,NULL,0,0,0,0,0,0,2.75,1),(4059,'Wine Cork Boot',21,'077757910340',29.99,NULL,1,NULL,0,0,0,0,0,0,19,1),(4060,'Goat\'s Milk Brie',3,'4099100216066',8.99,NULL,4,NULL,0,0,0,0,0,0,4,1),(4061,'Stilton with Mango & Ginger',3,'4099100128765',7.99,NULL,4,NULL,0,0,0,0,0,0,4,1),(4062,'Truffle Goat Cheese',3,'4099100216073',6.99,NULL,4,NULL,0,0,0,0,0,0,3.5,1),(4063,'Crown Vanilla Mini',18,'08252300',4.75,NULL,7,NULL,0,0,0,0,0,0,2,1),(4064,'Hakutsuru Saki Three-Pack',22,'747846010137',23.99,NULL,5,3,0,0,0,0,2,0,15.75,4),(4065,'Far Niente Cabernet',13,'030174091306',140,NULL,5,1,0,0,0,0,2,0,100,12),(4066,'Leeuwin Chardonnay',22,'071720061626',75,NULL,5,1,0,0,0,0,2,0,60,12),(4067,'Antinori Cervaro',13,'4099100121360',46.95,NULL,5,1,0,0,0,0,2,0,33,12),(4068,'Montecillo Rioja Crianza',13,'022851202013',12.99,NULL,5,1,0,0,0,0,2,0,8.75,12),(4069,'Vieux Telegrsphe La Crau 2018',22,'761503633217',94.99,NULL,5,1,0,0,0,0,2,0,67.5,12),(4070,'The Pundit Syrah',13,'088586006944',21.99,NULL,5,1,0,0,0,0,2,0,15.75,12),(4071,'Writer\'s Tears Copper Pot Irish Whiskey',18,'-[816511905280',42.99,NULL,7,NULL,0,0,0,0,0,0,30.56,1),(4072,'Writer\'s Tears Copper Pot Irish Whiskey',18,'816511905280',42.99,NULL,7,NULL,0,0,0,0,0,0,30.56,1),(4073,'Ole Smoky Peach Whiskey',18,'854628006520',21.99,NULL,7,NULL,0,0,0,0,0,0,15.5,1),(4074,'Paramount Peppermint 375ml',18,'086816101995',6.99,NULL,7,NULL,0,0,0,0,0,0,3.92,1),(4075,'Vollereaux Premier Cru Champagne',6,'086785761091',50.99,NULL,5,1,0,0,0,0,2,0,36,12),(4076,'Breckenridge Bourbon',18,'853826005304',58.99,NULL,7,NULL,0,0,0,0,0,0,42.75,1),(4077,'Vollereaux Champagne Cuvee Marguerite',6,'086785761114',99.99,NULL,5,1,0,0,0,0,2,0,43,12),(4078,'Giuliano Rosati Valpolicella Ripasso',6,'610746000815',20.99,NULL,5,1,0,0,0,0,2,0,14.5,12),(4079,'A Mano Imprint Primitivo',6,'8026705301206',16.99,NULL,5,1,0,0,0,0,2,0,11.5,12),(4080,'Four Vines Chardonnay',13,'761180801008',12.99,NULL,5,1,0,0,0,0,2,0,9.75,12),(4081,'Gingerbread Hearts',3,'4099100117042',3.99,NULL,59,NULL,0,0,0,0,0,0,2.25,1),(4082,'Chianti Italian Salame',3,'4099100210903',7.99,NULL,4,NULL,0,0,0,0,0,0,3.99,1),(4083,'Pinot Grigio Italian Salsme',3,'4099100210934',7.99,NULL,4,NULL,0,0,0,0,0,0,3.99,1),(4084,'Serving Tray',3,'4099100092134',24.99,NULL,1,NULL,0,0,0,0,0,0,10.5,1),(4085,'Torres Mas La Plana',21,'088586006470',62.99,NULL,5,1,0,0,0,0,2,0,49.99,12),(4086,'The Flood 2013 PN',22,'866563000037',48.99,NULL,5,1,0,0,0,0,2,0,25,12),(4087,'Robert Craig 2014 Mount Veeder Cabernet',22,'893924000023',99.99,NULL,5,1,0,0,0,0,2,0,67.5,12),(4088,'Diora Chardonnay Chardonnay',13,'82242015486',21.99,NULL,5,1,0,0,0,0,2,0,16.5,12),(4089,'Diora Chard',14,'082242015486',22.99,NULL,5,1,0,0,0,0,2,0,16.5,12),(4090,'Jalapeno Jack Olives',3,'4099100125801',7.99,NULL,4,NULL,0,0,0,0,0,0,3,1),(4091,'Mini Crown Apple',18,'08245805',4.75,NULL,7,NULL,0,0,0,0,0,0,2,1),(4092,'Big Grove Redheaded Stranger',1,'787790853794',10.99,NULL,6,NULL,0,0,0,0,0,0,7.83,1),(4093,'EH Taylor Straight Rye',18,'088004005504',115,NULL,7,NULL,0,0,0,0,0,0,58,1),(4094,'Lagavulin Distiller\'s Edition 2005',18,'088076184893',139.75,NULL,7,NULL,0,0,0,0,0,0,99.5,1),(4095,'White Chocolate Coffee',3,'4099100143577',7.99,NULL,59,NULL,0,0,0,0,0,0,3.99,1),(4096,'Caramel Brownie Cream',3,'053035036605',2.99,NULL,59,NULL,0,0,0,0,0,0,1.79,1),(4097,'Party Cheese Tray',3,'4099100146387',9.99,NULL,4,NULL,0,0,0,0,0,0,5.15,1),(4098,'Old Rip Van Winkle 10 Years',19,'089319123679',475,NULL,7,NULL,0,0,0,0,0,0,53,1),(4099,'Ardbeg 10 Year Scotch',18,'083300072106',63.99,NULL,7,NULL,0,0,0,0,0,0,45.5,1),(4100,'The Tyrconnell Single Malt',18,'080686187233',39.99,NULL,7,NULL,0,0,0,0,0,0,28.06,1),(4101,'Crown Royal XR',18,'082000734338',139.99,NULL,7,NULL,0,0,0,0,0,0,104.75,1),(4102,'Chambord',18,'083300034531',40.99,NULL,7,NULL,0,0,0,0,0,0,29.12,1),(4103,'Chila Coffee Liqueur',18,'088004016852',13.99,NULL,7,NULL,0,0,0,0,0,0,8.06,1),(4104,'Suntori Toki Whiskey',18,'080686957171',45.99,NULL,7,NULL,0,0,0,0,0,0,31.99,1),(4105,'Bacon Flavored Vodka',18,'681622127605',32.99,NULL,7,NULL,0,0,0,0,0,0,23,1),(4106,'Goldschlager Minis',18,'088004035761',3.75,NULL,7,NULL,0,0,0,0,0,0,2,1),(4107,'Invivo Sauvignon Blanc',13,'086785850016',19.99,NULL,5,1,0,0,0,0,2,0,12.95,12),(4108,'Spy Valley Sauvignon Blanc',22,'835207000023',19.99,NULL,5,1,0,0,0,0,2,0,12.75,12),(4109,'La Crema Willamette PN',13,'049331003137',35.99,NULL,5,1,0,0,0,0,2,0,25,12),(4110,'Chocolate Shop Wine',13,'857846102920',13.99,NULL,5,1,0,0,0,0,2,0,8.09,12),(4111,'Heitz Cellar 2015 Cab',13,'098803011507',62.99,NULL,5,1,0,0,0,0,2,0,41.5,12),(4112,'Passionate Wine Del Mono Malbec-Syrah',22,'810451030378',13.99,NULL,5,1,0,0,0,0,2,0,8.25,12),(4113,'Thomas H. Handy Rye',18,'8004000035',499,NULL,7,NULL,0,0,0,0,0,0,75,1),(4114,'Rideg east Bench Zinfandel',22,'744442889006',34.99,NULL,5,1,0,0,0,0,2,0,25,12),(4115,'Ridge Geyserville Red Blend',22,'744442301003',47.99,NULL,5,1,0,0,0,0,2,0,34,12),(4116,'Ridge Lytton Estate Petite Sirah',22,'744442781003',42.99,NULL,5,1,0,0,0,0,2,0,30,12),(4117,'Ridge Paganini Ranch Zin',22,'744442831005',42.99,NULL,5,1,0,0,0,0,2,0,30,12),(4118,'Game Of Thrones Red',13,'839146076309',22.99,NULL,5,1,0,0,0,0,2,0,15,12),(4119,'Penley Helios 2018',22,'751527471308',61.99,NULL,5,1,0,0,0,0,2,0,43.5,12),(4120,'Iron and Sand Cabernet',19,'085200020812',28.99,NULL,5,1,0,0,0,0,2,0,18.75,12),(4121,'BR Cohn Cabernet',13,'740216780166',24.99,NULL,5,1,0,0,0,0,2,0,17.5,12),(4122,'Caymus-Suisun Grand Durif',19,'017224710004',54.99,NULL,5,1,0,0,0,0,2,0,40.5,12),(4123,'K Vintners Syrah The Deal',19,'184745100048',38.99,NULL,5,1,0,0,0,0,2,0,24.75,12),(4124,'Delirium Belgian Ale',19,'815184010178',20.99,NULL,6,NULL,0,0,0,0,0,0,15,1),(4125,'Gatorade Reg',23,'052000328684',1.75,NULL,59,NULL,0,0,0,0,0,0,1,1),(4126,'Raccoons Stole my Baby Jesus',21,'9781634925365',14.99,NULL,1,NULL,0,0,0,0,0,0,8.99,1),(4127,'Duvel Belgian',19,'3706014151',15.99,NULL,6,NULL,0,0,0,0,0,0,11.25,1),(4128,'Absolut Lime Minis 50ml',18,'835229010253',2.75,NULL,7,NULL,0,0,0,0,0,0,1.5,1),(4129,'Brady Zinfandel',11,'793573225993',24.99,NULL,5,1,0,0,0,0,2,0,16.5,12),(4130,'Thomas Handy Rye',18,'088004000035',499,NULL,7,NULL,0,0,0,0,0,0,75,1),(4131,'Necklace',21,'810447024787',3.98,NULL,1,NULL,0,0,0,0,0,0,1.99,1),(4132,'Santa Bag',21,'80007531',3.99,NULL,1,NULL,0,0,0,0,0,0,1.5,1),(4133,'Ezra Brooks Bourbon Cream',18,'088352131474',16.99,NULL,7,NULL,0,0,0,0,0,0,11.75,1),(4134,'Smirnoff Vodka 1.75',18,'082000789451',31.98,NULL,7,NULL,0,0,0,0,0,0,25,1),(4135,'Day Drinking Southern Peach',13,'848375006025',6.99,NULL,5,1,0,0,0,0,2,0,3.5,12),(4136,'Don Melchor CYT Cabernet 2017',13,'082734314943',110,NULL,5,1,0,0,0,0,2,0,76.8,12),(4137,'Zing Zang Bloody Mary Mix Can 8oz',13,'616003737340',1.99,NULL,59,NULL,0,0,0,0,0,0,1.13,1),(4138,'Day Drinking Watermelon Rose 375ml Can',13,'8375006018',6.99,NULL,5,1,0,0,0,0,2,0,3.5,12),(4139,'Ginger Ale',21,'078000152463',2.99,NULL,59,NULL,0,0,0,0,0,0,1.5,1),(4140,'Knob Creek 375ml',18,'080686016601',24.99,NULL,7,NULL,0,0,0,0,0,0,17,1),(4141,'Jim Beam Black 375ml',18,'080686034179',15.99,NULL,7,NULL,0,0,0,0,0,0,11,1),(4142,'Bailey\'s Salted Caramel',18,'086767701763',35.5,NULL,7,NULL,0,0,0,0,0,0,25.25,1),(4143,'Bailey\'s Strawberries & Cream',18,'086767704832',35.5,NULL,7,NULL,0,0,0,0,0,0,25.25,1),(4144,'Pendleton Whisky',18,'811538019323',28.99,NULL,7,NULL,0,0,0,0,0,0,20.75,1),(4145,'Radz Candy Dispensers',21,'812340030698',2.99,NULL,1,NULL,0,0,0,0,0,0,1,1),(4146,'Balvenie 14 Year',18,'083664871681',93.99,NULL,7,NULL,0,0,0,0,0,0,66.5,1),(4147,'Pendleton Midnight',18,'811538019385',42.99,NULL,7,NULL,0,0,0,0,0,0,30.3,1),(4148,'Dalmore 12 Year Scotch',18,'087647111672',75.99,NULL,7,NULL,0,0,0,0,0,0,53,1),(4149,'Glenlivet 14 Year Single Malt',18,'080432114926',57.99,NULL,7,NULL,0,0,0,0,0,0,41.72,1),(4150,'Tanqueray Rangpur',18,'088076168640',28.99,NULL,7,NULL,0,0,0,0,0,0,20.02,1),(4151,'E&J Brandy',18,'08541305',14.99,NULL,7,NULL,0,0,0,0,0,0,10.25,1),(4152,'Lolea Sangria',13,'8437014256369',5.25,NULL,5,1,0,0,0,0,2,0,4,12),(4153,'Patron Reposado 50ml',18,'721733000227',6.99,NULL,7,NULL,0,0,0,0,0,0,5,1),(4154,'Patron Anejo 50ml',18,'721733000210',7.99,NULL,7,NULL,0,0,0,0,0,0,5.75,1),(4155,'Desert Heat Hot Sauce Collection',3,'810015640463',11.99,NULL,4,NULL,0,0,0,0,0,0,5.35,1),(4156,'Four Pack Cheese Pairing Spreads',3,'4099100200010',14.99,NULL,4,NULL,0,0,0,0,0,0,7.49,1),(4157,'Bing Cherry Vodka',18,'085592138652',16.99,NULL,7,NULL,0,0,0,0,0,0,11,1),(4158,'Arrow Creme de Cacao White',19,'088352118710',13.99,NULL,7,NULL,0,0,0,0,0,0,9,1),(4159,'Bubble Gum Sticks',21,'041396004104',2.5,NULL,59,NULL,0,0,0,0,0,0,1.25,1),(4160,'Specially Selected Scalloped Crackers',3,'4099100145700',6.5,NULL,59,NULL,0,0,0,0,0,0,3.25,1),(4161,'Camembert Brie',3,'4099100133981',7.99,NULL,4,NULL,0,0,0,0,0,0,4,1),(4162,'Tortilla Chips',3,'4099100066975',2.99,NULL,59,NULL,0,0,0,0,0,0,1.25,1),(4163,'Crown Royal Vanilla 200ml',18,'082000776574',10.75,NULL,7,NULL,0,0,0,0,0,0,7.58,1),(4164,'Ketel One Grapefruit Rose',18,'085156775002',24.99,NULL,7,NULL,0,0,0,0,0,0,17.5,1),(4165,'Dewars 200ml',18,'080480230050',8.99,NULL,7,NULL,0,0,0,0,0,0,6,1),(4166,'Dewars 12 Year 200ml',18,'080480985035',10.99,NULL,7,NULL,0,0,0,0,0,0,8.25,1),(4167,'Dewars 15 Year 200ml',18,'080480985042',10.99,NULL,7,NULL,0,0,0,0,0,0,8.25,1),(4168,'Duvel Golden Ale',19,'083706014151',15.99,NULL,6,NULL,0,0,0,0,0,0,11,1),(4169,'Grand Vin Bag',21,'/077757438592',1.99,NULL,1,NULL,0,0,0,0,0,0,1,1),(4170,'Party napkins',21,'039938776749',2.48,NULL,1,NULL,0,0,0,0,0,0,1.25,1),(4171,'Rosemary Scalloped Crackers',3,'4099100000702',3.99,NULL,4,NULL,0,0,0,0,0,0,2,1),(4172,'Luc Paretti Lovo Brut Prosecco',14,'2529003761',14.99,NULL,5,1,0,0,0,0,2,0,7.5,12),(4173,'Lucca Paretti Prosecco Brut',14,'852529003761',14.99,NULL,5,1,0,0,0,0,2,0,7.5,12),(4174,'Ice Hole & Mint',18,'087116035607',12.99,NULL,7,NULL,0,0,0,0,0,0,7.73,1),(4175,'Crown Royal Vanilla',18,'082000776581',16.99,NULL,7,NULL,0,0,0,0,0,0,12,1),(4176,'Ferrero Chocolates',23,'009800210282',18.99,NULL,59,NULL,0,0,0,0,0,0,8,1),(4177,'Artisan Crackers',3,'4099100128369',5.99,NULL,59,NULL,0,0,0,0,0,0,3,1),(4178,'Artisan Flatbread',3,'4099100128376',3.99,NULL,59,NULL,0,0,0,0,0,0,2,1),(4179,'Organic Salsa',3,'4099100021608',4.99,NULL,59,NULL,0,0,0,0,0,0,2,1),(4180,'Clase Azul Tequila',18,'081240049516',147.99,NULL,7,NULL,0,0,0,0,0,0,115.26,1),(4181,'Margaritaville mango marg 1.75',19,'086024008253',13.99,NULL,7,NULL,0,0,0,0,0,0,8.62,1),(4182,'Huckleberry Vodka',18,'085592145957',15.99,NULL,7,NULL,0,0,0,0,0,0,11,1),(4183,'State Vodka 1.75',18,'850001558044',21.99,NULL,7,NULL,0,0,0,0,0,0,14,1),(4184,'Steak House Cabernet',13,'184745000065',11.99,NULL,5,1,0,0,0,0,2,0,7.5,12),(4185,'Hayes Ranch Cabernet',13,'9636465001',11.99,NULL,5,1,0,0,0,0,2,0,7.5,12),(4186,'Four-Pack Cuervo Mango Marg',18,'811538016506',9.99,NULL,7,NULL,0,0,0,0,0,0,7.4,1),(4187,'Unscripted Red Blend',13,'082242015127',9.99,NULL,5,1,0,0,0,0,2,0,5.57,12),(4188,'Flat Rock',13,'847159001546',9.99,NULL,5,1,0,0,0,0,2,0,4.5,12),(4189,'Hayes Ranch Cabernet',13,'089636465001',11.99,NULL,5,1,0,0,0,0,2,0,7.5,12),(4190,'Hayes Ranch Red Blend',13,'089636465193',11.99,NULL,5,1,0,0,0,0,2,0,7.5,12),(4191,'14 Hands Hot to Trot',13,'088586004483',11.99,NULL,5,1,0,0,0,0,2,0,7.5,12),(4192,'Aged Gouda',3,'853748002214',7.99,NULL,4,NULL,0,0,0,0,0,0,4,1),(4193,'Crafthouse Moscow Mule',18,'859122005000',19.99,NULL,7,NULL,0,0,0,0,0,0,14,1),(4194,'Crafthouse Paloma',18,'859122005024',19.99,NULL,7,NULL,0,0,0,0,0,0,14,1),(4195,'Sierra Nevada Wanderland',1,'3783228229',10.99,NULL,6,NULL,0,0,0,0,0,0,7.05,1),(4196,'Bigfoot Barleywine',1,'083783375459',15.99,NULL,6,NULL,0,0,0,0,0,0,10.68,1),(4197,'Backpocket Raygun',1,'852131004675',11.99,NULL,6,NULL,0,0,0,0,0,0,7.99,1),(4198,'Black Cat Cobbler',1,'850016258069',14.99,NULL,6,NULL,0,0,0,0,0,0,10.3,1),(4199,'Sierra Nevada Wanderlust',1,'083783228229',10.99,NULL,6,NULL,0,0,0,0,0,0,7.25,1),(4200,'Sand Point Sauvignon Blanc',14,'891540001615',11.99,NULL,5,1,0,0,0,0,2,0,8,12),(4201,'Chevre',21,'736547329143',6.99,NULL,4,NULL,0,0,0,0,0,0,4,1),(4202,'Ole Smoky Salty Caramel',18,'4628006131',21.99,NULL,7,NULL,0,0,0,0,0,0,15.5,1),(4203,'Kentucky Owl 10 Year Rye',18,'857361007144',315.7,NULL,7,NULL,0,0,0,0,0,0,225.5,1),(4204,'Kentucky Owl Confiscated',18,'857361007052',195.99,NULL,7,NULL,0,0,0,0,0,0,130.5,1),(4205,'E&J Brandy',18,'085000004180',14.99,NULL,7,NULL,0,0,0,0,0,0,10.36,1),(4206,'Courvoisier 375ml',18,'080686961086',18.99,NULL,7,NULL,0,0,0,0,0,0,13.5,1),(4207,'Hendrick\'s Orbium',18,'083664873678',47.99,NULL,7,NULL,0,0,0,0,0,0,34.25,1),(4208,'Hakutsuru Draft Saki 300ml',22,'7846010083',6.99,NULL,5,1,0,0,0,0,2,0,5,12),(4209,'Sayuri Nigori Saki 300ml',22,'747846020013',10.99,NULL,5,1,0,0,0,0,2,0,7,12),(4210,'Legent Bourbon',18,'080686024019',43.99,NULL,7,NULL,0,0,0,0,0,0,30.5,1),(4211,'Tres Generaciones Reposado',18,'080686836032',44.99,NULL,7,NULL,0,0,0,0,0,0,30.5,1),(4212,'Aberlour A\'Bunadh',18,'080432516171',87.99,NULL,7,NULL,0,0,0,0,0,0,62.72,1),(4213,'Guinness Draught Stout',17,'083820104011',10.99,NULL,6,NULL,0,0,0,0,0,0,7.75,1),(4214,'Erath Pinot Gris',13,'084687007019',10.99,NULL,5,1,0,0,0,0,2,0,3.5,12),(4215,'Prayers of Sinners Red Blend',19,'088586010248',14.99,NULL,5,1,0,0,0,0,2,0,6,12),(4216,'Di Cello Prosecco',13,'851758002071',12.99,NULL,5,1,0,0,0,0,2,0,9,12),(4217,'Borne of Fire Chardonnay',13,'088586010309',16.99,NULL,5,1,0,0,0,0,2,0,7.5,12),(4218,'Valentine Hearts',23,'041761100363',2.75,NULL,59,NULL,0,0,0,0,0,0,1.15,1),(4219,'Mamma Mia White Wine',13,'088586008191',7.99,NULL,5,1,0,0,0,0,2,0,2,12),(4220,'Big Dippers',3,'4099100066456',2.99,NULL,59,NULL,0,0,0,0,0,0,1.25,1),(4221,'Amaro Montenegro',18,'898193001597',44.99,NULL,7,NULL,0,0,0,0,0,0,32,1),(4222,'Old Forrester 100 Proof',18,'081128001063',29.99,NULL,7,NULL,0,0,0,0,0,0,18.3,1),(4223,'Jameson Black Barrel',18,'080432107263',45.99,NULL,7,NULL,0,0,0,0,0,0,32.72,1),(4224,'Anew Rose',13,'088586007026',5.99,NULL,5,1,0,0,0,0,2,0,2,12),(4225,'Val D\'Oca Rose',13,'839552000561',12.99,NULL,5,1,0,0,0,0,2,0,3,12),(4226,'Reunion Something Wicked Sour',1,'728028504866',10.99,NULL,6,NULL,0,0,0,0,0,0,7.75,1),(4227,'Reunion Tank Puncher 4-Pack',1,'728028504835',12.99,NULL,6,NULL,0,0,0,0,0,0,8.66,1),(4228,'Stone Self-Reghtwous Black IPA',1,'636251740336',16.99,NULL,6,NULL,0,0,0,0,0,0,12.75,1),(4229,'Neyers 304 Chardonnay',19,'853763001681',26.25,NULL,5,1,0,0,0,0,2,0,18.75,12),(4230,'Gibson Madeira',11,'083420325328',10.99,NULL,5,1,0,0,0,0,2,0,6.75,12),(4231,'Retsina',11,'811611004079',11.99,NULL,5,1,0,0,0,0,2,0,8.25,12),(4232,'Boddingtons Pub Ale 4-Pack',1,'762274813938',9.99,NULL,6,NULL,0,0,0,0,0,0,6.83,1),(4233,'O\'Doul\'s NA Beer',1,'018200007842',10.99,NULL,6,NULL,0,0,0,0,0,0,7.25,1),(4234,'Elysian Space Dust',1,'817904000834',12.75,NULL,6,NULL,0,0,0,0,0,0,8.75,1),(4235,'Rumchata Frappa Chata',18,'890355001391',11.99,NULL,7,NULL,0,0,0,0,0,0,9,1),(4236,'Cranberry Vodka Cocktail 4-Pack',18,'089105001853',11.99,NULL,7,NULL,0,0,0,0,0,0,8.12,1),(4237,'Crown Royal Vanilla 750ml',18,'082000776598',33.99,NULL,5,1,0,0,0,0,2,0,23.89,12),(4238,'Shot Glass Set of 6',21,'704572427967',8.99,NULL,1,NULL,0,0,0,0,0,0,4.28,1),(4239,'Sour Gummy Bears',3,'042238312210',2.5,NULL,59,NULL,0,0,0,0,0,0,1.07,1),(4240,'Gummy Starmix',3,'042238722149',2.5,NULL,59,NULL,0,0,0,0,0,0,1.07,1),(4241,'Cadbury 4-Pack',21,'034000011452',3.99,NULL,59,NULL,0,0,0,0,0,0,1.5,1),(4242,'Reeces Eggs',23,'034000012633',3.99,NULL,59,NULL,0,0,0,0,0,0,1.5,1),(4243,'Irish Porter Cheese',3,'4099100228519',7.99,NULL,4,NULL,0,0,0,0,0,0,3.99,1),(4244,'Ezra Brooks 99 Proof',18,'088352135427',28.99,NULL,7,NULL,0,0,0,0,0,0,20.75,1),(4245,'Revenant Rye',18,'860003102435',42.99,NULL,7,NULL,0,0,0,0,0,0,30.5,1),(4246,'Hermit Beer',1,'728028504873',11.99,NULL,6,NULL,0,0,0,0,0,0,7,1),(4247,'Rum Chata Cold Brew',18,'890355001384',3.99,NULL,7,NULL,0,0,0,0,0,0,3,1),(4248,'Single Yeung Ling',21,'08992468',2.99,NULL,6,NULL,0,0,0,0,0,0,1,1),(4249,'Lagunitas Daytime IPA',17,'723830370111',10.99,NULL,6,NULL,0,0,0,0,0,0,7.75,1),(4250,'Jim Bem Red Stag',18,'080686001027',21.99,NULL,7,NULL,0,0,0,0,0,0,16.25,1),(4251,'Ezra Brooks Bourbon',18,'088352110929',17.5,NULL,7,NULL,0,0,0,0,0,0,12.5,1),(4252,'Old Grand-Dad Bourbon',18,'080686408406',28.99,NULL,7,NULL,0,0,0,0,0,0,20.75,1),(4253,'White Oak Chardonnay',14,'728351883904',14.99,NULL,5,1,0,0,0,0,2,0,6,12),(4254,'SIP Moscato',14,'856424003017',9.99,NULL,5,1,0,0,0,0,2,0,5,12),(4255,'Amble + Chase Rose',14,'898709038888',2.99,NULL,5,1,0,0,0,0,2,0,2,12),(4256,'Amble + Chase Rose',14,'098709038882',12.99,NULL,5,1,0,0,0,0,2,0,8,12),(4257,'ManCan White Wine with Fizz',14,'851333006029',5.99,NULL,5,1,0,0,0,0,2,0,2.5,12),(4258,'Muscador Muscat',14,'654029001090',8.99,NULL,5,1,0,0,0,0,2,0,4,12),(4259,'Barrua Red',13,'084692455201',37.99,NULL,5,1,0,0,0,0,2,0,20,12),(4260,'Castello Di Ama San Lorenzo Chianti',14,'8021846151123',39.99,NULL,5,1,0,0,0,0,2,0,24,12),(4261,'Szigeti Gruner Bubbly',14,'9005128000025',9.99,NULL,5,1,0,0,0,0,2,0,7,12),(4262,'Chi-Chi\'s Long Island Ice Tea 1.75',18,'089000548811',14.99,NULL,7,NULL,0,0,0,0,0,0,8.99,1),(4263,'Smirnoff Vodka 1.75ml',18,'082000105701',31.98,NULL,7,NULL,0,0,0,0,0,0,22.63,1),(4264,'Cline Cashmere Black',13,'098652400064',14.99,NULL,5,1,0,0,0,0,2,0,10,12),(4265,'Warre\'s Otima 10',13,'089419003161',29.99,NULL,5,1,0,0,0,0,2,0,21,12),(4266,'Sandeman Character Sherry',13,'8421150656008',19.99,NULL,5,1,0,0,0,0,2,0,14.55,12),(4267,'Paulaner Salvator Double Bock',1,'080157611878',12.75,NULL,6,NULL,0,0,0,0,0,0,8.75,1),(4268,'Cutwater Tiki Rum Mai Tai',1,'816751021689',13.99,NULL,6,NULL,0,0,0,0,0,0,9.85,1),(4269,'Tiki Rum Mai Tai',1,'816751021665',3.99,NULL,6,NULL,0,0,0,0,0,0,2.75,1),(4270,'Peanut Butter Egg',21,'03455102',0.99,NULL,59,NULL,0,0,0,0,0,0,0.5,1),(4271,'Golden Road Fruit Cart Mixer 15-Pack',1,'810628030415',19.99,NULL,6,NULL,0,0,0,0,0,0,14,1),(4272,'Campo Viejo Rioja',21,'852832106258',15.99,NULL,5,1,0,0,0,0,2,0,11,12),(4273,'Tortilla Chips',3,'99100066975',2.99,NULL,59,NULL,0,0,0,0,0,0,1.25,1),(4274,'Bulleit Bourbon 750ml',18,'087000005525',35.99,NULL,7,NULL,0,0,0,0,0,0,25.25,1),(4275,'Stoplman Roussanne',18,'890095000906',28.99,NULL,5,1,0,0,0,0,2,0,21,12),(4276,'Lunar Harvest Merlot',13,'848375002713',9.99,NULL,5,1,0,0,0,0,2,0,7,12),(4277,'Flat Rock Chardonnay',13,'7159001553',9.99,NULL,5,1,0,0,0,0,2,0,5,12),(4278,'Altos Ibericos Rioja',14,'088586006302',10.99,NULL,5,1,0,0,0,0,2,0,3,12),(4279,'Hahn Merlot',13,'086788777891',14.99,NULL,5,1,0,0,0,0,2,0,10.75,12),(4280,'Cruzan Black Strap Rum',18,'080686967606',14.99,NULL,7,NULL,0,0,0,0,0,0,11,1),(4281,'Roscato Sweet Red',13,'086785110738',14.99,NULL,5,1,0,0,0,0,2,0,8.25,12),(4282,'Eyzaguirre Cabernet',22,'091771944402',11.99,NULL,5,1,0,0,0,0,2,0,7.5,12),(4283,'whistlepig rye wiskey',17,'3573797940',82.5,NULL,7,NULL,0,0,0,0,0,0,75,1),(4284,'Mojo IPA',19,'050939112138',10.99,NULL,6,NULL,0,0,0,0,0,0,7.5,1),(4285,'Boulder Hazed & Confused',19,'050939112114',10.99,NULL,6,NULL,0,0,0,0,0,0,7.5,1),(4286,'Big Grove Arms Race',1,'752830777064',10.99,NULL,6,NULL,0,0,0,0,0,0,7.8,1),(4287,'Kinky Fruit Punch Mini 50ml',18,'084279005560',1.75,NULL,7,NULL,0,0,0,0,0,0,0.75,1),(4288,'Smirnoff Pink Lemonade 50ml',18,'08267807',1.99,NULL,7,NULL,0,0,0,0,0,0,1.12,1),(4289,'Mini Jagermeister 50ml',18,'083089660105',3.75,NULL,7,NULL,0,0,0,0,0,0,1.85,1),(4290,'Double Creme Brie',3,'4099100093759',7.99,NULL,4,NULL,0,0,0,0,0,0,4,1),(4291,'Carmel Road Chardonnay',13,'748284002548',14.99,NULL,5,1,0,0,0,0,2,0,9,12),(4292,'99 Strawberries',18,'088004039653',1.99,NULL,7,NULL,0,0,0,0,0,0,0.7,1),(4293,'Erath Willakia Chard',13,'084687007286',18.99,NULL,5,1,0,0,0,0,2,0,5,12),(4294,'New Amsterdam Peach 200ml',18,'085000020401',5.99,NULL,7,NULL,0,0,0,0,0,0,3.5,1),(4295,'Remy Martin VSOP 375ml',18,'087236001216',25.99,NULL,7,NULL,0,0,0,0,0,0,18.94,1),(4296,'Lakefront New Grist',1,'746546000684',10.99,NULL,6,NULL,0,0,0,0,0,0,7.75,1),(4297,'Farmstead Chardonnay',13,'894591002129',9.99,NULL,5,1,0,0,0,0,2,0,5,12),(4298,'Absolut Watermelon 750ml',18,'835229010994',21.99,NULL,7,NULL,0,0,0,0,0,0,15.5,1),(4299,'Whicked Pickle Whiskey',18,'085592163951',21.99,NULL,7,NULL,0,0,0,0,0,0,15.5,1),(4300,'Zing Zang',13,'616003741361',5.99,NULL,59,NULL,0,0,0,0,0,0,3.75,1),(4301,'Guenoc Cabernet',13,'081633185227',9.99,NULL,5,1,0,0,0,0,2,0,5.25,12),(4302,'Harlow Ridge Cabernet',13,'081054204354',9.99,NULL,5,1,0,0,0,0,2,0,5.25,12),(4303,'Chalk Hill Chardonnay',13,'016236000028',20.99,NULL,5,1,0,0,0,0,2,0,12,12),(4304,'Truly Citrus 12-Pack',17,'087692004240',20.99,NULL,6,NULL,0,0,0,0,0,0,15,1),(4305,'Gift Bag',21,'013286725536',1.98,NULL,1,NULL,0,0,0,0,0,0,1.25,1),(4306,'Can Diet Coke',23,'04965802',1,NULL,15,NULL,0,0,0,0,0,0,0.7,1),(4307,'Ace Pineapple',1,'8449008113',11.99,NULL,6,NULL,0,0,0,0,0,0,8.5,1),(4308,'Cutwater Variety Pack',1,'816751021979',18.99,NULL,6,NULL,0,0,0,0,0,0,13.66,1),(4309,'Fritz Muller Thurgau',22,'767946608614',18.99,NULL,5,1,0,0,0,0,2,0,13.5,12),(4310,'Cedre Hermitage Cahors Malbec',22,'3516481231231',21.99,NULL,5,1,0,0,0,0,2,0,14.5,12),(4311,'Colonel E.H. Taylor Bourbon',18,'088004005498',89.99,NULL,7,NULL,0,0,0,0,0,0,34,1),(4312,'Adelsheim Chardonnay',22,'011668060220',11.99,NULL,5,1,0,0,0,0,2,0,4,12),(4313,'Hudson Whiskey NY',18,'083664874507',42.99,NULL,7,NULL,0,0,0,0,0,0,30.55,1),(4314,'Oak & Eden Bourbon & Brew',18,'869673000485',65.99,NULL,7,NULL,0,0,0,0,0,0,47.25,1),(4315,'1800 Black Cherry Margarita',18,'818844021415',21.99,NULL,7,NULL,0,0,0,0,0,0,15.56,1),(4316,'Siduri Willamette PN',13,'877591002245',26.99,NULL,5,1,0,0,0,0,2,0,18,12),(4317,'Beauty in Chaos Red Blend',13,'088586009983',13.99,NULL,5,1,0,0,0,0,2,0,8.49,12),(4318,'Irish Cheddar with Beer',3,'4099100176414',4.99,NULL,4,NULL,0,0,0,0,0,0,2,1),(4319,'Irish Cheddar with Whiskey',3,'4099100176407',4.99,NULL,4,NULL,0,0,0,0,0,0,2,1),(4320,'Doubke Creme Red Brie',3,'4099100165241',7.99,NULL,4,NULL,0,0,0,0,0,0,4,1),(4321,'White Stilton with mango & Ginger',3,'4099100195798',7.99,NULL,4,NULL,0,0,0,0,0,0,4,1),(4322,'Large Marshmallows',3,'4099100093223',2.75,NULL,15,NULL,0,0,0,0,0,0,1,1),(4323,'Lg Bag Peanut M&M\'s',3,'040000513056',5.99,NULL,59,NULL,0,0,0,0,0,0,3,1),(4324,'Hop Valley Bubble Stash',17,'856052002130',10.99,NULL,6,NULL,0,0,0,0,0,0,7.5,1),(4325,'Alexander Valley Vineyards Merlot',13,'085798088621',20.99,NULL,5,1,0,0,0,0,2,0,12.25,12),(4326,'Alex Valley Vineyards Cabernet',13,'085798028726',23.99,NULL,5,1,0,0,0,0,2,0,15,12),(4327,'Mionetto Prosecco Rose',13,'816253012406',14.99,NULL,5,1,0,0,0,0,2,0,9.75,12),(4328,'Lolailo 8-Pack Sangria',13,'890582000204',13.99,NULL,5,8,0,0,0,0,2,0,8,4),(4329,'Meadowcroft Pinot Noir',21,'859784005318',24.99,NULL,5,1,0,0,0,0,2,0,20,12),(4330,'Ghirardelli Assortment',10,'747599306853',5.99,NULL,59,NULL,0,0,0,0,0,0,4,1),(4331,'Lindt Caramel Truffles',10,'009542004194',5.99,NULL,59,NULL,0,0,0,0,0,0,4,1),(4332,'Chateau Buena Vista Cabernet',19,'081188107699',43.99,NULL,5,1,0,0,0,0,2,0,30,12),(4333,'Old Elk Bourbon Whiskey',18,'852045007014',53.99,NULL,7,NULL,0,0,0,0,0,0,38,1),(4334,'Skittles',23,'04016201',1,NULL,59,NULL,0,0,0,0,0,0,0.8,1),(4335,'Caparzo Sangiovese',13,'089419002102',10.99,NULL,5,1,0,0,0,0,2,0,6,12),(4336,'Larceny Bourbon',18,'096749031559',28.99,NULL,7,NULL,0,0,0,0,0,0,21,1),(4337,'Honey Goat Cheese',3,'4099100133950',3.99,NULL,4,NULL,0,0,0,0,0,0,2,1),(4338,'Beer Nuts',3,'070842309043',2.59,NULL,4,NULL,0,0,0,0,0,0,1,1),(4339,'Choclatiers',3,'4099100086270',4.5,NULL,59,NULL,0,0,0,0,0,0,2,1),(4340,'Copper Cross Single Barrel Bourbon',18,'858506004264',47.99,NULL,7,NULL,0,0,0,0,0,0,34.25,1),(4341,'Starburst',23,'040000009702',1.49,NULL,59,NULL,0,0,0,0,0,0,1,1),(4342,'Bubly',21,'012000181153',0.99,NULL,15,NULL,0,0,0,0,0,0,0.5,1),(4343,'Blue Raz Fun Dip',21,'079200009373',0.75,NULL,59,NULL,0,0,0,0,0,0,0.45,1),(4344,'Chap Stick',21,'036600814013',1.59,NULL,1,NULL,0,0,0,0,0,0,1,1),(4345,'La Vieille Ferme',13,'089419000177',10.99,NULL,5,1,0,0,0,0,2,0,6,12),(4346,'Breckenridge Agave Wheat',1,'745432310098',10.99,NULL,6,NULL,0,0,0,0,0,0,7.25,1),(4347,'Bud Light Bottle',1,'01816927',2.5,NULL,6,NULL,0,0,0,0,0,0,1,1),(4348,'Bacardi Tropical',18,'0480986414',17.99,NULL,7,NULL,0,0,0,0,0,0,12.88,1),(4349,'Copper Dog Scotch',18,'088076181434',35.99,NULL,7,NULL,0,0,0,0,0,0,25.25,1),(4350,'Busch',1,'018200610479',14.99,NULL,6,NULL,0,0,0,0,0,0,11,1),(4351,'Kinky Pink',18,'084279983431',21.99,NULL,7,NULL,0,0,0,0,0,0,15.5,1),(4352,'Charles Krug Cabernet',21,'086012200430',39.99,NULL,5,1,0,0,0,0,2,0,30,12),(4353,'Cedar Ridge 965',9,'859824001102',17.25,NULL,5,1,0,0,0,0,2,0,12.25,12),(4354,'Maker\'s Mark 46',18,'085246500101',44.99,NULL,7,NULL,0,0,0,0,0,0,32,1),(4355,'Flip Sides Crackers',21,'030100103097',4.99,NULL,4,NULL,0,0,0,0,0,0,2.68,1),(4356,'Glenlivet Caribbean Reserve',18,'080432115763',44.75,NULL,7,NULL,0,0,0,0,0,0,31.99,1),(4357,'Jeppson\'s Mallort',18,'021037010190',23.99,NULL,7,NULL,0,0,0,0,0,0,16.76,1),(4358,'99 Root Beer',18,'088004023850',1.99,NULL,7,NULL,0,0,0,0,0,0,0.7,1),(4359,'Yellow Tail Merlot',13,'031259009223',6.5,NULL,5,1,0,0,0,0,2,0,4.88,12),(4360,'Cellar No. 8 Pinot Noir',13,'081054995009',7.33,NULL,5,1,0,0,0,0,2,0,5.25,12),(4361,'Welches Sparkling Rose',23,'041800705405',4.99,NULL,59,NULL,0,0,0,0,0,0,2.33,1),(4362,'Pub Pretzels',3,'4099100168013',5.99,NULL,59,NULL,0,0,0,0,0,0,3,1),(4363,'Jack Link Dill Pickle BM Mix',1,'859579004571',7.99,NULL,59,NULL,0,0,0,0,0,0,4.42,1),(4364,'Tres Generaciones Plata',19,'080686836018',40.99,NULL,7,NULL,0,0,0,0,0,0,29,1),(4365,'Clubtails Margarita',1,'746401026',2.99,NULL,6,NULL,0,0,0,0,0,0,1.25,1),(4366,'Club Tails Sunny Marg 6-Pack',1,'684746401033',11.99,NULL,6,NULL,0,0,0,0,0,0,7.5,1),(4367,'Bud Light Out of the Office',1,'018200202780',18.99,NULL,6,NULL,0,0,0,0,0,0,13,1),(4368,'Cutwater Mango Margarita',1,'816751022105',13.99,NULL,6,NULL,0,0,0,0,0,0,10,1),(4369,'Cutwater Mango Marg',1,'816751022099',3.99,NULL,6,NULL,0,0,0,0,0,0,2,1),(4370,'Borgo Scopeto',13,'089419002003',15.99,NULL,5,1,0,0,0,0,2,0,11,12),(4371,'Bourbon Gouda',21,'604262738079',7.99,NULL,4,NULL,0,0,0,0,0,0,4,1),(4372,'Left Hand Sinister Malt Whiskey',18,'850826008175',64.99,NULL,7,NULL,0,0,0,0,0,0,46,1),(4373,'Old Ezra 7 Year Bourbon',18,'088352133362',63.99,NULL,7,NULL,0,0,0,0,0,0,45.5,1),(4374,'Silk Road Bourbon',18,'810071260100',29.99,NULL,7,NULL,0,0,0,0,0,0,21.5,1),(4375,'Ramey Ritchie Vineyard Chardonnay',22,'185983000084',72.99,NULL,7,NULL,0,0,0,0,0,0,52.5,1),(4376,'Bud Light Platinum Seltzer Variety Pack',1,'018200202506',10.99,NULL,6,NULL,0,0,0,0,0,0,7.25,1),(4377,'Ole Smoky Blackberry Moonshine 50ml',18,'856011004175',3.99,NULL,7,NULL,0,0,0,0,0,0,2.18,1),(4378,'Louis Jadot Pouilly-Fuisse',13,'4692424542',33.99,NULL,5,1,0,0,0,0,2,0,24.3,12),(4379,'Eroica Riesling',13,'088586000201',21.99,NULL,5,1,0,0,0,0,2,0,15,12),(4380,'Christian Brothers Cream Sherry',13,'086036931273',10.99,NULL,5,1,0,0,0,0,2,0,8,12),(4381,'Lolailo Sangria',13,'0582000143',2.99,NULL,5,1,0,0,0,0,2,0,1.75,12),(4382,'Cuervo Light Margarita',18,'811538011006',19.25,NULL,7,NULL,0,0,0,0,0,0,13.75,1),(4383,'Scattered Peaks Napa Cabernet',13,'851718001014',34.99,NULL,5,1,0,0,0,0,2,0,26.25,12),(4384,'The Prisoner Red Blend',13,'086003255067',49.99,NULL,5,1,0,0,0,0,2,0,30,12),(4385,'Faust Napa Cabernet',13,'859369001254',53.99,NULL,5,1,0,0,0,0,2,0,21.5,12),(4386,'Bella Union Cabernet',13,'864796000107',69.99,NULL,5,1,0,0,0,0,2,0,48.67,12),(4387,'Walt Pinot Noir La Brisa',13,'892159000099',39.99,NULL,5,1,0,0,0,0,2,0,28,12),(4388,'2016 Chateau Clos Junet St. Emilion Grand Cru',21,'3760208580137',39.99,NULL,5,1,0,0,0,0,2,0,25,12),(4389,'Domaine Sangouard Pouilly-Fuisse',21,'3760158450085',27.99,NULL,5,1,0,0,0,0,2,0,20,12),(4390,'Les Banquettes Escarpees GSM',22,'3430560007718',14.99,NULL,5,1,0,0,0,0,2,0,7.75,12),(4391,'Clubtails Margarita',17,']684746401026',2.99,NULL,6,NULL,0,0,0,0,0,0,1.5,1),(4392,'Reeces PB Cups',23,'03444009',1.49,NULL,59,NULL,0,0,0,0,0,0,0.89,1),(4393,'Cornichons',21,'--006163',5.99,NULL,4,NULL,0,0,0,0,0,0,2.99,1),(4394,'Blue Moon Mango Wheat',17,'087800000713',10.99,NULL,6,NULL,0,0,0,0,0,0,7.8,1),(4395,'Leinenkugels Summer Shandy',17,'034100015060',10.99,NULL,6,NULL,0,0,0,0,0,0,7.8,1),(4396,'Manzanila Olives',21,'00204293',5.5,NULL,4,NULL,0,0,0,0,0,0,2.75,1),(4397,'Giant Chalkidiki Olives',21,'00576086',5.5,NULL,4,NULL,0,0,0,0,0,0,2.5,1),(4398,'Hot & Sweet Pepper Jelly',21,'00965347',5.5,NULL,4,NULL,0,0,0,0,0,0,2.75,1),(4399,'2015 Northstar Merlot',13,'088586000256',20,NULL,5,1,0,0,0,0,2,0,12,12),(4400,'Agavero',18,'811538012072',37.99,NULL,7,NULL,0,0,0,0,0,0,26.75,1),(4401,'Patron Citronge',18,'721733000043',29.99,NULL,7,NULL,0,0,0,0,0,0,21.76,1),(4402,'Seagram\'s 7',18,'087000007338',16.5,NULL,7,NULL,0,0,0,0,0,0,11.75,1),(4403,'McQueen & the Violet Fog Gin',18,'813497007168',39.99,NULL,7,NULL,0,0,0,0,0,0,28.25,1),(4404,'Dogfish Head Sea Quench',17,'638489001937',11.99,NULL,6,NULL,0,0,0,0,0,0,8.55,1),(4405,'Willakenzie Pinot Noir',13,'603110950038',23.99,NULL,5,1,0,0,0,0,2,0,13.5,12),(4406,'Rosemary Flatbread',3,'4099100122848',4.99,NULL,4,NULL,0,0,0,0,0,0,2.75,1),(4407,'Blue Moon 4-Pack Cans',17,'071990095451',10.99,NULL,6,NULL,0,0,0,0,0,0,7.4,1),(4408,'Breckenridge Avalanche Amber',1,'745432110001',10.99,NULL,6,NULL,0,0,0,0,0,0,7.25,1),(4409,'Sunny Margarita',1,'684746401026',2.99,NULL,6,NULL,0,0,0,0,0,0,1.5,1),(4410,'Halloumi Cheese',3,'4099100190885',6.99,NULL,4,NULL,0,0,0,0,0,0,3.99,1),(4411,'Goat Milk Cherry Cheese',3,'4099100257267',6.99,NULL,4,NULL,0,0,0,0,0,0,3.59,1),(4412,'Bacardi Tropical',18,'080480986414',17.99,NULL,7,NULL,0,0,0,0,0,0,13,1),(4413,'Howler Head Bourbon Mini',18,'850003347646',1.99,NULL,7,NULL,0,0,0,0,0,0,1,1),(4414,'Paul Masson Pineapple',18,'021296620215',14.99,NULL,7,NULL,0,0,0,0,0,0,10.12,1),(4415,'Caol Ila 12',18,'088076163461',93.99,NULL,7,NULL,0,0,0,0,0,0,67.99,1),(4416,'Bombay Bramble',18,'080480986001',29.99,NULL,7,NULL,0,0,0,0,0,0,20.75,1),(4417,'Appalachian Sippin\' Cream',18,'811559020360',29.99,NULL,7,NULL,0,0,0,0,0,0,20.78,1),(4418,'Propane',5,'PROPANE EXC',20.99,NULL,8,NULL,0,0,0,0,0,0,14.5,1),(4419,'Propane Exchange',5,'PROPANE EXCHANGE',20.99,NULL,8,NULL,0,0,0,0,0,0,14.5,1),(4420,'Sand Point sauvignon Blanc',14,'N891540001615',11.99,NULL,5,1,0,0,0,0,2,0,7.5,12),(4421,'Sugarlands Shine',18,'811559020025',29.99,NULL,7,NULL,0,0,0,0,0,0,20.78,1),(4428,'Red Wine Tasting',NULL,'REDWINETASTING',25,NULL,26,NULL,0,0,0,0,0,0,NULL,1),(4430,'Winter Wine Tasting',NULL,'WINTERWINETASTING',0,NULL,26,NULL,0,0,0,0,0,0,NULL,1),(4434,'ABC',21,'ABC',0.99,NULL,9,0,0,0,0,0,0,0,NULL,1),(4435,'ABC Blocks',2,'ABCBLOCKS',10,NULL,1,0,0,0,0,0,0,0,NULL,1),(4436,'ABC Candy',21,'ABCCANDY',1,NULL,2,0,0,0,0,0,0,0,NULL,1),(4437,'DeleteMe',2,'DELETEME',10.11,NULL,6,1,0,0,0,1,1,0,NULL,1),(4448,'Private Wine Tasting',NULL,'PRIVATEWINETASTING',15,NULL,26,NULL,1,1,0,0,0,0,NULL,1),(4449,'RestockFee',21,'RESTOCKFEE',0,NULL,12,0,0,0,0,0,0,0,NULL,1);
/*!40000 ALTER TABLE `inventory_description` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_inventory_description_BI` BEFORE INSERT ON `inventory_description` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'inventory_description' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_inventory_description_BU` BEFORE UPDATE ON `inventory_description` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'inventory_description' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_inventory_description_BD` BEFORE DELETE ON `inventory_description` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'inventory_description' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `inventory_price`
--

DROP TABLE IF EXISTS `inventory_price`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `inventory_price` (
  `inventoryID` int NOT NULL,
  `inventory_qty` int NOT NULL,
  `supplier_price` double NOT NULL,
  `purchased_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`inventoryID`),
  CONSTRAINT `fk_inventoryID` FOREIGN KEY (`inventoryID`) REFERENCES `inventory_description` (`inventoryID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventory_price`
--

LOCK TABLES `inventory_price` WRITE;
/*!40000 ALTER TABLE `inventory_price` DISABLE KEYS */;
INSERT INTO `inventory_price` VALUES (1024,12,10.99,'1900-01-01 00:00:00'),(1025,5,6.99,'1900-01-01 00:00:00'),(1026,2,1.25,'1900-01-01 00:00:00'),(1027,1,9.99,'1900-01-01 00:00:00'),(1028,1,2.99,'1900-01-01 00:00:00'),(1029,1,6.99,'1900-01-01 00:00:00'),(1030,0,190,'1900-01-01 00:00:00'),(1031,0,6,'1900-01-01 00:00:00'),(1032,5,11.99,'1900-01-01 00:00:00'),(1033,1,2.99,'1900-01-01 00:00:00'),(1034,1,24.99,'1900-01-01 00:00:00'),(1035,1,7.99,'1900-01-01 00:00:00'),(1036,10,13.99,'1900-01-01 00:00:00'),(1037,1,1,'1900-01-01 00:00:00'),(1038,99,1,'1900-01-01 00:00:00'),(1039,6,0,'1900-01-01 00:00:00'),(1040,5,2.75,'1900-01-01 00:00:00'),(1041,1,1.49,'1900-01-01 00:00:00'),(1042,5,1.49,'1900-01-01 00:00:00'),(1043,1,1.89,'1900-01-01 00:00:00'),(1044,4,12.99,'1900-01-01 00:00:00'),(1045,14,1,'1900-01-01 00:00:00'),(1046,0,1.25,'1900-01-01 00:00:00'),(1047,0,1,'1900-01-01 00:00:00'),(1048,1,2.99,'1900-01-01 00:00:00'),(1049,0,1.99,'1900-01-01 00:00:00'),(1050,2,44.55,'1900-01-01 00:00:00'),(1051,1,8.99,'1900-01-01 00:00:00'),(1052,0,7.25,'1900-01-01 00:00:00'),(1053,10,38.99,'1900-01-01 00:00:00'),(1054,5,6.99,'1900-01-01 00:00:00'),(1055,3,4.99,'1900-01-01 00:00:00'),(1056,0,6,'1900-01-01 00:00:00'),(1057,13,1.99,'1900-01-01 00:00:00'),(1058,9,1.99,'1900-01-01 00:00:00'),(1059,8,84.99,'1900-01-01 00:00:00'),(1060,3,179.99,'1900-01-01 00:00:00'),(1061,15,17.99,'1900-01-01 00:00:00'),(1062,2,1.89,'1900-01-01 00:00:00'),(1063,2,1.89,'1900-01-01 00:00:00'),(1064,0,1.5,'1900-01-01 00:00:00'),(1065,0,1.5,'1900-01-01 00:00:00'),(1066,0,5,'1900-01-01 00:00:00'),(1067,0,10,'1900-01-01 00:00:00'),(1068,0,0.99,'1900-01-01 00:00:00'),(1069,0,12,'1900-01-01 00:00:00'),(1070,0,0.92,'1900-01-01 00:00:00'),(1071,0,13.99,'1900-01-01 00:00:00'),(1072,0,1.99,'1900-01-01 00:00:00'),(1073,0,7.5,'1900-01-01 00:00:00'),(1074,0,7.73,'1900-01-01 00:00:00'),(1075,0,11,'1900-01-01 00:00:00'),(1076,0,9.99,'1900-01-01 00:00:00'),(1077,0,7.5,'1900-01-01 00:00:00'),(1078,5,10.99,'1900-01-01 00:00:00'),(1079,1,17.99,'1900-01-01 00:00:00'),(1080,1,9.99,'1900-01-01 00:00:00'),(1081,3,10.99,'1900-01-01 00:00:00'),(1082,1,17.99,'1900-01-01 00:00:00'),(1083,1,17.99,'1900-01-01 00:00:00'),(1084,3,7.53,'1900-01-01 00:00:00'),(1085,3,4.99,'1900-01-01 00:00:00'),(1086,0,1.99,'1900-01-01 00:00:00'),(1087,0,10.98,'1900-01-01 00:00:00'),(1088,1,17.99,'1900-01-01 00:00:00'),(1089,0,8.5,'1900-01-01 00:00:00'),(1090,0,1.02,'1900-01-01 00:00:00'),(1091,1,12.99,'1900-01-01 00:00:00'),(1092,0,7,'1900-01-01 00:00:00'),(1093,0,7,'1900-01-01 00:00:00'),(1094,0,10,'1900-01-01 00:00:00'),(1095,0,7.5,'1900-01-01 00:00:00'),(1096,0,8.25,'1900-01-01 00:00:00'),(1097,1,2.99,'1900-01-01 00:00:00'),(1098,0,3.75,'1900-01-01 00:00:00'),(1099,0,10.99,'1900-01-01 00:00:00'),(1100,5,3.5,'1900-01-01 00:00:00'),(1101,7,4.99,'1900-01-01 00:00:00'),(1102,3,4.99,'1900-01-01 00:00:00'),(1103,0,6.99,'1900-01-01 00:00:00'),(1104,1,6.99,'1900-01-01 00:00:00'),(1105,0,5.79,'1900-01-01 00:00:00'),(1106,1,4.99,'1900-01-01 00:00:00'),(1107,0,5.45,'1900-01-01 00:00:00'),(1108,0,5.99,'1900-01-01 00:00:00'),(1109,0,40,'1900-01-01 00:00:00'),(1110,0,99.8,'1900-01-01 00:00:00'),(1111,1,1.59,'1900-01-01 00:00:00'),(1112,3,1.59,'1900-01-01 00:00:00'),(1113,1,1.59,'1900-01-01 00:00:00'),(1114,1,3.99,'1900-01-01 00:00:00'),(1115,1,3.99,'1900-01-01 00:00:00'),(1116,0,23.99,'1900-01-01 00:00:00'),(1117,1,19.99,'1900-01-01 00:00:00'),(1118,3,16,'1900-01-01 00:00:00'),(1119,4,1.49,'1900-01-01 00:00:00'),(1120,7,1.49,'1900-01-01 00:00:00'),(1121,4,1.49,'1900-01-01 00:00:00'),(1122,4,4.5,'1900-01-01 00:00:00'),(1123,7,4.89,'1900-01-01 00:00:00'),(1124,20,1.99,'1900-01-01 00:00:00'),(1125,0,2.99,'1900-01-01 00:00:00'),(1126,1,12.99,'1900-01-01 00:00:00'),(1127,2,12.99,'1900-01-01 00:00:00'),(1128,1,12.99,'1900-01-01 00:00:00'),(1129,0,64.8,'1900-01-01 00:00:00'),(1130,0,10.99,'1900-01-01 00:00:00'),(1131,0,9,'1900-01-01 00:00:00'),(1132,1,13.99,'1900-01-01 00:00:00'),(1133,3,36.99,'1900-01-01 00:00:00'),(1134,0,1,'1900-01-01 00:00:00'),(1135,0,1.5,'1900-01-01 00:00:00'),(1136,0,1.25,'1900-01-01 00:00:00'),(1137,1,5.99,'1900-01-01 00:00:00'),(1138,0,5.99,'1900-01-01 00:00:00'),(1139,6,9.99,'1900-01-01 00:00:00'),(1140,6,1.99,'1900-01-01 00:00:00'),(1141,3,4.99,'1900-01-01 00:00:00'),(1142,5,35.99,'1900-01-01 00:00:00'),(1143,1,12.99,'1900-01-01 00:00:00'),(1144,1,8.99,'1900-01-01 00:00:00'),(1145,2,7.99,'1900-01-01 00:00:00'),(1146,10,2.49,'1900-01-01 00:00:00'),(1147,5,11.99,'1900-01-01 00:00:00'),(1148,6,4.99,'1900-01-01 00:00:00'),(1149,2,16.99,'1900-01-01 00:00:00'),(1150,2,4.99,'1900-01-01 00:00:00'),(1151,2,3.75,'1900-01-01 00:00:00'),(1152,3,3.75,'1900-01-01 00:00:00'),(1153,0,3.75,'1900-01-01 00:00:00'),(1154,1,6.99,'1900-01-01 00:00:00'),(1155,0,31.99,'1900-01-01 00:00:00'),(1156,0,3.87,'1900-01-01 00:00:00'),(1157,4,1.99,'1900-01-01 00:00:00'),(1158,23,7.99,'1900-01-01 00:00:00'),(1159,3,48.99,'1900-01-01 00:00:00'),(1160,1,10.99,'1900-01-01 00:00:00'),(1161,0,1.99,'1900-01-01 00:00:00'),(1162,0,13.99,'1900-01-01 00:00:00'),(1163,1,1.99,'1900-01-01 00:00:00'),(1164,2,10.99,'1900-01-01 00:00:00'),(1165,1,13.99,'1900-01-01 00:00:00'),(1166,0,9.99,'1900-01-01 00:00:00'),(1167,0,13.8,'1900-01-01 00:00:00'),(1168,0,11,'1900-01-01 00:00:00'),(1169,1,13.99,'1900-01-01 00:00:00'),(1170,2,1.49,'1900-01-01 00:00:00'),(1171,1,6.99,'1900-01-01 00:00:00'),(1172,2,4.99,'1900-01-01 00:00:00'),(1173,1,6.99,'1900-01-01 00:00:00'),(1174,1,6.99,'1900-01-01 00:00:00'),(1175,1,14.95,'1900-01-01 00:00:00'),(1176,0,11.99,'1900-01-01 00:00:00'),(1177,0,3.99,'1900-01-01 00:00:00'),(1178,0,1.25,'1900-01-01 00:00:00'),(1179,8,8.99,'1900-01-01 00:00:00'),(1180,0,8.99,'1900-01-01 00:00:00'),(1181,5,1.99,'1900-01-01 00:00:00'),(1182,6,0.5,'1900-01-01 00:00:00'),(1183,0,7.99,'1900-01-01 00:00:00'),(1184,9,0.5,'1900-01-01 00:00:00'),(1185,5,1.49,'1900-01-01 00:00:00'),(1186,3,1.49,'1900-01-01 00:00:00'),(1187,1,2.99,'1900-01-01 00:00:00'),(1188,1,5.99,'1900-01-01 00:00:00'),(1189,2,1.49,'1900-01-01 00:00:00'),(1190,0,42.99,'1900-01-01 00:00:00'),(1191,0,24,'1900-01-01 00:00:00'),(1192,6,1.49,'1900-01-01 00:00:00'),(1193,10,1.49,'1900-01-01 00:00:00'),(1194,2,12.99,'1900-01-01 00:00:00'),(1195,0,19,'1900-01-01 00:00:00'),(1196,11,1.49,'1900-01-01 00:00:00'),(1197,0,0.25,'1900-01-01 00:00:00'),(1198,7,0.5,'1900-01-01 00:00:00'),(1199,1,2.75,'1900-01-01 00:00:00'),(1200,0,1.5,'1900-01-01 00:00:00'),(1201,0,3.99,'1900-01-01 00:00:00'),(1202,1,3.99,'1900-01-01 00:00:00'),(1203,1,2.99,'1900-01-01 00:00:00'),(1204,0,5,'1900-01-01 00:00:00'),(1205,1,3.99,'1900-01-01 00:00:00'),(1206,0,2.75,'1900-01-01 00:00:00'),(1207,1,3.99,'1900-01-01 00:00:00'),(1208,1,4.99,'1900-01-01 00:00:00'),(1209,2,3.99,'1900-01-01 00:00:00'),(1210,1,4.99,'1900-01-01 00:00:00'),(1211,0,4.99,'1900-01-01 00:00:00'),(1212,1,3.99,'1900-01-01 00:00:00'),(1213,0,4.99,'1900-01-01 00:00:00'),(1214,0,3.75,'1900-01-01 00:00:00'),(1215,3,7.99,'1900-01-01 00:00:00'),(1216,1,5.99,'1900-01-01 00:00:00'),(1217,0,6.99,'1900-01-01 00:00:00'),(1218,2,6.99,'1900-01-01 00:00:00'),(1219,0,4,'1900-01-01 00:00:00'),(1220,1,15.99,'1900-01-01 00:00:00'),(1221,1,3.99,'1900-01-01 00:00:00'),(1222,0,3.75,'1900-01-01 00:00:00'),(1223,1,4.99,'1900-01-01 00:00:00'),(1224,0,2.79,'1900-01-01 00:00:00'),(1225,1,3.99,'1900-01-01 00:00:00'),(1226,1,4.99,'1900-01-01 00:00:00'),(1227,0,7.99,'1900-01-01 00:00:00'),(1228,0,5,'1900-01-01 00:00:00'),(1229,0,3.5,'1900-01-01 00:00:00'),(1230,3,4.99,'1900-01-01 00:00:00'),(1231,1,4.99,'1900-01-01 00:00:00'),(1232,0,5.25,'1900-01-01 00:00:00'),(1233,1,5.99,'1900-01-01 00:00:00'),(1234,1,5.99,'1900-01-01 00:00:00'),(1235,1,7.99,'1900-01-01 00:00:00'),(1236,2,14.99,'1900-01-01 00:00:00'),(1237,2,14.99,'1900-01-01 00:00:00'),(1238,1,14.99,'1900-01-01 00:00:00'),(1239,0,3.25,'1900-01-01 00:00:00'),(1240,1,4.99,'1900-01-01 00:00:00'),(1241,1,4.99,'1900-01-01 00:00:00'),(1242,1,3.99,'1900-01-01 00:00:00'),(1243,1,3.99,'1900-01-01 00:00:00'),(1244,1,5.99,'1900-01-01 00:00:00'),(1245,0,3.49,'1900-01-01 00:00:00'),(1246,0,4.99,'1900-01-01 00:00:00'),(1247,0,1.99,'1900-01-01 00:00:00'),(1248,1,13.98,'1900-01-01 00:00:00'),(1249,0,4,'1900-01-01 00:00:00'),(1250,1,15.99,'1900-01-01 00:00:00'),(1251,0,3.99,'1900-01-01 00:00:00'),(1252,1,14.99,'1900-01-01 00:00:00'),(1253,1,4.99,'1900-01-01 00:00:00'),(1254,1,4.99,'1900-01-01 00:00:00'),(1255,1,4.99,'1900-01-01 00:00:00'),(1256,1,4.99,'1900-01-01 00:00:00'),(1257,1,2.99,'1900-01-01 00:00:00'),(1258,0,1.25,'1900-01-01 00:00:00'),(1259,1,4.99,'1900-01-01 00:00:00'),(1260,1,38.99,'1900-01-01 00:00:00'),(1261,9,15,'1900-01-01 00:00:00'),(1262,0,6,'1900-01-01 00:00:00'),(1263,1,2.99,'1900-01-01 00:00:00'),(1264,1,6.25,'1900-01-01 00:00:00'),(1265,0,14.5,'1900-01-01 00:00:00'),(1266,99,0.5,'1900-01-01 00:00:00'),(1267,3,2.69,'1900-01-01 00:00:00'),(1268,0,2.69,'1900-01-01 00:00:00'),(1269,0,1.89,'1900-01-01 00:00:00'),(1270,0,5.99,'1900-01-01 00:00:00'),(1271,1,10.99,'1900-01-01 00:00:00'),(1272,21,1,'1900-01-01 00:00:00'),(1273,0,22.99,'1900-01-01 00:00:00'),(1274,11,1,'1900-01-01 00:00:00'),(1275,0,1.25,'1900-01-01 00:00:00'),(1276,1,18.99,'1900-01-01 00:00:00'),(1277,1,18.99,'1900-01-01 00:00:00'),(1278,0,21.79,'1900-01-01 00:00:00'),(1279,3,32.99,'1900-01-01 00:00:00'),(1280,8,1.25,'1900-01-01 00:00:00'),(1281,0,1.25,'1900-01-01 00:00:00'),(1282,0,1.69,'1900-01-01 00:00:00'),(1283,2,1.69,'1900-01-01 00:00:00'),(1284,996,1.69,'1900-01-01 00:00:00'),(1285,1,4.5,'1900-01-01 00:00:00'),(1286,0,2.5,'1900-01-01 00:00:00'),(1287,0,2.52,'1900-01-01 00:00:00'),(1288,0,1.25,'1900-01-01 00:00:00'),(1289,0,1.07,'1900-01-01 00:00:00'),(1290,1,7.99,'1900-01-01 00:00:00'),(1291,3,3.89,'1900-01-01 00:00:00'),(1292,2,10.99,'1900-01-01 00:00:00'),(1293,1,7.99,'1900-01-01 00:00:00'),(1294,1,7.99,'1900-01-01 00:00:00'),(1295,2,5.99,'1900-01-01 00:00:00'),(1296,0,0,'1900-01-01 00:00:00'),(1297,2,1.99,'1900-01-01 00:00:00'),(1298,2,9.99,'1900-01-01 00:00:00'),(1299,3,5.99,'1900-01-01 00:00:00'),(1300,1,5.99,'1900-01-01 00:00:00'),(1301,1,5.99,'1900-01-01 00:00:00'),(1302,14,3.25,'1900-01-01 00:00:00'),(1303,0,2.78,'1900-01-01 00:00:00'),(1304,1,5.99,'1900-01-01 00:00:00'),(1305,1,5.99,'1900-01-01 00:00:00'),(1306,2,7.99,'1900-01-01 00:00:00'),(1307,12,6.99,'1900-01-01 00:00:00'),(1308,2,5.99,'1900-01-01 00:00:00'),(1309,0,5.99,'1900-01-01 00:00:00'),(1310,14,5.99,'1900-01-01 00:00:00'),(1311,1,2.99,'1900-01-01 00:00:00'),(1312,0,1.07,'1900-01-01 00:00:00'),(1313,0,3.83,'1900-01-01 00:00:00'),(1314,11,0.5,'1900-01-01 00:00:00'),(1315,0,4.99,'1900-01-01 00:00:00'),(1316,4,8.99,'1900-01-01 00:00:00'),(1317,0,6.99,'1900-01-01 00:00:00'),(1318,0,2.96,'1900-01-01 00:00:00'),(1319,2,2.99,'1900-01-01 00:00:00'),(1320,508,1.605469,'1900-01-01 00:00:00'),(1321,0,1.25,'1900-01-01 00:00:00'),(1322,1,4.99,'1900-01-01 00:00:00'),(1323,0,2.99,'1900-01-01 00:00:00'),(1324,0,3.2,'1900-01-01 00:00:00'),(1325,1,1.99,'1900-01-01 00:00:00'),(1326,4,4.99,'1900-01-01 00:00:00'),(1327,4,2.75,'1900-01-01 00:00:00'),(1328,0,1.68,'1900-01-01 00:00:00'),(1329,0,10.98,'1900-01-01 00:00:00'),(1330,0,7.25,'1900-01-01 00:00:00'),(1331,0,6.99,'1900-01-01 00:00:00'),(1332,1,4.99,'1900-01-01 00:00:00'),(1333,0,2.99,'1900-01-01 00:00:00'),(1334,1,4.5,'1900-01-01 00:00:00'),(1335,0,2.99,'1900-01-01 00:00:00'),(1336,0,4.5,'1900-01-01 00:00:00'),(1337,2,4.5,'1900-01-01 00:00:00'),(1338,1,4.5,'1900-01-01 00:00:00'),(1339,0,2.99,'1900-01-01 00:00:00'),(1340,0,2.99,'1900-01-01 00:00:00'),(1341,0,2.99,'1900-01-01 00:00:00'),(1342,0,2.99,'1900-01-01 00:00:00'),(1343,0,2.99,'1900-01-01 00:00:00'),(1344,2,9.99,'1900-01-01 00:00:00'),(1345,1,10.99,'1900-01-01 00:00:00'),(1346,0,6.99,'1900-01-01 00:00:00'),(1347,0,3,'1900-01-01 00:00:00'),(1348,8,4.99,'1900-01-01 00:00:00'),(1349,3,9.99,'1900-01-01 00:00:00'),(1350,2,5.99,'1900-01-01 00:00:00'),(1351,1,3.99,'1900-01-01 00:00:00'),(1352,1,3.99,'1900-01-01 00:00:00'),(1353,3,2.99,'1900-01-01 00:00:00'),(1354,1,4.99,'1900-01-01 00:00:00'),(1355,0,6.98,'1900-01-01 00:00:00'),(1356,0,6.98,'1900-01-01 00:00:00'),(1357,0,1.5,'1900-01-01 00:00:00'),(1358,0,1.5,'1900-01-01 00:00:00'),(1359,1,4.99,'1900-01-01 00:00:00'),(1360,11,13.99,'1900-01-01 00:00:00'),(1361,12,13.99,'1900-01-01 00:00:00'),(1362,1,2.99,'1900-01-01 00:00:00'),(1363,6,2.69,'1900-01-01 00:00:00'),(1364,2,4.99,'1900-01-01 00:00:00'),(1365,2,9.99,'1900-01-01 00:00:00'),(1366,2,9.99,'1900-01-01 00:00:00'),(1367,1,6.5,'1900-01-01 00:00:00'),(1368,1,5.5,'1900-01-01 00:00:00'),(1369,1,5,'1900-01-01 00:00:00'),(1370,1,6.99,'1900-01-01 00:00:00'),(1371,4,4.5,'1900-01-01 00:00:00'),(1372,2,2.99,'1900-01-01 00:00:00'),(1373,1,2.99,'1900-01-01 00:00:00'),(1374,4,2.99,'1900-01-01 00:00:00'),(1375,1,2.5,'1900-01-01 00:00:00'),(1376,1,2.99,'1900-01-01 00:00:00'),(1377,3,2.99,'1900-01-01 00:00:00'),(1378,3,2.99,'1900-01-01 00:00:00'),(1379,1,6.5,'1900-01-01 00:00:00'),(1380,5,5.99,'1900-01-01 00:00:00'),(1381,3,4.99,'1900-01-01 00:00:00'),(1382,5,5.99,'1900-01-01 00:00:00'),(1383,1,5.99,'1900-01-01 00:00:00'),(1384,1,11.99,'1900-01-01 00:00:00'),(1385,3,7.99,'1900-01-01 00:00:00'),(1386,1,3.99,'1900-01-01 00:00:00'),(1387,1,3.99,'1900-01-01 00:00:00'),(1388,4,3.99,'1900-01-01 00:00:00'),(1389,2,3.99,'1900-01-01 00:00:00'),(1390,2,2.75,'1900-01-01 00:00:00'),(1391,3,2.5,'1900-01-01 00:00:00'),(1392,4,3.99,'1900-01-01 00:00:00'),(1393,2,0.99,'1900-01-01 00:00:00'),(1394,1,3.49,'1900-01-01 00:00:00'),(1395,1,2.99,'1900-01-01 00:00:00'),(1396,7,2.99,'1900-01-01 00:00:00'),(1397,3,2.99,'1900-01-01 00:00:00'),(1398,0,2,'1900-01-01 00:00:00'),(1399,2,5,'1900-01-01 00:00:00'),(1400,2,2.99,'1900-01-01 00:00:00'),(1401,15,2.99,'1900-01-01 00:00:00'),(1402,3,2.99,'1900-01-01 00:00:00'),(1403,7,3.99,'1900-01-01 00:00:00'),(1404,5,3.99,'1900-01-01 00:00:00'),(1405,4,3.99,'1900-01-01 00:00:00'),(1406,8,2.69,'1900-01-01 00:00:00'),(1407,7,3.99,'1900-01-01 00:00:00'),(1408,1,21.99,'1900-01-01 00:00:00'),(1409,1,12.99,'1900-01-01 00:00:00'),(1410,3,12.99,'1900-01-01 00:00:00'),(1411,4,5.99,'1900-01-01 00:00:00'),(1412,2,5.99,'1900-01-01 00:00:00'),(1413,4,3.99,'1900-01-01 00:00:00'),(1414,1,7.99,'1900-01-01 00:00:00'),(1415,1,31.99,'1900-01-01 00:00:00'),(1416,1,25.99,'1900-01-01 00:00:00'),(1417,1,9.99,'1900-01-01 00:00:00'),(1418,1,12.99,'1900-01-01 00:00:00'),(1419,0,2.69,'1900-01-01 00:00:00'),(1420,0,1.29,'1900-01-01 00:00:00'),(1421,0,1.25,'1900-01-01 00:00:00'),(1422,0,2.5,'1900-01-01 00:00:00'),(1423,0,1.25,'1900-01-01 00:00:00'),(1424,6,1,'1900-01-01 00:00:00'),(1425,0,3,'1900-01-01 00:00:00'),(1426,1,9.99,'1900-01-01 00:00:00'),(1427,1,6.99,'1900-01-01 00:00:00'),(1428,0,2.5,'1900-01-01 00:00:00'),(1429,0,2.5,'1900-01-01 00:00:00'),(1430,997,2.5,'1900-01-01 00:00:00'),(1431,2,2.99,'1900-01-01 00:00:00'),(1432,0,5.99,'1900-01-01 00:00:00'),(1433,2,2.5,'1900-01-01 00:00:00'),(1434,1,2.5,'1900-01-01 00:00:00'),(1435,3,2.5,'1900-01-01 00:00:00'),(1436,2,2.5,'1900-01-01 00:00:00'),(1437,0,11.99,'1900-01-01 00:00:00'),(1438,0,1.07,'1900-01-01 00:00:00'),(1439,0,43.13,'1900-01-01 00:00:00'),(1440,0,10.25,'1900-01-01 00:00:00'),(1441,0,19.99,'1900-01-01 00:00:00'),(1442,1,31.99,'1900-01-01 00:00:00'),(1443,0,4.25,'1900-01-01 00:00:00'),(1444,1,74.46,'1900-01-01 00:00:00'),(1445,5,25.99,'1900-01-01 00:00:00'),(1446,1,39.84,'1900-01-01 00:00:00'),(1447,1,59.8,'1900-01-01 00:00:00'),(1448,0,3.75,'1900-01-01 00:00:00'),(1449,2,40.86,'1900-01-01 00:00:00'),(1450,0,9,'1900-01-01 00:00:00'),(1451,0,16.75,'1900-01-01 00:00:00'),(1452,6,1.99,'1900-01-01 00:00:00'),(1453,1,32.5,'1900-01-01 00:00:00'),(1454,10,20.95,'1900-01-01 00:00:00'),(1455,12,1.75,'1900-01-01 00:00:00'),(1456,1,56.65,'1900-01-01 00:00:00'),(1457,0,0,'1900-01-01 00:00:00'),(1458,0,35,'1900-01-01 00:00:00'),(1459,7,4.99,'1900-01-01 00:00:00'),(1460,2,35.65,'1900-01-01 00:00:00'),(1461,0,20.99,'1900-01-01 00:00:00'),(1462,1,41.95,'1900-01-01 00:00:00'),(1463,1,47.99,'1900-01-01 00:00:00'),(1464,2,10.99,'1900-01-01 00:00:00'),(1465,9,8.99,'1900-01-01 00:00:00'),(1466,4,15.75,'1900-01-01 00:00:00'),(1467,1,16.36,'1900-01-01 00:00:00'),(1468,1,2.99,'1900-01-01 00:00:00'),(1469,1,46.99,'1900-01-01 00:00:00'),(1470,6,11.99,'1900-01-01 00:00:00'),(1471,0,10.99,'1900-01-01 00:00:00'),(1472,0,15.53,'1900-01-01 00:00:00'),(1473,5,9.99,'1900-01-01 00:00:00'),(1474,0,7.63,'1900-01-01 00:00:00'),(1475,1,10.99,'1900-01-01 00:00:00'),(1476,0,7.75,'1900-01-01 00:00:00'),(1477,4,9.99,'1900-01-01 00:00:00'),(1478,0,1.25,'1900-01-01 00:00:00'),(1479,2,45.09,'1900-01-01 00:00:00'),(1480,0,38,'1900-01-01 00:00:00'),(1481,3,27.45,'1900-01-01 00:00:00'),(1482,0,1.4,'1900-01-01 00:00:00'),(1483,1,1.49,'1900-01-01 00:00:00'),(1484,1,2.99,'1900-01-01 00:00:00'),(1485,1,52.81,'1900-01-01 00:00:00'),(1486,0,30,'1900-01-01 00:00:00'),(1487,11,1.75,'1900-01-01 00:00:00'),(1488,1,30.99,'1900-01-01 00:00:00'),(1489,1,1.99,'1900-01-01 00:00:00'),(1490,0,9,'1900-01-01 00:00:00'),(1491,2,17.53,'1900-01-01 00:00:00'),(1492,1,15.99,'1900-01-01 00:00:00'),(1493,0,12,'1900-01-01 00:00:00'),(1494,2,10.99,'1900-01-01 00:00:00'),(1495,1,15.99,'1900-01-01 00:00:00'),(1496,2,17.53,'1900-01-01 00:00:00'),(1497,2,17.53,'1900-01-01 00:00:00'),(1498,1,17.53,'1900-01-01 00:00:00'),(1499,3,47.99,'1900-01-01 00:00:00'),(1500,0,52,'1900-01-01 00:00:00'),(1501,1,49.99,'1900-01-01 00:00:00'),(1502,2,21.4,'1900-01-01 00:00:00'),(1503,2,21.94,'1900-01-01 00:00:00'),(1504,3,25.99,'1900-01-01 00:00:00'),(1505,0,21.25,'1900-01-01 00:00:00'),(1506,0,15.99,'1900-01-01 00:00:00'),(1507,0,4,'1900-01-01 00:00:00'),(1508,0,27.45,'1900-01-01 00:00:00'),(1509,0,3.75,'1900-01-01 00:00:00'),(1510,0,36.27,'1900-01-01 00:00:00'),(1511,1,44.99,'1900-01-01 00:00:00'),(1512,10,4.99,'1900-01-01 00:00:00'),(1513,2,15.35,'1900-01-01 00:00:00'),(1514,0,28,'1900-01-01 00:00:00'),(1515,0,14.99,'1900-01-01 00:00:00'),(1516,2,18.99,'1900-01-01 00:00:00'),(1517,2,48.24,'1900-01-01 00:00:00'),(1518,2,69.99,'1900-01-01 00:00:00'),(1519,0,6.5,'1900-01-01 00:00:00'),(1520,1,69.99,'1900-01-01 00:00:00'),(1521,0,49.99,'1900-01-01 00:00:00'),(1522,1,199.99,'1900-01-01 00:00:00'),(1523,1,49.99,'1900-01-01 00:00:00'),(1524,0,40.74,'1900-01-01 00:00:00'),(1525,0,54.99,'1900-01-01 00:00:00'),(1526,14,3.5,'1900-01-01 00:00:00'),(1527,0,31.98,'1900-01-01 00:00:00'),(1528,0,14.88,'1900-01-01 00:00:00'),(1529,1,24.485,'1900-01-01 00:00:00'),(1530,0,41.99,'1900-01-01 00:00:00'),(1531,0,40.68,'1900-01-01 00:00:00'),(1532,0,27.25,'1900-01-01 00:00:00'),(1533,1,44.99,'1900-01-01 00:00:00'),(1534,0,1.25,'1900-01-01 00:00:00'),(1535,0,7,'1900-01-01 00:00:00'),(1536,0,25.14,'1900-01-01 00:00:00'),(1537,5,62.99,'1900-01-01 00:00:00'),(1538,2,34.99,'1900-01-01 00:00:00'),(1539,0,17.99,'1900-01-01 00:00:00'),(1540,4,38.8,'1900-01-01 00:00:00'),(1541,20,20,'1900-01-01 00:00:00'),(1542,0,27,'1900-01-01 00:00:00'),(1543,0,1.5,'1900-01-01 00:00:00'),(1544,1,2.99,'1900-01-01 00:00:00'),(1545,2,65.43,'1900-01-01 00:00:00'),(1546,3,40.68,'1900-01-01 00:00:00'),(1547,0,11.25,'1900-01-01 00:00:00'),(1548,0,16.75,'1900-01-01 00:00:00'),(1549,0,15,'1900-01-01 00:00:00'),(1550,0,16,'1900-01-01 00:00:00'),(1551,3,15,'1900-01-01 00:00:00'),(1552,0,15,'1900-01-01 00:00:00'),(1553,0,1.25,'1900-01-01 00:00:00'),(1554,3,14.99,'1900-01-01 00:00:00'),(1555,0,1.99,'1900-01-01 00:00:00'),(1556,0,1.25,'1900-01-01 00:00:00'),(1557,46,1.99,'1900-01-01 00:00:00'),(1558,1,1.75,'1900-01-01 00:00:00'),(1559,1,1.99,'1900-01-01 00:00:00'),(1560,2,89.99,'1900-01-01 00:00:00'),(1561,4,3.25,'1900-01-01 00:00:00'),(1562,6,9,'1900-01-01 00:00:00'),(1563,0,7.63,'1900-01-01 00:00:00'),(1564,0,1.99,'1900-01-01 00:00:00'),(1565,4,1.99,'1900-01-01 00:00:00'),(1566,1,1.69,'1900-01-01 00:00:00'),(1567,2,16.99,'1900-01-01 00:00:00'),(1568,4,40,'1900-01-01 00:00:00'),(1569,2,2.79,'1900-01-01 00:00:00'),(1570,2,8.99,'1900-01-01 00:00:00'),(1571,0,13.99,'1900-01-01 00:00:00'),(1572,2,25.99,'1900-01-01 00:00:00'),(1573,8,13.99,'1900-01-01 00:00:00'),(1574,9,16.75,'1900-01-01 00:00:00'),(1575,7,5.36,'1900-01-01 00:00:00'),(1576,0,8.55,'1900-01-01 00:00:00'),(1577,0,15.99,'1900-01-01 00:00:00'),(1578,0,9.75,'1900-01-01 00:00:00'),(1579,8,0,'1900-01-01 00:00:00'),(1580,1,89.99,'1900-01-01 00:00:00'),(1581,2,14.5,'1900-01-01 00:00:00'),(1583,1,33.93,'1900-01-01 00:00:00'),(1584,1,21.99,'1900-01-01 00:00:00'),(1585,2,47.99,'1900-01-01 00:00:00'),(1586,0,17.64,'1900-01-01 00:00:00'),(1587,7,11.78429,'1900-01-01 00:00:00'),(1588,0,11.25,'1900-01-01 00:00:00'),(1589,2,39.99,'1900-01-01 00:00:00'),(1590,1,9.99,'1900-01-01 00:00:00'),(1591,0,11.99,'1900-01-01 00:00:00'),(1592,12,19.99,'1900-01-01 00:00:00'),(1593,2,25.99,'1900-01-01 00:00:00'),(1594,0,45.46,'1900-01-01 00:00:00'),(1595,2,33.99,'1900-01-01 00:00:00'),(1596,0,37.75,'1900-01-01 00:00:00'),(1597,0,94.75,'1900-01-01 00:00:00'),(1598,1,45.8,'1900-01-01 00:00:00'),(1599,0,7.3,'1900-01-01 00:00:00'),(1600,1,19.99,'1900-01-01 00:00:00'),(1601,2,2.99,'1900-01-01 00:00:00'),(1602,6,10.99,'1900-01-01 00:00:00'),(1603,2,10.99,'1900-01-01 00:00:00'),(1604,0,6.67,'1900-01-01 00:00:00'),(1605,0,1.99,'1900-01-01 00:00:00'),(1606,1,8.99,'1900-01-01 00:00:00'),(1607,15,11.99,'1900-01-01 00:00:00'),(1608,3,9.99,'1900-01-01 00:00:00'),(1609,2,19.99,'1900-01-01 00:00:00'),(1610,9,1.75,'1900-01-01 00:00:00'),(1611,0,16,'1900-01-01 00:00:00'),(1612,2,17.99,'1900-01-01 00:00:00'),(1613,1,1.85,'1900-01-01 00:00:00'),(1614,9,1.85,'1900-01-01 00:00:00'),(1615,6,1.85,'1900-01-01 00:00:00'),(1616,1,12.99,'1900-01-01 00:00:00'),(1617,0,4.99,'1900-01-01 00:00:00'),(1618,0,10.33,'1900-01-01 00:00:00'),(1619,2,13.99,'1900-01-01 00:00:00'),(1620,1,29.99,'1900-01-01 00:00:00'),(1621,0,24.3,'1900-01-01 00:00:00'),(1622,8,15.99,'1900-01-01 00:00:00'),(1623,6,20.99,'1900-01-01 00:00:00'),(1624,0,49.99,'1900-01-01 00:00:00'),(1625,2,62.99,'1900-01-01 00:00:00'),(1626,0,14.99,'1900-01-01 00:00:00'),(1627,8,1.99,'1900-01-01 00:00:00'),(1628,7,14.99,'1900-01-01 00:00:00'),(1629,1,2.79,'1900-01-01 00:00:00'),(1630,1,6.99,'1900-01-01 00:00:00'),(1631,9,2.99,'1900-01-01 00:00:00'),(1632,0,35.65,'1900-01-01 00:00:00'),(1633,0,2,'1900-01-01 00:00:00'),(1634,2,47.28,'1900-01-01 00:00:00'),(1635,0,34.99,'1900-01-01 00:00:00'),(1636,0,22.09,'1900-01-01 00:00:00'),(1637,1,29.99,'1900-01-01 00:00:00'),(1638,1,3.99,'1900-01-01 00:00:00'),(1639,100,4034.693,'1900-01-01 00:00:00'),(1640,1,24.99,'1900-01-01 00:00:00'),(1641,3,1.85,'1900-01-01 00:00:00'),(1642,0,11.5,'1900-01-01 00:00:00'),(1643,50,1.95,'1900-01-01 00:00:00'),(1644,1,11.99,'1900-01-01 00:00:00'),(1645,1,3.99,'1900-01-01 00:00:00'),(1646,0,0,'1900-01-01 00:00:00'),(1647,1,12.99,'1900-01-01 00:00:00'),(1648,1,2.69,'1900-01-01 00:00:00'),(1649,10,13.99,'1900-01-01 00:00:00'),(1650,15,9,'1900-01-01 00:00:00'),(1651,1,30.99,'1900-01-01 00:00:00'),(1652,0,0,'1900-01-01 00:00:00'),(1653,0,69.99,'1900-01-01 00:00:00'),(1654,1,1.99,'1900-01-01 00:00:00'),(1655,1,15.99,'1900-01-01 00:00:00'),(1656,0,11.67,'1900-01-01 00:00:00'),(1657,2,3.99,'1900-01-01 00:00:00'),(1658,2,35.65,'1900-01-01 00:00:00'),(1659,18,3.75,'1900-01-01 00:00:00'),(1660,1,28.3,'1900-01-01 00:00:00'),(1661,1,26.99,'1900-01-01 00:00:00'),(1662,7,21,'1900-01-01 00:00:00'),(1663,5,11.99,'1900-01-01 00:00:00'),(1664,5,12,'1900-01-01 00:00:00'),(1665,0,11.55,'1900-01-01 00:00:00'),(1666,10,16.99,'1900-01-01 00:00:00'),(1667,0,13.99,'1900-01-01 00:00:00'),(1668,4,15.99,'1900-01-01 00:00:00'),(1669,3,16.99,'1900-01-01 00:00:00'),(1670,0,5.99,'1900-01-01 00:00:00'),(1671,0,8,'1900-01-01 00:00:00'),(1672,5,10.99,'1900-01-01 00:00:00'),(1673,7,4.99,'1900-01-01 00:00:00'),(1674,3,13.99,'1900-01-01 00:00:00'),(1675,0,13.99,'1900-01-01 00:00:00'),(1676,0,10.5,'1900-01-01 00:00:00'),(1677,0,18,'1900-01-01 00:00:00'),(1678,0,11,'1900-01-01 00:00:00'),(1679,1,11.99,'1900-01-01 00:00:00'),(1680,2,13.99,'1900-01-01 00:00:00'),(1681,1,14.99,'1900-01-01 00:00:00'),(1682,1,12.99,'1900-01-01 00:00:00'),(1683,7,11.99,'1900-01-01 00:00:00'),(1684,1,13.99,'1900-01-01 00:00:00'),(1685,1,7.99,'1900-01-01 00:00:00'),(1686,1,10.99,'1900-01-01 00:00:00'),(1687,0,18.63,'1900-01-01 00:00:00'),(1688,0,29.99,'1900-01-01 00:00:00'),(1689,0,28.34,'1900-01-01 00:00:00'),(1690,2,17.99,'1900-01-01 00:00:00'),(1691,20,17.5,'1900-01-01 00:00:00'),(1692,2,27.76,'1900-01-01 00:00:00'),(1693,3,1.99,'1900-01-01 00:00:00'),(1694,6,1.99,'1900-01-01 00:00:00'),(1695,2,14.99,'1900-01-01 00:00:00'),(1696,2,16.75,'1900-01-01 00:00:00'),(1697,1,24.09,'1900-01-01 00:00:00'),(1698,12,1.85,'1900-01-01 00:00:00'),(1699,2,15.99,'1900-01-01 00:00:00'),(1700,0,2.99,'1900-01-01 00:00:00'),(1701,0,15.99,'1900-01-01 00:00:00'),(1702,0,13,'1900-01-01 00:00:00'),(1703,1,23.05,'1900-01-01 00:00:00'),(1704,1,45.5,'1900-01-01 00:00:00'),(1705,4,11.99,'1900-01-01 00:00:00'),(1706,0,1.5,'1900-01-01 00:00:00'),(1707,0,1.25,'1900-01-01 00:00:00'),(1708,0,19.99,'1900-01-01 00:00:00'),(1709,0,8,'1900-01-01 00:00:00'),(1710,0,9,'1900-01-01 00:00:00'),(1711,0,5,'1900-01-01 00:00:00'),(1712,7,13.99,'1900-01-01 00:00:00'),(1713,0,14.99,'1900-01-01 00:00:00'),(1714,10,5.75,'1900-01-01 00:00:00'),(1715,1,5.75,'1900-01-01 00:00:00'),(1716,0,1.45,'1900-01-01 00:00:00'),(1717,3,68.99,'1900-01-01 00:00:00'),(1718,1,18.99,'1900-01-01 00:00:00'),(1719,21,1.99,'1900-01-01 00:00:00'),(1720,11,1.99,'1900-01-01 00:00:00'),(1721,0,8.75,'1900-01-01 00:00:00'),(1722,1,9.99,'1900-01-01 00:00:00'),(1723,1,1.99,'1900-01-01 00:00:00'),(1724,1,25.02,'1900-01-01 00:00:00'),(1725,2,24.1,'1900-01-01 00:00:00'),(1726,0,24.81,'1900-01-01 00:00:00'),(1727,0,1.4,'1900-01-01 00:00:00'),(1728,1,4,'1900-01-01 00:00:00'),(1729,0,24.1,'1900-01-01 00:00:00'),(1730,12,1.99,'1900-01-01 00:00:00'),(1731,0,29.35,'1900-01-01 00:00:00'),(1732,1,38.99,'1900-01-01 00:00:00'),(1733,0,6.25,'1900-01-01 00:00:00'),(1734,0,48.99,'1900-01-01 00:00:00'),(1735,1,34.25,'1900-01-01 00:00:00'),(1736,0,15.68,'1900-01-01 00:00:00'),(1737,0,15.4,'1900-01-01 00:00:00'),(1738,0,7.99,'1900-01-01 00:00:00'),(1739,0,1.4,'1900-01-01 00:00:00'),(1740,0,10.13,'1900-01-01 00:00:00'),(1741,0,52.74,'1900-01-01 00:00:00'),(1742,1,33.55,'1900-01-01 00:00:00'),(1743,0,76.74,'1900-01-01 00:00:00'),(1744,0,62.5,'1900-01-01 00:00:00'),(1745,1,11.99,'1900-01-01 00:00:00'),(1746,0,13.5,'1900-01-01 00:00:00'),(1747,7,18.99,'1900-01-01 00:00:00'),(1748,0,12.75,'1900-01-01 00:00:00'),(1749,9,1.85,'1900-01-01 00:00:00'),(1750,0,68.99,'1900-01-01 00:00:00'),(1751,49,1.85,'1900-01-01 00:00:00'),(1752,2,14.99,'1900-01-01 00:00:00'),(1753,1,11.29,'1900-01-01 00:00:00'),(1754,1,10.99,'1900-01-01 00:00:00'),(1755,8,19.99,'1900-01-01 00:00:00'),(1756,0,1.4,'1900-01-01 00:00:00'),(1757,0,11.5,'1900-01-01 00:00:00'),(1758,1,15.99,'1900-01-01 00:00:00'),(1759,0,11.5,'1900-01-01 00:00:00'),(1760,4,39.99,'1900-01-01 00:00:00'),(1761,2,1.75,'1900-01-01 00:00:00'),(1762,5,1.99,'1900-01-01 00:00:00'),(1763,1,1.75,'1900-01-01 00:00:00'),(1764,0,1.5,'1900-01-01 00:00:00'),(1765,1,28.24,'1900-01-01 00:00:00'),(1766,4,8.05,'1900-01-01 00:00:00'),(1767,13,11.99,'1900-01-01 00:00:00'),(1768,11,11.99,'1900-01-01 00:00:00'),(1769,1,11.5,'1900-01-01 00:00:00'),(1770,11,7.5,'1900-01-01 00:00:00'),(1771,8,10.99,'1900-01-01 00:00:00'),(1772,1,15.5,'1900-01-01 00:00:00'),(1773,7,39.99,'1900-01-01 00:00:00'),(1774,1,13.75,'1900-01-01 00:00:00'),(1775,1,14.99,'1900-01-01 00:00:00'),(1776,8,22,'1900-01-01 00:00:00'),(1777,0,17,'1900-01-01 00:00:00'),(1778,11,12.5,'1900-01-01 00:00:00'),(1779,3,11.99,'1900-01-01 00:00:00'),(1780,0,1.99,'1900-01-01 00:00:00'),(1781,1,10.75,'1900-01-01 00:00:00'),(1782,2,7.75,'1900-01-01 00:00:00'),(1783,0,1.99,'1900-01-01 00:00:00'),(1784,0,7.72,'1900-01-01 00:00:00'),(1785,3,7.75,'1900-01-01 00:00:00'),(1786,7,7.99,'1900-01-01 00:00:00'),(1787,1,10.99,'1900-01-01 00:00:00'),(1788,1,15.99,'1900-01-01 00:00:00'),(1789,2,15.99,'1900-01-01 00:00:00'),(1790,0,15.99,'1900-01-01 00:00:00'),(1791,1,21.99,'1900-01-01 00:00:00'),(1792,0,24.09,'1900-01-01 00:00:00'),(1793,1,1.75,'1900-01-01 00:00:00'),(1794,1,9.5,'1900-01-01 00:00:00'),(1795,0,8,'1900-01-01 00:00:00'),(1796,0,3.53,'1900-01-01 00:00:00'),(1797,2,1.99,'1900-01-01 00:00:00'),(1798,4,12.99,'1900-01-01 00:00:00'),(1799,1,52,'1900-01-01 00:00:00'),(1800,1,10.99,'1900-01-01 00:00:00'),(1801,0,11.99,'1900-01-01 00:00:00'),(1802,3,99.99,'1900-01-01 00:00:00'),(1803,1,26.6,'1900-01-01 00:00:00'),(1804,10,8.25,'1900-01-01 00:00:00'),(1805,1,32.49,'1900-01-01 00:00:00'),(1806,4,2.5,'1900-01-01 00:00:00'),(1807,1,31.44,'1900-01-01 00:00:00'),(1808,0,17.79,'1900-01-01 00:00:00'),(1809,0,23.04,'1900-01-01 00:00:00'),(1810,4,1.85,'1900-01-01 00:00:00'),(1811,1,28.99,'1900-01-01 00:00:00'),(1812,6,10.5,'1900-01-01 00:00:00'),(1813,0,18.66,'1900-01-01 00:00:00'),(1814,1,49.99,'1900-01-01 00:00:00'),(1815,2,9.99,'1900-01-01 00:00:00'),(1816,0,11,'1900-01-01 00:00:00'),(1817,0,7,'1900-01-01 00:00:00'),(1818,4,62.99,'1900-01-01 00:00:00'),(1819,2,8.99,'1900-01-01 00:00:00'),(1820,8,14.99,'1900-01-01 00:00:00'),(1821,2,8.5,'1900-01-01 00:00:00'),(1822,1,2.99,'1900-01-01 00:00:00'),(1823,1,3.99,'1900-01-01 00:00:00'),(1824,1,10.99,'1900-01-01 00:00:00'),(1825,1,3,'1900-01-01 00:00:00'),(1826,1,22.99,'1900-01-01 00:00:00'),(1827,1,22.25,'1900-01-01 00:00:00'),(1828,0,22.99,'1900-01-01 00:00:00'),(1829,1,14.5,'1900-01-01 00:00:00'),(1830,0,9.99,'1900-01-01 00:00:00'),(1831,4,14.75,'1900-01-01 00:00:00'),(1832,0,13.99,'1900-01-01 00:00:00'),(1833,1,15.75,'1900-01-01 00:00:00'),(1834,5,14.99,'1900-01-01 00:00:00'),(1835,0,12.91,'1900-01-01 00:00:00'),(1836,1,17.25,'1900-01-01 00:00:00'),(1837,0,8.44,'1900-01-01 00:00:00'),(1838,6,2.49,'1900-01-01 00:00:00'),(1839,8,25.99,'1900-01-01 00:00:00'),(1840,5,38.99,'1900-01-01 00:00:00'),(1841,5,13.99,'1900-01-01 00:00:00'),(1842,0,9.24,'1900-01-01 00:00:00'),(1843,0,12,'1900-01-01 00:00:00'),(1844,1,29.99,'1900-01-01 00:00:00'),(1845,4,12.99,'1900-01-01 00:00:00'),(1846,0,8,'1900-01-01 00:00:00'),(1847,0,29.99,'1900-01-01 00:00:00'),(1848,8,10.5,'1900-01-01 00:00:00'),(1849,15,10,'1900-01-01 00:00:00'),(1850,13,15,'1900-01-01 00:00:00'),(1851,7,49.99,'1900-01-01 00:00:00'),(1852,0,0,'1900-01-01 00:00:00'),(1853,10,23.99,'1900-01-01 00:00:00'),(1854,6,18.99,'1900-01-01 00:00:00'),(1855,3,21.99,'1900-01-01 00:00:00'),(1856,1,56.99,'1900-01-01 00:00:00'),(1857,6,27.99,'1900-01-01 00:00:00'),(1858,1,89.99,'1900-01-01 00:00:00'),(1859,6,19.99,'1900-01-01 00:00:00'),(1860,5,18.99,'1900-01-01 00:00:00'),(1861,7,24.99,'1900-01-01 00:00:00'),(1862,7,18.99,'1900-01-01 00:00:00'),(1863,8,11.99,'1900-01-01 00:00:00'),(1864,6,15.99,'1900-01-01 00:00:00'),(1865,4,16.99,'1900-01-01 00:00:00'),(1866,12,23.99,'1900-01-01 00:00:00'),(1867,4,13.25,'1900-01-01 00:00:00'),(1868,2,12.99,'1900-01-01 00:00:00'),(1869,1,11.99,'1900-01-01 00:00:00'),(1870,1,17.99,'1900-01-01 00:00:00'),(1871,11,25.68,'1900-01-01 00:00:00'),(1872,2,36.91,'1900-01-01 00:00:00'),(1873,1,26.99,'1900-01-01 00:00:00'),(1874,1,53.99,'1900-01-01 00:00:00'),(1875,2,7.99,'1900-01-01 00:00:00'),(1876,1,12.99,'1900-01-01 00:00:00'),(1877,2,2.99,'1900-01-01 00:00:00'),(1878,1,180,'1900-01-01 00:00:00'),(1879,7,79.99,'1900-01-01 00:00:00'),(1880,1,124.99,'1900-01-01 00:00:00'),(1881,1,115,'1900-01-01 00:00:00'),(1882,2,49.99,'1900-01-01 00:00:00'),(1883,2,49.99,'1900-01-01 00:00:00'),(1884,1,72.99,'1900-01-01 00:00:00'),(1885,1,19.99,'1900-01-01 00:00:00'),(1886,4,19.99,'1900-01-01 00:00:00'),(1887,0,8.49,'1900-01-01 00:00:00'),(1888,1,174,'1900-01-01 00:00:00'),(1890,11,2.69,'1900-01-01 00:00:00'),(1891,2,2.69,'1900-01-01 00:00:00'),(1892,1,13.99,'1900-01-01 00:00:00'),(1893,12,0,'1900-01-01 00:00:00'),(1894,6,4.99,'1900-01-01 00:00:00'),(1895,0,12,'1900-01-01 00:00:00'),(1896,3,24.1,'1900-01-01 00:00:00'),(1897,1,4.99,'1900-01-01 00:00:00'),(1898,1,6.99,'1900-01-01 00:00:00'),(1899,1,12.99,'1900-01-01 00:00:00'),(1900,0,11,'1900-01-01 00:00:00'),(1901,2,12.99,'1900-01-01 00:00:00'),(1902,0,10,'1900-01-01 00:00:00'),(1903,0,10,'1900-01-01 00:00:00'),(1904,0,14.99,'1900-01-01 00:00:00'),(1905,0,9,'1900-01-01 00:00:00'),(1906,3,13.99,'1900-01-01 00:00:00'),(1907,0,37.75,'1900-01-01 00:00:00'),(1908,0,1.99,'1900-01-01 00:00:00'),(1909,1,12.99,'1900-01-01 00:00:00'),(1910,0,6,'1900-01-01 00:00:00'),(1911,0,49.99,'1900-01-01 00:00:00'),(1912,0,10,'1900-01-01 00:00:00'),(1913,1,9.99,'1900-01-01 00:00:00'),(1914,3,9.99,'1900-01-01 00:00:00'),(1915,0,7.5,'1900-01-01 00:00:00'),(1916,1,12.99,'1900-01-01 00:00:00'),(1917,0,9.99,'1900-01-01 00:00:00'),(1918,5,48.25,'1900-01-01 00:00:00'),(1919,0,10.99,'1900-01-01 00:00:00'),(1920,0,1.99,'1900-01-01 00:00:00'),(1921,0,16.75,'1900-01-01 00:00:00'),(1922,5,16.75,'1900-01-01 00:00:00'),(1923,0,45,'1900-01-01 00:00:00'),(1924,2,19.99,'1900-01-01 00:00:00'),(1925,25,15.99,'1900-01-01 00:00:00'),(1926,1,15.99,'1900-01-01 00:00:00'),(1927,1,56.99,'1900-01-01 00:00:00'),(1928,0,9.5,'1900-01-01 00:00:00'),(1929,1,99.99,'1900-01-01 00:00:00'),(1930,1,11.99,'1900-01-01 00:00:00'),(1931,0,6.99,'1900-01-01 00:00:00'),(1933,2,9.99,'1900-01-01 00:00:00'),(1934,1,5.99,'1900-01-01 00:00:00'),(1935,5,5.99,'1900-01-01 00:00:00'),(1936,2,6.99,'1900-01-01 00:00:00'),(1937,1,6.99,'1900-01-01 00:00:00'),(1938,4,13.99,'1900-01-01 00:00:00'),(1939,2,20.99,'1900-01-01 00:00:00'),(1940,0,3.99,'1900-01-01 00:00:00'),(1941,0,3.99,'1900-01-01 00:00:00'),(1942,2,3.99,'1900-01-01 00:00:00'),(1943,0,3.75,'1900-01-01 00:00:00'),(1944,0,3.99,'1900-01-01 00:00:00'),(1945,0,3.75,'1900-01-01 00:00:00'),(1946,0,2,'1900-01-01 00:00:00'),(1947,0,2,'1900-01-01 00:00:00'),(1948,0,2,'1900-01-01 00:00:00'),(1949,0,2,'1900-01-01 00:00:00'),(1950,0,2,'1900-01-01 00:00:00'),(1951,0,2,'1900-01-01 00:00:00'),(1952,0,2,'1900-01-01 00:00:00'),(1953,0,2,'1900-01-01 00:00:00'),(1954,0,2,'1900-01-01 00:00:00'),(1955,0,2,'1900-01-01 00:00:00'),(1956,0,2.99,'1900-01-01 00:00:00'),(1957,2,8.99,'1900-01-01 00:00:00'),(1958,3,6.99,'1900-01-01 00:00:00'),(1959,1,8.99,'1900-01-01 00:00:00'),(1960,1,7.99,'1900-01-01 00:00:00'),(1961,1,9.99,'1900-01-01 00:00:00'),(1962,0,3.99,'1900-01-01 00:00:00'),(1963,3,3.99,'1900-01-01 00:00:00'),(1964,0,1.89,'1900-01-01 00:00:00'),(1965,1,4.5,'1900-01-01 00:00:00'),(1966,1,7,'1900-01-01 00:00:00'),(1967,0,6.99,'1900-01-01 00:00:00'),(1968,1,2.59,'1900-01-01 00:00:00'),(1969,2,2.49,'1900-01-01 00:00:00'),(1970,5,2.59,'1900-01-01 00:00:00'),(1971,0,1.75,'1900-01-01 00:00:00'),(1972,0,1.75,'1900-01-01 00:00:00'),(1973,0,1.75,'1900-01-01 00:00:00'),(1974,0,1.75,'1900-01-01 00:00:00'),(1975,0,1.75,'1900-01-01 00:00:00'),(1976,0,1.75,'1900-01-01 00:00:00'),(1977,0,3,'1900-01-01 00:00:00'),(1978,1,3.99,'1900-01-01 00:00:00'),(1979,0,1.99,'1900-01-01 00:00:00'),(1980,0,6,'1900-01-01 00:00:00'),(1981,0,1.75,'1900-01-01 00:00:00'),(1982,1,4.99,'1900-01-01 00:00:00'),(1983,0,3.59,'1900-01-01 00:00:00'),(1984,1,4.99,'1900-01-01 00:00:00'),(1985,1,2.99,'1900-01-01 00:00:00'),(1986,1,6.99,'1900-01-01 00:00:00'),(1987,0,15,'1900-01-01 00:00:00'),(1988,0,10,'1900-01-01 00:00:00'),(1989,0,10,'1900-01-01 00:00:00'),(1990,7,22.99,'1900-01-01 00:00:00'),(1991,0,0.03,'1900-01-01 00:00:00'),(1992,1,67.99,'1900-01-01 00:00:00'),(1993,0,5,'1900-01-01 00:00:00'),(1994,0,9,'1900-01-01 00:00:00'),(1995,1,13.99,'1900-01-01 00:00:00'),(1996,8,12.99,'1900-01-01 00:00:00'),(1997,0,8.25,'1900-01-01 00:00:00'),(1998,7,10,'1900-01-01 00:00:00'),(1999,10,9.35,'1900-01-01 00:00:00'),(2000,10,12.99,'1900-01-01 00:00:00'),(2002,6,14.99,'1900-01-01 00:00:00'),(2003,1,4.99,'1900-01-01 00:00:00'),(2004,9,18.99,'1900-01-01 00:00:00'),(2005,2,19.99,'1900-01-01 00:00:00'),(2006,1,14.99,'1900-01-01 00:00:00'),(2007,1,12.99,'1900-01-01 00:00:00'),(2008,0,12.99,'1900-01-01 00:00:00'),(2009,3,11.99,'1900-01-01 00:00:00'),(2010,0,14.99,'1900-01-01 00:00:00'),(2011,0,10.99,'1900-01-01 00:00:00'),(2012,8,49.99,'1900-01-01 00:00:00'),(2013,1,11.99,'1900-01-01 00:00:00'),(2014,1,11.99,'1900-01-01 00:00:00'),(2015,0,9,'1900-01-01 00:00:00'),(2016,1,9.99,'1900-01-01 00:00:00'),(2017,3,3.75,'1900-01-01 00:00:00'),(2018,1,1.99,'1900-01-01 00:00:00'),(2019,0,1.5,'1900-01-01 00:00:00'),(2020,3,5.99,'1900-01-01 00:00:00'),(2021,3,16.99,'1900-01-01 00:00:00'),(2022,1,2.99,'1900-01-01 00:00:00'),(2023,1,11.99,'1900-01-01 00:00:00'),(2024,5,5.5,'1900-01-01 00:00:00'),(2025,0,26.56,'1900-01-01 00:00:00'),(2026,1,39.88,'1900-01-01 00:00:00'),(2027,0,8.63,'1900-01-01 00:00:00'),(2028,0,2.5,'1900-01-01 00:00:00'),(2029,1,34.54,'1900-01-01 00:00:00'),(2030,1,17.99,'1900-01-01 00:00:00'),(2031,1,9.95,'1900-01-01 00:00:00'),(2032,6,10.99,'1900-01-01 00:00:00'),(2033,1,1,'1900-01-01 00:00:00'),(2034,1,14.99,'1900-01-01 00:00:00'),(2035,2,9.99,'1900-01-01 00:00:00'),(2036,2,9.99,'1900-01-01 00:00:00'),(2037,1,18.99,'1900-01-01 00:00:00'),(2038,11,19.5,'1900-01-01 00:00:00'),(2039,1,1.99,'1900-01-01 00:00:00'),(2040,3,1.99,'1900-01-01 00:00:00'),(2041,0,14,'1900-01-01 00:00:00'),(2042,0,16.8,'1900-01-01 00:00:00'),(2043,0,16.8,'1900-01-01 00:00:00'),(2044,0,1.5,'1900-01-01 00:00:00'),(2045,1,1.99,'1900-01-01 00:00:00'),(2046,1,1.99,'1900-01-01 00:00:00'),(2047,0,1.99,'1900-01-01 00:00:00'),(2048,1,1.99,'1900-01-01 00:00:00'),(2049,0,4.99,'1900-01-01 00:00:00'),(2050,3,2.99,'1900-01-01 00:00:00'),(2051,1,2.99,'1900-01-01 00:00:00'),(2052,16,8.99,'1900-01-01 00:00:00'),(2053,2,3.99,'1900-01-01 00:00:00'),(2054,4,2.99,'1900-01-01 00:00:00'),(2055,2,3.99,'1900-01-01 00:00:00'),(2056,0,2.49,'1900-01-01 00:00:00'),(2057,6,2.49,'1900-01-01 00:00:00'),(2058,2,2.99,'1900-01-01 00:00:00'),(2059,5,3.99,'1900-01-01 00:00:00'),(2060,1,1.99,'1900-01-01 00:00:00'),(2061,1,2.99,'1900-01-01 00:00:00'),(2062,1,2.99,'1900-01-01 00:00:00'),(2063,1,2.99,'1900-01-01 00:00:00'),(2064,1,2.99,'1900-01-01 00:00:00'),(2065,1,2.99,'1900-01-01 00:00:00'),(2066,1,2.99,'1900-01-01 00:00:00'),(2067,10,3.99,'1900-01-01 00:00:00'),(2068,0,1.5,'1900-01-01 00:00:00'),(2069,0,1.5,'1900-01-01 00:00:00'),(2070,0,1.5,'1900-01-01 00:00:00'),(2071,1,2.99,'1900-01-01 00:00:00'),(2072,0,1.5,'1900-01-01 00:00:00'),(2073,0,1.5,'1900-01-01 00:00:00'),(2074,1,4.99,'1900-01-01 00:00:00'),(2075,0,1.25,'1900-01-01 00:00:00'),(2076,1,1.99,'1900-01-01 00:00:00'),(2077,1,2.99,'1900-01-01 00:00:00'),(2078,0,1.5,'1900-01-01 00:00:00'),(2079,0,1.5,'1900-01-01 00:00:00'),(2080,1,2.99,'1900-01-01 00:00:00'),(2081,0,1.5,'1900-01-01 00:00:00'),(2082,2,2.99,'1900-01-01 00:00:00'),(2083,0,1.5,'1900-01-01 00:00:00'),(2084,0,1.5,'1900-01-01 00:00:00'),(2085,1,2.99,'1900-01-01 00:00:00'),(2086,0,1.5,'1900-01-01 00:00:00'),(2087,4,3.99,'1900-01-01 00:00:00'),(2088,2,3.99,'1900-01-01 00:00:00'),(2089,0,1.5,'1900-01-01 00:00:00'),(2090,0,1.5,'1900-01-01 00:00:00'),(2091,0,2.99,'1900-01-01 00:00:00'),(2092,1,2.99,'1900-01-01 00:00:00'),(2093,1,2.99,'1900-01-01 00:00:00'),(2094,1,2.89,'1900-01-01 00:00:00'),(2095,1,2.99,'1900-01-01 00:00:00'),(2096,0,1.25,'1900-01-01 00:00:00'),(2097,2,6.99,'1900-01-01 00:00:00'),(2098,1,3.99,'1900-01-01 00:00:00'),(2099,0,10,'1900-01-01 00:00:00'),(2100,0,9.75,'1900-01-01 00:00:00'),(2101,0,10,'1900-01-01 00:00:00'),(2102,1,14.75,'1900-01-01 00:00:00'),(2103,2,15.99,'1900-01-01 00:00:00'),(2104,1,9.99,'1900-01-01 00:00:00'),(2105,0,7,'1900-01-01 00:00:00'),(2106,0,9,'1900-01-01 00:00:00'),(2107,0,2.56,'1900-01-01 00:00:00'),(2108,1,49.96,'1900-01-01 00:00:00'),(2109,6,18.99,'1900-01-01 00:00:00'),(2110,6,29.99,'1900-01-01 00:00:00'),(2111,1,16.99,'1900-01-01 00:00:00'),(2112,0,1.5,'1900-01-01 00:00:00'),(2113,0,1.5,'1900-01-01 00:00:00'),(2114,0,10,'1900-01-01 00:00:00'),(2115,0,20,'1900-01-01 00:00:00'),(2116,0,3.37,'1900-01-01 00:00:00'),(2117,2,12.99,'1900-01-01 00:00:00'),(2118,0,9.5,'1900-01-01 00:00:00'),(2119,4,14.99,'1900-01-01 00:00:00'),(2120,1,3.99,'1900-01-01 00:00:00'),(2121,1,2.99,'1900-01-01 00:00:00'),(2122,1,10.99,'1900-01-01 00:00:00'),(2123,1,13.99,'1900-01-01 00:00:00'),(2124,1,19.99,'1900-01-01 00:00:00'),(2125,1,14.99,'1900-01-01 00:00:00'),(2126,0,13.5,'1900-01-01 00:00:00'),(2127,0,11.99,'1900-01-01 00:00:00'),(2128,4,44.99,'1900-01-01 00:00:00'),(2129,3,53.99,'1900-01-01 00:00:00'),(2130,3,36.99,'1900-01-01 00:00:00'),(2131,1,62.99,'1900-01-01 00:00:00'),(2132,8,11.99,'1900-01-01 00:00:00'),(2133,1,15.99,'1900-01-01 00:00:00'),(2134,1,14.99,'1900-01-01 00:00:00'),(2135,1,11.99,'1900-01-01 00:00:00'),(2136,1,3.99,'1900-01-01 00:00:00'),(2137,0,8,'1900-01-01 00:00:00'),(2138,2,20.99,'1900-01-01 00:00:00'),(2139,0,16.8,'1900-01-01 00:00:00'),(2140,5,35.99,'1900-01-01 00:00:00'),(2141,1,44.99,'1900-01-01 00:00:00'),(2142,8,1.79,'1900-01-01 00:00:00'),(2143,1,37.99,'1900-01-01 00:00:00'),(2144,3,18.99,'1900-01-01 00:00:00'),(2145,1,13.99,'1900-01-01 00:00:00'),(2146,2,24.99,'1900-01-01 00:00:00'),(2147,1,23.99,'1900-01-01 00:00:00'),(2148,1,1.99,'1900-01-01 00:00:00'),(2149,2,10.25,'1900-01-01 00:00:00'),(2150,3,19.99,'1900-01-01 00:00:00'),(2151,1,12.99,'1900-01-01 00:00:00'),(2152,4,20.99,'1900-01-01 00:00:00'),(2153,0,12,'1900-01-01 00:00:00'),(2154,1,11.55,'1900-01-01 00:00:00'),(2155,1,79.99,'1900-01-01 00:00:00'),(2156,1,6.99,'1900-01-01 00:00:00'),(2157,1,5.99,'1900-01-01 00:00:00'),(2158,0,6,'1900-01-01 00:00:00'),(2159,4,8.99,'1900-01-01 00:00:00'),(2160,1,7.99,'1900-01-01 00:00:00'),(2161,1,4.99,'1900-01-01 00:00:00'),(2162,5,26.99,'1900-01-01 00:00:00'),(2163,0,21.99,'1900-01-01 00:00:00'),(2164,7,17.99,'1900-01-01 00:00:00'),(2165,0,11.99,'1900-01-01 00:00:00'),(2166,9,13.99,'1900-01-01 00:00:00'),(2167,4,5.99,'1900-01-01 00:00:00'),(2168,1,19.99,'1900-01-01 00:00:00'),(2169,10,2.89,'1900-01-01 00:00:00'),(2170,3,20.99,'1900-01-01 00:00:00'),(2171,1,42.99,'1900-01-01 00:00:00'),(2172,1,59.99,'1900-01-01 00:00:00'),(2173,1,31.99,'1900-01-01 00:00:00'),(2174,0,1.75,'1900-01-01 00:00:00'),(2175,0,1.25,'1900-01-01 00:00:00'),(2176,0,20.99,'1900-01-01 00:00:00'),(2177,1,26.99,'1900-01-01 00:00:00'),(2178,0,23.05,'1900-01-01 00:00:00'),(2179,1,42,'1900-01-01 00:00:00'),(2180,1,30.99,'1900-01-01 00:00:00'),(2181,1,31.45,'1900-01-01 00:00:00'),(2182,1,20.99,'1900-01-01 00:00:00'),(2183,4,15.99,'1900-01-01 00:00:00'),(2184,1,57.7,'1900-01-01 00:00:00'),(2185,0,5,'1900-01-01 00:00:00'),(2186,0,15.38,'1900-01-01 00:00:00'),(2187,0,1.25,'1900-01-01 00:00:00'),(2188,0,8.25,'1900-01-01 00:00:00'),(2189,1,8.99,'1900-01-01 00:00:00'),(2190,0,7.25,'1900-01-01 00:00:00'),(2191,1,36.99,'1900-01-01 00:00:00'),(2192,0,12.99,'1900-01-01 00:00:00'),(2193,2,10.99,'1900-01-01 00:00:00'),(2194,1,10.99,'1900-01-01 00:00:00'),(2195,6,8.99,'1900-01-01 00:00:00'),(2196,4,10.99,'1900-01-01 00:00:00'),(2197,0,9,'1900-01-01 00:00:00'),(2198,0,1.99,'1900-01-01 00:00:00'),(2199,3,10.99,'1900-01-01 00:00:00'),(2200,3,10.99,'1900-01-01 00:00:00'),(2201,9,15.99,'1900-01-01 00:00:00'),(2202,997,14.99,'1900-01-01 00:00:00'),(2203,1,49.99,'1900-01-01 00:00:00'),(2204,4,25.99,'1900-01-01 00:00:00'),(2205,1,20.99,'1900-01-01 00:00:00'),(2206,4,21.99,'1900-01-01 00:00:00'),(2207,2,7.99,'1900-01-01 00:00:00'),(2208,0,12,'1900-01-01 00:00:00'),(2209,0,2.99,'1900-01-01 00:00:00'),(2210,7,10.99,'1900-01-01 00:00:00'),(2211,4,6.99,'1900-01-01 00:00:00'),(2212,1,4.99,'1900-01-01 00:00:00'),(2213,1,4.99,'1900-01-01 00:00:00'),(2214,10,10.99,'1900-01-01 00:00:00'),(2215,5,7.99,'1900-01-01 00:00:00'),(2216,1,5.99,'1900-01-01 00:00:00'),(2217,2,4.75,'1900-01-01 00:00:00'),(2218,1,10.99,'1900-01-01 00:00:00'),(2219,0,9.75,'1900-01-01 00:00:00'),(2220,1,35.99,'1900-01-01 00:00:00'),(2221,4,16.99,'1900-01-01 00:00:00'),(2222,3,39.99,'1900-01-01 00:00:00'),(2223,3,2.99,'1900-01-01 00:00:00'),(2224,1,1.99,'1900-01-01 00:00:00'),(2225,1,10.99,'1900-01-01 00:00:00'),(2226,2,15.99,'1900-01-01 00:00:00'),(2227,1,3.99,'1900-01-01 00:00:00'),(2228,2,14.99,'1900-01-01 00:00:00'),(2229,0,55.99,'1900-01-01 00:00:00'),(2230,1,19.99,'1900-01-01 00:00:00'),(2231,1,5.99,'1900-01-01 00:00:00'),(2232,9,14.99,'1900-01-01 00:00:00'),(2233,0,13.99,'1900-01-01 00:00:00'),(2234,1,9.99,'1900-01-01 00:00:00'),(2235,0,17.99,'1900-01-01 00:00:00'),(2236,0,13.5,'1900-01-01 00:00:00'),(2237,1,7.99,'1900-01-01 00:00:00'),(2238,0,38,'1900-01-01 00:00:00'),(2239,0,49.99,'1900-01-01 00:00:00'),(2240,1,52.75,'1900-01-01 00:00:00'),(2241,1,48.99,'1900-01-01 00:00:00'),(2242,0,9.99,'1900-01-01 00:00:00'),(2243,6,7.5,'1900-01-01 00:00:00'),(2244,0,11.99,'1900-01-01 00:00:00'),(2245,1,12.99,'1900-01-01 00:00:00'),(2246,1,12.99,'1900-01-01 00:00:00'),(2247,0,10.99,'1900-01-01 00:00:00'),(2248,1,10.5,'1900-01-01 00:00:00'),(2249,3,0.35,'1900-01-01 00:00:00'),(2250,1,0.35,'1900-01-01 00:00:00'),(2251,1,3.99,'1900-01-01 00:00:00'),(2252,2,12.75,'1900-01-01 00:00:00'),(2253,1,21.99,'1900-01-01 00:00:00'),(2254,1,19.99,'1900-01-01 00:00:00'),(2255,4,11.99,'1900-01-01 00:00:00'),(2256,1,1.99,'1900-01-01 00:00:00'),(2257,2,29.75,'1900-01-01 00:00:00'),(2258,3,6.99,'1900-01-01 00:00:00'),(2259,10,12.99,'1900-01-01 00:00:00'),(2260,5,12.99,'1900-01-01 00:00:00'),(2261,4,12.99,'1900-01-01 00:00:00'),(2262,0,20.99,'1900-01-01 00:00:00'),(2263,3,17.99,'1900-01-01 00:00:00'),(2264,2,20.99,'1900-01-01 00:00:00'),(2265,8,35.75,'1900-01-01 00:00:00'),(2266,8,14.99,'1900-01-01 00:00:00'),(2267,1,49.99,'1900-01-01 00:00:00'),(2268,1,5.99,'1900-01-01 00:00:00'),(2269,1,15.99,'1900-01-01 00:00:00'),(2270,0,15.99,'1900-01-01 00:00:00'),(2271,10,15.75,'1900-01-01 00:00:00'),(2272,2,12.99,'1900-01-01 00:00:00'),(2273,1,14.99,'1900-01-01 00:00:00'),(2274,1,21.99,'1900-01-01 00:00:00'),(2275,2,10.5,'1900-01-01 00:00:00'),(2276,1,42,'1900-01-01 00:00:00'),(2277,0,10.5,'1900-01-01 00:00:00'),(2278,1,10.99,'1900-01-01 00:00:00'),(2279,1,1.99,'1900-01-01 00:00:00'),(2280,2,10.99,'1900-01-01 00:00:00'),(2281,1,14.99,'1900-01-01 00:00:00'),(2282,9,3.75,'1900-01-01 00:00:00'),(2283,2,3.99,'1900-01-01 00:00:00'),(2284,2,14.99,'1900-01-01 00:00:00'),(2285,3,9.99,'1900-01-01 00:00:00'),(2286,0,2,'1900-01-01 00:00:00'),(2287,0,9.99,'1900-01-01 00:00:00'),(2288,5,23.99,'1900-01-01 00:00:00'),(2289,2,13.99,'1900-01-01 00:00:00'),(2290,2,10.99,'1900-01-01 00:00:00'),(2291,0,10.99,'1900-01-01 00:00:00'),(2292,3,13.99,'1900-01-01 00:00:00'),(2293,0,12.99,'1900-01-01 00:00:00'),(2294,15,2,'1900-01-01 00:00:00'),(2295,12,2.99,'1900-01-01 00:00:00'),(2296,11,11.99,'1900-01-01 00:00:00'),(2297,1,38.99,'1900-01-01 00:00:00'),(2298,0,9,'1900-01-01 00:00:00'),(2299,0,9.42,'1900-01-01 00:00:00'),(2300,1,2.99,'1900-01-01 00:00:00'),(2301,0,35,'1900-01-01 00:00:00'),(2302,6,9,'1900-01-01 00:00:00'),(2303,1,11.99,'1900-01-01 00:00:00'),(2304,1,12.99,'1900-01-01 00:00:00'),(2305,3,16.75,'1900-01-01 00:00:00'),(2306,2,15.99,'1900-01-01 00:00:00'),(2307,2,13.99,'1900-01-01 00:00:00'),(2308,1,9.99,'1900-01-01 00:00:00'),(2309,1,16.99,'1900-01-01 00:00:00'),(2310,4,19.99,'1900-01-01 00:00:00'),(2311,1,18.99,'1900-01-01 00:00:00'),(2312,1,12.99,'1900-01-01 00:00:00'),(2313,1,1.75,'1900-01-01 00:00:00'),(2314,2,79.99,'1900-01-01 00:00:00'),(2315,0,2.99,'1900-01-01 00:00:00'),(2316,1,27.99,'1900-01-01 00:00:00'),(2317,1,3.99,'1900-01-01 00:00:00'),(2318,1,3.99,'1900-01-01 00:00:00'),(2319,1,32.99,'1900-01-01 00:00:00'),(2320,0,15,'1900-01-01 00:00:00'),(2321,2,10.99,'1900-01-01 00:00:00'),(2322,6,13.99,'1900-01-01 00:00:00'),(2323,3,24.99,'1900-01-01 00:00:00'),(2324,0,14.5,'1900-01-01 00:00:00'),(2325,5,13,'1900-01-01 00:00:00'),(2326,0,3.51,'1900-01-01 00:00:00'),(2327,3,33.47,'1900-01-01 00:00:00'),(2328,3,28.3,'1900-01-01 00:00:00'),(2329,0,28.3,'1900-01-01 00:00:00'),(2330,0,17.11,'1900-01-01 00:00:00'),(2331,11,2.75,'1900-01-01 00:00:00'),(2332,0,24.18,'1900-01-01 00:00:00'),(2333,0,3.5,'1900-01-01 00:00:00'),(2334,1,28.99,'1900-01-01 00:00:00'),(2335,1,19.99,'1900-01-01 00:00:00'),(2336,0,9.99,'1900-01-01 00:00:00'),(2337,0,26.88,'1900-01-01 00:00:00'),(2338,1,21.75,'1900-01-01 00:00:00'),(2339,0,20.99,'1900-01-01 00:00:00'),(2340,1,24.99,'1900-01-01 00:00:00'),(2341,0,16.06,'1900-01-01 00:00:00'),(2342,0,25,'1900-01-01 00:00:00'),(2343,0,1.2,'1900-01-01 00:00:00'),(2344,1,66.99,'1900-01-01 00:00:00'),(2345,9,1.89,'1900-01-01 00:00:00'),(2346,1,16,'1900-01-01 00:00:00'),(2347,8,2.99,'1900-01-01 00:00:00'),(2348,4,2.99,'1900-01-01 00:00:00'),(2349,1,2.99,'1900-01-01 00:00:00'),(2350,2,2.99,'1900-01-01 00:00:00'),(2351,2,2.99,'1900-01-01 00:00:00'),(2352,0,4.99,'1900-01-01 00:00:00'),(2353,1,22.99,'1900-01-01 00:00:00'),(2354,0,28.35,'1900-01-01 00:00:00'),(2355,26,3.99,'1900-01-01 00:00:00'),(2356,1,14.99,'1900-01-01 00:00:00'),(2357,3,5.99,'1900-01-01 00:00:00'),(2358,8,20.99,'1900-01-01 00:00:00'),(2359,7,20.99,'1900-01-01 00:00:00'),(2360,3,16.99,'1900-01-01 00:00:00'),(2361,4,20.99,'1900-01-01 00:00:00'),(2362,0,63.75,'1900-01-01 00:00:00'),(2363,3,49.99,'1900-01-01 00:00:00'),(2364,0,10.99,'1900-01-01 00:00:00'),(2365,2,10.99,'1900-01-01 00:00:00'),(2366,3,41.99,'1900-01-01 00:00:00'),(2367,14,16.99,'1900-01-01 00:00:00'),(2368,0,8.997499,'1900-01-01 00:00:00'),(2369,11,13.99,'1900-01-01 00:00:00'),(2370,7,13.99,'1900-01-01 00:00:00'),(2371,3,39.99,'1900-01-01 00:00:00'),(2372,4,12.5,'1900-01-01 00:00:00'),(2373,1,2.99,'1900-01-01 00:00:00'),(2374,1,0,'1900-01-01 00:00:00'),(2375,1,12.99,'1900-01-01 00:00:00'),(2376,1,29.99,'1900-01-01 00:00:00'),(2377,6,9.99,'1900-01-01 00:00:00'),(2378,0,9,'1900-01-01 00:00:00'),(2379,30,16.99,'1900-01-01 00:00:00'),(2380,7,16.99,'1900-01-01 00:00:00'),(2381,5,2.99,'1900-01-01 00:00:00'),(2382,0,7.79,'1900-01-01 00:00:00'),(2383,0,32.49,'1900-01-01 00:00:00'),(2384,2,2.99,'1900-01-01 00:00:00'),(2385,99,2.99,'1900-01-01 00:00:00'),(2386,0,23.49,'1900-01-01 00:00:00'),(2387,2,2.99,'1900-01-01 00:00:00'),(2388,1,49.26,'1900-01-01 00:00:00'),(2389,5,16.5,'1900-01-01 00:00:00'),(2390,0,9.75,'1900-01-01 00:00:00'),(2391,2,2.99,'1900-01-01 00:00:00'),(2392,1,2.75,'1900-01-01 00:00:00'),(2393,1,2.99,'1900-01-01 00:00:00'),(2394,0,128.99,'1900-01-01 00:00:00'),(2395,3,1.99,'1900-01-01 00:00:00'),(2396,1,2.99,'1900-01-01 00:00:00'),(2397,10,4.99,'1900-01-01 00:00:00'),(2398,34,9.92,'1900-01-01 00:00:00'),(2399,1,12.99,'1900-01-01 00:00:00'),(2400,6,20.99,'1900-01-01 00:00:00'),(2401,4,16.99,'1900-01-01 00:00:00'),(2402,4,10.99,'1900-01-01 00:00:00'),(2403,11,9,'1900-01-01 00:00:00'),(2404,0,9.75,'1900-01-01 00:00:00'),(2405,2,13.99,'1900-01-01 00:00:00'),(2406,20,6.99,'1900-01-01 00:00:00'),(2407,23,6.99,'1900-01-01 00:00:00'),(2408,14,6.99,'1900-01-01 00:00:00'),(2409,0,8.75,'1900-01-01 00:00:00'),(2410,0,9,'1900-01-01 00:00:00'),(2411,0,18,'1900-01-01 00:00:00'),(2412,0,37.75,'1900-01-01 00:00:00'),(2413,6,14.99,'1900-01-01 00:00:00'),(2414,0,23,'1900-01-01 00:00:00'),(2415,10,15.5,'1900-01-01 00:00:00'),(2416,0,3,'1900-01-01 00:00:00'),(2417,0,145.99,'1900-01-01 00:00:00'),(2418,0,8,'1900-01-01 00:00:00'),(2419,0,1.99,'1900-01-01 00:00:00'),(2420,0,10.99,'1900-01-01 00:00:00'),(2421,4,12.99,'1900-01-01 00:00:00'),(2422,1,13.99,'1900-01-01 00:00:00'),(2423,2,27.99,'1900-01-01 00:00:00'),(2424,2,22.99,'1900-01-01 00:00:00'),(2425,1,3.99,'1900-01-01 00:00:00'),(2426,0,1.75,'1900-01-01 00:00:00'),(2427,0,11.99,'1900-01-01 00:00:00'),(2428,6,18.99,'1900-01-01 00:00:00'),(2429,0,18.99,'1900-01-01 00:00:00'),(2430,0,5.5,'1900-01-01 00:00:00'),(2431,0,3.96,'1900-01-01 00:00:00'),(2432,0,12,'1900-01-01 00:00:00'),(2433,4,42,'1900-01-01 00:00:00'),(2434,0,11.51,'1900-01-01 00:00:00'),(2435,0,10.99,'1900-01-01 00:00:00'),(2436,0,9.99,'1900-01-01 00:00:00'),(2437,3,10.99,'1900-01-01 00:00:00'),(2438,0,10.99,'1900-01-01 00:00:00'),(2439,0,7.99,'1900-01-01 00:00:00'),(2440,0,10.99,'1900-01-01 00:00:00'),(2441,0,7.99,'1900-01-01 00:00:00'),(2442,1,34.99,'1900-01-01 00:00:00'),(2443,0,12.99,'1900-01-01 00:00:00'),(2444,0,10.99,'1900-01-01 00:00:00'),(2445,0,9,'1900-01-01 00:00:00'),(2446,0,13.5,'1900-01-01 00:00:00'),(2447,11,14.99,'1900-01-01 00:00:00'),(2448,7,12.99,'1900-01-01 00:00:00'),(2449,3,12.99,'1900-01-01 00:00:00'),(2450,0,1.35,'1900-01-01 00:00:00'),(2451,0,1.5,'1900-01-01 00:00:00'),(2452,0,1.35,'1900-01-01 00:00:00'),(2453,0,14.1,'1900-01-01 00:00:00'),(2454,0,7.3,'1900-01-01 00:00:00'),(2455,3,11.99,'1900-01-01 00:00:00'),(2456,0,8.25,'1900-01-01 00:00:00'),(2457,0,2.99,'1900-01-01 00:00:00'),(2458,1,11.75,'1900-01-01 00:00:00'),(2459,1,11.99,'1900-01-01 00:00:00'),(2460,0,1.99,'1900-01-01 00:00:00'),(2461,0,12.99,'1900-01-01 00:00:00'),(2462,0,14.99,'1900-01-01 00:00:00'),(2463,1,0,'1900-01-01 00:00:00'),(2464,2,14.99,'1900-01-01 00:00:00'),(2465,0,11.99,'1900-01-01 00:00:00'),(2466,0,11.99,'1900-01-01 00:00:00'),(2467,2,3.5,'1900-01-01 00:00:00'),(2468,3,18.99,'1900-01-01 00:00:00'),(2469,1,13.99,'1900-01-01 00:00:00'),(2470,5,15.75,'1900-01-01 00:00:00'),(2471,7,11.99,'1900-01-01 00:00:00'),(2472,1,11.99,'1900-01-01 00:00:00'),(2473,2,10.99,'1900-01-01 00:00:00'),(2474,14,2.5,'1900-01-01 00:00:00'),(2475,2,8.99,'1900-01-01 00:00:00'),(2476,1,0,'1900-01-01 00:00:00'),(2477,1,29.99,'1900-01-01 00:00:00'),(2478,10,44.99,'1900-01-01 00:00:00'),(2479,2,76.99,'1900-01-01 00:00:00'),(2480,0,31.99,'1900-01-01 00:00:00'),(2481,0,61,'1900-01-01 00:00:00'),(2482,1,43.99,'1900-01-01 00:00:00'),(2483,0,14.99,'1900-01-01 00:00:00'),(2484,1,25.99,'1900-01-01 00:00:00'),(2485,1,10.99,'1900-01-01 00:00:00'),(2486,1,1.49,'1900-01-01 00:00:00'),(2487,7,15.99,'1900-01-01 00:00:00'),(2488,2,4.75,'1900-01-01 00:00:00'),(2489,4,6.25,'1900-01-01 00:00:00'),(2490,21,7.99,'1900-01-01 00:00:00'),(2491,3,1.99,'1900-01-01 00:00:00'),(2492,3,1.75,'1900-01-01 00:00:00'),(2493,1,19.99,'1900-01-01 00:00:00'),(2494,0,12,'1900-01-01 00:00:00'),(2495,4,6.99,'1900-01-01 00:00:00'),(2496,0,13.99,'1900-01-01 00:00:00'),(2497,0,9.5,'1900-01-01 00:00:00'),(2498,6,14.99,'1900-01-01 00:00:00'),(2499,1,4.99,'1900-01-01 00:00:00'),(2500,1,30.99,'1900-01-01 00:00:00'),(2501,7,20.99,'1900-01-01 00:00:00'),(2502,1,13.99,'1900-01-01 00:00:00'),(2503,0,8.99,'1900-01-01 00:00:00'),(2504,1,25.99,'1900-01-01 00:00:00'),(2505,5,13.99,'1900-01-01 00:00:00'),(2506,0,15.99,'1900-01-01 00:00:00'),(2507,2,13.99,'1900-01-01 00:00:00'),(2508,11,6,'1900-01-01 00:00:00'),(2509,0,9,'1900-01-01 00:00:00'),(2510,5,21.99,'1900-01-01 00:00:00'),(2511,0,8.5,'1900-01-01 00:00:00'),(2512,0,11.99,'1900-01-01 00:00:00'),(2513,0,8.5,'1900-01-01 00:00:00'),(2514,2,13.99,'1900-01-01 00:00:00'),(2515,4,9.99,'1900-01-01 00:00:00'),(2516,1,2.99,'1900-01-01 00:00:00'),(2517,0,1.25,'1900-01-01 00:00:00'),(2518,8,17.95,'1900-01-01 00:00:00'),(2519,1,296.99,'1900-01-01 00:00:00'),(2520,1,29.99,'1900-01-01 00:00:00'),(2521,0,29.75,'1900-01-01 00:00:00'),(2522,11,11.99,'1900-01-01 00:00:00'),(2523,0,1.5,'1900-01-01 00:00:00'),(2524,6,26.83,'1900-01-01 00:00:00'),(2525,0,13,'1900-01-01 00:00:00'),(2526,4,10.99,'1900-01-01 00:00:00'),(2527,17,13,'1900-01-01 00:00:00'),(2528,0,26.83,'1900-01-01 00:00:00'),(2529,5,35.75,'1900-01-01 00:00:00'),(2530,0,39.01,'1900-01-01 00:00:00'),(2531,7,53.5,'1900-01-01 00:00:00'),(2532,1,40.38,'1900-01-01 00:00:00'),(2533,3,8.99,'1900-01-01 00:00:00'),(2534,6,14.99,'1900-01-01 00:00:00'),(2535,7,47.99,'1900-01-01 00:00:00'),(2536,0,17.5,'1900-01-01 00:00:00'),(2537,0,14.34,'1900-01-01 00:00:00'),(2538,4,30.05,'1900-01-01 00:00:00'),(2539,3,52,'1900-01-01 00:00:00'),(2540,1,48.99,'1900-01-01 00:00:00'),(2541,0,12.25,'1900-01-01 00:00:00'),(2542,0,17.5,'1900-01-01 00:00:00'),(2543,0,7.8,'1900-01-01 00:00:00'),(2544,1,0,'1900-01-01 00:00:00'),(2545,0,17.5,'1900-01-01 00:00:00'),(2546,0,4.49,'1900-01-01 00:00:00'),(2547,1,9.99,'1900-01-01 00:00:00'),(2548,6,22.99,'1900-01-01 00:00:00'),(2549,0,20.95,'1900-01-01 00:00:00'),(2550,0,1.5,'1900-01-01 00:00:00'),(2551,5,19.99,'1900-01-01 00:00:00'),(2552,1,3.99,'1900-01-01 00:00:00'),(2553,0,1.1,'1900-01-01 00:00:00'),(2554,4,13.25,'1900-01-01 00:00:00'),(2555,0,10.5,'1900-01-01 00:00:00'),(2556,1,2.99,'1900-01-01 00:00:00'),(2557,2,2.79,'1900-01-01 00:00:00'),(2558,2,2.99,'1900-01-01 00:00:00'),(2559,1,2.99,'1900-01-01 00:00:00'),(2560,2,5.99,'1900-01-01 00:00:00'),(2561,1,6.99,'1900-01-01 00:00:00'),(2562,5,10.99,'1900-01-01 00:00:00'),(2563,3,10.99,'1900-01-01 00:00:00'),(2564,0,4.99,'1900-01-01 00:00:00'),(2565,2,6.99,'1900-01-01 00:00:00'),(2566,1,3.99,'1900-01-01 00:00:00'),(2567,3,19.99,'1900-01-01 00:00:00'),(2568,3,8.99,'1900-01-01 00:00:00'),(2569,2,5.99,'1900-01-01 00:00:00'),(2570,11,9.99,'1900-01-01 00:00:00'),(2571,9,2.99,'1900-01-01 00:00:00'),(2572,2,19.66,'1900-01-01 00:00:00'),(2573,1,15.99,'1900-01-01 00:00:00'),(2574,2,1.99,'1900-01-01 00:00:00'),(2575,4,4.99,'1900-01-01 00:00:00'),(2576,0,1.07,'1900-01-01 00:00:00'),(2577,0,1.07,'1900-01-01 00:00:00'),(2578,1,7.99,'1900-01-01 00:00:00'),(2579,1,4.99,'1900-01-01 00:00:00'),(2580,2,4.99,'1900-01-01 00:00:00'),(2581,2,4.99,'1900-01-01 00:00:00'),(2582,0,1.99,'1900-01-01 00:00:00'),(2583,1,87.99,'1900-01-01 00:00:00'),(2584,2,9.99,'1900-01-01 00:00:00'),(2585,0,6.33,'1900-01-01 00:00:00'),(2586,1,35.31,'1900-01-01 00:00:00'),(2587,5,1.99,'1900-01-01 00:00:00'),(2588,0,8.5,'1900-01-01 00:00:00'),(2589,1,10.99,'1900-01-01 00:00:00'),(2590,0,15,'1900-01-01 00:00:00'),(2591,0,9,'1900-01-01 00:00:00'),(2592,0,9,'1900-01-01 00:00:00'),(2593,13,16.99,'1900-01-01 00:00:00'),(2594,3,4.5,'1900-01-01 00:00:00'),(2595,25,4.5,'1900-01-01 00:00:00'),(2596,0,6.25,'1900-01-01 00:00:00'),(2597,3,54.99,'1900-01-01 00:00:00'),(2598,2,15.99,'1900-01-01 00:00:00'),(2599,0,11,'1900-01-01 00:00:00'),(2600,2,15.99,'1900-01-01 00:00:00'),(2601,3,14.99,'1900-01-01 00:00:00'),(2602,2,17.99,'1900-01-01 00:00:00'),(2603,4,12.5,'1900-01-01 00:00:00'),(2604,7,13.99,'1900-01-01 00:00:00'),(2605,2,11.99,'1900-01-01 00:00:00'),(2606,1,18.9,'1900-01-01 00:00:00'),(2607,0,1312,'1900-01-01 00:00:00'),(2608,4,16.99,'1900-01-01 00:00:00'),(2609,6,13.25,'1900-01-01 00:00:00'),(2610,0,2.99,'1900-01-01 00:00:00'),(2611,2,23,'1900-01-01 00:00:00'),(2612,2,41.99,'1900-01-01 00:00:00'),(2613,6,17.99,'1900-01-01 00:00:00'),(2614,3,12.75,'1900-01-01 00:00:00'),(2615,15,17.99,'1900-01-01 00:00:00'),(2616,1,20.99,'1900-01-01 00:00:00'),(2617,0,8.99,'1900-01-01 00:00:00'),(2618,0,9.25,'1900-01-01 00:00:00'),(2619,2,13.99,'1900-01-01 00:00:00'),(2620,0,9,'1900-01-01 00:00:00'),(2621,0,26.99,'1900-01-01 00:00:00'),(2622,7,0,'1900-01-01 00:00:00'),(2623,0,15,'1900-01-01 00:00:00'),(2624,0,7.99,'1900-01-01 00:00:00'),(2625,5,27.99,'1900-01-01 00:00:00'),(2626,2,26.99,'1900-01-01 00:00:00'),(2627,6,11.99,'1900-01-01 00:00:00'),(2628,2,11.99,'1900-01-01 00:00:00'),(2629,1,18.5,'1900-01-01 00:00:00'),(2630,5,12.99,'1900-01-01 00:00:00'),(2631,0,13.99,'1900-01-01 00:00:00'),(2632,8,12.75,'1900-01-01 00:00:00'),(2633,3,12.75,'1900-01-01 00:00:00'),(2634,0,9.99,'1900-01-01 00:00:00'),(2635,1,25.99,'1900-01-01 00:00:00'),(2636,0,11.99,'1900-01-01 00:00:00'),(2637,12,27.99,'1900-01-01 00:00:00'),(2638,2,79.99,'1900-01-01 00:00:00'),(2639,3,30.99,'1900-01-01 00:00:00'),(2640,2,6.99,'1900-01-01 00:00:00'),(2641,1,8.99,'1900-01-01 00:00:00'),(2642,1,18.95,'1900-01-01 00:00:00'),(2643,13,11.95,'1900-01-01 00:00:00'),(2644,1,12.99,'1900-01-01 00:00:00'),(2645,1,10.99,'1900-01-01 00:00:00'),(2646,1,14.95,'1900-01-01 00:00:00'),(2647,1,19.95,'1900-01-01 00:00:00'),(2648,1,19.95,'1900-01-01 00:00:00'),(2649,1,19.99,'1900-01-01 00:00:00'),(2650,1,18.99,'1900-01-01 00:00:00'),(2651,1,16.99,'1900-01-01 00:00:00'),(2652,0,34.99,'1900-01-01 00:00:00'),(2653,0,8.75,'1900-01-01 00:00:00'),(2654,0,10.99,'1900-01-01 00:00:00'),(2655,0,14.99,'1900-01-01 00:00:00'),(2656,0,9.99,'1900-01-01 00:00:00'),(2657,0,4.99,'1900-01-01 00:00:00'),(2658,0,10.99,'1900-01-01 00:00:00'),(2659,0,24.99,'1900-01-01 00:00:00'),(2660,0,7.99,'1900-01-01 00:00:00'),(2661,0,20,'1900-01-01 00:00:00'),(2662,0,66.99,'1900-01-01 00:00:00'),(2664,0,4.99,'1900-01-01 00:00:00'),(2665,0,10.99,'1900-01-01 00:00:00'),(2666,0,18.99,'1900-01-01 00:00:00'),(2667,0,18.99,'1900-01-01 00:00:00'),(2668,0,7.99,'1900-01-01 00:00:00'),(2671,0,1.99,'1900-01-01 00:00:00'),(2672,0,6.9902289106,'1900-01-01 00:00:00'),(2673,0,6.99,'1900-01-01 00:00:00'),(2674,0,415.84,'1900-01-01 00:00:00'),(2675,0,325.43,'1900-01-01 00:00:00'),(2676,0,336.08,'1900-01-01 00:00:00'),(2677,0,423.49,'1900-01-01 00:00:00'),(2678,0,1,'1900-01-01 00:00:00'),(2679,0,0.99,'1900-01-01 00:00:00'),(2680,0,1,'1900-01-01 00:00:00'),(2681,0,1,'1900-01-01 00:00:00'),(2682,0,14.99,'1900-01-01 00:00:00'),(2683,0,7.99,'1900-01-01 00:00:00'),(2685,0,89.99,'1900-01-01 00:00:00'),(2687,0,0.05,'1900-01-01 00:00:00'),(2688,0,0.35,'1900-01-01 00:00:00'),(2689,0,0.75,'1900-01-01 00:00:00'),(2690,0,1.99,'1900-01-01 00:00:00'),(2691,0,3.75,'1900-01-01 00:00:00'),(2692,0,7.99,'1900-01-01 00:00:00'),(2693,0,1.99,'1900-01-01 00:00:00'),(2694,0,753.02,'1900-01-01 00:00:00'),(2695,0,704.21,'1900-01-01 00:00:00'),(2696,0,17.99,'1900-01-01 00:00:00'),(2697,0,379.87,'1900-01-01 00:00:00'),(2698,0,482.42,'1900-01-01 00:00:00'),(2699,0,367.52,'1900-01-01 00:00:00'),(2700,0,360.64,'1900-01-01 00:00:00'),(2701,0,4.79,'1900-01-01 00:00:00'),(2702,0,5.99,'1900-01-01 00:00:00'),(2703,0,4.5,'1900-01-01 00:00:00'),(2704,0,6.99,'1900-01-01 00:00:00'),(2705,0,26.83,'1900-01-01 00:00:00'),(2706,0,26.83,'1900-01-01 00:00:00'),(2707,0,2.5,'1900-01-01 00:00:00'),(2708,0,0.69,'1900-01-01 00:00:00'),(2709,0,0.99,'1900-01-01 00:00:00'),(2710,0,14.99,'1900-01-01 00:00:00'),(2711,0,2.99,'1900-01-01 00:00:00'),(2712,0,2.75,'1900-01-01 00:00:00'),(2713,0,2,'1900-01-01 00:00:00'),(2714,0,39.99,'1900-01-01 00:00:00'),(2716,0,16.99,'1900-01-01 00:00:00'),(2718,0,36.75,'1900-01-01 00:00:00'),(2719,0,2.5,'1900-01-01 00:00:00'),(2720,0,15.99,'1900-01-01 00:00:00'),(2721,0,62.99,'1900-01-01 00:00:00'),(2722,0,0,'1900-01-01 00:00:00'),(2723,0,7.99,'1900-01-01 00:00:00'),(2725,0,25.99,'1900-01-01 00:00:00'),(2726,0,22.99,'1900-01-01 00:00:00'),(2727,0,24.81,'1900-01-01 00:00:00'),(2728,0,3.75,'1900-01-01 00:00:00'),(2729,0,13.99,'1900-01-01 00:00:00'),(2730,0,8.75,'1900-01-01 00:00:00'),(2731,0,4.99,'1900-01-01 00:00:00'),(2732,0,8.99,'1900-01-01 00:00:00'),(2733,0,3.75,'1900-01-01 00:00:00'),(2734,0,13.99,'1900-01-01 00:00:00'),(2735,0,100,'1900-01-01 00:00:00'),(2736,0,25,'1900-01-01 00:00:00'),(2737,0,40,'1900-01-01 00:00:00'),(2738,0,50,'1900-01-01 00:00:00'),(2739,0,100,'1900-01-01 00:00:00'),(2740,0,3.99,'1900-01-01 00:00:00'),(2741,0,3.75,'1900-01-01 00:00:00'),(2742,0,2.69,'1900-01-01 00:00:00'),(2743,0,1.99,'1900-01-01 00:00:00'),(2745,0,3.75,'1900-01-01 00:00:00'),(2746,0,1.45,'1900-01-01 00:00:00'),(2747,0,12.99,'1900-01-01 00:00:00'),(2748,0,23.99,'1900-01-01 00:00:00'),(2749,0,10.99,'1900-01-01 00:00:00'),(2750,0,5.99,'1900-01-01 00:00:00'),(2751,0,22.99,'1900-01-01 00:00:00'),(2752,0,22.99,'1900-01-01 00:00:00'),(2753,0,3.99,'1900-01-01 00:00:00'),(2754,0,38.8,'1900-01-01 00:00:00'),(2755,0,19.99,'1900-01-01 00:00:00'),(2756,0,12.99,'1900-01-01 00:00:00'),(2758,0,4,'1900-01-01 00:00:00'),(2759,38,15,'1900-01-01 00:00:00'),(2760,0,4.99,'1900-01-01 00:00:00'),(2761,0,0.99,'1900-01-01 00:00:00'),(2762,0,0.69,'1900-01-01 00:00:00'),(2763,0,0.99,'1900-01-01 00:00:00'),(2764,1,12.99,'1900-01-01 00:00:00'),(2765,0,2.99,'1900-01-01 00:00:00'),(2766,0,1.75,'1900-01-01 00:00:00'),(2767,0,28.99,'1900-01-01 00:00:00'),(2768,0,5.99,'1900-01-01 00:00:00'),(2769,0,4.99,'1900-01-01 00:00:00'),(2770,0,24.19,'1900-01-01 00:00:00'),(2772,0,0.5,'1900-01-01 00:00:00'),(2773,0,14.75,'1900-01-01 00:00:00'),(2774,0,14.99,'1900-01-01 00:00:00'),(2775,0,7.99,'1900-01-01 00:00:00'),(2776,0,7.99,'1900-01-01 00:00:00'),(2777,1,19,'1900-01-01 00:00:00'),(2778,0,3.99,'1900-01-01 00:00:00'),(2779,0,19,'1900-01-01 00:00:00'),(2780,0,12.75,'1900-01-01 00:00:00'),(2782,0,7.99,'1900-01-01 00:00:00'),(2783,0,4,'1900-01-01 00:00:00'),(2784,0,5,'1900-01-01 00:00:00'),(2785,0,72.99,'1900-01-01 00:00:00'),(2786,0,23.99,'1900-01-01 00:00:00'),(2787,0,76.99,'1900-01-01 00:00:00'),(2788,0,7.99,'1900-01-01 00:00:00'),(2789,0,0.99,'1900-01-01 00:00:00'),(2790,0,1.25,'1900-01-01 00:00:00'),(2791,0,3.99,'1900-01-01 00:00:00'),(2792,0,0.75,'1900-01-01 00:00:00'),(2793,0,7.99,'1900-01-01 00:00:00'),(2794,0,20.99,'1900-01-01 00:00:00'),(2795,1,14.99,'1900-01-01 00:00:00'),(2796,0,8.75,'1900-01-01 00:00:00'),(2798,0,2.25,'1900-01-01 00:00:00'),(2799,0,20.99,'1900-01-01 00:00:00'),(2800,0,14.5,'1900-01-01 00:00:00'),(2803,0,4,'1900-01-01 00:00:00'),(2804,0,4.99,'1900-01-01 00:00:00'),(2805,0,1.99,'1900-01-01 00:00:00'),(2807,0,5.99,'1900-01-01 00:00:00'),(2808,0,5.99,'1900-01-01 00:00:00'),(2809,0,4.99,'1900-01-01 00:00:00'),(2810,0,6.99,'1900-01-01 00:00:00'),(2811,0,1.75,'1900-01-01 00:00:00'),(2812,0,20.99,'1900-01-01 00:00:00'),(2813,0,42,'1900-01-01 00:00:00'),(2814,0,3.99,'1900-01-01 00:00:00'),(2815,0,99.99,'1900-01-01 00:00:00'),(2816,0,79.99,'1900-01-01 00:00:00'),(2817,0,2.99,'1900-01-01 00:00:00'),(2818,0,0.45,'1900-01-01 00:00:00'),(2819,0,10.99,'1900-01-01 00:00:00'),(2820,0,1.49,'1900-01-01 00:00:00'),(2821,0,2.99,'1900-01-01 00:00:00'),(2822,0,1.99,'1900-01-01 00:00:00'),(2823,0,1,'1900-01-01 00:00:00'),(2824,0,2.99,'1900-01-01 00:00:00'),(2825,0,15.99,'1900-01-01 00:00:00'),(2826,0,2.99,'1900-01-01 00:00:00'),(2827,0,34.54,'1900-01-01 00:00:00'),(2828,0,0.25,'1900-01-01 00:00:00'),(2829,0,6.99,'1900-01-01 00:00:00'),(2830,0,12.99,'1900-01-01 00:00:00'),(2831,0,0.99,'1900-01-01 00:00:00'),(2832,0,1.99,'1900-01-01 00:00:00'),(2833,0,9.99,'1900-01-01 00:00:00'),(2834,0,2.99,'1900-01-01 00:00:00'),(2835,0,3.99,'1900-01-01 00:00:00'),(2836,0,2.99,'1900-01-01 00:00:00'),(2837,0,2.5,'1900-01-01 00:00:00'),(2838,0,2.5,'1900-01-01 00:00:00'),(2839,0,0.05,'1900-01-01 00:00:00'),(2840,0,0.05,'1900-01-01 00:00:00'),(2841,0,0.15,'1900-01-01 00:00:00'),(2842,0,5.99,'1900-01-01 00:00:00'),(2843,0,2.99,'1900-01-01 00:00:00'),(2844,0,27.99,'1900-01-01 00:00:00'),(2845,0,39.99,'1900-01-01 00:00:00'),(2846,0,2.75,'1900-01-01 00:00:00'),(2847,0,64.99,'1900-01-01 00:00:00'),(2848,0,4.99,'1900-01-01 00:00:00'),(2850,0,49.99,'1900-01-01 00:00:00'),(2851,0,1,'1900-01-01 00:00:00'),(2852,0,1786.65,'1900-01-01 00:00:00'),(2853,0,249.14,'1900-01-01 00:00:00'),(2854,0,429.45,'1900-01-01 00:00:00'),(2855,0,299.47,'1900-01-01 00:00:00'),(2856,0,2431.39,'1900-01-01 00:00:00'),(2857,0,3205.29,'1900-01-01 00:00:00'),(2859,0,0.99,'1900-01-01 00:00:00'),(2860,0,5.49,'1900-01-01 00:00:00'),(2861,0,5.99,'1900-01-01 00:00:00'),(2862,0,1.99,'1900-01-01 00:00:00'),(2863,0,25,'1900-01-01 00:00:00'),(2864,0,20,'1900-01-01 00:00:00'),(2865,0,9.99,'1900-01-01 00:00:00'),(2866,0,0.99,'1900-01-01 00:00:00'),(2867,0,20.99,'1900-01-01 00:00:00'),(2868,1,14.99,'1900-01-01 00:00:00'),(2869,0,7.99,'1900-01-01 00:00:00'),(2883,50,0,'2021-03-25 20:15:59'),(2885,0,0,'2021-04-01 19:08:06'),(2993,0,0,'2021-11-18 18:49:55'),(3085,1,0,'2022-02-17 20:37:51'),(3630,1,0,'2022-01-13 18:50:39'),(3833,0,0,'2022-02-17 20:07:01'),(3941,0,5,'2021-10-14 20:38:52'),(4031,0,0,'2022-04-19 10:09:07'),(4191,5,8,'2021-10-14 20:41:05'),(4428,9999,5,'2021-08-24 18:39:53'),(4430,9999,0,'2022-01-04 19:08:37'),(4434,3,0.99,'2022-01-18 17:53:06'),(4435,5,5,'2022-01-18 20:06:54'),(4436,1,0.5,'2022-01-18 20:11:26'),(4437,23,5.55,'2022-01-25 19:10:13'),(4448,20,5,'2022-04-07 20:45:57'),(4449,0,0,'2022-04-12 19:34:36');
/*!40000 ALTER TABLE `inventory_price` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_inventory_price_BI` BEFORE INSERT ON `inventory_price` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'inventory_price' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_inventory_price_BU` BEFORE UPDATE ON `inventory_price` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'inventory_price' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_inventory_price_BD` BEFORE DELETE ON `inventory_price` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'inventory_price' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Temporary view structure for view `inventory_quantity`
--

DROP TABLE IF EXISTS `inventory_quantity`;
/*!50001 DROP VIEW IF EXISTS `inventory_quantity`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `inventory_quantity` AS SELECT 
 1 AS `item_name`,
 1 AS `inventoryID`,
 1 AS `quantity`,
 1 AS `barcode`,
 1 AS `retail_price`,
 1 AS `supplierID`,
 1 AS `item_description`,
 1 AS `typeID`,
 1 AS `bottle_deposit_qty`,
 1 AS `nontaxable`,
 1 AS `nontaxable_local`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `inventory_type`
--

DROP TABLE IF EXISTS `inventory_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `inventory_type` (
  `typeID` int NOT NULL AUTO_INCREMENT,
  `inventory_type_name` varchar(50) NOT NULL,
  `min_qty` int DEFAULT '1',
  `max_qty` int DEFAULT '1',
  `idTax` int DEFAULT NULL,
  `bottles` int DEFAULT '0',
  `Increment_qty` int DEFAULT '1',
  PRIMARY KEY (`typeID`),
  KEY `Inventory_type_fk_Config` (`idTax`),
  CONSTRAINT `Inventory_type_fk_Config` FOREIGN KEY (`idTax`) REFERENCES `tax` (`idTAX`)
) ENGINE=InnoDB AUTO_INCREMENT=60 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventory_type`
--

LOCK TABLES `inventory_type` WRITE;
/*!40000 ALTER TABLE `inventory_type` DISABLE KEYS */;
INSERT INTO `inventory_type` VALUES (1,'GIFT',1,2,1,0,1),(2,'CANDY',1,2,1,0,1),(3,'MIXERS',1,2,1,0,1),(4,'FOOD',1,2,1,0,1),(5,'WINE',1,12,3,1,12),(6,'BEER',1,6,3,6,6),(7,'LIQUOR',1,2,3,0,1),(8,'PROPANE',1,2,1,0,1),(9,'CUSTOM',1,2,1,0,1),(10,'SERVICE',1,2,4,0,1),(11,'DEPOSIT',1,2,4,0,1),(12,'none',1,2,1,0,1),(13,'DRY CLEANING',1,2,1,0,1),(15,'SODA',1,2,3,0,1),(26,'EVENT',1,2,4,0,1),(59,'SNACK, SODA, & CANDY',1,2,NULL,0,1);
/*!40000 ALTER TABLE `inventory_type` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_inventory_type_BI` BEFORE INSERT ON `inventory_type` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'inventory_type' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_inventory_type_BU` BEFORE UPDATE ON `inventory_type` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'inventory_type' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_inventory_type_BD` BEFORE DELETE ON `inventory_type` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'inventory_type' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `notetype`
--

DROP TABLE IF EXISTS `notetype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `notetype` (
  `NoteTypeID` int NOT NULL AUTO_INCREMENT,
  `NoteType` varchar(45) NOT NULL,
  PRIMARY KEY (`NoteTypeID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `notetype`
--

LOCK TABLES `notetype` WRITE;
/*!40000 ALTER TABLE `notetype` DISABLE KEYS */;
INSERT INTO `notetype` VALUES (1,'General'),(2,'Request');
/*!40000 ALTER TABLE `notetype` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_notetype_BI` BEFORE INSERT ON `notetype` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'notetype' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_notetype_BU` BEFORE UPDATE ON `notetype` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'notetype' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_notetype_BD` BEFORE DELETE ON `notetype` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'notetype' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `paymentmethod`
--

DROP TABLE IF EXISTS `paymentmethod`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `paymentmethod` (
  `PaymentMethodId` int NOT NULL AUTO_INCREMENT,
  `PaymentMethod` varchar(45) NOT NULL,
  `PercentOffset` decimal(10,0) NOT NULL DEFAULT '0',
  PRIMARY KEY (`PaymentMethodId`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paymentmethod`
--

LOCK TABLES `paymentmethod` WRITE;
/*!40000 ALTER TABLE `paymentmethod` DISABLE KEYS */;
INSERT INTO `paymentmethod` VALUES (1,'CASH',3),(2,'CHECK',3),(3,'CREDIT CARD',0),(4,'GIFT CARD',0),(5,'CUSTOMER CREDIT',0),(6,'DONATE',100),(7,'BREAKAGE',100);
/*!40000 ALTER TABLE `paymentmethod` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_paymentmethod_BI` BEFORE INSERT ON `paymentmethod` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'paymentmethod' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_paymentmethod_BU` BEFORE UPDATE ON `paymentmethod` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'paymentmethod' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_paymentmethod_BD` BEFORE DELETE ON `paymentmethod` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'paymentmethod' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `payments`
--

DROP TABLE IF EXISTS `payments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payments` (
  `PayId` int NOT NULL AUTO_INCREMENT,
  `ReceiptID` int DEFAULT NULL,
  `Method` varchar(30) DEFAULT NULL,
  `Number` varchar(30) DEFAULT NULL,
  `Amount` double DEFAULT NULL,
  PRIMARY KEY (`PayId`),
  KEY `payments_fk_transaction` (`ReceiptID`),
  CONSTRAINT `payments_fk_transaction` FOREIGN KEY (`ReceiptID`) REFERENCES `transaction` (`receiptID`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payments`
--

LOCK TABLES `payments` WRITE;
/*!40000 ALTER TABLE `payments` DISABLE KEYS */;
INSERT INTO `payments` VALUES (1,7,'CASH','380',0),(2,8,'CASH','',14.88),(3,9,'CHECK',NULL,50),(4,10,'CASH',NULL,50),(5,11,'CHECK','1234',10),(6,12,'CHECK','1234',10),(7,13,'CASH',NULL,12),(8,14,'CASH',NULL,15),(9,7,'CASH','100',50),(10,7,'CASH','',520),(11,17,'CASH',NULL,1),(12,18,'GIFT CARD','',10),(13,18,'CREDIT CARD','',5),(14,18,'CREDIT CARD','',3),(15,19,'CUSTOMER CREDIT',NULL,55.75),(16,20,'CREDIT CARD','',271.09),(17,21,'CASH',NULL,255),(18,22,'CASH',NULL,15),(19,23,'CASH',NULL,2),(20,24,'CASH',NULL,200),(21,25,'CASH',NULL,122.2),(22,26,'CASH',NULL,8.47),(23,27,'BREAKAGE',NULL,8.47),(24,28,'CASH',NULL,100.14),(25,29,'BREAKAGE',NULL,11.7),(26,30,'BREAKAGE',NULL,41.18),(27,31,'CASH',NULL,40),(28,32,'DONATE',NULL,41.33),(29,34,'CASH',NULL,60),(30,42,'CREDIT CARD','',41.18),(31,43,'CASH',NULL,63.79),(32,44,'GIFT CARD','',70),(33,47,'CREDIT CARD','',50);
/*!40000 ALTER TABLE `payments` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_payments_BI` BEFORE INSERT ON `payments` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'payments' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_payments_BU` BEFORE UPDATE ON `payments` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'payments' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_payments_BD` BEFORE DELETE ON `payments` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'payments' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `printercode`
--

DROP TABLE IF EXISTS `printercode`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `printercode` (
  `printerCodeid` int NOT NULL AUTO_INCREMENT,
  `Drawer` varchar(45) DEFAULT NULL,
  `Cutter` varchar(45) DEFAULT NULL,
  `PartialCutter` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`printerCodeid`),
  UNIQUE KEY `UQ_printercode` (`Drawer`,`Cutter`,`PartialCutter`)
) ENGINE=InnoDB AUTO_INCREMENT=133 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `printercode`
--

LOCK TABLES `printercode` WRITE;
/*!40000 ALTER TABLE `printercode` DISABLE KEYS */;
INSERT INTO `printercode` VALUES (13,'','',''),(16,'','27,105','27,109'),(122,'123','321',NULL),(78,'27,07,11,55,07','27,100,51',''),(67,'27,110,0,25,250','',''),(38,'27,112','27,105',''),(43,'27,112,0,100,100','',''),(44,'27,112,0,100,250','',''),(82,'27,112,0,100,250','27,105',''),(89,'27,112,0,148,49','',''),(91,'27,112,0,150,250','',''),(62,'27,112,0,25','27,105',''),(59,'27,112,0,25,125','',''),(86,'27,112,0,25,25','',''),(1,'27,112,0,25,250','',''),(23,'27,112,0,25,250','27,105',''),(93,'27,112,0,25,250','27,105','27,109'),(30,'27,112,0,25,250','27,109',''),(35,'27,112,0,25,250','27,112,0,75,250',''),(61,'27,112,0,25,250','27,12,0,25,250',''),(31,'27,112,0,25,250','27121',''),(28,'27,112,0,25,251','',''),(10,'27,112,0,25,255','',''),(49,'27,112,0,250,250','',''),(24,'27,112,0,40,168','',''),(80,'27,112,0,48','',''),(45,'27,112,0,48,251','',''),(2,'27,112,0,48,251','27,105','27,109'),(3,'27,112,0,48,252','27,105','27,109'),(4,'27,112,0,48,253','27,105','27,109'),(92,'27,112,0,48,48','',''),(65,'27,112,0,48,50','',''),(9,'27,112,0,50,250','',''),(15,'27,112,0,50,250','27,105',''),(14,'27,112,0,50,250','27,105','27,109'),(17,'27,112,0,50,250','27,109',''),(50,'27,112,0,50,250','27,12',''),(56,'27,112,0,55','27,105,27,109',''),(66,'27,112,0,60,240','',''),(12,'27,112,0,64,240','',''),(32,'27,112,0,64,240','27,109',''),(47,'27,112,0,8,8','',''),(46,'27,112,1,49,251','',''),(53,'27,112,1,49,251','27,105',''),(5,'27,112,1,49,251','27,105','27,109'),(54,'27,112,1,49,251','27,109',''),(6,'27,112,1,49,252','27,105','27,109'),(25,'27,112,32,25','',''),(84,'27,112,32,55,255','',''),(36,'27,112,48,25,250','',''),(81,'27,112,48,32,64','27,109',''),(69,'27,112,48,40,200','27,105',''),(11,'27,112,48,55,121','',''),(27,'27,112,48,55,121','27,109',''),(34,'27,112,48,55,121','27,112,0,5,250',''),(87,'27,112,49,48,48','27,105',''),(63,'27,112,80,25,250','',''),(57,'27,112,80,25,250','27,112,1,55',''),(41,'27,113,0,25,250','',''),(8,'27,118,140','',''),(52,'27,120,1','',''),(51,'27,120,1','27,118',''),(55,'27,120,2','27,118',''),(73,'27,122,49,7','27,100,48',''),(42,'27,25,247','',''),(74,'27,7,10,50,7','',''),(76,'27,7,10,50,7','27,100,51',''),(70,'27,7,11,55,7','',''),(71,'27,7,11,55,7','27,100,48',''),(79,'27,7,11,55,7','27,100,51',''),(26,'27,70,0,50,50','',''),(123,'7','',NULL),(19,'7','',''),(88,'7','20',''),(58,'7','27,100',''),(60,'7','27,100,49',''),(75,'7','27,100,51',''),(18,'7','27,109',''),(21,'7,27','',''),(129,'aaa','bbb',''),(130,'bbb','ccc','');
/*!40000 ALTER TABLE `printercode` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_printercode_BI` BEFORE INSERT ON `printercode` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'printercode' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_printercode_BU` BEFORE UPDATE ON `printercode` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'printercode' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_printercode_BD` BEFORE DELETE ON `printercode` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'printercode' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `printermake`
--

DROP TABLE IF EXISTS `printermake`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `printermake` (
  `printerMakeID` int NOT NULL AUTO_INCREMENT,
  `printerMakeName` varchar(45) NOT NULL,
  PRIMARY KEY (`printerMakeID`),
  UNIQUE KEY `printerMakeName_UNIQUE` (`printerMakeName`)
) ENGINE=InnoDB AUTO_INCREMENT=102 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `printermake`
--

LOCK TABLES `printermake` WRITE;
/*!40000 ALTER TABLE `printermake` DISABLE KEYS */;
INSERT INTO `printermake` VALUES (5,''),(1,'3NSTAR'),(2,'AGPTek'),(3,'Appostar'),(4,'Axiohm'),(6,'Bematech'),(7,'Bixolon'),(8,'Citizen'),(9,'Code Soft'),(10,'Custom'),(11,'DCAPOS'),(12,'Dell'),(13,'DIGIPOS'),(14,'EC-Line'),(15,'Epson'),(16,'Essae'),(20,'Fujitsu'),(17,'Gainscha'),(18,'Goangzhou'),(19,'Gprinter'),(21,'HOIN'),(22,'HP'),(23,'HPRT'),(24,'IBM'),(25,'IDIPOS'),(26,'INFOCOMM'),(27,'Ithaca'),(28,'Jolimark'),(29,'Kasir Enibit'),(30,'Koohii'),(31,'MetaPace'),(32,'NCR'),(33,'NEC'),(34,'NEXA'),(35,'Obvios'),(36,'Ojuled'),(37,'Oki'),(38,'Olivetti'),(39,'POS-58'),(40,'POS-X'),(41,'Posiflex'),(42,'Samsung'),(43,'Seiko'),(44,'Sensonic'),(45,'Sewoo'),(46,'Shenzhen'),(47,'Sinocan'),(48,'SNBC'),(49,'Star'),(50,'Star Micronics'),(51,'Syncotek'),(52,'TEC'),(53,'Toshiba'),(54,'TOSHIBA TEC'),(55,'TPG'),(56,'TVS'),(57,'Tysso'),(58,'UCOM'),(59,'Unisys'),(60,'WASP'),(61,'WESTREX'),(62,'Xprinter'),(63,'Zjiang'),(64,'Zonerich');
/*!40000 ALTER TABLE `printermake` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_printermake_BI` BEFORE INSERT ON `printermake` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'printermake' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_printermake_BU` BEFORE UPDATE ON `printermake` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'printermake' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_printermake_BD` BEFORE DELETE ON `printermake` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'printermake' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `printermodel`
--

DROP TABLE IF EXISTS `printermodel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `printermodel` (
  `PrinterModelid` int NOT NULL AUTO_INCREMENT,
  `PrinterModelname` varchar(45) DEFAULT NULL,
  `printerMakeID` int DEFAULT NULL,
  PRIMARY KEY (`PrinterModelid`),
  UNIQUE KEY `UQ_printerModel` (`PrinterModelname`,`printerMakeID`),
  KEY `fk__idx` (`printerMakeID`),
  CONSTRAINT `fk_PrinterModel_PrinterMakeID` FOREIGN KEY (`printerMakeID`) REFERENCES `printermake` (`printerMakeID`)
) ENGINE=InnoDB AUTO_INCREMENT=249 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `printermodel`
--

LOCK TABLES `printermodel` WRITE;
/*!40000 ALTER TABLE `printermodel` DISABLE KEYS */;
INSERT INTO `printermodel` VALUES (133,'150',27),(134,'280',27),(46,'3200 SERIES',9),(225,'4200',61),(122,'4610',24),(142,'7167',32),(143,'7179',32),(144,'7197',32),(145,'7223',32),(130,'80 PLUS',27),(4,'A715',4),(5,'A756',4),(215,'A776',55),(6,'A794',4),(216,'A794',55),(118,'A798',22),(217,'A798',55),(119,'A799',22),(218,'A799',55),(120,'A799-C40W',22),(246,'AAA',10),(112,'AB-88A',18),(124,'AB-88H',25),(232,'AB-88H',64),(95,'ADP 300',15),(153,'All',39),(159,'AURA 5600',41),(160,'AURA 8000',41),(183,'BTP-2002NP',48),(181,'BTP-M280',48),(182,'BTP-R880NP',48),(24,'CBM-1000',8),(25,'CBM-1000 II',8),(16,'CBM-230',8),(17,'CBM-231',8),(18,'CBM-232',8),(19,'CBM-233',8),(20,'CBM-253',8),(21,'CBM-262',8),(22,'CBM-291',8),(23,'CBM-293',8),(158,'CR 4200',41),(28,'CT-S2000',8),(26,'CT-S300',8),(27,'CT-S310',8),(55,'Default',15),(184,'Default',49),(204,'dp-8340fm',50),(47,'DP7645III',9),(214,'DRJST-51',54),(51,'DS-800',13),(52,'EC-PM-520',14),(54,'EC-PM-5890X',14),(53,'EC-PM-80330',14),(102,'ECP-500',15),(222,'EF4272',59),(174,'ESC-POS',43),(157,'EVO-RP1',40),(223,'F100',60),(115,'fp-350',20),(116,'fp-410',20),(113,'GP-5890',19),(111,'GP-80160',17),(114,'GP-80160',19),(117,'HOP-E801',21),(30,'iDP-3210',8),(31,'iDP-3240',8),(32,'iDP-3310',8),(33,'iDP-3410',8),(34,'iDP-3420',8),(35,'iDP-3421',8),(36,'iDP-3423',8),(37,'iDP-3530',8),(38,'iDP-3535',8),(39,'iDP-3540',8),(40,'iDP-3541',8),(41,'iDP-3545',8),(42,'iDP-3546',8),(43,'iDP-3550',8),(44,'iDP-3551',8),(29,'iDP-460',8),(135,'iTherm 280',27),(178,'LK-TL-322',45),(1,'LPT005',1),(97,'LX-300+',15),(74,'M115A',15),(75,'M129C',15),(76,'M188A',15),(77,'M188B',15),(78,'M188D',15),(79,'M192C',15),(80,'M192H',15),(93,'M253A',15),(57,'M51PD',15),(103,'M665A',15),(7,'MP-250TH',6),(151,'OKIPOS 1000',37),(150,'OKIPOS 407',37),(148,'ORP-800',35),(138,'P58B',29),(125,'P80',26),(126,'PcOS 50',27),(127,'PcOS 51',27),(128,'PcOS 52',27),(180,'PO6-U/S/L',47),(49,'POS 8350',11),(229,'POS-58',63),(179,'POS-8350',46),(149,'POS58',36),(129,'POSjet',27),(136,'POSjet 1000',27),(161,'PP6000',41),(162,'PP6900',41),(163,'PP7000',41),(164,'PP8000',41),(45,'PPU-231',8),(110,'PR-85',16),(220,'PRP076',57),(152,'PRT-100',38),(147,'PX700',34),(48,'Q3',10),(206,'RKP300',52),(219,'RP-3200',56),(175,'RP-B10',43),(176,'RP-E10',43),(3,'RTP-3280',3),(2,'SC9-5870',2),(131,'SERIES 90',27),(132,'SERIES 94',27),(139,'SMART 300',30),(205,'SP-POS88VI',51),(188,'SP200',49),(189,'SP200-2',49),(202,'SP2000',49),(190,'SP212',49),(192,'SP500',49),(193,'SP512',49),(194,'SP550II',49),(166,'SRP 220',42),(167,'SRP 270',42),(168,'SRP 270A',42),(169,'SRP 275',42),(172,'SRP 350',42),(173,'SRP 350T',42),(8,'SRP-150UG',7),(11,'SRP-275',7),(170,'SRP-275AP',42),(171,'SRP-275C',42),(12,'SRP-280',7),(9,'SRP-330',7),(13,'SRP-350',7),(14,'SRP-350ii',7),(10,'SRP-350PLUSiii',6),(15,'SRP-375P',7),(165,'STP 131',42),(123,'Sure POS',24),(212,'SUREPOS500',53),(213,'SX2100',53),(177,'T-300',44),(140,'T1',31),(50,'T200',12),(81,'T200',15),(141,'T3',31),(69,'T88iii',15),(70,'T88iiiP',15),(82,'TM-200',15),(87,'TM-220',15),(96,'TM-300D',15),(63,'TM-82',15),(64,'TM-82ii',15),(71,'TM-88IV',15),(72,'TM-88V',15),(73,'TM-90',15),(106,'TM-H5000II',15),(107,'TM-H6000',15),(108,'TM-H6000ii',15),(109,'TM-J7100',15),(59,'TM-L60II',15),(56,'TM-T20',15),(58,'TM-T60',15),(60,'TM-T70',15),(61,'TM-T80P',15),(62,'TM-T81',15),(65,'TM-T85',15),(66,'TM-T88',15),(104,'TM-T883P',15),(67,'TM-T88II',15),(68,'TM-T88IIP',15),(83,'TM-U200B',15),(84,'TM-U200D',15),(86,'TM-U210D',15),(85,'TM-U210PD',15),(88,'TM-U220',15),(89,'TM-U220A',15),(91,'TM-U220B',15),(92,'TM-U220D',15),(90,'TM-U220PD',15),(94,'TM-U295',15),(98,'TM-U300PC',15),(99,'TM-U300PD',15),(100,'TM-U325D',15),(101,'TM-U375',15),(105,'TM-U950P',15),(121,'TP805',23),(137,'TP820',28),(208,'TRST-53',52),(209,'TRST-56',52),(207,'TRST-A10',52),(210,'TRST-A10',53),(211,'TRST-A15',53),(185,'TSP 100',49),(186,'TSP 100ii',49),(187,'TSP 100IIU',49),(146,'TSP-100',33),(195,'TSP-600',49),(196,'TSP-613',49),(197,'TSP-650',49),(203,'TSP-650',50),(198,'TSP-654iic',49),(199,'TSP-700',49),(200,'TSP-700ii',49),(201,'TSP-743ii',49),(191,'TSP200',49),(221,'U808',58),(224,'WTP-100',60),(228,'XP-350-B',62),(227,'XP-360',62),(226,'XP-C20-K',62),(154,'XR-200',40),(155,'XR-250',40),(156,'XR-500',40),(230,'ZJ-8200',63),(231,'ZJ-8250',63);
/*!40000 ALTER TABLE `printermodel` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_printermodel_BI` BEFORE INSERT ON `printermodel` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'printermodel' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_printermodel_BU` BEFORE UPDATE ON `printermodel` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'printermodel' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_printermodel_BD` BEFORE DELETE ON `printermodel` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'printermodel' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `printermodelcode`
--

DROP TABLE IF EXISTS `printermodelcode`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `printermodelcode` (
  `printerCodeid` int NOT NULL,
  `PrinterModelid` int NOT NULL,
  PRIMARY KEY (`printerCodeid`,`PrinterModelid`),
  KEY `FK_PrinterModelCode_PrinterModel_idx` (`PrinterModelid`),
  KEY `FK_PrinterModeCode_Printercode_idx` (`printerCodeid`),
  CONSTRAINT `FK_PrinterModelCode_Printercode` FOREIGN KEY (`printerCodeid`) REFERENCES `printercode` (`printerCodeid`),
  CONSTRAINT `FK_PrinterModelCode_PrinterModel` FOREIGN KEY (`PrinterModelid`) REFERENCES `printermodel` (`PrinterModelid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `printermodelcode`
--

LOCK TABLES `printermodelcode` WRITE;
/*!40000 ALTER TABLE `printermodelcode` DISABLE KEYS */;
INSERT INTO `printermodelcode` VALUES (1,1),(1,2),(1,3),(2,4),(5,4),(3,5),(6,5),(4,6),(8,7),(9,8),(10,9),(9,10),(11,11),(12,12),(9,13),(13,14),(11,15),(9,16),(14,17),(9,18),(14,19),(15,20),(14,21),(16,22),(16,23),(9,24),(17,25),(17,26),(17,27),(9,28),(18,29),(14,30),(17,31),(19,32),(21,32),(19,33),(21,33),(19,34),(21,34),(19,35),(21,35),(19,36),(21,36),(19,37),(21,37),(19,38),(21,38),(19,39),(21,39),(19,40),(21,40),(19,41),(21,41),(19,42),(21,42),(19,43),(21,43),(19,44),(21,44),(16,45),(1,46),(11,47),(15,48),(23,49),(19,50),(11,51),(24,52),(13,53),(19,54),(11,55),(25,56),(1,57),(25,58),(26,59),(27,60),(1,61),(1,62),(28,63),(28,64),(1,65),(30,66),(31,67),(27,68),(30,69),(32,70),(27,71),(11,72),(30,73),(1,74),(32,75),(1,76),(34,77),(34,78),(32,79),(32,80),(1,81),(12,82),(35,82),(36,83),(12,84),(35,85),(13,86),(1,87),(12,87),(1,88),(12,88),(35,89),(38,89),(1,90),(35,90),(38,90),(1,91),(35,92),(11,93),(11,94),(1,95),(23,96),(1,97),(11,97),(1,98),(1,99),(1,100),(1,101),(11,102),(11,103),(17,104),(9,105),(41,106),(42,106),(11,107),(11,108),(27,109),(43,110),(44,111),(9,112),(44,113),(13,114),(45,115),(46,116),(1,117),(47,118),(47,119),(47,120),(49,121),(19,122),(50,122),(49,123),(9,124),(9,125),(1,126),(19,126),(1,127),(19,127),(1,128),(19,128),(1,129),(51,130),(52,131),(52,132),(52,133),(53,134),(54,134),(51,135),(55,135),(52,136),(44,137),(1,138),(1,139),(11,140),(11,141),(56,142),(56,143),(56,144),(57,145),(58,146),(9,147),(1,148),(59,149),(60,150),(51,151),(61,152),(1,153),(23,154),(23,155),(23,156),(62,157),(1,158),(63,158),(1,159),(63,159),(1,160),(63,160),(1,161),(1,162),(1,163),(1,164),(65,165),(11,166),(1,167),(66,167),(12,168),(11,169),(11,170),(11,171),(67,172),(9,173),(14,174),(14,175),(14,176),(1,177),(9,178),(1,179),(11,180),(9,181),(11,182),(69,183),(70,184),(58,185),(19,186),(71,187),(70,188),(70,189),(70,190),(71,191),(71,192),(73,192),(73,193),(74,194),(75,195),(76,195),(19,196),(74,197),(70,198),(78,199),(13,200),(79,201),(73,202),(80,203),(70,204),(81,205),(82,206),(11,207),(82,208),(44,209),(11,210),(11,211),(49,212),(84,213),(82,214),(46,215),(46,216),(46,217),(47,218),(44,219),(9,220),(86,221),(44,222),(87,223),(87,224),(88,225),(89,226),(89,227),(89,228),(91,229),(92,230),(93,231),(9,232),(129,246),(130,246);
/*!40000 ALTER TABLE `printermodelcode` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_printermodelcode_BI` BEFORE INSERT ON `printermodelcode` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'printermodelcode' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_printermodelcode_BU` BEFORE UPDATE ON `printermodelcode` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'printermodelcode' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_printermodelcode_BD` BEFORE DELETE ON `printermodelcode` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'printermodelcode' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `supplier`
--

DROP TABLE IF EXISTS `supplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `supplier` (
  `supplierID` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `web` varchar(100) DEFAULT NULL,
  `phone` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`supplierID`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier`
--

LOCK TABLES `supplier` WRITE;
/*!40000 ALTER TABLE `supplier` DISABLE KEYS */;
INSERT INTO `supplier` VALUES (1,'7G BEER DISTRIBUTORS',NULL,NULL),(2,'ALCOHOLIC BEVERAGE DIVISION IOWA',NULL,NULL),(3,'ALDIS',NULL,NULL),(4,'AMANA SMOKEHOUSE',NULL,NULL),(5,'AMERIGAS',NULL,NULL),(6,'BEST CASE WINES',NULL,NULL),(7,'BUCHANAN HOUSE WINERY',NULL,NULL),(8,'CASK & CORK',NULL,NULL),(9,'CEDAR RIDGE WINERY',NULL,NULL),(10,'DELETED',NULL,NULL),(11,'DIMITRI WINES',NULL,NULL),(12,'FRESHIES',NULL,NULL),(13,'GLAZERS OF IOWA',NULL,NULL),(14,'GLOBAL WINES',NULL,NULL),(15,'GROOM WINES',NULL,NULL),(16,'HY-VEE/LOMAR',NULL,NULL),(17,'I-BEV',NULL,NULL),(18,'IA ALCOHOLIC BEVERAGES',NULL,NULL),(19,'JOHNSON BROTHERS',NULL,NULL),(20,'MILTON CREAMERY',NULL,NULL),(21,'NONE',NULL,NULL),(22,'OKOBOJI WINES',NULL,NULL),(23,'SAM\'S',NULL,NULL),(24,'THE SECRET CELLAR',NULL,NULL),(25,'WOODEN WHEEL WINERY',NULL,NULL),(32,'Johns','DirtyJohns.com','1112222444');
/*!40000 ALTER TABLE `supplier` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_supplier_BI` BEFORE INSERT ON `supplier` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'supplier' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_supplier_BU` BEFORE UPDATE ON `supplier` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'supplier' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_supplier_BD` BEFORE DELETE ON `supplier` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'supplier' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `tablelastchanged`
--

DROP TABLE IF EXISTS `tablelastchanged`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tablelastchanged` (
  `idTableLastChanged` int NOT NULL AUTO_INCREMENT,
  `Last_changed` datetime(6) NOT NULL,
  `TableName` varchar(100) NOT NULL,
  PRIMARY KEY (`idTableLastChanged`),
  UNIQUE KEY `TableName_UNIQUE` (`TableName`)
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tablelastchanged`
--

LOCK TABLES `tablelastchanged` WRITE;
/*!40000 ALTER TABLE `tablelastchanged` DISABLE KEYS */;
INSERT INTO `tablelastchanged` VALUES (1,'2021-10-28 20:53:44.282790','Customer'),(2,'2022-01-18 18:19:47.682908','customerfavorite'),(3,'2021-11-04 22:54:30.875010','customernote'),(4,'2022-04-19 10:09:47.851481','customerorder'),(5,'2021-10-26 22:00:04.000000','customerorderhist'),(6,'2022-04-07 20:12:53.263323','customerorderitem'),(7,'2022-04-07 20:12:53.263323','customerorderitemhist'),(8,'2022-03-29 18:43:44.448582','discount'),(9,'2022-04-19 10:09:46.564359','discount_inventory'),(10,'2022-03-29 18:43:12.548936','discount_type'),(11,'2022-04-19 19:04:54.206513','employee'),(12,'2022-04-07 20:45:57.900933','events'),(13,'2022-04-19 10:09:46.546613','inventory_description'),(14,'2022-04-19 10:09:46.552064','inventory_price'),(15,'2021-10-26 22:00:04.000000','inventory_quantity'),(16,'2022-03-29 18:43:12.707558','inventory_type'),(17,'2021-10-26 22:00:04.000000','notetype'),(18,'2022-01-11 19:26:32.367966','paymentmethod'),(19,'2022-04-07 20:47:44.383596','payments'),(20,'2021-10-26 22:00:04.000000','printercode'),(21,'2021-10-26 22:00:04.000000','printermake'),(22,'2021-10-26 22:00:04.000000','printermodel'),(23,'2021-10-26 22:00:04.000000','printermodelcode'),(24,'2021-10-26 22:00:04.000000','supplier'),(25,'2022-01-04 18:41:20.362895','tax'),(26,'2021-10-26 22:00:04.000000','tax_hist'),(27,'2022-04-12 20:39:38.660979','transaction'),(28,'2022-04-12 20:39:38.680096','transaction_items');
/*!40000 ALTER TABLE `tablelastchanged` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tax`
--

DROP TABLE IF EXISTS `tax`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tax` (
  `idTAX` int NOT NULL AUTO_INCREMENT,
  `bottle_deposit` double DEFAULT '0.05',
  `sales_tax` double DEFAULT '0.06',
  `local_sales_tax` double DEFAULT '0',
  `Tax_Name` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`idTAX`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tax`
--

LOCK TABLES `tax` WRITE;
/*!40000 ALTER TABLE `tax` DISABLE KEYS */;
INSERT INTO `tax` VALUES (1,0.05,0.06,0,'Default'),(2,0,0,0,'Food'),(3,0.05,0.06,0,'Bottle'),(4,0,0,0,'Event');
/*!40000 ALTER TABLE `tax` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_tax_BI` BEFORE INSERT ON `tax` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'tax' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_tax_BU` BEFORE UPDATE ON `tax` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'tax' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_tax_BD` BEFORE DELETE ON `tax` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'tax' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `tax_hist`
--

DROP TABLE IF EXISTS `tax_hist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tax_hist` (
  `idTAX` int NOT NULL,
  `bottle_deposit` double DEFAULT '0.05',
  `sales_tax` double DEFAULT '0.06',
  `local_sales_tax` double DEFAULT '0',
  `Tax_Name` varchar(20) DEFAULT NULL,
  `ChangeDate` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tax_hist`
--

LOCK TABLES `tax_hist` WRITE;
/*!40000 ALTER TABLE `tax_hist` DISABLE KEYS */;
/*!40000 ALTER TABLE `tax_hist` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_tax_hist_BI` BEFORE INSERT ON `tax_hist` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'tax_hist' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_tax_hist_BU` BEFORE UPDATE ON `tax_hist` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'tax_hist' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_tax_hist_BD` BEFORE DELETE ON `tax_hist` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'tax_hist' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `transaction`
--

DROP TABLE IF EXISTS `transaction`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `transaction` (
  `receiptID` int NOT NULL AUTO_INCREMENT,
  `register` int DEFAULT NULL,
  `sold_datetime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `empID` int DEFAULT '0',
  `customerID` int DEFAULT '0',
  `discount` double DEFAULT '0',
  `tax` double DEFAULT NULL,
  `paymentID` varchar(45) DEFAULT NULL,
  `location` varchar(50) DEFAULT NULL,
  `tax_exempt` tinyint DEFAULT '0',
  `shipping` double DEFAULT '0',
  `TranTypeid` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`receiptID`),
  KEY `fk_tr_empID_idx` (`empID`),
  KEY `fk_tr_customerID_idx` (`customerID`),
  KEY `fk_tr_tranTypeID_idx` (`TranTypeid`),
  CONSTRAINT `fk_tr_customerID` FOREIGN KEY (`customerID`) REFERENCES `customer` (`customerID`),
  CONSTRAINT `fk_tr_empID` FOREIGN KEY (`empID`) REFERENCES `employee` (`emp_id`),
  CONSTRAINT `fk_tr_tranTypeID` FOREIGN KEY (`TranTypeid`) REFERENCES `trantype` (`TranTypeID`)
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transaction`
--

LOCK TABLES `transaction` WRITE;
/*!40000 ALTER TABLE `transaction` DISABLE KEYS */;
INSERT INTO `transaction` VALUES (7,0,'2020-06-23 23:25:51',0,0,0,NULL,NULL,'Solon IA',0,0,0),(8,0,'2020-06-28 00:56:21',0,0,0,NULL,NULL,'string',0,0,0),(9,1,'2020-09-01 23:28:15',0,0,0,NULL,NULL,'',0,0,0),(10,1,'2020-09-01 23:29:09',0,0,0,NULL,NULL,'',0,0,0),(11,1,'2020-09-01 23:39:09',0,0,0,NULL,NULL,'',0,0,1),(12,1,'2020-09-01 23:39:09',0,0,0,NULL,NULL,'',0,0,1),(13,1,'2020-09-02 00:08:10',0,0,0,NULL,NULL,'',0,0,0),(14,1,'2020-11-24 17:26:30',0,0,0,NULL,NULL,'',0,0,0),(17,1,'2021-03-02 20:11:29',0,2,0,NULL,NULL,'',0,0,1),(18,1,'2021-03-09 20:23:31',0,0,0,NULL,NULL,'',0,0,1),(19,1,'2021-04-08 18:43:53',0,1,0,NULL,NULL,'',0,0,0),(20,1,'2021-05-04 19:15:46',0,0,0,NULL,NULL,'',0,0,0),(21,1,'2021-05-04 19:21:15',0,3,0,NULL,NULL,'',0,0,0),(22,1,'2021-05-04 19:26:56',0,0,0,NULL,NULL,'',0,0,0),(23,1,'2021-05-04 19:39:24',0,0,0,NULL,NULL,'',0,0,0),(24,1,'2021-05-04 19:40:28',0,0,0,NULL,NULL,'',0,0,0),(25,1,'2021-11-23 18:29:34',0,0,0,NULL,NULL,'',0,0,0),(26,1,'2021-11-23 18:36:42',0,0,0,NULL,NULL,'',0,0,0),(27,1,'2021-12-07 20:26:29',0,0,0,NULL,NULL,'',0,0,0),(28,1,'2021-12-16 20:11:22',0,0,0.1,NULL,NULL,'',0,0,0),(29,1,'2022-01-04 19:39:38',0,0,0,NULL,NULL,'',1,0,0),(30,1,'2022-01-04 19:53:55',0,0,0,NULL,NULL,'',1,0,0),(31,1,'2022-01-04 20:05:33',0,0,0,NULL,NULL,'',0,0,0),(32,1,'2022-01-13 20:34:07',0,0,0,NULL,NULL,'',1,0,0),(34,1,'2022-01-27 18:41:59',0,0,0,NULL,NULL,'',0,0,0),(38,1,'2022-02-15 18:56:48',0,3,0,NULL,NULL,'',0,0,1),(42,1,'2022-03-01 19:08:15',0,0,0,NULL,NULL,'',0,0,0),(43,1,'2022-04-05 19:34:15',0,0,0,NULL,NULL,'',0,0,1),(44,1,'2022-04-05 20:07:21',0,0,0,NULL,NULL,'',0,0,0),(45,1,'2022-04-07 18:47:22',0,1,0,NULL,NULL,'',0,0,2),(46,1,'2022-04-07 20:12:53',0,3,0,NULL,NULL,'',0,0,2),(47,1,'2022-04-07 20:44:32',0,0,0,NULL,NULL,'',0,0,0);
/*!40000 ALTER TABLE `transaction` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_transaction_BI` BEFORE INSERT ON `transaction` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'transaction' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_transaction_BU` BEFORE UPDATE ON `transaction` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'transaction' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_transaction_BD` BEFORE DELETE ON `transaction` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'transaction' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `transaction_items`
--

DROP TABLE IF EXISTS `transaction_items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `transaction_items` (
  `receiptID` int NOT NULL,
  `inventoryID` int NOT NULL,
  `sold_price` double NOT NULL,
  `supplier_price` double NOT NULL,
  `sold_qty` double NOT NULL,
  `Refunded_Qty` int DEFAULT NULL,
  PRIMARY KEY (`receiptID`,`inventoryID`,`sold_price`),
  KEY `inventoryID` (`inventoryID`) /*!80000 INVISIBLE */,
  KEY `receiptID` (`receiptID`) /*!80000 INVISIBLE */,
  CONSTRAINT `fk_tr_items_inventoryID` FOREIGN KEY (`inventoryID`) REFERENCES `inventory_description` (`inventoryID`),
  CONSTRAINT `fk_tr_items_receiptID` FOREIGN KEY (`receiptID`) REFERENCES `transaction` (`receiptID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transaction_items`
--

LOCK TABLES `transaction_items` WRITE;
/*!40000 ALTER TABLE `transaction_items` DISABLE KEYS */;
INSERT INTO `transaction_items` VALUES (7,1030,190,100,3,NULL),(8,1036,13.99,10,1,NULL),(9,1541,40,20,1,NULL),(10,1541,40,20,1,NULL),(11,1541,40,20,1,NULL),(12,1541,40,20,1,NULL),(13,2210,10.99,10.99,1,NULL),(14,2165,11.99,11.99,1,NULL),(17,1251,3.99,3.99,1,NULL),(18,2230,19.99,19.99,1,NULL),(23,1424,1,1,1,NULL),(24,1024,10.99,10.99,1,NULL),(24,1045,1,1,1,NULL),(24,1062,1.89,1.89,1,NULL),(24,1063,1.89,1.89,1,NULL),(24,1064,1.5,1.5,1,NULL),(24,1065,1.5,1.5,1,NULL),(24,1097,2.99,2.99,1,NULL),(24,1102,4.99,4.99,1,NULL),(24,1114,3.99,3.99,1,NULL),(24,1115,3.99,3.99,1,NULL),(24,1116,23.99,23.99,1,NULL),(24,1117,19.99,19.99,1,NULL),(24,1118,16,16,1,NULL),(24,1124,1.99,1.99,1,NULL),(24,1126,12.99,12.99,1,NULL),(24,1127,12.99,12.99,1,NULL),(24,1128,12.99,12.99,1,NULL),(24,1139,9.99,9.99,1,NULL),(24,1140,1.99,1.99,1,NULL),(24,1141,4.99,4.99,1,NULL),(24,1142,35.99,35.99,1,NULL),(24,1143,12.99,12.99,1,NULL),(24,1340,2.99,2.99,1,NULL),(24,1419,2.69,2.69,1,NULL),(24,1541,40,20,1,NULL),(24,1715,5.75,5.75,1,NULL),(24,1803,26.6,26.6,1,NULL),(24,2293,12.99,12.99,1,NULL),(24,2341,16.06,16.06,1,NULL),(24,2380,16.99,16.99,1,NULL),(24,2438,10.99,10.99,1,NULL),(24,2861,5.99,5.99,1,NULL),(25,2339,22.99,20.99,5,NULL),(26,3464,7.99,0,1,NULL),(27,3941,7.99,5,1,NULL),(28,1911,49.99,49.99,1,NULL),(28,2381,2.99,2.99,1,NULL),(28,3523,51.99,0,1,NULL),(29,1672,10.99,10.99,1,1),(30,1541,20,20,1,1),(30,4449,1,0,1,0),(31,1541,38.8,20,1,NULL),(32,3630,38.99,0,1,NULL),(34,2873,4.44,0,1,NULL),(38,1879,79.99,0,6,6),(38,2524,26.83,0,6,6),(38,2527,18.99,0,4,4),(38,4388,39.99,0,3,2),(38,4449,1,0,1,0),(38,4449,1.8,0,1,0),(42,1541,38.8,20,1,NULL),(43,1447,61.99,59.8,1,0),(44,3604,65.99,0,1,0),(45,4315,21.99,0,2,0),(46,2462,14.99,0,10,0),(47,4448,10,5,5,0);
/*!40000 ALTER TABLE `transaction_items` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_transaction_items_BI` BEFORE INSERT ON `transaction_items` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'transaction_items' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_transaction_items_BU` BEFORE UPDATE ON `transaction_items` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'transaction_items' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `TRG_transaction_items_BD` BEFORE DELETE ON `transaction_items` FOR EACH ROW UPDATE TableLastchanged SET Last_Changed = NOW(6) WHERE TableName= 'transaction_items' */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `trantype`
--

DROP TABLE IF EXISTS `trantype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `trantype` (
  `TranTypeID` tinyint(1) NOT NULL,
  `TranTypeName` varchar(45) NOT NULL,
  PRIMARY KEY (`TranTypeID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trantype`
--

LOCK TABLES `trantype` WRITE;
/*!40000 ALTER TABLE `trantype` DISABLE KEYS */;
INSERT INTO `trantype` VALUES (0,'Closed'),(1,'Suspended'),(2,'Invoice'),(3,'Hold');
/*!40000 ALTER TABLE `trantype` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `v_customer`
--

DROP TABLE IF EXISTS `v_customer`;
/*!50001 DROP VIEW IF EXISTS `v_customer`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_customer` AS SELECT 
 1 AS `customerID`,
 1 AS `customer_discount`,
 1 AS `first_name`,
 1 AS `last_name`,
 1 AS `business_name`,
 1 AS `email`,
 1 AS `isWholesale`,
 1 AS `addr1`,
 1 AS `addr2`,
 1 AS `city`,
 1 AS `state`,
 1 AS `zip`,
 1 AS `phone`,
 1 AS `credit`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_customer_hash`
--

DROP TABLE IF EXISTS `v_customer_hash`;
/*!50001 DROP VIEW IF EXISTS `v_customer_hash`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_customer_hash` AS SELECT 
 1 AS `HashValue`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_customerfavorite`
--

DROP TABLE IF EXISTS `v_customerfavorite`;
/*!50001 DROP VIEW IF EXISTS `v_customerfavorite`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_customerfavorite` AS SELECT 
 1 AS `InventoryID`,
 1 AS `CustomerID`,
 1 AS `LastRequestDate`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_customernotes`
--

DROP TABLE IF EXISTS `v_customernotes`;
/*!50001 DROP VIEW IF EXISTS `v_customernotes`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_customernotes` AS SELECT 
 1 AS `CustomerNoteID`,
 1 AS `CustomerID`,
 1 AS `NoteTypeID`,
 1 AS `Note`,
 1 AS `NoteDate`,
 1 AS `NoteType`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_customerorder`
--

DROP TABLE IF EXISTS `v_customerorder`;
/*!50001 DROP VIEW IF EXISTS `v_customerorder`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_customerorder` AS SELECT 
 1 AS `CustomerOrderItemID`,
 1 AS `Customer_Discount`,
 1 AS `InventoryID`,
 1 AS `name`,
 1 AS `RequestQTY`,
 1 AS `OrderQTY`,
 1 AS `Paid`,
 1 AS `Inventory_qty`,
 1 AS `DeliverQTY`,
 1 AS `CustomerID`,
 1 AS `RequestDate`,
 1 AS `DeliverDate`,
 1 AS `itemDeliverDate`,
 1 AS `First_name`,
 1 AS `inventory_type_name`,
 1 AS `Last_name`,
 1 AS `Business_name`,
 1 AS `isWholesale`,
 1 AS `Bottle_Deposit`,
 1 AS `barcode`,
 1 AS `price`,
 1 AS `paiddate`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_customerwithbalance`
--

DROP TABLE IF EXISTS `v_customerwithbalance`;
/*!50001 DROP VIEW IF EXISTS `v_customerwithbalance`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_customerwithbalance` AS SELECT 
 1 AS `customerID`,
 1 AS `customer_discount`,
 1 AS `first_name`,
 1 AS `last_name`,
 1 AS `business_name`,
 1 AS `email`,
 1 AS `isWholesale`,
 1 AS `addr1`,
 1 AS `addr2`,
 1 AS `city`,
 1 AS `state`,
 1 AS `zip`,
 1 AS `phone`,
 1 AS `credit`,
 1 AS `balancedue`,
 1 AS `suspendedTransactions`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_discount`
--

DROP TABLE IF EXISTS `v_discount`;
/*!50001 DROP VIEW IF EXISTS `v_discount`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_discount` AS SELECT 
 1 AS `DiscountID`,
 1 AS `DiscountName`,
 1 AS `minQty`,
 1 AS `maxQty`,
 1 AS `Discount`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_employee`
--

DROP TABLE IF EXISTS `v_employee`;
/*!50001 DROP VIEW IF EXISTS `v_employee`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_employee` AS SELECT 
 1 AS `roleId`,
 1 AS `typeID`,
 1 AS `emp_id`,
 1 AS `pin_number`,
 1 AS `first_name`,
 1 AS `last_name`,
 1 AS `email`,
 1 AS `addr1`,
 1 AS `addr2`,
 1 AS `city`,
 1 AS `state`,
 1 AS `zip`,
 1 AS `phone`,
 1 AS `typeName`,
 1 AS `roleName`,
 1 AS `roleDescription`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_event`
--

DROP TABLE IF EXISTS `v_event`;
/*!50001 DROP VIEW IF EXISTS `v_event`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_event` AS SELECT 
 1 AS `inventoryID`,
 1 AS `name`,
 1 AS `barcode`,
 1 AS `nontaxable`,
 1 AS `nontaxable_local`,
 1 AS `retail_price`,
 1 AS `typeID`,
 1 AS `inventory_type_name`,
 1 AS `inventory_qty`,
 1 AS `sales_tax`,
 1 AS `local_sales_tax`,
 1 AS `purchased_Date`,
 1 AS `supplier_price`,
 1 AS `PreOrder`,
 1 AS `PreOrderSold`,
 1 AS `PreOrderProfit`,
 1 AS `AtDoor`,
 1 AS `AtDoorSold`,
 1 AS `AtDoorProfit`,
 1 AS `Duration`,
 1 AS `EventDate`,
 1 AS `idTax`,
 1 AS `Tax_Name`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_inventory`
--

DROP TABLE IF EXISTS `v_inventory`;
/*!50001 DROP VIEW IF EXISTS `v_inventory`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_inventory` AS SELECT 
 1 AS `inventoryID`,
 1 AS `description`,
 1 AS `name`,
 1 AS `barcode`,
 1 AS `retail_price`,
 1 AS `bottles`,
 1 AS `nontaxable`,
 1 AS `nontaxable_local`,
 1 AS `typeID`,
 1 AS `hidden`,
 1 AS `inventory_type_name`,
 1 AS `supplierID`,
 1 AS `invMin`,
 1 AS `invMax`,
 1 AS `orderQty`,
 1 AS `RequestQty`,
 1 AS `inventory_qty`,
 1 AS `RequiredQty`,
 1 AS `Orderincrement`,
 1 AS `supplier`,
 1 AS `supplier_price`,
 1 AS `purchased_date`,
 1 AS `idTax`,
 1 AS `bottle_deposit`,
 1 AS `sales_tax`,
 1 AS `local_sales_tax`,
 1 AS `Tax_Name`,
 1 AS `DiscountID`,
 1 AS `DiscountName`,
 1 AS `minQty`,
 1 AS `maxQty`,
 1 AS `Discount`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_inventory_hash`
--

DROP TABLE IF EXISTS `v_inventory_hash`;
/*!50001 DROP VIEW IF EXISTS `v_inventory_hash`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_inventory_hash` AS SELECT 
 1 AS `HashValue`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_printer`
--

DROP TABLE IF EXISTS `v_printer`;
/*!50001 DROP VIEW IF EXISTS `v_printer`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_printer` AS SELECT 
 1 AS `CodeId`,
 1 AS `Modelid`,
 1 AS `MakeID`,
 1 AS `MakeName`,
 1 AS `Modelname`,
 1 AS `Drawer`,
 1 AS `Cutter`,
 1 AS `PartialCutter`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_suspendedtransaction`
--

DROP TABLE IF EXISTS `v_suspendedtransaction`;
/*!50001 DROP VIEW IF EXISTS `v_suspendedtransaction`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_suspendedtransaction` AS SELECT 
 1 AS `receiptID`,
 1 AS `TotalSale`,
 1 AS `TotalPayment`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_tax`
--

DROP TABLE IF EXISTS `v_tax`;
/*!50001 DROP VIEW IF EXISTS `v_tax`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_tax` AS SELECT 
 1 AS `idTAX`,
 1 AS `bottle_deposit`,
 1 AS `sales_tax`,
 1 AS `local_sales_tax`,
 1 AS `Tax_Name`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_transaction_items`
--

DROP TABLE IF EXISTS `v_transaction_items`;
/*!50001 DROP VIEW IF EXISTS `v_transaction_items`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_transaction_items` AS SELECT 
 1 AS `receiptID`,
 1 AS `name`,
 1 AS `InventoryID`,
 1 AS `barcode`,
 1 AS `sold_qty`,
 1 AS `refunded_qty`,
 1 AS `sold_price`,
 1 AS `supplier_price`,
 1 AS `bottles`,
 1 AS `inventory_type_name`,
 1 AS `nontaxable`,
 1 AS `nontaxable_local`,
 1 AS `inventory_qty`,
 1 AS `bottle_deposit`,
 1 AS `sales_tax`,
 1 AS `local_sales_tax`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_type`
--

DROP TABLE IF EXISTS `v_type`;
/*!50001 DROP VIEW IF EXISTS `v_type`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_type` AS SELECT 
 1 AS `idTax`,
 1 AS `DiscountID`,
 1 AS `typeID`,
 1 AS `inventory_type_name`,
 1 AS `min_qty`,
 1 AS `max_qty`,
 1 AS `bottles`,
 1 AS `Increment_qty`,
 1 AS `DiscountName`,
 1 AS `minQty`,
 1 AS `maxQty`,
 1 AS `Discount`,
 1 AS `bottle_deposit`,
 1 AS `sales_tax`,
 1 AS `local_sales_tax`,
 1 AS `Tax_Name`*/;
SET character_set_client = @saved_cs_client;

--
-- Dumping events for database 'inventory'
--

--
-- Dumping routines for database 'inventory'
--
/*!50003 DROP PROCEDURE IF EXISTS `test2` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `test2`()
BEGIN 
   DECLARE invoice_count int;
   
   SELECT COUNT(*)
   INTO invoice_count
   FROM invoices
   WHERE (invoice_total - payment_total - credit_total) >= 5000;
   
   SELECT CONCAT(invoice_count,   ' invoices >= $5000') as return_value;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `inventory_quantity`
--

/*!50001 DROP VIEW IF EXISTS `inventory_quantity`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `inventory_quantity` AS select 1 AS `item_name`,1 AS `inventoryID`,1 AS `quantity`,1 AS `barcode`,1 AS `retail_price`,1 AS `supplierID`,1 AS `item_description`,1 AS `typeID`,1 AS `bottle_deposit_qty`,1 AS `nontaxable`,1 AS `nontaxable_local` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_customer`
--

/*!50001 DROP VIEW IF EXISTS `v_customer`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_customer` AS select `customer`.`customerID` AS `customerID`,`customer`.`customer_discount` AS `customer_discount`,`customer`.`first_name` AS `first_name`,`customer`.`last_name` AS `last_name`,`customer`.`business_name` AS `business_name`,`customer`.`email` AS `email`,`customer`.`isWholesale` AS `isWholesale`,`customer`.`addr1` AS `addr1`,`customer`.`addr2` AS `addr2`,`customer`.`city` AS `city`,`customer`.`state` AS `state`,`customer`.`zip` AS `zip`,`customer`.`phone` AS `phone`,`customer`.`credit` AS `credit` from `customer` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_customer_hash`
--

/*!50001 DROP VIEW IF EXISTS `v_customer_hash`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_customer_hash` AS select md5(group_concat(concat_ws('#',`customer`.`customerID`,`customer`.`customer_discount`,`customer`.`first_name`,`customer`.`last_name`,`customer`.`business_name`,`customer`.`credit`) separator '##')) AS `HashValue` from `customer` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_customerfavorite`
--

/*!50001 DROP VIEW IF EXISTS `v_customerfavorite`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_customerfavorite` AS select `customerfavorite`.`InventoryID` AS `InventoryID`,`customer`.`customerID` AS `CustomerID`,max(`v_customerorder`.`RequestDate`) AS `LastRequestDate` from (((`customer` left join `customerfavorite` on((`customer`.`customerID` = `customerfavorite`.`CustomerID`))) left join `inventory_description` on((`customerfavorite`.`InventoryID` = `inventory_description`.`inventoryID`))) left join `v_customerorder` on(((`customerfavorite`.`InventoryID` = `v_customerorder`.`InventoryID`) and (`customer`.`customerID` = `v_customerorder`.`CustomerID`)))) group by `customerfavorite`.`InventoryID`,`customer`.`customerID` order by `customer`.`customerID` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_customernotes`
--

/*!50001 DROP VIEW IF EXISTS `v_customernotes`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_customernotes` AS select `customernote`.`CustomerNoteID` AS `CustomerNoteID`,`customernote`.`CustomerID` AS `CustomerID`,`customernote`.`NoteTypeID` AS `NoteTypeID`,`customernote`.`Note` AS `Note`,`customernote`.`NoteDate` AS `NoteDate`,`notetype`.`NoteType` AS `NoteType` from (`customernote` join `notetype` on((`customernote`.`NoteTypeID` = `notetype`.`NoteTypeID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_customerorder`
--

/*!50001 DROP VIEW IF EXISTS `v_customerorder`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_customerorder` AS select distinct `i`.`CustomerOrderItemID` AS `CustomerOrderItemID`,`c`.`customer_discount` AS `Customer_Discount`,`i`.`InventoryID` AS `InventoryID`,`d`.`name` AS `name`,`i`.`RequestQTY` AS `RequestQTY`,`d`.`orderQty` AS `OrderQTY`,`i`.`Paid` AS `Paid`,`d`.`inventory_qty` AS `Inventory_qty`,`i`.`DeliverQTY` AS `DeliverQTY`,`i`.`CustomerID` AS `CustomerID`,`i`.`RequestDate` AS `RequestDate`,`i`.`Deliverdate` AS `DeliverDate`,`i`.`Deliverdate` AS `itemDeliverDate`,`c`.`first_name` AS `First_name`,`d`.`inventory_type_name` AS `inventory_type_name`,`c`.`last_name` AS `Last_name`,`c`.`business_name` AS `Business_name`,`c`.`isWholesale` AS `isWholesale`,`d`.`bottle_deposit` AS `Bottle_Deposit`,`d`.`barcode` AS `barcode`,`i`.`Price` AS `price`,`i`.`PaidDate` AS `paiddate` from ((`customerorderitem` `i` join `v_inventory` `d` on((`i`.`InventoryID` = `d`.`inventoryID`))) join `customer` `c` on((`i`.`CustomerID` = `c`.`customerID`))) order by `i`.`CustomerID`,`i`.`CustomerOrderItemID` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_customerwithbalance`
--

/*!50001 DROP VIEW IF EXISTS `v_customerwithbalance`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_customerwithbalance` AS select `customer`.`customerID` AS `customerID`,`customer`.`customer_discount` AS `customer_discount`,`customer`.`first_name` AS `first_name`,`customer`.`last_name` AS `last_name`,`customer`.`business_name` AS `business_name`,`customer`.`email` AS `email`,`customer`.`isWholesale` AS `isWholesale`,`customer`.`addr1` AS `addr1`,`customer`.`addr2` AS `addr2`,`customer`.`city` AS `city`,`customer`.`state` AS `state`,`customer`.`zip` AS `zip`,`customer`.`phone` AS `phone`,`customer`.`credit` AS `credit`,`a`.`balancedue` AS `balancedue`,`a`.`suspendedTransactions` AS `suspendedTransactions` from (`customer` left join (select `transaction`.`customerID` AS `customerID`,ifnull(sum((`v_suspendedtransaction`.`TotalSale` - `v_suspendedtransaction`.`TotalPayment`)),0) AS `balancedue`,count(distinct `transaction`.`receiptID`) AS `suspendedTransactions` from (`transaction` join `v_suspendedtransaction` on((`transaction`.`receiptID` = `v_suspendedtransaction`.`receiptID`))) group by `transaction`.`customerID`) `a` on((`customer`.`customerID` = `a`.`customerID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_discount`
--

/*!50001 DROP VIEW IF EXISTS `v_discount`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`invuser`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_discount` AS select `discount`.`DiscountID` AS `DiscountID`,`discount`.`DiscountName` AS `DiscountName`,`discount`.`minQty` AS `minQty`,`discount`.`maxQty` AS `maxQty`,`discount`.`Discount` AS `Discount` from `discount` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_employee`
--

/*!50001 DROP VIEW IF EXISTS `v_employee`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_employee` AS select `employeetyperole`.`roleId` AS `roleId`,`employee`.`typeID` AS `typeID`,`employee`.`emp_id` AS `emp_id`,`employee`.`pin_number` AS `pin_number`,`employee`.`first_name` AS `first_name`,`employee`.`last_name` AS `last_name`,`employee`.`email` AS `email`,`employee`.`addr1` AS `addr1`,`employee`.`addr2` AS `addr2`,`employee`.`city` AS `city`,`employee`.`state` AS `state`,`employee`.`zip` AS `zip`,`employee`.`phone` AS `phone`,`employeetype`.`typeName` AS `typeName`,`employeerole`.`roleName` AS `roleName`,`employeerole`.`roleDescription` AS `roleDescription` from (((`employee` left join `employeetype` on((`employee`.`typeID` = `employeetype`.`typeId`))) left join `employeetyperole` on((`employee`.`typeID` = `employeetyperole`.`typeId`))) left join `employeerole` on((`employeetyperole`.`roleId` = `employeerole`.`roleId`))) order by `employee`.`emp_id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_event`
--

/*!50001 DROP VIEW IF EXISTS `v_event`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_event` AS select `i`.`inventoryID` AS `inventoryID`,`i`.`name` AS `name`,`i`.`barcode` AS `barcode`,`i`.`nontaxable` AS `nontaxable`,`i`.`nontaxable_local` AS `nontaxable_local`,`i`.`retail_price` AS `retail_price`,`i`.`typeID` AS `typeID`,`t`.`inventory_type_name` AS `inventory_type_name`,`ip`.`inventory_qty` AS `inventory_qty`,`c`.`sales_tax` AS `sales_tax`,`c`.`local_sales_tax` AS `local_sales_tax`,`ip`.`purchased_date` AS `purchased_Date`,`ip`.`supplier_price` AS `supplier_price`,`e`.`Preorder` AS `PreOrder`,sum(if(((`ti`.`sold_price` <> `e`.`AtDoor`) and (`ti`.`sold_price` is not null)),`ti`.`sold_qty`,0)) AS `PreOrderSold`,sum(if(((`ti`.`sold_price` <> `e`.`AtDoor`) and (`ti`.`sold_price` is not null)),(`ti`.`sold_price` * `ti`.`sold_qty`),0)) AS `PreOrderProfit`,`e`.`AtDoor` AS `AtDoor`,sum(if(((`ti`.`sold_price` = `e`.`AtDoor`) and (`ti`.`sold_price` is not null)),`ti`.`sold_qty`,0)) AS `AtDoorSold`,sum(if(((`ti`.`sold_price` = `e`.`AtDoor`) and (`ti`.`sold_price` is not null)),(`ti`.`sold_price` * `ti`.`sold_qty`),0)) AS `AtDoorProfit`,`e`.`Duration` AS `Duration`,`e`.`EventDate` AS `EventDate`,`c`.`idTAX` AS `idTax`,`c`.`Tax_Name` AS `Tax_Name` from (((((`inventory_description` `i` join `inventory_type` `t` on((`i`.`typeID` = `t`.`typeID`))) join `tax` `c` on((`c`.`idTAX` = `t`.`idTax`))) join `events` `e` on((`i`.`inventoryID` = `e`.`inventoryID`))) join `inventory_price` `ip` on((`i`.`inventoryID` = `ip`.`inventoryID`))) left join `transaction_items` `ti` on((`i`.`inventoryID` = `ti`.`inventoryID`))) group by `i`.`inventoryID`,`i`.`name`,`i`.`barcode`,`i`.`nontaxable`,`i`.`nontaxable_local`,`i`.`retail_price`,`i`.`typeID`,`t`.`inventory_type_name`,`ip`.`inventory_qty`,`c`.`sales_tax`,`c`.`local_sales_tax`,`ip`.`purchased_date`,`ip`.`supplier_price`,`e`.`Preorder`,`e`.`AtDoor`,`e`.`Duration`,`e`.`EventDate`,`c`.`idTAX`,`c`.`Tax_Name` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_inventory`
--

/*!50001 DROP VIEW IF EXISTS `v_inventory`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_inventory` AS select `i`.`inventoryID` AS `inventoryID`,`i`.`description` AS `description`,`i`.`name` AS `name`,`i`.`barcode` AS `barcode`,`i`.`retail_price` AS `retail_price`,`i`.`bottles` AS `bottles`,`i`.`nontaxable` AS `nontaxable`,`i`.`nontaxable_local` AS `nontaxable_local`,`i`.`typeID` AS `typeID`,`i`.`hidden` AS `hidden`,`i`.`inventory_type_name` AS `inventory_type_name`,`i`.`supplierID` AS `supplierID`,`i`.`invMin` AS `invMin`,`i`.`invMax` AS `invMax`,`i`.`orderQty` AS `orderQty`,`i`.`RequestQty` AS `RequestQty`,`i`.`inventory_qty` AS `inventory_qty`,`i`.`RequiredQty` AS `RequiredQty`,`i`.`Orderincrement` AS `Orderincrement`,`i`.`supplier` AS `supplier`,`i`.`supplier_price` AS `supplier_price`,`i`.`purchased_date` AS `purchased_date`,`i`.`idTax` AS `idTax`,`i`.`bottle_deposit` AS `bottle_deposit`,`i`.`sales_tax` AS `sales_tax`,`i`.`local_sales_tax` AS `local_sales_tax`,`i`.`Tax_Name` AS `Tax_Name`,`discount_inventory`.`DiscountID` AS `DiscountID`,`d`.`DiscountName` AS `DiscountName`,`d`.`minQty` AS `minQty`,`d`.`maxQty` AS `maxQty`,`d`.`Discount` AS `Discount` from (((select `i`.`inventoryID` AS `inventoryID`,`i`.`description` AS `description`,`i`.`name` AS `name`,`i`.`barcode` AS `barcode`,`i`.`retail_price` AS `retail_price`,`i`.`bottle_deposit_qty` AS `bottles`,`i`.`nontaxable` AS `nontaxable`,`i`.`nontaxable_local` AS `nontaxable_local`,`i`.`typeID` AS `typeID`,`i`.`hidden` AS `hidden`,`t`.`inventory_type_name` AS `inventory_type_name`,`i`.`supplierID` AS `supplierID`,`i`.`InvMin` AS `invMin`,`i`.`InvMax` AS `invMax`,`i`.`OrderQty` AS `orderQty`,ifnull(`r`.`requestQty`,0) AS `RequestQty`,`ip`.`inventory_qty` AS `inventory_qty`,ifnull(if((((sum(`ip`.`inventory_qty`) OVER `w` + `i`.`OrderQty`) - ifnull(`r`.`requestQty`,0)) > `i`.`InvMin`),0,(((((`i`.`InvMax` - sum(`ip`.`inventory_qty`) OVER `w`) - `i`.`OrderQty`) + ifnull(`r`.`requestQty`,0)) DIV greatest(`i`.`orderIncrement`,1)) + if((((((`i`.`InvMax` - sum(`ip`.`inventory_qty`) OVER `w`) - `i`.`OrderQty`) + ifnull(`r`.`requestQty`,0)) % greatest(`i`.`orderIncrement`,1)) > 0),greatest(`i`.`orderIncrement`,1),0))),0) AS `RequiredQty`,`i`.`orderIncrement` AS `Orderincrement`,`s`.`name` AS `supplier`,`ip`.`supplier_price` AS `supplier_price`,`ip`.`purchased_date` AS `purchased_date`,`t`.`idTax` AS `idTax`,`c`.`bottle_deposit` AS `bottle_deposit`,`c`.`sales_tax` AS `sales_tax`,`c`.`local_sales_tax` AS `local_sales_tax`,`c`.`Tax_Name` AS `Tax_Name` from (((((`inventory_description` `i` join `inventory_type` `t` on((`i`.`typeID` = `t`.`typeID`))) join `tax` `c` on((`c`.`idTAX` = `t`.`idTax`))) left join `inventory_price` `ip` on((`i`.`inventoryID` = `ip`.`inventoryID`))) left join `supplier` `s` on((`i`.`supplierID` = `s`.`supplierID`))) left join (select `customerorderitem`.`InventoryID` AS `InventoryId`,sum((`customerorderitem`.`RequestQTY` - `customerorderitem`.`DeliverQTY`)) AS `requestQty` from `customerorderitem` where ((`customerorderitem`.`RequestQTY` - `customerorderitem`.`DeliverQTY`) > 0) group by `customerorderitem`.`InventoryID`) `r` on((`r`.`InventoryId` = `i`.`inventoryID`))) window `w` AS (PARTITION BY `i`.`inventoryID` ) ) `i` left join `discount_inventory` on((`i`.`inventoryID` = `discount_inventory`.`InventoryID`))) left join `discount` `d` on((`discount_inventory`.`DiscountID` = `d`.`DiscountID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_inventory_hash`
--

/*!50001 DROP VIEW IF EXISTS `v_inventory_hash`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_inventory_hash` AS select date_format(max(`tablelastchanged`.`Last_changed`),'%Y%m%d%H%i%S%f') AS `HashValue` from `tablelastchanged` where (`tablelastchanged`.`TableName` in ('inventory_description','inventory_type','inventory_price','supplier','customerorderitem')) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_printer`
--

/*!50001 DROP VIEW IF EXISTS `v_printer`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_printer` AS select `printercode`.`printerCodeid` AS `CodeId`,`printermodel`.`PrinterModelid` AS `Modelid`,`printermake`.`printerMakeID` AS `MakeID`,`printermake`.`printerMakeName` AS `MakeName`,`printermodel`.`PrinterModelname` AS `Modelname`,`printercode`.`Drawer` AS `Drawer`,`printercode`.`Cutter` AS `Cutter`,`printercode`.`PartialCutter` AS `PartialCutter` from (((`printermake` join `printermodel` on((`printermake`.`printerMakeID` = `printermodel`.`printerMakeID`))) left join `printermodelcode` on((`printermodel`.`PrinterModelid` = `printermodelcode`.`PrinterModelid`))) left join `printercode` on((`printermodelcode`.`printerCodeid` = `printercode`.`printerCodeid`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_suspendedtransaction`
--

/*!50001 DROP VIEW IF EXISTS `v_suspendedtransaction`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_suspendedtransaction` AS select `transaction`.`receiptID` AS `receiptID`,sum(`transaction_items`.`sold_price`) AS `TotalSale`,sum(`payments`.`Amount`) AS `TotalPayment` from (((`transaction` left join `transaction_items` on((`transaction`.`receiptID` = `transaction_items`.`receiptID`))) left join `payments` on((`transaction`.`receiptID` = `payments`.`ReceiptID`))) left join `trantype` on((`transaction`.`TranTypeid` = `trantype`.`TranTypeID`))) where (`trantype`.`TranTypeName` = 'Suspended') group by `transaction`.`receiptID` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_tax`
--

/*!50001 DROP VIEW IF EXISTS `v_tax`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_tax` AS select `tax`.`idTAX` AS `idTAX`,`tax`.`bottle_deposit` AS `bottle_deposit`,`tax`.`sales_tax` AS `sales_tax`,`tax`.`local_sales_tax` AS `local_sales_tax`,`tax`.`Tax_Name` AS `Tax_Name` from `tax` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_transaction_items`
--

/*!50001 DROP VIEW IF EXISTS `v_transaction_items`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_transaction_items` AS select `ti`.`receiptID` AS `receiptID`,`i`.`name` AS `name`,`ti`.`inventoryID` AS `InventoryID`,`i`.`barcode` AS `barcode`,`ti`.`sold_qty` AS `sold_qty`,`ti`.`Refunded_Qty` AS `refunded_qty`,`ti`.`sold_price` AS `sold_price`,`ti`.`supplier_price` AS `supplier_price`,`i`.`bottle_deposit_qty` AS `bottles`,`t`.`inventory_type_name` AS `inventory_type_name`,`i`.`nontaxable` AS `nontaxable`,`i`.`nontaxable_local` AS `nontaxable_local`,`ip`.`inventory_qty` AS `inventory_qty`,`tx`.`bottle_deposit` AS `bottle_deposit`,`tx`.`sales_tax` AS `sales_tax`,`tx`.`local_sales_tax` AS `local_sales_tax` from (((((`transaction_items` `ti` join `inventory_description` `i` on((`ti`.`inventoryID` = `i`.`inventoryID`))) left join `inventory_type` `t` on((`i`.`typeID` = `t`.`typeID`))) left join `supplier` `s` on((`i`.`supplierID` = `s`.`supplierID`))) left join `inventory_price` `ip` on((`ti`.`inventoryID` = `ip`.`inventoryID`))) left join `tax` `tx` on((`tx`.`idTAX` = `t`.`idTax`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_type`
--

/*!50001 DROP VIEW IF EXISTS `v_type`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_type` AS select `inventory_type`.`idTax` AS `idTax`,`discount_type`.`DiscountID` AS `DiscountID`,`inventory_type`.`typeID` AS `typeID`,`inventory_type`.`inventory_type_name` AS `inventory_type_name`,`inventory_type`.`min_qty` AS `min_qty`,`inventory_type`.`max_qty` AS `max_qty`,`inventory_type`.`bottles` AS `bottles`,`inventory_type`.`Increment_qty` AS `Increment_qty`,`discount`.`DiscountName` AS `DiscountName`,`discount`.`minQty` AS `minQty`,`discount`.`maxQty` AS `maxQty`,`discount`.`Discount` AS `Discount`,`tax`.`bottle_deposit` AS `bottle_deposit`,`tax`.`sales_tax` AS `sales_tax`,`tax`.`local_sales_tax` AS `local_sales_tax`,`tax`.`Tax_Name` AS `Tax_Name` from (((`inventory_type` left join `discount_type` on((`inventory_type`.`typeID` = `discount_type`.`typeID`))) left join `discount` on((`discount_type`.`DiscountID` = `discount`.`DiscountID`))) join `tax` on((`inventory_type`.`idTax` = `tax`.`idTAX`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-04-19 20:04:02
