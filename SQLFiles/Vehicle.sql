CREATE DATABASE  IF NOT EXISTS `test` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `test`;
-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: test
-- ------------------------------------------------------
-- Server version	5.7.15-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `vehicle`
--

DROP TABLE IF EXISTS `vehicle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vehicle` (
  `vehicleId` int(10) unsigned NOT NULL,
  `name` varchar(45) NOT NULL,
  `number` varchar(45) NOT NULL,
  `type` varchar(45) NOT NULL,
  `seatCapacity` tinyint(3) unsigned NOT NULL,
  `stearingType` varchar(45) NOT NULL,
  `availability` enum('true','false') NOT NULL,
  `rate` decimal(10,0) unsigned NOT NULL,
  `pickupPoint` varchar(45) DEFAULT NULL,
  `userName` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`vehicleId`),
  KEY `fk_userName_idx` (`userName`),
  CONSTRAINT `fk_userName` FOREIGN KEY (`userName`) REFERENCES `user` (`userName`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle`
--

LOCK TABLES `vehicle` WRITE;
/*!40000 ALTER TABLE `vehicle` DISABLE KEYS */;
INSERT INTO `vehicle` VALUES (1,'Hyundai Accent','D12-ABC','Economy',4,'Power','true',131,'25 Newark Airport, Bldg 25, Newark, NJ',NULL),(2,'Toyota Yaris','ANP-472','Economy',4,'Power','false',125,'2121 Lemoine Avenue, Fort Lee, NJ','pv4'),(3,'Nissan Versa','C90-ELE','Compact',5,'Power','false',140,'501 Kennedy Boulevard, North Bergen, NJ','rahil9'),(4,'Toyota RAV4','601-BHO','SUV',5,'Power','true',260,'25 Newark Airport, Bldg 25, Newark, NJ',NULL),(5,'Ford Mustang','BPW-48K','Convertible',4,'Power','true',622,'30 West Mall Drive, Jersey City, NJ',NULL),(6,'Ford F-150','578-EPY','Pickup Truck',5,'Power','false',418,'501 Kennedy Boulevard, North Bergen, NJ','Rk23');
/*!40000 ALTER TABLE `vehicle` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-10-02 20:36:25
