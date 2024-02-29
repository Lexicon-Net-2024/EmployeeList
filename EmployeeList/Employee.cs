using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
    internal class Employee : Object
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary; 
        }

        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary}";
        }
    }
}
