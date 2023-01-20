using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week3_ObjectOrientedProgramming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3_ObjectOrientedProgramming.Tests
{
    [TestClass()]
    public class CupTests
    {
        [TestMethod()]
        public void CupConstructorTest()
        {
            // AAA convention

            // Arrange the variables we need to test
            string expectedColor = "wood";
            string expectedContents = "coffee";
            int expectedVolumneInMilliliters = 250;

            // Act - call the code we are testing, and get vaules back out
            Cup cup = new Cup(expectedColor, expectedContents, expectedVolumneInMilliliters);
            string actualColor = cup.Color;
            string actualContents = cup.Contents;
            int actualVolumneInMilliliters = cup.getVolumeInMilliliters();

            // Assert - did we get what we expected
            Assert.AreEqual(expectedColor, actualColor);
            //Assert.AreEqual(expectedColor, cup.Color);
            Assert.AreEqual(expectedContents, actualContents);
            Assert.AreEqual(expectedVolumneInMilliliters, actualVolumneInMilliliters);
        }

        [TestMethod()]
        public void drinkTestReturnsFalse()
        {
            // Arrange
            int expectedVolumneInMilliliters = 250;
            Cup cup = new Cup("", "", expectedVolumneInMilliliters);

            // Act
            bool result = cup.drink(expectedVolumneInMilliliters * 2);
            int actualVolumneInMilliliters = cup.getVolumeInMilliliters();

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(expectedVolumneInMilliliters, actualVolumneInMilliliters);


        }
        [TestMethod()]
        public void drinkTestReturnsTrue()
        {
            // Arrange
            int startingVolumneInMilliliters = 250;
            int expectedVolumneInMilliliters = 200;
            Cup cup = new Cup("", "", startingVolumneInMilliliters);

            // Act
            bool result = cup.drink(startingVolumneInMilliliters - expectedVolumneInMilliliters);
            int actualVolumneInMilliliters = cup.getVolumeInMilliliters();

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(expectedVolumneInMilliliters, actualVolumneInMilliliters);


        }


        [TestMethod()]
        public void setVolumeInMillilitersTest()
        {
            // Arrange
            Cup cup = new Cup("");
            int expectedVolumneInMilliliters = 200;

            // Act
            cup.setVolumeInMilliliters(expectedVolumneInMilliliters);
            int actualVolumneInMilliliters = cup.getVolumeInMilliliters();

            // Assert
            Assert.AreEqual(expectedVolumneInMilliliters, actualVolumneInMilliliters);

        }

        [TestMethod()]
        public void setVolumeInMillilitersTestNegativeValuesSetTo0()
        {
            // Arrange
            Cup cup = new Cup("", "", 250);
            int expectedVolumneInMilliliters = 0;

            // Act
            cup.setVolumeInMilliliters(-100);
            int actualVolumneInMilliliters = cup.getVolumeInMilliliters();

            // Assert
            Assert.AreEqual(expectedVolumneInMilliliters, actualVolumneInMilliliters);

        }
    }
}