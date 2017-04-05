/*SYMMETRIC PAIRS*/
/*
You are given a table, Functions, containing two columns: X and Y. Y is the value of some function F at X -- i.e. Y = F(X).
Two pairs (X1, Y1) and (X2, Y2) are said to be symmetric pairs if X1 = Y2 and X2 = Y1. Write a query to output all such symmetric pairs in ascending order by the value of X.
--select "(" + convert(varchar(5), X) + "," + convert(varchar(5), Y) + ")," from Functions order by 1
*/

declare @Functions Table (X int, Y int)
insert into @Functions Values (1,1), (10,10), (100,100), (11,11), (11,15), (12,12), (13,13), (13,13), (14,12), (14,14), (15,11), (15,15), (16,10), (16,16), (17,17), (17,9), (18,18), (18,8), (19,19), (2,2), (2,24), 
(20,20), (20,6), (21,21), (21,5), (22,22), (22,4), (23,23), (23,3), (24,2), (24,24), (25,1), (25,25), (26,26), (27,27), (28,28), (29,29), (3,3), (30,30), (31,31), (32,32), (33,33), (34,34), (35,35), (36,36), (37,37), 
(38,38), (39,39), (4,22), (4,4), (40,40), (41,41), (42,42), (43,43), (44,44), (45,45), (46,46), (47,47), (48,48), (49,49), (5,21), (5,5), (50,50), (51,51), (52,52), (53,53), (54,54), (55,55), (56,56), (58,58), (59,59), 
(6,20), (6,6), (60,60), (61,61), (62,62), (63,63), (64,64), (65,65), (66,66), (67,67), (68,68), (69,69), (7,19), (7,7), (71,71), (72,72), (73,73), (74,74), (75,75), (76,76), (77,77), (78,78), (79,79), (8,18), (8,8), (80,80), 
(81,81), (83,83), (84,84), (85,85), (86,86), (87,87), (88,88), (89,89), (9,17), (9,9), (90,90), (91,91), (92,92), (93,93), (94,94), (95,95), (96,96), (97,97), (98,98), (99,99)

--select * from @Functions

select distinct F1.X, F1.Y 
from (select *, ROW_NUMBER() OVER (order by X) As RowNum from @Functions) F1 
inner join (select *, ROW_NUMBER() OVER (order by X) As RowNum from @Functions) F2 
on F1.X = F2.Y and F1.Y = F2.X and F1.X <= F1.Y and F1.RowNum <> F2.RowNum order by F1.X

/* Hackerrank accepted solution below: 
select distinct F1.X, F1.Y from (select *, ROW_NUMBER() OVER (order by X) As RowNum from Functions) F1 
inner join (select *, ROW_NUMBER() OVER (order by X) As RowNum from Functions) F2 
on F1.X = F2.Y and F1.Y = F2.X and F1.X <= F1.Y and F1.RowNum <> F2.RowNum
order by F1.X
*/