select * from dbo.Servicos;
SELECT * FROM Usuario

UPDATE dbo.Usuario SET Nome_Usuario = 'João' WHERE ID_Usuario = 2

SELECT Usuario.Nome_Usuario,
       Servicos.Descricao,
	   Servicos.Status
FROM dbo.Servicos WITH (NOLOCK)
     INNER JOIN dbo.Usuario WITH (NOLOCK)
	 ON Usuario.ID_Usuario = Usuario.ID_Usuario
WHERE Usuario.ID_Usuario = 2