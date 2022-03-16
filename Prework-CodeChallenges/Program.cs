using System;

namespace Prework_CodeChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //ArrayMaxResult(); 
           // LeapYearCalculator();
            PerfectSequence();
        }

        static void ArrayMaxResult()
        {
            int[] Nums = new int[5];
            Console.WriteLine("Please input 5 numbers between 1-10");
            for (int i = 0; i < Nums.Length; i++)
            {
                Nums[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < Nums.Length; i++)
            {
                Console.Write(Nums[i] + " ");
            }
            Console.WriteLine("is your array, now select a number from the array!");
            int val = Convert.ToInt32(Console.ReadLine());
          if (val%2 == 0)   
            Console.WriteLine($"Your computated score is: {val*2} ");
         else   Console.WriteLine($"Your computated score is: {val} ");
        }

        static void LeapYearCalculator()
        {
            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0)) Console.WriteLine($"{Year} is a Leap Year.");
            else Console.WriteLine($"{Year} is not a Leap Year.");
        }
       static void PerfectSequence()
        {
            int[] seq = new int[3];
            Console.WriteLine("Please input 3 numbers");
            for (int i = 0; i < seq.Length; i++)
            {
                seq[i] = Convert.ToInt32(Console.ReadLine());

            }
            if (seq[0] + seq[1] + seq[2] == seq[0] * seq[1] * seq[2]) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }

}
