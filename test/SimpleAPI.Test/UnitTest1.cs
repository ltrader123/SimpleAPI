using System;
using Xunit;
using SimpleAPI.Controllers;
using System.Collections.Generic;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {

        SimpleAPI.Controllers.WeatherForecastController _controller = new WeatherForecastController();

        [Fact]
        public void GetReturnsMyName()
        {
            IEnumerable<WeatherForecast> result = _controller.Get();

            Assert.True(true, "Should be true!!");
        }

        [Fact]
        public void Test1()
        {
            Assert.True(true);

        }
    }
}
