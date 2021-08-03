using System;

namespace Collatz_Conjecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //defining all the variables
            int x = 5;
            int z = x;
            int y = 0;
            int counter = 0;

            //while loop to detirmine how many numbers to run through for example : 5 - 1000
            while (x < 11)
            {
                //while loop to run the eqaution
                while (z != 1)
                {
                    //calculate if x is even or odd
                    y = z % 2;
                    //even it runs x/2
                    if (y == 0)
                    {
                        z = z / 2;
                        Console.WriteLine("Even (Equation: x/2) {0}", z);
                    }
                    //odd it runs x*3+1
                    else
                    {
                        z = z * 3 + 1;
                        Console.WriteLine("Odd (Equation: 3*x+1) {0}", z);
                    }
                    //adds to a counter each time it runs to show user how many times it takes for x to get to 1
                    counter++;
                }
                //adds 1 to x for the next number
                x++;
                //resets z to equal next number
                z = x;
                //prints counter to show user
                Console.WriteLine("It took {0} times!", counter);
                //prints next number
                Console.WriteLine("Next number: {0}", x);
                //resets counter for next number
                counter = 0;
            }
        }
    }
}
