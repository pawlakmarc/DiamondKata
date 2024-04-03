using DiamondKata;

namespace DiamondKataTests
{
    public class DiamondPrinterTests
    {
        [Fact]
        public void Print_ReturnsLetterA_WhenGivenLetterA()
        {
            //Arrange
            var expected = "A";

            //Act
            var actual = DiamondPrinter.Print('A');

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}