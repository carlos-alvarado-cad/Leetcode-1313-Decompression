using System;
using System.Collections.Generic;

namespace Decompression
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test1 = { 4, 5, 4, 10, 2, 5 };
            int[] test2 = { 1, 1, 1, 2, 1, 3, 1, 4, 1, 5 };
            int[] test3 = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };
            int[] test4 = { 5, 1, 4, 2, 3, 3, 2, 4, 1, 5 };

            int[] result1 = Decode(test1);
            foreach (int num in result1)
            {
                Console.Write(num + ", ");
            }
        }

        public static int[] Decode(int[] rleData)
        {
            List<int> decodedList = new List<int>();
            for (int i = 0, j = 1; i < rleData.Length; i += 2, j += 2)
            {
                for (int h = 0; h < rleData[i]; h++)
                {
                    decodedList.Add(rleData[j]);
                }
            }
            int[] decodedArray = decodedList.ToArray();
            return decodedArray;
        }
    }
}
