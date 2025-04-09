using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;
        int rotations = 3;

        // Act
        string result = StringRotator.RotateRight(input, rotations);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        // Arrange
        string input = "hello";
        int rotations = 0;

        // Act
        string result = StringRotator.RotateRight(input, rotations);

        // Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "abcdef";
        int rotations = 2;
        string expected = "efabcd";

        // Act
        string result = StringRotator.RotateRight(input, rotations);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "12345";
        int rotations = -2;
        string expected = "45123";

        // Act
        string result = StringRotator.RotateRight(input, rotations);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        // Arrange
        string input = "xyz";
        int rotations = 5;
        string expected = "yzx";

        // Act
        string result = StringRotator.RotateRight(input, rotations);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
