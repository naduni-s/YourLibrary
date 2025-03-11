-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 11, 2024 at 04:39 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `library_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `isbn` varchar(20) NOT NULL,
  `title` text NOT NULL,
  `author` text NOT NULL,
  `publisher` text NOT NULL,
  `genre` text NOT NULL,
  `language` text NOT NULL,
  `available` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`isbn`, `title`, `author`, `publisher`, `genre`, `language`, `available`) VALUES
('00122C', 'Matilda', 'Roald Dahl', 'Jonathan', 'Novel Children\'s literature', 'English', 1),
('00341N', 'Me before you', 'Jojo Moyes', 'Penguin books', 'Novel Romance', 'English', 1),
('00497C', 'Harry Potter and the Goblet of Fire', 'J. K. Rowling', 'Bloomsbury', 'Novel Fantasy fiction', 'English', 1),
('00501N', 'Jane Eyre', 'Charlotte Bronte', 'Harper brothers', 'Novel Romance', 'English', 1),
('00534N', 'The Book Thief', 'Markus Zusak', 'Knopf books', 'Novel Young adult fiction', 'English', 1),
('00600E', 'Biology', 'Clara Philip', 'JK company', 'Education', 'German', 1),
('00705C', 'The enchanted wood', 'Enid Blyton', 'Fion', 'Fantasy fiction', 'English', 1),
('00871E', 'Abstract Algebra', 'Charles C. Pinter', 'McGraw ', 'Education Maths', 'English', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`isbn`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
