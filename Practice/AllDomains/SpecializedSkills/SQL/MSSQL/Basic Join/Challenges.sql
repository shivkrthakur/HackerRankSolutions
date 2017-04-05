/* CHALLENGES */
/*
Julia asked her students to create some coding challenges. Write a query to print the hacker_id, name, and the total number of challenges created by each student. 
Sort your results by the total number of challenges in descending order. 
If more than one student created the same number of challenges, then sort the result by hacker_id. 
If more than one student created the same number of challenges and the count is less than the maximum number of challenges created, then exclude those students from the result.

select "(" + Convert(Varchar(10),Challenge_Id) + "," + Convert(Varchar(10),Hacker_Id) + ")," from Challenges order by 1 
*/

declare @Hackers Table (Hacker_Id int, Name varchar(20))
insert into @Hackers Values (5077, 'Rose'), (21283,'Angela'),(62743,'Frank'),(88255,'Patrick'),(96196,'Lisa')
--select * from @Hackers

declare @Challenges Table (Challenge_ID int, Hacker_Id int)
insert into @Challenges Values (61654,5077),(58302,21283),(40587,88255),(29477,5077),(1220,21283),(69514,21283),(46561,62743),
(58077,62743),(18483,88255),(76766,21283),(52382,5077),(74467,21283),(33625,96196),(26053,88255),(42665,62743),(12859,62743),(70094,21283),
(34599,88255),(54680,88255),(61881,5077)
--select * from @Challenges

select C.Hacker_id, H.Name, count(challenge_id)
from @Hackers H Inner Join @Challenges C
ON H.Hacker_Id = C.Hacker_Id
group by C.Hacker_Id, H.Name
having count(challenge_id) not in (select x.ChallengeCount from (  
        select C.Hacker_id, H.Name, count(challenge_id) as ChallengeCount
        from @Hackers H Inner Join @Challenges C
        ON H.Hacker_Id = C.Hacker_Id
        group by C.Hacker_Id, H.Name
     ) x
where x.ChallengeCount <> (select top 1 count(challenge_id) from @Challenges group by hacker_Id order by 1 desc) 
group by x.ChallengeCount
having count(x.challengecount) > 1)
order by 3 desc, 1

/* Hackerrank accepted solution:
select C.Hacker_id, H.Name, count(challenge_id)
from Hackers H Inner Join Challenges C
ON H.Hacker_Id = C.Hacker_Id
group by C.Hacker_Id, H.Name
having count(challenge_id) not in (select x.ChallengeCount from (  
        select C.Hacker_id, H.Name, count(challenge_id) as ChallengeCount
        from Hackers H Inner Join Challenges C
        ON H.Hacker_Id = C.Hacker_Id
        group by C.Hacker_Id, H.Name
     ) x
where x.ChallengeCount <> (select top 1 count(challenge_id) from challenges group by hacker_Id order by 1 desc) 
group by x.ChallengeCount
having count(x.challengecount) > 1)
order by 3 desc, 1
*/