-- --------------------------------------------------------
-- 호스트:                          192.168.0.80
-- 서버 버전:                        8.0.32 - MySQL Community Server - GPL
-- 서버 OS:                        Linux
-- HeidiSQL 버전:                  12.3.0.6589
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- mhpark 데이터베이스 구조 내보내기
CREATE DATABASE IF NOT EXISTS `mhpark` /*!40100 DEFAULT CHARACTER SET utf8mb3 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `mhpark`;

-- 테이블 mhpark.words 구조 내보내기
CREATE TABLE IF NOT EXISTS `words` (
  `id` int NOT NULL AUTO_INCREMENT,
  `DAY` int DEFAULT NULL,
  `eng` varchar(50) DEFAULT NULL,
  `kor` varchar(50) DEFAULT NULL,
  `isdone` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_words_days` (`DAY`),
  CONSTRAINT `FK_words_days` FOREIGN KEY (`DAY`) REFERENCES `days` (`DAY`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb3;

-- 테이블 데이터 mhpark.words:~8 rows (대략적) 내보내기
DELETE FROM `words`;
INSERT INTO `words` (`id`, `DAY`, `eng`, `kor`, `isdone`) VALUES
	(1, 1, 'book', '책', 'FALSE'),
	(2, 1, 'apple', '사과', 'false'),
	(3, 2, 'car', '자동차', 'false'),
	(4, 2, 'school', '학교', 'false'),
	(5, 3, 'pen', '볼펜', 'false'),
	(6, 4, 'note', '공책', 'false'),
	(7, 5, 'coffe', '커피', 'true'),
	(8, 5, 'monitor', '모니터', 'true');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
