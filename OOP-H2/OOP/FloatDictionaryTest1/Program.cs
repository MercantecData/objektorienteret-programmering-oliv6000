using System;
using FloatDictionary;

namespace FloatDictionaryTest1
{
    class Program
    {
        static string UserInput;
        static float UserFloatValue;
        static void Main(string[] args)
        {
            floatDictionary dict = new floatDictionary();
            addToFloatDictionary(dict);

            while (UserInput != "quit")
            {
                UserInput = Console.ReadLine();

                //UserFloatValue = float.tryParse(UserInput);

                if (Single.TryParse(UserInput, out UserFloatValue));
                else Console.WriteLine("Unable to parse '{0}'.", UserInput);

                //Console.WriteLine(UserFloatValue);


                int i = 0;
                int ii = 0;
                foreach(var item in dict.dictionary)
                {
                    i += 1;
                    if (UserFloatValue == item.Key)
                    {
                        ii += 1;
                        Console.WriteLine(item.Value);
                    }
                    else if (i == dict.dictionary.Count && ii == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("There is nothing in the float dictionary with the value [" + UserFloatValue + "]\nwrite another float value.\n");
                    }

                }
            }


        }

        public static void addToFloatDictionary(floatDictionary dict)
        {
            dict.dictionary.Add(1.61f, false);
            dict.dictionary.Add(6.90f, true);
            dict.dictionary.Add(42.00f, true);
            dict.dictionary.Add(42.069f, false);
            dict.dictionary.Add(3.342f, true);
            dict.dictionary.Add(6.61f, false);
            dict.dictionary.Add(12.512f, true);
            dict.dictionary.Add(16.71f, false);
            dict.dictionary.Add(2.221f, true);
            dict.dictionary.Add(17.761f, false);
        }
    }
}
