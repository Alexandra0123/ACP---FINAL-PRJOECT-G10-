-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 11, 2023 at 02:31 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `big_brew`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `admin_id` int(11) NOT NULL,
  `adminUser` varchar(50) NOT NULL,
  `adminPass` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`admin_id`, `adminUser`, `adminPass`) VALUES
(1, 'admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `orderhistory`
--

CREATE TABLE `orderhistory` (
  `order_id` int(11) NOT NULL,
  `customer` varchar(100) NOT NULL,
  `orders` text NOT NULL,
  `order_date` date DEFAULT curdate()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `orderhistory`
--

INSERT INTO `orderhistory` (`order_id`, `customer`, `orders`, `order_date`) VALUES
(1, 'Customer Name: Marie\r\n', 'KAPE BRUSKO (16oz)   qx\nKAPE MATCHA (16oz)   1x\nKAPE BRUSKO (22oz)   1x\nKAPE MATCHA (22oz)   1x\nCHOCOLATE (22oz)   1x\nOKINAWA (22oz)   1x\nSALTED CARAMEL (22oz)   1x\nCHOCOBERRY (16oz)   1x\nLEMON (16oz)   1x\nCustomer Name: Marie\n', '2023-12-11'),
(2, 'Customer Name: Shekinah\r\n', 'KAPE BRUSKO (16oz)   1x\r\nCustomer Name: Shekinah\r\n', '2023-12-11'),
(3, 'Customer Name: Marie\r\n', 'KAPE BRUSKO (22oz)   1x\r\nCustomer Name: Marie\r\n', '2023-12-11'),
(4, 'Customer Name: Marie\r\n', 'KAPE BRUSKO (16oz)   1x\r\nCustomer Name: Marie\r\n', '2023-12-11'),
(5, 'Customer Name: Marie\r\n', '', '2023-12-11'),
(6, 'Customer Name: Khim\r\n', 'KAPE BRUSKO (16oz)   1x\r\nCustomer Name: Khim\r\n', '2023-12-11'),
(7, 'Customer Name: Khim\r\n', 'KAPE BRUSKO (16oz)   1x\r\nKAPE MACCH (16oz)   1x\r\nCHOCOLATE (16oz)   qx\r\nCustomer Name: Khim\r\n', '2023-12-11'),
(8, 'Customer Name: Alex\r\n', 'KAPE BRUSKO (16oz)   1x\r\nCustomer Name: Alex\r\n', '2023-12-11'),
(9, 'Customer Name: Khim\r\n', 'KAPE BRUSKO (16oz)   1x\r\nKAPE MACCH (16oz)   1x\r\nOKINAWA (16oz)   1x\r\nCHOCOLATE (16oz)   1x\r\nCustomer Name: Khim\r\n', '2023-12-11'),
(10, 'Customer Name: sheki\r\n', 'KAPE BRUSKO (16oz)   1x\r\nCustomer Name: sheki\r\n', '2023-12-11'),
(11, 'Customer Name: sheki\r\n', 'KAPE BRUSKO (22oz)   1x\r\nKAPE VAN (22oz)   1x\r\nCustomer Name: sheki\r\n', '2023-12-11'),
(12, 'Customer Name: mhik\r\n', 'KAPE MATCHA (16oz)   22x\r\nKAPE VAN (16oz)   22x\r\nCustomer Name: mhik\r\n', '2023-12-11'),
(13, 'Customer Name: jyjyjy\r\n', 'KAPE BLANCO (16oz)   1x\r\nCustomer Name: jyjyjy\r\n', '2023-12-11'),
(14, 'Customer Name: 11\r\n', 'OKINAWA (16oz)   11x\r\nCustomer Name: 11\r\n', '2023-12-11'),
(15, 'Customer Name: 11\r\n', 'KIWI (16oz)   11x\r\nCustomer Name: 11\r\n', '2023-12-11'),
(16, 'Customer Name: 11\r\n', 'KAPE MACCH (16oz)   11x\r\nCustomer Name: 11\r\n', '2023-12-11'),
(17, 'Customer Name: 11\r\n', 'KAPE MATCHA (16oz)   11x\r\nCustomer Name: 11\r\n', '2023-12-11'),
(18, 'Customer Name: 2\r\n', 'LEMON (16oz)   2x\r\nCustomer Name: 2\r\n', '2023-12-11'),
(19, 'Customer Name: shekinah\r\n', 'KAPE BRUSKO (16oz)   1x\r\nKAPE BLANCO (16oz)   1x\r\nKAPE KARAMEL (16oz)   1x\r\nCHOCOLATE (16oz)   1x\r\nCHEESECAKE (16oz)   1x\r\nCustomer Name: shekinah\r\n', '2023-12-11'),
(20, 'Customer Name: k\r\n', 'KAPE BRUSKO (16oz)   1x\r\nKAPE MACCH (16oz)   1x\r\nCustomer Name: k\r\n', '2023-12-11'),
(21, 'Customer Name: q\r\n', 'KAPE BRUSKO (16oz)   1x\r\nKAPE MACCH (16oz)   1x\r\nCustomer Name: q\r\n', '2023-12-11'),
(22, 'Customer Name: we\r\n', 'Customer Name: we\r\n', '2023-12-11'),
(23, 'Customer Name: qw\r\n', '\r\n\r\nCHOCOLATE (16oz)   111x\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nCustomer Name: qw\r\n\r\n', '2023-12-11'),
(24, 'Customer Name: as\r\n', '\r\n\r\nCHOCOLATE (16oz)   111x\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nCustomer Name: as\r\n\r\n', '2023-12-11'),
(25, 'Customer Name: a\r\n', '\r\n\r\nDARK CHOCO (16oz)   6x\r\nSALTED CARAMEL (16oz)   6x\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nCustomer Name: a\r\n\r\n', '2023-12-11'),
(26, 'Customer Name: a\r\n', '\r\n\r\nDARK CHOCO (16oz)   6x\r\nSALTED CARAMEL (16oz)   6x\r\n\r\n\r\n\r\nKIWI (22oz)   7x\r\n\r\n\r\n\r\n\r\nCustomer Name: a\r\n\r\n', '2023-12-11'),
(27, 'Customer Name: j\r\n', '\r\n\r\nDARK CHOCO (16oz)   8x\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nCustomer Name: j\r\n\r\n', '2023-12-11'),
(28, 'Customer Name: k\r\n', '\r\n\r\nDARK CHOCO (16oz)   8x\r\n\r\n\r\n\r\n\r\nMOCHA (16oz)   9x\r\n\r\n\r\n\r\nCustomer Name: k\r\n\r\n', '2023-12-11'),
(29, 'Customer Name: l\r\n', '\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nBUFFALO FRIES    3x\r\n\r\nCustomer Name: l\r\n\r\n', '2023-12-11'),
(30, 'Customer Name: k\r\n', '\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nBUFFALO FRIES    3x\r\nBUFFALO FRIES    90x\r\n\r\nCustomer Name: k\r\n\r\n', '2023-12-11'),
(31, 'Customer Name: t\r\n', '\r\n\r\nDARK CHOCO (16oz)   3x\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nCustomer Name: t\r\n\r\n', '2023-12-11'),
(32, 'Customer Name: y\r\n', '\r\n\r\nDARK CHOCO (16oz)   3x\r\n\r\n\r\n\r\n\r\n\r\n\r\nMOJOS    5x\r\n\r\nCustomer Name: y\r\n\r\n', '2023-12-11'),
(33, 'Customer Name: a\r\n', '\r\n\r\nCHEESECAKE (16oz)   123x\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nCustomer Name: a\r\n\r\n', '2023-12-11'),
(34, 'Customer Name: 0\r\n', '\r\n\r\nCHEESECAKE (16oz)   123x\r\n\r\n\r\nLEMON (16oz)   9x\r\n\r\n\r\n\r\n\r\n\r\nCustomer Name: 0\r\n\r\n', '2023-12-11'),
(35, 'Customer Name: a\r\n', '\r\n\r\n\r\nCOOKIES AND CREAM (22oz)   5x\r\n\r\n\r\n\r\n\r\n\r\n\r\nCustomer Name: a\r\n\r\n', '2023-12-11'),
(36, 'Customer Name: b\r\n', '\r\n\r\n\r\nCOOKIES AND CREAM (22oz)   5x\r\n\r\n\r\n\r\nMOCHA (16oz)   10x\r\n\r\n\r\n\r\nCustomer Name: b\r\n\r\n', '2023-12-11'),
(37, 'Customer Name: qwe\r\n', '\n\n\nSALTED CARAMEL (22oz)   123x\r\n\n\n\n\n\n\nCustomer Name: qwe\r\n', '2023-12-11'),
(38, 'Customer Name: qwe\r\n', '\nKAPE MOCHA (22oz)   123x\r\n\n\n\n\n\n\n\n\nCustomer Name: qwe\r\n', '2023-12-11'),
(39, 'Customer Name: qwerty\r\n', '\n\n\nDARK CHOCO (22oz)   12x\r\n\n\n\n\n\n\nCustomer Name: qwerty\r\n', '2023-12-11'),
(40, 'Customer Name: tyukh\r\n', '\n\n\nDARK CHOCO (22oz)   12x\r\n\n\n\n\n\n\nCustomer Name: tyukh\r\n', '2023-12-11'),
(41, 'Customer Name: a\r\n', 'KAPE BRUSKO (16oz)   1x\r\nKAPE MACCH (16oz)   1x\r\n\n\n\nDARK CHOCO (22oz)   12x\r\n\n\n\n\n\n\nCustomer Name: a\r\n', '2023-12-11'),
(42, 'Customer Name: sd\r\n', 'KAPE BRUSKO (16oz)   1x\r\nKAPE MACCH (16oz)   1x\r\n\n\n\nDARK CHOCO (22oz)   12x\r\n\n\n\n\n\n\nCustomer Name: sd\r\n', '2023-12-11'),
(43, 'Customer Name: sd\r\n', 'KAPE BRUSKO (16oz)   1x\r\nKAPE MACCH (16oz)   1x\r\n\n\n\nDARK CHOCO (22oz)   12x\r\n\n\n\nMATCHA (16oz)   123x\r\nMOCHA (16oz)   123x\r\n\n\n\nCustomer Name: sd\r\n', '2023-12-11'),
(44, 'Customer Name: qwerty\r\n', '', '2023-12-11'),
(45, 'Customer Name: qwert\r\n', '', '2023-12-11'),
(46, 'Customer Name: 123\r\n', '', '2023-12-11'),
(47, 'Customer Name: qwe\r\n', '', '2023-12-11'),
(48, 'Customer Name: 123435\r\n', '\n\n\n\n\n\n\n\n\n', '2023-12-11'),
(49, 'Customer Name: qwe\r\n', '\n\nCOOKIES AND CREAM (16oz)   123x\r\n\n\n\n\n\n\n\nCustomer Name: qwe\r\n', '2023-12-11'),
(50, 'Customer Name: qwerty\r\n', 'KAPE MACCH (16oz)   123x\r\n\n\n\n\n\n\n\n\n\nCustomer Name: qwerty\r\n', '2023-12-11'),
(51, 'Customer Name: sdfggd\r\n', 'KAPE MACCH (16oz)   123x\r\n\n\n\n\nWATERMELON (16oz)   1234x\r\n\n\n\n\n\nCustomer Name: sdfggd\r\n', '2023-12-11'),
(52, 'Customer Name: qwerty\r\n', '\nKAPE VAN (22oz)   123x\r\n\n\n\n\n\n\n\n\nCustomer Name: qwerty\r\n', '2023-12-11'),
(53, 'Customer Name: fries\r\n', '\nKAPE VAN (22oz)   123x\r\n\n\n\n\n\n\n\nMOJOS    123x\r\nBUFFALO FRIES    123x\r\n\nCustomer Name: fries\r\n', '2023-12-11'),
(54, 'Customer Name: qwer\r\n', '\nKAPE VAN (22oz)   123x\r\n\n\n\n\n\n\nCOOKIES AND CREAM (22oz)   123x\r\n\nMOJOS    123x\r\nBUFFALO FRIES    123x\r\n\nCustomer Name: qwer\r\n', '2023-12-11'),
(55, 'Customer Name: wer\r\n', '\n\nCOOKIES AND CREAM (16oz)   123x\r\n\n\n\n\n\n\n\nCustomer Name: wer\r\n', '2023-12-11'),
(56, 'Customer Name: hjk\r\n', '\n\nCOOKIES AND CREAM (16oz)   123x\r\n\n\nKIWI (16oz)   456x\r\n\n\n\n\n\nCustomer Name: hjk\r\n', '2023-12-11'),
(57, 'Customer Name: asd\r\n', 'KAPE BRUSKO (16oz)   1x\r\n\n\n\n\n\n\n\n\n\nCustomer Name: asd\r\n', '2023-12-11'),
(58, 'Customer Name: Angelo\r\n', 'KAPE MACCH (16oz)   12x\r\nKAPE BRUSKO (16oz)   12x\r\n\n\n\n\n\n\n\n\n\nCustomer Name: Angelo\r\n', '2023-12-11'),
(59, 'Customer Name: qwe\r\n', '\n\n\n\n\n\n\n\n\nCustomer Name: qwe\r\n', '2023-12-11'),
(60, 'Customer Name: qw\r\n', '\n\n\n\n\n\n\n\n\nCustomer Name: qw\r\n', '2023-12-11'),
(61, 'Customer Name: 321\r\n', 'KAPE BRUSKO (16oz)   12x\r\n\n\n\n\n\n\n\n\n\nCustomer Name: 321\r\n', '2023-12-11'),
(62, 'Customer Name: 12\r\n', 'KAPE BRUSKO (16oz)   12x\r\n\n\n\n\n\n\n\n\n\nCustomer Name: 12\r\n', '2023-12-11'),
(63, 'Customer Name: 12\r\n', '', '2023-12-11'),
(64, 'Customer Name: Angelo\r\n', 'KAPE BRUSKO (16oz)   12x\r\n\n\nCHOCOLATE (16oz)   12x\r\nCOOKIES AND CREAM (16oz)   2x\r\nSALTED CARAMEL (16oz)   2x\r\n\n\n\n\n\n\n\nCustomer Name: Angelo\r\n', '2023-12-11'),
(65, 'Customer Name: wq\r\n', '\nKAPE BRUSKO (22oz)   2x\r\n\n\n\n\n\n\n\n\nCustomer Name: wq\r\n', '2023-12-11'),
(66, 'Customer Name: 2\r\n', 'KAPE BRUSKO (16oz)   2x\r\n\n\n\n\n\n\n\n\n\nCustomer Name: 2\r\n', '2023-12-11'),
(67, 'Customer Name: 2\r\n', '\n\nCHOCOLATE (16oz)   2x\r\n\n\n\n\n\n\n\nCustomer Name: 2\r\n', '2023-12-11'),
(68, 'Customer Name: 2\r\n', '\n\nCHOCOLATE (16oz)   2x\r\n\n\n\n\n\n\n\nCustomer Name: 2\r\n', '2023-12-11'),
(69, 'Customer Name: 2\r\n', '\nKAPE BRUSKO (22oz)   2x\r\n\n\n\n\n\n\n\n\nCustomer Name: 2\r\n', '2023-12-11'),
(70, 'Customer Name: d\r\n', 'KAPE BRUSKO (16oz)   1x\r\n\n\n\n\n\n\n\n\n\nCustomer Name: d\r\n', '2023-12-11'),
(71, 'Customer Name: sadas\r\n', 'KAPE BRUSKO (16oz)   1x\r\n', '2023-12-11'),
(72, 'Customer Name: a\r\n', 'KAPE BRUSKO (16oz)   1x\r\nCustomer Name: a\r\n', '2023-12-11'),
(73, 'Customer Name: sss\r\n', 'Customer Name: sss\r\n', '2023-12-11'),
(74, 'Customer Name: qqq\r\n', 'Customer Name: qqq\r\n', '2023-12-11'),
(75, 'Customer Name: ss\r\n', 'Customer Name: ss\r\n', '2023-12-11'),
(76, 'Customer Name: ddddd\r\n', 'Customer Name: ddddd\r\n', '2023-12-11'),
(77, 'Customer Name: GROUP 10\r\n', 'KAPE MATCHA (16oz)   2x\r\nKAPE BLANCO (16oz)   2x\r\nKAPE VAN (16oz)   1x\r\nMATCHA (16oz)   2x\r\nCOOKIES AND CREAM (16oz)   2x\r\nCHOCOLATE (16oz)   1x\r\nCustomer Name: GROUP 10\r\n', '2023-12-11'),
(78, 'Customer Name: GLEN\r\n', 'KAPE BLANCO (16oz)   33x\r\nCustomer Name: GLEN\r\n', '2023-12-11'),
(79, 'Customer Name: alex\r\n', 'KAPE BRUSKO (16oz)   1x\r\nCHEESECAKE (16oz)   2x\r\nCustomer Name: alex\r\n', '2023-12-11'),
(80, 'Customer Name: alex\r\n', 'KAPE BRUSKO (16oz)   1x\r\n\nKAPE BLANCO (22oz)   2x\r\n\nDOUBLE DUTCH (16oz)   3x\r\n\n\n\n\n\n\n\nCustomer Name: alex\r\n', '2023-12-11'),
(81, 'Customer Name: alex\r\n', 'Customer Name: alex\r\n', '2023-12-11'),
(82, 'Customer Name: alex\r\n', 'Customer Name: alex\r\n', '2023-12-11'),
(83, 'Customer Name: alex\r\n', 'KAPE KARAMEL (16oz)   7x\r\nKAPE MATCHA (16oz)   6x\r\nKAPE BLANCO (16oz)   5x\r\nKAPE VAN (16oz)   4x\r\nKAPE MOCA (16oz)   3x\r\nKAPE MACCH (16oz)   2x\r\nKAPE BRUSKO (16oz)   1x\r\nCHOCOLATE (16oz)   2x\r\nWATERMELON (22oz)   5x\r\nCustomer Name: alex\r\n', '2023-12-11');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `orderhistory`
--
ALTER TABLE `orderhistory`
  ADD PRIMARY KEY (`order_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `orderhistory`
--
ALTER TABLE `orderhistory`
  MODIFY `order_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=84;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
