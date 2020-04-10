CREATE DATABASE EX7;

CREATE TABLE aluno(
    IdAluno INT PRIMARY KEY NOT NULL,
    Nome VARCHAR(30),
    CPF INT
);

CREATE TABLE turma(
    IdTurma INT PRIMARY KEY NOT NULL,
    Horario INT,
    Sala INT
);

INSERT INTO turma(IdTurma,Horario,Turma)
VALUES(1,123123,13);

--Inserimos dados na Tabela Aluno
INSERT INTO aluno
	(IdAluno,Nome,CPF)
VALUES(2,'Carlos',1231231);


-- Criando a Tabela Cadastro com duas chaves estrangeiras
CREATE TABLE cadastro(
	IdCadastro INT PRIMARY KEY NOT NULL,
	IdAluno INT FOREIGN KEY REFERENCES aluno(IdAluno),
	IdTurma INT FOREIGN KEY REFERENCES turma(IdTurma),
	Situacao VARCHAR(3)
);

--Exibimos as 3 Entidades
SELECT * FROM aluno;
SELECT * FROM turma;
SELECT * FROM cadastro;

--Inserimos Dados na Entidade Cadastro
INSERT INTO cadastro(IdCadastro,IdAluno,IdTurma, Situacao)
VALUES(1,2,5,'OK');

--Inserimos Dados na Entidade Cadastro
INSERT INTO cadastro(IdCadastro,IdAluno,IdTurma, Situacao)
VALUES(2,5,1,'NOT');