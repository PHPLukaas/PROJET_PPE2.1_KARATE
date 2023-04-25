-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mar. 25 avr. 2023 à 20:05
-- Version du serveur : 10.4.21-MariaDB
-- Version de PHP : 8.0.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `karate`
--

-- --------------------------------------------------------

--
-- Structure de la table `club`
--

CREATE TABLE `club` (
  `NUM_CLUB` int(11) NOT NULL,
  `NOM_CLUB` varchar(50) NOT NULL,
  `ADR_RUE_CLUB` varchar(50) NOT NULL,
  `CODE_POST_CLUB` varchar(5) NOT NULL,
  `ADR_VILLE_CLUB` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `club`
--

INSERT INTO `club` (`NUM_CLUB`, `NOM_CLUB`, `ADR_RUE_CLUB`, `CODE_POST_CLUB`, `ADR_VILLE_CLUB`) VALUES
(1, 'Karaté-Club Nancéien', '45 rue Emile bertin', '54000', 'Nancy'),
(2, 'SCK Forbach', 'rue de Remsing', '57600', 'Forbach'),
(3, 'Karaté-Club de Metz', '11 rue du Dauphiné', '57070', 'Metz');

-- --------------------------------------------------------

--
-- Structure de la table `competition`
--

CREATE TABLE `competition` (
  `NUM_COMPETITION` int(11) NOT NULL,
  `NUM_CLUB` int(11) NOT NULL,
  `DATE_COMPETITION` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `competition`
--

INSERT INTO `competition` (`NUM_COMPETITION`, `NUM_CLUB`, `DATE_COMPETITION`) VALUES
(1, 1, '2021-10-12'),
(2, 3, '2021-07-13'),
(3, 2, '2022-01-25'),
(4, 1, '2022-02-18');

-- --------------------------------------------------------

--
-- Structure de la table `entraineur`
--

CREATE TABLE `entraineur` (
  `NUM_ENTRAINEUR` int(11) NOT NULL,
  `NUM_CLUB` int(11) NOT NULL,
  `NOM_ENTRAINEUR` varchar(50) NOT NULL,
  `PRENOM_ENTRAINEUR` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `entraineur`
--

INSERT INTO `entraineur` (`NUM_ENTRAINEUR`, `NUM_CLUB`, `NOM_ENTRAINEUR`, `PRENOM_ENTRAINEUR`) VALUES
(1, 1, 'BOURGEOIS', 'Agnès'),
(2, 2, 'BOGUSZ', 'Thierry');

-- --------------------------------------------------------

--
-- Structure de la table `inscription`
--

CREATE TABLE `inscription` (
  `NUM_COMPETITION` int(11) NOT NULL,
  `NUM_LICENCE` varchar(50) NOT NULL,
  `NOTE_GLOBALE` decimal(4,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `inscription`
--

INSERT INTO `inscription` (`NUM_COMPETITION`, `NUM_LICENCE`, `NOTE_GLOBALE`) VALUES
(1, '1234567890', '15.00'),
(1, '5678901234', '11.00'),
(2, '1234567890', '45.00'),
(2, '5678901234', '0.00'),
(3, '5678901234', '0.00'),
(4, '1234567890', '0.00'),
(4, '5678901234', '0.00');

-- --------------------------------------------------------

--
-- Structure de la table `juge`
--

CREATE TABLE `juge` (
  `NUM_COMPETITION` int(11) NOT NULL,
  `NUM_ENTRAINEUR` int(11) NOT NULL,
  `NUM_JURY` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `juge`
--

INSERT INTO `juge` (`NUM_COMPETITION`, `NUM_ENTRAINEUR`, `NUM_JURY`) VALUES
(1, 1, 1),
(1, 2, 2),
(2, 1, 1),
(2, 2, 2);

-- --------------------------------------------------------

--
-- Structure de la table `membre`
--

CREATE TABLE `membre` (
  `NUM_LICENCE` varchar(50) NOT NULL,
  `NUM_CLUB` int(11) NOT NULL,
  `NOM_MEMBRE` varchar(50) NOT NULL,
  `PRENOM_MEMBRE` varchar(50) NOT NULL,
  `DATE_NAISSANCE` date NOT NULL,
  `ADR_RUE_MEMBRE` varchar(50) NOT NULL,
  `CODE_POST_MEMBRE` varchar(5) NOT NULL,
  `ADR_VILLE_MEMBRE` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `membre`
--

INSERT INTO `membre` (`NUM_LICENCE`, `NUM_CLUB`, `NOM_MEMBRE`, `PRENOM_MEMBRE`, `DATE_NAISSANCE`, `ADR_RUE_MEMBRE`, `CODE_POST_MEMBRE`, `ADR_VILLE_MEMBRE`) VALUES
('1234567890', 1, 'MENVUSA', 'Gérard', '1995-06-08', '25 rue des Chats Huants', '54000', 'Nancy'),
('5678901234', 2, 'AVOILE', 'Richard', '1996-01-03', '12 rue du petit Four', '57070', 'Metz');

-- --------------------------------------------------------

--
-- Structure de la table `note`
--

CREATE TABLE `note` (
  `NUM_COMPETITION` int(11) NOT NULL,
  `NUM_LICENCE` varchar(50) NOT NULL,
  `NUM_ENTRAINEUR` int(11) NOT NULL,
  `NOTE` decimal(4,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `note`
--

INSERT INTO `note` (`NUM_COMPETITION`, `NUM_LICENCE`, `NUM_ENTRAINEUR`, `NOTE`) VALUES
(1, '1234567890', 1, '8.00'),
(1, '1234567890', 2, '7.00'),
(1, '5678901234', 1, '6.00'),
(1, '5678901234', 2, '5.00'),
(2, '1234567890', 1, '45.00');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `club`
--
ALTER TABLE `club`
  ADD PRIMARY KEY (`NUM_CLUB`);

--
-- Index pour la table `competition`
--
ALTER TABLE `competition`
  ADD PRIMARY KEY (`NUM_COMPETITION`),
  ADD KEY `fk_competition_NUM_CLUB` (`NUM_CLUB`);

--
-- Index pour la table `entraineur`
--
ALTER TABLE `entraineur`
  ADD PRIMARY KEY (`NUM_ENTRAINEUR`),
  ADD KEY `fk_entraineur_NUM_CLUB` (`NUM_CLUB`);

--
-- Index pour la table `inscription`
--
ALTER TABLE `inscription`
  ADD PRIMARY KEY (`NUM_COMPETITION`,`NUM_LICENCE`),
  ADD KEY `fk_inscription_NUM_LICENCE` (`NUM_LICENCE`);

--
-- Index pour la table `juge`
--
ALTER TABLE `juge`
  ADD PRIMARY KEY (`NUM_COMPETITION`,`NUM_ENTRAINEUR`),
  ADD KEY `fk_entraineur_NUM_ENTRAINEUR` (`NUM_ENTRAINEUR`);

--
-- Index pour la table `membre`
--
ALTER TABLE `membre`
  ADD PRIMARY KEY (`NUM_LICENCE`),
  ADD KEY `fk_membre_NUM_CLUB` (`NUM_CLUB`);

--
-- Index pour la table `note`
--
ALTER TABLE `note`
  ADD PRIMARY KEY (`NUM_COMPETITION`,`NUM_LICENCE`,`NUM_ENTRAINEUR`),
  ADD KEY `fk_licence_NUM_LICENCE` (`NUM_LICENCE`),
  ADD KEY `fk_ntraineure_NUM_ENTRAINEUR` (`NUM_ENTRAINEUR`);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `competition`
--
ALTER TABLE `competition`
  ADD CONSTRAINT `fk_competition_NUM_CLUB` FOREIGN KEY (`NUM_CLUB`) REFERENCES `club` (`NUM_CLUB`);

--
-- Contraintes pour la table `entraineur`
--
ALTER TABLE `entraineur`
  ADD CONSTRAINT `fk_entraineur_NUM_CLUB` FOREIGN KEY (`NUM_CLUB`) REFERENCES `club` (`NUM_CLUB`);

--
-- Contraintes pour la table `inscription`
--
ALTER TABLE `inscription`
  ADD CONSTRAINT `fk_inscription_NUM_COMPETITION` FOREIGN KEY (`NUM_COMPETITION`) REFERENCES `competition` (`NUM_COMPETITION`),
  ADD CONSTRAINT `fk_inscription_NUM_LICENCE` FOREIGN KEY (`NUM_LICENCE`) REFERENCES `membre` (`NUM_LICENCE`);

--
-- Contraintes pour la table `juge`
--
ALTER TABLE `juge`
  ADD CONSTRAINT `fk_competition_NUM_COMPETITION` FOREIGN KEY (`NUM_COMPETITION`) REFERENCES `competition` (`NUM_COMPETITION`),
  ADD CONSTRAINT `fk_entraineur_NUM_ENTRAINEUR` FOREIGN KEY (`NUM_ENTRAINEUR`) REFERENCES `entraineur` (`NUM_ENTRAINEUR`);

--
-- Contraintes pour la table `membre`
--
ALTER TABLE `membre`
  ADD CONSTRAINT `fk_membre_NUM_CLUB` FOREIGN KEY (`NUM_CLUB`) REFERENCES `club` (`NUM_CLUB`);

--
-- Contraintes pour la table `note`
--
ALTER TABLE `note`
  ADD CONSTRAINT `fk_compet_NUM_COMPETITION` FOREIGN KEY (`NUM_COMPETITION`) REFERENCES `competition` (`NUM_COMPETITION`),
  ADD CONSTRAINT `fk_licence_NUM_LICENCE` FOREIGN KEY (`NUM_LICENCE`) REFERENCES `membre` (`NUM_LICENCE`),
  ADD CONSTRAINT `fk_ntraineure_NUM_ENTRAINEUR` FOREIGN KEY (`NUM_ENTRAINEUR`) REFERENCES `entraineur` (`NUM_ENTRAINEUR`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
