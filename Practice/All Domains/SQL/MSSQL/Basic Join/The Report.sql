/* THE REPORT
You are given two tables: Students and Grades. Students contains three columns ID, Name and Marks.

Ketty gives Eve a task to generate a report containing three columns:  Name, Grade and Mark. Ketty doesn't want the NAMES of those students who received a grade lower than 8. 
The report must be in descending order by grade -- i.e. higher grades are entered first. If there is more than one student with the same grade (1-10) assigned to them, 
order those particular students by their name alphabetically. 
Finally, if the grade is lower than 8, use "NULL" as their name and list them by their marks in ascending order.

Write a query to help Eve.

select "(" + Convert(Varchar(3),Id) + ",'" + Name + "'," + Convert(Varchar(3), Marks) + ")," from Students
select "(" + Convert(Varchar(3),Grade) + "," + Convert(Varchar(3), Min_Mark) + "," + Convert(Varchar(3), Max_Mark) + ")," from Grades
*/
Declare @Students Table (ID int, Name varchar(20), Marks int) Insert into @Students Values (19,'Samantha',87), (21,'Julia',96), (11,'Britney',95), (32,'Kristeen',100), (12,'Dyana',55), (13,'Jenny',66), (14,'Christene',88), (15,'Meera',24), 
(16,'Priya',76), (17,'Priyanka',77), (18,'Paige',74), (19,'Jane',64), (21,'Belvet',78), (31,'Scarlet',80), (41,'Salma',81), (51,'Amanda',34), (61,'Heraldo',94), (71,'Stuart',99), (81,'Aamina',77), (76,'Amina',89), (91,'Vivek',84)
Declare @Grades Table (Grade Int, Min_Mark int, Max_Mark int) Insert into @Grades Values (1,0,9), (2,10,19), (3,20,29), (4,30,39), (5,40,49), (6,50,59), (7,60,69), (8,70,79), (9,80,89), (10,90,100)

select s.Name, G.Grade, S.Marks 
from @Students s
inner join @Grades g
on s.marks >= Min_Mark and s.marks <= Max_Mark
where g.Grade > 7
order by 2 desc, 1

select NULL as Name, G.Grade, S.Marks 
from @Students s
inner join @Grades g
on s.marks >= Min_Mark and s.marks <= Max_Mark
where g.Grade < 8
order by 2 desc, 3

/* HackerRank accepted solution:
select s.Name, G.Grade, S.Marks 
from Students s
inner join Grades g
on s.marks >= Min_Mark and s.marks <= Max_Mark
where g.Grade > 7
order by 2 desc, 1

select NULL as Name, G.Grade, S.Marks 
from Students s
inner join Grades g
on s.marks >= Min_Mark and s.marks <= Max_Mark
where g.Grade < 8
order by 2 desc, 3
*/