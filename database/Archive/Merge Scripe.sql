select `i`.`CustomerOrderItemID` AS `CustomerOrderItemID`,`o`.`CustomerOrderID` AS `CustomerOrderID`,`customer`.`customer_discount` AS `Customer_Discount`,`i`.`InventoryID` AS `InventoryID`,`d`.`name` AS `name`,`i`.`OrderQTY` AS `OrderQTY`,
`o`.`InvoiceAmount` AS `InvoiceAmount`,`o`.`PaidAmount` AS `PaidAmount`,`d`.`inventory_qty` AS `Inventory_qty`,`i`.`DeliverQTY` AS `DeliverQTY`,`o`.`CustomerID` AS `CustomerID`,`o`.`RequestDate` AS `RequestDate`,`o`.`DeliverDate` AS `DeliverDate`,
`i`.`Deliverdate` AS `itemDeliverDate`,`customer`.`first_name` AS `First_name`,`d`.`inventory_type_name` AS `inventory_type_name`,`customer`.`last_name` AS `Last_name`,`customer`.`business_name` AS `Business_name`,`customer`.`isWholesale` AS `isWholesale`,
`o`.`OrderNote` AS `OrderNote`,`d`.`bottle_deposit` AS `Bottle_Deposit` 
from (((`customerorder` `o` join `customerorderitem` `i` on((`o`.`CustomerOrderID` = `i`.`CustomerOrderID`))) 
join `v_inventory` `d` on((`i`.`InventoryID` = `d`.`inventoryID`))) 
join `customer` on((`o`.`CustomerID` = `customer`.`customerID`)))
 order by `o`.`CustomerOrderID`,`i`.`CustomerOrderItemID` */;






DROP TABLE IF EXISTS `customerorder`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customerorder` (
  `CustomerOrderID` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerID` int(11) DEFAULT NULL,
  `InvoiceAmount` double DEFAULT NULL,
  `PaidAmount` double DEFAULT NULL,
  `RequestDate` datetime DEFAULT NULL,
  `DeliverDate` datetime DEFAULT NULL,
  `OrderNote` varchar(1000) DEFAULT NULL,
  PRIMARY KEY (`CustomerOrderID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customerorder`
--

LOCK TABLES `customerorder` WRITE;
/*!40000 ALTER TABLE `customerorder` DISABLE KEYS */;
/*!40000 ALTER TABLE `customerorder` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
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

--
-- Table structure for table `customerorderhist`
--

DROP TABLE IF EXISTS `customerorderhist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customerorderhist` (
  `CustomerOrderID` int(11) NOT NULL,
  `CustomerID` int(11) DEFAULT NULL,
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

--
-- Table structure for table `customerorderitem`
--

DROP TABLE IF EXISTS `customerorderitem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customerorderitem` (
  `CustomerOrderItemID` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerOrderID` int(11) DEFAULT NULL,
  `InventoryID` int(11) DEFAULT NULL,
  `OrderQTY` int(11) DEFAULT NULL,
  `DeliverQTY` int(11) DEFAULT NULL,
  `Deliverdate` datetime DEFAULT NULL,
  PRIMARY KEY (`CustomerOrderItemID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customerorderitem`
--

LOCK TABLES `customerorderitem` WRITE;
/*!40000 ALTER TABLE `customerorderitem` DISABLE KEYS */;
/*!40000 ALTER TABLE `customerorderitem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customerorderitemhist`
--

DROP TABLE IF EXISTS `customerorderitemhist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customerorderitemhist` (
  `CustomerOrderItemID` int(11) NOT NULL,
  `CustomerOrderID` int(11) DEFAULT NULL,
  `InventoryID` int(11) DEFAULT NULL,
  `OrderQTY` int(11) DEFAULT NULL,
  `DeliverQTY` int(11) DEFAULT NULL,
  `Deliverdate` datetime DEFAULT NULL,
  PRIMARY KEY (`CustomerOrderItemID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customerorderitemhist`
--

LOCK TABLES `customerorderitemhist` WRITE;
/*!40000 ALTER TABLE `customerorderitemhist` DISABLE KEYS */;
/*!40000 ALTER TABLE `customerorderitemhist` ENABLE KEYS */;
UNLOCK TABLES;

SELECT * FROM customerorder;

SELECT * FROM customerorderitem;

SELECT * FROM inventory_Description  WHERE inventoryID = 24
LIMIt 1;


create OR REPLACE VIEW `v_customerorder` AS 
select `i`.`CustomerOrderItemID` AS `CustomerOrderItemID`,`o`.`CustomerOrderID` AS `CustomerOrderID`,`customer`.`customer_discount` AS `Customer_Discount`, `retail_price`, `i`.`InventoryID` AS `InventoryID`,`d`.`name` AS `name`,`i`.`OrderQTY` AS `OrderQTY`,`o`.`InvoiceAmount` AS `InvoiceAmount`,`o`.`PaidAmount` AS `PaidAmount`,`d`.`inventory_qty` AS `Inventory_qty`,`i`.`DeliverQTY` AS `DeliverQTY`,`o`.`CustomerID` AS `CustomerID`,`o`.`RequestDate` AS `RequestDate`,`o`.`DeliverDate` AS `DeliverDate`,`i`.`Deliverdate` AS `itemDeliverDate`,`customer`.`first_name` AS `First_name`,`d`.`inventory_type_name` AS `inventory_type_name`,`customer`.`last_name` AS `Last_name`,`customer`.`business_name` AS `Business_name`,`customer`.`isWholesale` AS `isWholesale`,`o`.`OrderNote` AS `OrderNote`,`d`.`bottle_deposit` AS `Bottle_Deposit` 
from (((`customerorder` `o` join `customerorderitem` `i` on((`o`.`CustomerOrderID` = `i`.`CustomerOrderID`))) 
join `v_inventory` `d` on((`i`.`InventoryID` = `d`.`inventoryID`))) 
join `customer` on((`o`.`CustomerID` = `customer`.`customerID`))) 
order by `o`.`CustomerOrderID`,`i`.`CustomerOrderItemID` ;


SELECT * FROM v_inventory;

    SELECT 
        `i`.`inventoryID` AS `inventoryID`,
        `i`.`description` AS `description`,
        `i`.`name` AS `name`,
        `i`.`barcode` AS `barcode`,
        `i`.`retail_price` AS `retail_price`,
        `i`.`bottle_deposit_qty` AS `bottles`,
        `i`.`nontaxable` AS `nontaxable`,
        `i`.`nontaxable_local` AS `nontaxable_local`,
        `i`.`typeID` AS `typeID`,
        `i`.`hidden` AS `hidden`,
        `t`.`inventory_type_name` AS `inventory_type_name`,
        `i`.`supplierID` AS `supplierID`,
        `i`.`InvMin` AS `invMin`,
        `i`.`InvMax` AS `invMax`,
        `i`.`OrderQty` AS `orderQty`,
        `i`.`orderIncrement` AS `Orderincrement`,
        `s`.`name` AS `supplier`,
        `discount_inventory`.`DiscountID` AS `DiscountID`,
        `d`.`DiscountName` AS `DiscountName`,
        `d`.`minQty` AS `minQty`,
        `d`.`maxQty` AS `maxQty`,
        `d`.`Discount` AS `Discount`,
        `ip`.`inventory_qty` AS `inventory_qty`,
        `ip`.`supplier_price` AS `supplier_price`,
        `ip`.`purchased_date` AS `purchased_date`,
        `t`.`idTax` AS `idTax`,
        `c`.`bottle_deposit` AS `bottle_deposit`,
        `c`.`sales_tax` AS `sales_tax`,
        `c`.`local_sales_tax` AS `local_sales_tax`,
        `c`.`Tax_Name` AS `Tax_Name`
    FROM
        ((((((`inventory_description` `i`
        JOIN `inventory_type` `t` ON ((`i`.`typeID` = `t`.`typeID`)))
        JOIN `tax` `c` ON ((`c`.`idTAX` = `t`.`idTax`)))
        LEFT JOIN `supplier` `s` ON ((`i`.`supplierID` = `s`.`supplierID`)))
        LEFT JOIN `inventory_price` `ip` ON ((`i`.`inventoryID` = `ip`.`inventoryID`)))
        LEFT JOIN `discount_inventory` ON ((`i`.`inventoryID` = `discount_inventory`.`InventoryID`)))
        LEFT JOIN `discount` `d` ON ((`discount_inventory`.`DiscountID` = `d`.`DiscountID`)));
        
        
        
 SELECT * FROM Notetype;       
        
 Merge Notetype USING (
 SELECT 3 id, 'Happy' typename
 )
ON notetypeID = id
WHEN MATCHED
THEN SET notetype = typename

WHEN NOT MATCHED
THEN (NoteType)
values(typename)

WHEN NOT MATCHED BY SOURCE
THEN DELETE;     
      
      
SELECT * FROM v_inventory;
  
        
        
        SELECT * FROM v_customerOrder;