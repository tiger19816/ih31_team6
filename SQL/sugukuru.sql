-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 
-- サーバのバージョン： 10.1.31-MariaDB
-- PHP Version: 7.2.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sugukuru`
--
CREATE DATABASE IF NOT EXISTS `sugukuru` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `sugukuru`;

-- --------------------------------------------------------

--
-- テーブルの構造 `auction_hall`
--

CREATE TABLE `auction_hall` (
  `id` int(11) NOT NULL COMMENT 'オークション会場ID',
  `auction_hall_name` varchar(30) NOT NULL COMMENT 'オークション会場名'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- テーブルのデータのダンプ `auction_hall`
--

INSERT INTO `auction_hall` (`id`, `auction_hall_name`) VALUES
(1, 'HAA神戸'),
(2, 'ベイオーク'),
(3, '大阪日産AA'),
(4, 'USS名古屋'),
(5, 'USS横浜');

-- --------------------------------------------------------

--
-- テーブルの構造 `bid`
--

CREATE TABLE `bid` (
  `order_id` char(9) NOT NULL COMMENT '受注ID',
  `auction_hall_id` int(11) NOT NULL COMMENT 'オークション会場ID',
  `listing_number` int(11) NOT NULL COMMENT '出品番号',
  `bid_date` date NOT NULL COMMENT '入札日付',
  `bid_price` int(11) NOT NULL COMMENT '入札金額',
  `bid_result` int(11) NOT NULL COMMENT '入札結果'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='入札テーブル';

--
-- テーブルのデータのダンプ `bid`
--

INSERT INTO `bid` (`order_id`, `auction_hall_id`, `listing_number`, `bid_date`, `bid_price`, `bid_result`) VALUES
('181110001', 1, 12345, '2018-11-14', 850000, 1),
('181110002', 1, 12346, '2018-11-14', 700000, 1);

-- --------------------------------------------------------

--
-- テーブルの構造 `bill`
--

CREATE TABLE `bill` (
  `invoice_number` char(10) NOT NULL COMMENT '請求書番号',
  `customer_id` char(5) NOT NULL COMMENT '顧客ID',
  `billing_date` date NOT NULL COMMENT '請求日',
  `billing_representative` char(3) NOT NULL COMMENT '請求担当者',
  `payment_criteria` varchar(50) NOT NULL COMMENT '支払条件',
  `remarks` text NOT NULL COMMENT '備考'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='請求書';

--
-- テーブルのデータのダンプ `bill`
--

INSERT INTO `bill` (`invoice_number`, `customer_id`, `billing_date`, `billing_representative`, `payment_criteria`, `remarks`) VALUES
('1800118011', '18001', '2018-11-21', '101', '月末締翌月末払', '');

-- --------------------------------------------------------

--
-- テーブルの構造 `billing_clearing`
--

CREATE TABLE `billing_clearing` (
  `no` char(10) NOT NULL COMMENT '請求書番号',
  `amount` int(11) NOT NULL COMMENT '入金額',
  `clearing_flag` int(11) NOT NULL DEFAULT '0' COMMENT '消込フラグ'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='請求消込';

--
-- テーブルのデータのダンプ `billing_clearing`
--

INSERT INTO `billing_clearing` (`no`, `amount`, `clearing_flag`) VALUES
('1800118011', 1000000, 2);

-- --------------------------------------------------------

--
-- テーブルの構造 `billing_detail`
--

CREATE TABLE `billing_detail` (
  `invoice_number` char(10) NOT NULL COMMENT '請求書番号',
  `no` int(11) NOT NULL COMMENT '項番',
  `order_id` char(9) NOT NULL COMMENT '受注ID',
  `product_name` varchar(100) NOT NULL COMMENT '品名',
  `quantity` int(11) NOT NULL COMMENT '数量',
  `unit` varchar(3) NOT NULL COMMENT '単位',
  `unit_price` int(11) NOT NULL COMMENT '単価'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='請求明細';

--
-- テーブルのデータのダンプ `billing_detail`
--

INSERT INTO `billing_detail` (`invoice_number`, `no`, `order_id`, `product_name`, `quantity`, `unit`, `unit_price`) VALUES
('1800118011', 1, '181110001', 'JZS144 クラウン', 1, '台', 1000000),
('1800118011', 2, '181110002', 'L600S ムーブ', 1, '台', 1000000);

-- --------------------------------------------------------

--
-- テーブルの構造 `client`
--

CREATE TABLE `client` (
  `id` char(5) NOT NULL COMMENT '顧客ID',
  `formal_name` varchar(50) NOT NULL COMMENT '正式名称',
  `formal_name_read` varchar(50) NOT NULL COMMENT '正式名称カナ',
  `abbreviation` varchar(50) NOT NULL COMMENT '略称',
  `abbreviation_read` varchar(50) NOT NULL COMMENT '略称読み',
  `postal_code` char(7) NOT NULL COMMENT '郵便番号',
  `prefectures` varchar(4) NOT NULL COMMENT '都道府県',
  `municipality` varchar(50) NOT NULL COMMENT '市町村以下',
  `client_division` varchar(20) NOT NULL COMMENT '取引先部署',
  `client_rep` varchar(20) NOT NULL COMMENT '取引先担当者',
  `phone_number` char(11) NOT NULL COMMENT '電話番号',
  `fax` char(11) NOT NULL COMMENT 'ファックス',
  `mail_address` varchar(100) NOT NULL COMMENT 'メールアドレス',
  `monthly_trading_estimated` int(11) NOT NULL COMMENT '月間取引見込み',
  `recovery_condition` int(11) NOT NULL COMMENT '回収条件',
  `closing_date` int(11) NOT NULL COMMENT '締日',
  `collection_month` int(11) NOT NULL COMMENT '回収月',
  `collection_date` int(11) NOT NULL COMMENT '回収日',
  `financial_institution_name` varchar(30) NOT NULL COMMENT '金融機関名',
  `financial_institution_code` char(4) NOT NULL COMMENT '金融機関コード',
  `branch_name` varchar(30) NOT NULL COMMENT '支店名',
  `branch_code` char(3) NOT NULL COMMENT '支店コード',
  `bank_account_type` int(11) NOT NULL COMMENT '口座種別',
  `bank_account_number` char(7) NOT NULL COMMENT '口座番号',
  `bank_account_holder` varchar(30) NOT NULL COMMENT '口座名義',
  `fine_info` text COMMENT '微細情報',
  `create_at` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT '登録日',
  `create_rep` char(3) NOT NULL COMMENT '登録担当者',
  `update_at` datetime NOT NULL DEFAULT '0000-00-00 00:00:00' ON UPDATE CURRENT_TIMESTAMP COMMENT '変更日',
  `update_rep` char(3) DEFAULT '' COMMENT '変更担当者',
  `sales_rep` char(3) NOT NULL DEFAULT '' COMMENT '営業担当者'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='顧客テーブル';

--
-- テーブルのデータのダンプ `client`
--

INSERT INTO `client` (`id`, `formal_name`, `formal_name_read`, `abbreviation`, `abbreviation_read`, `postal_code`, `prefectures`, `municipality`, `client_division`, `client_rep`, `phone_number`, `fax`, `mail_address`, `monthly_trading_estimated`, `recovery_condition`, `closing_date`, `collection_month`, `collection_date`, `financial_institution_name`, `financial_institution_code`, `branch_name`, `branch_code`, `bank_account_type`, `bank_account_number`, `bank_account_holder`, `fine_info`, `create_at`, `create_rep`, `update_at`, `update_rep`, `sales_rep`) VALUES
('18001', '株式会社カーステーションバンバン', 'カブシキガイシャカーステーションバンバン', 'カーステバン', 'カーステバン', '5300001', '大阪府', '北区梅田3-3-1', '営業部', '岡本隆', '0612345678', '0623456789', 'okamoto@carban.co.jp', 100, 1, 20, 1, 15, '三井住友銀行', '0009', '天六支店', '130', 0, '1234567', 'ｶ)ｶｰｽﾃｰｼﾖﾝﾊﾞﾝﾊﾞﾝ', NULL, '2018-11-06 16:41:30', '101', '2018-11-20 15:58:12', NULL, '102'),
('18002', '株式会社パシフィックオート', 'カブシキガイシャパシフィックオート', 'パシフオート', 'パシフオート', '5300001', '大阪府', '北区梅田3-3-1', '総務部', '今井哲文', '0612345555', '0623456785', 'imai@pasificauto.co.jp', 100, 1, 20, 1, 15, '三井住友銀行', '0009', '天六支店', '130', 0, '1234567', 'ｶ)ﾊﾟｼﾌｲﾂｸｵｰﾄ', NULL, '2018-11-06 16:41:30', '101', '2018-11-20 15:58:50', NULL, '102'),
('18003', '株式会社オフィスMIYA', 'カブシキガイシャオフィスミヤ', 'オフィスミヤ', 'オフィスミヤ', '5300001', '大阪府', '北区梅田3-3-1', '営業部', '田中太郎', '0612345678', '0623456789', 'okamoto@carban.co.jp', 100, 1, 20, 1, 15, '三井住友銀行', '0009', '天六支店', '130', 0, '1234567', 'ｶ)ｵﾌｲｽﾐﾔ', NULL, '2018-11-13 18:10:15', '101', '2018-11-20 16:00:03', NULL, '102');

-- --------------------------------------------------------

--
-- テーブルの構造 `document`
--

CREATE TABLE `document` (
  `id` int(11) NOT NULL,
  `name` varchar(20) NOT NULL COMMENT '書類名',
  `category` int(11) NOT NULL COMMENT '必要書類(0)登録ナンバー付(1)抹消済(2)'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='書類';

--
-- テーブルのデータのダンプ `document`
--

INSERT INTO `document` (`id`, `name`, `category`) VALUES
(1, 'オークション出品票', 0),
(2, '検査証', 1),
(3, '自賠責保険証書', 1),
(4, '譲渡証明', 1),
(5, '印鑑証明', 1),
(6, '委任状', 1),
(7, '抹消証明', 2);

-- --------------------------------------------------------

--
-- テーブルの構造 `employee`
--

CREATE TABLE `employee` (
  `id` char(3) NOT NULL COMMENT '社員ID',
  `family_name` varchar(10) NOT NULL COMMENT '姓',
  `first_name` varchar(10) NOT NULL COMMENT '名',
  `family_name_read` varchar(20) NOT NULL COMMENT '姓読み',
  `first_name_read` varchar(20) NOT NULL COMMENT '名読み',
  `mail_address` varchar(100) NOT NULL COMMENT 'メールアドレス',
  `password` varchar(20) NOT NULL COMMENT 'パスワード',
  `postal_code` char(7) NOT NULL COMMENT '郵便番号',
  `address` varchar(50) NOT NULL COMMENT '住所',
  `birthdate` date NOT NULL COMMENT '誕生日',
  `division` int(11) NOT NULL COMMENT '部署(事務：1、営業：2)',
  `post` int(11) NOT NULL COMMENT '役職',
  `create_at` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT '登録日',
  `update_at` datetime NOT NULL DEFAULT '0000-00-00 00:00:00' ON UPDATE CURRENT_TIMESTAMP COMMENT '変更日'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='社員テーブル';

--
-- テーブルのデータのダンプ `employee`
--

INSERT INTO `employee` (`id`, `family_name`, `first_name`, `family_name_read`, `first_name_read`, `mail_address`, `password`, `postal_code`, `address`, `birthdate`, `division`, `post`, `create_at`, `update_at`) VALUES
('101', '岡本', '義則', 'オカモト', 'ヨシノリ', 'okamoto@sugukuru.co.jp', 'password', '5300001', '大阪市北区梅田3-3-1', '1990-11-12', 1, 1, '2018-11-07 12:58:13', '0000-00-00 00:00:00'),
('102', '山田', '太郎', 'ヤマダ', 'タロウ', 'yamada@sugukuru.co.jp', 'password', '5300001', '大阪市北区梅田3-3-1', '1990-04-12', 2, 1, '2018-11-07 12:58:13', '2018-11-11 05:00:19'),
('103', '渡辺', '勇樹', 'ワタナベ', 'ユウキ', 'watanabe@sugukuru.co.jp', 'password', '5300001', '大阪市北区梅田3-3-1', '1988-11-27', 2, 1, '2018-11-07 12:58:13', '2018-11-11 05:00:23');

-- --------------------------------------------------------

--
-- テーブルの構造 `orders`
--

CREATE TABLE `orders` (
  `id` char(9) NOT NULL COMMENT '受注ID',
  `client_id` char(5) NOT NULL COMMENT '顧客ID',
  `order_type` int(11) NOT NULL COMMENT '受注種別',
  `car_model` varchar(30) NOT NULL COMMENT '型式',
  `car_classification` varchar(30) NOT NULL COMMENT '車種',
  `car_model_year` char(3) NOT NULL COMMENT '年式',
  `car_color` varchar(5) NOT NULL COMMENT '色',
  `transmission` int(11) NOT NULL COMMENT 'AT(0)/MT(1)',
  `car_mileage` int(11) NOT NULL COMMENT '走行距離',
  `budget` int(11) NOT NULL COMMENT '予算',
  `fine_info` text NOT NULL COMMENT '微細情報',
  `order_rep` char(3) NOT NULL COMMENT '受注担当者',
  `create_at` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT '登録日',
  `create_rep` char(3) NOT NULL COMMENT '登録担当者',
  `update_at` datetime NOT NULL DEFAULT '0000-00-00 00:00:00' ON UPDATE CURRENT_TIMESTAMP COMMENT '変更日',
  `update_rep` char(3) NOT NULL COMMENT '変更担当者',
  `cancel_flag` int(11) NOT NULL DEFAULT '0' COMMENT 'キャンセルフラグ'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='受注テーブル';

--
-- テーブルのデータのダンプ `orders`
--

INSERT INTO `orders` (`id`, `client_id`, `order_type`, `car_model`, `car_classification`, `car_model_year`, `car_color`, `transmission`, `car_mileage`, `budget`, `fine_info`, `order_rep`, `create_at`, `create_rep`, `update_at`, `update_rep`, `cancel_flag`) VALUES
('181110001', '18001', 1, 'JZS144', 'クラウン', 'H10', 'パール', 0, 50000, 1000000, '', '102', '2018-11-12 15:42:07', '101', '0000-00-00 00:00:00', '', 0),
('181110002', '18001', 1, 'L600S', 'ムーブ', 'H10', 'シルバー', 0, 50000, 1000000, '', '102', '2018-11-13 15:17:57', '101', '0000-00-00 00:00:00', '', 0),
('181110003', '18002', 1, 'LH186', 'ハイエース', 'H14', 'シルバー', 0, 50000, 1500000, '', '102', '2018-11-13 15:17:57', '101', '0000-00-00 00:00:00', '', 0);

-- --------------------------------------------------------

--
-- テーブルの構造 `procedure_after_successful_bid`
--

CREATE TABLE `procedure_after_successful_bid` (
  `order_id` char(10) NOT NULL COMMENT '受注ID',
  `rep_id` char(3) NOT NULL COMMENT '担当者ID',
  `payment_status` int(11) NOT NULL COMMENT '支払い状況',
  `payment_due` date NOT NULL COMMENT '支払い期限',
  `vehicle_registration_status` int(11) NOT NULL COMMENT '車両登録状況',
  `procedure_content` varchar(50) DEFAULT NULL COMMENT '手続内容',
  `report_deadline` date DEFAULT NULL COMMENT '報告期限',
  `procedure_flag` int(11) DEFAULT NULL COMMENT 'オークション手続伝達フラグ',
  `report_complete_date` date DEFAULT NULL COMMENT '報告完了日付'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='落札後手続きテーブル';

-- --------------------------------------------------------

--
-- テーブルの構造 `quote`
--

CREATE TABLE `quote` (
  `id` char(10) NOT NULL COMMENT '見積書番号',
  `client_id` char(5) NOT NULL COMMENT '顧客ID',
  `quote_date` date NOT NULL COMMENT '見積日',
  `quote_rep` char(3) NOT NULL COMMENT '見積担当者',
  `expiry_date` varchar(20) NOT NULL COMMENT '有効期限',
  `payment_term` varchar(20) NOT NULL COMMENT '支払条件',
  `delivery_date` varchar(20) NOT NULL COMMENT '納期',
  `remarks` text NOT NULL COMMENT '備考'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='見積テーブル';

-- --------------------------------------------------------

--
-- テーブルの構造 `quote_detail`
--

CREATE TABLE `quote_detail` (
  `quote_id` char(10) NOT NULL COMMENT '見積ID',
  `no` int(11) NOT NULL COMMENT '項番',
  `order_id` char(10) NOT NULL COMMENT '受注ID',
  `product_name` varchar(20) NOT NULL COMMENT '品名',
  `quantity` int(11) NOT NULL COMMENT '数量',
  `unit` int(11) NOT NULL COMMENT '単位',
  `price` int(11) NOT NULL COMMENT '単価'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='見積明細テーブル';

-- --------------------------------------------------------

--
-- テーブルの構造 `recieved_document`
--

CREATE TABLE `recieved_document` (
  `order_id` char(10) NOT NULL COMMENT '受注ID',
  `document_id` int(11) NOT NULL COMMENT '書類ID'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- テーブルの構造 `successful_bid_vehicle`
--

CREATE TABLE `successful_bid_vehicle` (
  `order_id` char(9) NOT NULL COMMENT '受注ID',
  `car_model` varchar(30) NOT NULL COMMENT '型式',
  `undercarriage_number` varchar(20) NOT NULL COMMENT '車台番号',
  `car_model_year` char(9) NOT NULL COMMENT '年式',
  `car_name` varchar(30) NOT NULL COMMENT '車名',
  `car_color` varchar(5) NOT NULL COMMENT '色',
  `car_mileage` varchar(15) NOT NULL COMMENT '走行距離',
  `transmission` int(11) NOT NULL COMMENT 'AT/MT',
  `fine_info` text NOT NULL COMMENT '微細情報',
  `successful_bid_vehicle_tax` int(11) NOT NULL COMMENT '落札車両消費税',
  `contracted_successful_bid_quantity` int(11) NOT NULL COMMENT '成約落札量',
  `vehicle_tax_equivalent` int(11) NOT NULL COMMENT '車両税相当額',
  `fee` int(11) NOT NULL COMMENT '手数料',
  `successful_bid_fixing` int(11) NOT NULL COMMENT '落札確定'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='落札車両テーブル';

-- --------------------------------------------------------

--
-- テーブルの構造 `transportation`
--

CREATE TABLE `transportation` (
  `order_id` char(9) NOT NULL COMMENT '受注ID',
  `vendor_id` char(3) NOT NULL COMMENT '業者ID',
  `starting_postal_code` char(7) NOT NULL COMMENT '出発地郵便番号',
  `starting_address` varchar(100) NOT NULL COMMENT '出発地住所',
  `destination_postal_code` char(7) NOT NULL COMMENT '到着地郵便番号',
  `destination_address` varchar(100) NOT NULL COMMENT '到着地住所',
  `fee` int(11) NOT NULL COMMENT '料金',
  `order_date` date NOT NULL COMMENT '依頼日',
  `slip_number` varchar(20) NOT NULL COMMENT '伝票番号',
  `responsible_id` char(3) NOT NULL COMMENT '担当者ID'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='陸送情報';

-- --------------------------------------------------------

--
-- テーブルの構造 `transportation_vendor`
--

CREATE TABLE `transportation_vendor` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL COMMENT '陸送業者名'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='陸送業者';

--
-- テーブルのデータのダンプ `transportation_vendor`
--

INSERT INTO `transportation_vendor` (`id`, `name`) VALUES
(1, ' 株式会社オークション・トランスポート'),
(2, ' 新富士陸送株式会社'),
(3, ' スズキ輸送梱包株式会社'),
(4, ' 国際陸送有限会社'),
(5, '株式会社ゼロ'),
(6, '株式会社テイクオフ');

-- --------------------------------------------------------

--
-- テーブルの構造 `unbilled_data`
--

CREATE TABLE `unbilled_data` (
  `id` int(11) NOT NULL,
  `customer_id` char(5) NOT NULL COMMENT '顧客ID',
  `order_id` char(9) NOT NULL COMMENT '受注ID',
  `recorded_date` date NOT NULL COMMENT '計上日',
  `billing_amount` varchar(50) NOT NULL COMMENT '品名',
  `quantity` int(11) NOT NULL COMMENT '数量',
  `unit` varchar(3) NOT NULL COMMENT '単位',
  `unit_price` int(11) NOT NULL COMMENT '単価',
  `comp_flag` int(11) NOT NULL COMMENT '完了フラグ'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- テーブルのデータのダンプ `unbilled_data`
--

INSERT INTO `unbilled_data` (`id`, `customer_id`, `order_id`, `recorded_date`, `billing_amount`, `quantity`, `unit`, `unit_price`, `comp_flag`) VALUES
(1, '18001', '181110001', '2018-11-15', 'JZS144 クラウン', 1, '台', 1000000, 1),
(2, '18001', '181110002', '2018-11-15', 'L600S ムーブ', 1, '台', 1000000, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `auction_hall`
--
ALTER TABLE `auction_hall`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `bid`
--
ALTER TABLE `bid`
  ADD PRIMARY KEY (`order_id`);

--
-- Indexes for table `bill`
--
ALTER TABLE `bill`
  ADD PRIMARY KEY (`invoice_number`);

--
-- Indexes for table `billing_clearing`
--
ALTER TABLE `billing_clearing`
  ADD PRIMARY KEY (`no`);

--
-- Indexes for table `billing_detail`
--
ALTER TABLE `billing_detail`
  ADD PRIMARY KEY (`invoice_number`,`no`);

--
-- Indexes for table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `document`
--
ALTER TABLE `document`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `procedure_after_successful_bid`
--
ALTER TABLE `procedure_after_successful_bid`
  ADD PRIMARY KEY (`order_id`);

--
-- Indexes for table `quote`
--
ALTER TABLE `quote`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `quote_detail`
--
ALTER TABLE `quote_detail`
  ADD PRIMARY KEY (`quote_id`,`no`);

--
-- Indexes for table `recieved_document`
--
ALTER TABLE `recieved_document`
  ADD PRIMARY KEY (`order_id`,`document_id`);

--
-- Indexes for table `successful_bid_vehicle`
--
ALTER TABLE `successful_bid_vehicle`
  ADD PRIMARY KEY (`order_id`);

--
-- Indexes for table `transportation`
--
ALTER TABLE `transportation`
  ADD PRIMARY KEY (`order_id`);

--
-- Indexes for table `transportation_vendor`
--
ALTER TABLE `transportation_vendor`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `unbilled_data`
--
ALTER TABLE `unbilled_data`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `auction_hall`
--
ALTER TABLE `auction_hall`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'オークション会場ID', AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `document`
--
ALTER TABLE `document`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `transportation_vendor`
--
ALTER TABLE `transportation_vendor`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `unbilled_data`
--
ALTER TABLE `unbilled_data`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
