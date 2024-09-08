using System;
using System.Collections.Generic;

namespace AdvancedLINQConcepts
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public double Salary { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public DateTime HireDate { get; set; }
    }
}