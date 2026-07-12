/* Write your T-SQL query statement below */
select name , sum(amount) as balance from users inner join transactions on users.account = transactions.account
group by name
having sum(amount) > 10000