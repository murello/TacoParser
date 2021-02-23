using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("33.524131,-86.724876,Taco Bell Birmingham...", -86.724876)]
        [InlineData("32.92496,-85.961342,Taco Bell Alexander Cit...", -85.961342)]
        [InlineData("30.731386,-86.566652,Taco Bell Crestvie...", -86.566652)]
        [InlineData("33.949936,-86.470697,Taco Bell Oneonta...", -86.470697)]
        public void ShouldParseLongitude(string line, double expected)

        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Longitude);


        }


        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("33.524131,-86.724876,Taco Bell Birmingham...", 33.524131)]
        [InlineData("32.92496,-85.961342,Taco Bell Alexander Cit...", 32.92496)]
        [InlineData("30.731386,-86.566652,Taco Bell Crestvie...", 30.731386)]
        [InlineData("33.949936,-86.470697,Taco Bell Oneonta...", 33.949936)]
        public void ShouldParseLatitude(string line, double expected)

        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Latitude);


        }


    }
}
