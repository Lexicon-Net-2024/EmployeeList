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
        public uint Salary { get; set; }

        public Employee(string name, uint salary)
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
