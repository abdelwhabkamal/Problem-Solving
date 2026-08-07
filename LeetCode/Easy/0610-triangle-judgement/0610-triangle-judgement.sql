/* Write your T-SQL query statement below */
select x, y, z, case 
    when z < x + y and x < y + z and y < x + z then 'Yes'
    else 'No'
    end
    as triangle
from triangle