create table clientes (

codigo int not null,
nome varchar (100),
CPF numeric (11) not null,
RG numeric (11) not null
);

create table estoque(

codigo int not null primary key,
descricao varchar (100),
valor numeric (4,2),
data_entrega date,
data_validade date,
nota_fiscal numeric (30)
);

create table fornecedores(

codigo int not null primary key,
nome_fornecedor varchar (100),
telefone numeric (11),
cnpj numeric (20)
);

create table receita(
codigo int not null primary key,
entrada_caixa numeric (4,4),
saída_caixa numeric (4,4),
lucros numeric (4,4)
);



