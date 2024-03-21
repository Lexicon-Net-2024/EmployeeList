namespace EmployeeList.MSTest
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void Get_SalaryLevel_ShouldReturn_SalaryLevelJunior()
        {
            //Arrange
            const uint juniorSalaryLevel = 10000;
            const string name = "Kalle";

            var employee = new Employee(name, juniorSalaryLevel);
            var expected = SalaryLevel.Junior;

            //Act
            var actual = employee.SalaryLevel;

            Assert.AreEqual(expected, actual);
        }
        
        [DataTestMethod]
        [DataRow(2u)]
        [DataRow(10000u)]
        [DataRow(24999u)]
        public void TestMethod1(uint salary)
        {
            //Arrange
            const string name = "Kalle";

            var employee = new Employee(name, salary);
            var expected = SalaryLevel.Junior;

            //Act
            var actual = employee.SalaryLevel;

            Assert.AreEqual(expected, actual);
        }
    }
}