using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new(); // empty
        Dictionary<string, int> dict2 = new(); // empty

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new(); // empty
        Dictionary<string, int> dict2 = new();
        dict2.Add("Key1", 1);
        dict2.Add("Key2", 2);
        dict2.Add("Key3", 3);

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new();
        dict1.Add("Key1", 1);
        dict1.Add("Key2", 2);
        dict1.Add("Key3", 3);

        Dictionary<string, int> dict2 = new();
        dict2.Add("Key4", 4);
        dict2.Add("Key5", 5);
        dict2.Add("Key6", 6);

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new();
        dict1.Add("Key1", 1);
        dict1.Add("Key2", 2);
        dict1.Add("Key3", 3);

        Dictionary<string, int> dict2 = new();
        dict2.Add("Key3", 3);
        dict2.Add("Key2", 2);
        dict2.Add("Key6", 6);

        Dictionary<string, int> expected = new()
        {
            ["Key2"] = 2,
            ["Key3"] = 3
        };

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        CollectionAssert.AreEqual(expected, result);
        Assert.That(result["Key2"], Is.EqualTo(expected["Key2"]));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new();
        dict1.Add("Key1", 1);
        dict1.Add("Key2", 2);
        dict1.Add("Key3", 3);

        Dictionary<string, int> dict2 = new();
        dict2.Add("Key1", 4);
        dict2.Add("Key2", 5);
        dict2.Add("Key3", 6);

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // Bonus test - not for Judge
    [Test]
    public void Test_Intersect_FirstDictionaryNotEmptyAndSecondEmptyDictionary_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new(); 
        dict1.Add("Key1", 1);
        dict1.Add("Key2", 2);
        dict1.Add("Key3", 3);

        Dictionary<string, int> dict2 = new(); // empty

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.Empty);
    }
}
