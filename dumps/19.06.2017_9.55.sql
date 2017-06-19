-- phpMyAdmin SQL Dump
-- version 4.0.10.15
-- http://www.phpmyadmin.net
--
-- Хост: localhost
-- Время создания: Июн 19 2017 г., 09:55
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
  `code` varchar(20) NOT NULL,
  `description` varchar(200) NOT NULL,
  `measure` varchar(20) NOT NULL,
  `amount` int(11) NOT NULL,
  `region` varchar(50) NOT NULL,
  `frp` int(11) NOT NULL,
  `status` int(11) NOT NULL,
  `request` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=28 ;

--
-- Дамп данных таблицы `materials`
--

INSERT INTO `materials` (`id`, `code`, `description`, `measure`, `amount`, `region`, `frp`, `status`, `request`) VALUES
(27, '6', 'Вата', 'шт', 7, 'Россия', 2, 0, 1),
(26, '123', 'абвгд', 'шт', 2, 'Россия', 2, 0, 1),
(25, '2', 'Марля', 'шт', 5, 'Россия', 2, 0, 1),
(24, '7', 'Вата2', 'шт', 8, 'Россия', 2, 0, 1),
(23, '4', 'Вата', 'шт', 7, 'Россия', 2, 0, 1),
(22, '3', 'Бинт', 'шт', 7, 'Германия', 2, 0, 1);

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
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=7 ;

--
-- Дамп данных таблицы `requests`
--

INSERT INTO `requests` (`id`, `code`, `ts`, `status`, `frp`, `type`) VALUES
(6, 1, '2017-06-19 06:53:33', 1, 2, 0);

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
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `login`, `password`, `last_name`, `name`, `patronymic`, `role_id`) VALUES
(1, '0001', '123', 'Админов', 'Админ', 'Админыч', 1),
(2, '0002', 'qwe', 'Иванов', 'Федор', 'Петрович', 3);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
