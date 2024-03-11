-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 11, 2024 at 03:12 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `manageadministrator`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_manageadministrator`
--

CREATE TABLE `tbl_manageadministrator` (
  `AdminID` int(10) NOT NULL,
  `FullName` varchar(250) NOT NULL,
  `Username` varchar(250) NOT NULL,
  `Password` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_manageadministrator`
--

INSERT INTO `tbl_manageadministrator` (`AdminID`, `FullName`, `Username`, `Password`) VALUES
(2, 'Full Name', 'Username', 'Password'),
(3, 'Maria Anne Jimeno', 'B.', '1234'),
(4, 'Ariel Javier', 'AJavier', '12345');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_scholarshipcategory`
--

CREATE TABLE `tbl_scholarshipcategory` (
  `CategoryID` int(10) NOT NULL,
  `CategoryName` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_scholarshipcategory`
--

INSERT INTO `tbl_scholarshipcategory` (`CategoryID`, `CategoryName`) VALUES
(3, 'Senior Highschool'),
(4, 'Undergraduate'),
(5, 'Financial Assistance'),
(6, 'Promotional Discount'),
(7, 'Scholarship Partnership'),
(8, 'Government Funds'),
(9, 'SAMPLE'),
(10, 'SDF');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_scholarshipinformation`
--

CREATE TABLE `tbl_scholarshipinformation` (
  `StudentNumber` int(10) NOT NULL,
  `FullName` varchar(250) NOT NULL,
  `Program` varchar(250) NOT NULL,
  `YearLevel` int(10) NOT NULL,
  `DOB` int(250) NOT NULL,
  `Address` varchar(250) NOT NULL,
  `EmailAddress` varchar(250) NOT NULL,
  `ContactNumber` int(250) NOT NULL,
  `Age` int(10) NOT NULL,
  `Siblings` int(250) NOT NULL,
  `ScholarshipCategory` varchar(250) NOT NULL,
  `ScholarshipType` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_scholarshiptype`
--

CREATE TABLE `tbl_scholarshiptype` (
  `TypeID` int(10) NOT NULL,
  `CategoryName` varchar(250) NOT NULL,
  `ScholarshipType` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_scholarshiptype`
--

INSERT INTO `tbl_scholarshiptype` (`TypeID`, `CategoryName`, `ScholarshipType`) VALUES
(1, 'Senior Highschool', 'E.T. Yuchengco Scholarship');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_manageadministrator`
--
ALTER TABLE `tbl_manageadministrator`
  ADD PRIMARY KEY (`AdminID`);

--
-- Indexes for table `tbl_scholarshipcategory`
--
ALTER TABLE `tbl_scholarshipcategory`
  ADD PRIMARY KEY (`CategoryID`);

--
-- Indexes for table `tbl_scholarshipinformation`
--
ALTER TABLE `tbl_scholarshipinformation`
  ADD PRIMARY KEY (`StudentNumber`);

--
-- Indexes for table `tbl_scholarshiptype`
--
ALTER TABLE `tbl_scholarshiptype`
  ADD PRIMARY KEY (`TypeID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_manageadministrator`
--
ALTER TABLE `tbl_manageadministrator`
  MODIFY `AdminID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tbl_scholarshipcategory`
--
ALTER TABLE `tbl_scholarshipcategory`
  MODIFY `CategoryID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tbl_scholarshiptype`
--
ALTER TABLE `tbl_scholarshiptype`
  MODIFY `TypeID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
