UPDATE pessoa
	SET datanascimento = '1998-02-23',
		idade = 24
WHERE id IN (1, 2, 3); -- Altera onde os ID's são 1, 2, 3

UPDATE pessoa
	SET datanascimento = '1995-8-15',
		idade = 27
WHERE id IN (4);

