-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Време на генериране: 26 март 2026 в 08:54
-- Версия на сървъра: 10.4.32-MariaDB
-- Версия на PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данни: `airplane_tickets`
--
CREATE DATABASE airplane_tickets;
USE airplane_tickets;

-- --------------------------------------------------------

--
-- Структура на таблица `bookings`
--

CREATE TABLE `bookings` (
  `booking_id` int(11) NOT NULL,
  `customer_id` int(11) DEFAULT NULL,
  `booking_date` date DEFAULT NULL,
  `status` enum('активен','отменен','изчакващ') NOT NULL DEFAULT 'изчакващ',
  `flight_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `bookings`
--

INSERT INTO `bookings` (`booking_id`, `customer_id`, `booking_date`, `status`, `flight_id`) VALUES
(1, 1, '2026-01-10', 'активен', 1),
(2, 2, '2026-01-11', 'активен', 1),
(3, 3, '2026-01-12', 'изчакващ', 1),
(4, 4, '2026-01-13', 'отменен', 1),
(5, 5, '2026-01-14', 'активен', 1),
(6, 6, '2026-01-15', 'активен', 1),
(7, 7, '2026-01-16', 'изчакващ', 1),
(8, 8, '2026-01-17', 'активен', 1),
(9, 9, '2026-01-18', 'отменен', 1),
(10, 10, '2026-01-19', 'активен', 1);

-- --------------------------------------------------------

--
-- Структура на таблица `customers`
--

CREATE TABLE `customers` (
  `customer_id` int(11) NOT NULL,
  `first_name` varchar(50) DEFAULT NULL,
  `last_name` varchar(50) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `customers`
--

INSERT INTO `customers` (`customer_id`, `first_name`, `last_name`, `email`, `phone`) VALUES
(1, 'Иван', 'Петров', 'ivan@mail.com', '0888111111'),
(2, 'Мария', 'Георгиева', 'maria@mail.com', '0888222222'),
(3, 'Георги', 'Димитров', 'georgi@mail.com', '0888333333'),
(4, 'Елена', 'Иванова', 'elena@mail.com', '0888444444'),
(5, 'Николай', 'Стоянов', 'nikolay@mail.com', '0888555555'),
(6, 'Христина', 'Колева', 'hristina@mail.com', '0888666666'),
(7, 'Петър', 'Николов', 'petar@mail.com', '0888777777'),
(8, 'Десислава', 'Тодорова', 'desi@mail.com', '0888888888'),
(9, 'Мартин', 'Ангелов', 'martin@mail.com', '0888999999'),
(10, 'Виктория', 'Павлова', 'viktoria@mail.com', '0899000000');

-- --------------------------------------------------------

--
-- Структура на таблица `flights`
--

CREATE TABLE `flights` (
  `flight_id` int(11) NOT NULL,
  `origin` varchar(50) DEFAULT NULL,
  `destination` varchar(50) DEFAULT NULL,
  `departure_time` datetime DEFAULT NULL,
  `arrival_time` datetime DEFAULT NULL,
  `price` decimal(10,2) DEFAULT NULL,
  `available_seats` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `flights`
--

INSERT INTO `flights` (`flight_id`, `origin`, `destination`, `departure_time`, `arrival_time`, `price`, `available_seats`) VALUES
(1, 'София', 'Лондон', '2026-02-01 08:30:00', '2026-02-01 10:25:00', 199.99, 42),
(2, 'София', 'Париж', '2026-02-02 12:10:00', '2026-02-02 14:05:00', 149.50, 12),
(3, 'Варна', 'Берлин', '2026-02-03 06:45:00', '2026-02-03 09:10:00', 175.00, 4),
(4, 'Пловдив', 'Рим', '2026-02-04 15:20:00', '2026-02-04 16:55:00', 160.00, 9),
(5, 'София', 'Мадрид', '2026-02-05 09:00:00', '2026-02-05 11:55:00', 210.00, 3),
(6, 'София', 'Виена', '2026-02-06 18:30:00', '2026-02-06 19:50:00', 120.00, 30),
(7, 'Бургас', 'Амстердам', '2026-02-07 07:15:00', '2026-02-07 09:45:00', 230.00, 6),
(8, 'София', 'Атина', '2026-02-08 10:40:00', '2026-02-08 11:50:00', 95.00, 55),
(9, 'Варна', 'Истанбул', '2026-02-09 20:10:00', '2026-02-09 21:05:00', 80.00, 2),
(10, 'София', 'Мюнхен', '2026-02-10 13:25:00', '2026-02-10 15:05:00', 170.00, 18);

-- --------------------------------------------------------

--
-- Структура на таблица `reviews`
--

CREATE TABLE `reviews` (
  `review_id` int(11) NOT NULL,
  `flight_id` int(11) DEFAULT NULL,
  `customer_id` int(11) DEFAULT NULL,
  `rating` int(11) DEFAULT NULL,
  `comment` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `reviews`
--

INSERT INTO `reviews` (`review_id`, `flight_id`, `customer_id`, `rating`, `comment`) VALUES
(1, 1, 1, 5, 'Много добър полет'),
(2, 2, 2, 4, 'Добро обслужване'),
(3, 3, 3, 3, 'Закъснение'),
(4, 4, 4, 2, 'Неудобни седалки'),
(5, 5, 5, 5, 'Отличен'),
(6, 6, 6, 4, 'Всичко точно'),
(7, 7, 7, 3, 'Средна работа'),
(8, 8, 8, 5, 'Страхотен полет'),
(9, 9, 9, 1, 'Лоша работа'),
(10, 10, 10, 4, 'Добре беше');

-- --------------------------------------------------------

--
-- Структура на таблица `tickets`
--

CREATE TABLE `tickets` (
  `ticket_id` int(11) NOT NULL,
  `booking_id` int(11) DEFAULT NULL,
  `flight_id` int(11) DEFAULT NULL,
  `seat_number` varchar(5) DEFAULT NULL,
  `price` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `tickets`
--

INSERT INTO `tickets` (`ticket_id`, `booking_id`, `flight_id`, `seat_number`, `price`) VALUES
(1, 1, 1, '12A', 199.99),
(2, 1, 8, '14C', 95.00),
(3, 2, 2, '03B', 149.50),
(4, 3, 3, '18D', 175.00),
(5, 3, 6, '07A', 120.00),
(6, 4, 4, '09F', 160.00),
(7, 5, 5, '22C', 210.00),
(8, 6, 10, '11B', 170.00),
(9, 7, 7, '16E', 230.00),
(10, 8, 9, '02A', 80.00),
(11, 9, 8, '25D', 95.00),
(12, 10, 6, '05C', 120.00);

-- --------------------------------------------------------

--
-- Структура на таблица `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `role` varchar(20) NOT NULL DEFAULT 'user'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `role`) VALUES
(1, 'admin', '1234', 'admin'),
(2, 'user1', '1234', 'user');

--
-- Indexes for dumped tables
--

--
-- Индекси за таблица `bookings`
--
ALTER TABLE `bookings`
  ADD PRIMARY KEY (`booking_id`),
  ADD KEY `customer_id` (`customer_id`);

--
-- Индекси за таблица `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`customer_id`);

--
-- Индекси за таблица `flights`
--
ALTER TABLE `flights`
  ADD PRIMARY KEY (`flight_id`);

--
-- Индекси за таблица `reviews`
--
ALTER TABLE `reviews`
  ADD PRIMARY KEY (`review_id`),
  ADD KEY `flight_id` (`flight_id`),
  ADD KEY `customer_id` (`customer_id`);

--
-- Индекси за таблица `tickets`
--
ALTER TABLE `tickets`
  ADD PRIMARY KEY (`ticket_id`),
  ADD KEY `booking_id` (`booking_id`),
  ADD KEY `flight_id` (`flight_id`);

--
-- Индекси за таблица `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bookings`
--
ALTER TABLE `bookings`
  MODIFY `booking_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `customer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `flights`
--
ALTER TABLE `flights`
  MODIFY `flight_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `reviews`
--
ALTER TABLE `reviews`
  MODIFY `review_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tickets`
--
ALTER TABLE `tickets`
  MODIFY `ticket_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Ограничения за дъмпнати таблици
--
ALTER TABLE reviews DROP FOREIGN KEY reviews_ibfk_1;
ALTER TABLE reviews DROP FOREIGN KEY reviews_ibfk_2;
ALTER TABLE bookings DROP FOREIGN KEY bookings_ibfk_1;
ALTER TABLE tickets DROP FOREIGN KEY tickets_ibfk_1;
ALTER TABLE tickets DROP FOREIGN KEY tickets_ibfk_2;
--
-- Ограничения за таблица `bookings`
--
ALTER TABLE `bookings`
  ADD CONSTRAINT bookings_ibfk_1
    FOREIGN KEY (customer_id) REFERENCES customers(customer_id)
    ON DELETE CASCADE;

--
-- Ограничения за таблица `reviews`
--
ALTER TABLE `reviews`
  ADD CONSTRAINT reviews_ibfk_1
    FOREIGN KEY (flight_id) REFERENCES flights(flight_id)
    ON DELETE CASCADE,
  ADD CONSTRAINT reviews_ibfk_2
    FOREIGN KEY (customer_id) REFERENCES customers(customer_id)
    ON DELETE CASCADE;

--
-- Ограничения за таблица `tickets`
--
ALTER TABLE `tickets`
 ADD CONSTRAINT tickets_ibfk_1
    FOREIGN KEY (booking_id) REFERENCES bookings(booking_id)
    ON DELETE CASCADE,
  ADD CONSTRAINT tickets_ibfk_2
    FOREIGN KEY (flight_id) REFERENCES flights(flight_id)
    ON DELETE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
