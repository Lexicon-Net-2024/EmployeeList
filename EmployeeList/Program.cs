namespace EmployeeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Droid d = new Droid("C-3PO");

            //Console.WriteLine(d.GetFirstName());

            ////d.firstname = "R2-D2";
            //d.SetFirstName("R2-D2");
            //Console.WriteLine(d.GetFirstName());
            //d.Salary = 20000; 

            //Employee emp = new Employee("Anders", 20000);

            //Console.WriteLine($"Name: {emp.Name} Salary: {emp.Salary}");

            //emp.Name = "Nisse";

            //Console.WriteLine($"Name: {emp.Name} Salary: {emp.Salary}");



            //Payroll payroll = new Payroll();

            ////Lägger till ny anställd
            //payroll.AddEmployee("Kalle", 25000);
            //payroll.AddEmployee("Anna", 30000);

            ////Hämtar en samling av alla anställda.
            //IEnumerable<Employee> employees = payroll.GetEmployees();

            ////Skriver ut alla anställda
            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine($"Name: {employee.Name} Salary: {employee.Salary}");
            //}

            Droid d1 = new Droid("R2-D2");
           // Console.WriteLine(Droid.Count);
            Droid d2 = new Droid("C-3PO");
           // Console.WriteLine(Droid.Count);
            Droid d3 = new Droid("R5-D4");
           // Console.WriteLine(Droid.Count);
           // int count = Droid.Count;

            Droid.GetCount(); 


        }
    }
}
