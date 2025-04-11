using System;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        // Arrange
        string input = string.Empty;
        string[] expected = Array.Empty<string>();

        // Act
        string[] actual = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        // Arrange
        string input = "Name";
        string[] expected = new string[] { "Name" };

        // Act
        string[] actual = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        // Arrange
        string input = "Name,Age";
        string[] expected = new string[] { "Name", "Age" };

        // Act
        string[] actual = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        // Arrange
        string input = "          Name,          Age                 ";
        string[] expected = new string[] { "Name", "Age" };

        // Act
        string[] actual = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
