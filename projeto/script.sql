CREATE TABLE nota_fiscal(
	id_nota INT GENERATED ALWAYS AS IDENTITY,
    emissor VARCHAR(150),
    data_ DATE
);

CREATE TABLE item(
    id_item INT GENERATED ALWAYS AS IDENTITY,
    id_nota INT,
    produto VARCHAR(255),
    valor DECIMAL(10,2),
    tamanho DECIMAL(10,2)
);

ALTER TABLE nota_fiscal
ADD PRIMARY KEY(id_nota);

ALTER TABLE item
ADD FOREIGN KEY (id_nota) REFERENCES nota_fiscal;

ALTER TABLE item
ADD CONSTRAINT chave_composta PRIMARY KEY (id_item, Id_nota);