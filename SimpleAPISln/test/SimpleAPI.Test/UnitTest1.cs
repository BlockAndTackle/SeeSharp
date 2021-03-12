using System;
using Xunit;
using SimpleApi.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {

        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void GetReturnsWeather()
        {
            var returnvalue = controller.Get(1);
            Assert.Equal(IEnumerable<WeatherForecast>, returnvalue)
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
