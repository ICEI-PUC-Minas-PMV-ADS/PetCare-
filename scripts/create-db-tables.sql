CREATE TABLE `usuarios` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `senha` varchar(45) NOT NULL,
  `nascimento` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb3;

CREATE TABLE `pets` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `idDono` int unsigned NOT NULL,
  `nome` varchar(450) NOT NULL,
  `especie` varchar(100) NOT NULL,
  `raca` varchar(100) NOT NULL,
  `nascimento` varchar(15) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idDono_idx` (`idDono`),
  CONSTRAINT `idDono` FOREIGN KEY (`idDono`) REFERENCES `usuarios` (`id`) ON DELETE CASCADE ON UPDATE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

CREATE TABLE `registros` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `idPet` int unsigned NOT NULL,
  `descricao` varchar(450) NOT NULL,
  `tipoRegistro` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idPet_idx` (`idPet`),
  CONSTRAINT `idPet` FOREIGN KEY (`idPet`) REFERENCES `pets` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

CREATE TABLE `pesos` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `idRegistro` int unsigned NOT NULL,
  `observacao` varchar(150) NOT NULL,
  `peso` double NOT NULL,
  `dataPesagem` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idRegistro_idx` (`idRegistro`),
  CONSTRAINT `idRegistro` FOREIGN KEY (`idRegistro`) REFERENCES `registros` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;