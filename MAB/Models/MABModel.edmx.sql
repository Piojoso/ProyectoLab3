
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/08/2020 20:23:02
-- Generated from EDMX file: C:\Users\Piojoso\source\repos\Proyecto Lab 4\MAB\Models\MABModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MAB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClienteTelefono]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Telefonos] DROP CONSTRAINT [FK_ClienteTelefono];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteLavarropas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Lavarropas] DROP CONSTRAINT [FK_ClienteLavarropas];
GO
IF OBJECT_ID(N'[dbo].[FK_LavarropasReparacion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reparaciones] DROP CONSTRAINT [FK_LavarropasReparacion];
GO
IF OBJECT_ID(N'[dbo].[FK_ReparacionRepuestos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Repuestos] DROP CONSTRAINT [FK_ReparacionRepuestos];
GO
IF OBJECT_ID(N'[dbo].[FK_ReparacionesEntregas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Entregas] DROP CONSTRAINT [FK_ReparacionesEntregas];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientesEntregas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Entregas] DROP CONSTRAINT [FK_ClientesEntregas];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Clientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clientes];
GO
IF OBJECT_ID(N'[dbo].[Telefonos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Telefonos];
GO
IF OBJECT_ID(N'[dbo].[Lavarropas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Lavarropas];
GO
IF OBJECT_ID(N'[dbo].[Reparaciones]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reparaciones];
GO
IF OBJECT_ID(N'[dbo].[Repuestos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Repuestos];
GO
IF OBJECT_ID(N'[dbo].[Entregas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Entregas];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(max)  NULL,
    [apellido] nvarchar(max)  NOT NULL,
    [direccion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Telefonos'
CREATE TABLE [dbo].[Telefonos] (
    [ClienteId] int  NOT NULL,
    [telefono] bigint IDENTITY(1,1) NOT NULL,
    [estado] bit  NOT NULL
);
GO

-- Creating table 'Lavarropas'
CREATE TABLE [dbo].[Lavarropas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [marca] nvarchar(max)  NOT NULL,
    [modelo] nvarchar(max)  NOT NULL,
    [estadoGeneral] nvarchar(max)  NULL,
    [ClienteId] int  NOT NULL
);
GO

-- Creating table 'Reparaciones'
CREATE TABLE [dbo].[Reparaciones] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [fechaIngreso] datetime  NOT NULL,
    [fechaEgreso] datetime  NULL,
    [errorAReparar] nvarchar(max)  NOT NULL,
    [estadoReparacion] int  NOT NULL,
    [mesesGarantia] int  NULL,
    [reparacionRealizada] nvarchar(max)  NOT NULL,
    [manoDeObra] float  NOT NULL,
    [totalRepuestos] float  NOT NULL,
    [LavarropasId] int  NOT NULL
);
GO

-- Creating table 'Repuestos'
CREATE TABLE [dbo].[Repuestos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(max)  NOT NULL,
    [descripcion] nvarchar(max)  NULL,
    [precio] float  NOT NULL,
    [stock] int  NOT NULL,
    [ReparacionId] int  NOT NULL
);
GO

-- Creating table 'Entregas'
CREATE TABLE [dbo].[Entregas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [fecha] datetime  NOT NULL,
    [monto] float  NOT NULL,
    [ReparacionesId] int  NOT NULL,
    [ClientesId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [telefono], [ClienteId] in table 'Telefonos'
ALTER TABLE [dbo].[Telefonos]
ADD CONSTRAINT [PK_Telefonos]
    PRIMARY KEY CLUSTERED ([telefono], [ClienteId] ASC);
GO

-- Creating primary key on [Id] in table 'Lavarropas'
ALTER TABLE [dbo].[Lavarropas]
ADD CONSTRAINT [PK_Lavarropas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Reparaciones'
ALTER TABLE [dbo].[Reparaciones]
ADD CONSTRAINT [PK_Reparaciones]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Repuestos'
ALTER TABLE [dbo].[Repuestos]
ADD CONSTRAINT [PK_Repuestos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Entregas'
ALTER TABLE [dbo].[Entregas]
ADD CONSTRAINT [PK_Entregas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClienteId] in table 'Telefonos'
ALTER TABLE [dbo].[Telefonos]
ADD CONSTRAINT [FK_ClienteTelefono]
    FOREIGN KEY ([ClienteId])
    REFERENCES [dbo].[Clientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteTelefono'
CREATE INDEX [IX_FK_ClienteTelefono]
ON [dbo].[Telefonos]
    ([ClienteId]);
GO

-- Creating foreign key on [ClienteId] in table 'Lavarropas'
ALTER TABLE [dbo].[Lavarropas]
ADD CONSTRAINT [FK_ClienteLavarropas]
    FOREIGN KEY ([ClienteId])
    REFERENCES [dbo].[Clientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteLavarropas'
CREATE INDEX [IX_FK_ClienteLavarropas]
ON [dbo].[Lavarropas]
    ([ClienteId]);
GO

-- Creating foreign key on [LavarropasId] in table 'Reparaciones'
ALTER TABLE [dbo].[Reparaciones]
ADD CONSTRAINT [FK_LavarropasReparacion]
    FOREIGN KEY ([LavarropasId])
    REFERENCES [dbo].[Lavarropas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LavarropasReparacion'
CREATE INDEX [IX_FK_LavarropasReparacion]
ON [dbo].[Reparaciones]
    ([LavarropasId]);
GO

-- Creating foreign key on [ReparacionId] in table 'Repuestos'
ALTER TABLE [dbo].[Repuestos]
ADD CONSTRAINT [FK_ReparacionRepuestos]
    FOREIGN KEY ([ReparacionId])
    REFERENCES [dbo].[Reparaciones]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReparacionRepuestos'
CREATE INDEX [IX_FK_ReparacionRepuestos]
ON [dbo].[Repuestos]
    ([ReparacionId]);
GO

-- Creating foreign key on [ReparacionesId] in table 'Entregas'
ALTER TABLE [dbo].[Entregas]
ADD CONSTRAINT [FK_ReparacionesEntregas]
    FOREIGN KEY ([ReparacionesId])
    REFERENCES [dbo].[Reparaciones]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReparacionesEntregas'
CREATE INDEX [IX_FK_ReparacionesEntregas]
ON [dbo].[Entregas]
    ([ReparacionesId]);
GO

-- Creating foreign key on [ClientesId] in table 'Entregas'
ALTER TABLE [dbo].[Entregas]
ADD CONSTRAINT [FK_ClientesEntregas]
    FOREIGN KEY ([ClientesId])
    REFERENCES [dbo].[Clientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientesEntregas'
CREATE INDEX [IX_FK_ClientesEntregas]
ON [dbo].[Entregas]
    ([ClientesId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------