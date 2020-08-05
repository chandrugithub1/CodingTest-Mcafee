-----DROP DATABASE----------------------
DROP  Table TestMaster

-----CREATE TABLE----------------

CREATE TABLE TestMaster(Name Varchar(50))

----INSERT Name------------------------

INSERT INTO TestMaster VALUES('MASTER')
INSERT INTO TestMaster VALUES('TEMPDB')
INSERT INTO TestMaster VALUES('MODEL')
INSERT INTO TestMaster VALUES('MSDB')

--------Substring---------------------------------

SELECT Name as NAME,Substring(Name,1,1) as FirstCharester,Substring(Name,3,1) as SecondCharester,SUBSTRING(Name,4,1) from TestMaster