/* THE BLUNDER */
/*
Samantha was tasked with calculating the average monthly salaries for all employees in the EMPLOYEES table, but did not realize her keyboard's 0 key was broken 
until after completing the calculation. She wants your help finding the difference between her miscalculation (using salaries with any zeroes removed), 
and the actual average salary. Write a query calculating the amount of error (i.e.actual - miscalculated:  average monthly salaries), and round it up to the next integer.

select "(" + Convert(Varchar(3),ID) + ",'" + Name + "'," + Convert(Varchar(10),Salary) + ")," from Employees
*/

declare @EMployees Table (ID int, Name Varchar(20), Salary int)
insert into @EMployees Values (1,'Ashley',2340), (2,'Julia',1198), (3,'Britney',9009), (4,'Kristeen',2341), (5,'Dyana',9990), (6,'Diana',8011), (7,'Jenny',2341), 
(8,'Christeen',2342), (9,'Meera',2343), (10,'Priya',2344), (11,'Priyanka',2345), (12,'Paige',2346), (13,'Jane',2347), (14,'Belvet',2348), (15,'Scarlet',2349), 
(16,'Salma',9087), (17,'Amanda',7777), (18,'Aamina',5500), (19,'Amina',2570), (20,'Ketty',2007)

select cast(CEILING(avg(cast(salary as float)) - avg(cast(replace(salary,0,'') as float))) as int) from @EMployees

/* Hackerrank accepted solution:
select cast(CEILING(avg(cast(salary as float)) - avg(cast(replace(salary,0,'') as float))) as int) from employees
Output: 2253
*/
