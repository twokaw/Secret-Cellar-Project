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
-- Table structure for table `discount_inventory`
--

DROP TABLE IF EXISTS `discount_inventory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `discount_inventory` (
  `DiscountID` int NOT NULL,
  `InventoryID` int NOT NULL,
  PRIMARY KEY (`DiscountID`,`InventoryID`),
  KEY `Discount_Inventory_fk_Inventory_Description` (`InventoryID`),
  CONSTRAINT `Discount_Inventory_fk_Discount` FOREIGN KEY (`DiscountID`) REFERENCES `discount` (`DiscountID`) ON DELETE CASCADE,
  CONSTRAINT `Discount_Inventory_fk_Inventory_Description` FOREIGN KEY (`InventoryID`) REFERENCES `inventory_description` (`inventoryID`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `discount_inventory`
--

LOCK TABLES `discount_inventory` WRITE;
/*!40000 ALTER TABLE `discount_inventory` DISABLE KEYS */;
INSERT INTO `discount_inventory` VALUES (1,1030),(2,1030),(1,1031),(2,1031),(1,1032),(2,1032),(1,1034),(2,1034),(1,1035),(2,1035),(1,1036),(2,1036),(1,1044),(2,1044),(1,1050),(2,1050),(1,1053),(2,1053),(1,1056),(2,1056),(1,1059),(2,1059),(1,1060),(2,1060),(1,1061),(2,1061),(1,1066),(2,1066),(1,1067),(2,1067),(1,1069),(2,1069),(1,1092),(2,1092),(1,1093),(2,1093),(1,1094),(2,1094),(1,1095),(2,1095),(1,1096),(2,1096),(1,1108),(2,1108),(1,1109),(2,1109),(1,1110),(2,1110),(1,1129),(2,1129),(1,1130),(2,1130),(1,1131),(2,1131),(1,1132),(2,1132),(1,1133),(2,1133),(1,1155),(2,1155),(1,1159),(2,1159),(1,1179),(2,1179),(1,1180),(2,1180),(1,1190),(2,1190),(1,1191),(2,1191),(1,1195),(2,1195),(1,1260),(2,1260),(1,1261),(2,1261),(1,1273),(2,1273),(1,1278),(2,1278),(1,1279),(2,1279),(1,1296),(2,1296),(1,1360),(2,1360),(1,1361),(2,1361),(1,1439),(2,1439),(1,1440),(2,1440),(1,1441),(2,1441),(1,1442),(2,1442),(1,1444),(2,1444),(1,1445),(2,1445),(1,1446),(2,1446),(1,1447),(2,1447),(1,1448),(2,1448),(1,1449),(2,1449),(1,1450),(2,1450),(1,1451),(2,1451),(1,1452),(2,1452),(1,1453),(2,1453),(1,1454),(2,1454),(1,1455),(2,1455),(1,1456),(2,1456),(1,1457),(2,1457),(1,1458),(2,1458),(1,1459),(2,1459),(1,1460),(2,1460),(1,1461),(2,1461),(1,1462),(2,1462),(1,1463),(2,1463),(1,1464),(2,1464),(1,1465),(2,1465),(1,1466),(2,1466),(1,1467),(2,1467),(1,1468),(2,1468),(1,1469),(2,1469),(1,1470),(2,1470),(1,1471),(2,1471),(1,1472),(2,1472),(1,1473),(2,1473),(1,1479),(2,1479),(1,1480),(2,1480),(1,1481),(2,1481),(1,1482),(2,1482),(1,1483),(2,1483),(1,1484),(2,1484),(1,1485),(2,1485),(1,1486),(2,1486),(1,1487),(2,1487),(1,1488),(2,1488),(1,1489),(2,1489),(1,1490),(2,1490),(1,1491),(2,1491),(1,1492),(2,1492),(1,1493),(2,1493),(1,1494),(2,1494),(1,1495),(2,1495),(1,1496),(2,1496),(1,1497),(2,1497),(1,1498),(2,1498),(1,1499),(2,1499),(1,1500),(2,1500),(1,1501),(2,1501),(1,1502),(2,1502),(1,1503),(2,1503),(1,1504),(2,1504),(1,1505),(2,1505),(1,1506),(2,1506),(1,1508),(2,1508),(1,1509),(2,1509),(1,1510),(2,1510),(1,1511),(2,1511),(1,1512),(2,1512),(1,1513),(2,1513),(1,1514),(2,1514),(1,1515),(2,1515),(1,1516),(2,1516),(1,1517),(2,1517),(1,1518),(2,1518),(1,1519),(2,1519),(1,1520),(2,1520),(1,1521),(2,1521),(1,1522),(2,1522),(1,1523),(2,1523),(1,1524),(2,1524),(1,1525),(2,1525),(1,1526),(2,1526),(1,1527),(2,1527),(1,1528),(2,1528),(1,1529),(2,1529),(1,1530),(2,1530),(1,1531),(2,1531),(1,1532),(2,1532),(1,1533),(2,1533),(1,1536),(2,1536),(1,1537),(2,1537),(1,1538),(2,1538),(1,1539),(2,1539),(1,1540),(2,1540),(1,1541),(2,1541),(1,1542),(2,1542),(1,1543),(2,1543),(1,1545),(2,1545),(1,1546),(2,1546),(1,1547),(2,1547),(1,1548),(2,1548),(1,1549),(2,1549),(1,1550),(2,1550),(1,1551),(2,1551),(1,1552),(2,1552),(1,1553),(2,1553),(1,1554),(2,1554),(1,1555),(2,1555),(1,1556),(2,1556),(1,1557),(2,1557),(1,1558),(2,1558),(1,1559),(2,1559),(1,1560),(2,1560),(1,1561),(2,1561),(1,1562),(2,1562),(1,1563),(2,1563),(1,1564),(2,1564),(1,1565),(2,1565),(1,1567),(2,1567),(1,1568),(2,1568),(1,1569),(2,1569),(1,1570),(2,1570),(1,1571),(2,1571),(1,1572),(2,1572),(1,1573),(2,1573),(1,1574),(2,1574),(1,1575),(2,1575),(1,1576),(2,1576),(1,1577),(2,1577),(1,1578),(2,1578),(1,1580),(2,1580),(1,1581),(2,1581),(1,1583),(2,1583),(1,1584),(2,1584),(1,1585),(2,1585),(1,1586),(2,1586),(1,1587),(2,1587),(1,1588),(2,1588),(1,1589),(2,1589),(1,1590),(2,1590),(1,1591),(2,1591),(1,1592),(2,1592),(1,1593),(2,1593),(1,1594),(2,1594),(1,1595),(2,1595),(1,1596),(2,1596),(1,1597),(2,1597),(1,1598),(2,1598),(1,1601),(2,1601),(1,1602),(2,1602),(1,1603),(2,1603),(1,1607),(2,1607),(1,1608),(2,1608),(1,1610),(2,1610),(1,1611),(2,1611),(1,1612),(2,1612),(1,1613),(2,1613),(1,1614),(2,1614),(1,1615),(2,1615),(1,1616),(2,1616),(1,1617),(2,1617),(1,1618),(2,1618),(1,1620),(2,1620),(1,1621),(2,1621),(1,1622),(2,1622),(1,1623),(2,1623),(1,1624),(2,1624),(1,1625),(2,1625),(1,1626),(2,1626),(1,1627),(2,1627),(1,1628),(2,1628),(1,1629),(2,1629),(1,1630),(2,1630),(1,1631),(2,1631),(1,1632),(2,1632),(1,1634),(2,1634),(1,1635),(2,1635),(1,1636),(2,1636),(1,1637),(2,1637),(1,1639),(2,1639),(1,1640),(2,1640),(1,1641),(2,1641),(1,1642),(2,1642),(1,1643),(2,1643),(1,1645),(2,1645),(1,1649),(2,1649),(1,1650),(2,1650),(1,1651),(2,1651),(1,1652),(2,1652),(1,1653),(2,1653),(1,1654),(2,1654),(1,1655),(2,1655),(1,1656),(2,1656),(1,1658),(2,1658),(1,1659),(2,1659),(1,1660),(2,1660),(1,1661),(2,1661),(1,1662),(2,1662),(1,1663),(2,1663),(1,1664),(2,1664),(1,1665),(2,1665),(1,1666),(2,1666),(1,1667),(2,1667),(1,1668),(2,1668),(1,1669),(2,1669),(1,1670),(2,1670),(1,1671),(2,1671),(1,1672),(2,1672),(1,1673),(2,1673),(1,1674),(2,1674),(1,1675),(2,1675),(1,1676),(2,1676),(1,1677),(2,1677),(1,1678),(2,1678),(1,1679),(2,1679),(1,1680),(2,1680),(1,1681),(2,1681),(1,1682),(2,1682),(1,1683),(2,1683),(1,1684),(2,1684),(1,1686),(2,1686),(1,1687),(2,1687),(1,1688),(2,1688),(1,1689),(2,1689),(1,1690),(2,1690),(1,1691),(2,1691),(1,1692),(2,1692),(1,1693),(2,1693),(1,1694),(2,1694),(1,1695),(2,1695),(1,1696),(2,1696),(1,1697),(2,1697),(1,1698),(2,1698),(1,1699),(2,1699),(1,1700),(2,1700),(1,1701),(2,1701),(1,1702),(2,1702),(1,1703),(2,1703),(1,1704),(2,1704),(1,1705),(2,1705),(1,1706),(2,1706),(1,1707),(2,1707),(1,1710),(2,1710),(1,1711),(2,1711),(1,1712),(2,1712),(1,1713),(2,1713),(1,1714),(2,1714),(1,1715),(2,1715),(1,1717),(2,1717),(1,1718),(2,1718),(1,1719),(2,1719),(1,1720),(2,1720),(1,1721),(2,1721),(1,1722),(2,1722),(1,1723),(2,1723),(1,1724),(2,1724),(1,1725),(2,1725),(1,1726),(2,1726),(1,1727),(2,1727),(1,1728),(2,1728),(1,1729),(2,1729),(1,1730),(2,1730),(1,1731),(2,1731),(1,1732),(2,1732),(1,1733),(2,1733),(1,1734),(2,1734),(1,1735),(2,1735),(1,1736),(2,1736),(1,1737),(2,1737),(1,1738),(2,1738),(1,1739),(2,1739),(1,1740),(2,1740),(1,1741),(2,1741),(1,1742),(2,1742),(1,1743),(2,1743),(1,1744),(2,1744),(1,1745),(2,1745),(1,1746),(2,1746),(1,1747),(2,1747),(1,1748),(2,1748),(1,1749),(2,1749),(1,1750),(2,1750),(1,1751),(2,1751),(1,1752),(2,1752),(1,1753),(2,1753),(1,1754),(2,1754),(1,1755),(2,1755),(1,1756),(2,1756),(1,1757),(2,1757),(1,1758),(2,1758),(1,1759),(2,1759),(1,1760),(2,1760),(1,1761),(2,1761),(1,1762),(2,1762),(1,1763),(2,1763),(1,1764),(2,1764),(1,1765),(2,1765),(1,1767),(2,1767),(1,1768),(2,1768),(1,1769),(2,1769),(1,1770),(2,1770),(1,1771),(2,1771),(1,1772),(2,1772),(1,1773),(2,1773),(1,1774),(2,1774),(1,1775),(2,1775),(1,1776),(2,1776),(1,1777),(2,1777),(1,1778),(2,1778),(1,1785),(2,1785),(1,1786),(2,1786),(1,1787),(2,1787),(1,1788),(2,1788),(1,1789),(2,1789),(1,1790),(2,1790),(1,1791),(2,1791),(1,1792),(2,1792),(1,1793),(2,1793),(1,1794),(2,1794),(1,1795),(2,1795),(1,1798),(2,1798),(1,1799),(2,1799),(1,1800),(2,1800),(1,1801),(2,1801),(1,1802),(2,1802),(1,1803),(2,1803),(1,1804),(2,1804),(1,1805),(2,1805),(1,1806),(2,1806),(1,1807),(2,1807),(1,1808),(2,1808),(1,1809),(2,1809),(1,1810),(2,1810),(1,1811),(2,1811),(1,1812),(2,1812),(1,1813),(2,1813),(1,1814),(2,1814),(1,1815),(2,1815),(1,1816),(2,1816),(1,1817),(2,1817),(1,1818),(2,1818),(1,1819),(2,1819),(1,1820),(2,1820),(1,1821),(2,1821),(1,1826),(2,1826),(1,1827),(2,1827),(1,1828),(2,1828),(1,1829),(2,1829),(1,1831),(2,1831),(1,1832),(2,1832),(1,1833),(2,1833),(1,1834),(2,1834),(1,1835),(2,1835),(1,1836),(2,1836),(1,1837),(2,1837),(1,1838),(2,1838),(1,1839),(2,1839),(1,1840),(2,1840),(1,1841),(2,1841),(1,1842),(2,1842),(1,1843),(2,1843),(1,1844),(2,1844),(1,1845),(2,1845),(1,1846),(2,1846),(1,1847),(2,1847),(1,1848),(2,1848),(1,1849),(2,1849),(1,1850),(2,1850),(1,1851),(2,1851),(1,1852),(2,1852),(1,1853),(2,1853),(1,1854),(2,1854),(1,1855),(2,1855),(1,1856),(2,1856),(1,1857),(2,1857),(1,1858),(2,1858),(1,1859),(2,1859),(1,1860),(2,1860),(1,1861),(2,1861),(1,1862),(2,1862),(1,1863),(2,1863),(1,1864),(2,1864),(1,1865),(2,1865),(1,1866),(2,1866),(1,1867),(2,1867),(1,1868),(2,1868),(1,1869),(2,1869),(1,1870),(2,1870),(1,1871),(2,1871),(1,1872),(2,1872),(1,1873),(2,1873),(1,1874),(2,1874),(1,1878),(2,1878),(1,1879),(2,1879),(1,1880),(2,1880),(1,1881),(2,1881),(1,1882),(2,1882),(1,1883),(2,1883),(1,1884),(2,1884),(1,1886),(2,1886),(1,1888),(2,1888),(1,1892),(2,1892),(1,1893),(2,1893),(1,1895),(2,1895),(1,1896),(2,1896),(1,1900),(2,1900),(1,1901),(2,1901),(1,1902),(2,1902),(1,1903),(2,1903),(1,1904),(2,1904),(1,1905),(2,1905),(1,1906),(2,1906),(1,1907),(2,1907),(1,1910),(2,1910),(1,1918),(2,1918),(1,1921),(2,1921),(1,1922),(2,1922),(1,1923),(2,1923),(1,1924),(2,1924),(1,1925),(2,1925),(1,1926),(2,1926),(1,1927),(2,1927),(1,1928),(2,1928),(1,1929),(2,1929),(1,1930),(2,1930),(1,1939),(2,1939),(1,1987),(2,1987),(1,1990),(2,1990),(1,1992),(2,1992),(1,1995),(2,1995),(1,1996),(2,1996),(1,1997),(2,1997),(1,1998),(2,1998),(1,1999),(2,1999),(1,2000),(2,2000),(1,2004),(2,2004),(1,2005),(2,2005),(1,2006),(2,2006),(1,2008),(2,2008),(1,2009),(2,2009),(1,2010),(2,2010),(1,2012),(2,2012),(1,2015),(2,2015),(1,2025),(2,2025),(1,2026),(2,2026),(1,2027),(2,2027),(1,2028),(2,2028),(1,2029),(2,2029),(1,2037),(2,2037),(1,2038),(2,2038),(1,2099),(2,2099),(1,2100),(2,2100),(1,2101),(2,2101),(1,2102),(2,2102),(1,2103),(2,2103),(1,2104),(2,2104),(1,2105),(2,2105),(1,2106),(2,2106),(1,2107),(2,2107),(1,2108),(2,2108),(1,2109),(2,2109),(1,2110),(2,2110),(1,2111),(2,2111),(1,2114),(2,2114),(1,2115),(2,2115),(1,2118),(2,2118),(1,2119),(2,2119),(1,2122),(2,2122),(1,2123),(2,2123),(1,2124),(2,2124),(1,2126),(2,2126),(1,2128),(2,2128),(1,2129),(2,2129),(1,2130),(2,2130),(1,2131),(2,2131),(1,2132),(2,2132),(1,2133),(2,2133),(1,2135),(2,2135),(1,2136),(2,2136),(1,2137),(2,2137),(1,2138),(2,2138),(1,2139),(2,2139),(1,2140),(2,2140),(1,2141),(2,2141),(1,2143),(2,2143),(1,2145),(2,2145),(1,2146),(2,2146),(1,2147),(2,2147),(1,2150),(2,2150),(1,2151),(2,2151),(1,2152),(2,2152),(1,2153),(2,2153),(1,2154),(2,2154),(1,2155),(2,2155),(1,2162),(2,2162),(1,2163),(2,2163),(1,2164),(2,2164),(1,2165),(2,2165),(1,2166),(2,2166),(1,2170),(2,2170),(1,2171),(2,2171),(1,2172),(2,2172),(1,2173),(2,2173),(1,2174),(2,2174),(1,2175),(2,2175),(1,2176),(2,2176),(1,2177),(2,2177),(1,2178),(2,2178),(1,2179),(2,2179),(1,2180),(2,2180),(1,2181),(2,2181),(1,2182),(2,2182),(1,2183),(2,2183),(1,2184),(2,2184),(1,2185),(2,2185),(1,2186),(2,2186),(1,2191),(2,2191),(1,2195),(2,2195),(1,2201),(2,2201),(1,2202),(2,2202),(1,2203),(2,2203),(1,2204),(2,2204),(1,2205),(2,2205),(1,2206),(2,2206),(1,2208),(2,2208),(1,2218),(2,2218),(1,2219),(2,2219),(1,2221),(2,2221),(1,2222),(2,2222),(1,2226),(2,2226),(1,2229),(2,2229),(1,2232),(2,2232),(1,2233),(2,2233),(1,2235),(2,2235),(1,2236),(2,2236),(1,2238),(2,2238),(1,2239),(2,2239),(1,2240),(2,2240),(1,2241),(2,2241),(1,2242),(2,2242),(1,2246),(2,2246),(1,2253),(2,2253),(1,2254),(2,2254),(1,2255),(2,2255),(1,2257),(2,2257),(1,2259),(2,2259),(1,2260),(2,2260),(1,2261),(2,2261),(1,2262),(2,2262),(1,2263),(2,2263),(1,2264),(2,2264),(1,2265),(2,2265),(1,2266),(2,2266),(1,2267),(2,2267),(1,2269),(2,2269),(1,2270),(2,2270),(1,2271),(2,2271),(1,2287),(2,2287),(1,2288),(2,2288),(1,2292),(2,2292),(1,2297),(2,2297),(1,2301),(2,2301),(1,2302),(2,2302),(1,2303),(2,2303),(1,2305),(2,2305),(1,2306),(2,2306),(1,2307),(2,2307),(1,2309),(2,2309),(1,2310),(2,2310),(1,2314),(2,2314),(1,2319),(2,2319),(1,2320),(2,2320),(1,2322),(2,2322),(1,2323),(2,2323),(1,2324),(2,2324),(1,2325),(2,2325),(1,2326),(2,2326),(1,2327),(2,2327),(1,2328),(2,2328),(1,2329),(2,2329),(1,2330),(2,2330),(1,2331),(2,2331),(1,2332),(2,2332),(1,2334),(2,2334),(1,2335),(2,2335),(1,2337),(2,2337),(1,2338),(2,2338),(1,2339),(2,2339),(1,2340),(2,2340),(1,2341),(2,2341),(1,2342),(2,2342),(1,2343),(2,2343),(1,2344),(2,2344),(1,2345),(2,2345),(1,2346),(2,2346),(1,2353),(2,2353),(1,2354),(2,2354),(1,2356),(2,2356),(1,2358),(2,2358),(1,2359),(2,2359),(1,2360),(2,2360),(1,2361),(2,2361),(1,2362),(2,2362),(1,2363),(2,2363),(1,2366),(2,2366),(1,2367),(2,2367),(1,2368),(2,2368),(1,2369),(2,2369),(1,2370),(2,2370),(1,2371),(2,2371),(1,2372),(2,2372),(1,2374),(2,2374),(1,2376),(2,2376),(1,2377),(2,2377),(1,2378),(2,2378),(1,2379),(2,2379),(1,2380),(2,2380),(1,2382),(2,2382),(1,2383),(2,2383),(1,2384),(2,2384),(1,2385),(2,2385),(1,2386),(2,2386),(1,2387),(2,2387),(1,2388),(2,2388),(1,2389),(2,2389),(1,2390),(2,2390),(1,2394),(2,2394),(1,2398),(2,2398),(1,2400),(2,2400),(1,2401),(2,2401),(1,2402),(2,2402),(1,2403),(2,2403),(1,2404),(2,2404),(1,2406),(2,2406),(1,2407),(2,2407),(1,2408),(2,2408),(1,2411),(2,2411),(1,2412),(2,2412),(1,2413),(2,2413),(1,2414),(2,2414),(1,2415),(2,2415),(1,2417),(2,2417),(1,2422),(2,2422),(1,2423),(2,2423),(1,2424),(2,2424),(1,2428),(2,2428),(1,2429),(2,2429),(1,2430),(2,2430),(1,2432),(2,2432),(1,2433),(2,2433),(1,2434),(2,2434),(1,2442),(2,2442),(1,2443),(2,2443),(1,2447),(2,2447),(1,2448),(2,2448),(1,2449),(2,2449),(1,2462),(2,2462),(1,2464),(2,2464),(1,2465),(2,2465),(1,2466),(2,2466),(1,2467),(2,2467),(1,2468),(2,2468),(1,2470),(2,2470),(1,2471),(2,2471),(1,2476),(2,2476),(1,2478),(2,2478),(1,2479),(2,2479),(1,2480),(2,2480),(1,2481),(2,2481),(1,2487),(2,2487),(1,2490),(2,2490),(1,2491),(2,2491),(1,2492),(2,2492),(1,2493),(2,2493),(1,2494),(2,2494),(1,2498),(2,2498),(1,2500),(2,2500),(1,2501),(2,2501),(1,2503),(2,2503),(1,2505),(2,2505),(1,2506),(2,2506),(1,2507),(2,2507),(1,2509),(2,2509),(1,2510),(2,2510),(1,2511),(2,2511),(1,2512),(2,2512),(1,2513),(2,2513),(1,2514),(2,2514),(1,2521),(2,2521),(1,2522),(2,2522),(1,2523),(2,2523),(1,2524),(2,2524),(1,2525),(2,2525),(1,2526),(2,2526),(1,2527),(2,2527),(1,2528),(2,2528),(1,2529),(2,2529),(1,2530),(2,2530),(1,2531),(2,2531),(1,2532),(2,2532),(1,2533),(2,2533),(1,2534),(2,2534),(1,2535),(2,2535),(1,2536),(2,2536),(1,2537),(2,2537),(1,2538),(2,2538),(1,2539),(2,2539),(1,2540),(2,2540),(1,2541),(2,2541),(1,2542),(2,2542),(1,2545),(2,2545),(1,2548),(2,2548),(1,2549),(2,2549),(1,2554),(2,2554),(1,2555),(2,2555),(1,2578),(2,2578),(1,2585),(2,2585),(1,2586),(2,2586),(1,2587),(2,2587),(1,2588),(2,2588),(1,2589),(2,2589),(1,2590),(2,2590),(1,2591),(2,2591),(1,2592),(2,2592),(1,2593),(2,2593),(1,2597),(2,2597),(1,2598),(2,2598),(1,2599),(2,2599),(1,2600),(2,2600),(1,2601),(2,2601),(1,2602),(2,2602),(1,2603),(2,2603),(1,2604),(2,2604),(1,2607),(2,2607),(1,2608),(2,2608),(1,2609),(2,2609),(1,2611),(2,2611),(1,2612),(2,2612),(1,2613),(2,2613),(1,2614),(2,2614),(1,2615),(2,2615),(1,2616),(2,2616),(1,2617),(2,2617),(1,2618),(2,2618),(1,2619),(2,2619),(1,2620),(2,2620),(1,2621),(2,2621),(1,2622),(2,2622),(1,2623),(2,2623),(1,2625),(2,2625),(1,2626),(2,2626),(1,2627),(2,2627),(1,2628),(2,2628),(1,2629),(2,2629),(1,2630),(2,2630),(1,2631),(2,2631),(1,2632),(2,2632),(1,2633),(2,2633),(1,2634),(2,2634),(1,2635),(2,2635),(1,2637),(2,2637),(1,2638),(2,2638),(1,2639),(2,2639),(1,2777),(2,2777),(1,2795),(2,2795);
/*!40000 ALTER TABLE `discount_inventory` ENABLE KEYS */;
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
