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

        [Fact]
        public void Print_ReturnsADiamondShapeWithLetterCOnOuterEdges_WhenGivenLetterC()
        {
            //Arrange
            var expected = $"  A{Environment.NewLine}" +
                           $" B B{Environment.NewLine}" +
                           $"C   C{Environment.NewLine}" +
                           $" B B{Environment.NewLine}" +
                           $"  A";

            //Act
            var actual = DiamondPrinter.Print('G');

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Print_ThrowsArgumentException_WhenGivenCharacterIsNotALetter()
        {
            //Act
            Action print = () => DiamondPrinter.Print('?');
            
            //Assert
            Assert.Throws<ArgumentException>(print);
        }

        [Fact]
        public void Print_ReturnsADiamondShapeWithLetterGOnOuterEdges_WhenGivenLetterG()
        {
            //Arrange
            var expected = $"      A{Environment.NewLine}" +
                           $"     B B{Environment.NewLine}" +
                           $"    C   C{Environment.NewLine}" +
                           $"   D     D{Environment.NewLine}" +
                           $"  E       E{Environment.NewLine}" +
                           $" F         F{Environment.NewLine}" +
                           $"G           G{Environment.NewLine}" +
                           $" F         F{Environment.NewLine}" +
                           $"  E       E{Environment.NewLine}" +
                           $"   D     D{Environment.NewLine}" +
                           $"    C   C{Environment.NewLine}" +
                           $"     B B{Environment.NewLine}" +
                           $"      A";

            //Act
            var actual = DiamondPrinter.Print('G');

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}