using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        this._exceptions = new Exceptions();
    }

    // TODO: finish test
    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        string input = "Hello";
        string expected = "olleH";

        // Act
        string result = _exceptions.ArgumentNullReverse(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null;
        string message = "String cannot be null. (Parameter 's')";

        // Act & Assert
        // new syntax
        Assert.That(() => _exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException, "bla bla");

        try
        {
            _exceptions.ArgumentNullReverse(input);
        }
        catch (ArgumentNullException exception)
        {
            Assert.That(exception.Message, Is.EqualTo(message));
        }

        // old syntax
        var ex = Assert.Throws<ArgumentNullException>(() => _exceptions.ArgumentNullReverse(input));
        Assert.That(ex.Message, Is.EqualTo(message));
    }

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        // Arrange
        decimal price = 200;
        decimal discount = 10;
        decimal expectedPrice = 180;

        // Act
        decimal result = _exceptions.ArgumentCalculateDiscount(price, discount);

        // Assert
        Assert.That(result, Is.EqualTo(expectedPrice));
    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        decimal price = 200;
        decimal discount = -10;

        // Act & Assert - new syntax
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(price, discount), Throws.ArgumentException);
    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal price = 100.0m;
        decimal discount = 110.0m;
        string message = "Discount must be between 0 and 100. (Parameter 'discount')";

        // Act & Assert - old syntax
        var ex = Assert.Throws<ArgumentException>(() => _exceptions.ArgumentCalculateDiscount(price, discount));
        Assert.That(ex.Message, Is.EqualTo(message));
    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = 2;
        int expected = 30;

        // Act
        int result = _exceptions.IndexOutOfRangeGetElement(array, index);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = -2;

        // Act & Assert
        Assert.That(() => _exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    // TODO: finish test
    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;

        // Act & Assert
        Assert.That(() => _exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = 10;

        // Act & Assert
        Assert.That(() => _exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        // Arrange
        bool isLoggedIn = true;
        string expected = "User logged in.";

        // Act
        string result = _exceptions.InvalidOperationPerformSecureOperation(isLoggedIn);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        // Arrange
        bool isLoggedIn = false;
        string message = "User must be logged in to perform this operation.";

        // Act & Assert - old syntax
        var ex = Assert.Throws<InvalidOperationException>(() => _exceptions.InvalidOperationPerformSecureOperation(isLoggedIn));

        Assert.That(ex.Message, Is.EqualTo(message));

    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        // Arrange
        string input = "42";
        int expected = 42;

        // Act
        int result = _exceptions.FormatExceptionParseInt(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    // Arrange
    [TestCase("pet")]
    [TestCase("5.5")]
    [TestCase("5a")]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException(string input)
    {
        // Act & Assert
        Assert.That(() => _exceptions.FormatExceptionParseInt(input), Throws.TypeOf<FormatException>());
    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        // Arrange
        Dictionary<string, int> dict = new Dictionary<string, int>()
        {
            ["one"] = 1,
            ["two"] = 2,
            ["three"] = 3,
            ["four"] = 4
        };

        string key = "two";
        int expected = 2;

        // Act
        int result = _exceptions.KeyNotFoundFindValueByKey(dict, key);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        // Arrange
        Dictionary<string, int> dict = new Dictionary<string, int>()
        {
            ["one"] = 1,
            ["two"] = 2,
            ["three"] = 3,
            ["four"] = 4
        };

        string invalidKey = "five";
        string message = "The specified key was not found in the dictionary.";

        // Act & Assert
        var ex = Assert.Throws<KeyNotFoundException>(() => _exceptions.KeyNotFoundFindValueByKey(dict, invalidKey));

        // Check exception message
        Assert.That(ex.Message, Is.EqualTo(message));
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        // Arrange
        int a = 5;
        int b = 10;
        int expected = 15;

        // Act
        int result = _exceptions.OverflowAddNumbers(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = int.MaxValue;
        int b = 1;
        string message = "Arithmetic overflow occurred during addition.";

        // Act & Assert - new syntax for check the excaption message
        try
        {
            Assert.That(() => _exceptions.OverflowAddNumbers(a, b), Throws.TypeOf<OverflowException>());

            // викаме си метода отделно, за да хвърли грешката
            _exceptions.OverflowAddNumbers(a, b); 
        }
        catch (OverflowException ex)
        {
            Assert.That(ex.Message, Is.EqualTo(message));
        }
    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = int.MinValue;
        int b = -1;
        string message = "Arithmetic overflow occurred during addition.";

        // Act & Assert - new syntax for check the excaption message
        try
        {
            Assert.That(() => _exceptions.OverflowAddNumbers(a, b), Throws.TypeOf<OverflowException>());

            // викаме си метода отделно, за да хвърли грешката
            _exceptions.OverflowAddNumbers(a, b);
        }
        catch (OverflowException ex)
        {
            Assert.That(ex.Message, Is.EqualTo(message));
        }
    }

    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        // Arrange
        int divident = 14;
        int divisor = 4;
        int expected = 3;

        // Act
        int result = _exceptions.DivideByZeroDivideNumbers(divident, divisor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        int divident = 14;
        int divisor = 0;
        string message = "Division by zero is not allowed.";

        // Act & Assert + check exception message
        try
        {
            Assert.That(() => _exceptions.DivideByZeroDivideNumbers(divident, divisor), Throws.TypeOf<DivideByZeroException>());
            _exceptions.DivideByZeroDivideNumbers(divident, divisor);
        }
        catch (DivideByZeroException ex)
        {
            Assert.That(ex.Message, Is.EqualTo(message));
        }
    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        // Arrange
        int[] array = new int[] { 1, 2, 3, 4, 5 };
        int validIndex = 2;
        int expected = 15;

        // Act
        int result = _exceptions.SumCollectionElements(array, validIndex);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        // Arrange
        int[] nullArray = null;
        int validIndex = 2;

        // Act & Assert
        Assert.That(() => _exceptions.SumCollectionElements(nullArray, validIndex), Throws.TypeOf<ArgumentNullException>());
    }

    [TestCase(-10)]
    [TestCase(-1)]
    [TestCase(5)]
    [TestCase(10)]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException(int invalidIndex)
    {
        // Arrange
        int[] array = new int[] { 1, 2, 3, 4, 5 };

        // Act & Assert
        Assert.That(() => _exceptions.SumCollectionElements(array, invalidIndex), Throws.TypeOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        // Arrange
        Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            ["one"] = "1",
            ["two"] = "2",
            ["three"] = "3",
            ["four"] = "4"
        };

        string validKey = "two";
        int expected = 2;

        // Act
        int result = _exceptions.GetElementAsNumber(dict, validKey);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        // Arrange
        Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            ["one"] = "1",
            ["two"] = "2",
            ["three"] = "3",
            ["four"] = "4"
        };

        string invalidKey = "five";

        // Act & Assert - old syntax
        Assert.Throws<KeyNotFoundException>(() => _exceptions.GetElementAsNumber(dict, invalidKey));
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        // Arrange
        Dictionary<string, string> dictWithInvalidValues = new Dictionary<string, string>()
        {
            ["one"] = "1a",
            ["two"] = "2.2",
            ["three"] = "3#",
            ["four"] = "four"
        };

        string validKey = "three";

        // Act & Assert - old syntax
        Assert.Throws<FormatException>(() => _exceptions.GetElementAsNumber(dictWithInvalidValues, validKey));
    }
}
