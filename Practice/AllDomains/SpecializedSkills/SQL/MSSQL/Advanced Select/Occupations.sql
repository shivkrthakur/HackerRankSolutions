/*select "('" + Name + "','" + Occupation + "')," from Occupations

Pivot the Occupation column in OCCUPATIONS so that each Name is sorted alphabetically and displayed underneath its corresponding Occupation. The output column headers should be Doctor, Professor, Singer, and Actor, respectively.
Note: Print NULL when there are no more names corresponding to an occupation.
*/
Declare @Occupations Table (Name Varchar(20), Occupation Varchar(50))
insert into @Occupations Values ('Ashley','Professor'), ('Samantha','Actor'), ('Julia','Doctor'), ('Britney','Professor'), ('Maria','Professor'), ('Meera','Professor'), ('Priya','Doctor'), 
('Priyanka','Professor'), ('Jennifer','Actor'), ('Ketty','Actor'), ('Belvet','Professor'), ('Naomi','Professor'), ('Jane','Singer'), ('Jenny','Singer'), ('Kristeen','Singer'), ('Christeen','Singer'), ('Eve','Actor'), ('Aamina','Doctor')

--select * from @Occupations

select [Doctor],[Professor],[Singer],[Actor] from (select Name, Occupation, ROW_NUMBER() over(partition by occupation order by name) as RN from @Occupations) source
pivot (Max(Name) for Occupation in ([Doctor],[Professor],[Singer],[Actor])) as PivotTable 
