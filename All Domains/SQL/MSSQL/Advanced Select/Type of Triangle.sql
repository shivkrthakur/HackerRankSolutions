/*
select "(" + Convert(Varchar(3),A) + "," + Convert(Varchar(3),B) + ","+ Convert(Varchar(3),C) +  ")" from Triangles
Write a query identifying the type of each record in the TRIANGLES table using its three side lengths. Output one of the following statements for each record in the table:

Not A Triangle: The given values of A, B, and C don't form a triangle.
Equilateral: It's a triangle with 3 sides of equal length.
Isosceles: It's a triangle with 2 sides of equal length.
Scalene: It's a triangle with 3 sides of differing lengths.
*/

Declare @Triangles Table (A int, B int, C int)
insert into @Triangles Values (10,10,10),(11,11,11), (30,32,30), (40,40,40), (20,20,21), (21,21,21), (20,22,21), (20,20,40), (20,22,21), (30,32,41), (50,22,51), (20,12,61), (20,22,50), (50,52,51), (80,80,80)
--select * from @Triangles

SELECT
    --A, B, C,
    CASE WHEN A + B > C AND A + C > B AND B + C > A THEN
        CASE 
             WHEN A <> B AND B <> C AND C <> A THEN 'Scalene'
             WHEN A = B AND B = C AND C = A THEN 'Equilateral'
             WHEN A = B OR B = C OR C = A THEN 'Isosceles'
        END
    ELSE
        'Not A Triangle'
    END
FROM @Triangles;

