using Week7_Linq;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            Student stduent = new Student("Eric", 100);
            string expectedStudentString = "Name: Eric - Score: 100";

            // Act
            string actualStudentString = stduent.ToString();

            // Assert
            Assert.AreEqual(expectedStudentString, actualStudentString);

        }
    }
}