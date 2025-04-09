using NUnit.Framework;
using System;
using System.Text;
using TestApp.Library;

namespace TestApp.Tests;

[TestFixture]
public class LibraryCatalogTests
{
    private LibraryCatalog _catalog = null!;

    [SetUp]
    public void SetUp()
    {
        _catalog = new LibraryCatalog();
    }

    [Test]
    public void Test_AddBook_BookAddedToCatalog()
    {
        // Arrange
        string isbn = "ISBN 123-456-7-89";
        string title = "The Lord Of The Rings";
        string author = "J.R.R.Tolkien";

        // Act
        _catalog.AddBook(isbn, title, author);
        Book result = _catalog.GetBook("ISBN 123-456-7-89");

        // Assert
        Assert.That(result.Isbn, Is.EqualTo(isbn));
        Assert.That(result.Title, Is.EqualTo(title));
        Assert.That(result.Author, Is.EqualTo(author));
    }

    [Test]
    public void Test_GetBook_BookExists_ReturnsBook()
    {
        // Arrange
        string isbn = "ISBN 123-456-7-89";
        string title = "The Lord Of The Rings";
        string author = "J.R.R.Tolkien";

        // Act
        _catalog.AddBook(isbn, title, author);
        _catalog.AddBook("ISBN 283-47-289", "Title 1", "Author 1");
        _catalog.AddBook("ISBN 282342-7289", "Title 2", "Author 2");
        _catalog.AddBook("ISBN 283-4235-9", "Title 3", "Author 3");

        Book result = _catalog.GetBook(isbn);

        // Assert
        Assert.That(result.Isbn, Is.EqualTo(isbn));
        Assert.That(result.Title, Is.EqualTo(title));
        Assert.That(result.Author, Is.EqualTo(author));
    }

    [Test]
    public void Test_GetBook_BookDoesNotExist_ThrowsArgumentException()
    {
        // Arrange
        _catalog.AddBook("ISBN 283-47-289", "Title 1", "Author 1");
        _catalog.AddBook("ISBN 282342-7289", "Title 2", "Author 2");
        _catalog.AddBook("ISBN 283-4235-9", "Title 3", "Author 3");

        // Act + Assert
        Assert.Throws<ArgumentException>(() => _catalog.GetBook("invalid ISBN"));
    }

    [Test]
    public void Test_DisplayCatalog_NoBooks_ReturnsEmptyString()
    {
        // Act
        string result = _catalog.DisplayCatalog();

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_DisplayCatalog_WithBooks_ReturnsFormattedCatalog()
    {
        // Arrange
        _catalog.AddBook("ISBN 283-47-289", "Title 1", "Author 1");
        _catalog.AddBook("ISBN 282342-7289", "Title 2", "Author 2");
        _catalog.AddBook("ISBN 283-4235-9", "Title 3", "Author 3");

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Library Catalog:");
        sb.AppendLine($"Title 1 by Author 1 (ISBN: ISBN 283-47-289)");
        sb.AppendLine($"Title 2 by Author 2 (ISBN: ISBN 282342-7289)");
        sb.AppendLine($"Title 3 by Author 3 (ISBN: ISBN 283-4235-9)");

        string expected = sb.ToString().Trim();

        // Act
        string result = _catalog.DisplayCatalog();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
