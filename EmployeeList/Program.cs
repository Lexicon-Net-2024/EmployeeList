using System;
using System.Xml.Linq;

namespace EmployeeList
{
    internal class Program
    {
        private static Payroll payRoll = new Payroll(); 
        static void Main(string[] args)
        {

            SeedData(); 
            do
            {
                
                Console.WriteLine("1. Add" +
                    "\n2. Print" +
                    "\nQ. Quit");
                string input = Console.ReadLine().ToUpper();

                switch (input)
                {
                    case "1":                    
                        AddEmployee();
                        break;
                    case "2":
                        PrintEmployees();
                        break;
                    case "Q":
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
            bool success = false;
            string name;
            int salary = 0;

            do
            {
                Console.Write("Name: ");
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("You must enter a valid name");
                }
                else
                {
                    success = true;
                    Console.Write("Salary: ");
                  int.TryParse(Console.ReadLine(), out salary);
                }
            } while (!success);
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
            payRoll.AddEmployee("Anna", 30000);
            payRoll.AddEmployee("Stefan", 25000);
            payRoll.AddEmployee("Lasse", 35000);
        }
    }
}
