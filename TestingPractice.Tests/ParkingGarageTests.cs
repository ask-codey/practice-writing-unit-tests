namespace TestingPractice.Tests;

[TestClass]
public class ParkingGarageTests
{
    // An example to start from. It passes: the garage gets this one right.
    [TestMethod]
    public void Cost_ForHalfAnHour_IsTheFirstHourRate()
    {
        // Arrange
        ParkingGarage garage = new ParkingGarage();

        // Act
        decimal cost = garage.Cost(30);

        // Assert
        Assert.AreEqual(3.00m, cost);
    }
}
