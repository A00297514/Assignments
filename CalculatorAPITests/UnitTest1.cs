using CalculatorLibrary;
namespace CalculatorAPITests;

[TestClass]
public class UnitTest1
{
    //-----------------------------Test Cases for Add method--------------------------------
        [TestMethod]
        public void Add_Two_Positive_Numbers()
        {
            // Arrange
            var calculator = new Calculator();
            decimal op1 = 10;
            decimal op2 = 5;
            string expected = "10 + 5 = 15";

            // Act
            string actual = calculator.Add(op1, op2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Two_Negative_Numbers()
        {
            // Arrange
            var calculator = new Calculator();
            decimal op1 = -10;
            decimal op2 = -5;
            string expected = "-10 + -5 = -15";

            // Act
            string actual = calculator.Add(op1, op2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_One_Positive_Second_Negative_Number()
        {
            // Arrange
            var calculator = new Calculator();
            decimal op1 = 10;
            decimal op2 = -5;
            string expected = "10 + -5 = 5";

            // Act
            string actual = calculator.Add(op1, op2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_One_Negative_One_Positive_Number()
        {
            // Arrange
            var calculator = new Calculator();
            decimal op1 = -10;
            decimal op2 = 5;
            string expected = "-10 + 5 = -5";

            // Act
            string actual = calculator.Add(op1, op2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Two_Zeros()
        {
            // Arrange
            var calculator = new Calculator();
            decimal op1 = 0;
            decimal op2 = 0;
            string expected = "0 + 0 = 0";

            // Act
            string actual = calculator.Add(op1, op2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //-----------------------------Test Cases for Subtract method--------------------------------
        [TestMethod]
        public void Subtract_Two_Positive_Numbers()
        {
            // Arrange
            var calculator = new Calculator();
            decimal op1 = 10;
            decimal op2 = 5;
            string expected = "10 - 5 = 5";

            // Act
            string actual = calculator.Subtract(op1, op2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subtract_Two_Negative_Numbers()
        {
            // Arrange
            var calculator = new Calculator();
            decimal op1 = -10;
            decimal op2 = -5;
            string expected = "-10 - -5 = -5";

            // Act
            string actual = calculator.Subtract(op1, op2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subtract_Greater_From_Lesser_Number()
        {
            // Arrange
            var calculator = new Calculator();
            decimal op1 = 5;
            decimal op2 = 15;
            string expected = "5 - 15 = -10";

            // Act
            string actual = calculator.Subtract(op1, op2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subtract_Lesser_From_Greater_Number()
        {
            // Arrange
            var calculator = new Calculator();
            decimal op1 = 15;
            decimal op2 = 5;
            string expected = "15 - 5 = 10";

            // Act
            string actual = calculator.Subtract(op1, op2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subtract_From_Zero()
        {
            // Arrange
            var calculator = new Calculator();
            decimal op1 = 0;
            decimal op2 = 5;
            string expected = "0 - 5 = -5";

            // Act
            string actual = calculator.Subtract(op1, op2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //-----------------------------Test Cases for Multiply method--------------------------------

        [TestMethod]
        public void Multiply_With_Zero()
        {
            // Arrange
            var calculator = new Calculator();
            decimal op1 = 0;
            decimal op2 = 5;
            string expected = "0 X 5 = 0";

            // Act
            string actual = calculator.Multiply(op1, op2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Multiply_Two_Negative_Numbers()
        {
            // Arrange
            var calculator = new Calculator();
            decimal op1 = -10;
            decimal op2 = -5;
            string expected = "-10 X -5 = 50";

            // Act
            string actual = calculator.Multiply(op1, op2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Multiply_Two_Positive_Numbers()
        {
            // Arrange
            var calculator = new Calculator();
            decimal op1 = 10;
            decimal op2 = 5;
            string expected = "10 X 5 = 50";

            // Act
            string actual = calculator.Multiply(op1, op2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Multiply_Positive_And_Negative_Number()
        {
            // Arrange
            var calculator = new Calculator();
            decimal op1 = 10;
            decimal op2 = -5;
            string expected = "10 X -5 = -50";

            // Act
            string actual = calculator.Multiply(op1, op2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Multiply_Two_Decimal_Numbers()
        {
            // Arrange
            var calculator = new Calculator();
            decimal op1 = 10.05M;
            decimal op2 = 5.007M;
            string expected = "10.05 X 5.007 = 50.32035";

            // Act
            string actual = calculator.Multiply(op1, op2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //-----------------------------Test Cases for Divide method--------------------------------
        [TestMethod]
        public void Divide_By_Zero()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            string result = calculator.Divide(0, 0);

            // Assert
            Assert.AreEqual("0 can not divide by 0.", result);
        }

        [TestMethod]
        public void Regular_Division()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            string result = calculator.Divide(10, 2);

            // Assert
            Assert.AreEqual("10 / 2 = 5", result);
        }

        [TestMethod]
        public void Zero_Divide_By_Number()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            string result = calculator.Divide(0, 2);

            // Assert
            Assert.AreEqual("0 / 2 = 0", result);
        }

        [TestMethod]
        public void Divide_By_Self()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            string result = calculator.Divide(10, 10);

            // Assert
            Assert.AreEqual("10 / 10 = 1", result);
        }

        [TestMethod]
        public void Division_Of_Negative_Numbers()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            string result = calculator.Divide(-10, -5);

            // Assert
            Assert.AreEqual("-10 / -5 = 2", result);
        }
}