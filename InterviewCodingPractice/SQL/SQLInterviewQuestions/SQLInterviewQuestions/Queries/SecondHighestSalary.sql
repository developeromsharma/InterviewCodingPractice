/*SQL QUERY */

Select top 1*
from
(
	select top 2 salary
	employess
	order by salary desc
)
as innerQuery
order by salary asc;

/*LINQ QUERY 

var secondHighestSalary = employees
	.Select(e => e.Salary)
	.Distinct()
	.OrderByDescending(s => s)
	.Skip(1)
	.FirstOrDefault();

	*/