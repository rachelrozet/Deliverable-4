/* Author: Rachel Rozet
 * Date: 2/5/2023
 * Description: Create a Console application using an array to display the Fibonacci sequence for an input of 25
 * */

namespace Deliverable4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is intended to show the Fibonacci sequence for an input of 25.");

            int input = 25;

            if(input == 25)
            {
                int[] even = new int[input];
                int[] odd = new int[input];
                int[] fibonacci = new int[input];

                // Initialize fibonacci series
                fibonacci[0] = 0;
                fibonacci[1] = 1;
                
                for (int i = 0; i < input; i++)
                {
                    even[i] = 2 * i;
                    odd[i] = 2 * i + 1;

                    if(i >= 2)
                    {
                        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                    }

                    Console.WriteLine("Fibonacci number (" + i + ") = " + fibonacci[i]);

                }

            }
        }
    }
}