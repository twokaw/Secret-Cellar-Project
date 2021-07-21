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
  PRIMARY KEY (`receiptID`,`inventoryID`),
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
INSERT INTO `transaction_items` VALUES (7,1030,190,100,3),(8,1036,13.99,10,1),(9,1541,40,20,1),(10,1541,40,20,1),(11,1541,40,20,1),(12,1541,40,20,1),(13,2210,10.99,10.99,1),(14,2165,11.99,11.99,1),(17,1251,3.99,3.99,1),(18,2230,19.99,19.99,1),(23,1424,1,1,1),(24,1024,10.99,10.99,1),(24,1045,1,1,1),(24,1062,1.89,1.89,1),(24,1063,1.89,1.89,1),(24,1064,1.5,1.5,1),(24,1065,1.5,1.5,1),(24,1097,2.99,2.99,1),(24,1102,4.99,4.99,1),(24,1114,3.99,3.99,1),(24,1115,3.99,3.99,1),(24,1116,23.99,23.99,1),(24,1117,19.99,19.99,1),(24,1118,16,16,1),(24,1124,1.99,1.99,1),(24,1126,12.99,12.99,1),(24,1127,12.99,12.99,1),(24,1128,12.99,12.99,1),(24,1139,9.99,9.99,1),(24,1140,1.99,1.99,1),(24,1141,4.99,4.99,1),(24,1142,35.99,35.99,1),(24,1143,12.99,12.99,1),(24,1340,2.99,2.99,1),(24,1419,2.69,2.69,1),(24,1541,40,20,1),(24,1715,5.75,5.75,1),(24,1803,26.6,26.6,1),(24,2293,12.99,12.99,1),(24,2341,16.06,16.06,1),(24,2380,16.99,16.99,1),(24,2438,10.99,10.99,1),(24,2861,5.99,5.99,1);
/*!40000 ALTER TABLE `transaction_items` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-07-20 23:21:02
