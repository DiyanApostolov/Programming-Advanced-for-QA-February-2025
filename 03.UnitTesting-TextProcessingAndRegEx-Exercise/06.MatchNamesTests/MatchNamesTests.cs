﻿using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchNamesTests
{
    [Test]
    public void Test_Match_ValidNames_ReturnsMatchedNames()
    {
        // Arrange
        string names = "John Smith and Alice Johnson";
        string expected = "John Smith Alice Johnson";

        // Act
        string actual = MatchNames.Match(names);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NoValidNames_ReturnsEmptyString()
    {
        // Arrange
        string names = "john Smith and Alice johnson";
        string expected = string.Empty;

        // Act
        string actual = MatchNames.Match(names);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string names = string.Empty;
        string expected = string.Empty;

        // Act
        string actual = MatchNames.Match(names);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
