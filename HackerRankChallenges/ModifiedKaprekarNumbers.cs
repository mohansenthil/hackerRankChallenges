using System;
using System.Text;

namespace HackerRankChallenges
{
    public class ModifiedKaprekarNumbers
    {

        public static void KaprekarNumbers(int startRange, int endRange)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = startRange; i <= endRange; i++)
            {
                ulong squareRootOfWholeNumber = (ulong)i * (ulong)i;

                var squareRootOfWholeNumberAsText = squareRootOfWholeNumber.ToString();

                uint addtionOfTwoNumbers = 1;

                if (squareRootOfWholeNumberAsText.Length > 1)
                {
                    var firstPart = squareRootOfWholeNumberAsText.Substring(0, squareRootOfWholeNumberAsText.Length / 2);
                    var secondPart = squareRootOfWholeNumberAsText.Substring((squareRootOfWholeNumberAsText.Length / 2));

                    addtionOfTwoNumbers = Convert.ToUInt32(firstPart) + Convert.ToUInt32(secondPart);

                }

                if (addtionOfTwoNumbers == i)
                    builder.Append(i + " ");

            }

            if (builder.Length > 0)
            {
                Console.WriteLine(builder);
            }
            else
            {
                Console.WriteLine("INVALID RANGE");
            }

        }
    }
}
