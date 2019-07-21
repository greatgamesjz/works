using System;
using System.Collections;

namespace _4._Existing_powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList decomposedNums = new ArrayList();
            string input;
            uint num;
            while((input = Console.ReadLine())!="")
            {
                if (UInt32.TryParse(input, out num))
                {
                    decomposeNum(num, decomposedNums);
                }
                else Console.WriteLine("NaN");
            }
            if (decomposedNums.Count > 0)
            {
                decomposedNums.Sort();
                foreach (uint number in decomposedNums)
                {
                    Console.Write(number + " ");
                }
            }
            else Console.WriteLine("NA");
        }
        private static void decomposeNum(uint num,ArrayList decomposedNums)
        {
            uint i = 1;
            while(i<=num)
            {
                if ((i & num) != 0)
                {
                    if(!decomposedNums.Contains(i))
                        decomposedNums.Add(i);
                }
                i <<= 1;
            }
        }
    }
}
