using NUnit.Framework;
using ICT3101_Calculator;

namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        public FileReader _fileReader;

        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
            _fileReader = new FileReader();
            
           
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void Add_WhenSubtractingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Subtract(32, 20);
            // Assert
            Assert.That(result, Is.EqualTo(12));
        }

        [Test]
        public void Add_WhenMultiplyingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Multiply(3, 10);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void Add_WhenDividingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Divide(45, 15);
            // Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Add_WhenDividingTwoZeroNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Divide(0, 0);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Add_WhenDividingZeroByNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Divide(0, 13);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        /* [Test]
        public void Add_WhenDividingTwoNumbers0_ResultEqualToSum()
        {
            // Act
            float zero = 0;
            double result = _calculator.Divide(45, 0);
            float infinity = 1 / zero;
            // Assert
            Assert.That(result, Is.EqualTo(infinity));
        } */

        [Test]
        [TestCase(10, 0)]
        public void Divide_WithZerosAsInputs_ResultPositiveInfinity(int a, int b)
        {
            //Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
            double result = _calculator.Divide(a, b);
            Assert.That(result, Is.EqualTo(double.PositiveInfinity));
        }

        [Test]
        public void Factorial_ResultEqualTo()
        {
            // Act
            double result = _calculator.Factorial(9);
            // Assert
            Assert.That(result, Is.EqualTo(362880));
        }

        [Test]
        public void FactorialOfZero_ResultEqualTo()
        {
            // Act
            double result = _calculator.Factorial(0);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        [TestCase(-3)]
        [TestCase(-5)]
        public void FacotrialsLessThanZero_ResultThrowArgumentException(int a)
        {
            Assert.That(() => _calculator.Factorial(a), Throws.ArgumentException);
        }

        [Test]
        public void AreaOfTriangle_ResultEqualToSum()
        {
            // Act
            double result = _calculator.AreaTriangle(20, 6);
            // Assert
            Assert.That(result, Is.EqualTo(40));
        }

        [Test]
        public void AreaOfCircle_ResultEqualToSum()
        {
            // Act
            double result = _calculator.AreaCircle(3);
            // Assert
            Assert.That(result, Is.EqualTo(28.26));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.Permutation(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.Permutation(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.Permutation(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.Permutation(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.Permutation(4, 5), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.Combination(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.Combination(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.Combination(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.Combination(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.Combination(4, 5), Throws.ArgumentException);
        }

        [Test]
        public void MagicGen_Input4_ResultShouldBe8()
        {
            // Act
            double result = _calculator.GenMagicNum(2, _fileReader);
            // Assert
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void MagicGen_InputNeg4_ResultShouldBe0()
        {
            // Act
            double result = _calculator.GenMagicNum(-4, _fileReader);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void MagicGen_Input0_ResultShouldBe0()
        {
            // Act
            double result = _calculator.GenMagicNum(0, _fileReader);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
    }
}