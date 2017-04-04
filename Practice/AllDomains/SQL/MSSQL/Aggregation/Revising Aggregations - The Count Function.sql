/* REVISING AGGREGATIONS - THE COUNT FUNCTION */
/*
Query a count of the number of cities in CITY having a Population larger than 100,000.
select "(" + Convert(Varchar(5),ID) + ",'" + Name + "','" + CountryCode + "','" + District + "'," + Convert(varchar(10),Population) + ")," from City
*/
DECLARE @City Table (ID int, Name Varchar(20), CountryCode Varchar(5), District Varchar(20), Population int)
insert into @City Values (6,'Rotterdam','NLD','Zuid-Holland',593321), (3878,'Scottsdale','USA','Arizona',202705), (3965,'Corona','USA','California',124966), 
(3973,'Concord','USA','California',121780), (3977,'Cedar Rapids','USA','Iowa',120758), (3982,'Coral Springs','USA','Florida',117549), 
(4054,'Fairfield','USA','California',92256), (4058,'Boulder','USA','Colorado',91238), (4061,'Fall River','USA','Massachusetts',90555)

select count(distinct name) from @City where population > 100000

/* Hackerrank accepted solution
select count(distinct name) from city where population > 100000
Output: 6
*/
