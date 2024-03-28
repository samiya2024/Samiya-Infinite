Create database Assessment_2

Use Assessment_2

---1. Write a query to display your birthday( day of week)
 
 -- Create table
CREATE TABLE Birthday (
    Name VARCHAR(50),
    DateOfBirth DATE
);

-- Insert data
INSERT INTO Birthday (Name, DateOfBirth) VALUES 
('Samiya', '2001-06-03'), -- Sunday, 3rd June
('Sandy', '1995-11-15'),
('Suresh', '1988-09-22'),
('Mahita', '2005-04-10');

-- Display day of the week for the birthday
SELECT Name, DateOfBirth, DATENAME(dw, DateOfBirth) AS DayOfWeek
FROM Birthday;

--------------------------Output----------------------
----Name     DateOfBirth     DayOfWeek
----Samiya	2001-06-03     	Sunday
----Sandy	1995-11-15   	Wednesday
----Suresh	1988-09-22	    Thursday
----Mahita	2005-04-10	    Sunday

--- 2.	Write a query to display your age in days
-- Creating the table
CREATE TABLE Age (
    Name VARCHAR(50),
    DateOfBirth DATE
);

-- Inserting data
INSERT INTO Age (Name, DateOfBirth) VALUES 
('Samiya', '2001-06-03'),
('Mahita', '2005-04-10'),
('Sandy', '1995-11-15'),
('Suresh', '1988-09-22');

Select*from Age

-- Query to display age in days
SELECT Name, DATEDIFF(day, DateOfBirth, GETDATE()) AS AgeInDays
FROM Age;

-------------------------Output----------------------
---Name    AgeInDays
---Samiya	8334
---Mahita	6927
---Sandy	10361
---Suresh	12971

--3.Write a query to display all employees information those who joined before 5 years in the current month

-- Create table
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    Name VARCHAR(50),
    Department VARCHAR(50),
    JoinDate DATE
);

-- Insert sample data
INSERT INTO Employees (EmployeeID, Name, Department, JoinDate)
VALUES 
    (1, 'Samiya', 'IT', '2019-03-15'),
    (2, 'Mahita', 'HR', '2017-08-21'),
    (3, 'Sandy', 'IT', '2017-03-28'),
    (4, 'Suresh', 'Finance', '2018-10-10');

	Select*from Employees


	-- Show employees who joined over 5 years ago this month
	select * from Employees where JoinDate <= dateadd(year, -5, dateadd(month, datediff(month, 0, getdate()), 0))

----------------Output--------------------

----EmployeeID   Name    Department      JoinDate
----2	        Mahita   	HR	       2017-08-21
---3         	Sandy    	IT	       2017-03-28
---4       	Suresh   	Finance   	2018-10-10


---4.Create table Employee with empno, ename, sal, doj columns and perform the following operations in a single transaction
---	a. First insert 3 rows 
---	b. Update the second row sal with 15% increment  
---        c. Delete first row.
---After completing above all actions how to recall the deleted row without losing increment of second row


create table employee22 (
    empno int primary key,
    ename varchar(10),
    sal float,
    doj date
)

insert into employee22 values 
(1, 'Samiya', 400, '2023-01-01'),
(2, 'mahita', 761, '2024-02-25'),
(3, 'mohan', 600, '2021-03-21')

begin transaction

select * from employee22

delete from employee22 where empno = 1 --deleting row with empno

select * from employee22
------Output-----
2	mahita	761	2024-02-25
3	mohan	600	2021-03-21

rollback transaction --calling rollback to undo changes
select * from employee22
--------Output-------------
1	Samiya	400	2023-01-01
2	mahita	761	2024-02-25
3	mohan	600	2021-03-21

update employee22 set sal = 1.15 * sal where empno = 2

select * from employee22
--------------Output----------
1	Samiya	400	2023-01-01
2	mahita	875.15	2024-02-25
3	mohan	600	2021-03-21


---5.  Create a user defined function calculate Bonus for all employees of a  given job using 	following conditions
---	  a.     For Deptno 10 employees 15% of sal as bonus.
---   b.     For Deptno 20 employees  20% of sal as bonus
---   c      For Others employees 5%of sal as bonus



Create table Employee3(empno numeric(10) primary key,
	ename varchar(20),
	DeptNo INT, 
	sal DECIMAL(10, 2)
	);
 
Insert into Employee3 (empno, ename, DeptNo, sal) values 
	(1, 'Samiya', 10, 1000), 
	(2, 'John', 12, 55000), 
	(3, 'Mahita', 13, 29000), 
	(4, 'Sreya', 14, 24000), 
	(5, 'Srita', 20, 19000);
 
select * From Employee3
 

 
CREATE FUNCTION CalculateBonus (@DeptNo INT, @sal DECIMAL(10, 2))
RETURNS DECIMAL(10, 2)
AS
BEGIN
    DECLARE @bonus DECIMAL(10, 2);
 
--	 For Deptno 10 employees 15% of sal as bonus.
    IF @deptno = 10
        SET @bonus = 0.15 * @sal;
 
--	 For Deptno 20 employees  20% of sal as bonus
 
    ELSE IF @deptno = 20
        SET @bonus = 0.20 * @sal;
 
-- For Others employees 5%of sal as bonus
 
    ELSE
        SET @bonus = 0.05 * @sal;
 
    RETURN @bonus;
END;
 
 
SELECT empno, ename, sal, dbo.CalculateBonus(DeptNo, sal) AS bonus
FROM Employee3;
 
----------------------------------- OUTPUT-----------------
1	Samiya	1000.00	150.00
2	John	55000.00	2750.00
3	Mahita	29000.00	1450.00
4	Sreya	24000.00	1200.00
5	Srita	19000.00	3800.00



