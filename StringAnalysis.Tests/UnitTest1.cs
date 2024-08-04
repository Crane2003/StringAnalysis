using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringAnalysis;

namespace StringAnalysis.Tests
{
    [TestClass]
    public class AnalyzerTests
    {
        // Test MaxUnequalConsecutive
        [TestMethod]
        public void MaxUnequalConsecutive_InputIsNull_ReturnsZero()
        {
            // Arrange
            string? input = null;

            // Act
            int result = Analyzer.MaxUnequalConsecutive(input);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MaxUnequalConsecutive_InputIsEmpty_ReturnsZero()
        {
            // Arrange
            string input = string.Empty;

            // Act
            int result = Analyzer.MaxUnequalConsecutive(input);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MaxUnequalConsecutive_AllSameCharacters_ReturnsOne()
        {
            // Arrange
            string input = "aaaa";

            // Act
            int result = Analyzer.MaxUnequalConsecutive(input);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MaxUnequalConsecutive_AllDifferentCharacters_ReturnsLength()
        {
            // Arrange
            string input = "abcd";

            // Act
            int result = Analyzer.MaxUnequalConsecutive(input);

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void MaxUnequalConsecutive_MixedCharacters_ReturnsExpected()
        {
            // Arrange
            string input = "aabbbcddd";

            // Act
            int result = Analyzer.MaxUnequalConsecutive(input);

            // Assert
            Assert.AreEqual(3, result);
        }

        // Test MaxConsecutiveIdenticalLetters
        [TestMethod]
        public void MaxConsecutiveIdenticalLetters_InputIsNull_ReturnsZero()
        {
            // Arrange
            string? input = null;

            // Act
            int result = Analyzer.MaxConsecutiveIdenticalLetters(input);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MaxConsecutiveIdenticalLetters_InputIsEmpty_ReturnsZero()
        {
            // Arrange
            string input = string.Empty;

            // Act
            int result = Analyzer.MaxConsecutiveIdenticalLetters(input);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MaxConsecutiveIdenticalLetters_AllSameLetters_ReturnsLength()
        {
            // Arrange
            string input = "aaaa";

            // Act
            int result = Analyzer.MaxConsecutiveIdenticalLetters(input);

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void MaxConsecutiveIdenticalLetters_MixedLetters_ReturnsExpected()
        {
            // Arrange
            string input = "aabbbccccc";

            // Act
            int result = Analyzer.MaxConsecutiveIdenticalLetters(input);

            // Assert
            Assert.AreEqual(5, result);
        }

        // Test MaxConsecutiveIdenticalDigits
        [TestMethod]
        public void MaxConsecutiveIdenticalDigits_InputIsNull_ReturnsZero()
        {
            // Arrange
            string? input = null;

            // Act
            int result = Analyzer.MaxConsecutiveIdenticalDigits(input);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MaxConsecutiveIdenticalDigits_InputIsEmpty_ReturnsZero()
        {
            // Arrange
            string input = string.Empty;

            // Act
            int result = Analyzer.MaxConsecutiveIdenticalDigits(input);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MaxConsecutiveIdenticalDigits_AllSameDigits_ReturnsLength()
        {
            // Arrange
            string input = "1111";

            // Act
            int result = Analyzer.MaxConsecutiveIdenticalDigits(input);

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void MaxConsecutiveIdenticalDigits_MixedDigits_ReturnsExpected()
        {
            // Arrange
            string input = "11222333344";

            // Act
            int result = Analyzer.MaxConsecutiveIdenticalDigits(input);

            // Assert
            Assert.AreEqual(4, result);
        }
    }
}
