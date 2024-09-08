using AdvancedLINQConcepts;

// Create departments
var departments = new List<Department>
            {
                new Department { Id = 1, DepartmentName = "HR" },
                new Department { Id = 2, DepartmentName = "IT" },
                new Department { Id = 3, DepartmentName = "Finance" }
            };

// Create employees
var employees = new List<Employee>
            {
                new Employee { Id = 1, EmployeeName = "Alice", Salary = 60000, DepartmentId = 2, Department = departments[1], HireDate = new DateTime(2019, 1, 15) },
                new Employee { Id = 2, EmployeeName = "Bob", Salary = 80000, DepartmentId = 2, Department = departments[1], HireDate = new DateTime(2018, 6, 10) },
                new Employee { Id = 3, EmployeeName = "Charlie", Salary = 75000, DepartmentId = 3, Department = departments[2], HireDate = new DateTime(2017, 9, 20) },
                new Employee { Id = 4, EmployeeName = "David", Salary = 55000, DepartmentId = 1, Department = departments[0], HireDate = new DateTime(2020, 2, 1) },
                new Employee { Id = 5, EmployeeName = "Eve", Salary = 90000, DepartmentId = 2, Department = departments[1], HireDate = new DateTime(2016, 4, 5) }
            };

// Example 1: Filter employees with a salary above 70000 using a lambda expression
var highEarners = employees.Where(e => e.Salary > 70000);

Console.WriteLine("High Earners:");
foreach (var employee in highEarners)
{
    Console.WriteLine($"{employee.EmployeeName}, Salary: {employee.Salary:C}, Department: {employee.Department.DepartmentName}");
}

// Example 2: Sort employees by hire date using a lambda expression
var sortedByHireDate = employees.OrderBy(e => e.HireDate);

Console.WriteLine("\nEmployees Sorted by Hire Date:");
foreach (var employee in sortedByHireDate)
{
    Console.WriteLine($"{employee.EmployeeName}, Hire Date: {employee.HireDate.ToShortDateString()}, Department: {employee.Department.DepartmentName}");
}

// Example 3: Group employees by department using a LINQ expression
var groupedByDepartment = from e in employees
                          group e by e.Department.DepartmentName into departmentGroup
                          select new
                          {
                              DepartmentName = departmentGroup.Key,
                              Employees = departmentGroup
                          };

Console.WriteLine("\nEmployees Grouped by Department:");
foreach (var group in groupedByDepartment)
{
    Console.WriteLine($"Department: {group.DepartmentName}");
    foreach (var employee in group.Employees)
    {
        Console.WriteLine($"- {employee.EmployeeName}, Salary: {employee.Salary:C}");
    }
}

// Example 4: Project employees into a new anonymous type using LINQ
var employeeSummaries = employees.Select(e => new
{
    e.EmployeeName,
    e.Department.DepartmentName,
    e.Salary,
    HireYear = e.HireDate.Year
});

Console.WriteLine("\nEmployee Summaries:");
foreach (var summary in employeeSummaries)
{
    Console.WriteLine($"{summary.EmployeeName}, Department: {summary.DepartmentName}, Salary: {summary.Salary:C}, Hire Year: {summary.HireYear}");
}

// Example 5: Calculate the average salary by department using a LINQ expression
var averageSalaryByDepartment = from e in employees
                                group e by e.Department.DepartmentName into departmentGroup
                                select new
                                {
                                    DepartmentName = departmentGroup.Key,
                                    AverageSalary = departmentGroup.Average(emp => emp.Salary)
                                };

Console.WriteLine("\nAverage Salary by Department:");
foreach (var department in averageSalaryByDepartment)
{
    Console.WriteLine($"Department: {department.DepartmentName}, Average Salary: {department.AverageSalary:C}");
}

// Example 6: Check if any employee is earning more than $90,000
bool anyHighEarners = employees.Any(e => e.Salary > 90000);
Console.WriteLine("\nAny Employee Earning More Than $90,000: " + anyHighEarners);

// Example 7: Check if all employees in IT department earn more than $50,000
bool allITAbove50k = employees.Where(e => e.Department.DepartmentName == "IT").All(e => e.Salary > 50000);
Console.WriteLine("\nAll IT Employees Earn More Than $50,000: " + allITAbove50k);

// Example 8: Count the number of employees in each department
var employeeCountByDepartment = employees.GroupBy(e => e.Department.DepartmentName)
                                         .Select(g => new { DepartmentName = g.Key, Count = g.Count() });

Console.WriteLine("\nEmployee Count by Department:");
foreach (var department in employeeCountByDepartment)
{
    Console.WriteLine($"Department: {department.DepartmentName}, Employee Count: {department.Count}");
}

// Example 9: Find the employee with the highest salary using LINQ
var highestSalaryEmployee = employees.OrderByDescending(e => e.Salary).FirstOrDefault();
Console.WriteLine($"\nHighest Salary: {highestSalaryEmployee.EmployeeName}, Salary: {highestSalaryEmployee.Salary:C}");

// Example 10: Find the youngest employee based on HireDate
var youngestEmployee = employees.OrderByDescending(e => e.HireDate).FirstOrDefault();
Console.WriteLine($"\nYoungest Employee (Most Recent Hire): {youngestEmployee.EmployeeName}, Hire Date: {youngestEmployee.HireDate.ToShortDateString()}");

// Example 11: Skip the first 2 employees and take the next 2
var skippedAndTakenEmployees = employees.Skip(2).Take(2);
Console.WriteLine("\nEmployees After Skipping 2 and Taking 2:");
foreach (var employee in skippedAndTakenEmployees)
{
    Console.WriteLine($"{employee.EmployeeName}, Salary: {employee.Salary:C}, Department: {employee.Department.DepartmentName}");
}

// Example 12: Calculate the total salary of all employees using LINQ
var totalSalary = employees.Sum(e => e.Salary);
Console.WriteLine($"\nTotal Salary of All Employees: {totalSalary:C}");

// Example 13: Get distinct departments that have employees
var distinctDepartments = employees.Select(e => e.Department.DepartmentName).Distinct();
Console.WriteLine("\nDistinct Departments:");
foreach (var dept in distinctDepartments)
{
    Console.WriteLine(dept);
}

// Example 14: Use LINQ to join Employees with Departments and project into a new type
var employeeDepartmentJoin = from e in employees
                             join d in departments on e.DepartmentId equals d.Id
                             select new { e.EmployeeName, DepartmentName = d.DepartmentName, e.Salary };

Console.WriteLine("\nEmployee-Department Join:");
foreach (var item in employeeDepartmentJoin)
{
    Console.WriteLine($"Employee: {item.EmployeeName}, Department: {item.DepartmentName}, Salary: {item.Salary:C}");
}

// Example 15: Use LINQ to find the maximum salary in each department
var maxSalaryByDepartment = from e in employees
                            group e by e.Department.DepartmentName into departmentGroup
                            select new
                            {
                                DepartmentName = departmentGroup.Key,
                                MaxSalary = departmentGroup.Max(emp => emp.Salary)
                            };

Console.WriteLine("\nMaximum Salary by Department:");
foreach (var department in maxSalaryByDepartment)
{
    Console.WriteLine($"Department: {department.DepartmentName}, Maximum Salary: {department.MaxSalary:C}");
}

// Example 16: Use LINQ to find employees whose names start with 'A'
var employeesStartingWithA = employees.Where(e => e.EmployeeName.StartsWith("A"));

Console.WriteLine("\nEmployees Whose Names Start with 'A':");
foreach (var employee in employeesStartingWithA)
{
    Console.WriteLine($"{employee.EmployeeName}, Salary: {employee.Salary:C}");
}

// Example 17: Use LINQ to find the employee with the lowest salary
var lowestSalaryEmployee = employees.OrderBy(e => e.Salary).FirstOrDefault();
Console.WriteLine($"\nLowest Salary: {lowestSalaryEmployee.EmployeeName}, Salary: {lowestSalaryEmployee.Salary:C}");

// Example 18: Reverse the order of employees by hire date
var reversedEmployeesByHireDate = employees.OrderBy(e => e.HireDate).Reverse();

Console.WriteLine("\nEmployees Reversed by Hire Date:");
foreach (var employee in reversedEmployeesByHireDate)
{
    Console.WriteLine($"{employee.EmployeeName}, Hire Date: {employee.HireDate.ToShortDateString()}, Salary: {employee.Salary:C}");
}

// Example 19: Use LINQ to select the first 3 employees by salary
var topThreeEmployeesBySalary = employees.OrderByDescending(e => e.Salary).Take(3);

Console.WriteLine("\nTop 3 Employees by Salary:");
foreach (var employee in topThreeEmployeesBySalary)
{
    Console.WriteLine($"{employee.EmployeeName}, Salary: {employee.Salary:C}");
}

// Example 20: Use LINQ to find the maximum hire date (most recent hire)
var maxHireDate = employees.Max(e => e.HireDate);
Console.WriteLine($"\nMost Recent Hire Date: {maxHireDate.ToShortDateString()}");

// Example 21: Select employees along with an index using LINQ
var employeesWithIndex = employees.Select((e, index) => new { Index = index + 1, EmployeeName = e.EmployeeName, e.Salary });

Console.WriteLine("\nEmployees with Index:");
foreach (var item in employeesWithIndex)
{
    Console.WriteLine($"Index: {item.Index}, Name: {item.EmployeeName}, Salary: {item.Salary:C}");
}

// Example 22: Group employees by salary range
var employeesGroupedBySalaryRange = employees.GroupBy(e =>
{
    if (e.Salary <= 60000)
        return "Low Salary";
    if (e.Salary <= 80000)
        return "Mid Salary";
    return "High Salary";
});

Console.WriteLine("\nEmployees Grouped by Salary Range:");
foreach (var group in employeesGroupedBySalaryRange)
{
    Console.WriteLine($"{group.Key}:");
    foreach (var employee in group)
    {
        Console.WriteLine($"- {employee.EmployeeName}, Salary: {employee.Salary:C}");
    }
}

// Example 23: Use LINQ to find employees who were hired in the last 3 years
var recentHires = employees.Where(e => (DateTime.Now - e.HireDate).TotalDays <= 365 * 3);

Console.WriteLine("\nEmployees Hired in the Last 3 Years:");
foreach (var employee in recentHires)
{
    Console.WriteLine($"{employee.EmployeeName}, Hire Date: {employee.HireDate.ToShortDateString()}");
}

// Example 24: Use LINQ to flatten a list of lists (if employees had multiple roles)
var employeesRoles = new List<List<string>>
            {
                new List<string> { "Developer", "Tester" },
                new List<string> { "Manager", "Scrum Master" },
                new List<string> { "Accountant", "Auditor" }
            };

var flattenedRoles = employeesRoles.SelectMany(r => r);

Console.WriteLine("\nFlattened Employee Roles:");
foreach (var role in flattenedRoles)
{
    Console.WriteLine(role);
}

// Example 25: Use LINQ to partition employees into those who earn more than $70,000 and those who don't
var partitionedEmployees = employees.ToLookup(e => e.Salary > 70000);

Console.WriteLine("\nEmployees Partitioned by Salary > $70,000:");
Console.WriteLine("Above $70,000:");
foreach (var employee in partitionedEmployees[true])
{
    Console.WriteLine($"- {employee.EmployeeName}, Salary: {employee.Salary:C}");
}

Console.WriteLine("Below or Equal to $70,000:");
foreach (var employee in partitionedEmployees[false])
{
    Console.WriteLine($"- {employee.EmployeeName}, Salary: {employee.Salary:C}");
}