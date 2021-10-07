using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Moq;

namespace ICT3101_Calculator.UnitTests
{
    class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
            fr.Read("MagicNumbers.txt")).Returns(new string[12] { "5", "67", "4", "35", "213", "6", "45", "123", "2", "56", "69", "34" });
            _calculator = new Calculator();
        }

        [Test]
        public void AdditionalMagicGen_InputNeg4_ResultShouldBe0()
        {
            // Act
            double result = _calculator.GenMagicNum(-4, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void AdditionalMagicGen_Input0_ResultShouldBe0()
        {
            // Act
            double result = _calculator.GenMagicNum(0, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
    }

    
}
