using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newTasks
{
    public class Variables
    {
        public void variablesTask()
        {
            try
            {
                Console.WriteLine("Creating a program that declares several variables of different types and then prints them out.");
                Console.WriteLine();
                Console.WriteLine("So, here is the program with several variables: ");
                Console.WriteLine(" ");
                string input = "";
                string yes;
                while (input != "yes")
                {
                    Console.Write("PLZ SAY YES TO CONTINUE.......:");
                    if (input == "yes")
                    {
                        break;
                    }
                    input = Console.ReadLine();
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");


                string name = "IMRAN KHAN";
                int age = 74;
                bool real = true;
                float prisonDays = 710.1f;
                double time = 9.40;
                decimal price = 0;

                Console.WriteLine("The name is " + name);
                Console.WriteLine("The age is " + age);
                Console.WriteLine("The bool is " + real);
                Console.WriteLine("The float is " + prisonDays);
                Console.WriteLine("The double is " + time);
                Console.WriteLine("The price is " + price);
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(" ");


                Console.WriteLine(" Create a program that stores your age in one variable, and your height in another, and then prints both.");
                Console.WriteLine("Now creating another program, ");
                Console.WriteLine(" ");


                Console.WriteLine("Now write your height and age below:");
                Console.Write("Age: ");
                int ages = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("And your height?: ");
                Console.WriteLine("Height: ");
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("So your age is " + ages + " and height is " + height);
                Console.WriteLine();
                Console.WriteLine(" ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }
        }
    }
}
