/* INTERVIEWs
Samantha interviews many candidates from different colleges using coding challenges and contests. Write a query to print the contest_id, hacker_id, name, and the sums of total_submissions, total_accepted_submissions, total_views, and total_unique_views for each contest sorted by contest_id. Exclude the contest from the result if all four sums are 0.
Note: A specific contest can be used to screen candidates at more than one college, but each college only holds screening contest.
*/
declare @Contests Table (Contest_Id int, Hacker_Id int, Name Varchar(20)) insert into @Contests Values (64406,17973, 'Rose'), (66556, 79153, 'Angela'),(94828,80275,'Frank')
declare @Colleges Table (College_Id int, Contest_Id int) insert into @Colleges Values (11219,64406), (32473,66556),(56685,94828)
declare @Challenges Table (Challenge_Id int, College_Id int) insert into @Challenges Values (18765,11219),(47127,11219), (60292,32473),(72974,56685)
declare @View_Stats Table (CHallenge_Id int, Total_VIews int, Total_Unique_Views int) insert into @View_Stats Values (47127,26,19),(47127,15,14),(18765,43,10),(18765,72,13),(18765,72,13),(18765,72,13),(75516,35,17),(60292,11,10),(72974,41,15),(75516,75,11)
declare @Submission_Stats Table (Challenge_Id int, total_Submissions int, Total_Accepted_Submissions int) insert into @Submission_Stats Values (75516,34,12),(47127,27,10),(47127,56,18),(75516,74,12),(75516,83,8),(72974,68,24),(72974,82,14),(47127,28,11)

--select * from @Contests
--select * from @Colleges
--select * from @Challenges
--select * from @View_Stats
--select * from @Submission_Stats

select con.Contest_Id, con.Hacker_id, con.Name, x.TSub, x.TASub, x.TV, x.TUV 
from @Contests Con inner join 
( select T1.Contest_Id, isnull(T1.TSub,0) as TSub, isnull(T1.TASub,0) as TASub, isnull(T2.TV,0) as TV, isnull(T2.TUV,0) as TUV from (
				select Col.Contest_Id, TSub = Sum(Ss.Total_Submissions), TASub = Sum(Ss.Total_Accepted_Submissions)
				from @Colleges Col inner join @Challenges Ch on col.College_Id = ch.College_Id
				left outer join @Submission_Stats Ss on ch.Challenge_Id = Ss.Challenge_Id
				group by Col.Contest_Id
			) T1 --order by 1,2
inner join (
				select Col.Contest_Id, TV = Sum(Vs.Total_Views), TUV=Sum(Vs.Total_Unique_Views)
				from @Colleges Col inner join @Challenges Ch on col.College_Id = ch.College_Id
				left join @View_Stats Vs on ch.Challenge_Id = Vs.Challenge_Id
				group by Col.Contest_Id
			) T2 --order by 1,2
on T1.Contest_Id = T2.Contest_Id) x
on x.Contest_Id = Con.Contest_Id 

/* Hackerrank accepted solution below:
select con.Contest_Id, con.Hacker_id, con.Name, x.TSub, x.TASub, x.TV, x.TUV 
from Contests Con inner join 
( select T1.Contest_Id, isnull(T1.TSub,0) as TSub, isnull(T1.TASub,0) as TASub, isnull(T2.TV,0) as TV, isnull(T2.TUV,0) as TUV from (
				select Col.Contest_Id, TSub = Sum(Ss.Total_Submissions), TASub = Sum(Ss.Total_Accepted_Submissions)
				from Colleges Col inner join Challenges Ch on col.College_Id = ch.College_Id
				left outer join Submission_Stats Ss on ch.Challenge_Id = Ss.Challenge_Id
				group by Col.Contest_Id
			) T1 --order by 1,2
inner join (
				select Col.Contest_Id, TV = Sum(Vs.Total_Views), TUV=Sum(Vs.Total_Unique_Views)
				from Colleges Col inner join Challenges Ch on col.College_Id = ch.College_Id
				left join View_Stats Vs on ch.Challenge_Id = Vs.Challenge_Id
				group by Col.Contest_Id
			) T2 --order by 1,2
on T1.Contest_Id = T2.Contest_Id) x
on x.Contest_Id = Con.Contest_Id 
*/