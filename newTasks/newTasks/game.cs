using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newTasks
{
    public class game
    {
        public void gameTask()
        {
            try
            {
                Console.WriteLine(" ");
                Console.WriteLine("----------------------------------------------------------------------------------------");
                string input = "";
                while (input != "yes")
                {
                    Console.WriteLine("Would you like to Play Number Guessing Game?");
                    input = Console.ReadLine();
                    if (input.ToLower() == "yes")
                    {
                        Random random = new Random();
                        bool playAgain = true;
                        int min = 1;
                        int max = 100;
                        int guess;
                        int number;
                        int guesses;
                        String response;

                        while (playAgain)
                        {
                            guess = 0;
                            guesses = 0;
                            response = "";
                            number = random.Next(min, max + 1);

                            while (guess != number)
                            {
                                Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                                Console.Write("Number: ");
                                guess = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Guess: " + guess);

                                if (guess > number)
                                {
                                    Console.WriteLine(guess + " is to high!");
                                }
                                else if (guess < number)
                                {
                                    Console.WriteLine(guess + " is to low!");
                                }
                                guesses++;
                            }
                            Console.WriteLine("Number: " + number);
                            Console.WriteLine();
                            Console.WriteLine("YOU WIN!");
                            Console.WriteLine("Guesses: " + guesses);

                            Console.WriteLine("Would you like to play again (Y/N): ");
                            response = Console.ReadLine();
                            response = response.ToUpper();

                            if (response == "Y")
                            {
                                playAgain = true;
                            }
                            else
                            {
                                playAgain = false;
                            }
                        }

                        Console.WriteLine("Thanks for playing! ... I guess");
                        Console.ReadKey();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
