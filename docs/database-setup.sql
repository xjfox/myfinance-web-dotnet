CREATE DATABASE myfinance
GO

USE [myfinance]
GO

CREATE TABLE [dbo].[planoconta](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](50) NOT NULL,
	[tipo] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) /ON [PRIMARY]
GO

CREATE TABLE [dbo].[transacao](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[data] [datetime] NOT NULL,
	[valor] [decimal](9, 2) NOT NULL,
	[historico] [varchar](100) NULL,
	[planoconta_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[transacao]  WITH CHECK ADD FOREIGN KEY([planoconta_id])
REFERENCES [dbo].[planoconta] ([id])
GO

insert into planoconta(descricao, tipo) values ('Combustível', 'D')
insert into planoconta(descricao, tipo) values ('Salário', 'R')
insert into planoconta(descricao, tipo) values ('Alimentação', 'D')

insert into planoconta(descricao, tipo) values ('Impostos', 'D')
insert into planoconta(descricao, tipo) values ('Água', 'D')
insert into planoconta(descricao, tipo) values ('Luz', 'D')
insert into planoconta(descricao, tipo) values ('Internet', 'D')
insert into planoconta(descricao, tipo) values ('Cartão de crédito', 'D')

insert into transacao (data, valor, historico, planoconta_id)
values (getdate(), 25, 'Café da manhã', 3)

insert into transacao (data, valor, historico, planoconta_id)
values (getdate(), 38, 'Gasolina moto', 1)

insert into transacao (data, valor, historico, planoconta_id)
values ('20230601', 1000, 'Salário empresa 1', 2)

insert into transacao (data, valor, historico, planoconta_id)
values ('20230610', 350, 'IPTU', 4)

insert into transacao (data, valor, historico, planoconta_id)
values ('20230608', 92, 'Copasa', 5)

insert into transacao (data, valor, historico, planoconta_id)
values ('20230608', 230, 'Cemig', 6)

insert into transacao (data, valor, historico, planoconta_id)
values ('20230608', 119, 'Vero internet', 7)

insert into transacao (data, valor, historico, planoconta_id)
values ('20230615', 378, 'Cartão Nubank', 8)