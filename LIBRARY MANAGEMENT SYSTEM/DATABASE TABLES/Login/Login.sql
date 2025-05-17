create table Login(
id int NOT NULL IDENTITY(1,1) primary key,
username varchar(150) not null,
pasword varchar(150) not null,
);
select * from Login;

insert into Login (username,pasword) values ('Karan','Pass');