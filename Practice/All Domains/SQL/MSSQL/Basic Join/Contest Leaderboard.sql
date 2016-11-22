/* CONTEST LEADERBOARD */
/*

You did such a great job helping Julia with her last coding contest challenge that she wants you to work on this one, too!
The total score of a hacker is the sum of their maximum scores for all of the challenges. 
Write a query to print the hacker_id, name, and total score of the hackers ordered by the descending score. 
If more than one hacker achieved the same total score, then sort the result by ascending hacker_id. 
Exclude all hackers with a total score of  from your result.
select "(" + Convert(Varchar(10),Submission_Id) + "," + Convert(Varchar(10),Hacker_Id) + "," + Convert(Varchar(10),Challenge_Id) + "," + Convert(Varchar(10),Score) + ")," from submissions order by 1
*/

declare @Hackers Table (Hacker_Id int, Name varchar(20))
insert into @Hackers Values (4071, 'Rose'), (4806,'Angela'),(26071,'Frank'),(49438,'Patrick'),(74842,'Lisa'),(80305,'Kimberly'),(84072,'Bonnie'),(87868,'Michael'),(92118,'Todd'),(95895,'Joe')
--select * from @Hackers

declare @Submissions Table (Submission_ID int, Hacker_Id int, Challenge_Id int, Score int)
insert into @Submissions Values (67194,74842,63132,76),(64479,74842,19797,98),(40742,26071,49593,20),(17513,4806,49593,32),(69846,80305,19797,19),(41002,26071,89343,36),(52826,49438,49593,9),
(31093,26071,19797,2),(81614,84072,49593,100),(44829,26071,89343,17),(75147,80305,49593,48),(14115,4806,49593,76),(6943,4071,19797,95),(12855,4806,25917,13),(73343,80305,49593,42),(84264,84072,63132,0),(9951,4071,49593,43),
(45104,49438,25917,34),(53795,74842,19797,5),(26363,26071,19797,29),(10063,4071,49593,96)
--select * from @Submissions

select H.Hacker_id, h.Name, sum(x.Score) 
from @Hackers h 
inner join (   
            select hacker_id, challenge_id, max(Score) as Score 
            from @Submissions 
            group by hacker_id, challenge_id
          ) x 
on H.Hacker_id = x.hacker_Id
group by H.Hacker_Id, h.Name
having sum(x.score) > 0
order by 3 desc, h.hacker_id

/* Hackerrank accepted solution:
select H.Hacker_id, h.Name, sum(x.Score) 
from hackers h 
inner join (   
            select hacker_id, challenge_id, max(Score) as Score 
            from Submissions 
            group by hacker_id, challenge_id
          ) x 
on H.Hacker_id = x.hacker_Id
group by H.Hacker_Id, h.Name
having sum(x.score) > 0
order by 3 desc, h.hacker_id
*/