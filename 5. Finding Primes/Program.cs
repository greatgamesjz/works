using System;

namespace _5._Finding_Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            int t, start, end;
            Int32.TryParse(Console.ReadLine(), out t);
            while((t--)>0)
            {
                Int32.TryParse(Console.ReadLine(), out start);
                Int32.TryParse(Console.ReadLine(), out end);
                Console.WriteLine(countPrimes(start, end));
            }
      
        }
        private static int countPrimes(int start,int end)
        {
            int count = 0;
            for(int i=start;i<=end;i++)
            {
                if (isPrime(i))
                    count++;
            }
            return count;
        }
        private static bool isPrime(int num)
        {
            if (num < 2)
                return false;
            for(int i=2;i*i<=num;i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
