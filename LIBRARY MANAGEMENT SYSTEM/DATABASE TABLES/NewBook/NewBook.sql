create database LibraryMS;
create table NewBook(
Bid int NOT NULL IDENTITY(1,1) primary key,
Bname varchar(250) not null,
Bauthor varchar(250) not null,
Bpublication varchar(250) not null,
Bpublicationdate varchar(250)null,
Bprice bigint not null,
Bquantity bigint null
);
select * from NewBook;


insert into NewBook(Bname,Bauthor,Bpublication,Bpublicationdate,Bprice,Bquantity) values('The C Programming Language','Brian W and Dennis M','Prentice Hall','12 July 1978','1200','13');
insert into NewBook(Bname,Bauthor,Bpublication,Bpublicationdate,Bprice,Bquantity) values('C Programming :A Morden Approach','K.N King','W.W Norton & Company','13 jan 1996','1900','15');
insert into NewBook(Bname,Bauthor,Bpublication,Bpublicationdate,Bprice,Bquantity) values('Effective Java','Joshua Bloch','Addison-Wesley','1 July 2001','1000','93');
insert into NewBook(Bname,Bauthor,Bpublication,Bpublicationdate,Bprice,Bquantity) values('Java:The Complete Reference','Herbert Schildt','McGraw-Hill','22 June 1996','1200','13');
insert into NewBook(Bname,Bauthor,Bpublication,Bpublicationdate,Bprice,Bquantity) values('','','Prentice Hall','12 July 1978','','');


insert into NewBook(Bname,Bauthor,Bpublication,Bpublicationdate,Bprice,Bquantity) values('PHP and MySQL Web Development','Luke Welling and Laura Thomson','Addison-Wesley','5 mar 2000','977','78');
insert into NewBook(Bname,Bauthor,Bpublication,Bpublicationdate,Bprice,Bquantity) values('Learning PHP,MySQL & JavaScript','Robin Nixon','OReillay Media','10 mar 2014','890','80');

insert into NewBook(Bname,Bauthor,Bpublication,Bpublicationdate,Bprice,Bquantity) values('C# 9.0 in Nutshell','Joseph Albahari and Ben Albahari','OReillay Media','5 mar 2020','1455','99');
insert into NewBook(Bname,Bauthor,Bpublication,Bpublicationdate,Bprice,Bquantity) values('C# Programming Yellow Book','Rob Miles','Create Space Independent Publishing','18 sep 2016','880','21');


insert into NewBook(Bname,Bauthor,Bpublication,Bpublicationdate,Bprice,Bquantity) values('Pro .NET Framework with the Base Class Library','Andrew Troelsen','Apress','9 oct 2021','4500','54');

insert into NewBook(Bname,Bauthor,Bpublication,Bpublicationdate,Bprice,Bquantity) values('Programming .NET Framework','Chris Sells and Lan Griffiths','OReillay Media','18 sep 2002','1700','55');

insert into NewBook(Bname,Bauthor,Bpublication,Bpublicationdate,Bprice,Bquantity) values('ASP .NET Core in Action','Andrew Lock','Manning Publications','8 aug 2018','1600','102');





