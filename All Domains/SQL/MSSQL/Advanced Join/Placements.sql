/* PLACEMENTS
You are given three tables: Students, Friends and Packages. Students contains two columns: ID and Name. Friends contains two columns: ID and Friend_ID (ID of the ONLY best friend). 
Packages contains two columns: ID and Salary (offered salary in $ thousands per month). Write a query to output the names of those students whose best friends got offered a higher salary than them. 
Names must be ordered by the salary amount offered to the best friends. It is guaranteed that no two students got same salary offer.

select "(" + convert(varchar(2), ID) + ",'" + Name +"')," from Students 
select "(" + convert(varchar(2), ID) + "," + convert(varchar(2), Friend_ID) + ")," from Friends 
select "(" + convert(varchar(2), ID) + "," +  + convert(varchar(10), Salary) + ")," from Packages
*/

Declare @Students Table (Id int, Name Varchar(20)) INsert into @Students Values (1,'Samantha'), (2,'Julia'), (3,'Britney'), (4,'Kristeen'), (5,'Dyana'), (6,'Jenny'), (7,'Christene'), (8,'Meera'), (9,'Priya'), (10,'Priyanka'), (11,'Paige'), (12,'Jane'), (13,'Belvet'), (14,'Scarlet'), (15,'Salma'), (16,'Amanda'), (17,'Maria'), (18,'Stuart'), (19,'Aamina'), (20,'Amina')
Declare @Friends Table (Id int, Friend_Id Int) INsert into @Friends Values (1,14), (2,15), (3,18), (4,19), (5,20), (6,5), (7,6), (8,7), (9,8), (10,1), (11,2), (12,3), (13,4), (14,9), (15,10), (16,11), (17,12), (18,13), (19,16), (20,17)
Declare @Packages Table (Id int, Salary float) INsert into @Packages Values (1,15.5), (2,15.6), (3,16.7), (4,18.8), (5,31.5), (6,45), (7,47), (8,46), (9,39), (10,11.1), (11,12.1), (12,13.1), (13,14.1), (14,15.1), (15,17.1), (16,21.1), (17,31.1), (18,13.15), (19,33.33), (20,22.16)

--select * from @Students
--select * from @Friends
--select * from @Packages
select S1.Name
from @Students s1 
inner join @Packages p1 on s1.Id = p1.Id
inner join @Friends f on s1.id = f.Id
inner join @Students s2 on f.Friend_Id = s2.Id
inner join @Packages p2 on s2.id = p2.Id
where p1.Salary < p2.Salary
order by p2.Salary 

/* Hackerrank accepted solution below:
select S1.Name
from Students s1 
inner join Packages p1 on s1.Id = p1.Id
inner join Friends f on s1.id = f.Id
inner join Students s2 on f.Friend_Id = s2.Id
inner join Packages p2 on s2.id = p2.Id
where p1.Salary < p2.Salary
order by p2.Salary 
*/