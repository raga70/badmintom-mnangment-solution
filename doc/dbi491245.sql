-- phpMyAdmin SQL Dump
-- version 4.9.3
-- https://www.phpmyadmin.net/
--
-- Host: studmysql01.fhict.local
-- Generation Time: Jun 08, 2022 at 05:17 PM
-- Server version: 5.7.26-log
-- PHP Version: 7.4.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbi491245`
--

-- --------------------------------------------------------

--
-- Table structure for table `gamefights`
--

CREATE TABLE `gamefights` (
  `tournament_id` int(11) NOT NULL,
  `player_id` int(11) NOT NULL,
  `fightScore` text COLLATE utf8_unicode_ci NOT NULL,
  `oponent_id` int(11) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `gamefights`
--

INSERT INTO `gamefights` (`tournament_id`, `player_id`, `fightScore`, `oponent_id`, `id`) VALUES
(1, 2, '21:2', 1, 47),
(1, 1, '2:21', 2, 48),
(1, 3, '4:21', 1, 49),
(1, 1, '21:4', 3, 50),
(1, 2, '21:24', 3, 51),
(1, 3, '24:21', 2, 52),
(2, 2, '8:21', 1, 53),
(2, 1, '21:8', 2, 54),
(5, 2, '21:15', 1, 55),
(5, 1, '15:21', 2, 56),
(5, 3, '18:21', 1, 57),
(5, 1, '21:18', 3, 58),
(5, 2, '21:9', 3, 59),
(5, 3, '9:21', 2, 60),
(7, 2, '25:21', 1, 67),
(7, 1, '21:25', 2, 68);

-- --------------------------------------------------------

--
-- Table structure for table `gameresults`
--

CREATE TABLE `gameresults` (
  `tournament_id` int(11) NOT NULL,
  `player_id` int(11) NOT NULL,
  `points` int(11) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `gameresults`
--

INSERT INTO `gameresults` (`tournament_id`, `player_id`, `points`, `id`) VALUES
(1, 1, 1, 5),
(1, 2, 2, 6),
(1, 3, 0, 7),
(2, 1, 1, 92),
(2, 2, 0, 93),
(5, 1, 1, 94),
(5, 2, 3, 95),
(5, 3, 1, 96),
(7, 1, 0, 100),
(7, 2, 1, 101);

-- --------------------------------------------------------

--
-- Table structure for table `tournaments`
--

CREATE TABLE `tournaments` (
  `sportType` enum('Badminton') COLLATE utf8_unicode_ci NOT NULL,
  `startDate` datetime NOT NULL,
  `endDate` datetime NOT NULL,
  `minPlayers` int(11) NOT NULL,
  `maxPlayers` int(11) NOT NULL,
  `location` text COLLATE utf8_unicode_ci NOT NULL,
  `tournamentSystem` enum('RoundRobin','SingleElimination') COLLATE utf8_unicode_ci NOT NULL,
  `description` text COLLATE utf8_unicode_ci NOT NULL,
  `gender` int(11) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `tournaments`
--

INSERT INTO `tournaments` (`sportType`, `startDate`, `endDate`, `minPlayers`, `maxPlayers`, `location`, `tournamentSystem`, `description`, `gender`, `id`) VALUES
('Badminton', '2022-05-29 13:13:00', '2022-05-31 14:19:00', 2, 4, 'ssc', 'RoundRobin', 'first tournament', 0, 1),
('Badminton', '2022-05-30 00:00:00', '2022-06-01 00:00:00', 2, 4, 'ssc', 'RoundRobin', 'wateverr', 0, 2),
('Badminton', '2022-04-28 00:00:00', '2022-04-30 00:00:00', 2, 5, 'ssc', 'RoundRobin', 'third tournament', 0, 3),
('Badminton', '2022-04-28 00:00:00', '2022-04-29 00:00:00', 4, 8, 'badminton facility Breda', 'RoundRobin', 'hello 4', 0, 4),
('Badminton', '2022-05-31 18:46:48', '2022-06-04 18:46:48', 2, 8, 'idk', 'RoundRobin', 'gg', 0, 5),
('Badminton', '2022-06-07 15:51:37', '2022-06-11 15:51:37', 2, 5, 'Indonesia, Badminton Court', 'RoundRobin', '$5 CASH PRIZE', 0, 7),
('Badminton', '2022-06-07 16:40:05', '2022-06-09 16:40:05', 2, 3, 'grdthjyku', 'RoundRobin', 'fdghj', 0, 8);

-- --------------------------------------------------------

--
-- Table structure for table `tournaments_users`
--

CREATE TABLE `tournaments_users` (
  `tournaments_id` int(11) NOT NULL,
  `users_id` int(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `tournaments_users`
--

INSERT INTO `tournaments_users` (`tournaments_id`, `users_id`) VALUES
(1, 1),
(2, 1),
(5, 1),
(7, 1),
(1, 2),
(2, 2),
(5, 2),
(7, 2),
(1, 3),
(5, 3);

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
  `accType` enum('Athlete','Staff','Admin') COLLATE utf8_unicode_ci NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`username`, `password`, `firstName`, `lastName`, `birthdayDate`, `gender`, `email`, `phoneNumber`, `accType`, `id`) VALUES
('toni', '6yxGUmSumhXyUagjn23AyB5Z9p5GHpoBbmGR3N1VrwHyT828', 'tonito', 'rasel', '2001-05-22', 0, 'toni@gmail.com', '0878965115', 'Athlete', 1),
('toni2', 'xHhClrLu2fMgO9sTV8da9HuGhLQrULDEWhNBX9SjqSYzLrwR', 'kolio', 'dupter', '2022-06-02', 0, 'ddd@abv.bg', '086544656433', 'Athlete', 2),
('toni3', 'H5f8kHXP7+pex1DO2oc0gZqw5k5JfUvBPUTfdYyeL/kZZNIW', 'tonizero', 'kontini', '2022-05-16', 0, 'raga70@abv.bg', '+31623941935', 'Athlete', 3),
('staff', '6yxGUmSumhXyUagjn23AyB5Z9p5GHpoBbmGR3N1VrwHyT828', 'John', 'Tomson', '2021-09-13', 0, 'support@duelsys.com', '0678964117', 'Staff', 4);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `gamefights`
--
ALTER TABLE `gamefights`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `ui_dupliii` (`tournament_id`,`player_id`,`oponent_id`) USING BTREE,
  ADD KEY `player_id` (`player_id`),
  ADD KEY `oponent_id` (`oponent_id`);

--
-- Indexes for table `gameresults`
--
ALTER TABLE `gameresults`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `ui_dupli` (`tournament_id`,`player_id`),
  ADD KEY `player_id` (`player_id`);

--
-- Indexes for table `tournaments`
--
ALTER TABLE `tournaments`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tournaments_users`
--
ALTER TABLE `tournaments_users`
  ADD UNIQUE KEY `uq_noDuplicateUsersInTournament` (`tournaments_id`,`users_id`),
  ADD KEY `users_id` (`users_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `ui_username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `gamefights`
--
ALTER TABLE `gamefights`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=77;

--
-- AUTO_INCREMENT for table `gameresults`
--
ALTER TABLE `gameresults`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=110;

--
-- AUTO_INCREMENT for table `tournaments`
--
ALTER TABLE `tournaments`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `gamefights`
--
ALTER TABLE `gamefights`
  ADD CONSTRAINT `gameFights_ibfk_1` FOREIGN KEY (`tournament_id`) REFERENCES `tournaments` (`id`),
  ADD CONSTRAINT `gameFights_ibfk_2` FOREIGN KEY (`player_id`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `gameFights_ibfk_3` FOREIGN KEY (`oponent_id`) REFERENCES `users` (`id`);

--
-- Constraints for table `gameresults`
--
ALTER TABLE `gameresults`
  ADD CONSTRAINT `gameResults_ibfk_1` FOREIGN KEY (`tournament_id`) REFERENCES `tournaments` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `gameResults_ibfk_2` FOREIGN KEY (`player_id`) REFERENCES `users` (`id`);

--
-- Constraints for table `tournaments_users`
--
ALTER TABLE `tournaments_users`
  ADD CONSTRAINT `tournaments_users_ibfk_1` FOREIGN KEY (`tournaments_id`) REFERENCES `tournaments` (`id`),
  ADD CONSTRAINT `tournaments_users_ibfk_2` FOREIGN KEY (`users_id`) REFERENCES `users` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
