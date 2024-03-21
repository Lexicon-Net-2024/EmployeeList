using EmployeeList.Helpers;
using Moq;

namespace EmployeeList.XUnitTests
{
    public class UtilTests
    {
        const string expected = "some input";
        private Mock<IUI> mockUI;

        public UtilTests()
        {
            mockUI = new Mock<IUI>();
        }

        [Fact]
        public void AskForString_ShiuldReturnString()
        {
            var mockUI = new MockUI();
            mockUI.SetInput = expected;

            var actual = Util.AskForString("", mockUI);

            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void AskForString_ShiuldReturnString_With_MOQ()
        {
            mockUI.Setup(u => u.GetInput()).Returns(expected);

            var actual = Util.AskForString("", mockUI.Object);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void Test(uint value)
        {
            Assert.True(value >= 0);
        }
    }
}