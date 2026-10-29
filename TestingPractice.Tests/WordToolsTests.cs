namespace TestingPractice.Tests;

[TestClass]
public class WordToolsTests
{
    // An example to start from. It passes: WordTools gets this one right.
    [TestMethod]
    public void IsPalindrome_ForLevel_IsTrue()
    {
        // Arrange
        WordTools tools = new WordTools();

        // Act
        bool result = tools.IsPalindrome("level");

        // Assert
        Assert.IsTrue(result);
    }
}
