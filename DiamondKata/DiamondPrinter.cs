using System.Text;

namespace DiamondKata
{
    public class DiamondPrinter
    {
        public static string Print(char input)
        {
            if (input < 'A' || input > 'Z')
            {
                throw new ArgumentException("The given character is not a character from the alphabet");
            }

            var builder = new StringBuilder();

            for (char character = 'A'; character <= input; character++)
            {
                int characterDistanceFromInput = input - character;
                int characterDistanceFromLetterA = character - 'A';

                if (characterDistanceFromLetterA > 0)
                {
                    builder.AppendLine();
                }

                builder.Append(' ', characterDistanceFromInput).Append(character);

                if (characterDistanceFromLetterA > 0)
                {
                    builder.Append(' ', (characterDistanceFromLetterA * 2) - 1).Append(character);
                }
            }

            for (char character = (char)(input - 1); character >= 'A'; character--)
            {
                int characterDistanceFromLetterA = character - 'A';
                int characterDistanceFromInput = input - character;

                builder.AppendLine();
                builder.Append(' ', characterDistanceFromInput).Append(character);

                if (characterDistanceFromLetterA > 0)
                {
                    builder.Append(' ', characterDistanceFromLetterA).Append(character);
                }
            }

            return builder.ToString();
        }
    }
}
