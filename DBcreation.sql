drop database if exists BloodDonationsystemdb;
Go
create database BloodDonationsystemdb;
Go 
use BloodDonationsystemdb;

create table Account(
acc_id int identity(1,1),
username varchar(50) unique,
pass varchar(50) ,
isperson char(1) check(isperson in ('t ','f'))
constraint acc_pk primary key(acc_id)
)

create table Person(
p_id int primary key,
fname varchar(50),
lname varchar(50),
email varchar(50) unique,
bloodtype char(3) check(bloodtype in('A+','A-','B+','B-','O+','O-','AB+','AB-'))
constraint fk_pid foreign key (p_id) references Account(acc_id)
)
create table Organization(
O_id int primary key,
org_name varchar(50) unique,
contactnum varchar(20),
city varchar(50)
constraint fk_oid foreign key (O_id) references Account(acc_id)
)
Go
create nonclustered index orgkey on Organization(org_name); 
Go

create table Donation(
pid int,
orgid int,
dateofdonation date default getdate(),
constraint pk primary key (pid,dateofdonation),
constraint fkpid foreign key(pid) references Person(p_id),
constraint fkorg foreign key(orgid) references Organization(O_id)
)
