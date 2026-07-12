/* Write your T-SQL query statement below */
select sell_date , Count(Distinct(product)) as num_sold , 
STRING_AGG(product, ',') WITHIN GROUP (ORDER BY product) as products 
from (select Distinct sell_date , product from activities) a
group by sell_date 
ORDER BY sell_date