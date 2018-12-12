/*
select "(" + Convert(varchar(3),isnull(N,0)) + "," + Convert(varchar(3),isnull(P,0)) + ")," from BST

You are given a table, BST, containing two columns: N and P, where N represents the value of a node in BST, and P is the parent of N.
Write a query to find the node type of BST ordered by the value of the node. Output one of the following for each node:

Root: If node is root node.
Leaf: If node is leaf node.
Inner: If node is neither root nor leaf node.*/

declare @BST Table(N int, P int)
insert into @BST Values (1,2), (3,2), (5,6), (7,6), (2,4), (6,4), (4,15), (8,9), (10,9), (12,13), (14,13), (9,11), (13,11), (11,15), (15,0)

select  N
    ,   Case 
            WHEN P = 0 THEN 'Root'
            WHEN not exists (select N from @BST where P = B1.N ) THEN 'Leaf'
            WHEN exists(select N from @BST where P = B1.N) THEN  'Inner'
        END  
from @BST B1
order by N;
