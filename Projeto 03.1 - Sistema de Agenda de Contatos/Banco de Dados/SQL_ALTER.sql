ALTER TABLE contato DROP flstatus; 
ALTER TABLE contato ADD flstatus ENUM('I', 'A');

ALTER TABLE contato DROP email;
ALTER TABLE contato ADD email VARCHAR(45);