using System;

namespace newTasks
{
    public class DataType
    {
        public void datatypeTask()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("So Now here is the task for \"DATA TYPES\"");
                Console.WriteLine("Write a program that uses a `float` and `double` to calculate the area of a circle with a given radius.");
                Console.WriteLine();
                Console.WriteLine("Enter the radius of your choice to findout the area of circle");
                //  float radius = Convert.ToSingle(Console.ReadLine());
                float radius = float.Parse(Console.ReadLine());

                double area = 3.14 * (radius * radius);

                Console.WriteLine("The area of circle is " + area);
                Console.WriteLine();

                Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine();

                Console.WriteLine("Write a program that converts temperatures between Fahrenheit and Celsius.");
                Console.WriteLine("Enter Fahrenheit, you want to convert into celcius: ");
                Console.WriteLine();
                Console.Write("Fahrenheit = ");
                double fahrenheitTemp = double.Parse(Console.ReadLine());
                Console.WriteLine();

                double celsius = (fahrenheitTemp - 32) * 5 / 9;

                Console.WriteLine("So the \"celcius\" for " + fahrenheitTemp + " is " + celsius);
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------");

                //return "OK";
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
