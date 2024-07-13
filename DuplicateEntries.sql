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
count(*) from [cop].[duplicated] 
group  by fruit_name, price

delete from [cop].[duplicated]
where fruit_id not in(
select min(fruit_id)
from [cop].[duplicated]
group  by fruit_name, price
)