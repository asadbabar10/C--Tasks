using System;

namespace newTasks
{
    public class Operators
    {
        public void operatorsTask()
        {
            try
            {
                Console.WriteLine("Now writing a  program that uses comparison operators to check\n if a number is greater than, less than, or equal to another number.");
                int num1, num2;
                Console.WriteLine(" ");
                Console.WriteLine("Enter  your first number to check");
                Console.Write("1st Number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Enter  your second number to check");
                Console.Write("2nd Number: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                if (num1 > num2)
                {
                    Console.WriteLine("Num1 is \"Greater \" than Num2");
                }
                else if (num1 < num2)
                {
                    Console.WriteLine("Num1 is \"Less than\" Num2");
                }
                else
                {
                    Console.WriteLine("Both are \"Equal \"");
                }

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(" ");

                Console.WriteLine("Now creating a program that uses logical operators to check if a number is within a given range(10-20). ");
                int number1, number2;
                int minNum = 10;
                int maxNum = 20;
                Console.WriteLine("Enter Numbers to check accordingly, weather the numbers are in a given range or not");
                Console.Write("Number 1: ");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Console.Write("Number 2: ");
                number2 = Convert.ToInt32(Console.ReadLine());
                if (number1 >= minNum && number2 <= maxNum)
                {
                    Console.WriteLine("It is in the range.");
                }
                else
                {
                    Console.WriteLine("It is not in the range.");
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(" ");
             }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }
}
    }
}
