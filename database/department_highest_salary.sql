SELECT d.Name,e.Name,a.Salary FROM (select max(Salary) as Salary,DepartmentId from Employee group by DepartmentId) a ,Department d,Employee e where a.DepartmentId = e.DepartmentId and a.Salary = e.Salary and e.DepartmentId = d.Id