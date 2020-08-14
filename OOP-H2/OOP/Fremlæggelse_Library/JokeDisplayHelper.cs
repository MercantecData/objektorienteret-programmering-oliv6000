using System;
using System.Text.RegularExpressions;

namespace FremlæggelseLibrary
{
    public class JokeDisplayHelper
    {        
        public delegate string ReturnRaw(string joke);
        public delegate string ReturnPresented(string joke, string presentation = "");
        public delegate string ReturnReplacedWords(string joke, string wordToReplace, string wordToInsert);
        public delegate string OtherJokeDisplay(string joke);

        //Lambda med implicit return
        public static ReturnRaw raw = joke => joke;
        
        public static ReturnPresented presented = (joke, presentation) => 
            (presentation != "" ? presentation.Trim() + " " : "The joke is: ") + joke;

        //This is a lambda that takes more than one parameter
        public static ReturnReplacedWords replacedWords = (joke, wordToReplace, wordToInsert) =>
        {
            //Flere linjer kode i en lambda!
            return Regex.Replace(joke, wordToReplace, wordToInsert);
        };

        public static string displayOther(string joke, OtherJokeDisplay otherJoke)
        {
            return otherJoke(joke);
        }
    }
}