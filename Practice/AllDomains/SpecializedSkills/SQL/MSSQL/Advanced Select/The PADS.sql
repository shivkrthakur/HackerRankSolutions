/*
select "('" + Name + "','" + Occupation + "')," from Occupations
Generate the following two result sets:

Query an alphabetically ordered list of all names in OCCUPATIONS, immediately followed by the first letter of each profession as a parenthetical (i.e.: enclosed in parentheses). For example: AnActorName(A), ADoctorName(D), AProfessorName(P), and ASingerName(S).
Query the number of ocurrences of each occupation in OCCUPATIONS. Sort the occurrences in ascending order, and output them in the following format: 

There are total [occupation_count] [occupation]s.
where [occupation_count] is the number of occurrences of an occupation in OCCUPATIONS and [occupation] is the lowercase occupation name. If more than one Occupation has the same [occupation_count], they should be ordered alphabetically.

Note: There will be at least two entries in the table for each type of occupation.*/
Declare @Occupations Table (Name Varchar(20), Occupation Varchar(50))
insert into @Occupations Values ('Ashley','Professor'), ('Samantha','Actor'), ('Julia','Doctor'), ('Britney','Professor'), ('Maria','Professor'), ('Meera','Professor'), ('Priya','Doctor'), 
('Priyanka','Professor'), ('Jennifer','Actor'), ('Ketty','Actor'), ('Belvet','Professor'), ('Naomi','Professor'), ('Jane','Singer'), ('Jenny','Singer'), ('Kristeen','Singer'), ('Christeen','Singer'), ('Eve','Actor'), ('Aamina','Doctor')

--select * from @Occupations

select Name + '(' + left(occupation,1) + ')' from @OCCUPATIONS order by name;

select 'There are total ' + Cast(Count(Occupation) as Varchar(5)) + ' ' + lower(Occupation) + 's.'
from @Occupations
group by Occupation
order by count(occupation), occupation;