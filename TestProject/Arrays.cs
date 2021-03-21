using System;

namespace TestProject
{
    public class Arrays
    {

        public static int FoundMax2nd(int[] inputArray)
        {
            int max;
            int secmax;
            int arr_lengeth = inputArray.Length;
            if (arr_lengeth < 1)
                throw new ArgumentException("array is not full");
            else if (arr_lengeth < 2)
                throw new ArgumentException("array is too short");


            // Decide on first two numbers
            if (inputArray[0] > inputArray[1])
            {
                max = inputArray[0];
                secmax = inputArray[1];
            }
            else
            {
                secmax = inputArray[0];
                max = inputArray[1];
            }
            // Loop through remaining numbers
            for (int i = 2; i < inputArray.Length; ++i)
            {
                if (inputArray[i] > max)
                {
                    secmax = max;
                    max = inputArray[i];
                }
                else if (inputArray[i] > secmax /*&& inputArray[i] != max/*removes duplicate problem*/
                    )
                    secmax = inputArray[i];
            }
            return secmax;
        }

        static void Main(string[] args)
        {
            //#include <iostream>

            int[] testArr = { 1, 8, 4, 5, 3, 9, 15, 300 };

            int secMax = FoundMax2nd(testArr);
            Console.Write(secMax);

            // return 0;

        }


    }
}
