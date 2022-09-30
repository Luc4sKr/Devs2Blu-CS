SELECT id,
	   nome,
       datanascimento,
       idade,
       status
FROM pessoa;

-- ORDER BY idade ASC; 
-- ORDENA AS IDADES DE FORMA CRESCENTE
-- ORDER BY idade DESC; 
-- ORDENA AS IDADES DE FORMA DECRESCENTE
                       
SELECT * FROM pessoa;
				
SELECT *
FROM pessoa AS p
JOIN usuario AS u
ON p.id = u.id_pessoa;

SELECT p.id AS id_pessoa,
	   u.id as id_usuario,
	   p.nome,
       u.login,
       u.senha,
	   p.datanascimento AS nascimento,
       p.idade,
       p.status AS situacao_pessoa,
       u.status AS status_usuario
FROM pessoa AS p
JOIN usuario AS u
ON p.id = u.id_pessoa;

SELECT * 
FROM pessoa
WHERE datanascimento < '1998-01-01';
