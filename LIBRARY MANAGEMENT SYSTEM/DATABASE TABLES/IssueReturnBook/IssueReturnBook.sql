create table IssueReturnBook(
id int NOT NULL IDENTITY(1,1) primary key,
stud_enroll varchar(250) not null,
stud_name varchar(250) not null,
stud_dep varchar(250) not null,
stud_sem varchar(250) not null,
stud_contact bigint not null,
stud_email varchar(250) not null,
book_name varchar(250) not null,
book_issue_date varchar(250) not null,
book_return_date varchar(250),
);
select * from IssueReturnBook;