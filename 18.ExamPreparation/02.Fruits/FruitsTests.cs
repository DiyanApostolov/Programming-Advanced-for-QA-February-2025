using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        // Arrange
        Dictionary<string, int> input = new Dictionary<string, int>
        {
            { "apple", 15 },
            { "pear", 25 }
        };
        string fruitKey = "pear";
        int expected = 25;

        // Act
        int actual = Fruits.GetFruitQuantity(input, fruitKey);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> input = new Dictionary<string, int>
        {
            { "apple", 15 },
            { "pear", 25 }
        };
        string fruitKey = "invalid name";
        int expected = 0;

        // Act
        int actual = Fruits.GetFruitQuantity(input, fruitKey);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero() // null or empty ? 
    {
        // Arrange
        Dictionary<string, int> input = new Dictionary<string, int> { };
        string fruitKey = "invalid name";
        int expected = 0;

        // Act
        int actual = Fruits.GetFruitQuantity(input, fruitKey);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> input = null;
        string fruitKey = "invalid name";
        int expected = 0;

        // Act
        int actual = Fruits.GetFruitQuantity(input, fruitKey);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> input = new Dictionary<string, int>
        {
            { "apple", 15 },
            { "pear", 25 }
        };
        string fruitKey = null;
        int expected = 0;

        // Act
        int actual = Fruits.GetFruitQuantity(input, fruitKey);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
