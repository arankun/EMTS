CREATE TABLE [dbo].[User](
    [UserId] BIGINT IDENTITY (1, 1) NOT NULL,
    [Firstname] [nvarchar](50) NOT NULL,
    [Lastname] [nvarchar](50) NOT NULL,
    [EmailAddress] NVARCHAR(50) NOT NULL,
    [ts] [rowversion] NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY ([UserId])
);