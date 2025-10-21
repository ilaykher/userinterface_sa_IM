-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 01, 2025 at 07:51 AM
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
-- Database: `information_management`
--

-- --------------------------------------------------------

--
-- Table structure for table `cart`
--

CREATE TABLE `cart` (
  `cart_id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `product_id` int(11) DEFAULT NULL,
  `product_name` varchar(255) DEFAULT NULL,
  `price` decimal(10,2) DEFAULT NULL,
  `description` text DEFAULT NULL,
  `quantity` int(11) DEFAULT 1,
  `added_date` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cart`
--

INSERT INTO `cart` (`cart_id`, `user_id`, `product_id`, `product_name`, `price`, `description`, `quantity`, `added_date`) VALUES
(14, 2, 9, 'Asus ROG G14', 95000.00, 'Processor: AMD Ryzen™ 9 8945HS (up to 5.2 GHz, 8 cores, 16 threads) with AMD XDNA™ NPU up to 16 TOPS\n\nGraphics: Up to NVIDIA® GeForce RTX™ 4070 Laptop GPU (8GB GDDR6)\n\nDisplay: 14\" 3K OLED 120Hz Nebula Display with VESA DisplayHDR True Black 500 support\n\nMemory: Up to 32GB LPDDR5X RAM\n\nStorage: Up to 1TB PCIe 4.0 SSD\n\nOperating System: Windows 11 Pro\n\nWeight: Approximately 1.5 kg (3.3 lbs)\n\nCooling: ROG Intelligent Cooling with Tri-fan technology and liquid metal\n\nPorts: Comprehensive selection including USB-C, USB-A, HDMI, and microSD card slot\n\nBattery Life: Approximately 5–6 hours', 1, '2025-10-01 08:22:06'),
(15, 2, 6, 'Office PC', 35000.00, 'Intel i5, 8GB RAM', 1, '2025-10-01 08:22:11'),
(19, 3, 1, 'iPhone 15 Pro', 45000.00, 'Latest iPhone with A17 Pro chip', 1, '2025-10-01 13:39:00'),
(20, 3, 4, 'Dell XPS 15', 75000.00, 'Intel i7, 16GB RAM', 1, '2025-10-01 13:39:05');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `order_id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `product_id` int(11) DEFAULT NULL,
  `product_name` varchar(255) DEFAULT NULL,
  `price` decimal(10,2) DEFAULT NULL,
  `order_date` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`order_id`, `user_id`, `product_id`, `product_name`, `price`, `order_date`) VALUES
(1, 2, 9, 'Asus ROG G14', 95000.00, '2025-10-01 07:14:31'),
(2, 2, 9, 'Asus ROG G14', 95000.00, '2025-10-01 07:20:03'),
(3, 2, 1, 'iPhone 15 Pro', 45000.00, '2025-10-01 08:01:59'),
(4, 2, 4, 'Dell XPS 15', 75000.00, '2025-10-01 08:01:59'),
(5, 2, 6, 'Office PC', 35000.00, '2025-10-01 08:01:59'),
(6, 3, 2, 'Samsung Galaxy S24', 40000.00, '2025-10-01 13:38:45'),
(7, 3, 6, 'Office PC', 35000.00, '2025-10-01 13:38:45');

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `product_id` int(11) NOT NULL,
  `product_name` varchar(200) NOT NULL,
  `category` varchar(50) NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `stock` int(11) DEFAULT 0,
  `description` text DEFAULT NULL,
  `image_path` varchar(255) DEFAULT NULL,
  `created_date` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`product_id`, `product_name`, `category`, `price`, `stock`, `description`, `image_path`, `created_date`) VALUES
(1, 'iPhone 15 Pro', 'Cellphone', 45000.00, 9, 'Latest iPhone with A17 Pro chip', 'C:\\DeviceMarketImg\\iphone15.jpg', '2025-09-30 19:49:18'),
(2, 'Samsung Galaxy S24', 'Cellphone', 40000.00, 14, 'Samsung flagship', 'C:\\DeviceMarketImg\\Samsung Galaxy S24.jpg', '2025-09-30 19:49:18'),
(4, 'Dell XPS 15', 'Laptop', 75000.00, 4, 'Intel i7, 16GB RAM', 'C:\\DeviceMarketImg\\Dell XPS 15.jpg', '2025-09-30 19:49:18'),
(5, 'Gaming PC', 'Computer', 80000.00, 3, 'i7-12700K, RTX 3060, 16GB RAM', 'C:\\DeviceMarketImg\\Gaming PC.jpg', '2025-09-30 19:49:18'),
(6, 'Office PC', 'Computer', 35000.00, 5, 'Intel i5, 8GB RAM', 'C:\\DeviceMarketImg\\Office PC.jpg', '2025-09-30 19:49:18'),
(9, 'Asus ROG G14', 'Laptop', 95000.00, 8, 'Processor: AMD Ryzen™ 9 8945HS (up to 5.2 GHz, 8 cores, 16 threads) with AMD XDNA™ NPU up to 16 TOPS\n\nGraphics: Up to NVIDIA® GeForce RTX™ 4070 Laptop GPU (8GB GDDR6)\n\nDisplay: 14\" 3K OLED 120Hz Nebula Display with VESA DisplayHDR True Black 500 support\n\nMemory: Up to 32GB LPDDR5X RAM\n\nStorage: Up to 1TB PCIe 4.0 SSD\n\nOperating System: Windows 11 Pro\n\nWeight: Approximately 1.5 kg (3.3 lbs)\n\nCooling: ROG Intelligent Cooling with Tri-fan technology and liquid metal\n\nPorts: Comprehensive selection including USB-C, USB-A, HDMI, and microSD card slot\n\nBattery Life: Approximately 5–6 hours', 'C:\\DeviceMarketImg\\AsusRogG14.jpg', '2025-10-01 01:01:22');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `email` varchar(255) DEFAULT NULL,
  `balance` decimal(10,2) DEFAULT NULL,
  `security_question` varchar(255) DEFAULT NULL,
  `security_answer` varchar(255) DEFAULT NULL,
  `created_date` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `username`, `password`, `email`, `balance`, `security_question`, `security_answer`, `created_date`) VALUES
(1, 'admin', 'admin', NULL, NULL, NULL, NULL, '2025-09-27 23:26:36'),
(2, 'user1', 'userOne', NULL, 185273.00, 'What is your favorite color?', 'Green', '2025-09-30 19:08:50'),
(3, 'James', '12345', NULL, 45000.00, 'What is your favorite color?', 'Red', '2025-10-01 13:34:33');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cart`
--
ALTER TABLE `cart`
  ADD PRIMARY KEY (`cart_id`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`order_id`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`product_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cart`
--
ALTER TABLE `cart`
  MODIFY `cart_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `order_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `product_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
