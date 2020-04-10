USE EX8;

--Criamos a tabela Local
CREATE TABLE local(
	IdLocal INT IDENTITY PRIMARY KEY NOT NULL,
	Nome VARCHAR(15),
);

--Criamos a tabela departamento
CREATE TABLE departamento(
	IdDepartamento INT IDENTITY PRIMARY KEY NOT NULL,
	Nome VARCHAR(20),
	IdLocal INT FOREIGN KEY REFERENCES local(IdLocal)
);

--Criamos a tabela empregado
CREATE TABLE empregado(
	IdEmpregado INT IDENTITY PRIMARY KEY NOT NULL,
	Nome VARCHAR(40),
	Idade INT,
	IdDepartamento INT FOREIGN KEY REFERENCES departamento(IdDepartamento)
);

USE EX8;
SELECT * FROM local;
SELECT * FROM departamento;
SELECT * FROM empregado;

--Tabela LOCAL
INSERT INTO local(Nome)
VALUES('Osasco'),
('Praia Grande'),
('São Paulo');

--Tabela DEPARTAMENTO
INSERT INTO departamento(Nome,IdLocal)
VALUES('Recursos Humanos',4);

INSERT INTO departamento(Nome,IdLocal)
VALUES('Qualidade',3);

INSERT INTO departamento(Nome,IdLocal)
VALUES('Produção',1);

--Tabela EMPREGADO
INSERT INTO empregado(Nome,Idade,IdDepartamento)
VALUES('Carlos Roberto',17,1);

