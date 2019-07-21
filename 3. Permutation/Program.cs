using System;

namespace _3._Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            const int elementsNum = 11;
            
            int[] arr1 = new int[elementsNum];
            int[] arr2 = new int[elementsNum];
            bool[] checkList = new bool[elementsNum];
            bool found;
            bool isPermutation=true;
            for (int i = 0; i < elementsNum; i++)
                checkList[i] = false;
            getArrays(arr1, elementsNum);
            getArrays(arr2, elementsNum);
            for(int i=0;i<elementsNum;i++)
            {
                found = false;
                for(int j=0;j<elementsNum;j++)
                {
                    if(arr1[i]==arr2[j] && !checkList[j])
                    {
                        found = true;
                        checkList[j] = true;
                        break;
                    }
                }
                if(!found)
                {
                    isPermutation = false;
                    break;
                }
            }
            if (isPermutation)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

        }
        private static void getArrays(int[] arr,int elementsNum)
        {
            bool success;
            int number;
            for (int i = 0; i < elementsNum; i++)
            {
                success = Int32.TryParse(Console.ReadLine(), out number);
                if (success)
                    arr[i] = number;
                else
                {
                    Console.WriteLine("It's not a number");
                    i--;
                }
            }
        }
    }
}
