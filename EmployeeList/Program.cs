namespace EmployeeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Droid d = new Droid("C-3PO");

            Console.WriteLine(d.GetFirstName());

            //d.firstname = "R2-D2";
            d.SetFirstName("R2-D2");
            Console.WriteLine(d.GetFirstName());
            d.Salary = 20000; 
            
        }
    }
}
