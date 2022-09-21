 create OR REPLACE  view v_InventoryBase AS
   
   SELECT `i`.`inventoryID` AS `inventoryID`,
          `i`.`description` AS `description`,
          `i`.`name` AS `name`,
          `i`.`barcode` AS `barcode`,
          `i`.`retail_price` AS `retail_price`,
          `i`.`discount_price` AS `discount_price`,   
          `i`.`bottle_deposit_qty` AS `bottles`,
          `i`.`nontaxable` AS `nontaxable`,
          `i`.`nontaxable_local` AS `nontaxable_local`,
          `i`.`typeID` AS `typeID`,
          `i`.`hidden` AS `hidden`,
          `i`.`supplierID` AS `supplierID`,
          `i`.`InvMin` AS `invMin`,
          `i`.`InvMax` AS `invMax`,
          `i`.`OrderQty` AS `orderQty`,
          IFNULL(`r`.`requestQty`, 0) AS `RequestQty`,
          `ip`.`inventory_qty` AS `inventory_qty`,
          IFNULL(IF( SUM(`ip`.`inventory_qty`) OVER `w` 
                    + `i`.`OrderQty` 
                    - IFNULL(`r`.`requestQty`, 0) 
                    > `i`.`InvMin`
                    , 0
                    ,  `i`.`InvMax` 
                      - SUM(`ip`.`inventory_qty`) OVER `w` 
                      - `i`.`OrderQty` 
                      + IFNULL(`r`.`requestQty`, 0) DIV greatest(`i`.`orderIncrement`, 1) 
                      + if( `i`.`InvMax` 
                           - SUM(`ip`.`inventory_qty`) OVER `w` 
                           - `i`.`OrderQty` 
                           + IFNULL(`r`.`requestQty`, 0) % greatest(`i`.`orderIncrement`,1) > 0
                          , greatest(`i`.`orderIncrement`, 1)
                          , 0
                          )
                    )
				, 0
                ) AS `RequiredQty`,
       `i`.`orderIncrement` AS `Orderincrement`,
       `ip`.`supplier_price` AS `supplier_price`,
       `ip`.`purchased_date` AS `purchased_date`
   FROM `inventory_description` `i` 
   LEFT JOIN  `inventory_price` `ip` ON `i`.`inventoryID` = `ip`.`inventoryID` 
   LEFT JOIN  
    (
	 SELECT `coi`.`InventoryID` AS `InventoryId`,
	        SUM(`coi`.`RequestQTY` - `coi`.`DeliverQTY`) AS `requestQty`
	 FROM `customerorderitem` `coi` 
	 WHERE (`coi`.`RequestQTY` - `coi`.`DeliverQTY`) > 0
	 GROUP BY `coi`.`InventoryID`
	) `r` 
   ON `r`.`InventoryId` = `i`.`inventoryID`
   WINDOW `w` AS (PARTITION BY `i`.`inventoryID` )
