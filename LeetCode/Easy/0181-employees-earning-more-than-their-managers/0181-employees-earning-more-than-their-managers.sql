/* Write your T-SQL query statement below */
select employee.name as Employee from Employee e
left join employee on e.id = employee.managerId 
where employee.salary > e.salary