ALTER TABLE contato DROP flstatus; 
ALTER TABLE contato ADD flstatus ENUM('I', 'A');