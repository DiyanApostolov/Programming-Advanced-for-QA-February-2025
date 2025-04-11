using System;
using System.Text;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests;

[TestFixture]
public class InventoryTrackingSystemTests
{
    private InventoryTrackingSystem _inventoryTrackingSystem = null!;

    [SetUp]
    public void SetUp()
    {
        this._inventoryTrackingSystem = new();
    }

    [Test]
    public void Test_Constructor_CheckInitialEmptyItemCollectionAndCount()
    {
        Assert.That(_inventoryTrackingSystem.ItemCount, Is.EqualTo(0));
    }

    [Test]
    public void Test_AddItem_ValidItemName_AddNewItem()
    {
        // Arrange
        string itemName = "item1";
        List<string> expected = new List<string>()
        {
            itemName
        };
        // Act
        _inventoryTrackingSystem.AddItem(itemName);
        List<string> actual = _inventoryTrackingSystem.GetAllItems();

        // Assert
        Assert.That(_inventoryTrackingSystem.ItemCount, Is.EqualTo(1));
        //Assert.That(actual, Does.Contain(itemName));
        Assert.That(actual[0], Is.EqualTo(itemName));
        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_AddItem_NullOrEmptyItemName_ThrowsArgumentException()
    {
        Assert.That(() => _inventoryTrackingSystem.AddItem(null), Throws.ArgumentException);
        Assert.That(() => _inventoryTrackingSystem.AddItem(string.Empty), Throws.ArgumentException);
        Assert.That(() => _inventoryTrackingSystem.AddItem(" "), Throws.ArgumentException);
    }

    [Test]
    public void Test_RemoveItem_ValidItemName_RemoveFirstItemName()
    {
        // Arrange
        string item1Name = "item1";
        string item2Name = "item2";
        string expectedAsString = "item1 item2";
        List<string> expected = new List<string>()
        {
            item1Name,
            item2Name
        };

        // Act
        _inventoryTrackingSystem.AddItem(item1Name);
        _inventoryTrackingSystem.AddItem(item2Name);
        _inventoryTrackingSystem.AddItem(item2Name);
        _inventoryTrackingSystem.RemoveItem(item2Name);
        List<string> actual = _inventoryTrackingSystem.GetAllItems();

        // Assert
        Assert.That(_inventoryTrackingSystem.ItemCount, Is.EqualTo(2));
        Assert.That(actual, Does.Contain(item1Name));
        Assert.That(actual, Does.Contain(item2Name));
        Assert.That(string.Join(" ", actual), Is.EqualTo(expectedAsString));
        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_RemoveItem_NullOrEmptyItemName_ThrowsArgumentException()
    {
        Assert.That(() => _inventoryTrackingSystem.RemoveItem(null), Throws.ArgumentException);
        Assert.That(() => _inventoryTrackingSystem.RemoveItem(string.Empty), Throws.ArgumentException);
        Assert.That(() => _inventoryTrackingSystem.RemoveItem(" "), Throws.ArgumentException);
    }

    [Test]
    public void Test_GetAllItems_AddedAndRemovedItems_ReturnsExpectedItemCollection()
    {
        // Arrange
        string item1Name = "item1";
        string item2Name = "item2";
        string expectedAsString = "item1 item2";
        List<string> expected = new List<string>()
        {
            item1Name,
            item2Name
        };

        // Act
        _inventoryTrackingSystem.AddItem(item1Name);
        _inventoryTrackingSystem.AddItem(item2Name);
        _inventoryTrackingSystem.AddItem(item2Name);
        _inventoryTrackingSystem.RemoveItem(item2Name);
        List<string> actual = _inventoryTrackingSystem.GetAllItems();

        // Assert
        Assert.That(_inventoryTrackingSystem.ItemCount, Is.EqualTo(2));
        Assert.That(actual, Does.Contain(item1Name));
        Assert.That(actual, Does.Contain(item2Name));
        Assert.That(string.Join(" ", actual), Is.EqualTo(expectedAsString));
        CollectionAssert.AreEqual(actual, expected);
    }
}
