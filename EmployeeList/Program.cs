﻿using System;
using System.Xml.Linq;
using EmployeeList.Helpers;

namespace EmployeeList
{
    internal class Program
    {
        private static Payroll payRoll = new Payroll(); 
        static void Main(string[] args)
        {

            //Employee kalle = new Employee("Kalle", 50000);

            //payRoll.AddEmployee(kalle);
            //payRoll.AddEmployee("Kalle", 50000); 

            SeedData(); 
            do
            {
                MenuHelpers.ShowMainMenu(); 
               
                string input = Console.ReadLine().ToUpper();

                switch (input)
                {
                    case MenuHelpers.Add:                    
                        AddEmployee();
                        break;
                    case MenuHelpers.Print:
                        PrintEmployees();
                        break;
                    case MenuHelpers.Quit:
                        Environment.Exit(0); 
                        break; 
                    default:
                        Console.WriteLine("Not a valid selection!");
                        break;
                }

            } while (true);

        }        

        private static void AddEmployee()
        {
            string name = Util.AskForString("Name");
            uint salary = Util.AskForUInt("Salary");

            payRoll.AddEmployee(name, salary); 
        }

        private static void PrintEmployees()
        {
            IEnumerable<Employee> employees = payRoll.GetEmployees();
            
            foreach(Employee employee in employees)
            {
                //Console.WriteLine($"Name: {employee.Name} Salary: {employee.Salary}");
                Console.WriteLine(employee.ToString()); 
            }
        }

        private static void SeedData()
        {
            payRoll.AddEmployee(new Employee("Anna", 30000));
            payRoll.AddEmployee("Stefan", 25000);
            payRoll.AddEmployee("Lasse", 35000);
        }
       
    }
}
