﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("EmployeeList.MSTest")]
namespace EmployeeList
{
    internal class Employee : object
    {
        public string Name { get; set; }
        public uint Salary { get; set; }

        public SalaryLevel SalaryLevel => Salary < 25000 ? SalaryLevel.Junior : SalaryLevel.Senior;
        //{
        //    get
        //    {
        //        if(Salary < 25000)
        //        {
        //            return SalaryLevel.Junior;
        //        }
        //        else
        //        {
        //            return SalaryLevel.Senior;
        //        }
        //    }
        //}        




        public Employee(string name, uint salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {


            return $"Name: {Name} Salary: {Salary} Salary Level: {SalaryLevel}";
        }
    }
}
