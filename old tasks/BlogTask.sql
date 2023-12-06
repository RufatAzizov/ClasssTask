create database CsharpTask

create table Users(
Id int identity primary key,
Name nvarchar(25) not null,
Surname nvarchar(20),
Password nchar(256)
)

create table Blogs(
Id int identity primary key,
Title nvarchar(100) not null,
Description nvarchar(256) not null,
UserId int references Users(Id)
)

drop table Users

