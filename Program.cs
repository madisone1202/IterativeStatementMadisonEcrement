using System;

namespace IterativeStatementMadisonEcrement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Integer between 2 and 10: ");

            string number = Console.ReadLine();
            int valueofnumber = int.Parse(number);

            if (valueofnumber % 2==0)
            {
                for (int r = 1; r < valueofnumber + 2; r++)
                {
                    Console.WriteLine(r.ToString() + "." + "You entered an even number");
                }
            }
            else
            {
                for (int r = 1; r < valueofnumber + 0; r++)
                {
                    Console.WriteLine(r.ToString() + "." + "You entered an odd number");
                }
            }

        }
    }
}
