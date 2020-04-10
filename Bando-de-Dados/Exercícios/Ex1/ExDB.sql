USE ExDB;

--Criamos tabela marca
CREATE TABLE marca(
	IdMarca INT PRIMARY KEY IDENTITY NOT NULL,
	Nome VARCHAR(15)
);

--Criamos tabela cores
CREATE TABLE cores(
	IdCor INT IDENTITY PRIMARY KEY NOT NULL,
	Cor VARCHAR(10)
);

--Criamos tabela tamanho
CREATE TABLE tamanho(
	IdTamanho INT IDENTITY PRIMARY KEY NOT NULL,
	TAM VARCHAR(2)
);

--Criamos tabela camiseta
CREATE TABLE camiseta(
	IdCamiseta INT IDENTITY PRIMARY KEY NOT NULL,
	IdMarca INT FOREIGN KEY REFERENCES marca(IdMarca),
	IdCor INT FOREIGN KEY REFERENCES cores(IdCor),
	IdTamanho INT FOREIGN KEY REFERENCES tamanho(IdTamanho)
);

--IMPORTANTE: Usar o banco de dados para as alterações serem feitas nele
USE ExDB;

--Exibimos os resultados
SELECT * FROM marca;
SELECT * FROM cores;
SELECT * FROM tamanho;
SELECT * FROM camiseta;


--Inserimos dados dentro da tabela CORES
INSERT INTO cores(Cor)
VALUES('Amarelo');

INSERT INTO cores(Cor)
VALUES('Verde');

INSERT INTO cores(Cor)
VALUES('Roxo');

INSERT INTO cores(Cor)
VALUES('Azul');

--Inserimos dados dentro da tabela TAMANHO
INSERT INTO tamanho(TAM)
VALUES('P');

INSERT INTO tamanho(TAM)
VALUES('M');

INSERT INTO tamanho(TAM)
VALUES('G');

INSERT INTO tamanho(TAM)
VALUES('GG');

-- Inserimos dados dentro da tabela MARCA
INSERT INTO marca(Nome)
VALUES('Nike');

INSERT INTO marca(Nome)
VALUES('Puma');

INSERT INTO marca(Nome)
VALUES('Adidas');

INSERT INTO marca(Nome)
VALUES('Reebok');

-- Inserimos dados dentro da tabela Camiseta;
-- Puma, Azul, G;
INSERT INTO camiseta(IdMarca,IdCor,IdTamanho)
VALUES(2,4,3);

-- Adidas, Verde, P;
INSERT INTO camiseta(IdMarca,IdCor,IdTamanho)
VALUES(3,2,1);

-- Nike, Roxo, GG;
INSERT INTO camiseta(IdMarca,IdCor,IdTamanho)
VALUES(1,3,4);

-- Reebok, Amarelo, 2;
INSERT INTO camiseta(IdMarca,IdCor,IdTamanho)
VALUES(4,1,2);

--Aqui mostramos os valores dos ID's

/*
	Dentro do SELECT colocamos as chaves estrangeiras que serão mostradas dentro do INNER JOIN, assim colocando a ENTIDADE E O ATRIBUTO DESEJADO
	No FROM colocamos a tabela que essas informações serão mostradas
	No INNER JOIN colocando novamente a tabela que queremos mostrar as informações
	NA SINTAXE FICA: INNER JOIN 'entidade que tratada' ON 'entidade.IddeReferenciaDaTabela' = tabelaquemostrara.IdReferenciaDaTabela
*/
SELECT 
	marca.Nome, --Mostrar atributo Nome da tabela marca (marca.Nome)
	cores.Cor,
	tamanho.TAM
FROM camiseta -- Entidade que tem os valores das outros tabelas (camiseta)
	INNER JOIN marca ON marca.IdMarca = camiseta.IdMarca 
	-- Importante lembrar que depois do sinal de IGUAL nós falamos qual a tabela que tem os valores e depois referenciamos os ID
	INNER JOIN cores ON cores.IdCor = camiseta.IdCor
	INNER JOIN tamanho ON tamanho.IdTamanho = camiseta.IdTamanho;
