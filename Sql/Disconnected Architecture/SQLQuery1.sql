Create table Course
(cid int primary key,
cname varchar(50) not null,
instructor varchar(50))

alter table Course
alter column fees decimal

--To add Constraint through Alter table
alter table Course 
add constraint chk_fees check(fees>0)


create table Student
(sid int primary key, 
sname varchar(50) not null, 
address varchar(50),
cid int foreign key references Course(cid))

insert into Course values(201,'C#','Nikita',10000)
insert into Course values(202,'Java','Rajeshree',7000)
insert into Course values(203,'Angular','Devyani',9000)
insert into Course values(204,'SQL','Shilpa',5000)
insert into Course values(205,'Android','Janhavi',6000)

insert into Student values(1,'Ashutosh','Kothrud',201)
insert into Student values(2,'Ajinkya','FC Road',203)
insert into Student values(3,'Simran','Sinhgad',202)
insert into Student values(4,'Rucha','Deccan',204)
insert into Student values(5,'Abhishek','Bavdhan',205)

select * from Course
select * from Student