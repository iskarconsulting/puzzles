using System;
using System.Text;

namespace StringCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "aaaaabbbcccccccdddd";

            StringBuilder sb = new StringBuilder();

            int length = input.Length;

            int blockStartPosition = 0;

            if (length > 0)
            {
                char currentCharacter = input[0];

                for (int i = 0; i < length; i++)
                {
                    if (!input[i].Equals(currentCharacter))
                    {
                        sb.Append(input[blockStartPosition] + (i - blockStartPosition).ToString());

                        currentCharacter = input[i];
                        blockStartPosition = i;
                    }
                }

                // Add the final block
                sb.Append(input[blockStartPosition] + (length - blockStartPosition).ToString());
            }

            Console.WriteLine("Compressed string: " + sb.ToString());

        }
    }
}
