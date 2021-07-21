-- MySQL dump 10.13  Distrib 8.0.25, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: inventory
-- ------------------------------------------------------
-- Server version	8.0.25

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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-07-20 23:21:03
