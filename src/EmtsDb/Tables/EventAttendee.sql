CREATE TABLE [dbo].[EventAttendee]
(
    [EventId] bigint NOT NULL,
    [UserId] bigint not null,
    [ts] rowversion not null,
    primary key (EventId, UserId),
    foreign key (UserId) references dbo.[User] (UserId),
    foreign key (EventId) references dbo.Event (EventId)
)
go

create index ix_EventAttendee_UserId on EventAttendee(UserId)
go