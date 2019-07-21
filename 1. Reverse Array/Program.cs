using System;

namespace _1._Reverse_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] arr;
            int num;
            bool success;
            do
            {
                success = Int32.TryParse(Console.ReadLine(), out n);
                if (!success)
                    Console.WriteLine("NaN");
            } while (!success);
            arr = new int[n];
            for(int i=0;i<n;i++)
            {
                success = Int32.TryParse(Console.ReadLine(), out num);
                if (success)
                    arr[i] = num;
                else
                {
                    i--;
                    Console.WriteLine("NaN");
                }
            }
            for (int i = n - 1; i >= 0; i--)
                Console.Write(arr[i] + " ");
                
        }
    }
}
