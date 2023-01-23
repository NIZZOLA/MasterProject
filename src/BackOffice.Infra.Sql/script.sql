IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Clientes] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NOT NULL,
    [Cpf] nvarchar(max) NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    [Celular] nvarchar(max) NOT NULL,
    [CreateDate] datetime2 NULL,
    [UpdateDate] datetime2 NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Produtos] (
    [Id] int NOT NULL IDENTITY,
    [Descricao] nvarchar(max) NOT NULL,
    [Valor] decimal(18,2) NOT NULL,
    [CreateDate] datetime2 NULL,
    [UpdateDate] datetime2 NULL,
    CONSTRAINT [PK_Produtos] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Pedidos] (
    [Id] int NOT NULL IDENTITY,
    [RequestId] uniqueidentifier NULL,
    [DataDaCompra] datetime2 NOT NULL,
    [Status] int NOT NULL,
    [ClienteId] int NOT NULL,
    [CreateDate] datetime2 NULL,
    [UpdateDate] datetime2 NULL,
    CONSTRAINT [PK_Pedidos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Pedidos_Clientes_ClienteId] FOREIGN KEY ([ClienteId]) REFERENCES [Clientes] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Pagamentos] (
    [Id] int NOT NULL IDENTITY,
    [PedidoId] int NOT NULL,
    [Valor] decimal(18,2) NOT NULL,
    [Vencimento] datetime2 NOT NULL,
    [Pagamento] datetime2 NULL,
    [ValorPago] decimal(18,2) NULL,
    [CreateDate] datetime2 NULL,
    [UpdateDate] datetime2 NULL,
    CONSTRAINT [PK_Pagamentos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Pagamentos_Pedidos_PedidoId] FOREIGN KEY ([PedidoId]) REFERENCES [Pedidos] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [PedidoItens] (
    [Id] int NOT NULL IDENTITY,
    [PedidoId] int NOT NULL,
    [ProdutoId] int NOT NULL,
    [Quantidade] decimal(18,2) NOT NULL,
    [Valor] decimal(18,2) NOT NULL,
    [CreateDate] datetime2 NULL,
    [UpdateDate] datetime2 NULL,
    CONSTRAINT [PK_PedidoItens] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_PedidoItens_Pedidos_PedidoId] FOREIGN KEY ([PedidoId]) REFERENCES [Pedidos] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_PedidoItens_Produtos_ProdutoId] FOREIGN KEY ([ProdutoId]) REFERENCES [Produtos] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Pagamentos_PedidoId] ON [Pagamentos] ([PedidoId]);
GO

CREATE INDEX [IX_PedidoItens_PedidoId] ON [PedidoItens] ([PedidoId]);
GO

CREATE INDEX [IX_PedidoItens_ProdutoId] ON [PedidoItens] ([ProdutoId]);
GO

CREATE INDEX [IX_Pedidos_ClienteId] ON [Pedidos] ([ClienteId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230123154406_Initial', N'7.0.0');
GO

COMMIT;
GO

