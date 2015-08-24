CREATE TABLE [dbo].[Event] (
    [EventId]       BIGINT         IDENTITY (1, 1) NOT NULL,
    [Title]         NVARCHAR (100) NOT NULL,
	[Description]   NVARCHAR (500) NOT NULL,
    [StartDate]     DATETIME2 (7)  NULL,
    [EndDate]       DATETIME2 (7)  NULL,
    [CreatedDate]   DATETIME2 (7)  NOT NULL,
    [CreatedUserId] bigint    NOT NULL,
    [ts]            rowversion     NOT NULL,
    PRIMARY KEY CLUSTERED ([EventId] ASC),
    FOREIGN KEY ([CreatedUserId]) REFERENCES [dbo].[User] ([UserId])
);