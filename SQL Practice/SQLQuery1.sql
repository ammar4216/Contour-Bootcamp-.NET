create database bootcamp2
use bootcamp2

create table class2(
class_id int IDENTITY(1,1) PRIMARY KEY,
class_name varchar(50) default '',
class_duration varchar(50) default '',
);

-- Select command
select * from class2

-- Insert command
Insert into class2 (class_name, class_duration) 
values 
	('.NET Bootcamp', '3:00'), 
	('SQA Bootcamp', '4:00'),
	('MERN Bootcamp', '2:00'),
	('Java Bootcamp', '5:00')

Insert into class2 (class_name, class_duration) 
values
	('React JS', '3:30')

update class2 set class_days = 'F, S, S' where class_id = 5

-- update command
update class2 set class_duration = '4:30' where class_id = 2


-- delete command
delete from class2 where class_id = 10


-- select with where
select * from class2 where class_id = 4

-- alter table
alter table class2 add faculty_id int FOREIGN KEY REFERENCES faculty(faculty_id)

update class2 set faculty_id = 2 where class_id = 4


-- drop table command
drop table class1


-- New Table
create table faculty(
faculty_id int IDENTITY(1,1) PRIMARY KEY,
faculty_name varchar(50) NOT NULL,
);

Insert into faculty (faculty_name) 
values 
	('Sir Fazeel'), 
	('Miss Sadia'),
	('Miss Natasha'),
	('Sir Bilal')

select * from faculty


-- JOINS

-- FULL OUTER JOIN
select a.class_name, a.class_duration, a.class_days, b.faculty_name from class2 a full outer join faculty b on a.faculty_id = b.faculty_id 

-- INNER JOIN
select a.class_name, a.class_duration, a.class_days, b.faculty_name from class2 a inner join faculty b on a.faculty_id = b.faculty_id

-- LEFT OUTER JOIN
select a.class_name, a.class_duration, a.class_days, b.faculty_name from class2 a left join faculty b on a.faculty_id = b.faculty_id

-- RIGHT OUTER JOIN
select a.class_name, a.class_duration, a.class_days, b.faculty_name from class2 a right join faculty b on a.faculty_id = b.faculty_id


-- STORED PROCEDURES

CREATE PROCEDURE SelectClassData
AS
select * from class2 where class_name = '.NET Bootcamp'
GO

EXEC SelectClassData

-- STORED PROCEDURES with parameters

CREATE PROCEDURE SelectClassName @className varchar(50)
AS
select * from class2 where class_name = @className
GO

EXEC SelectClassName @className = 'Java Bootcamp';

-- DROP SP
DROP PROCEDURE SelectClassData;  
GO 

-- VIEWS
Create view [SelectCommonData] as 
select a.class_name, a.class_duration, a.class_days, b.faculty_name from class2 a inner join faculty b on a.faculty_id = b.faculty_id

select * from [SelectCommonData]