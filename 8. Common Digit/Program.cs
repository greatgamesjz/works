using System;

namespace _8._Common_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            if (Int32.TryParse(Console.ReadLine(), out n));
            {
                int maxSum = -1, maxIndex = -1,s;
                string input = Console.ReadLine();
                string[] token = input.Split(' ');
                int[] numbers = Array.ConvertAll(token, int.Parse);
                for (int i=0;i<n;i++)
                {
                    s = sum(numbers[i]);
                    if (s>maxSum)
                    {
                        maxSum = s;
                        maxIndex = i;
                    }
                    else if(s==maxSum)
                    {
                        if(numbers[i]>numbers[maxIndex])
                        {
                            maxSum = s;
                            maxIndex = i;
                        }
                    }
                }
                Console.WriteLine(maxIndex);
            }

        }
        static int sum(int num)
        {
            int w = 0;
            do
            {
                w += num % 10;
                num /= 10;
            } while (num > 0);
            return w;
        }
    }
}
