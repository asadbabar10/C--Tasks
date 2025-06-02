using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newTasks
{
    public class Arrays
    {
        public void arraysTask()
        {
            try
            {
                Console.WriteLine("Creating an array of integers and printing out the first and last elements of the array");
                Console.WriteLine(" ");
                int[] elements = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                foreach (int i in elements)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine(" ");
                Console.WriteLine("This is an array of integers. Now printing out the first and last elements of the array,");
                Console.WriteLine(" ");
                string input;
                do
                {
                    Console.WriteLine("Enter \"YES\" to continue....");
                    input = Console.ReadLine();

                    if (input.ToLower() == "yes")
                    {
                        Console.WriteLine(elements[0]);
                        Console.WriteLine(" ");
                        Console.WriteLine(elements[9]);
                    }
                    else
                    {
                        Console.WriteLine("Just put \"Yes\"");
                    }
                    Console.WriteLine(" ");

                } while (input.ToLower() != "yes");

                Console.WriteLine(" ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("NOW NEW TASK...");
                Console.WriteLine("Write a program that takes FIVE numbers from the user and stores them in an array, then calculates the average of those numbers.");
                Console.WriteLine("So user...JUST enters your five numbers/integers that you want to be stored in array..");
                Console.WriteLine(" ");

                Console.Write("Number 1:  ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Number 2:  ");
                int num2 = int.Parse(Console.ReadLine());
                Console.Write("Number 3:  ");
                int num3 = int.Parse(Console.ReadLine());
                Console.Write("Number 4:  ");
                int num4 = int.Parse(Console.ReadLine());
                Console.Write("Number 5:  ");
                int num5 = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("So here is the sorted array of your Numbers: ");
                int[] numbers = { num1, num2, num3, num4, num5 };
                Array.Sort(numbers);
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
                int sum = num1 + num2 + num3 + num4 + num5;
                double average = sum / 5.0;
                Console.WriteLine(" ");
                Console.WriteLine("So the average of the numbers are below:");
                Console.WriteLine("Average: " + average);
                Console.WriteLine(" ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Now creating a program that reverses an array of strings and prints the reversed array.");
                Console.WriteLine(" ");
                Console.WriteLine("Here is the array of FRUITS:");
                string[] fruits = { "Apples", "Bananas", "Stawberries", "Oranges", "Graphes" };
                foreach (string fruit in fruits)
                {
                    Console.WriteLine(fruit);
                }
                Console.WriteLine(" ");
                Console.WriteLine("Now getting the reverse of fruit's array");
                string put;
                do
                {
                    Console.WriteLine("Enter \"YES\" to continue....");
                    put = Console.ReadLine();

                    if (put.ToLower() == "yes")
                    {
                        Array.Reverse(fruits);
                        foreach (string i in fruits)
                        {
                            Console.WriteLine(i);
                        }
                    }

                    else
                    {
                        Console.WriteLine("Try again, just put \"Yes\"...");
                    }
                    Console.WriteLine(" ");
                } while (put.ToLower() != "yes");
                Console.WriteLine(" ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("So it is the \"END\" of Tasks......");
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