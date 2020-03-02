-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  mer. 15 août 2018 à 15:13
-- Version du serveur :  5.7.21
-- Version de PHP :  5.6.35

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `videogames`
--

-- --------------------------------------------------------

--
-- Structure de la table `developer`
--

DROP TABLE IF EXISTS `developer`;
CREATE TABLE IF NOT EXISTS `developer` (
  `idDeveloper` int(11) NOT NULL AUTO_INCREMENT,
  `nameDeveloper` varchar(100) NOT NULL,
  PRIMARY KEY (`idDeveloper`)
) ENGINE=MyISAM AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `developer`
--

INSERT INTO `developer` (`idDeveloper`, `nameDeveloper`) VALUES
(1, 'Harry Cover'),
(2, 'Harty Show');

-- --------------------------------------------------------

--
-- Structure de la table `developervideogame`
--

DROP TABLE IF EXISTS `developervideogame`;
CREATE TABLE IF NOT EXISTS `developervideogame` (
  `iddevvg` int(11) NOT NULL AUTO_INCREMENT,
  `fkvideogame` int(11) NOT NULL,
  `fkdeveloper` int(11) NOT NULL,
  PRIMARY KEY (`iddevvg`)
) ENGINE=MyISAM AUTO_INCREMENT=46 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `developervideogame`
--

INSERT INTO `developervideogame` (`iddevvg`, `fkvideogame`, `fkdeveloper`) VALUES
(1, 1, 1),
(2, 1, 2),
(3, 3, 2),
(4, 2, 1);

-- --------------------------------------------------------

--
-- Structure de la table `editor`
--

DROP TABLE IF EXISTS `editor`;
CREATE TABLE IF NOT EXISTS `editor` (
  `idEditor` int(11) NOT NULL AUTO_INCREMENT,
  `nameEditor` varchar(100) NOT NULL,
  PRIMARY KEY (`idEditor`)
) ENGINE=MyISAM AUTO_INCREMENT=38 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `editor`
--

INSERT INTO `editor` (`idEditor`, `nameEditor`) VALUES
(1, 'Frédérique Andolfatto'),
(2, 'CPNV');

-- --------------------------------------------------------

--
-- Structure de la table `editorvideogame`
--

DROP TABLE IF EXISTS `editorvideogame`;
CREATE TABLE IF NOT EXISTS `editorvideogame` (
  `idedvg` int(11) NOT NULL AUTO_INCREMENT,
  `fkvideogame` int(11) NOT NULL,
  `fkeditor` int(11) NOT NULL,
  PRIMARY KEY (`idedvg`)
) ENGINE=MyISAM AUTO_INCREMENT=75 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `editorvideogame`
--

INSERT INTO `editorvideogame` (`idedvg`, `fkvideogame`, `fkeditor`) VALUES
(1, 1, 1),
(2, 1, 2),
(3, 2, 2),
(4, 3, 1);

-- --------------------------------------------------------

--
-- Structure de la table `platform`
--

DROP TABLE IF EXISTS `platform`;
CREATE TABLE IF NOT EXISTS `platform` (
  `idplatform` int(11) NOT NULL AUTO_INCREMENT,
  `nameplatform` varchar(50) NOT NULL,
  PRIMARY KEY (`idplatform`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `platform`
--

INSERT INTO `platform` (`idplatform`, `nameplatform`) VALUES
(1, 'Nintendo'),
(2, 'Wii'),
(3, 'DS'),
(4, 'Playstation'),
(5, 'Xbox'),
(6, 'PC'),
(7, 'Smartphone');

-- --------------------------------------------------------

--
-- Structure de la table `platformvideogame`
--

DROP TABLE IF EXISTS `platformvideogame`;
CREATE TABLE IF NOT EXISTS `platformvideogame` (
  `idplatformvideogame` int(11) NOT NULL AUTO_INCREMENT,
  `fkplatform` int(11) NOT NULL,
  `fkvideogame` int(11) NOT NULL,
  PRIMARY KEY (`idplatformvideogame`)
) ENGINE=MyISAM AUTO_INCREMENT=86 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `platformvideogame`
--

INSERT INTO `platformvideogame` (`idplatformvideogame`, `fkplatform`, `fkvideogame`) VALUES
(1, 1, 1),
(2, 6, 1),
(3, 2, 2),
(4, 5, 2),
(5, 7, 2),
(6, 6, 2),
(7, 3, 2),
(8, 6, 3),
(9, 7, 3);

-- --------------------------------------------------------

--
-- Structure de la table `type`
--

DROP TABLE IF EXISTS `type`;
CREATE TABLE IF NOT EXISTS `type` (
  `idtype` int(11) NOT NULL AUTO_INCREMENT,
  `nametype` varchar(50) NOT NULL,
  PRIMARY KEY (`idtype`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `type`
--

INSERT INTO `type` (`idtype`, `nametype`) VALUES
(1, 'Action'),
(2, 'Action-aventure'),
(3, 'Aventure'),
(4, 'Jeu de rôle'),
(5, 'Réflexion'),
(6, 'Simulation'),
(7, 'Puzzle'),
(8, 'Casse-brique'),
(9, 'Programmation'),
(10, 'Bac à sable');

-- --------------------------------------------------------

--
-- Structure de la table `videogame`
--

DROP TABLE IF EXISTS `videogame`;
CREATE TABLE IF NOT EXISTS `videogame` (
  `idvideogame` int(11) NOT NULL AUTO_INCREMENT,
  `namevideogame` varchar(255) NOT NULL,
  `dateoutput` date NOT NULL,
  `fktype` int(11) NOT NULL,
  PRIMARY KEY (`idvideogame`)
) ENGINE=MyISAM AUTO_INCREMENT=60 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `videogame`
--

INSERT INTO `videogame` (`idvideogame`, `namevideogame`, `dateoutput`, `fktype`) VALUES
(1, 'Fortnite', '2017-06-01', 3),
(2, 'DreamLeagues', '2018-07-30', 4),
(3, 'Human Resource Machine', '2018-02-05', 9);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

ALTER TABLE videogame
ADD FOREIGN KEY (fktype) REFERENCES type(idtype); 

ALTER TABLE platformvideogame
ADD FOREIGN KEY (fkvideogame) REFERENCES videogame(idvideogame); 

ALTER TABLE platformvideogame
ADD FOREIGN KEY (fkplatform) REFERENCES platform(idplatform); 

ALTER TABLE editorvideogame
ADD FOREIGN KEY (fkvideogame) REFERENCES videogame(idvideogame); 

ALTER TABLE editorvideogame
ADD FOREIGN KEY (fkeditor) REFERENCES editor(ideditor); 

ALTER TABLE developervideogame
ADD FOREIGN KEY (fkvideogame) REFERENCES videogame(idvideogame); 

ALTER TABLE developervideogame
ADD FOREIGN KEY (fkdeveloper) REFERENCES developer(iddeveloper); 
