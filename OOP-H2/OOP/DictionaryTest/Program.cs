using System;
using DictionaryLibrary;

namespace DictionaryTest
{
    class Program
    {
        public static string UserInput;
        static void Main(string[] args)
        {
            NumberDictionary NRDictionary = new NumberDictionary();
            ADDNumbersToDictionary(NRDictionary);

            while (UserInput != "quit")
            {
                UserInput = Console.ReadLine();


                int i = 0;
                int ii = 0;
                foreach (var item in NRDictionary.numbers.Keys)
                {
                    i += 1;
                    if (UserInput == item)
                    {
                        ii += 1;
                        Console.WriteLine("Dictionary value => " + NRDictionary.numbers[UserInput] + "\n");
                    }
                    else if (i == NRDictionary.numbers.Count && ii == 0)
                    {
                        Console.WriteLine("Couldnt find [" + UserInput + "] in the dictionary! \nPlease try again.\n");
                    }
                }
            }
        }

        public static void ADDNumbersToDictionary(NumberDictionary NRDictionary)
        {
            NRDictionary.numbers["one"] = 1;
            NRDictionary.numbers["two"] = 2;
            NRDictionary.numbers["three"] = 3;
            NRDictionary.numbers["four"] = 4;
            NRDictionary.numbers["five"] = 5;
            NRDictionary.numbers["six"] = 6;
            NRDictionary.numbers["seven"] = 7;
            NRDictionary.numbers["eight"] = 8;
            NRDictionary.numbers["nine"] = 9;
            NRDictionary.numbers["ten"] = 10;
        }
    }
}
