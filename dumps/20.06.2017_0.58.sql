-- phpMyAdmin SQL Dump
-- version 4.0.10.15
-- http://www.phpmyadmin.net
--
-- Хост: localhost
-- Время создания: Июн 20 2017 г., 00:58
-- Версия сервера: 5.1.73
-- Версия PHP: 5.3.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- База данных: `arm`
--

-- --------------------------------------------------------

--
-- Структура таблицы `materials`
--

CREATE TABLE IF NOT EXISTS `materials` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `description` varchar(200) NOT NULL,
  `measure` varchar(20) NOT NULL,
  `amount` int(11) NOT NULL,
  `region` varchar(50) NOT NULL,
  `frp` int(11) NOT NULL,
  `request` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=30 ;

--
-- Дамп данных таблицы `materials`
--

INSERT INTO `materials` (`id`, `description`, `measure`, `amount`, `region`, `frp`, `request`) VALUES
(27, 'Вата', 'шт', 7, 'Россия', 2, 1),
(26, 'абвгд', 'шт', 2, 'Россия', 2, 1),
(25, 'Марля', 'шт', 5, 'Россия', 2, 1),
(24, 'Вата2', 'шт', 8, 'Россия', 2, 1),
(23, 'Вата', 'шт', 7, 'Россия', 2, 1),
(22, 'Бинт', 'шт', 7, 'Германия', 2, 1),
(29, '123', 'qwe', 12, '12', 2, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `requests`
--

CREATE TABLE IF NOT EXISTS `requests` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `code` int(11) NOT NULL,
  `ts` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `status` int(11) NOT NULL,
  `frp` int(11) NOT NULL,
  `type` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=12 ;

--
-- Дамп данных таблицы `requests`
--

INSERT INTO `requests` (`id`, `code`, `ts`, `status`, `frp`, `type`) VALUES
(6, 1, '2017-06-19 17:41:13', 0, 2, 0),
(7, 2, '2017-06-19 17:45:39', 0, 2, 0),
(8, 3, '2017-06-19 19:08:16', 0, 2, 0),
(9, 4, '2017-06-19 21:57:18', 1, 2, 1),
(10, 5, '2017-06-19 21:54:05', 1, 2, 1),
(11, 6, '2017-06-19 21:55:43', 1, 2, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `temp_materials`
--

CREATE TABLE IF NOT EXISTS `temp_materials` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `description` varchar(200) NOT NULL,
  `measure` varchar(20) NOT NULL,
  `amount` int(11) NOT NULL,
  `region` varchar(50) NOT NULL,
  `frp` int(11) NOT NULL,
  `request` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=9 ;

--
-- Дамп данных таблицы `temp_materials`
--

INSERT INTO `temp_materials` (`id`, `description`, `measure`, `amount`, `region`, `frp`, `request`) VALUES
(1, 'dsad', '12', 12, '1212', 1, 1),
(2, '123', 'qwe', 12, '12', 12, 12),
(3, 'asdasd', '123', 1231, '123', 2, 2),
(5, '123', 'qwe', 1, '12', 2, 3),
(8, 'Бинт', 'шт', 2, 'Германия', 2, 6);

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(50) NOT NULL,
  `password` varchar(200) NOT NULL,
  `last_name` varchar(200) NOT NULL,
  `name` varchar(200) NOT NULL,
  `patronymic` varchar(200) NOT NULL,
  `role_id` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=6 ;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `login`, `password`, `last_name`, `name`, `patronymic`, `role_id`) VALUES
(1, '0001', '123', 'Админов', 'Админ', 'Админыч', 1),
(2, '0002', 'qwe', 'Иванов', 'Федор', 'Петрович', 2),
(5, '0003', 'qwe', 'Бухгалтер', 'Буглат', 'Бухгалтерьевич', 3);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
