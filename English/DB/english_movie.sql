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
-- Table structure for table `movie`
--

DROP TABLE IF EXISTS `movie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movie` (
  `id` int NOT NULL AUTO_INCREMENT,
  `en_movie_name` varchar(255) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `ch_movie_name` varchar(255) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `movietype_id` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=251 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movie`
--

LOCK TABLES `movie` WRITE;
/*!40000 ALTER TABLE `movie` DISABLE KEYS */;
INSERT INTO `movie` VALUES (1,'TENET','天能',5),(2,'Spider Man','蜘蛛人',1),(3,'TITANIC','鐵達尼號',4),(4,'Toy Story','玩具總動員',2),(5,'The Fast and the Furious','玩命關頭',1),(6,'Avengers: Endgame','復仇者聯盟4：終局之戰',6),(7,'Conjuring','厲陰宅',3),(8,'Forrest Gump','阿甘正傳',8),(9,'The Notebook','手札情緣',4),(10,'The Lion King','獅子王',2),(11,'Sleepless in Seattle','西雅圖不眠夜',4),(12,'A Room with a View','窗外有藍天',8),(13,'The Bridges of Madison','麥迪遜之橋',4),(14,'If Only','如果能再愛一次',4),(15,'Indecent Proposal','桃色交易',8),(16,'Up','天外奇蹟',2),(17,'Good will hunting','心靈捕手',8),(18,'The English Patient','英倫情人',4),(19,'When Harry Met Sally...','當哈利遇見莎莉',4),(20,'My Blueberry Nights','我的藍莓夜',4),(21,'Inception  ','全面啟動',5),(22,'50 First Dates','我的失憶女友',4),(23,'The Curious Case of Benjamin Button','班傑明的奇幻旅程',4),(24,'Gone with the Wind','亂世佳人',4),(25,'P.S. I Love You','PS我愛你',4),(26,'Amelie','艾蜜莉的異想世界',8),(27,'One Day','真愛挑日子',4),(28,'Cold Mountain','冷山',8),(29,'Once','曾經 愛是唯一',4),(30,'Jerry Maguire','征服情海',4),(31,'Sleepless in Seattle','西雅圖夜未眠',4),(32,'Dear John','最後一封情書',4),(33,'Edward Scissorhands','剪刀手愛德華',4),(34,'The Odd Couple','單身公寓',4),(35,'500 DAYS OF SUMMER','戀夏500天',4),(36,'Brokeback Mountain','斷背山',4),(37,'The fault in our stars','生命中的美好缺憾',4),(38,'Silver Linings Playbook','派特的幸福劇本',4),(39,'No Time to Die','007：生死交戰',1),(40,'Star Wars','星際大戰',5),(41,'Twilight','暮光之城：無懼的愛',1),(42,'Maleficent: Mistress of Evil','黑魔女2',7),(43,'Begin Again','曼哈頓戀習曲',4),(44,'Melody','兩小無猜',4),(45,'The Good Liar','大說謊家',7),(46,'The Lord of the Rings','魔戒',1),(47,' Wonder Woman 1984 Quotes','神力女超人1984',1),(48,'Love Actually ','愛是您愛是我',4),(49,'The Holiday','戀愛沒有假期',4),(50,'You\'ve Got Mail','電子情書',4),(51,'Silver Linings Playbook','派特的幸福劇本',4),(52,'Hitch','全民情聖',4),(53,'Her','雲端情人',4),(54,'Just Married','新婚告急',4),(55,'Love Actually','愛是您・愛是我',4),(56,'Sex and the City: The Movie','慾望城市',4),(57,'Ghost','第六感生死戀',4),(58,'A Star Is Born','一個巨星的誕生',4),(59,'Juno','鴻孕當頭',4),(60,'Pride and Prejudice','傲慢與偏見',4),(61,'The Theory of Everything','愛的萬物論',4),(62,'Emma','艾瑪姑娘要出嫁',4),(63,'Notting Hill','新娘百分百',4),(64,'Who You Think I Am','別問我是誰',4),(65,'Call Me by Your Name','以你的名字呼喚我',4),(66,'Before Midnight','愛在午夜希臘時',4),(67,'About Time','真愛每一天',4),(68,'To All the Boys: P.S. I Still Love You','愛的過去進行式：P.S. 我仍愛你',4),(69,'Love, Rosie','真愛繞圈圈',4),(70,'Me Before You','我就要你好好的 ',4),(71,'Pretty Woman','麻雀變鳳凰',4),(72,'The English Patient','我的英倫情人',4),(73,'Before Sunrise','愛在黎明破曉時',4),(74,'La La Land','星聲夢裡人',4),(75,'Fly Me to Polaris','星願',4),(76,'It: Chapter Two','牠：第二章',3),(77,'Hereditary','宿怨',3),(78,'The Autopsy of Jane Doe','驗屍官',3),(79,'A Quiet Place','噤界',3),(80,'Sherlock','新世紀福爾摩斯',7),(81,'A Study in Scarlet','血字的研究',7),(82,'Criminal Minds','犯罪心理',7),(83,'Joker','小丑',7),(84,'A Nightmare on Elm Street','半夜鬼上床',3),(85,'The Texas Chain Saw Massacre','德州電鋸殺人狂',3),(86,'Iron Man','鋼鐡人',6),(87,'Captain America','美國隊長',6),(88,'Ant-Man','蟻人',6),(89,'Captain America: Civil War','美國隊長3：英雄內戰',6),(90,'Doctor Strang','奇異博士',6),(91,'Guardians of the Galaxy Vol. 2','星際異攻隊2',6),(92,'Spider-Man: Homecoming','蜘蛛人：返校日',6),(93,'Thor: Ragnarok','雷神索爾3',6),(94,'Avengers: Infinity War','復仇者聯盟3︰無限之戰',6),(95,'Avengers: Endgame','復仇者聯盟4︰終局之戰',6),(96,'Captain America: The Winter Soldier','美國隊長2：酷寒戰士',6),(97,'Black Panther','黑豹',6),(98,'The Avengers','復仇者聯盟',6),(99,'Black Widow','黑寡婦',6),(100,'Alice\'s Adventures in Wonderland','愛麗絲夢遊仙境',2),(101,'Shrek','史瑞克',2),(102,'The Princess and the Frog','公主與青蛙',2),(103,'Made of Honour','新郎不是我',4),(104,'10 Things I Hate About You','對面惡女看過來',4),(105,'Harry Potter and the Chamber of Secrets','哈利波特：消失的密室',5),(106,'The Pursuit of Happyness','當幸褔來敲門',8),(107,'The Secret Life of Walter Mitty','白日夢冒險王',8),(108,'All the King\'s Men','國王人馬',8),(109,'3 Idiots','三個傻瓜',8),(110,'Secret in Their Eyes','沉默的雙眼',7),(111,'Gran Torino','經典老爺車',7),(112,'Man on Fire','火線救援',1),(113,'The Godfather','教父',7),(114,'Scarface','疤面煞星',7),(115,'Taken','即刻救援',1),(116,'The Predator','終極戰士',5),(117,'Aliens','異形2',5),(118,'Sudden Impact','撥雲見日',1),(119,'A Few Good Men','軍官與魔鬼',1),(120,'Avatar','阿凡達',5),(121,'Batman','蝙蝠俠',1),(122,'Hugo','雨果的冒險',5),(123,'On the Waterfront','岸上風雲',4),(124,'The Wizard of Oz','綠野仙蹤',5),(125,'Casablanca','北非諜影',4),(126,'Dirty Harry','撥雲見日',7),(127,'Sunset Boulevard','紅樓金粉',7),(128,'All About Eve','彗星美人',8),(129,'Taxi Driver','計程車司機',7),(130,'Cool Hand Luke','鐵窗喋血',7),(131,'Apocalypse Now','現代啟示錄',7),(132,'Love Story','愛情故事',4),(133,'The Maltese Falcon','梟巢喋血戰',1),(134,'E.T.','E.T.外星人',5),(135,'In the Heat of the Night','惡夜追緝令',7),(136,'Citizen Kane','大國民',8),(137,'White Heat','白熱',7),(138,'Network','螢光幕後',8),(139,'The Silence of the Lambs','沉默的羔羊',7),(140,'Dr. No','第七號情報員',1),(141,'She Done Him Wrong','儂本多情',4),(142,'Midnight Cowboy','午夜牛郎',8),(143,'Grand Hotel','大飯店',8),(144,'When Harry Met Sally...','當哈利遇上莎莉',4),(145,'Escape','逃亡',7),(146,'Jaws','大白鯊',1),(147,'The Treasure of the Sierra Madre','碧血金沙',8),(148,'The Terminator','魔鬼終結者',5),(149,'The Pride of the Yankees','洋基的驕傲',8),(150,'Field of Dreams','夢幻成真',8),(151,'Bonnie and Clyde','我倆沒有明天',7),(152,'The Graduate','畢業生',8),(153,'The Sixth Sense','靈異第六感',7),(154,'A Streetcar Named Desire','慾望街車',8),(155,'Now, Voyager','揚帆',8),(156,'Shane','原野奇俠',8),(157,'Some Like It Hot','熱情如火',4),(158,'Victor Frankenstein','科學怪人',5),(159,'Apollo 13','阿波羅13號',5),(160,'Dirty Harry','緊急追捕令',1),(161,'Animal Crackers','瘋狂的動物',8),(162,'A League of Their Own','紅粉聯盟',1),(163,'Annie Hall','安妮霍爾',4),(164,'Psycho','驚魂記',3),(165,'Wall Street','華爾街',8),(166,'The Godfather Part II','教父第二集',7),(167,'Sons of the Desert','懼內先生',8),(168,'Beyond the Forest','越過森林',8),(169,'The Graduate','畢業生',8),(170,'Dr. Strangelove or: How I Learned to Stop Worrying and Love the Bomb','奇愛博士',8),(171,'The Adventures of Sherlock Holmes','福爾摩斯歷險記',7),(172,'Planet of the Apes','浩劫餘生',5),(173,'The Shining','鬼店',3),(174,'Poltergeist','鬼哭神號',3),(175,'Marathon Man','霹靂鑽',7),(176,'The Jazz Singer','爵士歌手',8),(177,'Mommie Dearest','親愛的媽咪',8),(178,'Little Caesar','小凱薩',7),(179,'Chinatown','唐人街',8),(180,'Soylent Green','超世紀諜殺案',5),(181,'2001: A Space Odyssey','2001太空漫遊',5),(182,'National Lampoon\'s Animal House','動物屋',4),(183,'Dracula','吸血鬼',3),(184,'King Kong','金剛',5),(185,'The Lord of the Rings: The Two Towers','魔戒二部曲：雙城奇謀',1),(186,'42nd Street','第四十二街',4),(187,'On Golden Pond','金色池塘',8),(188,'Knute Rockne, All American','克努特·羅克尼',8),(189,'Goldfinger','007：金手指',1),(190,'The Naughty Nineties','大鬧戲船',8),(191,'Caddyshack','瘋狂高爾夫',8),(192,'Auntie Mame','歡樂梅姑',8),(193,'Top Gun','捍衛戰士',5),(194,'Dead Poets Society','春風化雨',8),(195,'moonstruck','發暈',4),(196,'Yankee Doodle Dandy','勝利之歌',8),(197,'Dirty Dancing','熱舞17',1),(198,'The Truman Show','楚門的世界',8),(199,'Fight Club','鬥陣俱樂部',8),(200,'Ratatouille','料理鼠王',2),(201,'Zootopia','動物方程式',2),(202,'Frozen','冰雪奇緣',2),(203,'Top Gun：Maverick','捍衛戰士：獨行俠',1),(204,'The Intern','高年級實習生',8),(205,'Florence Foster Jenkins','走音天后',8),(206,'The Pursuit of Happyness','當幸福來敲門',8),(207,'V for Vendetta','V字仇殺隊',7),(208,'Wag the Dog','搖尾狗',8),(209,'The Dish','天線',8),(210,'Black Hawk Down','黑鷹降落',8),(211,'Cinderella Man','鐵拳男人',8),(212,'Eternal Sunshine of the Spotless Mind','美麗心靈的永恆陽光',4),(213,'The Vampire Diaries','吸血鬼日記',5),(214,'The Shawshank Redemption','刺激1995',8),(215,'Batman Begins','蝙蝠俠：開戰時刻',1),(216,'The Breakfast Club','早餐俱樂部',8),(217,'A Streetcar Named Desire','慾望號街車',8),(218,'Black Hawk Down','黑鷹降落',1),(219,'Homeless to Harvard: The Liz Murray Story','最貧窮的哈佛女孩',8),(220,'Cast Away','浩劫重生',1),(221,'Million Dollar Baby','登峰造擊',8),(222,'A Beautiful Mind','美麗境界',4),(223,'Legally Blonde','金法尤物',8),(224,'Billy Elliot','舞動人生',1),(225,'Patch Adams','心靈點滴',8),(226,'Click','命運好好玩',8),(227,'Eight Below','極地長征',8),(228,'Coach Carter','卡特教練',8),(229,'The Devil Wears Prada','穿著Prada的惡魔',8),(230,'Little Miss Sunshine','小太陽的願望',8),(231,'Les Choristes','放牛班的春天',8),(232,'12 Angry Men','十二怒漢',1),(233,'Citizen Kane','大國民',8),(234,'All about Eve','彗星美人',8),(235,'Marry Poppins','歡樂滿人間',8),(236,'Laura','蘿拉',4),(237,'Charlie and theChocolate Factory','查理的巧克力工廠',5),(238,'Schindler\'s List','辛德勒的名單',8),(239,'Star Wars V: Empire Strikes Back','星球大戰V：帝國反擊戰',5),(240,'The Croods','瘋狂原始人',2),(241,'Zootopia','動物方程市',2),(242,'Braveheart','勇敢的心',8),(243,'Blade','刀鋒戰士',1),(244,NULL,NULL,NULL),(245,NULL,NULL,NULL),(246,NULL,NULL,NULL),(247,NULL,NULL,NULL),(248,NULL,NULL,NULL),(249,NULL,NULL,NULL),(250,NULL,NULL,NULL);
/*!40000 ALTER TABLE `movie` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-12-19  0:32:15
