create database Assignment_5
use Assignment_5

Create table Employees (
    EmployeeID numeric(10) primary key,
    EmployeeName varchar(30),
    Salary numeric(10)
);

Insert into Employees(EmployeeID, EmployeeName, Salary) values 
    (01, 'Samiya', 3000), 
    (02, 'Sulthana', 5000), 
    (03, 'Priya', 4500);

select * from Employees

-- Create a stored procedure named GeneratePayslip
CREATE PROCEDURE GeneratePayslip 
    @EmployeeID INT
AS
BEGIN
    -- Declare variables to store various components of the payslip
    DECLARE @EmployeeName NVARCHAR(100)
    DECLARE @Salary DECIMAL(18, 2)
    DECLARE @HRA DECIMAL(18, 2)
    DECLARE @DA DECIMAL(18, 2)
    DECLARE @PF DECIMAL(18, 2)
    DECLARE @IT DECIMAL(18, 2)
    DECLARE @Deductions DECIMAL(18, 2)
    DECLARE @GrossSalary DECIMAL(18, 2)
    DECLARE @NetSalary DECIMAL(18, 2)

    --Display Employee details based on the provided EmployeeID
    SELECT @EmployeeName = EmployeeName,
           @Salary = Salary
    FROM Employees
    WHERE EmployeeID = @EmployeeID

    -- Calculate HRA , DA , PF , and IT based on salary
    SET @HRA = @Salary * 0.10
    SET @DA = @Salary * 0.20
    SET @PF = @Salary * 0.08
    SET @IT = @Salary * 0.05

    -- Calculate total deductions (PF + IT)
    SET @Deductions = @PF + @IT

    -- Calculate Gross Salary (Basic Salary + HRA + DA)
    SET @GrossSalary = @Salary + @HRA + @DA

    -- Calculate Net Salary (Gross Salary - Deductions)
    SET @NetSalary = @GrossSalary - @Deductions

    -- Print  payslip details
    PRINT 'Employee Name: ' + @EmployeeName
    PRINT '---------------------------------------'
    PRINT 'Basic Salary: ' + CAST(@Salary AS NVARCHAR(50))
    PRINT 'HRA: ' + CAST(@HRA AS NVARCHAR(50))
    PRINT 'DA: ' + CAST(@DA AS NVARCHAR(50))
    PRINT 'PF: ' + CAST(@PF AS NVARCHAR(50))
    PRINT 'IT: ' + CAST(@IT AS NVARCHAR(50))
    PRINT '---------------------------------------'
    PRINT 'Gross Salary: ' + CAST(@GrossSalary AS NVARCHAR(50))
    PRINT 'Deductions: ' + CAST(@Deductions AS NVARCHAR(50))
    PRINT '---------------------------------------'
    PRINT 'Net Salary: ' + CAST(@NetSalary AS NVARCHAR(50))
    PRINT '---------------------------------------'
END

-- Execute  GeneratePayslip stored procedure for EmployeeID
EXEC GeneratePayslip @EmployeeID = 1;