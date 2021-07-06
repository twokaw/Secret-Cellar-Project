CREATE DATABASE Inventory;
Use Inventory;
CREATE USER invuser identified by 'testinv!';
GRANT SELECT, INSERT, UPDATE, DELETE ON inventory.* TO invuser;