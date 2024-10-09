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

 insert into clientes (clienteID,nome_cliente,telefone_cliente,cpf_cliente,endereco_cliente,gmail_cliente,cidade_cliente,CEP,bairro,Numero_casa,complemento_cliente)values
(2, 'Maria Santos','17996075011', '261165223211', 'rua H' ,'maria.santos@example.com', 'sao paulo','150540000','jardim','1016',NULL);

insert into funcionario (funcionarioID,nome_funcionario,cpf_funcionario,telefone_funcionario,endereco_funcionario,CEP,bairro,numero_funcionario,complemento_funcionario)values
(2, 'jubernal','17996075011', '261165223211', 'rua H' ,'150540000','jardim','1016',NULL);


 insert into servico (servicoID, clienteID, funcionarioID,data_servico,valor_servico,descricao_servico,descricao_contrato,valor_contrato,tipo_contrato) values
 (2,2,2,'2023-01-15',250.00,'no servico foi feito a limpeza do ar','contrato é feito a manutençao do ar',1000.00,'contrato mensal');

 select c.nome_cliente,f.nome_funcionario, p.descricao_servico as descricao_servico
 from clientes c
 inner join servico p on c.clienteID = p.clienteID
 inner join funcionario f on p.funcionarioID = f.funcionarioID
 