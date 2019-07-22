using System;

namespace _8._Common_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int maxIndex = 0, maxValue = 0;
            int[] digitCount = new int[10];
            for (int i = 0; i < 10; i++)
                digitCount[i] = 0;
            if (Int32.TryParse(Console.ReadLine(), out n)) ;
            string digits = Console.ReadLine();
            for (int i = 0; i < digits.Length; i++)
                if (digits[i] >= '0' && digits[i] <= '9')
                    digitCount[digits[i] - '0']++;
            for (int i = 9; i >= 0; i--)
                if (digitCount[i] > maxValue)
                {
                    maxIndex = i;
                    maxValue = digitCount[i];
                }
            Console.WriteLine(maxIndex);

        }
    }
}