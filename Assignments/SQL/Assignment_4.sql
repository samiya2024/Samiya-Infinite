-- 1.	Write a T-SQL Program to find the factorial of a given number.
 


DECLARE @number INT = 9; 

DECLARE @factorial BIGINT = 1;
DECLARE @counter INT = 1;

WHILE @counter <= @number
BEGIN
    SET @factorial = @factorial * @counter;
    SET @counter = @counter + 1;
END

SELECT @factorial AS FactorialOfNumber;

 
 
-- 2.	Create a stored procedure to generate multiplication tables up to a given number.

create procedure Tables
@EndNumber int
as
begin
    declare @multiplier int = 1;

    while @multiplier <= @EndNumber
    begin
        declare @multiplicand int = 1;

        while @multiplicand <= @EndNumber
        begin
            declare @result int = @multiplier * @multiplicand;
            print convert(varchar(10), @multiplier) + ' * ' + convert(varchar(10), @multiplicand) + ' = ' + convert(varchar(10), @result);
            set @multiplicand = @multiplicand + 1;
        end;

        set @multiplier = @multiplier + 1;
        print 'NEXT TABLE or END';
    end;
end;
 
 EXEC Tables @EndNumber = 5;


 
-- 3.  Create a trigger to restrict data manipulation on EMP table during General holidays. Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate" etc
-- Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details. try to match and stop manipulation
 CREATE TABLE employee (
    emp_id INT PRIMARY KEY,
    emp_name VARCHAR(100),
    emp_salary DECIMAL(10, 2)
);

 -- Step 1: Create holiday table
CREATE TABLE holiday (
    holiday_date DATE PRIMARY KEY,
    holiday_name VARCHAR(100)
);

-- Step 2: Populate holiday table with holiday details
INSERT INTO holiday (holiday_date, holiday_name) VALUES
('2024-07-04', 'Independence Day'),
('2024-10-25', 'Diwali'),
('2024-12-25', 'Christmas'),
('2025-01-01', 'New Year');

-- Step 3: Create trigger on EMP table
DELIMITER $$

create trigger Restricted on employee
after insert, delete, update
as
begin
    declare @CurrentDate date;
    declare @HolidayName varchar(40);

    set @CurrentDate = getdate();
    select @HolidayName = holiday_name
    from holiday
    where holiday_date = @CurrentDate;

    if @HolidayName is not null
    begin
	 raiserror('Due to %s, you cannot manipulate data.', 16, 1, @HolidayName);
	 rollback transaction;
    end
end;
-- Explanation:
-- This trigger will prevent any manipulation (INSERT, UPDATE, DELETE) on the EMP table during holidays.
-- It checks if the date of the attempted manipulation (NEW.date_column) exists in the holiday table.
-- If a match is found, it raises an error with an appropriate message indicating the holiday name.
