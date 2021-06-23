
DROP TABLE CustomerOrder;
CREATE TABLE CustomerOrder
(
  CustomerOrderID INTEGER Primary KEY auto_increment, 
  CustomerID INTEGER  REFERENCES Customer(CustomerID) ON DELETE CASCADE, 
  InvoiceAmount double,  
  PaidAmount double,  
  RequestDate DATETIME, 
  DeliverDate DATETIME, 
  OrderNote VARCHAR(1000)
);

DROP TABLE CustomerOrderItem;
CREATE TABLE CustomerOrderItem
(
  CustomerOrderItemID INTEGER Primary KEY auto_increment, 
  CustomerOrderID     INTEGER REFERENCES CustomerOrder(CustomerOrderID) ,   
  InventoryID         INTEGER REFERENCES Inventory_Description(InventoryID), 
  OrderQTY            INTEGER, 
  DeliverQTY          INTEGER,  
  Deliverdate         DATETIME
);    

DELIMITER //
CREATE TRIGGER TRG_CustomerOrder
BEFORE DELETE ON CustomerOrder 
FOR EACH ROW
BEGIN
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
END //
DELIMITER ;

DROP TABLE IF EXISTS CustomerOrderHist;
CREATE TABLE CustomerOrderHist
(
  CustomerOrderID INTEGER Primary KEY, 
  CustomerID INTEGER, 
  InvoiceAmount double,  
  PaidAmount double,  
  RequestDate DATETIME, 
  DeliverDate DATETIME, 
  OrderNote VARCHAR(1000),
  PaidDate DateTime
);

DROP TABLE IF EXISTS CustomerOrderItemHist;
CREATE TABLE CustomerOrderItemHist
(
  CustomerOrderItemID INTEGER Primary KEY, 
  CustomerOrderID     INTEGER REFERENCES CustomerOrderHist(CustomerOrderID) ON DELETE SET NULL,   
  InventoryID         INTEGER REFERENCES Inventory_Description(InventoryID) ON DELETE SET NULL, 
  OrderQTY            INTEGER, 
  DeliverQTY          INTEGER,  
  Deliverdate         DATETIME
);    

CREATE OR REPLACE VIEW v_CustomerOrder AS
SELECT CustomerOrderItemID, 
       CustomerOrderID,   
	   Customer_Discount,
       InventoryID, 
	   name, 
       i.OrderQTY, 
       InvoiceAmount,  
       PaidAmount,  
       Inventory_qty,
       DeliverQTY,  
       CustomerID,
       RequestDate, 
       o.DeliverDate DeliverDate, 
       i.DeliverDate itemDeliverDate, 
       First_name, 
	   inventory_type_name,
	   Last_name, 
	   Business_name,
	   isWholesale, 
       OrderNote,
       Bottle_Deposit
FROM  CustomerOrder o 
JOIN  CustomerOrderItem i
USING ( CustomerOrderID )
JOIN  v_Inventory d
USING (InventoryID)
JOIN  Customer
USING (Customerid)
ORDER BY CustomerOrderID, CustomerOrderItemID
 ;
 
 
/*
SELECT * FROM v_Inventory;

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
        `s`.`name` AS `supplier`,
        `discount_inventory`.`DiscountID` AS `DiscountID`,
        `d`.`DiscountName` AS `DiscountName`,
        `d`.`minQty` AS `minQty`,
        `d`.`maxQty` AS `maxQty`,
        `i`.`OrderIncrement` AS `OrderIncrement`,
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
        */
 