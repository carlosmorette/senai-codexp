/* Mostrar dados */
SELECT * FROM aluno;

/* Asterisco representa mostrar tudo (ALL) */
SELECT * FROM materia;

/* Mostrar dados específicos de um aluno*/
SELECT * FROM aluno WHERE Idade = 2;

/* Mostrar dados em "busca" com LIKE*/ -- % entre as aspas
SELECT * FROM aluno WHERE Nome LIKE '%Bruna%'; -- Porcetangem serve para ignorar o que vem antes ou que vem depois, mas mostrar a palavra 'Bruna'

/* Ordenar por nome do aluno de forma ascendente */
SELECT * FROM aluno ORDER BY Nome ASC;

/* Ordenar por nome do aluno de forma decrescente */
SELECT * FROM aluno ORDER BY Nome DESC;

/* Juntamos as 3 tabelas usando INNER JOIN */
SELECT * FROM trabalho
	INNER JOIN materia ON materia.IdMateria = trabalho.IdMateria
	INNER JOIN aluno ON aluno.IdAluno = trabalho.IdAluno;
    
/* Juntamos as 3 tabelas usando INNER JOIN */
--Deixamos somente os dados que nos interessam no momento

SELECT 
	aluno.Nome,
	aluno.RA,
	aluno.Idade,
	materia.Materia,
	trabalho.Nota
FROM trabalho
	INNER JOIN materia ON materia.IdMateria = trabalho.IdMateria
	INNER JOIN aluno ON aluno.IdAluno = trabalho.IdAluno;

/* Utilizamos função nativa COUNT para retornar o número de registros na minha tabela */

/* Usamos o Alias "AS" para nomear a coluna */
SELECT COUNT(*) AS total_registros FROM ALUNO;

/* A idade máxima dos alunos */
SELECT MAX (Idade) AS idade_maxima FROM aluno;

/* Pegamos a idade mínima dos alunos */
SELECT MIN (Idade) AS idade_minima FROM aluno;


/* Pegamos a média de idade dos alunos */
SELECT AVG (Idade) AS media_de_idade FROM aluno;


/* Somamos as idades */
SELECT SUM (Idade) AS soma_de_idades FROM aluno;

/* Juntamos todas as funções em uma única consulta */
SELECT
	COUNT(*) AS total_registros,
	MAX(Idade) AS idade_maxima,
	MIN(Idade) AS idade_minima,
	AVG(Idade) AS media_de_idade,
	SUM(Idade) AS soma_idade
FROM aluno;


/* Pegamos parte de uma String */
SELECT SUBSTRING (Nome,0,3) AS cortado FROM aluno;

/* UPPER */
-- Deixar tudo em maiúsculo
SELECT UPPER(Nome) AS Nome FROM aluno;

/* LOWER */
-- Deixa tudo em minúsculo
SELECT LOWER(Nome) AS Nome FROM aluno;
