declare @num int
set @num=0
while @num<1000
begin
set @num=@num+1
insert into Movies(title,ReleaseDate,Genre,Price) values (cast(@num as nvarchar(50)),'20180603','Happy',100)
end 