create database MySql1


use MySql1

-- Create Books table
CREATE TABLE Books (
    id INT PRIMARY KEY IDENTITY(1,1),
    title VARCHAR(255) NOT NULL,
    author VARCHAR(255) NOT NULL,
    isbn VARCHAR(13) UNIQUE NOT NULL,
    published_date DATETIME NOT NULL
);

-- Insert data into Books table
INSERT INTO Books (title, author, isbn, published_date) VALUES
('My first sql book', 'Mary Parker', '981483029127', '2012-02-22 12:08:17'),
('My second sql book', 'John Mayer', '857300923713', '1972-07-03 09:22:45'),
('My third sql book', 'Cary Flint', '523120967812', '2015-10-18 14:05:44');

--Display the data from the Books
SELECT*FROM Books;

-- Create Reviews table
CREATE TABLE Reviews (
    id INT PRIMARY KEY IDENTITY(1,1),
    book_id INT REFERENCES Books(id),
    reviewer_name NVARCHAR(255) NOT NULL,
    content NVARCHAR(MAX) NOT NULL,
    rating INT NOT NULL CHECK (rating BETWEEN 1 AND 5),
    published_date DATETIME NOT NULL
);

-- Insert data into Reviews table
INSERT INTO Reviews (book_id, reviewer_name, content, rating, published_date) VALUES
(1, 'John Smith', 'My first review', 4, '2017-12-10 05:50:11.1'),
(2, 'John Smith', 'My second review', 5, '2017-10-13 15:05:12.6'),
(2, 'Alice Walker', 'My another review', 1, '2017-10-22 23:47:10');

--Display the data from the reviews
SELECT*FROM Reviews;




-- Query 1: to fetch details of books written by authors whose names end with "er"
SELECT * FROM Books WHERE author LIKE '%er';

---------------------Query 1:Output----
--id     title               Author         isbn          Publisher_date
--1  	My first sql book	Mary Parker	981483029127	2012-02-22 12:08:17.000
--2 	My second sql book	John Mayer	857300923713	1972-07-03 09:22:45.000



-- Query 1(2) : to display Title, Author, and ReviewerName for all the books
SELECT b.title, b.author, r.reviewer_name
FROM Books b
JOIN Reviews r ON b.id = r.book_id;


---------------------Query 1(2):Output----
--title                    author       reviewer_name
--My first sql book	Mary   Parker	    John Smith
--My second sql book	  John Mayer	John Smith
--My second sql book	  John Mayer	Alice Walker


-- Query 2: Display the reviewer names who reviewed more than one book
SELECT reviewer_name
FROM (
    SELECT reviewer_name, COUNT(DISTINCT book_id) AS num_books_reviewed
    FROM Reviews
    GROUP BY reviewer_name
) AS sub
WHERE num_books_reviewed > 1;

---------------------Query 2:Output----
     ---reviewer_name
     ----John Smith


	 -- Creating the Customer table
CREATE TABLE Customer (
    ID INT PRIMARY KEY,
    NAME VARCHAR(255),
    AGE INT,
    ADDRESS VARCHAR(255),
    SALARY DECIMAL(10, 2)
);

-- Inserting data into Customer table
INSERT INTO Customer (ID, NAME, AGE, ADDRESS, SALARY)
VALUES 
(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3, 'Kaushik', 23, 'Kota', 2000.00),
(4, 'Chaitali', 25, 'Mumbai', 6500.00),
(5, 'Hardik', 27, 'Bhopal', 8500.00),
(6, 'Komal', 22, 'Mp', 4500.00),
(7, 'Muffy', 24, 'Indore', 10000.00);


select*from Customer;

-- Query 3: Display the Name for the customer who live in the same address which has the character 'o' anywhere in the address

SELECT c1.NAME
FROM Customer c1
JOIN Customer c2 ON c1.ADDRESS = c2.ADDRESS
WHERE c2.ADDRESS LIKE '%o%';

------------------------Query 3:Output----
 ----  Name
 ----  Kaushik
 ----  Hardik
 ----  Muffy


 -----Query 4------
 -- Creating the Customer table
CREATE TABLE Customer (
    ID INT PRIMARY KEY,
    NAME VARCHAR(255),
    AGE INT,
    ADDRESS VARCHAR(255),
    SALARY DECIMAL(10, 2)
);

-- Inserting data into Customer table
INSERT INTO Customer (ID, NAME, AGE, ADDRESS, SALARY)
VALUES 
(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3, 'Kaushik', 23, 'Kota', 2000.00),
(4, 'Chaitali', 25, 'Mumbai', 6500.00),
(5, 'Hardik', 27, 'Bhopal', 8500.00),
(6, 'Komal', 22, 'Mp', 4500.00),
(7, 'Muffy', 24, 'Indore', 10000.00);

-- Creating the Orders table
CREATE TABLE Orders (
    OID INT PRIMARY KEY,
    DATE DATETIME,
    CUSTOMER_ID INT REFERENCES Customer(ID),
    AMOUNT DECIMAL(10, 2)
);

-- Inserting data into Orders table
INSERT INTO Orders (OID, DATE, CUSTOMER_ID, AMOUNT)
VALUES 
(102, '2009-10-08 00:00:00', 3, 3000),
(100, '2009-10-08 00:00:00', 3, 1500),
(101, '2009-11-20 00:00:00', 2, 1560),
(103, '2008-05-20 00:00:00', 4, 2060);

select*from orders;

-- Query 4 : Display the Date and the total number of customers who placed orders on the same date
SELECT DATE, COUNT(DISTINCT CUSTOMER_ID) AS Total_Customers_Placed_Order
FROM Orders
GROUP BY DATE;

------------------------------Query 4:Output----

---         Date              Total_Customers_Placed_Order
---2008-05-20 00:00:00.000   	1
---2009-10-08 00:00:00.000 	1
---2009-11-20 00:00:00.000  	1


-----Query 5----
-- Creating the EMPLOYEE table
CREATE TABLE EMPLOYEE (
    ID INT PRIMARY KEY,
    NAME VARCHAR(255),
    AGE INT,
    ADDRESS VARCHAR(255),
    SALARY DECIMAL(10, 2)
);

-- Inserting data into EMPLOYEE table
INSERT INTO EMPLOYEE (ID, NAME, AGE, ADDRESS, SALARY)
VALUES 
(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3, 'Kaushik', 23, 'Kota', 2000.00),
(4, 'Chaitali', 27, 'Mumbai', 6500.00),
(5, 'Hardik', 27, 'Bhopal', 8500.00),
(6, 'Komal', 22, 'Mp', NULL),
(7, 'Muffy', 24, 'Indore', NULL);

-- Query 5: Display the Names of the Employee in lower case, whose salary is null
SELECT LOWER(NAME) AS Lowercase_Name
FROM EMPLOYEE
WHERE SALARY IS NULL;

------------------------------Query 5:Output----
    -----Lowercase_Name
	---komal
    ---muffy

----Query5.1	
-- Creating the Studentdetails table
CREATE TABLE Studentdetails (
    RegisterNo INT PRIMARY KEY,
    Name VARCHAR(255),
    Age INT,
    Qualification VARCHAR(255),
    MobileNo BIGINT,
    Mail_id VARCHAR(255),
    Location VARCHAR(255),
    Gender CHAR(1)
);

-- Inserting data into Studentdetails table
INSERT INTO Studentdetails (RegisterNo, Name, Age, Qualification, MobileNo, Mail_id, Location, Gender)
VALUES 
(2, 'Sai', 22, 'B.E', 9952836777, 'Sai@gmail.com', 'Chennai', 'M'),
(3, 'Kumar', 20, 'B.Sc', 7890125648, 'Kumar@gmail.com', 'Madurai', 'M'),
(4, 'Selvi', 22, 'B.Tech', 8904567342, 'selvi@gmail.com', 'Selam', 'F'),
(5, 'Nisha', 25, 'M.E', 784672310, 'Nisha@gmail.com', 'Theni', 'F'),
(6, 'SaiSaran', 21, 'B.A', 7890345678, 'saran@gmail.com', 'Madurai', 'F'),
(7, 'Tom', 23, 'BCA', 8901234675, 'Tom@gmail.com', 'Pune', 'M');

-- Query 5.1: Display the Gender and the total number of males and females
SELECT 
    Gender,
    COUNT(CASE WHEN Gender = 'M' THEN 1 END) AS Total_Males,
    COUNT(CASE WHEN Gender = 'F' THEN 1 END) AS Total_Females
FROM Studentdetails
GROUP BY Gender;

------------------------------Query 5.1:Output----

---Gender      Total_Males    Total_Females
---F	          0	               3
----M	           3	               0

  




	 