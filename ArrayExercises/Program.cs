using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = {1, 1, 2, 3, 5, 8 };
            
            // loop through and print each value in array with for loop
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine(numArray[i]);
            }

            // loop through and print only odd values in array with foreach loop
            foreach (int num in numArray)
            {   if(num%2 != 0) 
                Console.WriteLine(num);
            }

            
        }
    }
}
