using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newTasks
{
    public class Switches
    {
        public void switchTask()
        {
            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ");
            try
            {
                Console.WriteLine("Writing a program that takes a number between 1 and 7 (representing days of the week) and prints the name of the day (e.g., 1 = \"Monday\")");
                Console.WriteLine(" ");
                Console.Write("Enter a Number(1-7): ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("Wrong Input, Try again later..");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Creating a simple menu program using a `switch` statement where the user can choose options to perform simple actions like add, subtract, etc");
                Console.Write("Enter 1st Number:  ");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.Write("Enter 2nd Number:  ");
                int number2 = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.Write("Enter operator(%,-,/,+,*):  ");
                string op = Console.ReadLine();
                switch (op)
                {
                    case "+":
                        Console.WriteLine(number1 + number2);
                        break;
                    case "-":
                        Console.WriteLine(number1 - number2);
                        break;
                    case "*":
                        Console.WriteLine(number1 * number2);
                        break;
                    case "%":
                        if (number2 == 0)
                        {
                            Console.WriteLine("Cannot perform modulus with 0.");
                        }
                        else
                        {
                            Console.WriteLine(number1 % number2);
                        }
                        break;
                    case "/":
                        if (number2 > 0)
                        {
                            Console.WriteLine(number1 / number2);
                        }
                        else
                        {
                            Console.WriteLine("Invalid (2nd Number can't be 0)");
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong Input..");
                        break;

                }
                Console.WriteLine();
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
