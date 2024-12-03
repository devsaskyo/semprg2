using System;
using System.Collections.Generic;
using System.Linq;

namespace ImAnEmployerApparently
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Petr", Age = 65 },
            new Employee { Name = "Pavel", Age = 23 },
            new Employee { Name = "Jan", Age = 87 },
            new Employee { Name = "David", Age = 14 },
            new Employee { Name = "Oskar", Age = 15 },
            new Employee { Name = "Josef", Age = 120 }
        };

            var filteredEmployees = employees
                .Where(e => e.Name.Length > 4)
                .OrderBy(e => e.Name.Length)
                .Select(e => e.Name);
            Console.WriteLine("Employees with names longer than 4 ordered by Name:");
            foreach (var name in filteredEmployees)
            {
                Console.WriteLine(name);
            }
        }
    }
}
