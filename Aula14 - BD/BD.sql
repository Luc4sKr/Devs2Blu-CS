-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema acessos
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema acessos
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `acessos` DEFAULT CHARACTER SET utf8 ;
USE `acessos` ;

-- -----------------------------------------------------
-- Table `acessos`.`pessoa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `acessos`.`pessoa` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `datanascimento` DATE NULL,
  `idade` INT NULL,
  `status` TINYINT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `acessos`.`usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `acessos`.`usuario` (
  `id` INT NOT NULL,
  `id_pessoa` INT NOT NULL,
  `login` VARCHAR(45) NOT NULL,
  `senha` VARCHAR(255) NOT NULL,
  `status` VARCHAR(1) NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_usuario_pessoa_idx` (`id_pessoa`),
  CONSTRAINT `fk_usuario_pessoa`
    FOREIGN KEY (`id_pessoa`)
    REFERENCES `acessos`.`pessoa` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
