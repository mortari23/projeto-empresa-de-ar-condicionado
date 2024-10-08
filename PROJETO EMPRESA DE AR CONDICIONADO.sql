CREATE TABLE clientes (
 clienteID int primary key,
 nome_cliente nvarchar(100),
 telefone_cliente varchar(15),
 cpf_cliente varchar(20),
 endereco_cliente nvarchar(100),
 gmail_cliente nvarchar (100),
 cidade_cliente nvarchar(100)
 );

CREATE TABLE servico (
 servicoID int primary key,
 clienteID int references clientes (clienteID),
 funcionarioID int references funcionario (funcionarioID),
 data_servico date,
 valor_servico decimal(10,2),
 descricao_servico nvarchar(200),
 descricao_contrato nvarchar(200),
 valor_contrato decimal(10,2),
 tipo_contrato nvarchar(50)
 );

CREATE TABLE funcionario (
 funcionarioID int primary key,
 nome_funcionario nvarchar(100),
 cpf_funcionario varchar (20),
 telefone_funcionario varchar(15),
 endereco_funcionario nvarchar(100)
 );

 alter table clientes add CEP varchar(15), bairro nvarchar(30);
 alter table clientes add Numero_casa varchar(10);
 alter table clientes add complemento_cliente nvarchar(100);

 alter table funcionario add CEP varchar(15), bairro nvarchar(30), numero_funcionario varchar(10);
 alter table funcionario add complemento_funcionario nvarchar(100);
 