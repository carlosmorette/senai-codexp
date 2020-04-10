/*
    Dica de erro: Colocando VARCHAR com comprimento 1, devido a isso deu erro!!
*/

--Criamos o Banco de Dados EX6
CREATE DATABASE EX6;

--Criamos a Tabela Curso e os atributos IdCurso, Tipo e Horário
CREATE TABLE curso(    
    IdCurso INT IDENTITY PRIMARY KEY NOT NULL,
    Tipo VARCHAR,
    Horario INT
);

CREATE TABLE candidato(
    IdCandidato INT IDENTITY PRIMARY KEY NOT NULL,
    Nome VARCHAR,
    Idade INT,
    Telefone INT,
    IdCurso INT FOREIGN KEY REFERENCES curso(IdCurso) --Criamos a Tabela Candidato e chamamos a chave estrangeira da tabela IdCurso
);

--Mostramos a Tabela
SELECT * FROM curso;

SELECT * FROM candidato;

INSERT INTO curso
	(Tipo, Horario)
VALUES ('TI', 3);

INSERT INTO curso
	(Tipo, Horario)
VALUES ('Gastronomia', 2);

--Inserindo Dados na Tabela CANDIDATO
INSERT INTO candidato(Nome,Idade,Telefone,IdCurso)
VALUES('Carlos',17,1232,17);
