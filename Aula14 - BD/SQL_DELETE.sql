-- INSERT de teste
INSERT INTO pessoa (nome,
                    datanascimento,
                    idade,
                    status)
VALUES ('Josefino', '2005-03-22', 17, 1);

/*DELETE*/

DELETE FROM pessoa
WHERE id IN (5, 6);

-- Apaga o último registro ---------------------------------------------
DELETE FROM pessoa
WHERE max(id); -- Continua na próxima aula
------------------------------------------------------------------------




-- WHERE nome LIKE 'Josefino';
-- J% -> Deleta tudo que começa com 'J'
-- %sefi% -> Deleta tudo que tem 'sefi' na string