create table NewStudent(
Sid int NOT NULL IDENTITY(1,1)primary key,
Sname varchar(250) not null,
Senrollment varchar(250) not null,
SDepartment varchar(250) not null,
Ssemester varchar(250) not null,
Scontact bigint not null,
Semail varchar(250) not null
);

select * from NewStudent;

insert into NewStudent (Sname,Senrollment,SDepartment,Ssemester,Scontact,Semail) values ('hardik','ER_32','ba','5','2345678934','1243@gmail.com');