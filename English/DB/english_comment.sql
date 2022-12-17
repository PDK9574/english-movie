-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: 152.70.110.2    Database: english
-- ------------------------------------------------------
-- Server version	8.0.24

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
-- Table structure for table `comment`
--

DROP TABLE IF EXISTS `comment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `comment` (
  `id` int NOT NULL AUTO_INCREMENT,
  `text` text COLLATE utf8mb4_general_ci,
  `lastupdateTime` datetime DEFAULT NULL,
  `authorid` int DEFAULT NULL,
  `c_type` varchar(45) COLLATE utf8mb4_general_ci DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_comment_comment_1` (`c_type`)
) ENGINE=InnoDB AUTO_INCREMENT=62 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `comment`
--

LOCK TABLES `comment` WRITE;
/*!40000 ALTER TABLE `comment` DISABLE KEYS */;
INSERT INTO `comment` VALUES (1,'good','2022-05-18 11:39:00',1,'sentence'),(2,'太好看了吧!!','2022-10-10 11:16:59',66,'sentence'),(3,'我好喜歡喔','2022-10-10 11:18:56',66,'other'),(4,'國慶日到此一遊','2022-10-10 12:08:00',66,'other'),(8,'注意看 這個男人太狠了','2022-10-10 15:06:20',66,'other'),(9,'這個背後原因令人暖心','2022-10-10 15:06:20',66,'other'),(12,'she lost everyone.... my heart hurts. well done cdpr and trigger. well done. great anime','2022-10-10 15:20:06',66,'sentence'),(13,'RIP David, you keep all your promises:\r\nGet on the top of Arasak','2022-10-10 15:22:35',66,'sentence'),(14,'分析的很到位也滿合理','2022-10-10 15:24:20',66,'sentence'),(15,'看了多數中文影評後我還是把這部長片看完了，有料內容的','2022-10-10 15:24:46',66,'sentence'),(18,'樓上認真？','2022-10-11 22:50:03',68,'other'),(22,'今天好','2022-10-12 08:29:10',68,'other'),(23,'這部大推','2022-10-26 00:15:45',68,'sentence'),(37,'這部電影太好看了','2022-11-21 01:25:58',73,'sentence'),(53,'我喜歡','2022-12-02 11:17:42',79,'sentence'),(54,'asd','2022-12-14 22:51:12',69,'sentence'),(55,'good','2022-12-15 15:32:50',69,'sentence'),(56,'好看','2022-12-15 20:35:52',72,'sentence'),(57,'hi','2022-12-16 12:09:12',80,'sentence'),(58,'','2022-12-16 12:09:14',80,'sentence'),(59,'10756037','2022-12-16 12:09:32',80,'sentence'),(60,'我是黃宥碩','2022-12-16 12:10:10',80,'sentence'),(61,'這電影很好看','2022-12-16 13:17:33',72,'sentence');
/*!40000 ALTER TABLE `comment` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-12-18  0:17:32
