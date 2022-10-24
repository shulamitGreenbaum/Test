CREATE TABLE.members (
[tableID] [int] IDENTITY(1,1) not null,
firstName varchar(10) not null ,
lastName varchar(10) not null ,
id varchar(9) not null,
city varchar(10) not null,
steet varchar(10)not null,
bildingnumber int  not null,
birthday date not null,
phone varchar(9) not null,
cellphone varchar (10) null,
vaccinDate1 date null,
tipevaccin1 varchar(10) null,
sickdate date null,
recoverydate date null,


CONSTRAINT [PK_Table_Name] PRIMARY KEY CLUSTERED 
(
[id] ASC
)
)
ALTER TABLE members
ADD BvaccindDate date null;
ALTER TABLE members
ADD CvaccinDate date null;
ALTER TABLE members
ADD DvaccinDate date null;
ALTER TABLE members
ADD Btipevaccin varchar(10) null;
ALTER TABLE members
ADD Ctipevaccin varchar(10) null;
ALTER TABLE members
ADD Dtipevaccin varchar(10) null;


INSERT INTO members
(
,'Shulamit',lastName-'Greenbaum',id-'213255078',city-'Jerusalem',steet-'Sorotzkin',bildingnumber- 18,birthday-'08/08/2002',phone='025373853',cellphone='0548455274',vaccinDate1,vaccinDate2,vaccinDate3,vaccinDate4,tipevaccin1,tipevaccin2,tipevaccin3,tipevaccin4,sickdate,recoverydate
)
