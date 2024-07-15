create database Coplur
create schema cop
create table [cop].[duplicated]
(fruit_id int identity(01,1) primary key,
fruit_name varchar(50),
price int 
)

insert into [cop].[duplicated]
values('mango', 20),
('grapes',27),
('apple',60),
('orange',30)
select * from [cop].[duplicated]
order by fruit_name asc

select fruit_name, price,
count(fruit_id) from [cop].[duplicated] 
group  by fruit_name, price

delete from [cop].[duplicated]
where fruit_id not in(
select min(fruit_id)
from [cop].[duplicated]
group  by fruit_name, price
)

create table [cop].[sale]
(
fruit_id int,
sale int
)

insert into [cop].[sale]
values(1, 120),
(3,300),
(4,600),
(2,330)
select * from [cop].[sale]

 select duplicated.fruit_id, duplicated.fruit_name, sale.sale
 from [cop].[duplicated]
 inner join [cop].[sale] on duplicated.fruit_id= sale.fruit_id

 select * from [cop].[sale]
 select * from [cop].[duplicated]

