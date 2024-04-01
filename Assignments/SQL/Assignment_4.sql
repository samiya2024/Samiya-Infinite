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
DROP TABLE HOLIDAY;
-- Create the Holiday table
CREATE TABLE Holiday (
    H_Date DATE,
    H_Name VARCHAR(40)
);

-- Insert holiday data
INSERT INTO Holiday VALUES
('2024-03-25', 'Holi'),
('2024-08-15', 'Independence Day'),
('2024-08-19', 'Raksha-Bandhan'),
('2024-03-26', 'Tuesday');



CREATE TRIGGER Restricted ON emp
AFTER INSERT, DELETE, UPDATE
AS
BEGIN
    DECLARE @CurrentDate DATE;
    DECLARE @HolidayName VARCHAR(40);

    -- Get the current date
    SET @CurrentDate = GETDATE();

    -- Check if the current date is a holiday
    SELECT @HolidayName = H_Name
    FROM Holiday
    WHERE H_Date = @CurrentDate;

    -- If it's a holiday, raise an error and rollback the transaction
    IF @HolidayName IS NOT NULL
    BEGIN
        DECLARE @ErrorMessage VARCHAR(100);
        SET @ErrorMessage = CONCAT('Due to ', @HolidayName, ', data manipulation is restricted.');
        RAISERROR(@ErrorMessage, 16, 1);
        ROLLBACK TRANSACTION;
    END;
    ELSE
    BEGIN
        
        COMMIT TRANSACTION;
    END;
END;
GO

CREATE TABLE emp (
    emp_id INT PRIMARY KEY,
    emp_name VARCHAR(100),
    emp_salary DECIMAL(10, 2)
);

INSERT INTO EMP VALUES(100,'SAMIYA',34000);

SELECT*FROM EMP;




