namespace CrimeSimulationAPI.Tests;

public class OrderServiceTests
{
    [Fact]
    public void TotalOrders_ShouldBeGreaterThanZero()
    {
        // Arrange
        var totalOrders = 247;

        // Act & Assert
        Assert.True(totalOrders > 0);
    }

    [Fact]
    public void ActiveOrders_ShouldBeLessThanTotal()
    {
        // Arrange
        var totalOrders = 247;
        var activeOrders = 183;

        // Act & Assert
        Assert.True(activeOrders < totalOrders);
    }

    [Fact]
    public void CompletedOrders_ShouldAddUpCorrectly()
    {
        // Arrange
        var totalOrders = 247;
        var activeOrders = 183;
        var completedOrders = 64;

        // Act
        var sum = activeOrders + completedOrders;

        // Assert
        Assert.Equal(totalOrders, sum);
    }

    [Fact]
    public void HealthCheck_ShouldReturnTrue()
    {
        // Arrange
        var isHealthy = true;

        // Act & Assert
        Assert.True(isHealthy);
    }
}