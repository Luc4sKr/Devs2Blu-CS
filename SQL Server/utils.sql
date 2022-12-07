USE [DATABASE]
GO

-- INSERT 
INSERT INTO [dbo].[Tabela]
			([id],
			[nome],
			[idade])
	VALUES
		  (1,
		  'Lucas',
		  17)
GO

-- ALTER
ALTER TABLE [dbo].[Tabela]
	ADD [nacionalidade] varchar(50)
GO

-- UPDATE
UPDATE [dbo].[Tabela]
	SET nacionalidade = 'Brasileiro'
WHERE nacionalidade IS NULL;
GO

-- SELECT
SELECT * 
	FROM [dbo].[Tabela]
GO