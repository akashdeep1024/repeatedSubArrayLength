using System;

namespace RepeatedSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //A: [1,2,3,2,1]
            //B: [3, 2, 1, 4, 7]
            //Get the count of the repeated subarray 

            int[] A = { 1, 2, 3, 2, 1 };
            int[] B = { 3, 2, 1, 4, 7 };
            int rpeatedSubarrayLength = 0;
            int[,] temp = new int[A.Length+1, B.Length+1];


            for (int i = A.Length - 1; i >= 0; --i)
            {
                for (int j = B.Length - 1; j >= 0; --j)
                {
                    if (A[i] == B[j])
                    {
                        temp[i, j] = temp[i + 1, j + 1] + 1;
                        if (rpeatedSubarrayLength < temp[i, j])
                        {
                            rpeatedSubarrayLength = temp[i, j];
                        }
                    }
                }
                
            }
            Console.WriteLine("Repeated SubArray Length: "+ rpeatedSubarrayLength);
        }
    }
}
