-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema sistemacadastro
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema sistemacadastro
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `sistemacadastro` DEFAULT CHARACTER SET utf8 ;
USE `sistemacadastro` ;

-- -----------------------------------------------------
-- Table `sistemacadastro`.`pessoa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sistemacadastro`.`pessoa` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(50) NOT NULL,
  `cgccpf` VARCHAR(25) NOT NULL,
  `tipopessoa` ENUM('PF', 'PJ') NOT NULL,
  `flstatus` ENUM('E', 'A', 'I') NOT NULL DEFAULT 'A' COMMENT 'E - Excluído  (0)\nA - Ativo      (1)\nI - Inativo    (2)',
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sistemacadastro`.`endereco`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sistemacadastro`.`endereco` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `id_pessoa` INT NOT NULL,
  `CEP` VARCHAR(15) NULL,
  `rua` VARCHAR(45) NOT NULL,
  `numero` INT NOT NULL,
  `bairro` VARCHAR(45) NOT NULL,
  `cidade` VARCHAR(45) NOT NULL,
  `uf` VARCHAR(2) NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_endereco_pessoa_idx` (`id_pessoa`),
  CONSTRAINT `fk_endereco_pessoa`
    FOREIGN KEY (`id_pessoa`)
    REFERENCES `sistemacadastro`.`pessoa` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sistemacadastro`.`convenio`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sistemacadastro`.`convenio` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `flstatus` ENUM('I', 'A') NOT NULL DEFAULT 'A' COMMENT 'I - Inativo\nA - Ativo',
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sistemacadastro`.`paciente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sistemacadastro`.`paciente` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `id_pessoa` INT NOT NULL,
  `convenio_id` INT NOT NULL,
  `numero_prontuario` INT NOT NULL,
  `paciente_risco` VARCHAR(5) NULL,
  `flstatus` ENUM('E', 'A') NOT NULL DEFAULT 'A' COMMENT 'E - Excluído\nA - Ativo',
  `flobito` TINYINT NOT NULL DEFAULT 0 COMMENT '0 - Não\n1 - Sim',
  PRIMARY KEY (`id`),
  INDEX `index_nrprontuario`,
  INDEX `fk_paciente_pessoa1_idx` (`id_pessoa`),
  INDEX `fk_paciente_convenio1_idx` (`convenio_id`),
  CONSTRAINT `fk_paciente_pessoa1`
    FOREIGN KEY (`id_pessoa`)
    REFERENCES `sistemacadastro`.`pessoa` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_paciente_convenio1`
    FOREIGN KEY (`convenio_id`)
    REFERENCES `sistemacadastro`.`convenio` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Data for table `sistemacadastro`.`pessoa`
-- -----------------------------------------------------
START TRANSACTION;
USE `sistemacadastro`;
INSERT INTO `sistemacadastro`.`pessoa` (`id`, `nome`, `cgccpf`, `tipopessoa`, `flstatus`) VALUES (1, 'Lucas Kreuch', '107.577.123-90', 'PF', 'A');

COMMIT;


-- -----------------------------------------------------
-- Data for table `sistemacadastro`.`convenio`
-- -----------------------------------------------------
START TRANSACTION;
USE `sistemacadastro`;
INSERT INTO `sistemacadastro`.`convenio` (`id`, `nome`, `flstatus`) VALUES (1, 'Bradesco', 'A');
INSERT INTO `sistemacadastro`.`convenio` (`id`, `nome`, `flstatus`) VALUES (2, 'Unimed', 'A');
INSERT INTO `sistemacadastro`.`convenio` (`id`, `nome`, `flstatus`) VALUES (3, 'Amil', 'A');
INSERT INTO `sistemacadastro`.`convenio` (`id`, `nome`, `flstatus`) VALUES (4, 'Servmed', 'A');
INSERT INTO `sistemacadastro`.`convenio` (`id`, `nome`, `flstatus`) VALUES (5, 'Boa vida', 'A');
INSERT INTO `sistemacadastro`.`convenio` (`id`, `nome`, `flstatus`) VALUES (6, 'Salvamed', 'A');
INSERT INTO `sistemacadastro`.`convenio` (`id`, `nome`, `flstatus`) VALUES (7, 'Pladista', 'A');
INSERT INTO `sistemacadastro`.`convenio` (`id`, `nome`, `flstatus`) VALUES (8, 'Clinipam', 'A');

COMMIT;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
