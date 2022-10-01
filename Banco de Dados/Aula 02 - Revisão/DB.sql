-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema filmes
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema filmes
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `filmes` DEFAULT CHARACTER SET utf8 ;
USE `filmes` ;

-- -----------------------------------------------------
-- Table `filmes`.`genero`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `filmes`.`genero` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `flstatus` VARCHAR(1) NULL DEFAULT 'A' COMMENT 'A - Ativo; I - Inativo;',
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `filmes`.`classificacao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `filmes`.`classificacao` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `label` VARCHAR(45) NULL,
  `numlabel` INT NULL,
  `observacao` VARCHAR(255) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `filmes`.`filme`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `filmes`.`filme` (
  `id_filme` INT NOT NULL AUTO_INCREMENT,
  `titulo` VARCHAR(50) NOT NULL,
  `duracao` INT NOT NULL,
  `flstatus` VARCHAR(1) NULL DEFAULT 'A' COMMENT 'A - Ativo; I - Inativo;',
  `id_genero` INT NOT NULL,
  `id_classificacao` INT NOT NULL,
  PRIMARY KEY (`id_filme`),
  INDEX `fk_filme_genero_idx` (`id_genero`),
  INDEX `fk_filme_classificacao1_idx` (`id_classificacao`),
  CONSTRAINT `fk_filme_genero`
    FOREIGN KEY (`id_genero`)
    REFERENCES `filmes`.`genero` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_filme_classificacao1`
    FOREIGN KEY (`id_classificacao`)
    REFERENCES `filmes`.`classificacao` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
