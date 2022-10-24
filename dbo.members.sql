CREATE TABLE [dbo].[members] (
    [tableID]       INT          IDENTITY (1, 1) NOT NULL,
    [firstName]     VARCHAR (10) NOT NULL,
    [lastName]      VARCHAR (10) NOT NULL,
    [id]            VARCHAR (9)  NOT NULL,
    [city]          VARCHAR (10) NOT NULL,
    [steet]         VARCHAR (10) NOT NULL,
    [bildingnumber] INT          NOT NULL,
    [birthday]      DATE         NOT NULL,
    [phone]         VARCHAR (9)  NOT NULL,
    [cellphone]     VARCHAR (10) NULL,
    [vaccinDate]    DATE         NULL,
    [tipevaccin]    VARCHAR (10) NULL,
    [sickdate]      DATE         NULL,
    [recoverydate]  DATE         NULL,
    CONSTRAINT [PK_Table_Name] PRIMARY KEY CLUSTERED ([id] ASC)
);

