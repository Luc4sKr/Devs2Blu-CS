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
-- Table `sistemaagendacontatos`.`estado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sistemaagendacontatos`.`estado` (
  `id_estado` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(2) NOT NULL,
  PRIMARY KEY (`id_estado`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sistemaagendacontatos`.`contato`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sistemaagendacontatos`.`contato` (
  `id_contato` INT NOT NULL AUTO_INCREMENT,
  `id_estado` INT NOT NULL,
  `nome` VARCHAR(45) NOT NULL,
  `email` VARCHAR(25) NOT NULL,
  `numero_tel` VARCHAR(20) NOT NULL COMMENT '(xx) xx xxxxx-xxxx',
  PRIMARY KEY (`id_contato`),
  INDEX `fk_contato_estado_idx` (`id_estado` ASC) VISIBLE,
  CONSTRAINT `fk_contato_estado`
    FOREIGN KEY (`id_estado`)
    REFERENCES `sistemaagendacontatos`.`estado` (`id_estado`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sistemaagendacontatos`.`compromisso`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sistemaagendacontatos`.`compromisso` (
  `id_compromisso` INT NOT NULL AUTO_INCREMENT,
  `id_contato` INT NOT NULL,
  `local` VARCHAR(45) NOT NULL,
  `data` DATE NOT NULL,
  `dia_semana` ENUM('dom', 'seg', 'ter', 'qua', 'qui', 'sex', 'sab') NOT NULL,
  `flstatus` ENUM('A', 'I') NOT NULL COMMENT 'A - Ativo\nI - Inativo',
  PRIMARY KEY (`id_compromisso`),
  INDEX `fk_compromisso_contato1_idx` (`id_contato` ASC) VISIBLE,
  CONSTRAINT `fk_compromisso_contato1`
    FOREIGN KEY (`id_contato`)
    REFERENCES `sistemaagendacontatos`.`contato` (`id_contato`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
