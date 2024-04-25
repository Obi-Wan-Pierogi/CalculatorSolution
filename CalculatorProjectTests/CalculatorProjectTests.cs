
using CalculatorProject;
using Microsoft.VisualStudio.TestPlatform.TestHost;
namespace CalculatorProjectTests
{
    [TestClass]
    public class CalculatorProjectTests
    {
        public TestContext? TestContext { get; set; }

        [TestMethod]
        public void CalculatorProjectAdd_2_4_returns_6()
        {

            // Default values to 0 if null
            int x = 0;
            int y = 0;

            // Check if TestContext values are not null and can parse to int
            if (TestContext?.Properties?["ValueX"]?.ToString() != null && int.TryParse(TestContext.Properties["ValueX"].ToString(), out int parsedX))
            {
                x = parsedX;
            }
            if (TestContext?.Properties?["ValueY"]?.ToString() != null && int.TryParse(TestContext.Properties["ValueY"].ToString(), out int parsedY))
            {
                y = parsedY;
            }

            // Show Values of X and Y
            Console.WriteLine($"ValueX: {x}, ValueY: {y}");

            Calculator c = new Calculator();
            int result = c.Add(x, y);
            Assert.AreEqual(14, result); 
        }
    }
}