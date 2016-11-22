/* select '(' + convert(varchar(10),ID) + ",'" + Name + "'," + Convert(varchar(20),Marks) + "),"  from Students Order by 1 */
/*
Query the Name of any student in STUDENTS who scored higher than 75 Marks. Order your output by the last three characters of each name. If two or more students both have names ending in the same last three characters (i.e.: Bobby, Robby, etc.), secondary sort them by ascending ID.
*/

declare @Students Table (ID int, Name Varchar(22), Marks int)
insert into @Students Values  (11,'Britney',95), (12,'Dyana',55), (13,'Jenny',66), (14,'Christene',88), (15,'Meera',24), (16,'Devil',76), (16,'Priya',76), (17,'Evil',79), (17,'Priyanka',77), (18,'Paige',74), 
(19,'Jane',64), (19,'Samantha',87), (21,'Belvet',78), (21,'Julia',96), (31,'Scarlet',80), (32,'Kristeen',100), (34,'Fanny',75), (38,'Danny',75), (41,'Salma',81), (51,'Amanda',34), (61,'Heraldo',94), (71,'Stuart',99), (76,'Amina',89), (81,'Aamina',77), (91,'Vivek',84)

select Name from @students where marks > 75 order by substring(Name,len(Name) -2, len(Name)), ID;