using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newTasks
{
    public class Loops
    {
        public void loopsTask()
        {
            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ");
            try
            {
                Console.WriteLine("Writing a program that prints the numbers 1 through 10 using a `for` loop.");
                string input;
                do
                {
                    Console.WriteLine("Enter yes to continue....");
                    input = Console.ReadLine();
                    Console.WriteLine(" ");

                    if (input.ToLower() == "yes")
                    {
                        Console.WriteLine("ok so here is the for loop created from 1 to 10");
                        Console.WriteLine(" ");
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("INVALID, Try again...");
                    }
                } while (true);

                Console.WriteLine(" ");
                Console.WriteLine("New Task");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Creating a program that uses a `while` loop to print even numbers from 2 to 20.");
                Console.WriteLine(" ");


                int num = 2;
                do
                {
                    Console.WriteLine("Enter yes to continue....");
                    input = Console.ReadLine();

                    if (input.ToLower() == "yes")
                    {
                        Console.WriteLine("Below is the while loop: ");
                        Console.WriteLine(" ");
                        while (num <= 20)
                        {
                            Console.WriteLine(num);
                            num += 2;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("INVALID, Try again...");
                    }
                } while (true);

                Console.WriteLine();
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }
            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ");

        }
    }
}
