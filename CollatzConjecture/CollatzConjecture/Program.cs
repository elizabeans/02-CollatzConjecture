using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzConjecture
{
    class Program
    {
        static int GetIntegerFromConsole(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(prompt);
                    string input = Console.ReadLine();
                    int x = int.Parse(input);
                    return x;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a number.");
                }
            }
        }

        static void Main(string[] args)
        {
            int input = GetIntegerFromConsole("Enter a number");
            int n = input;
            int numOfSteps = 0;
            int peak = 0;
            int peakSteps = 0;


            while( n > 1 )
            {
                numOfSteps++;

                if ( (n%2) == 0 )
                {
                    n = n / 2;

                        if (n > peak)
                        {
                            peak = n;
                            peakSteps = numOfSteps;
                        }
                }
                else
                {
                    n = (n * 3) + 1;

                        if (n > peak)
                        {
                            peak = n;
                            peakSteps = numOfSteps;
                        }
                }

                
            }
            Console.WriteLine("It takes " + numOfSteps + " to reach 1 from " + input + ".");
            Console.WriteLine("The value reaches its peak of " + peak + " at step " + peakSteps + ".");
            Console.ReadLine();
        }
    }
}
