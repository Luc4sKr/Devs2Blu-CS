SELECT *
FROM pessoa;

SELECT * 
FROM pessoa AS p
JOIN endereco AS e
	ON p.id = e.id_pessoa;