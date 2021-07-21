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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-07-20 23:21:03
