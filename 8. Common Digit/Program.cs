using System;

namespace _8._Common_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int maxIndex = 0, maxValue = 0;
            int[] digitSum = new int[10];
            for (int i = 0; i < 10; i++)
                digitSum[i]=0;
            if (Int32.TryParse(Console.ReadLine(), out n));
                string digits = Console.ReadLine();
            for (int i = 0; i < digits.Length; i++)
                if (digits[i] >= '0' && digits[i] <= '9')
                    digitSum[digits[i] - '0']++;
            for(int i=9;i>=0;i--)
                if(digitSum[i]>maxValue)
                {
                    maxIndex = i;
                    maxValue = digitSum[i];
                }
            Console.WriteLine(maxIndex);

        }
    }
}
