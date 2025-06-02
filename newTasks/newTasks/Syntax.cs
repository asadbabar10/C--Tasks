using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newTasks
{
    public class Syntax
    {
        public void syntaxTask()
        {
            try
            {
                string userchoice;
                do
                {

                    Console.WriteLine("\n Here is a program that declares and initializes\n " +
                        "variables of different data types (e.g., string, int, double, char, bool)");

                    Console.WriteLine();

                    Console.WriteLine("So Plx provide your details below:");
                    Console.WriteLine();

                    Console.Write("Your Name:");
                    string name = Console.ReadLine().ToLower();

                    Console.Write("Your Age:");
                    string input = Console.ReadLine();

                    int age = 0;
                    bool ageResult = false;

                    while (ageResult == false)
                    {
                        ageResult = int.TryParse(input, out age);
                        if (!ageResult)
                        {
                            Console.Write("Your Age:");
                            input = Console.ReadLine();
                            Console.WriteLine("Enter correct age in integer");
                        }
                    }

                    decimal salary = 0;
                    char section = '0';

                    Console.Write("Your Salary:");
                    salary = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("Your section (from \"(a-z)\" or 1-9), As it is char so keep it one digit/letter:");
                    section = Convert.ToChar(Console.ReadLine().ToLower());

                    Console.Write("Are you a student? (Yes/No): ");
                    string studentInput = Console.ReadLine().ToLower();
                    //bool student = studentInput == "yes"; 
                    //Console.WriteLine();
                    //Console.WriteLine("You are a student: " + student);
                    Console.WriteLine();


                    if (studentInput == "yes")
                    {
                        Console.WriteLine("oh! " + studentInput + " so you are student,hmmm....");
                    }
                    else
                    {
                        Console.WriteLine("So you are not a student..ok");
                    }


                    Console.WriteLine();
                    Console.WriteLine("Your Name is " + name);
                    Console.WriteLine("Your age is " + age);
                    Console.WriteLine("Your salary is " + salary);
                    Console.WriteLine("Your section is " + section);
                    Console.WriteLine("Just checking for \"students\", So you are student? your response:  " + studentInput);
                    Console.WriteLine();
                    Console.WriteLine("\n\n");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("Ok so now here is some math calculations for you.....!!");

                    Console.WriteLine();
                    Console.WriteLine("Enter first number");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine("Enter second number");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine("Enter operator (+,-,/,%,*)");
                    string opr = Console.ReadLine();
                    Console.WriteLine();


                    if (opr == "+")
                    {
                        Console.WriteLine("Result: " + (num1 + num2));
                    }
                    else if (opr == "-")
                    {
                        Console.WriteLine("Result: " + (num1 - num2));
                    }
                    else if (opr == "%")
                    {
                        Console.WriteLine("Result: " + (num1 % num2));
                    }
                    else if (opr == "*")
                    {
                        Console.WriteLine("Result: " + (num1 * num2));
                    }
                    else if (opr == "/")
                    {
                        if (num2 > 0)
                        {
                            Console.WriteLine("Result: " + (num1 / num2));
                        }
                        else
                        {
                            Console.WriteLine("num2 can't be zero/Invalid Input");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Do you want to check it out again?? just say (\"Yes/no\")");
                    userchoice = Console.ReadLine().ToLower();
                } while (userchoice == "yes");
                Console.WriteLine();

                Console.WriteLine("THANKS FOR VIEWING TASK 1");
                Console.WriteLine(" ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}