using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;
using System.Text.RegularExpressions;

namespace Ex04.Menus.Test
{
    public class InterfaceCountWords : MenuItem, IMenuButton
    {
        private const string k_Title = "Count Words";
        private const bool k_IsMainMenu = false;
        private const string k_UserRequest = "Please enter a sentence:";
        private const string k_DisplayNumberOfWords = "The number of words in the sentence is: {0}";

        public InterfaceCountWords()
            : base(k_Title, k_IsMainMenu)
        {

        }

        public void ClickButton()
        {
            int numberOfWords = 0;
            System.Console.WriteLine(k_UserRequest);
            numberOfWords =  countWordsInSentence(System.Console.ReadLine());
            System.Console.WriteLine(string.Format(k_DisplayNumberOfWords, numberOfWords));
            System.Console.ReadLine();
        }

        private int countWordsInSentence(string i_Sentence)
        {
            MatchCollection collection = Regex.Matches(i_Sentence, @"[A-Za-z]+");
            return collection.Count;
        }
    }
}
