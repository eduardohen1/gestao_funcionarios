create database if not exists gestao_funcionario;

use gestao_funcionario;

create table funcionarios (
	matricula           int           primary key,
    nome                varchar(120)  not null,
    tipo                varchar(20)   not null,
    salario_base        decimal(12,2) not null,
    total_vendas        decimal(12,2)     null,
    percentual_comissao decimal( 5,2)     null,    
    constraint chk_tipo
     check (tipo in ('CLT', 'COMISSIONADO'))
);