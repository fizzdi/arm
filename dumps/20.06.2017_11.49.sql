-- phpMyAdmin SQL Dump
-- version 4.0.10.15
-- http://www.phpmyadmin.net
--
-- Хост: localhost
-- Время создания: Июн 20 2017 г., 11:49
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
-- Структура таблицы `config`
--

CREATE TABLE IF NOT EXISTS `config` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `num` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=2 ;

--
-- Дамп данных таблицы `config`
--

INSERT INTO `config` (`id`, `num`) VALUES
(1, 10);

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
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=33 ;

--
-- Дамп данных таблицы `materials`
--

INSERT INTO `materials` (`id`, `description`, `measure`, `amount`, `region`, `frp`, `request`) VALUES
(30, 'asdasd', '123', 1231, '123', 2, 2),
(27, 'Вата', 'шт', 100645, 'Россия', 5, 1),
(26, 'абвгд', 'шт', 0, 'Россия', 2, 1),
(25, 'Марля', 'шт', 0, 'Россия', 2, 1),
(24, 'Вата2', 'шт', 3, 'Россия', 2, 1),
(23, 'Вата', 'шт', 100645, 'Россия', 2, 1),
(22, 'Бинт', 'шт', 201, 'Германия', 2, 1),
(29, '123', 'qwe', 23, '12', 2, 1),
(31, 'Хрень', 'мл', 75, 'Россия', 2, 12),
(32, 'fdsfa', 'd', 123, '2', 2, 14);

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
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=21 ;

--
-- Дамп данных таблицы `requests`
--

INSERT INTO `requests` (`id`, `code`, `ts`, `status`, `frp`, `type`) VALUES
(6, 1, '2017-06-20 07:06:42', 1, 2, 0),
(7, 2, '2017-06-20 07:05:53', 1, 2, 0),
(8, 3, '2017-06-20 06:52:34', 1, 2, 0),
(9, 4, '2017-06-19 21:57:18', 1, 2, 1),
(10, 5, '2017-06-19 21:54:05', 1, 2, 1),
(11, 6, '2017-06-19 21:55:43', 1, 2, 1),
(12, 7, '2017-06-20 06:52:24', 1, 2, 1),
(13, 8, '2017-06-20 07:15:24', 1, 2, 1),
(14, 9, '2017-06-20 07:21:11', 1, 2, 1),
(15, 10, '2017-06-20 07:22:20', 1, 2, 0),
(16, 11, '2017-06-20 07:23:49', 1, 2, 0),
(17, 12, '2017-06-20 07:24:56', 1, 2, 0),
(19, 13, '2017-06-20 07:26:51', 1, 2, 0),
(20, 14, '2017-06-20 07:30:03', 1, 2, 0);

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
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=26 ;

--
-- Дамп данных таблицы `temp_materials`
--

INSERT INTO `temp_materials` (`id`, `description`, `measure`, `amount`, `region`, `frp`, `request`) VALUES
(1, 'dsad', '12', 12, '1212', 1, 1),
(2, '123', 'qwe', 12, '12', 12, 12),
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
