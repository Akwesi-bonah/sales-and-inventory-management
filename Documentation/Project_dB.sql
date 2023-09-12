CREATE DATABASE  IF NOT EXISTS `project_demo` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `project_demo`;
-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: project_demo
-- ------------------------------------------------------
-- Server version	8.0.34

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
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employees` (
  `employee_id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `Gender` varchar(8) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `phone_number` varchar(20) DEFAULT NULL,
  `hire_date` date DEFAULT NULL,
  PRIMARY KEY (`employee_id`)
) ENGINE=InnoDB AUTO_INCREMENT=223 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees` VALUES (216,'tomy','akan','','jajkgnm@gmail.com',NULL,NULL),(222,'Ernest','Asubonteng Nketiah','Male','anekitconsult23@gmail.com','0595001956','2023-08-29');
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `login`
--

DROP TABLE IF EXISTS `login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `login` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `USERNAME` varchar(200) NOT NULL,
  `employee_id` int DEFAULT NULL,
  `PASSWORD` varchar(200) NOT NULL,
  `ROLE` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `USERNAME` (`USERNAME`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login`
--

LOCK TABLES `login` WRITE;
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login` VALUES (12,'user',216,'user','user'),(17,'admin',216,'admin','admin'),(20,'ANEK IT CONSULT',222,'anek2023','user');
/*!40000 ALTER TABLE `login` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product_brand`
--

DROP TABLE IF EXISTS `product_brand`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product_brand` (
  `BRAND_ID` int NOT NULL AUTO_INCREMENT,
  `BRAND_NAME` varchar(200) NOT NULL,
  PRIMARY KEY (`BRAND_ID`),
  UNIQUE KEY `BRAND_NAME` (`BRAND_NAME`)
) ENGINE=InnoDB AUTO_INCREMENT=20013 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product_brand`
--

LOCK TABLES `product_brand` WRITE;
/*!40000 ALTER TABLE `product_brand` DISABLE KEYS */;
INSERT INTO `product_brand` VALUES (20004,'Brand A'),(20005,'Brand B'),(20006,'Brand C'),(20007,'Brand D'),(20008,'Brand E'),(20009,'Brand F'),(20010,'Brand G'),(20001,'Brand X'),(20002,'Brand Y'),(20003,'Brand Z'),(20012,'Toyota');
/*!40000 ALTER TABLE `product_brand` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product_catalog`
--

DROP TABLE IF EXISTS `product_catalog`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product_catalog` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `PRODUCT_NAME` varchar(200) NOT NULL,
  `DESCRIPTION` text,
  `BATCH_NUMBER` varchar(50) NOT NULL DEFAULT '',
  `MANUFACTURE_DATE` date DEFAULT NULL,
  `EXPIRY_DATE` date DEFAULT NULL,
  `BRAND_ID` int DEFAULT NULL,
  `CATEGORY_ID` int DEFAULT NULL,
  `PRICE` decimal(6,2) NOT NULL,
  `STOCK_COUNT` int DEFAULT '0',
  `SOLD_OUT` int DEFAULT '0',
  `NOT_SOLD` int DEFAULT '0',
  `STOCK_LEVEL` int DEFAULT '0',
  `STOCK_IN` tinyint(1) DEFAULT '0',
  `OUT_OF_STOCK` tinyint(1) DEFAULT '0',
  `CREATED_AT` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `UPDATED_AT` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`),
  KEY `BRAND_ID` (`BRAND_ID`),
  KEY `CATEGORY_ID` (`CATEGORY_ID`),
  CONSTRAINT `product_catalog_ibfk_1` FOREIGN KEY (`BRAND_ID`) REFERENCES `product_brand` (`BRAND_ID`) ON DELETE CASCADE,
  CONSTRAINT `product_catalog_ibfk_2` FOREIGN KEY (`CATEGORY_ID`) REFERENCES `product_category` (`CATEGORY_ID`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=95 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product_catalog`
--

LOCK TABLES `product_catalog` WRITE;
/*!40000 ALTER TABLE `product_catalog` DISABLE KEYS */;
INSERT INTO `product_catalog` VALUES (44,'Apple','fresh fruit','B20230819095800',NULL,NULL,20001,10001,5.00,150,18,2,20,1,0,'2023-08-19 09:58:00','2023-08-30 10:32:44'),(45,'Banana','Sweet and ripe banana','B20230819095800',NULL,NULL,20001,10001,0.49,150,8,12,20,1,0,'2023-08-19 09:58:00','2023-08-30 08:17:24'),(46,'Orange','Citrusy and nutritious orange','B20230819095800',NULL,NULL,20001,10001,1.25,120,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-28 20:44:10'),(47,'Tomato','Ripe and juicy tomato','B20230819095800',NULL,NULL,20001,10001,0.75,120,1,13,14,1,0,'2023-08-19 09:58:00','2023-08-30 08:17:24'),(48,'Lettuce','Crisp and fresh lettuce','B20230819095800',NULL,NULL,20001,10001,1.50,113,0,23,23,1,0,'2023-08-19 09:58:00','2023-08-28 20:44:10'),(49,'Carrot','Healthy and crunchy carrot','B20230819095800',NULL,NULL,20001,10001,0.99,110,22,0,22,1,0,'2023-08-19 09:58:00','2023-08-30 08:15:43'),(50,'Milk','Fresh cow milk','B20230819095800',NULL,NULL,20002,10002,5.00,80,100,0,100,0,1,'2023-08-19 09:58:00','2023-08-30 10:33:53'),(51,'Cheese','Assorted cheese types','B20230819095800',NULL,NULL,20002,10002,3.99,40,39,0,39,1,0,'2023-08-19 09:58:00','2023-08-28 20:20:36'),(52,'Yogurt','Creamy and delicious yogurt','B20230819095800',NULL,NULL,20002,10002,1.25,60,25,0,25,1,0,'2023-08-19 09:58:00','2023-08-30 10:29:02'),(53,'Butter','Creamy butter for cooking and spreading','B20230819095800',NULL,NULL,20002,10002,2.00,30,2,0,2,1,0,'2023-08-19 09:58:00','2023-08-25 17:05:28'),(54,'Bread','Freshly baked bread','B20230819095800',NULL,NULL,20003,10003,2.49,70,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(55,'Rolls','Soft dinner rolls','B20230819095800',NULL,NULL,20003,10003,1.99,50,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(56,'Pastry','Assorted pastries','B20230819095800',NULL,NULL,20003,10003,1.75,60,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(57,'Cake','Delicious cakes for all occasions','B20230819095800',NULL,NULL,20003,10003,12.99,15,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(58,'Beef','Quality beef cuts','B20230819095800',NULL,NULL,20004,10004,9.99,40,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(59,'Chicken','Fresh chicken meat','B20230819095800',NULL,NULL,20004,10004,6.99,55,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(60,'Pork','Tender pork cuts','B20230819095800',NULL,NULL,20004,10004,7.50,30,20,0,20,1,0,'2023-08-19 09:58:00','2023-08-29 19:07:48'),(61,'Lamb','Premium lamb meat','B20230819095800',NULL,NULL,20004,10004,11.99,20,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(62,'Salmon','Fresh salmon fillets','B20230819095800',NULL,NULL,20005,10005,14.99,35,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(63,'Tilapia','Delicate tilapia fillets','B20230819095800',NULL,NULL,20005,10005,9.99,40,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(64,'Shrimp','Tasty shrimp varieties','B20230819095800',NULL,NULL,20005,10005,12.49,50,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(65,'Crab','Succulent crab meat','B20230819095800',NULL,NULL,20005,10005,16.99,25,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(66,'Frozen Vegetables','Assorted frozen vegetables','B20230819095800',NULL,NULL,20006,10006,2.99,80,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(67,'Frozen Pizza','Delicious frozen pizzas','B20230819095800',NULL,NULL,20006,10006,5.49,60,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(68,'Ice Cream','Various ice cream flavors','B20230819095800',NULL,NULL,20006,10006,3.99,100,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(69,'Soft Drinks','Assorted soft drink flavors','B20230819095800',NULL,NULL,20007,10007,1.25,150,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(70,'Juices','Fruit juices for a refreshing drink','B20230819095800',NULL,NULL,20007,10007,2.49,120,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(71,'Bottled Water','Pure bottled water','B20230819095800',NULL,NULL,20007,10007,0.99,200,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(72,'Coffee','Ground coffee for brewing','B20230819095800',NULL,NULL,20007,10007,6.99,80,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(73,'Tea','Variety of tea blends','B20230819095800',NULL,NULL,20007,10007,3.50,100,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(74,'Chips','Assorted chip flavors','B20230819095800',NULL,NULL,20001,10008,1.75,120,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(75,'Pretzels','Salty and crunchy pretzels','B20230819095800',NULL,NULL,20001,10008,1.49,80,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(76,'Nuts','Roasted nut varieties','B20230819095800',NULL,NULL,20001,10008,2.99,90,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(77,'Cookies','Delicious cookie assortments','B20230819095800',NULL,NULL,20001,10008,3.25,100,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(78,'Crackers','Crisp and flavorful crackers','B20230819095800',NULL,NULL,20001,10008,1.99,78,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-20 10:17:31'),(79,'Soups','Various canned soup types','B20230819095800',NULL,NULL,20004,10009,2.49,60,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(80,'Beans','Canned beans for cooking','B20230819095800',NULL,NULL,20004,10009,1.49,70,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(81,'Vegetables','Canned vegetable varieties','B20230819095800',NULL,NULL,20004,10009,1.75,80,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(82,'Fruits','Canned fruit assortments','B20230819095800',NULL,NULL,20004,10009,2.25,50,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(83,'Cleaning Products','Cleaning supplies for your home','B20230819095800',NULL,NULL,20005,10010,3.99,40,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(84,'Paper Towels','Absorbent paper towels','B20230819095800',NULL,NULL,20005,10010,1.99,70,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(85,'Toilet Paper','Soft and high-quality toilet paper','B20230819095800',NULL,NULL,20005,10010,2.25,60,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(86,'Trash Bags','Strong trash bags for waste disposal','B20230819095800',NULL,NULL,20005,10010,3.49,50,0,0,0,1,0,'2023-08-19 09:58:00','2023-08-19 09:58:00'),(88,'Adom Manago','fresh fruits','B20230823183136','2023-08-01','2023-11-02',20004,10001,12.50,4,0,0,0,1,0,'2023-08-23 18:31:36','2023-08-23 18:32:13'),(89,'Helix','2023 brand','B20230828203303','2023-06-14','2024-02-09',20012,10014,2400.00,15,0,0,0,1,0,'2023-08-28 20:33:03','2023-08-28 20:33:03');
/*!40000 ALTER TABLE `product_catalog` ENABLE KEYS */;
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
/*!50003 CREATE*/ /*!50017 DEFINER=`Admin`@`%`*/ /*!50003 TRIGGER `trg_generate_batch_number` BEFORE INSERT ON `product_catalog` FOR EACH ROW BEGIN
    SET NEW.BATCH_NUMBER = CONCAT('B', DATE_FORMAT(NOW(), '%Y%m%d%H%i%s'));
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`Admin`@`%`*/ /*!50003 TRIGGER `trg_calculate_stock_level` BEFORE UPDATE ON `product_catalog` FOR EACH ROW BEGIN
    SET NEW.stock_level = NEW.sold_out + NEW.not_sold;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`Admin`@`%`*/ /*!50003 TRIGGER `trg_stock_out_or_in` BEFORE UPDATE ON `product_catalog` FOR EACH ROW BEGIN
    DECLARE calculated_stock INT;
    SET calculated_stock = NEW.stock_count - NEW.stock_level;

    IF calculated_stock <= 0 THEN
        SET NEW.out_of_stock = 1;
    ELSE
        SET NEW.out_of_stock = 0;
    END IF;
    
    IF calculated_stock > 0 THEN
        SET NEW.stock_in = 1;
    ELSE
        SET NEW.stock_in = 0;
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `product_category`
--

DROP TABLE IF EXISTS `product_category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product_category` (
  `CATEGORY_ID` int NOT NULL AUTO_INCREMENT,
  `CATEGORY_NAME` varchar(200) NOT NULL,
  PRIMARY KEY (`CATEGORY_ID`),
  UNIQUE KEY `CATEGORY_NAME` (`CATEGORY_NAME`)
) ENGINE=InnoDB AUTO_INCREMENT=10015 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product_category`
--

LOCK TABLES `product_category` WRITE;
/*!40000 ALTER TABLE `product_category` DISABLE KEYS */;
INSERT INTO `product_category` VALUES (10004,'Bakery'),(10008,'Beverages'),(10010,'Canned Goods'),(10014,'Cars'),(10003,'Dairy'),(10007,'Frozen Foods'),(10001,'Fruits'),(10011,'Household Supplies'),(10005,'Meat and Poultry'),(10006,'Seafood'),(10009,'Snacks'),(10002,'Vegetables');
/*!40000 ALTER TABLE `product_category` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `productsummary`
--

DROP TABLE IF EXISTS `productsummary`;
/*!50001 DROP VIEW IF EXISTS `productsummary`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `productsummary` AS SELECT 
 1 AS `ProductID`,
 1 AS `Product Name`,
 1 AS `Description`,
 1 AS `Sold Out`,
 1 AS `Not Sold`,
 1 AS `Stock Count`,
 1 AS `Stock Level`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `sales`
--

DROP TABLE IF EXISTS `sales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sales` (
  `SaleID` int NOT NULL AUTO_INCREMENT,
  `invoice` text,
  `employee_id` int NOT NULL,
  `SaleDate` datetime NOT NULL,
  `Amount` decimal(7,2) NOT NULL,
  `PaymentMethod` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`SaleID`),
  KEY `employee_id` (`employee_id`),
  CONSTRAINT `sales_ibfk_1` FOREIGN KEY (`employee_id`) REFERENCES `employees` (`employee_id`)
) ENGINE=InnoDB AUTO_INCREMENT=52 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sales`
--

LOCK TABLES `sales` WRITE;
/*!40000 ALTER TABLE `sales` DISABLE KEYS */;
INSERT INTO `sales` VALUES (2,'2023110416-4284',216,'2023-08-19 11:04:17',7.98,'Cash'),(3,'2023112236-2718',216,'2023-08-19 11:22:36',7.50,'Card'),(4,'2023112304-3084',216,'2023-08-19 11:23:05',10.00,'voucher'),(5,'2023115321-4912',216,'2023-08-19 11:53:21',10.00,'voucher'),(6,'2023115349-5987',216,'2023-08-19 11:53:50',71.82,'Card'),(8,'2023183747-7895',216,'2023-08-22 18:37:47',2.50,'voucher'),(9,'2023183759-6956',216,'2023-08-22 18:37:59',7.50,'Card'),(10,'2023183825-5665',216,'2023-08-22 18:38:25',5.00,'MoMo'),(11,'2023165859-1732',216,'2023-08-23 16:59:00',2.50,'voucher'),(12,'2023185234-1451',216,'2023-08-23 18:52:34',75.00,'voucher'),(13,'2023164452-7015',216,'2023-08-25 16:44:52',3.99,'Cash'),(14,'2023165503-3062',216,'2023-08-25 16:55:03',3.99,'Cash'),(16,'2023165947-7623',216,'2023-08-25 16:59:48',3.99,'Cash'),(17,'2023170109-9205',216,'2023-08-25 17:01:10',2.00,'Cash'),(18,'2023170232-8302',216,'2023-08-25 17:02:33',2.50,'Cash'),(19,'2023170528-8980',216,'2023-08-25 17:05:29',13.97,'Cash'),(20,'2023170911-2877',216,'2023-08-25 17:09:12',3.99,'Cash'),(21,'2023171005-3806',216,'2023-08-25 17:10:06',3.99,'Cash'),(22,'2023171520-7498',216,'2023-08-25 17:15:21',3.99,'Cash'),(23,'2023171656-5704',216,'2023-08-25 17:16:56',18.46,'Cash'),(24,'2023171755-1669',216,'2023-08-25 17:17:56',3.99,'Cash'),(25,'2023172624-5807',216,'2023-08-25 17:26:24',3.99,'Cash'),(26,'2023173820-9688',216,'2023-08-25 17:38:20',2.50,'Cash'),(27,'2023201816-2315',216,'2023-08-28 20:18:17',2.50,'Cash'),(28,'2023202036-2000',216,'2023-08-28 20:20:37',39.30,'voucher'),(29,'2023152803-4318',216,'2023-08-29 15:28:03',0.49,'Cash'),(30,'2023190412-1882',216,'2023-08-29 19:04:12',655.00,'Card'),(31,'2023190651-3643',216,'2023-08-29 19:06:52',132.50,'MoMo'),(32,'2023190851-3787',216,'2023-08-29 19:08:51',154.95,'Cash'),(33,'2023191634-4694',216,'2023-08-29 19:16:34',2.50,'MoMo'),(36,'2023070105-2386',216,'2023-08-30 07:01:06',120.00,'Cash'),(37,'2023070529-5659',216,'2023-08-30 07:05:29',0.49,'Cash'),(38,'2023070916-9014',216,'2023-08-30 07:09:16',120.00,'Cash'),(39,'2023071708-8556',216,'2023-08-30 07:17:09',120.00,'Cash'),(40,'2023073221-9076',216,'2023-08-30 07:32:21',0.49,'Cash'),(41,'2023074018-8391',216,'2023-08-30 07:40:18',0.49,'Cash'),(42,'2023074319-2997',216,'2023-08-30 07:43:20',120.00,'Cash'),(43,'2023074638-7047',216,'2023-08-30 07:46:39',120.00,'Cash'),(44,'2023080025-2835',216,'2023-08-30 08:00:25',0.49,'Cash'),(45,'2023080417-8045',216,'2023-08-30 08:04:17',120.00,'Cash'),(46,'2023080738-3281',216,'2023-08-30 08:07:39',0.49,'Cash'),(47,'2023081332-5861',216,'2023-08-30 08:13:32',0.49,'Cash'),(48,'2023081543-1873',216,'2023-08-30 08:15:43',0.99,'Cash'),(49,'2023081724-6253',216,'2023-08-30 08:17:25',1.24,'Cash'),(50,'2023091830-8735',216,'2023-08-30 09:18:31',120.00,'Cash'),(51,'2023103005-4539',216,'2023-08-30 10:30:05',1206.25,'MoMo');
/*!40000 ALTER TABLE `sales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `salesitems`
--

DROP TABLE IF EXISTS `salesitems`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `salesitems` (
  `SalesItemID` int NOT NULL AUTO_INCREMENT,
  `SaleID` int NOT NULL,
  `ProductName` varchar(200) NOT NULL,
  `Quantity` int NOT NULL,
  `Price` decimal(10,2) NOT NULL,
  `Subtotal` decimal(10,2) NOT NULL,
  PRIMARY KEY (`SalesItemID`),
  KEY `SaleID` (`SaleID`),
  CONSTRAINT `salesitems_ibfk_1` FOREIGN KEY (`SaleID`) REFERENCES `sales` (`SaleID`)
) ENGINE=InnoDB AUTO_INCREMENT=57 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salesitems`
--

LOCK TABLES `salesitems` WRITE;
/*!40000 ALTER TABLE `salesitems` DISABLE KEYS */;
INSERT INTO `salesitems` VALUES (1,2,'Cheese',2,2.00,2.00),(2,3,'Milk',3,3.00,3.00),(3,4,'Yogurt',8,8.00,8.00),(4,5,'Milk',4,4.00,4.00),(5,6,'Cheese',18,18.00,18.00),(6,8,'Milk',1,1.00,1.00),(7,9,'Milk',3,3.00,3.00),(8,10,'Milk',2,2.00,2.00),(9,11,'Milk',1,1.00,1.00),(10,12,'Milk',30,30.00,30.00),(11,13,'Cheese',1,1.00,1.00),(12,14,'Cheese',1,1.00,1.00),(13,16,'Cheese',1,1.00,1.00),(14,17,'Butter',1,1.00,1.00),(15,18,'Yogurt',2,2.00,2.00),(16,19,'Cheese',3,3.00,3.00),(17,19,'Butter',1,1.00,1.00),(18,20,'Cheese',1,1.00,1.00),(19,21,'Cheese',1,1.00,1.00),(20,22,'Cheese',1,1.00,1.00),(21,23,'Milk',1,1.00,1.00),(22,23,'Cheese',4,4.00,4.00),(23,24,'Cheese',1,1.00,1.00),(24,25,'Cheese',1,1.00,1.00),(25,26,'Milk',1,1.00,1.00),(26,27,'Milk',1,1.00,1.00),(27,28,'Carrot',16,16.00,16.00),(28,28,'Cheese',4,4.00,4.00),(29,28,'Milk',3,3.00,3.00),(30,29,'Banana',1,1.00,1.00),(31,30,'KFC',10,10.00,10.00),(32,30,'Milk',50,50.00,50.00),(33,31,'Apple',1,1.00,1.00),(34,31,'Yogurt',10,10.00,10.00),(35,32,'Carrot',5,5.00,5.00),(36,32,'Pork',20,20.00,20.00),(37,33,'Shaving Stick',1,1.00,1.00),(38,36,'Apple',1,1.00,1.00),(39,37,'Banana',1,1.00,1.00),(40,38,'Apple',1,1.00,1.00),(41,39,'Apple',1,1.00,1.00),(42,40,'Banana',1,1.00,1.00),(43,40,'Tomato',0,0.00,0.00),(44,41,'Banana',1,1.00,1.00),(45,42,'Apple',1,1.00,1.00),(46,43,'Apple',1,1.00,1.00),(47,44,'Banana',1,1.00,1.00),(48,45,'Apple',1,1.00,1.00),(49,46,'Banana',1,1.00,1.00),(50,47,'Banana',1,1.00,1.00),(51,48,'Carrot',1,1.00,1.00),(52,49,'Tomato',1,1.00,1.00),(53,49,'Banana',1,1.00,1.00),(54,50,'Apple',1,1.00,1.00),(55,51,'Apple',10,10.00,10.00),(56,51,'Yogurt',5,5.00,5.00);
/*!40000 ALTER TABLE `salesitems` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'project_demo'
--

--
-- Dumping routines for database 'project_demo'
--
/*!50003 DROP PROCEDURE IF EXISTS `UpdateStockLevel` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`Admin`@`%` PROCEDURE `UpdateStockLevel`(IN productName VARCHAR(200), IN newStockCount INT)
BEGIN
    UPDATE product_catalog
    SET STOCK_COUNT = STOCK_COUNT + newStockCount
    WHERE PRODUCT_NAME = productName;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `productsummary`
--

/*!50001 DROP VIEW IF EXISTS `productsummary`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`Admin`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `productsummary` AS select `pc`.`ID` AS `ProductID`,`pc`.`PRODUCT_NAME` AS `Product Name`,`pc`.`DESCRIPTION` AS `Description`,`pc`.`SOLD_OUT` AS `Sold Out`,`pc`.`NOT_SOLD` AS `Not Sold`,`pc`.`STOCK_COUNT` AS `Stock Count`,`pc`.`STOCK_LEVEL` AS `Stock Level` from `product_catalog` `pc` */;
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

-- Dump completed on 2023-08-30 10:38:49
