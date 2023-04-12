-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: anime_database
-- ------------------------------------------------------
-- Server version	8.0.32

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
-- Table structure for table `anime`
--

DROP TABLE IF EXISTS `anime`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `anime` (
  `anime_id` int NOT NULL AUTO_INCREMENT,
  `anime_title` varchar(200) NOT NULL,
  `anime_episode_count` int DEFAULT NULL,
  `studio_id` int DEFAULT NULL,
  `genre_id` int DEFAULT NULL,
  `writer_id` int DEFAULT NULL,
  `director_id` int DEFAULT NULL,
  PRIMARY KEY (`anime_id`),
  KEY `studio_id` (`studio_id`),
  KEY `genre_id` (`genre_id`),
  KEY `writer_id` (`writer_id`),
  KEY `director_id` (`director_id`),
  CONSTRAINT `anime_ibfk_1` FOREIGN KEY (`studio_id`) REFERENCES `studio` (`studio_id`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `anime_ibfk_2` FOREIGN KEY (`genre_id`) REFERENCES `genre` (`genre_id`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `anime_ibfk_3` FOREIGN KEY (`writer_id`) REFERENCES `writer` (`writer_id`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `anime_ibfk_4` FOREIGN KEY (`director_id`) REFERENCES `director` (`director_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `anime`
--

LOCK TABLES `anime` WRITE;
/*!40000 ALTER TABLE `anime` DISABLE KEYS */;
INSERT INTO `anime` VALUES (11,'Shingeki no Kyojin',25,1,1,1,1),(12,'Death Note',37,2,2,2,2),(13,'Fullmetal Alchemist: Brotherhood',37,3,3,3,3),(14,'One Punch Man',37,4,4,4,4),(15,'Sword Art Online',37,5,5,5,5),(16,'Boku no Hero Academia',37,6,6,6,6),(17,'Kimetsu no Yaiba',37,7,7,7,7),(18,'Naruto',37,1,8,8,8),(21,'Tokyo Ghoul',37,1,1,1,7),(22,'Hunter x Hunter',37,3,10,2,1),(27,'Chainsaw Man',24,1,2,1,2),(35,'Elfen Lied',25,1,2,2,2);
/*!40000 ALTER TABLE `anime` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `anime_count`
--

DROP TABLE IF EXISTS `anime_count`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `anime_count` (
  `count` int NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `anime_count`
--

LOCK TABLES `anime_count` WRITE;
/*!40000 ALTER TABLE `anime_count` DISABLE KEYS */;
INSERT INTO `anime_count` VALUES (12);
/*!40000 ALTER TABLE `anime_count` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `director`
--

DROP TABLE IF EXISTS `director`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `director` (
  `director_id` int NOT NULL AUTO_INCREMENT,
  `director_name` varchar(100) NOT NULL,
  `director_nationality` varchar(100) DEFAULT NULL,
  `studio_id` int DEFAULT NULL,
  PRIMARY KEY (`director_id`),
  KEY `studio_id` (`studio_id`),
  CONSTRAINT `director_ibfk_1` FOREIGN KEY (`studio_id`) REFERENCES `studio` (`studio_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `director`
--

LOCK TABLES `director` WRITE;
/*!40000 ALTER TABLE `director` DISABLE KEYS */;
INSERT INTO `director` VALUES (1,'Tetsurō Araki','Japanese',1),(2,'Yasuhiro Irie','Japanese',2),(3,'Tomohiko Ito','Japanese',3),(4,'Kenji Nagasaki','Japanese',4),(5,'Haruo Sotozaki','Japanese',5),(6,'Hayato Date','Japanese',6),(7,'Tadahito Matsubayashi','Japanese',7),(8,'Hiroshi Kōjina','Japanese',1);
/*!40000 ALTER TABLE `director` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `genre`
--

DROP TABLE IF EXISTS `genre`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `genre` (
  `genre_id` int NOT NULL AUTO_INCREMENT,
  `genre_type` varchar(100) NOT NULL,
  PRIMARY KEY (`genre_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genre`
--

LOCK TABLES `genre` WRITE;
/*!40000 ALTER TABLE `genre` DISABLE KEYS */;
INSERT INTO `genre` VALUES (1,'Action'),(2,'Drama'),(3,'Suspense'),(4,'Supernatural'),(5,'Adventure'),(6,'Fantasy'),(7,'Comedy'),(8,'Romance'),(9,'Horror'),(10,'Action');
/*!40000 ALTER TABLE `genre` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `studio`
--

DROP TABLE IF EXISTS `studio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `studio` (
  `studio_id` int NOT NULL AUTO_INCREMENT,
  `studio_name` varchar(100) NOT NULL,
  PRIMARY KEY (`studio_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studio`
--

LOCK TABLES `studio` WRITE;
/*!40000 ALTER TABLE `studio` DISABLE KEYS */;
INSERT INTO `studio` VALUES (1,'Wit Studio'),(2,'Madhouse'),(3,'Bones'),(4,'A-1 Pictures'),(5,'Ufotable'),(6,'Pierrot'),(7,'Bones');
/*!40000 ALTER TABLE `studio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'Karl Millare','iamgroot'),(17,'Seris Vritra','iaminevitable');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `view_one`
--

DROP TABLE IF EXISTS `view_one`;
/*!50001 DROP VIEW IF EXISTS `view_one`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_one` AS SELECT 
 1 AS `anime_title`,
 1 AS `anime_episode_count`,
 1 AS `genre_type`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_three`
--

DROP TABLE IF EXISTS `view_three`;
/*!50001 DROP VIEW IF EXISTS `view_three`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_three` AS SELECT 
 1 AS `anime_title`,
 1 AS `studio_name`,
 1 AS `genre_type`,
 1 AS `director_name`,
 1 AS `writer_name`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_two`
--

DROP TABLE IF EXISTS `view_two`;
/*!50001 DROP VIEW IF EXISTS `view_two`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_two` AS SELECT 
 1 AS `anime_title`,
 1 AS `studio_name`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `writer`
--

DROP TABLE IF EXISTS `writer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `writer` (
  `writer_id` int NOT NULL AUTO_INCREMENT,
  `writer_name` varchar(100) NOT NULL,
  `writer_nationality` varchar(100) DEFAULT NULL,
  `studio_id` int DEFAULT NULL,
  PRIMARY KEY (`writer_id`),
  KEY `studio_id` (`studio_id`),
  CONSTRAINT `writer_ibfk_1` FOREIGN KEY (`studio_id`) REFERENCES `studio` (`studio_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `writer`
--

LOCK TABLES `writer` WRITE;
/*!40000 ALTER TABLE `writer` DISABLE KEYS */;
INSERT INTO `writer` VALUES (1,'Yoshihiro Togashi','Japanese',1),(2,'Hajime Isayama','Japanese',2),(3,'Tsugumi Ohba','Japanese',3),(4,'Hiromu Arakawa','Japanese',4),(5,'Kōhei Horikoshi','Japanese',5),(6,'Reki Kawahara','Japanese',6),(7,'Koyoharu Gotouge','Japanese',7),(8,'Masashi Kishimoto','Japanese',1),(9,'Sui Ishida','Japanese',2);
/*!40000 ALTER TABLE `writer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `view_one`
--

/*!50001 DROP VIEW IF EXISTS `view_one`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_one` AS select `anime`.`anime_title` AS `anime_title`,`anime`.`anime_episode_count` AS `anime_episode_count`,`genre`.`genre_type` AS `genre_type` from (`anime` join `genre` on((`anime`.`genre_id` = `genre`.`genre_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_three`
--

/*!50001 DROP VIEW IF EXISTS `view_three`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_three` AS select `anime`.`anime_title` AS `anime_title`,`studio`.`studio_name` AS `studio_name`,`genre`.`genre_type` AS `genre_type`,`director`.`director_name` AS `director_name`,`writer`.`writer_name` AS `writer_name` from ((((`anime` join `studio` on((`anime`.`studio_id` = `studio`.`studio_id`))) join `genre` on((`anime`.`genre_id` = `genre`.`genre_id`))) join `director` on((`anime`.`director_id` = `director`.`director_id`))) join `writer` on((`anime`.`writer_id` = `writer`.`writer_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_two`
--

/*!50001 DROP VIEW IF EXISTS `view_two`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_two` AS select `anime`.`anime_title` AS `anime_title`,`studio`.`studio_name` AS `studio_name` from (`anime` join `studio` on((`anime`.`studio_id` = `studio`.`studio_id`))) */;
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

-- Dump completed on 2023-04-12 23:01:23
