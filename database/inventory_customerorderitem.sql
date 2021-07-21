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
-- Table structure for table `customerorderitem`
--

DROP TABLE IF EXISTS `customerorderitem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customerorderitem` (
  `CustomerOrderItemID` int NOT NULL AUTO_INCREMENT,
  `CustomerOrderID` int DEFAULT NULL,
  `InventoryID` int DEFAULT NULL,
  `OrderQTY` int DEFAULT NULL,
  `DeliverQTY` int DEFAULT NULL,
  `Deliverdate` datetime DEFAULT NULL,
  PRIMARY KEY (`CustomerOrderItemID`),
  KEY `FK_CustomerOrderItem_idx` (`InventoryID`),
  KEY `FK_CustomerOrderItem_OrderId_idx` (`CustomerOrderID`),
  CONSTRAINT `FK_CustomerOrderItem_InventoryID` FOREIGN KEY (`InventoryID`) REFERENCES `inventory_description` (`inventoryID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_CustomerOrderItem_OrderId` FOREIGN KEY (`CustomerOrderID`) REFERENCES `customerorder` (`CustomerOrderID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customerorderitem`
--

LOCK TABLES `customerorderitem` WRITE;
/*!40000 ALTER TABLE `customerorderitem` DISABLE KEYS */;
INSERT INTO `customerorderitem` VALUES (1,5,1024,2,0,'2021-06-23 00:38:31'),(10,5,4315,1,0,'0001-01-01 00:00:00'),(11,5,3085,0,0,'0001-01-01 00:00:00'),(17,5,2326,1,0,'0001-01-01 00:00:00');
/*!40000 ALTER TABLE `customerorderitem` ENABLE KEYS */;
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
