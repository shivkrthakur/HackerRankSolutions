/* OLLIVANDER'S INVENTORY */
/*
Harry Potter and his friends are at Ollivander's with Ron, finally replacing Charlie's old broken wand.
Hermione decides the best way to choose is by determining the minimum number of gold galleons needed to buy each non-evil wand of high power and age. 
Write a query to print the id, age, coins_needed, and power of the wands that Ron's interested in, sorted in order of descending power. 
If more than one wand has same power, sort the result in order of descending age.
*/
Declare @Wands Table (ID int, Code int, coins_Needed int, Power int) insert into @Wands Values (1,4,3688,8),(2,3,9365,3),(3,3,7187,10),(4,3,734,8),(5,1,6020,2),(6,2,6773,7),(7,3,9873,9),
(8,3,7721,7),(9,1,1647,10),(10,4,504,5),(11,2,7587,5),(12,5,9897,10),(13,3,4651,8),(14,2,5408,1),(15,2,6108,7),(16,4,7710,5),(17,2,8798,7),(18,2,3312,3),(19,4,7651,6),(20,5,5689,3)
Declare @Wands_Property Table (Code int, Age int, Is_evil int) Insert into @Wands_Property Values (1,45,0),(2,40,0),(3,4,1),(4,20,0),(5,17,0)

--select * from @Wands
--select * from @Wands_Property

select w.id, wp.age, w.coins_needed, w.power 
from @Wands w inner join @Wands_Property wp on w.code = wp.code
inner join (
                select wp.age as Age, w.power, min(w.coins_needed) as MinCoins 
                from @Wands w inner join @Wands_Property wp on w.code = wp.code
                where wp.is_evil = 0
                group by wp.age, w.power
                --order by 1 desc, 2 desc
            )x
on wp.age = x.Age and w.power = x.power and w.Coins_needed = x.MinCoins
where wp.is_evil = 0
order by power desc, age desc 

/* Hackerrank accepted solution:
select w.id, wp.age, w.coins_needed, w.power 
from Wands w inner join wands_property wp on w.code = wp.code
inner join (
                select wp.age as Age, w.power, min(w.coins_needed) as MinCoins 
                from Wands w inner join wands_property wp on w.code = wp.code
                where wp.is_evil = 0
                group by wp.age, w.power
            )x
on wp.age = x.Age and w.power = x.power and w.Coins_needed = x.MinCoins
where wp.is_evil = 0
order by power desc, age desc 
*/