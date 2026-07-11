/* Write your T-SQL query statement below */
select product_name , year , price from sales 
inner join product on product.product_id = sales.product_id; 