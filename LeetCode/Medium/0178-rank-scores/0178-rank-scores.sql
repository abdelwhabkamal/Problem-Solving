/* Write your T-SQL query statement below */
select s1.score ,  (
select count ( distinct s2.score) from scores s2
where s1.score <= s2.score
) As rank from scores s1
order by s1.score desc