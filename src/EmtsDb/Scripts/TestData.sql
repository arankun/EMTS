declare @eventId int,
    @userId int

if not exists (select * from [User] where EmailAddress = 'bhogg@emts.com')
    INSERT into [dbo].[User] ([Firstname], [Lastname], [EmailAddress])
        VALUES (N'Boss', N'Hogg', N'bhogg')

if not exists (select * from [User] where EmailAddress = 'jbob@emts.com')
    INSERT into [dbo].[User] ([Firstname], [Lastname], [EmailAddress])
        VALUES (N'Jim', N'Bob', N'jbob')

if not exists (select * from [User] where EmailAddress = 'jdoe@emts.com')
    INSERT into [dbo].[User] ([Firstname], [Lastname], [EmailAddress])
        VALUES (N'John', N'Doe', N'jdoe')

if not exists(select * from dbo.Event where Title = 'KV')
begin
    select top 1 @userId = UserId from [User] order by UserId;

    insert into dbo.Event(Title, Description, StartDate, CreatedDate, CreatedUserId, State, ZipCode)
        values('KV', 'Sample Event Test',getdate(), getdate(), @userId, 'GA', '30040');

    set @eventId = SCOPE_IDENTITY();

    INSERT [dbo].[EventAttendees] ([EventId], [UserId])
        VALUES (@eventId, @userId)
end