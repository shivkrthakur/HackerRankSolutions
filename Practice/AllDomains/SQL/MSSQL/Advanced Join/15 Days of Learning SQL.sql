declare @Hackers Table (Hacker_Id int, Name varchar(20)) insert into @Hackers Values (15758,'Rose'),(20703,'Angela'),(36396,'Frank'),(38289,'Patrick'),(44065,'Lisa'),(53473, 'Kimberly'),(62529, 'Bonnie'),(79722,'Michael')
declare @Submissions Table (Submission_Date DateTime, Submission_Id Int, Hacker_Id int, score int)
insert into @Submissions Values ('2016-03-01',8494,20703, 0),('2016-03-01',22403,53473,15),('2016-03-01',23965,79722, 60),('2016-03-01',30173,36396,70),('2016-03-02',34928,20703, 0),('2016-03-02',38740,15758,60),('2016-03-02',42769,79722, 25),('2016-03-02',44364,79722,60),('2016-03-03',45440,20703, 0),('2016-03-03',49050,36396,70)
,('2016-03-03',50273,79722, 5),('2016-03-04',50344,20703,0),('2016-03-04',51360,44065, 90),('2016-03-04',54404,53473,65),('2016-03-04',61533,79722, 45),('2016-03-05',72852,20703,0),('2016-03-05',74546,38289,0),('2016-03-05',76487,62529,0),('2016-03-05',82439,36396,10),('2016-03-05',90006,36396,40),('2016-03-06',90404,20703,0)

--select * from @Hackers
--select * from @Submissions
;

With SubmissionsCte (Submission_Date, Hacker_Id, DC)
As
(
	select Submission_Date, Hacker_Id, DC = 1 from @Submissions where Submission_Date = (Select Min(Submission_Date) from @Submissions)
	union all 
	select S1.Submission_Date, S1.Hacker_Id, DC = 1 from @Submissions S1 inner join SubmissionsCte sc on s1.hacker_Id = sc.Hacker_Id 
	and S1.Submission_Date = DateAdd(D,1,Sc.Submission_Date)
)

Select X.Submission_Date, Y.UHackerCount, x.Hacker_Id, H.Name 
from @Hackers H
inner join (
			select	Min(T2.Hacker_Id) as Hacker_Id
				,	T2.Submission_Date
				,	T2.DC
			from (select s.Submission_Date, s.Hacker_Id, DC = Count(s.Submission_Id) from @Submissions s group by s.Submission_Date, s.Hacker_Id) T2
			inner join (	
							select T1.Submission_Date, Max(T1.Dc) as DC from (select s.Submission_Date, s.Hacker_Id, DC = Count(s.Submission_Id) from @Submissions s group by s.Submission_Date, s.Hacker_Id) T1
							group by T1.Submission_Date
						) T3
			on T2.Submission_Date = T3.Submission_Date and T2.DC = T3.DC
			group by T2.Submission_Date, T2.DC
		 ) X  on H.Hacker_Id = X.Hacker_Id
inner join (
			 select Submission_Date, Count(Distinct Hacker_Id) as UHackerCount
			 from SubmissionsCte 
			 group by Submission_Date
		   ) Y on X.Submission_Date = Y.Submission_Date
order by 1

/* Hacker Rank Accepted Answer below:
With SubmissionsCte (Submission_Date, Hacker_Id, DC)
As
(
	select Submission_Date, Hacker_Id, DC = 1 from Submissions where Submission_Date = (Select Min(Submission_Date) from Submissions)
	union all 
	select S1.Submission_Date, S1.Hacker_Id, DC = 1 from Submissions S1 inner join SubmissionsCte sc on s1.hacker_Id = sc.Hacker_Id 
	and S1.Submission_Date = DateAdd(D,1,Sc.Submission_Date)
)

Select X.Submission_Date, Y.UHackerCount, x.Hacker_Id, H.Name 
from Hackers H
inner join (
			select	Min(T2.Hacker_Id) as Hacker_Id
				,	T2.Submission_Date
				,	T2.DC
			from (select s.Submission_Date, s.Hacker_Id, DC = Count(s.Submission_Id) from Submissions s group by s.Submission_Date, s.Hacker_Id) T2
			inner join (	
							select T1.Submission_Date, Max(T1.Dc) as DC from (select s.Submission_Date, s.Hacker_Id, DC = Count(s.Submission_Id) from Submissions s group by s.Submission_Date, s.Hacker_Id) T1
							group by T1.Submission_Date
						) T3
			on T2.Submission_Date = T3.Submission_Date and T2.DC = T3.DC
			group by T2.Submission_Date, T2.DC
		 ) X  on H.Hacker_Id = X.Hacker_Id
inner join (
			 select Submission_Date, Count(Distinct Hacker_Id) as UHackerCount
			 from SubmissionsCte 
			 group by Submission_Date
		   ) Y on X.Submission_Date = Y.Submission_Date
order by 1
*/