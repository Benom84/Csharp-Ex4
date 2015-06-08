using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceCountWords : MenuItem, IMenuButton
    {
        private const string k_Title = "Count Words";
        private const string k_UserRequest = "Please enter a sentence:";
        private const string k_DisplayNumberOfWords = "The number of words in the sentence is: {0}";

        public InterfaceCountWords()
            : base(k_Title)
        {
        }

        public void ClickButton()
        {
            string userInput = string.Empty;
            int numberOfWordsCounted = 0;
            System.Console.Clear();
            System.Console.WriteLine(k_UserRequest);
            userInput = System.Console.ReadLine();
            numberOfWordsCounted = Regex.Matches(userInput, @"[A-Za-z]+").Count;
            System.Console.WriteLine(string.Format(k_DisplayNumberOfWords, numberOfWordsCounted));
            System.Console.ReadLine();
        }
    }
}
