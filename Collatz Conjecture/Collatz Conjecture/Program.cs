using System;

namespace Collatz_Conjecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int counter = 0;

            while (x >= 1)
            {
                while (x != 1)
                {
                    int y = x % 2;
                    if (y == 0)
                    {
                        x = x / 2;
                    }
                    else
                    {
                        x = x * 3 + 1;
                    }
                    Console.WriteLine(x);
                    counter++;
                }
                x++;
            }
            Console.WriteLine("It took {0} times!", counter);
            Console.WriteLine(x);


        }
    }
}
