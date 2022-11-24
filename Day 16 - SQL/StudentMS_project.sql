create database StudentMS
use StudentMS

create table StudentInfo(
Stu_id int IDENTITY(1,1) PRIMARY KEY,
Stu_Name varchar(50),
Stu_Email nvarchar(50)
);

create table Courses(
cr_id int IDENTITY(1,1) PRIMARY KEY,
cr_Name varchar(50),
cr_hr tinyint
);

create table Faculty(
fac_id int IDENTITY(1,1) PRIMARY KEY,
fac_Name varchar(50),
fac_company varchar(50)
);

create table Department(
dep_id int IDENTITY(1,1) PRIMARY KEY,
dep_name varchar(75),
);



Insert into StudentInfo (Stu_Name, Stu_Email)
values
	('Ammar', 'aym4216@gmail.com'),
	('Ali', 'ali@gmail.com'),
	('Ahmed', 'ahmed@gmail.com'),
	('Saad', 'saad@gmail.com'),
	('Asad', 'asad@gmail.com')


	Insert into Courses (cr_Name, cr_hr)
values
	('Java', 3),
	('.NET', 4),
	('MERN', 5),
	('SQA', 3),
	('Networking', 3)

	Insert into Faculty (fac_Name, fac_company)
values
	('Ahmer', 'CONTOUR SOFTWARE'),
	('Bilal', 'CONTOUR SOFTWARE'),
	('Daniyal', 'CONTOUR SOFTWARE'),
	('Fazeel', 'CONTOUR SOFTWARE'),
	('Sadia', 'CONTOUR SOFTWARE')

	Insert into Department (dep_name)
values
	('FEST'),
	('FOP'),
	('BBA'),
	('FEM'),
	('FMS')


-- Many to Many
create table Enrollment(
er_id int IDENTITY(1,2) PRIMARY KEY,
stu_id int FOREIGN KEY REFERENCES StudentInfo(stu_id),
cr_id int FOREIGN KEY REFERENCES Courses(cr_id),
);

create table Teaching(
teaching_id int IDENTITY(1,2) PRIMARY KEY,
cr_id int FOREIGN KEY REFERENCES Courses(cr_id),
fac_id int FOREIGN KEY REFERENCES Faculty(fac_id),
);


-- One to Many
alter table StudentInfo add dep_id int FOREIGN KEY REFERENCES Department(dep_id)

select * from StudentInfo

-- INNER Join with three tables
select * from Enrollment E inner join StudentInfo S on E.stu_id = S.Stu_id inner join Courses C on E.cr_id = C.cr_id
