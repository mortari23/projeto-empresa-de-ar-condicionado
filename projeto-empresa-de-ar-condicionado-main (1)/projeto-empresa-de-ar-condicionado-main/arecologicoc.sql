CREATE TABLE clientes (
 clienteID int primary key identity,
 nome_cliente nvarchar(100),
 telefone_cliente varchar(15),
 cpf_cliente varchar(20),
 endereco_cliente nvarchar(100),
 gmail_cliente nvarchar (100),
 cidade_cliente nvarchar(100)
 );

CREATE TABLE servico (
 servicoID int primary key identity,
 clienteID int references clientes (clienteID),
 funcionarioID int references funcionario (funcionarioID),
 data_servico date,
 valor_servico decimal(10,2),
 );

CREATE TABLE funcionario (
 funcionarioID int primary key identity,
 nome_funcionario nvarchar(100),
 cpf_funcionario varchar (20),
 telefone_funcionario varchar(15),
 endereco_funcionario nvarchar(100)
 );

 create table contrato (
 contratoID int primary key identity,
 clienteID int references clientes (clienteID),
 descricao_servico nvarchar(200),
 descricao_contrato nvarchar(200),
 valor_contrato decimal(10,2),
 tipo_contrato nvarchar(50)
 );

 alter table clientes add CEP varchar(15), bairro nvarchar(30);
 alter table clientes add Numero_casa varchar(10);
 alter table clientes add complemento_cliente nvarchar(100);

 alter table funcionario add CEP varchar(15), bairro nvarchar(30), numero_funcionario varchar(10);
 alter table funcionario add complemento_funcionario nvarchar(100);

 select c.nome_cliente,f.nome_funcionario, p.descricao_servico as descricao_servico
 from clientes c
 inner join servico p on c.clienteID = p.clienteID
 inner join funcionario f on p.funcionarioID = f.funcionarioID

 alter table clientes drop column CEP,bairro;
 alter table funcionario drop column CEP,bairro;

 alter table clientes add CEP_cliente varchar(15), bairro_cliente varchar(50);
 alter table funcionario add CEP_funcionario varchar(15), bairro_funcionario varchar(50);

  alter table contrato  drop column descricao_servico;

  select * from clientes

  alter table servico add descricao_serviço nvarchar(200);

  alter table contrato add final_contrato date;

  alter table contrato add data_contrato date;

  select c.nome_cliente, f.nome_funcionario
  from clientes c
  inner join funcionario f on c.clienteID = c.clienteID
  group by c.nome_cliente,f.nome_funcionario;

  SELECT 
    s.contratoID,
    c.nome_cliente AS nome_cliente,
    s.data_contrato,
    s.valor_contrato,
    s.descricao_contrato
	s. tipo_contrato
	s.final_contrato
FROM 
    contrato s
INNER JOIN 
    clientes c ON s.clienteID = c.clienteID;

SELECT 
    ct.contratoID,
    c.nome_cliente AS nome_cliente,
    ct.descricao_contrato,
    ct.valor_contrato,
    ct.tipo_contrato,
    ct.final_contrato,
    ct.data_contrato
FROM 
    contrato ct
INNER JOIN 
    clientes c ON ct.clienteID = c.clienteID;

select * from contrato
select * from servico
select * from clientes
select * from funcionario


