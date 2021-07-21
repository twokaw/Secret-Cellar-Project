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
-- Temporary view structure for view `v_customerorder`
--

DROP TABLE IF EXISTS `v_customerorder`;
/*!50001 DROP VIEW IF EXISTS `v_customerorder`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_customerorder` AS SELECT 
 1 AS `CustomerOrderItemID`,
 1 AS `CustomerOrderID`,
 1 AS `Customer_Discount`,
 1 AS `InventoryID`,
 1 AS `name`,
 1 AS `OrderQTY`,
 1 AS `InvoiceAmount`,
 1 AS `PaidAmount`,
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
 1 AS `OrderNote`,
 1 AS `Bottle_Deposit`,
 1 AS `retail_price`*/;
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
 1 AS `Orderincrement`,
 1 AS `supplier`,
 1 AS `DiscountID`,
 1 AS `DiscountName`,
 1 AS `minQty`,
 1 AS `maxQty`,
 1 AS `Discount`,
 1 AS `inventory_qty`,
 1 AS `supplier_price`,
 1 AS `purchased_date`,
 1 AS `idTax`,
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
 1 AS `sold_price`,
 1 AS `supplier_price`,
 1 AS `bottles`,
 1 AS `inventory_type_name`,
 1 AS `nontaxable`,
 1 AS `nontaxable_local`,
 1 AS `inventory_qty`*/;
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
 1 AS `AtDoor`,
 1 AS `Duration`,
 1 AS `EventDate`,
 1 AS `idTax`,
 1 AS `Tax_Name`*/;
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
/*!50001 VIEW `v_customerorder` AS select distinct `i`.`CustomerOrderItemID` AS `CustomerOrderItemID`,`o`.`CustomerOrderID` AS `CustomerOrderID`,`customer`.`customer_discount` AS `Customer_Discount`,`i`.`InventoryID` AS `InventoryID`,`d`.`name` AS `name`,`i`.`OrderQTY` AS `OrderQTY`,`o`.`InvoiceAmount` AS `InvoiceAmount`,`o`.`PaidAmount` AS `PaidAmount`,`d`.`inventory_qty` AS `Inventory_qty`,`i`.`DeliverQTY` AS `DeliverQTY`,`o`.`CustomerID` AS `CustomerID`,`o`.`RequestDate` AS `RequestDate`,`o`.`DeliverDate` AS `DeliverDate`,`i`.`Deliverdate` AS `itemDeliverDate`,`customer`.`first_name` AS `First_name`,`d`.`inventory_type_name` AS `inventory_type_name`,`customer`.`last_name` AS `Last_name`,`customer`.`business_name` AS `Business_name`,`customer`.`isWholesale` AS `isWholesale`,`o`.`OrderNote` AS `OrderNote`,`d`.`bottle_deposit` AS `Bottle_Deposit`,`d`.`retail_price` AS `retail_price` from (((`customerorder` `o` join `customerorderitem` `i` on((`o`.`CustomerOrderID` = `i`.`CustomerOrderID`))) join `v_inventory` `d` on((`i`.`InventoryID` = `d`.`inventoryID`))) join `customer` on((`o`.`CustomerID` = `customer`.`customerID`))) order by `o`.`CustomerOrderID`,`i`.`CustomerOrderItemID` */;
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
/*!50001 VIEW `v_type` AS select `inventory_type`.`idTax` AS `idTax`,`discount_type`.`DiscountID` AS `DiscountID`,`inventory_type`.`typeID` AS `typeID`,`inventory_type`.`inventory_type_name` AS `inventory_type_name`,`discount`.`DiscountName` AS `DiscountName`,`discount`.`minQty` AS `minQty`,`discount`.`maxQty` AS `maxQty`,`discount`.`Discount` AS `Discount`,`tax`.`bottle_deposit` AS `bottle_deposit`,`tax`.`sales_tax` AS `sales_tax`,`tax`.`local_sales_tax` AS `local_sales_tax`,`tax`.`Tax_Name` AS `Tax_Name` from (((`inventory_type` left join `discount_type` on((`inventory_type`.`typeID` = `discount_type`.`typeID`))) left join `discount` on((`discount_type`.`DiscountID` = `discount`.`DiscountID`))) join `tax` on((`inventory_type`.`idTax` = `tax`.`idTAX`))) */;
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
/*!50001 VIEW `v_inventory` AS select `i`.`inventoryID` AS `inventoryID`,`i`.`description` AS `description`,`i`.`name` AS `name`,`i`.`barcode` AS `barcode`,`i`.`retail_price` AS `retail_price`,`i`.`bottle_deposit_qty` AS `bottles`,`i`.`nontaxable` AS `nontaxable`,`i`.`nontaxable_local` AS `nontaxable_local`,`i`.`typeID` AS `typeID`,`i`.`hidden` AS `hidden`,`t`.`inventory_type_name` AS `inventory_type_name`,`i`.`supplierID` AS `supplierID`,`i`.`InvMin` AS `invMin`,`i`.`InvMax` AS `invMax`,`i`.`OrderQty` AS `orderQty`,`i`.`orderIncrement` AS `Orderincrement`,`s`.`name` AS `supplier`,`discount_inventory`.`DiscountID` AS `DiscountID`,`d`.`DiscountName` AS `DiscountName`,`d`.`minQty` AS `minQty`,`d`.`maxQty` AS `maxQty`,`d`.`Discount` AS `Discount`,`ip`.`inventory_qty` AS `inventory_qty`,`ip`.`supplier_price` AS `supplier_price`,`ip`.`purchased_date` AS `purchased_date`,`t`.`idTax` AS `idTax`,`c`.`bottle_deposit` AS `bottle_deposit`,`c`.`sales_tax` AS `sales_tax`,`c`.`local_sales_tax` AS `local_sales_tax`,`c`.`Tax_Name` AS `Tax_Name` from ((((((`inventory_description` `i` join `inventory_type` `t` on((`i`.`typeID` = `t`.`typeID`))) join `tax` `c` on((`c`.`idTAX` = `t`.`idTax`))) left join `supplier` `s` on((`i`.`supplierID` = `s`.`supplierID`))) left join `inventory_price` `ip` on((`i`.`inventoryID` = `ip`.`inventoryID`))) left join `discount_inventory` on((`i`.`inventoryID` = `discount_inventory`.`InventoryID`))) left join `discount` `d` on((`discount_inventory`.`DiscountID` = `d`.`DiscountID`))) */;
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
/*!50001 VIEW `v_transaction_items` AS select `ti`.`receiptID` AS `receiptID`,`i`.`name` AS `name`,`ti`.`inventoryID` AS `InventoryID`,`i`.`barcode` AS `barcode`,`ti`.`sold_qty` AS `sold_qty`,`ti`.`sold_price` AS `sold_price`,`ti`.`supplier_price` AS `supplier_price`,`i`.`bottle_deposit_qty` AS `bottles`,`t`.`inventory_type_name` AS `inventory_type_name`,`i`.`nontaxable` AS `nontaxable`,`i`.`nontaxable_local` AS `nontaxable_local`,`ip`.`inventory_qty` AS `inventory_qty` from ((((`transaction_items` `ti` join `inventory_description` `i` on((`ti`.`inventoryID` = `i`.`inventoryID`))) left join `inventory_type` `t` on((`i`.`typeID` = `t`.`typeID`))) left join `supplier` `s` on((`i`.`supplierID` = `s`.`supplierID`))) left join `inventory_price` `ip` on((`ti`.`inventoryID` = `ip`.`inventoryID`))) */;
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
/*!50001 VIEW `v_suspendedtransaction` AS select `transaction`.`receiptID` AS `receiptID`,sum(`transaction_items`.`sold_price`) AS `TotalSale`,sum(`payments`.`Amount`) AS `TotalPayment` from ((`transaction` left join `transaction_items` on((`transaction`.`receiptID` = `transaction_items`.`receiptID`))) left join `payments` on((`transaction`.`receiptID` = `payments`.`ReceiptID`))) group by `transaction`.`receiptID` having ((`TotalSale` > `TotalPayment`) or (`TotalPayment` is null)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

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
/*!50001 VIEW `v_event` AS select `i`.`inventoryID` AS `inventoryID`,`i`.`name` AS `name`,`i`.`barcode` AS `barcode`,`i`.`nontaxable` AS `nontaxable`,`i`.`nontaxable_local` AS `nontaxable_local`,`i`.`retail_price` AS `retail_price`,`i`.`typeID` AS `typeID`,`t`.`inventory_type_name` AS `inventory_type_name`,`ip`.`inventory_qty` AS `inventory_qty`,`c`.`sales_tax` AS `sales_tax`,`c`.`local_sales_tax` AS `local_sales_tax`,`ip`.`purchased_date` AS `purchased_Date`,`ip`.`supplier_price` AS `supplier_price`,`e`.`Preorder` AS `PreOrder`,`e`.`AtDoor` AS `AtDoor`,`e`.`Duration` AS `Duration`,`e`.`EventDate` AS `EventDate`,`c`.`idTAX` AS `idTax`,`c`.`Tax_Name` AS `Tax_Name` from ((((`inventory_description` `i` join `inventory_type` `t` on((`i`.`typeID` = `t`.`typeID`))) join `tax` `c` on((`c`.`idTAX` = `t`.`idTax`))) join `events` `e` on((`i`.`inventoryID` = `e`.`inventoryID`))) join `inventory_price` `ip` on((`i`.`inventoryID` = `ip`.`inventoryID`))) */;
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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-07-20 23:21:04
