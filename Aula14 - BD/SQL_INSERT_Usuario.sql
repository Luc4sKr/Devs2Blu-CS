INSERT INTO usuario(id_pessoa,
					login,
                    senha,
                    status)
VALUES (1, 'lucaskreuch', 'lucas123', 'A'),
	   (2, 'mariaclara', 'maria123', 'A'),
       (3, 'josemar', 'josemar123', 'A'),
       (4, 'rita', 'rita123', 'A');
       
ALTER TABLE usuario MODIFY id INT NOT NULL AUTO_INCREMENT;