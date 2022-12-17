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
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(64) COLLATE utf8mb4_general_ci NOT NULL,
  `password` varchar(64) COLLATE utf8mb4_general_ci NOT NULL,
  `email` varchar(255) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `point` decimal(64,0) DEFAULT '0',
  `createTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=85 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'112','6c7nGrky/ehjM40Ivk3p3+OeoEm9r7NCzmWexUULaa4=','10756019@ntub.edu.tw',5,'2022-03-12 11:30:37'),(6,'789678','6666','gdrf',33,'2022-03-12 11:30:37'),(7,'asdsa','6c7nGrky/ehjM40Ivk3p3+OeoEm9r7NCzmWexUULaa4=','aeww@dasd.coq',0,'2022-03-12 11:30:37'),(59,'45dsee','$2y$10$z7B2p9TSVoTnNJKFdMCjBujMKQUBoMUtnii3HK7agJrQXjTXtswqi','sd',0,'2022-07-13 14:58:38'),(62,'dg5 fs','$2y$10$5s8e9jCr9q.VrhIAG2FS1uTItw2Y7bIPqFy9xFhBk9yHI9TstP.ma','sd',0,'2022-07-13 14:59:11'),(63,'dssdf','$2y$10$eLppaYuzh2PotdAHX46vuulTE5jwj/j1f4BArcZTGrHgshaRE5Kg6','jkhhjk',0,'2022-07-13 15:04:26'),(64,'sdfrrr454','$2y$10$yz8YhbqRG942L1VhjXs9..0ipHdmdhb8N9PAAsxeIpMoP69dasXs2','gvk k',0,'2022-07-15 11:23:40'),(65,'bran2003','6c7nGrky/ehjM40Ivk3p3+OeoEm9r7NCzmWexUULaa4=','jasdkj@cc.ao',0,'2022-08-10 13:54:09'),(66,'brian2003','6c7nGrky/ehjM40Ivk3p3+OeoEm9r7NCzmWexUULaa4=','niahwn',0,'2022-08-10 13:55:01'),(67,'xyzasda','8MKokPwhog3a5NHG+T1TEwz3bKsYyMYU+LWSaaaOREM=','wwlkl@nn.ca',0,'2022-08-10 15:48:59'),(68,'ntub','A6xnQhbz4Vx2HuGl4lXwZ5U2I8iziLRFnhP5eNfIRvQ=','asd123',14,'2022-10-11 22:49:49'),(69,'briankuo','TXHypZS2galLgki/mFgQy1j31P5hhpDqKhZjSgYtgRU=','brian@abc.com',22,'2022-11-15 22:33:54'),(70,'1234','A6xnQhbz4Vx2HuGl4lXwZ5U2I8iziLRFnhP5eNfIRvQ=','10756026@ntub.edu.tw',0,'2022-11-16 10:31:23'),(71,'terry','In7pPbNYdvBWJFej9WzT21CzN/ZgQal39kdbtpnlwgg=','10756015@ntub.edu.tw',1,'2022-11-16 13:05:20'),(72,'asd123','WZRHGrsBESr8wYFZ9sx0tPURuZgG2lmzyvWpwXPKz8U=','aaa@gmail.com',3,'2022-11-20 20:35:22'),(73,'add123','WZRHGrsBESr8wYFZ9sx0tPURuZgG2lmzyvWpwXPKz8U=','sssmoo@gmail.com',1,'2022-11-21 01:03:21'),(74,'ntub123','i4JWVWAb89um5aex12LZe1C7Uro9Y+RxZNn5UFQa2gg=','hh@ss',2,'2022-11-23 09:00:03'),(76,'aaa','pmWkWSBCL51Bfkhn79xPuKBKHz//H6B+mY6G9/eieuM=','10756006@ntub.edu.tw',0,'2022-11-29 20:32:54'),(77,'manager3467','pmWkWSBCL51Bfkhn79xPuKBKHz//H6B+mY6G9/eieuM=','manager@gmail.com',0,'2022-11-29 20:54:34'),(78,'ntubb','dlxlNdf5YTpohhJRtgK6wpAr51b0U86OjJE+DRSfQQo=','ntubb',1,'2022-11-30 12:10:08'),(79,'yutube','WoGmjOGODUzkNnr7lucpescsfsxispT58hjpL8EO3hA=','abc@gama.cim',0,'2022-12-02 11:16:48'),(80,'tk888','gL4jsqHp2CpVgcsDZ1s1koedU7FDkjoL6vcvFeb9mfQ=','ajj@ng.ca',4,'2022-12-15 13:57:55'),(81,'eason','t3bCHp5yBwKXc+b5s79DhuF80Z6FvPaEeDElYIDOGHc=','abc123@gmail.com',0,'2022-12-15 20:14:20'),(84,'kevin','A6xnQhbz4Vx2HuGl4lXwZ5U2I8iziLRFnhP5eNfIRvQ=','brian0214.usa@gmail.com',0,'2022-12-15 21:52:47');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-12-18  0:17:29
