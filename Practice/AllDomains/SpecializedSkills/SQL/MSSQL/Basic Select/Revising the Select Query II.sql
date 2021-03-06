/*select '(' + convert(varchar(10),ID) + ",'" + Name + "','" + CountryCode + "','" + District + "'," + Convert(varchar(20),Population) + "),"  from City*/
declare @City Table (Id int, Name Varchar(17), CountryCOde varchar(3), District Varchar(20), Population int)
insert into @City Values (6,'Rotterdam','NLD','Zuid-Holland',593321), 
(3878,'Scottsdale','USA','Arizona',202705), 
(3965,'Corona','USA','California',124966), 
(3973,'Concord','USA','California',121780), 
(3977,'Cedar Rapids','USA','Iowa',120758), 
(3982,'Coral Springs','USA','Florida',117549), 
(4054,'Fairfield','USA','California',92256), 
(4058,'Boulder','USA','Colorado',91238), 
(4061,'Fall River','USA','Massachusetts',90555)

select Name from @City where population > 120000 and countrycode = 'USA';