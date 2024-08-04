namespace StringAnalysis
{
    public class Analyzer
    {
        public static int MaxUnequalConsecutive(string input)
        {
            if (string.IsNullOrEmpty(input)) return 0;

            int maxLength = 1;
            int currentLength = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    currentLength++;
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }

            return maxLength;
        }

        public static int MaxConsecutiveIdenticalLetters(string input)
        {
            if (string.IsNullOrEmpty(input)) return 0;

            int maxLength = 0;
            int currentLength = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]) && input[i] == input[i - 1])
                {
                    currentLength++;
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }

            return maxLength;
        }

        public static int MaxConsecutiveIdenticalDigits(string input)
        {
            if (string.IsNullOrEmpty(input)) return 0;

            int maxLength = 0;
            int currentLength = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]) && input[i] == input[i - 1])
                {
                    currentLength++;
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }

            return maxLength;
        }
    }
}

