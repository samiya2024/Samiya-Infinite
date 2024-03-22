create database Assignment_2

use Assignment_2

--EMP(empno, ename, job, mgr-id, hiredate, sal, comm, deptno) 

--DEPT(deptno, dname, loc) 

CREATE TABLE EMP (
    empo numeric(4) primary key,
    ename varchar(20),
    job varchar(15),
    mgr_id int,
    hiredate date,
    sal float(5),
    comm numeric(4),
    deptno numeric(2) foreign key (deptno) references DEPT(deptno)
);

insert into EMP(empo,ename,job,mgr_id,hiredate, sal, comm, deptno) values
	(7369,'SMIT', 'CLERK', 7902, '17-DEC-80', 800, null,20),
	(7499, 'ALLEN', 'SALESMAN', 7698, '20-FEB-81', 1600, 300, 30),
	(7521, 'WARD', 'SALESMAN', 7698, '22-FEB-81', 1250, 500, 30),
	(7566, 'JONES', 'MANAGER', 7839, '02-APR-81', 2975, null, 20),
	(7654, 'MARTIN', 'SALESMAN', 7698, '28-SEP-81', 1250, 1400, 30),
	(7698, 'BLAKE', 'MANAGER', 7839, '01-MAY-81', 2850, null, 30),
	(7782, 'CLARK', 'MANAGER', 7839, '09-JUN-81', 2450, null,10),
	(7788, 'SCOTT', 'ANALYST', 7566, '19-APR-87', 3000, null,20),
	(7839, 'KING', 'PRESIDENT', null, '17-NOV-81', 5000, null,10),
	(7844, 'TURNER', 'SALESMAN', 7698, '08-SEP-81', 1500, 0, 30),
	(7876, 'ADAMS', 'CLERK', 7788, '23-MAY-87', 1100, null,20),
	(7900, 'JAMES', 'CLERK', 7698, '03-DEC-81', 950, null,30),
	(7902, 'FORD', 'ANALYST', 7566, '03-DEC-81', 3000, null,20),
	(7934, 'MILLER', 'CLERK', 7782, '23-JAN-82', 1300, null,10);


select * from EMP;

-------------------------------------------------------------------------------------

create table DEPT (
	DEPTNO numeric(4) primary key,
	DNAME varchar(20),  
	LOC varchar(20)
)

insert into DEPT(deptno, dname, loc) values
(10, 'ACCOUNTING', 'NEW YORK'), 
(20, 'RESEARCH', 'DALLAS'), 
(30, 'SALES', 'CHICAGO'), 
(40, 'OPERATIONS', 'BOSTON');


select * from DEPT;

---------------------------------------------------------------------------------------
-- 1. List all employees whose name begins with 'A'.
SELECT * FROM EMP WHERE ENAME LIKE 'A%';

-- 2. Select all those employees who don't have a manager.
SELECT * FROM EMP WHERE MGR_ID IS NULL;

-- 3. List employee name, number, and salary for those employees who earn in the range 1200 to 1400.
SELECT ENAME, empo, SAL FROM EMP WHERE SAL BETWEEN 1200 AND 1400;

-- 4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise.
-- Before
SELECT * FROM EMP WHERE DEPTNO = 20;

-- Apply pay rise
UPDATE EMP SET SAL = SAL * 1.1 WHERE DEPTNO = 20;

-- After
SELECT * FROM EMP WHERE DEPTNO = 20;

-- 5. Find the number of CLERKS employed. Give it a descriptive heading.
SELECT COUNT(*) AS "Number of Clerks" FROM EMP WHERE JOB = 'CLERK';

-- 6. Find the average salary for each job type and the number of people employed in each job.
SELECT JOB, AVG(SAL) AS "Average Salary", COUNT(*) AS "Number of Employees" FROM EMP GROUP BY JOB;

-- 7. List the employees with the lowest and highest salary.
SELECT * FROM EMP WHERE SAL = (SELECT MIN(SAL) FROM EMP) OR SAL = (SELECT MAX(SAL) FROM EMP);

-- 8. List full details of departments that don't have any employees.
SELECT * FROM DEPT WHERE DEPTNO NOT IN (SELECT DISTINCT DEPTNO FROM EMP);

-- 9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name.
SELECT ENAME, SAL FROM EMP WHERE JOB = 'ANALYST' AND SAL > 1200 AND DEPTNO = 20 ORDER BY ENAME ASC;

-- 10. For each department, list its name and number together with the total salary paid to employees in that department.
SELECT d.deptno, d.dname, SUM(e.sal) AS TotalSalary
FROM DEPT d
JOIN EMP e ON d.deptno = e.deptno
GROUP BY d.deptno, d.dname;

-- 11. Find out salary of both MILLER and SMITH.
SELECT ENAME, SAL FROM EMP WHERE ENAME IN ('MILLER', 'SMITH');

-- 12. Find out the names of the employees whose name begins with �A� or �M�.
SELECT ENAME FROM EMP WHERE ENAME LIKE 'A%' OR ENAME LIKE 'M%';

-- 13. Compute yearly salary of SMITH.
SELECT ENAME, SAL * 12 AS "Yearly Salary" FROM EMP WHERE ENAME = 'SMITH';

-- 14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850.
SELECT ENAME, SAL FROM EMP WHERE SAL NOT BETWEEN 1500 AND 2850;

-- 15. Find all managers who have more than 2 employees reporting to them.
SELECT MGR_ID, COUNT(*) AS "Number of Employees" FROM EMP GROUP BY MGR_ID HAVING COUNT(*) > 2;


--16.find the list of manager  who earns less than manager but they should not be manager

SELECT emp1.empo, emp1.ename, emp1.sal AS EmployeeSalary, mgr.sal AS ManagerSalary
FROM EMP emp1
JOIN EMP mgr ON emp1.mgr_id = mgr.empo
WHERE emp1.sal < mgr.sal
AND emp1.job <> 'MANAGER';

SELECT e.*
FROM EMP e
JOIN EMP manager ON e.mgr_id = manager.empo
WHERE e.sal < manager.sal
AND e.job <> 'MANAGER';
