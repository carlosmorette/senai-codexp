/* Criar banco */
CREATE  DATABASE boletim;

/* Excluir banco */
DROP DATABASE boletim;

/* Excluir tabela */
DROP TABLE candidato;

/* Usar o banco DQL*/
USE boletim;

/* Criar tabela de aluno */
--NOT NULL - Não deixa ficar vazio (Serve para obrigar o dado ser preenchido)
--IDENTITY - Serve para auto incrementar de 1 em 1 
--CHAR - Quando sabe efetivamente a quantidade de digitos

CREATE TABLE aluno (
	IdAluno INT IDENTITY PRIMARY KEY NOT NULL,
	Nome VARCHAR(100) NOT NULL,
	RA VARCHAR(20),
	Idade INT
);

/* Criar tabela de matéria */
CREATE TABLE materia(
	IdMateria INT IDENTITY PRIMARY KEY NOT NULL,
	Materia VARCHAR(50) NOT NULL,
);


-- Lembrar se usar o USE boletim
USE boletim;
/* Criar tabela de trabalho */
CREATE TABLE trabalho(
	IdTrabalho INT IDENTITY PRIMARY KEY NOT NULL,
	Nota DECIMAL,

	-- Chamamos nossas chaves estrangeiras
	IdMateria INT FOREIGN KEY REFERENCES materia(IdMateria),
	IdAluno INT FOREIGN KEY REFERENCES aluno(IdAluno),
);

/* Incluir nova coluna */
ALTER TABLE materia ADD Teste VARCHAR(2);

/* Excluir coluna */
ALTER TABLE materia DROP COLUMN Teste;