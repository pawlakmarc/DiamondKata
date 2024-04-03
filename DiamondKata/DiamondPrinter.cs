using System.Text;

namespace DiamondKata
{
    public class DiamondPrinter
    {
        public static string Print(char input)
        {
            var builder = new StringBuilder();

            for (char character = 'A'; character <= input; character++)
            {
                int characterDistanceFromInput = input - character;
                int distanceFromLetterA = character - 'A';

                if (distanceFromLetterA > 0)
                {
                    builder.AppendLine();
                }

                builder.Append(' ', characterDistanceFromInput).Append(character);

                if (distanceFromLetterA > 0)
                {
                    builder.Append(' ', (distanceFromLetterA * 2) - 1).Append(character);
                }
            }

            return builder.ToString();
        }
    }
}
