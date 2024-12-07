using my_api.Services;

namespace unitTests;

public class WeatherForecastServiceTests
{
    [Fact]
    public void GetWeatherForecast_ShouldReturnFiveForecasts()
    {
        //Arrange
        var service = new WeatherForecastService();

        //Act
        var forecasts = service.GetWeatherForecasts();

        //Assert
        Assert.NotNull(forecasts);
        Assert.Equal(5, forecasts.Length);
    }

    [Fact]
    public void GetWeatherForecasts_ShouldContainValidData()
    {
        // Arrange
        var service = new WeatherForecastService();

        // Act
        var forecasts = service.GetWeatherForecasts();

        // Assert
        foreach (var forecast in forecasts)
        {
            Assert.InRange(forecast.TemperatureC, -20, 55);
            Assert.False(string.IsNullOrEmpty(forecast.Summary));
        }
    }
}