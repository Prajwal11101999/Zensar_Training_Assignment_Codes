/*
1.	Write a T-SQL Program to generate complete payslip of a given employee with respect to the following condition
a)	HRA  as 10% Of sal
b)	DA as  20% of sal
c)	PF as 8% of sal
d)	IT as 5% of sal
e)	Deductions as sum of PF and IT
f)	Gross Salary as sum of SAL,HRA,DA and Deductions
g)	Net salary as  Gross salary- Deduction
*/
use ZensarDB

sp_helptext getEmployeeSalary

create or alter procedure Employee_PaySlip @Eid int
as
begin
  select EmpName,EmpId,EmpSalary,
  EmpSalary/100*10 as HRA,
  EmpSalary/100*20 as DA,
  EmpSalary/100*8 as PF,
  EmpSalary/100*5 as IT,
  ((EmpSalary/100*8)+(EmpSalary/100*5)) as Deductions,
  (EmpSalary + (EmpSalary/100*10) + (EmpSalary/100*20) + (((EmpSalary/100*8)+(EmpSalary/100*5)))) as 'Gross Salary',
  (EmpSalary + (EmpSalary/100*10) + (EmpSalary/100*20) + ((EmpSalary/100*8)+(EmpSalary/100*5)) - ((EmpSalary/100*8)+(EmpSalary/100*5))) as 'Net Salary'from Employee
  where EmpId = @Eid
end

exec Employee_PaySlip 106

/*
2.	Write a T-SQL Program to Display complete result of a given student. (Note: Consider 10th standard result sheet and Student table structure as (sno,sname,maths,phy,comp)
*/

create Database Assignment3DB

use Assignment3DB

create table Student_Info
(Sno int primary key,
SName varchar(20) unique,
Maths_Marks float check (Maths_Marks<100),
Phy_Marks float check (Phy_Marks<100),
Comp_Marks float check (Comp_Marks<100),)

insert into Student_Info
values(1,'Yash Tamhane',76.0,97.56,55),
(2,'Prajwal Borawake',89.9,99.56,91.98),
(3,'Shreya Borawake',70.0,67.56,85),
(4,'Sagarika Khamkar',26.0,47.56,75),
(5,'Yogi Tamhane',96.0,57.56,95)

select * from Student_Info

create or alter procedure Student_Result @Studid int
as
begin
 select *,(((Maths_Marks + Phy_Marks + Comp_Marks)/300)*100) as 'Result in Percentage' from Student_Info
 where Sno = @Studid
end

exec Student_Result 4

/*
Write a T-SQL Program to find the factorial of a given number.
*/

create or alter procedure Factorial_Number @Num1 int
as
begin
declare @Factorial int = 1, @i int = 1
while(@i<=@Num1)
  begin
    set @Factorial = @Factorial * @i
	set @i += 1
  end
select @Factorial as 'Factorial of the Given Number'
end

exec Factorial_Number 3 

/*
Create a stored procedure to generate multiplication tables up to a given number.
*/

create or alter procedure Multiplication_Table @Num int
as
begin
  declare @Mult int 
  declare @i int = 1, @j int = 1
  while @i = 1
  begin
    print 'Multiplication Table'
    while @j <= 10
	begin
	  set @Mult = @Num * @j
	  print cast(@Num as varchar(5)) + ' * ' + cast(@j as varchar(5)) + ' = ' + cast(@Mult as varchar(5))
	  set @j = @j + 1
    end
  set @i = @i + 1
  end
end

exec Multiplication_Table 4

/*
Create a user defined function calculate Bonus for all employees of a  given job using following conditions
a.	       For Deptno10 employees 15% of sal as bonus.
b.	       For Deptno20 employees  20% of sal as bonus
c.	      For Others employees 5%of sal as bonus
*/

use Assignment1DB

create or alter function Calculate_Bonus()
returns table
as 
return (select *, Bonus=case 
when DEPTNO=10 then SAL*0.15
when DEPTNO=20 then SAL*0.2									  
else SAL*0.05 									 
end 									 
from EMP)

select * from Calculate_Bonus()

/*
Create a trigger to restrict data manipulation on EMP table during General holidays. Display the error message like “Due to Independence day you cannot manipulate data”
Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details
*/

create table General_Holiday
(Holiday_Date varchar(30),
Holiday_Name varchar(40) primary key)

select * from General_Holiday

insert into General_Holiday
values('15-August','Independence Day'),
('26-January','Republic Day'),
('10-April','Rama Navami'),
('14-April','Ambedkar Jayanti'),
('2-October','Ghandhi Jayanti'),
('25-December','Christmas Day')

create or alter trigger trgRestrict_Data_Manipulation
on General_Holiday
instead of delete,insert,update
as
begin
  raiserror('Due to Public Holiday you cannot Manipulate Data',16,1)
end

insert into General_Holiday
values('5-Sep', 'Teachers Day')

update General_Holiday set Holiday_Date = '4-Aug' where Holiday_Date = '5-Sep'

delete from General_Holiday where Holiday_Date = '15-Aug'

select * from General_Holiday


