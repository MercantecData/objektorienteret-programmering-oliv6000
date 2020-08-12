using System;
using System.Threading.Tasks;
using MultithreadingGuessNumber;

namespace MultithreadingGuessNumberConsoleApp
{
    class Program
    {
        private static readonly Random random = new Random();
        static void Main(string[] args)
        {
            gameStart();
        }

        public static void gameStart()
        {
            GuessTheNumber.resetTokenValue();
            Console.Clear();
            Console.WriteLine("Press any key once you're ready to guess the number im thinking off.\nBut keep in mind, you only have 10 seconds!\n");
            Console.ReadKey();

            var task = GuessTheNumber.timerForGame(1, 10, () => Console.Write("Remaining seconds until automatic loss: "), () => Console.WriteLine("Time has run out!"));
            userGame(1, 10, task);
        }

        public static async void userGame(int minRandomNumber, int maxRandomNumber, Task task)
        {
            int num = random.Next(minRandomNumber, maxRandomNumber);

            string userInput = Console.ReadLine();
            while (userInput != num.ToString() && task.IsCompleted == false)
            {
                Console.WriteLine("Dang, you didn't guess correctly, try again!\n");
                userInput = Console.ReadLine();
            }
            if (userInput == num.ToString())
            {
                Console.WriteLine($"You guessed the number: {num} correct! hurraayyyyyyy");
                GuessTheNumber.stopTask();//End task here
                Console.WriteLine("Press any key to restart!");
                Console.ReadKey();
                gameStart();
            }
            else
            {
                Console.Clear();
                GuessTheNumber.stopTask();//End task here
                Console.WriteLine($"Unlucky, you lost! The number you were trying to guess is {num}.");

                Console.WriteLine("\nPress any key to try again!");
                Console.ReadKey();
                gameStart();
            }

        }
    }
}
