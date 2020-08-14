using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FremlæggelseLibrary;

namespace FremlæggelseConsole
{
    class Program
    {
        private static string endpoint = "https://geek-jokes.sameerkumar.website/api";
        private static string geekJoke;
        private static bool isOver = false;
        private static Task<string> task;
        
        
        static void Main(string[] args)
        {
            
            //Joke retrieving loop
            while (!isOver)
            {
                //Get new task ready for next round of jokes.
                task = Tasks.get(endpoint);
                GeekQuotes();
            }
        }

        static void GeekQuotes()
        {
            Console.WriteLine("Do you want a geek joke?");
            Console.WriteLine("If so, press enter, if not... too bad, press enter.");
            Console.ReadLine(); Console.Clear();
            
            Console.WriteLine("Please choose how you want joke displayed.");
            Console.WriteLine("1) Raw\n2) Presented\n3) Words replaced\n4) Display other\n5) Okay sure.. you can quit if you want to.");
            
            Int32.TryParse(Console.ReadLine(), out int choice);
            
            Console.Clear();
            
            //Check option selected in choice above
            switch (choice)
            {
                case 1:
                    DisplayLoader();
                    
                    geekJoke = JokeDisplayHelper.raw(task.Result);
                    
                    break;
                case 2:
                    Console.WriteLine("Choose a presenting string. You can type nothing, if you want the default.");
                    string presenter = Console.ReadLine();
                    
                    DisplayLoader();
                    
                    geekJoke = JokeDisplayHelper.presented(task.Result, presenter);
                    break;
                case 3:
                    Console.WriteLine("Choose word(s) to replace");
                    string wordToReplace = Console.ReadLine();
                    
                    Console.WriteLine("Choose word(s) to insert");
                    string wordToInsert = Console.ReadLine();
                    
                    DisplayLoader();
                    
                    geekJoke = JokeDisplayHelper.replacedWords(task.Result, wordToReplace, wordToInsert);
                    break;
                case 4:
                    DisplayLoader();
                    geekJoke = JokeDisplayHelper.displayOther(task.Result, (joke) => joke.ToUpper());
                    break;
                case 5:
                    isOver = true;
                    break;
                default:
                    Console.WriteLine("You didn't choose a valid number.");
                    break;
            }
            
            Console.SetCursorPosition(0,0);
            Console.WriteLine(geekJoke);
        }

        //Syntax sugar to not have to write the same two lines again and again.
        private static void DisplayLoader()
        {
            Console.Clear();
            Console.WriteLine("Loading quote, please wait...");
        }
    }
}