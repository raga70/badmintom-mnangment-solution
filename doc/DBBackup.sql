-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: May 15, 2022 at 05:57 PM
-- Server version: 8.0.13-4
-- PHP Version: 7.2.24-0ubuntu0.18.04.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `3dzxuKGkH2`
--

-- --------------------------------------------------------

--
-- Table structure for table `gameFights`
--

CREATE TABLE `gameFights` (
  `tournament_id` int(11) NOT NULL,
  `playerUsername` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `fightScore` text COLLATE utf8_unicode_ci NOT NULL,
  `oponent` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `gameFights`
--

INSERT INTO `gameFights` (`tournament_id`, `playerUsername`, `fightScore`, `oponent`, `id`) VALUES
(6, 'toni2', '21-16', 'toni', 3),
(6, 'toni', '16-21', 'toni2', 4);

-- --------------------------------------------------------

--
-- Table structure for table `gameResults`
--

CREATE TABLE `gameResults` (
  `tournament_id` int(11) NOT NULL,
  `playerUsername` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `points` int(11) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `gameResults`
--

INSERT INTO `gameResults` (`tournament_id`, `playerUsername`, `points`, `id`) VALUES
(6, 'toni', 0, 3),
(6, 'toni2', 1, 4);

-- --------------------------------------------------------

--
-- Table structure for table `tournaments`
--

CREATE TABLE `tournaments` (
  `sportType` enum('Badminton','') CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `startDate` datetime NOT NULL,
  `endDate` datetime NOT NULL,
  `minPlayers` int(11) NOT NULL,
  `maxPlayers` int(11) NOT NULL,
  `location` text COLLATE utf8_unicode_ci NOT NULL,
  `tournamentSystem` enum('RoundRobin') COLLATE utf8_unicode_ci NOT NULL,
  `description` text CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `gender` int(11) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `tournaments`
--

INSERT INTO `tournaments` (`sportType`, `startDate`, `endDate`, `minPlayers`, `maxPlayers`, `location`, `tournamentSystem`, `description`, `gender`, `id`) VALUES
('Badminton', '2022-04-28 13:13:00', '2022-04-29 14:19:00', 2, 4, 'ssc', 'RoundRobin', 'first tournament', 0, 1),
('Badminton', '2022-04-28 00:00:00', '2022-04-30 00:00:00', 3, 4, 'ssc', 'RoundRobin', 'wateverr', 0, 2),
('Badminton', '2022-04-28 00:00:00', '2022-04-30 00:00:00', 2, 4, 'ssc', 'RoundRobin', 'third tournament', 0, 3),
('Badminton', '2022-04-28 00:00:00', '2022-04-29 00:00:00', 4, 8, 'badminton facility Breda', 'RoundRobin', 'hello 4', 0, 4),
('Badminton', '2022-04-30 18:46:48', '2022-05-13 18:46:48', 2, 8, 'idk', 'RoundRobin', 'gg', 0, 5),
('Badminton', '2022-05-03 19:09:46', '2022-05-07 19:09:46', 2, 4, 'q', 'RoundRobin', 'ww', 0, 6);

-- --------------------------------------------------------

--
-- Table structure for table `tournaments_users`
--

CREATE TABLE `tournaments_users` (
  `tournaments_id` int(11) NOT NULL,
  `users_username` varchar(45) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `tournaments_users`
--

INSERT INTO `tournaments_users` (`tournaments_id`, `users_username`) VALUES
(1, 'toni'),
(3, 'toni'),
(5, 'toni'),
(6, 'toni'),
(6, 'toni2');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `username` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `password` text COLLATE utf8_unicode_ci NOT NULL,
  `firstName` text COLLATE utf8_unicode_ci NOT NULL,
  `lastName` text COLLATE utf8_unicode_ci NOT NULL,
  `birthdayDate` date NOT NULL,
  `gender` int(11) NOT NULL,
  `email` text COLLATE utf8_unicode_ci NOT NULL,
  `phoneNumber` text COLLATE utf8_unicode_ci NOT NULL,
  `accType` enum('Athlete','Staff','Admin') CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`username`, `password`, `firstName`, `lastName`, `birthdayDate`, `gender`, `email`, `phoneNumber`, `accType`) VALUES
('toni', '6yxGUmSumhXyUagjn23AyB5Z9p5GHpoBbmGR3N1VrwHyT828', 'tonito', 'rasel', '2001-05-22', 0, 'toni@gmail.com', '0878965115', 'Athlete'),
('toni2', 'xHhClrLu2fMgO9sTV8da9HuGhLQrULDEWhNBX9SjqSYzLrwR', 'kolio', 'dupter', '2022-06-02', 0, 'ddd@abv.bg', '086544656433', 'Athlete');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `gameFights`
--
ALTER TABLE `gameFights`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `ui_dupliii` (`tournament_id`,`playerUsername`,`oponent`);

--
-- Indexes for table `gameResults`
--
ALTER TABLE `gameResults`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `ui_dupli` (`tournament_id`,`playerUsername`),
  ADD KEY `playerUsername` (`playerUsername`);

--
-- Indexes for table `tournaments`
--
ALTER TABLE `tournaments`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tournaments_users`
--
ALTER TABLE `tournaments_users`
  ADD UNIQUE KEY `uq_noDuplicateUsersInTournament` (`tournaments_id`,`users_username`),
  ADD KEY `users_username` (`users_username`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `gameFights`
--
ALTER TABLE `gameFights`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `gameResults`
--
ALTER TABLE `gameResults`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tournaments`
--
ALTER TABLE `tournaments`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `gameFights`
--
ALTER TABLE `gameFights`
  ADD CONSTRAINT `gameFights_ibfk_1` FOREIGN KEY (`tournament_id`) REFERENCES `tournaments` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT;

--
-- Constraints for table `gameResults`
--
ALTER TABLE `gameResults`
  ADD CONSTRAINT `gameResults_ibfk_1` FOREIGN KEY (`tournament_id`) REFERENCES `tournaments` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `gameResults_ibfk_2` FOREIGN KEY (`playerUsername`) REFERENCES `users` (`username`);

--
-- Constraints for table `tournaments_users`
--
ALTER TABLE `tournaments_users`
  ADD CONSTRAINT `tournaments_users_ibfk_1` FOREIGN KEY (`tournaments_id`) REFERENCES `tournaments` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  ADD CONSTRAINT `tournaments_users_ibfk_2` FOREIGN KEY (`users_username`) REFERENCES `users` (`username`) ON DELETE RESTRICT ON UPDATE RESTRICT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
