using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using Ex04.Menus;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            InterfaceMainMenu mainMenuInterfaceExample = createMainMenuInterfaceExample();
            Interfaces.MainMenu mainMenuInterface = new Interfaces.MainMenu();
            Delegates.MenuItem mainMenuDelegatesExample = createMainMenuDelegateExample();
            Delegates.MainMenu mainMenuDelegates = new Delegates.MainMenu();

            mainMenuInterface.Show(mainMenuInterfaceExample);
            mainMenuDelegates.Show(mainMenuDelegatesExample);
        }

        private static InterfaceMainMenu createMainMenuInterfaceExample()
        {
            InterfaceMainMenu mainMenuInterfaceExample = new InterfaceMainMenu();
            InterfaceDateTime dateTimeInterfaceExample = new InterfaceDateTime();
            InterfaceDate dateInterfaceExample = new InterfaceDate();
            InterfaceTime timeInterfaceExample = new InterfaceTime();
            InterfaceInfo infoInterfaceExample = new InterfaceInfo();
            InterfaceVersion versionInterfaceExample = new InterfaceVersion();
            InterfaceCountWords countWordsInterfaceExample = new InterfaceCountWords();
            
            dateTimeInterfaceExample.AddMenuItem(timeInterfaceExample);
            dateTimeInterfaceExample.AddMenuItem(dateInterfaceExample);
            infoInterfaceExample.AddMenuItem(versionInterfaceExample);
            infoInterfaceExample.AddMenuItem(countWordsInterfaceExample);
            mainMenuInterfaceExample.AddMenuItem(dateTimeInterfaceExample);
            mainMenuInterfaceExample.AddMenuItem(infoInterfaceExample);

            return mainMenuInterfaceExample;
        }

        private static Delegates.MenuItem createMainMenuDelegateExample()
        {
            Delegates.MenuItem mainMenuDelegateExample = new Delegates.MenuItem("Main Menu Delegates", null);
            Delegates.MenuItem dateTimeDelegateExample = new Delegates.MenuItem("Show Date/Time", null);
            Delegates.MenuItem dateDelegateExample = new Delegates.MenuItem("Show Date", showDate);
            Delegates.MenuItem timeDelegateExample = new Delegates.MenuItem("Show Time", showTime);
            Delegates.MenuItem infoDelegateExample = new Delegates.MenuItem("Info", null);
            Delegates.MenuItem versionDelegateExample = new Delegates.MenuItem("Version", showVersion);
            Delegates.MenuItem countWordsDelegateExample = new Delegates.MenuItem("Count Words", countWords);

            dateTimeDelegateExample.AddMenuItem(timeDelegateExample);
            dateTimeDelegateExample.AddMenuItem(dateDelegateExample);
            infoDelegateExample.AddMenuItem(versionDelegateExample);
            infoDelegateExample.AddMenuItem(countWordsDelegateExample);
            mainMenuDelegateExample.AddMenuItem(dateTimeDelegateExample);
            mainMenuDelegateExample.AddMenuItem(infoDelegateExample);

            return mainMenuDelegateExample;
        }

        private static void showDate()
        {
            System.Console.Clear();
            System.Console.WriteLine(DateTime.Today.ToString("dd.MM.yyyy"));
            System.Console.ReadLine();
        }

        private static void showTime()
        {
            System.Console.Clear();
            System.Console.WriteLine(DateTime.Now.ToString("T"));
            System.Console.ReadLine();
        }

        private static void showVersion()
        {
            System.Console.Clear();
            System.Console.WriteLine("Version: 15.2.4.0");
            System.Console.ReadLine();
        }

        private static void countWords()
        {
            string userInput = string.Empty;
            int numberOfWordsCounted = 0;
            System.Console.Clear();
            System.Console.WriteLine("Please enter a sentence:");
            userInput = System.Console.ReadLine();
            numberOfWordsCounted = Regex.Matches(userInput, @"[A-Za-z]+").Count;
            System.Console.WriteLine(string.Format("The number of words in the sentence is: {0}", numberOfWordsCounted));
            System.Console.ReadLine();
        }
    }
}
