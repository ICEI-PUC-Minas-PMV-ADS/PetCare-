CREATE DATABASE `heroku_cd40deb8c8e7a90` /*!40100 DEFAULT CHARACTER SET utf8 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE heroku_cd40deb8c8e7a90;
CREATE TABLE `usuarios` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `nome` varchar(450) NOT NULL,
  `email` varchar(450) NOT NULL,
  `senha` varchar(45) NOT NULL,
  `nascimento` varchar(45) NOT NULL,
  `imagem` longtext,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb3;
CREATE TABLE `pets` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `idDono` int unsigned NOT NULL,
  `nome` varchar(450) NOT NULL,
  `especie` varchar(100) NOT NULL,
  `raca` varchar(100) NOT NULL,
  `nascimento` varchar(15) NOT NULL,
  `imagem` longtext,
  PRIMARY KEY (`id`),
  KEY `idDono_idx` (`idDono`),
  CONSTRAINT `idDono` FOREIGN KEY (`idDono`) REFERENCES `usuarios` (`id`) ON DELETE CASCADE ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb3;
CREATE TABLE `registros` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idPet` int(10) unsigned NOT NULL,
  `idDono` int(10) unsigned NOT NULL,
  `descricao` varchar(450) NOT NULL,
  `tipoRegistro` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idPet_idx` (`idPet`),
  CONSTRAINT `idPet` FOREIGN KEY (`idPet`) REFERENCES `pets` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
CREATE TABLE `pesos` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `idRegistro` int unsigned NOT NULL,
  `observacao` varchar(150),
  `peso` double NOT NULL,
  `dataPesagem` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idRegistro_idx` (`idRegistro`),
  CONSTRAINT `idRegistro` FOREIGN KEY (`idRegistro`) REFERENCES `registros` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb3;

CREATE TABLE `medicamentos` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `idRegistro` int unsigned NOT NULL,
  `nome` varchar(45) NOT NULL,
  `aplicacao` varchar(45) NOT NULL,
  `reaplicacao` varchar(45) DEFAULT NULL,
  `dosagem` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idRegistro_Medicamento_idx` (`idRegistro`),
  CONSTRAINT `idRegistro_Medicamento` FOREIGN KEY (`idRegistro`) REFERENCES `registros` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb3;

CREATE TABLE `vacinas` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `idRegistro` int unsigned NOT NULL,
  `nome` varchar(45) NOT NULL,
  `aplicacao` varchar(45) NOT NULL,
  `reaplicacao` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idRegistro_Vacina_idx` (`idRegistro`),
  CONSTRAINT `idRegistro_Vacinas` FOREIGN KEY (`idRegistro`) REFERENCES `registros` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb3;

