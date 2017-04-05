declare @Projects Table (Task_Id Int, Start_Date DateTime, End_Date DateTime)
--Same Data for the problem
insert into @Projects Values (1,'2015-10-01','2015-10-02'), (2,'2015-10-02','2015-10-03'), (3,'2015-10-03','2015-10-04'), (4,'2015-10-13','2015-10-14'), (5,'2015-10-14','2015-10-15'), (6,'2015-10-28','2015-10-29'), (7,'2015-10-30','2015-10-31')
/* Actual data extracted using the following sql
Select "(" + Convert(Varchar(10),Task_Id) + ",'" + Convert(Varchar(15),start_date) + "','" + Convert(Varchar(15),End_Date) + "')," from Projects

Values (1,'2015-10-01','2015-10-02'), (24,'2015-10-02','2015-10-03'), (2,'2015-10-03','2015-10-04'), (23,'2015-10-04','2015-10-05'), (3,'2015-10-11','2015-10-12'), 
(22,'2015-10-12','2015-10-13'), (4,'2015-10-15','2015-10-16'), (21,'2015-10-17','2015-10-18'), (5,'2015-10-19','2015-10-20'), (20,'2015-10-21','2015-10-22'), (6,'2015-10-25','2015-10-26'), 
(19,'2015-10-26','2015-10-27'), (7,'2015-10-27','2015-10-28'), (18,'2015-10-28','2015-10-29'), (8,'2015-10-29','2015-10-30'), (17,'2015-10-30','2015-10-31'), (9,'2015-11-01','2015-11-02'), 
(16,'2015-11-04','2015-11-05'), (10,'2015-11-07','2015-11-08'), (15,'2015-11-06','2015-11-07'), (11,'2015-11-05','2015-11-06'), (14,'2015-11-11','2015-11-12'), (12,'2015-11-12','2015-11-13'), (13,'2015-11-17','2015-11-18')
*/
/*
select RowId = ROW_NUMBER() Over (order by Start_Date), Task_Id, Start_Date, End_Date from @Projects where Start_Date not in (Select End_Date from @Projects)

select	RowId = ROW_NUMBER() Over (order by Start_Date)
	,   RankId = Rank() Over (order by Start_Date)
	,   RankId = Dense_Rank() Over (order by Start_Date)
	,	Task_Id
	,	Start_Date
	,	End_Date 
from @Projects 
where Start_Date not in (Select End_Date from @Projects)
*/
select * from @Projects order by Start_Date;

With ProjectsCte (Start_Date, End_Date)
As
(
	select Start_Date, End_Date from @Projects where Start_Date not in (Select End_Date from @Projects)
	union All
	select pc.Start_Date, p.End_Date from @Projects p inner join ProjectsCte pc on p.Start_Date = pc.End_Date
)
--select * from ProjectsCte
select Start_Date, Max(End_Date) as End_Date, Count(End_Date) as Days from ProjectsCte group by Start_Date 
order by Count(End_Date), Start_Date

/* HackerRank accepted answer below:
With ProjectsCte (Start_Date, End_Date)
As
(
	select Start_Date, End_Date from Projects where Start_Date not in (Select End_Date from Projects)
	union All
	select pc.Start_Date, p.End_Date from Projects p inner join ProjectsCte pc on p.Start_Date = pc.End_Date
)
select Start_Date, Max(End_Date) as End_Date from ProjectsCte group by Start_Date 
order by Count(End_Date), Start_Date
*/



