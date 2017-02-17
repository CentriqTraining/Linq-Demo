use master
go
drop database BuyMoria
go
Create Database BuyMoria
go
use buymoria
go

Create Table Employee (
[ID] int identity(1,1) primary key,
[FirstName] varchar(150),
[LastName] varchar(150),
[Salary] numeric(9,2),
[Position] varchar(100),
[DateTerminated] datetime)

Create Table Expense (
[ID] int identity(1,1) primary key,
[EmployeeID] int not null foreign key references Employee (ID) on delete cascade on update cascade,
[Description] varchar(250),
[Cost] numeric(9,2))

go


insert into employee select 'Michael','Tucker','18.00','Manager',null
insert into employee select 'Morgan','Grimes','12.00','Asst. Manager',null
insert into employee select 'Emmett','Milbarge','14.00','Asst. Manager','2012-01-31 00:00:00'
insert into employee select 'Harry','Tang','12.00','Asst. Manager','2011-01-31 00:00:00'
insert into employee select 'Diane','Beckman','22.00','Manager',null
insert into employee select 'John','Casey','10.00','Green Shirt',null
insert into employee select 'Fernando','','9.00','Green Shirt',null
insert into employee select 'Bunny','','9.00','Green Shirt',null
insert into employee select 'Chuck','Bartowski','13.00','Nerd Herd',null
declare @scope int 
select @scope =  Scope_Identity()


insert into Expense Select @scope,'Install in Paris','4300.00'
insert into Expense Select @scope,'Install','30.00'
insert into Expense Select @scope,'Install','50.00'
insert into Expense Select @scope,'Install','75.00'
insert into Expense Select @scope,'Install','240.00'
insert into Expense Select @scope,'Install','43.00'
insert into Expense Select @scope,'Install','14.00'
insert into Expense Select @scope,'Install','400.00'
insert into Expense Select @scope,'Install','300.00'

insert into employee select 'Jeffrey','Barnes','11.25','Nerd Herd, Apple',null
insert into employee select 'Lester','Patel','11.25','Nerd Herd, Apple',null
insert into employee select 'Skip','Johnson','12.00','Nerd Herd',null
insert into employee select 'Anna','Wu','9.00','Nerd Herd','2012-01-31 00:00:00'
insert into employee select 'Hannah','','8.00','Nerd Herd','2012-01-31 00:00:00'
insert into employee select 'Greta','','8.00','Green Shirt','2012-01-31 00:00:00'
insert into employee select 'Rick','Noble','8.00','Green Shirt',null
insert into employee select 'Victoria','Dunwoody','8.00','Green Shirt',null
insert into employee select 'Moses','Finkelstein','180.00','Founder',null
insert into employee select 'Porter','Bauer','8.00','Green Shirt','2010-01-31 00:00:00'
insert into employee select 'Marvin','Gadsby','8.00','Green Shirt','2010-01-31 00:00:00'
insert into employee select 'Cecil','Goldenberg','8.00','Green Shirt','2010-01-31 00:00:00'
insert into employee select 'Christina','James','8.00','Green Shirt','2010-01-31 00:00:00'
insert into employee select 'Ruben','Mango','8.00','Green Shirt','2010-01-31 00:00:00'
insert into employee select 'Sal','Sawaya','8.00','Green Shirt','2010-01-31 00:00:00'
insert into employee select 'Skye','Stoinitz','8.00','Green Shirt','2010-01-31 00:00:00'
insert into employee select 'Leticia','Williams','8.00','Green Shirt','2010-01-31 00:00:00'
insert into employee select 'Sarah','Yang','8.00','Green Shirt','2010-01-31 00:00:00'

use master
go
exec sp_addsrvrolemember '10266A-GEN-DEV\Student', 'sysadmin'