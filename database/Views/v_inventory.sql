CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_inventory` AS 
SELECT `i`.`inventoryID` AS `inventoryID`,
       `i`.`description` AS `description`,
       `i`.`name` AS `name`,
       `i`.`barcode` AS `barcode`,
       `i`.`retail_price` AS `retail_price`,
       `i`.`discount_price` AS `discount_price`,
       IFNULL(`i`.`bottles`, 0) AS `bottles`,
       `i`.`nontaxable` AS `nontaxable`,
       `i`.`nontaxable_local` AS `nontaxable_local`,
       `i`.`typeID` AS `typeID`,
       `i`.`hidden` AS `hidden`,
       `i`.`supplierID` AS `supplierID`,
       IFNULL(`i`.`invMin`, 0) AS `invMin`,
       IFNULL(`i`.`invMax`, 0) AS `invMax`,
       `i`.`orderQty` AS `orderQty`,
       `i`.`RequestQty` AS `RequestQty`,
       `i`.`inventory_qty` AS `inventory_qty`,
       `i`.`RequiredQty` AS `RequiredQty`,
       `i`.`Orderincrement` AS `Orderincrement`,
       `i`.`supplier_price` AS `supplier_price`,
       `i`.`purchased_date` AS `purchased_date`,
       `di`.`DiscountID` AS `DiscountID`,
       `d`.`DiscountName` AS `DiscountName`,
       `d`.`minQty` AS `minQty`,
       `d`.`maxQty` AS `maxQty`,
       `d`.`Discount` AS `Discount`,
       IFNULL(`sq`.`suspendedQty`, 0) AS `suspendedQty`,
       `s`.`name` AS `supplier`,
       `t`.`idTax` AS `idTax`, 
       `t`.`inventory_type_name` AS `inventory_type_name`,
       `c`.`bottle_deposit` AS `bottle_deposit`,
       `c`.`sales_tax` AS `sales_tax`,
       `c`.`local_sales_tax` AS `local_sales_tax`,
       `c`.`Tax_Name` AS `Tax_Name`
       
FROM v_InventoryBase `i` 
JOIN `inventory_type` `t`         ON `i`.`typeID` = `t`.`typeID` 
JOIN `tax` `c`                    ON `c`.`idTAX` = `t`.`idTax`
LEFT JOIN  `supplier` `s`         ON `i`.`supplierID` = `s`.`supplierID`
LEFT JOIN  `discount_inventory` `di` ON `i`.`inventoryID` = `di`.`InventoryID` 
LEFT JOIN  `discount` `d` ON `di`.`DiscountID` = `d`.`DiscountID` 
LEFT JOIN  v_suspendTransactionDetail `sq` ON `sq`.`inventoryID` = `i`.`inventoryID`
;