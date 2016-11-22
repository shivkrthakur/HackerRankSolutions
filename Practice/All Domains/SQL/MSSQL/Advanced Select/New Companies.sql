/*

Amber's conglomerate corporation just acquired some new companies. Each of the companies follows this hierarchy: 
Given the table schemas below, write a query to print the company_code, founder name, total number of lead managers, total number of senior managers, 
total number of managers, and total number of employees. Order your output by ascending company_code.
Note:
The tables may contain duplicate records. The company_code is string, so the sorting should not be alphanumeric. 
For example, if the company_codes are C_1, C_2, and C_10, then the ascending company_codes will be C_1, C_10, and C_2.
*/
declare @Company Table (Company_Code varchar(5), Founder varchar(10))
declare @Lead_Manager Table (Lead_Manager_Code varchar(5), Company_Code varchar(5))
declare @Senior_Manager Table (Senior_Manager_Code varchar(5), Lead_Manager_Code varchar(5), Company_Code varchar(5))
declare @Manager Table (Manager_Code varchar(5), Senior_Manager_Code varchar(5), Lead_Manager_Code varchar(5), Company_Code varchar(5))
declare @Employee Table (Employee_Code varchar(5), Manager_Code varchar(5), Senior_Manager_Code Varchar(5), Lead_Manager_Code varchar(5), Company_Code varchar(5))

--SAMPLE DATA
insert into @Company Values ('C1','Monika'),('C2','Samantha')
insert into @Lead_Manager Values ('LM1','C1'),('LM2','C2')
insert into @Senior_Manager Values ('SM1','LM1','C1'),('SM2','LM1','C1'),('SM3','LM2','C2')
insert into @Manager Values ('M1','SM1','LM1','C1'),('M2','SM3','LM2','C2'),('M3','SM3','LM2','C2')
insert into @Employee Values ('E1','M1','SM1','LM1','C1'), ('E2','M1','SM1','LM1','C1'), ('E3','M2','SM3','LM2','C2'), ('E4','M3','SM3','LM2','C2')

select c.Company_Code, Founder, Count(distinct LM.Lead_Manager_Code), Count(distinct SM.Senior_Manager_Code), Count(distinct M.Manager_Code), Count(distinct E.Employee_Code) 
from @company c inner join @Lead_Manager LM on c.Company_Code = LM.Company_Code
inner join @Senior_Manager SM on C.Company_COde = SM.COmpany_Code 
    and SM.Lead_manager_code = LM.LEad_manager_Code
inner join @Manager M on C.Company_Code = M.Company_Code 
    and M.Lead_Manager_Code = LM.LEad_Manager_Code
    and M.Senior_Manager_Code = SM.SEnior_Manager_Code
inner join @EMployee E on C.Company_Code = E.Company_Code 
    and E.Lead_Manager_Code = M.LEad_Manager_Code 
    and E.Senior_Manager_Code = M.Senior_Manager_Code 
    and E.Manager_Code = M.Manager_Code
group by c.Company_Code, Founder
order by 1

/*Hacker Rank Accepted Answer below
select c.Company_Code, Founder, Count(distinct LM.Lead_Manager_Code), Count(distinct SM.Senior_Manager_Code), Count(distinct M.Manager_Code), Count(distinct E.Employee_Code) 
from company c inner join Lead_Manager LM on c.Company_Code = LM.Company_Code
inner join Senior_Manager SM on C.Company_COde = SM.COmpany_Code 
    and SM.Lead_manager_code = LM.LEad_manager_Code
inner join Manager M on C.Company_Code = M.Company_Code 
    and M.Lead_Manager_Code = LM.LEad_Manager_Code
    and M.Senior_Manager_Code = SM.SEnior_Manager_Code
inner join EMployee E on C.Company_Code = E.Company_Code 
    and E.Lead_Manager_Code = M.LEad_Manager_Code 
    and E.Senior_Manager_Code = M.Senior_Manager_Code 
    and E.Manager_Code = M.Manager_Code
group by c.Company_Code, Founder
order by 1
*/


