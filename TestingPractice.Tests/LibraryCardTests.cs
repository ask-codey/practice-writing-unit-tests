namespace TestingPractice.Tests;

[TestClass]
public class LibraryCardTests
{
    // An example to start from. It passes: the card gets this one right.
    [TestMethod]
    public void Borrow_OneBook_PutsItOnTheCard()
    {
        // Arrange
        LibraryCard card = new LibraryCard();

        // Act
        bool borrowed = card.Borrow("The Hobbit");

        // Assert
        Assert.IsTrue(borrowed);
        Assert.AreEqual(1, card.BorrowedCount);
        Assert.IsTrue(card.HasBook("The Hobbit"));
    }
}
