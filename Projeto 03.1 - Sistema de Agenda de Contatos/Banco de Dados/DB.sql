-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema sistemaagendacontatos
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema sistemaagendacontatos
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `sistemaagendacontatos` DEFAULT CHARACTER SET utf8 ;
USE `sistemaagendacontatos` ;

-- -----------------------------------------------------
-- Table `sistemaagendacontatos`.`contato`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sistemaagendacontatos`.`contato` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `email` VARCHAR(25) NOT NULL,
  `numero_tel` VARCHAR(20) NOT NULL COMMENT '(xx) xx xxxxx-xxxx',
  `flstatus` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sistemaagendacontatos`.`estado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sistemaagendacontatos`.`estado` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `uf` VARCHAR(2) NOT NULL,
  `descricao` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sistemaagendacontatos`.`endereco`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sistemaagendacontatos`.`endereco` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `cep` VARCHAR(10) NOT NULL COMMENT 'xx.xxx-xxx',
  `uf` VARCHAR(2) NOT NULL,
  `cidade` VARCHAR(45) NOT NULL,
  `bairro` VARCHAR(45) NOT NULL,
  `rua` VARCHAR(45) NOT NULL,
  `numero` INT NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sistemaagendacontatos`.`compromisso`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sistemaagendacontatos`.`compromisso` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `id_contato` INT NULL,
  `id_endereco` INT NOT NULL,
  `titulo` VARCHAR(45) NOT NULL,
  `descricao` VARCHAR(255) NULL,
  `dia_semana` VARCHAR(3) NULL,
  `data_inicio` DATETIME NOT NULL,
  `data_fim` DATETIME NULL,
  `flstatus` ENUM('I', 'A', 'C', 'R') NOT NULL COMMENT 'I - Inativo\nA - Ativo\nC - Concluído\nR - Remarcado',
  PRIMARY KEY (`id`),
  INDEX `fk_compromisso_endereco_idx` (`id_endereco` ASC) VISIBLE,
  INDEX `fk_compromisso_contato1_idx` (`id_contato` ASC) VISIBLE,
  CONSTRAINT `fk_compromisso_endereco`
    FOREIGN KEY (`id_endereco`)
    REFERENCES `sistemaagendacontatos`.`endereco` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_compromisso_contato1`
    FOREIGN KEY (`id_contato`)
    REFERENCES `sistemaagendacontatos`.`contato` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
