using CalculatorAPI.controllers;
using Microsoft.AspNetCore.Mvc;

namespace CalcAPITests;

[TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd_PositiveNumbers()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();
            decimal num1 = 5;
            decimal num2 = 10;
            decimal expectedResult = 15;

            // Act
            IActionResult actionResult = controller.Add(num1, num2);
            OkObjectResult okResult = actionResult as OkObjectResult;
            decimal result = (decimal)okResult.Value;

            // Assert
            Assert.AreEqual(expectedResult, result, "Addition of positive numbers is not correct");
        }
    
[TestMethod]
public void TestAdd_NegativeNumbers()
{
    // Arrange
    CalculatorController controller = new CalculatorController();
    decimal num1 = -5;
    decimal num2 = -10;
    decimal expectedResult = -15;

    // Act
    IActionResult actionResult = controller.Add(num1, num2);
    OkObjectResult okResult = actionResult as OkObjectResult;
    decimal result = (decimal)okResult.Value;

    // Assert
    Assert.AreEqual(expectedResult, result, "Addition of negative numbers is not correct");
}

[TestMethod]
public void TestAdd_ZeroWithPositiveNumber()
{
    // Arrange
    CalculatorController controller = new CalculatorController();
    decimal num1 = 0;
    decimal num2 = 10;
    decimal expectedResult = 10;

    // Act
    IActionResult actionResult = controller.Add(num1, num2);
    OkObjectResult okResult = actionResult as OkObjectResult;
    decimal result = (decimal)okResult.Value;

    // Assert
    Assert.AreEqual(expectedResult, result, "Addition of zero with a positive number is not correct");
}

[TestMethod]
public void TestAdd_ZeroWithNegativeNumber()
{
    // Arrange
    CalculatorController controller = new CalculatorController();
    decimal num1 = 0;
    decimal num2 = -10;
    decimal expectedResult = -10;

    // Act
    IActionResult actionResult = controller.Add(num1, num2);
    OkObjectResult okResult = actionResult as OkObjectResult;
    decimal result = (decimal)okResult.Value;

    // Assert
    Assert.AreEqual(expectedResult, result, "Addition of zero with a negative number is not correct");
}

[TestMethod]
public void TestAdd_ZeroWithZero()
{
    // Arrange
    CalculatorController controller = new CalculatorController();
    decimal num1 = 0;
    decimal num2 = 0;
    decimal expectedResult = 0;

    // Act
    IActionResult actionResult = controller.Add(num1, num2);
    OkObjectResult okResult = actionResult as OkObjectResult;
    decimal result = (decimal)okResult.Value;

    // Assert
    Assert.AreEqual(expectedResult, result, "Addition of zero with zero is not correct");
}



     [TestMethod]
public void TestSubtract_PositiveNumbers()
{
    // Arrange
    CalculatorController controller = new CalculatorController();
    decimal num1 = 10;
    decimal num2 = 5;
    decimal expectedResult = 5;

    // Act
    IActionResult actionResult = controller.Subtract(num1, num2);
    OkObjectResult okResult = actionResult as OkObjectResult;
    decimal result = (decimal)okResult.Value;

    // Assert
    Assert.AreEqual(expectedResult, result, "Subtraction of positive numbers is not correct");
}

[TestMethod]
public void TestSubtract_NegativeNumbers()
{
    // Arrange
    CalculatorController controller = new CalculatorController();
    decimal num1 = -10;
    decimal num2 = -5;
    decimal expectedResult = -5;

    // Act
    IActionResult actionResult = controller.Subtract(num1, num2);
    OkObjectResult okResult = actionResult as OkObjectResult;
    decimal result = (decimal)okResult.Value;

    // Assert
    Assert.AreEqual(expectedResult, result, "Subtraction of negative numbers is not correct");
}

[TestMethod]
public void TestSubtract_PositiveFromNegative()
{
    // Arrange
    CalculatorController controller = new CalculatorController();
    decimal num1 = -5;
    decimal num2 = 10;
    decimal expectedResult = -15;

    // Act
    IActionResult actionResult = controller.Subtract(num1, num2);
    OkObjectResult okResult = actionResult as OkObjectResult;
    decimal result = (decimal)okResult.Value;

    // Assert
    Assert.AreEqual(expectedResult, result, "Subtraction of a positive number from a negative number is not correct");
}

[TestMethod]
public void TestSubtract_NegativeFromPositive()
{
    // Arrange
    CalculatorController controller = new CalculatorController();
    decimal num1 = 10;
    decimal num2 = -5;
    decimal expectedResult = 15;

    // Act
    IActionResult actionResult = controller.Subtract(num1, num2);
    OkObjectResult okResult = actionResult as OkObjectResult;
    decimal result = (decimal)okResult.Value;

    // Assert
    Assert.AreEqual(expectedResult, result, "Subtraction of a negative number from a positive number is not correct");
}

[TestMethod]
public void TestSubtract_Zero()
{
    // Arrange
    CalculatorController controller = new CalculatorController();
    decimal num1 = 10;
    decimal num2 = 0;
    decimal expectedResult = 10;

    // Act
    IActionResult actionResult = controller.Subtract(num1, num2);
    OkObjectResult okResult = actionResult as OkObjectResult;
    decimal result = (decimal)okResult.Value;

    // Assert
    Assert.AreEqual(expectedResult, result, "Subtraction of zero is not correct");
}


        [TestMethod]
public void TestMultiply_PositiveNumbers()
{
    // Arrange
    CalculatorController controller = new CalculatorController();
    decimal num1 = 5;
    decimal num2 = 10;
    decimal expectedResult = 50;

    // Act
    IActionResult actionResult = controller.Multiply(num1, num2);
    OkObjectResult okResult = actionResult as OkObjectResult;
    decimal result = (decimal)okResult.Value;

    // Assert
    Assert.AreEqual(expectedResult, result, "Multiplication of positive numbers is not correct");
}

[TestMethod]
public void TestMultiply_NegativeNumbers()
{
    // Arrange
    CalculatorController controller = new CalculatorController();
    decimal num1 = -5;
    decimal num2 = -10;
    decimal expectedResult = 50;

    // Act
    IActionResult actionResult = controller.Multiply(num1, num2);
    OkObjectResult okResult = actionResult as OkObjectResult;
    decimal result = (decimal)okResult.Value;

    // Assert
    Assert.AreEqual(expectedResult, result, "Multiplication of negative numbers is not correct");
}

[TestMethod]
public void TestMultiply_PositiveAndNegativeNumbers()
{
    // Arrange
    CalculatorController controller = new CalculatorController();
    decimal num1 = -5;
    decimal num2 = 10;
    decimal expectedResult = -50;

    // Act
    IActionResult actionResult = controller.Multiply(num1, num2);
    OkObjectResult okResult = actionResult as OkObjectResult;
    decimal result = (decimal)okResult.Value;

    // Assert
    Assert.AreEqual(expectedResult, result, "Multiplication of positive and negative numbers is not correct");
}

[TestMethod]
public void TestMultiply_ByZero()
{
    // Arrange
    CalculatorController controller = new CalculatorController();
    decimal num1 = 5;
    decimal num2 = 0;
    decimal expectedResult = 0;

    // Act
    IActionResult actionResult = controller.Multiply(num1, num2);
    OkObjectResult okResult = actionResult as OkObjectResult;
    decimal result = (decimal)okResult.Value;

    // Assert
    Assert.AreEqual(expectedResult, result, "Multiplication by zero is not correct");
}

[TestMethod]
public void TestMultiply_Zero()
{
    // Arrange
    CalculatorController controller = new CalculatorController();
    decimal num1 = 0;
    decimal num2 = 10;
    decimal expectedResult = 0;

    // Act
    IActionResult actionResult = controller.Multiply(num1, num2);
    OkObjectResult okResult = actionResult as OkObjectResult;
    decimal result = (decimal)okResult.Value;

    // Assert
    Assert.AreEqual(expectedResult, result, "Multiplication with zero is not correct");
}

      [TestMethod]
public void TestDivide_PositiveNumbers()
{
    // Arrange
    CalculatorController controller = new CalculatorController();
    decimal num1 = 10;
    decimal num2 = 2;
    decimal expectedResult = 5;

    // Act
    IActionResult actionResult = controller.Divide(num1, num2);
    OkObjectResult okResult = actionResult as OkObjectResult;
    decimal result = (decimal)okResult.Value;

    // Assert
    Assert.AreEqual(expectedResult, result, "Division of positive numbers is not correct");
}

[TestMethod]
public void TestDivide_NegativeNumbers()
{
    // Arrange
    CalculatorController controller = new CalculatorController();
    decimal num1 = -10;
    decimal num2 = -2;
    decimal expectedResult = 5;

    // Act
    IActionResult actionResult = controller.Divide(num1, num2);
    OkObjectResult okResult = actionResult as OkObjectResult;
    decimal result = (decimal)okResult.Value;

    // Assert
    Assert.AreEqual(expectedResult, result, "Division of negative numbers is not correct");
}

[TestMethod]
public void TestDivide_PositiveByNegativeNumber()
{
    // Arrange
    CalculatorController controller = new CalculatorController();
    decimal num1 = 10;
    decimal num2 = -2;
    decimal expectedResult = -5;

    // Act
    IActionResult actionResult = controller.Divide(num1, num2);
    OkObjectResult okResult = actionResult as OkObjectResult;
    decimal result = (decimal)okResult.Value;

    // Assert
    Assert.AreEqual(expectedResult, result, "Division of positive number by negative number is not correct");
}

[TestMethod]
public void TestDivide_ByZero()
{
    // Arrange
    CalculatorController controller = new CalculatorController();
    decimal num1 = 10;
    decimal num2 = 0;

    // Act
    IActionResult actionResult = controller.Divide(num1, num2);

    // Assert
    Assert.IsInstanceOfType(actionResult, typeof(BadRequestObjectResult), "Division by zero should result in BadRequest");
}

[TestMethod]
public void TestDivide_Zero()
{
    // Arrange
    CalculatorController controller = new CalculatorController();
    decimal num1 = 0;
    decimal num2 = 10;
    decimal expectedResult = 0;

    // Act
    IActionResult actionResult = controller.Divide(num1, num2);
    OkObjectResult okResult = actionResult as OkObjectResult;
    decimal result = (decimal)okResult.Value;

    // Assert
    Assert.AreEqual(expectedResult, result, "Division by zero is not correct");
}
    }