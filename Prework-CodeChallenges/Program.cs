using System;

namespace Prework_CodeChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ArrayMaxResult();
        }

        static void ArrayMaxResult()
        {
            //  create an array with a size of 5 to have numbers in
            int[] Nums = new int[5];

            // tell user to input his array elements
            Console.WriteLine("Please input 5 numbers between 1-10");

            //loop 5 times and ask for input to add to the array
            for (int i = 0; i < Nums.Length; i++)
            {
                Nums[i] = Convert.ToInt32(Console.ReadLine());

            }

            //loop to print it
            for (int i = 0; i < Nums.Length; i++)
            {
                Console.Write(Nums[i] + " ");
            }

            //Show user his array
            Console.WriteLine("is your array, now select a number from the array!");

            //store the inputted value into a
            int val = Convert.ToInt32(Console.ReadLine());
          if (val%2 == 0)   

            Console.WriteLine($"Your computated score is: {val*2} ");
         else   Console.WriteLine($"Your computated score is: {val} ");
        }
    }

}
