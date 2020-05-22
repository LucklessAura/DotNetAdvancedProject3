
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/11/2020 10:18:03
-- Generated from EDMX file: D:\dotnet\advanced\Proiect2\Database\Project1\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [NETProiect2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_FileAditionalFilePropriety]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AditionalFileProprieties] DROP CONSTRAINT [FK_FileAditionalFilePropriety];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Files]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Files];
GO
IF OBJECT_ID(N'[dbo].[AditionalFileProprieties]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AditionalFileProprieties];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Files'
CREATE TABLE [dbo].[Files] (
    [FileId] int IDENTITY(1,1) NOT NULL,
    [FilePath] nvarchar(50)  NOT NULL,
    [DateCreated] nvarchar(20)  NOT NULL,
    [Ocasion] nvarchar(50)  NULL,
    [People] nvarchar(100)  NULL,
    [Place] nvarchar(50)  NULL,
    [Deleted] bit  NOT NULL,
    [FileName] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'AditionalFileProprieties'
CREATE TABLE [dbo].[AditionalFileProprieties] (
    [AditionalFileProprietyId] int IDENTITY(1,1) NOT NULL,
    [ProprietyName] nvarchar(50)  NOT NULL,
    [ProprietyValue] nvarchar(50)  NOT NULL,
    [ForeignFileId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [FileId] in table 'Files'
ALTER TABLE [dbo].[Files]
ADD CONSTRAINT [PK_Files]
    PRIMARY KEY CLUSTERED ([FileId] ASC);
GO

-- Creating primary key on [AditionalFileProprietyId] in table 'AditionalFileProprieties'
ALTER TABLE [dbo].[AditionalFileProprieties]
ADD CONSTRAINT [PK_AditionalFileProprieties]
    PRIMARY KEY CLUSTERED ([AditionalFileProprietyId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ForeignFileId] in table 'AditionalFileProprieties'
ALTER TABLE [dbo].[AditionalFileProprieties]
ADD CONSTRAINT [FK_FileAditionalFilePropriety]
    FOREIGN KEY ([ForeignFileId])
    REFERENCES [dbo].[Files]
        ([FileId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FileAditionalFilePropriety'
CREATE INDEX [IX_FK_FileAditionalFilePropriety]
ON [dbo].[AditionalFileProprieties]
    ([ForeignFileId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------