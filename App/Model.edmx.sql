
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/13/2019 01:16:33
-- Generated from EDMX file: D:\bookids\App\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [database];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClienteFilho]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Filho] DROP CONSTRAINT [FK_ClienteFilho];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Compras] DROP CONSTRAINT [FK_ClienteCompra];
GO
IF OBJECT_ID(N'[dbo].[FK_ProdutoDetalheCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalhesCompras] DROP CONSTRAINT [FK_ProdutoDetalheCompra];
GO
IF OBJECT_ID(N'[dbo].[FK_FilhoInscrição]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Inscrição] DROP CONSTRAINT [FK_FilhoInscrição];
GO
IF OBJECT_ID(N'[dbo].[FK_AnimadorColaboração]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Colaboração] DROP CONSTRAINT [FK_AnimadorColaboração];
GO
IF OBJECT_ID(N'[dbo].[FK_EventoColaboração]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Colaboração] DROP CONSTRAINT [FK_EventoColaboração];
GO
IF OBJECT_ID(N'[dbo].[FK_EventoInscrição]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Inscrição] DROP CONSTRAINT [FK_EventoInscrição];
GO
IF OBJECT_ID(N'[dbo].[FK_EscolaFilho]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Filho] DROP CONSTRAINT [FK_EscolaFilho];
GO
IF OBJECT_ID(N'[dbo].[FK_EscolaParticipação]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Participação] DROP CONSTRAINT [FK_EscolaParticipação];
GO
IF OBJECT_ID(N'[dbo].[FK_EventoParticipação]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Participação] DROP CONSTRAINT [FK_EventoParticipação];
GO
IF OBJECT_ID(N'[dbo].[FK_CompraDetalheCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalhesCompras] DROP CONSTRAINT [FK_CompraDetalheCompra];
GO
IF OBJECT_ID(N'[dbo].[FK_TipoProdutoProduto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Produtoes] DROP CONSTRAINT [FK_TipoProdutoProduto];
GO
IF OBJECT_ID(N'[dbo].[FK_Cliente_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Cliente] DROP CONSTRAINT [FK_Cliente_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Filho_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Filho] DROP CONSTRAINT [FK_Filho_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Animador_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Animador] DROP CONSTRAINT [FK_Animador_inherits_Pessoa];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Pessoas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas];
GO
IF OBJECT_ID(N'[dbo].[Compras]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Compras];
GO
IF OBJECT_ID(N'[dbo].[DetalhesCompras]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetalhesCompras];
GO
IF OBJECT_ID(N'[dbo].[Produtoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Produtoes];
GO
IF OBJECT_ID(N'[dbo].[Inscrição]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Inscrição];
GO
IF OBJECT_ID(N'[dbo].[Colaboração]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Colaboração];
GO
IF OBJECT_ID(N'[dbo].[Eventoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Eventoes];
GO
IF OBJECT_ID(N'[dbo].[Escolas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Escolas];
GO
IF OBJECT_ID(N'[dbo].[Participação]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Participação];
GO
IF OBJECT_ID(N'[dbo].[TipoProdutos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoProdutos];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Pessoas_Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas_Cliente];
GO
IF OBJECT_ID(N'[dbo].[Pessoas_Filho]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas_Filho];
GO
IF OBJECT_ID(N'[dbo].[Pessoas_Animador]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas_Animador];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Pessoas'
CREATE TABLE [dbo].[Pessoas] (
    [IdPessoa] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL,
    [CodPostal] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Telemovel] nvarchar(max)  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Compras'
CREATE TABLE [dbo].[Compras] (
    [NrCompra] int IDENTITY(1,1) NOT NULL,
    [ClienteIdPessoa] int  NOT NULL,
    [Data] datetime  NOT NULL,
    [UtilizouCartão] bit  NOT NULL
);
GO

-- Creating table 'DetalhesCompras'
CREATE TABLE [dbo].[DetalhesCompras] (
    [Quantidade] int  NOT NULL,
    [ProdutoCodProduto] int  NOT NULL,
    [CompraNrCompra1] int  NOT NULL
);
GO

-- Creating table 'Produtoes'
CREATE TABLE [dbo].[Produtoes] (
    [CodProduto] int IDENTITY(1,1) NOT NULL,
    [Designação] nvarchar(max)  NOT NULL,
    [Preço] float  NOT NULL,
    [StockExistente] int  NOT NULL,
    [TipoProdutoCodTipoProduto] int  NOT NULL
);
GO

-- Creating table 'Inscrição'
CREATE TABLE [dbo].[Inscrição] (
    [Confirmada] bit  NOT NULL,
    [FilhoIdPessoa] int  NOT NULL,
    [EventoNrEvento] int  NOT NULL
);
GO

-- Creating table 'Colaboração'
CREATE TABLE [dbo].[Colaboração] (
    [AnimadorIdPessoa] int  NOT NULL,
    [EventoNrEvento] int  NOT NULL
);
GO

-- Creating table 'Eventoes'
CREATE TABLE [dbo].[Eventoes] (
    [NrEvento] int IDENTITY(1,1) NOT NULL,
    [Descrição] nvarchar(max)  NOT NULL,
    [Local] nvarchar(max)  NOT NULL,
    [DataHora] datetime  NOT NULL,
    [LimiteParticipações] int  NOT NULL,
    [IdadeInferior] int  NOT NULL,
    [IdadeSuperior] int  NOT NULL,
    [TipoEvento] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Escolas'
CREATE TABLE [dbo].[Escolas] (
    [IdEscola] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL,
    [CodPostal] nvarchar(max)  NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Participação'
CREATE TABLE [dbo].[Participação] (
    [EscolaIdEscola] int  NOT NULL,
    [EventoNrEvento] int  NOT NULL
);
GO

-- Creating table 'TipoProdutos'
CREATE TABLE [dbo].[TipoProdutos] (
    [CodTipoProduto] int IDENTITY(1,1) NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Pass] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Pessoas_Cliente'
CREATE TABLE [dbo].[Pessoas_Cliente] (
    [ValorOferta] float  NOT NULL,
    [NrCartao] int  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- Creating table 'Pessoas_Filho'
CREATE TABLE [dbo].[Pessoas_Filho] (
    [Sexo] nvarchar(max)  NOT NULL,
    [DataNascimento] nvarchar(max)  NOT NULL,
    [ClienteIdPessoa] int  NOT NULL,
    [EscolaIdEscola] int  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- Creating table 'Pessoas_Animador'
CREATE TABLE [dbo].[Pessoas_Animador] (
    [Especialidade] nvarchar(max)  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdPessoa] in table 'Pessoas'
ALTER TABLE [dbo].[Pessoas]
ADD CONSTRAINT [PK_Pessoas]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [NrCompra] in table 'Compras'
ALTER TABLE [dbo].[Compras]
ADD CONSTRAINT [PK_Compras]
    PRIMARY KEY CLUSTERED ([NrCompra] ASC);
GO

-- Creating primary key on [ProdutoCodProduto], [CompraNrCompra1] in table 'DetalhesCompras'
ALTER TABLE [dbo].[DetalhesCompras]
ADD CONSTRAINT [PK_DetalhesCompras]
    PRIMARY KEY CLUSTERED ([ProdutoCodProduto], [CompraNrCompra1] ASC);
GO

-- Creating primary key on [CodProduto] in table 'Produtoes'
ALTER TABLE [dbo].[Produtoes]
ADD CONSTRAINT [PK_Produtoes]
    PRIMARY KEY CLUSTERED ([CodProduto] ASC);
GO

-- Creating primary key on [FilhoIdPessoa], [EventoNrEvento] in table 'Inscrição'
ALTER TABLE [dbo].[Inscrição]
ADD CONSTRAINT [PK_Inscrição]
    PRIMARY KEY CLUSTERED ([FilhoIdPessoa], [EventoNrEvento] ASC);
GO

-- Creating primary key on [AnimadorIdPessoa], [EventoNrEvento] in table 'Colaboração'
ALTER TABLE [dbo].[Colaboração]
ADD CONSTRAINT [PK_Colaboração]
    PRIMARY KEY CLUSTERED ([AnimadorIdPessoa], [EventoNrEvento] ASC);
GO

-- Creating primary key on [NrEvento] in table 'Eventoes'
ALTER TABLE [dbo].[Eventoes]
ADD CONSTRAINT [PK_Eventoes]
    PRIMARY KEY CLUSTERED ([NrEvento] ASC);
GO

-- Creating primary key on [IdEscola] in table 'Escolas'
ALTER TABLE [dbo].[Escolas]
ADD CONSTRAINT [PK_Escolas]
    PRIMARY KEY CLUSTERED ([IdEscola] ASC);
GO

-- Creating primary key on [EscolaIdEscola], [EventoNrEvento] in table 'Participação'
ALTER TABLE [dbo].[Participação]
ADD CONSTRAINT [PK_Participação]
    PRIMARY KEY CLUSTERED ([EscolaIdEscola], [EventoNrEvento] ASC);
GO

-- Creating primary key on [CodTipoProduto] in table 'TipoProdutos'
ALTER TABLE [dbo].[TipoProdutos]
ADD CONSTRAINT [PK_TipoProdutos]
    PRIMARY KEY CLUSTERED ([CodTipoProduto] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'Pessoas_Cliente'
ALTER TABLE [dbo].[Pessoas_Cliente]
ADD CONSTRAINT [PK_Pessoas_Cliente]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'Pessoas_Filho'
ALTER TABLE [dbo].[Pessoas_Filho]
ADD CONSTRAINT [PK_Pessoas_Filho]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'Pessoas_Animador'
ALTER TABLE [dbo].[Pessoas_Animador]
ADD CONSTRAINT [PK_Pessoas_Animador]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClienteIdPessoa] in table 'Pessoas_Filho'
ALTER TABLE [dbo].[Pessoas_Filho]
ADD CONSTRAINT [FK_ClienteFilho]
    FOREIGN KEY ([ClienteIdPessoa])
    REFERENCES [dbo].[Pessoas_Cliente]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteFilho'
CREATE INDEX [IX_FK_ClienteFilho]
ON [dbo].[Pessoas_Filho]
    ([ClienteIdPessoa]);
GO

-- Creating foreign key on [ClienteIdPessoa] in table 'Compras'
ALTER TABLE [dbo].[Compras]
ADD CONSTRAINT [FK_ClienteCompra]
    FOREIGN KEY ([ClienteIdPessoa])
    REFERENCES [dbo].[Pessoas_Cliente]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteCompra'
CREATE INDEX [IX_FK_ClienteCompra]
ON [dbo].[Compras]
    ([ClienteIdPessoa]);
GO

-- Creating foreign key on [ProdutoCodProduto] in table 'DetalhesCompras'
ALTER TABLE [dbo].[DetalhesCompras]
ADD CONSTRAINT [FK_ProdutoDetalheCompra]
    FOREIGN KEY ([ProdutoCodProduto])
    REFERENCES [dbo].[Produtoes]
        ([CodProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [FilhoIdPessoa] in table 'Inscrição'
ALTER TABLE [dbo].[Inscrição]
ADD CONSTRAINT [FK_FilhoInscrição]
    FOREIGN KEY ([FilhoIdPessoa])
    REFERENCES [dbo].[Pessoas_Filho]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [AnimadorIdPessoa] in table 'Colaboração'
ALTER TABLE [dbo].[Colaboração]
ADD CONSTRAINT [FK_AnimadorColaboração]
    FOREIGN KEY ([AnimadorIdPessoa])
    REFERENCES [dbo].[Pessoas_Animador]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [EventoNrEvento] in table 'Colaboração'
ALTER TABLE [dbo].[Colaboração]
ADD CONSTRAINT [FK_EventoColaboração]
    FOREIGN KEY ([EventoNrEvento])
    REFERENCES [dbo].[Eventoes]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventoColaboração'
CREATE INDEX [IX_FK_EventoColaboração]
ON [dbo].[Colaboração]
    ([EventoNrEvento]);
GO

-- Creating foreign key on [EventoNrEvento] in table 'Inscrição'
ALTER TABLE [dbo].[Inscrição]
ADD CONSTRAINT [FK_EventoInscrição]
    FOREIGN KEY ([EventoNrEvento])
    REFERENCES [dbo].[Eventoes]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventoInscrição'
CREATE INDEX [IX_FK_EventoInscrição]
ON [dbo].[Inscrição]
    ([EventoNrEvento]);
GO

-- Creating foreign key on [EscolaIdEscola] in table 'Pessoas_Filho'
ALTER TABLE [dbo].[Pessoas_Filho]
ADD CONSTRAINT [FK_EscolaFilho]
    FOREIGN KEY ([EscolaIdEscola])
    REFERENCES [dbo].[Escolas]
        ([IdEscola])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EscolaFilho'
CREATE INDEX [IX_FK_EscolaFilho]
ON [dbo].[Pessoas_Filho]
    ([EscolaIdEscola]);
GO

-- Creating foreign key on [EscolaIdEscola] in table 'Participação'
ALTER TABLE [dbo].[Participação]
ADD CONSTRAINT [FK_EscolaParticipação]
    FOREIGN KEY ([EscolaIdEscola])
    REFERENCES [dbo].[Escolas]
        ([IdEscola])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [EventoNrEvento] in table 'Participação'
ALTER TABLE [dbo].[Participação]
ADD CONSTRAINT [FK_EventoParticipação]
    FOREIGN KEY ([EventoNrEvento])
    REFERENCES [dbo].[Eventoes]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventoParticipação'
CREATE INDEX [IX_FK_EventoParticipação]
ON [dbo].[Participação]
    ([EventoNrEvento]);
GO

-- Creating foreign key on [CompraNrCompra1] in table 'DetalhesCompras'
ALTER TABLE [dbo].[DetalhesCompras]
ADD CONSTRAINT [FK_CompraDetalheCompra]
    FOREIGN KEY ([CompraNrCompra1])
    REFERENCES [dbo].[Compras]
        ([NrCompra])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompraDetalheCompra'
CREATE INDEX [IX_FK_CompraDetalheCompra]
ON [dbo].[DetalhesCompras]
    ([CompraNrCompra1]);
GO

-- Creating foreign key on [TipoProdutoCodTipoProduto] in table 'Produtoes'
ALTER TABLE [dbo].[Produtoes]
ADD CONSTRAINT [FK_TipoProdutoProduto]
    FOREIGN KEY ([TipoProdutoCodTipoProduto])
    REFERENCES [dbo].[TipoProdutos]
        ([CodTipoProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoProdutoProduto'
CREATE INDEX [IX_FK_TipoProdutoProduto]
ON [dbo].[Produtoes]
    ([TipoProdutoCodTipoProduto]);
GO

-- Creating foreign key on [IdPessoa] in table 'Pessoas_Cliente'
ALTER TABLE [dbo].[Pessoas_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_Pessoa]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[Pessoas]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPessoa] in table 'Pessoas_Filho'
ALTER TABLE [dbo].[Pessoas_Filho]
ADD CONSTRAINT [FK_Filho_inherits_Pessoa]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[Pessoas]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPessoa] in table 'Pessoas_Animador'
ALTER TABLE [dbo].[Pessoas_Animador]
ADD CONSTRAINT [FK_Animador_inherits_Pessoa]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[Pessoas]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------