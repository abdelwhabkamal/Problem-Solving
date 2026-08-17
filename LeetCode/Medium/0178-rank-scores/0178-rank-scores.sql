/* Write your T-SQL query statement below */
select s1.score ,
dense_rank() over (order by s1.score desc) As rank from scores s1