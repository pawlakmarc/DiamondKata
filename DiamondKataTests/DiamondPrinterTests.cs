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

        [Fact]
        public void Print_ReturnsTwoBLettersInSecondRow_WhenGivenLetterB()
        {
            //Arrange
            var expected = "B B";

            //Act
            var actual = DiamondPrinter.Print('B').Split(Environment.NewLine)[1];

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}