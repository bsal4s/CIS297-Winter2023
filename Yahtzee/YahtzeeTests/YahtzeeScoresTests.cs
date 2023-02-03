using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yahtzee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahtzeeTests;

namespace Yahtzee.Tests
{
    [TestClass()]
    public class YahtzeeScoresTests
    {
        [TestMethod()]
        public void YahtzeeScoresTest()
        {
            // Arrange
            NotRandom notRandom = new NotRandom(
                new List<int> { 1, 2, 3, 4, 5 });
            Dice dice = new Dice(notRandom);
            YahtzeeScores scores = new YahtzeeScores(dice);
            int expectedOnesScore = 1;

            // Act
            int actualOnesScore = scores.OnesScore();

            // Assert
            Assert.AreEqual(expectedOnesScore, actualOnesScore);
        }
    }
}