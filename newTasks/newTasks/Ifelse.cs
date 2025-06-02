using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newTasks
{
    public class Ifelse
    {
        public void FindAge()
        {
            try
            {
                Console.WriteLine("Creating program that asks the user for their age and then prints a message saying whether they are a minor or an adult.");
                Console.WriteLine(" ");
                Console.Write("Your age: ");
                int age = int.Parse(Console.ReadLine());
                if (age > 0 && age < 16)
                {
                    Console.WriteLine("Ah! You are still Minor and kid...");
                }
                else if (age >= 18 && age < 100)
                {
                    Console.WriteLine("oh! You are an adult, good..");
                }
                else if (age >= 100)
                {
                    Console.WriteLine("Ah you are old enough, how interesting...");
                }
                else
                {
                    Console.WriteLine("Invalid age, try again later.");
                }
                Console.WriteLine(" ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(" ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }
        }

        public void CheckNum()
        {
            try
            {
                Console.WriteLine(" ");
                Console.WriteLine("Now writing a program that checks if a number entered by the user is positive, negative, or zero. ");
                Console.WriteLine(" ");
                Console.WriteLine("Enter a number of your choice to check out weather it is positive, negative or zero... ");
                Console.Write("Enter Number: ");
                decimal numbers = decimal.Parse(Console.ReadLine());

                if (numbers > 0)
                {
                    Console.WriteLine("It is a Positive Number...");
                }
                else if (numbers < 0)
                {
                    Console.WriteLine("It is a Negative Number...");
                }
                else if (numbers == 0)
                {
                    Console.WriteLine("It is Zero");
                }
                else
                {
                    Console.WriteLine("It is invalid input.Try again later....");
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
