create database MVCwithDatabase
use MVCwithDatabase

create table RegistrationForm(
id int IDENTITY(1,1) PRIMARY KEY,
UserName varchar(50),
UserEmail varchar(50),
UserCNIC varchar(50),
UserAddress varchar(50),
);

select * from RegistrationForm