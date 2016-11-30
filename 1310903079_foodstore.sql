-- phpMyAdmin SQL Dump
-- version 4.0.8
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Nov 30, 2016 at 08:48 AM
-- Server version: 5.7.14-log
-- PHP Version: 5.4.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `1310903079_foodstore`
--

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE IF NOT EXISTS `employee` (
  `ID` varchar(11) NOT NULL COMMENT 'Kennitala',
  `name` varchar(255) NOT NULL,
  `password` int(4) NOT NULL COMMENT 'PIN',
  `jobtitle` varchar(255) NOT NULL COMMENT 'Starfsheiti',
  `hours` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`ID`, `name`, `password`, `jobtitle`, `hours`) VALUES
('0206952429', 'Hávar Sigurðarson', 1324, 'Kassastarfsmaður', NULL),
('123', 'LagerMadur', 123, 'Lager', NULL),
('1310903079', 'Gylfi Þór Helgason', 1234, 'Lager', NULL),
('1903902929', 'Ármann Hallbert Jónsson', 1234, 'Verslunarstjóri', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `lager`
--

CREATE TABLE IF NOT EXISTS `lager` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `productname` varchar(255) NOT NULL,
  `productprice` int(255) NOT NULL,
  `quantity` int(255) NOT NULL,
  `lagertype_id` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `lagertype_id` (`lagertype_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=60 ;

--
-- Dumping data for table `lager`
--

INSERT INTO `lager` (`ID`, `productname`, `productprice`, `quantity`, `lagertype_id`) VALUES
(1, 'Appelsína', 100, 25, 101),
(2, 'Banani', 150, 25, 101),
(3, 'Rauð Epli', 120, 30, 101),
(4, 'Græn Epli', 110, 35, 101),
(5, 'Jarðaber', 200, 45, 101),
(6, 'Ananas', 300, 0, 101),
(7, 'Perur', 500, 25, 101),
(8, 'Mangó', 150, 25, 101),
(9, 'Kál', 120, 50, 102),
(10, 'Tómatar', 140, 0, 102),
(11, 'Spínat', 20, 10, 102),
(12, 'Gulrætur', 120, 5, 102),
(13, 'Kartöflur', 220, 50, 102),
(14, 'Laukur', 320, 55, 102),
(15, 'Sveppir', 220, 70, 102),
(16, 'Nýmjólk', 250, 100, 201),
(17, 'Léttmjólk', 245, 66, 201),
(18, 'Fjörmjólk', 250, 100, 201),
(19, 'Undarenna', 245, 66, 201),
(20, 'Ostur', 150, 100, 201),
(21, 'Skyr', 125, 50, 201),
(22, 'Smjör', 120, 25, 201),
(23, 'Jógurt', 109, 100, 201),
(24, 'Rjómi', 450, 100, 201),
(25, 'Ís', 245, 66, 201),
(26, 'Nautakjöt', 1000, 100, 301),
(27, 'Nautahakk', 1250, 25, 301),
(28, 'Lambakjöt', 2000, 12, 301),
(29, 'Heill Kjúklingur', 1250, 25, 301),
(30, 'Kjúklingavængir', 1250, 25, 301),
(31, 'Kjúklingalæri', 1450, 25, 301),
(32, 'Kók', 150, 500, 401),
(33, 'Appelsín', 150, 500, 401),
(34, 'Mt. Dew', 150, 500, 401),
(35, 'Dr. Pepper', 150, 500, 401),
(36, 'Kók Zero', 150, 500, 401),
(37, 'Pepsi', 150, 500, 401),
(38, 'Pepsi Max', 150, 500, 401),
(39, 'Monster', 250, 500, 401),
(40, 'Red Bull', 250, 500, 401),
(50, 'Þristur', 50, 1000, 402),
(51, 'Nóa Kropp', 200, 10, 402),
(52, 'Appolo Lakkrís Konfekt', 550, 10, 402),
(53, 'Appolo Stjörnurúllur', 100, 20, 402),
(54, 'Freyju Djúpur', 250, 9, 402),
(55, 'Nóa Sirius Rjómasúkkulaði', 150, 20, 402);

-- --------------------------------------------------------

--
-- Table structure for table `lagertype`
--

CREATE TABLE IF NOT EXISTS `lagertype` (
  `ID` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `lagertype`
--

INSERT INTO `lagertype` (`ID`, `name`) VALUES
(101, 'Ávextir'),
(102, 'Grænmeti'),
(201, 'Mjólkurvörur'),
(301, 'Kjötvörur'),
(401, 'Gos'),
(402, 'Nammi'),
(403, 'test');

-- --------------------------------------------------------

--
-- Table structure for table `workhours`
--

CREATE TABLE IF NOT EXISTS `workhours` (
  `employee_id` varchar(11) NOT NULL,
  `login` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `logout` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  KEY `employee_id` (`employee_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `lager`
--
ALTER TABLE `lager`
  ADD CONSTRAINT `lager_ibfk_1` FOREIGN KEY (`lagertype_id`) REFERENCES `lagertype` (`ID`);

--
-- Constraints for table `workhours`
--
ALTER TABLE `workhours`
  ADD CONSTRAINT `workhours_ibfk_1` FOREIGN KEY (`employee_id`) REFERENCES `employee` (`ID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
