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
-- Table structure for table `usercreate`
--

DROP TABLE IF EXISTS `usercreate`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usercreate` (
  `id` int NOT NULL AUTO_INCREMENT,
  `sentence` text COLLATE utf8mb4_general_ci NOT NULL COMMENT '使用者新增',
  `chinese` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `moviename` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `movietype` varchar(255) COLLATE utf8mb4_general_ci NOT NULL COMMENT '使用者輸入的電影類型',
  `time` time NOT NULL COMMENT '在電影的的幾分幾秒',
  `uploadTime` datetime DEFAULT NULL COMMENT '上傳時間',
  `create_id` int DEFAULT NULL COMMENT '上傳者',
  PRIMARY KEY (`id`),
  KEY `fk_userCreate_userCreate_1` (`create_id`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usercreate`
--

LOCK TABLES `usercreate` WRITE;
/*!40000 ALTER TABLE `usercreate` DISABLE KEYS */;
INSERT INTO `usercreate` VALUES (9,'I like to watch video ','我喜歡看影片','蜘蛛人','愛情','23:50:56','2022-03-22 18:09:00',10),(14,'You are never wrong to do the right thing.','堅持做對的事，永遠不會錯。','高年級實習生','勵志','00:30:50','2022-09-16 00:23:08',61),(15,'1123','4214','1414','414','00:04:14','2022-10-11 23:59:35',61),(16,'dodo','嘟嘟','蜘蛛人','愛情','12:33:33','2022-10-12 00:37:30',61),(17,'dodo','嘟嘟','蜘蛛人','ththt','12:33:33','2022-10-12 00:37:52',61),(18,'dodo','嘟嘟','蜘蛛人','ththt','12:33:33','2022-10-12 00:38:02',61),(19,'safa','我','蜘蛛','動作','01:31:52','2022-10-25 01:32:31',61),(20,'asd','支柱','置諸','動作','01:31:52','2022-10-25 01:35:01',61),(21,'dsdasd','我','蜘蛛人','動作','01:03:02','2022-10-25 21:33:05',61),(22,'dsdasd','我','蜘蛛人','科幻','01:03:02','2022-10-25 21:33:58',61),(23,'You are never wrong to do the right thin','堅持做對的事，永遠不會錯','高年級實習生','動作','01:02:30','2022-11-21 01:20:51',73),(24,'hate','我','我','動作','01:31:52','2022-11-21 01:32:46',72),(25,'aaa','我','我','動作','01:31:52','2022-11-21 01:33:17',72),(26,'sss','我','我','動作','01:31:52','2022-11-21 01:34:11',72),(27,'Adventure is out there','生活就是冒險。','天外奇蹟','動畫','00:50:34','2022-12-15 20:15:28',81),(28,'Adventure is out there','生活就是冒險。','天外奇蹟','動畫','00:50:34','2022-12-15 20:38:32',72);
/*!40000 ALTER TABLE `usercreate` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-12-18  0:17:21
