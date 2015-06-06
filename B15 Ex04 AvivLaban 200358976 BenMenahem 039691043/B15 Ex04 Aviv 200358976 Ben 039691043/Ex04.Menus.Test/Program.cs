using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using Ex04.Menus;

namespace Ex04.Menus.Test
{
    public enum eActionsOnClick {
        ShowDate, ShowTime, ShowVersion, CountWords, None
    }

    public class Program
    {
        private static Dictionary<Delegates.MenuItem, eActionsOnClick> m_MenuItemToActionOnClick;

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
            m_MenuItemToActionOnClick = new Dictionary<Delegates.MenuItem, eActionsOnClick>();
            
            Delegates.MenuItem mainMenuDelegateExample = createDelegateMenuItem("Main Menu Delegates", eActionsOnClick.None);
            Delegates.MenuItem dateTimeDelegateExample = createDelegateMenuItem("Show Date/Time", eActionsOnClick.None);
            Delegates.MenuItem dateDelegateExample = createDelegateMenuItem("Show Date", eActionsOnClick.ShowDate);
            Delegates.MenuItem timeDelegateExample = createDelegateMenuItem("Show Time", eActionsOnClick.ShowTime);
            Delegates.MenuItem infoDelegateExample = createDelegateMenuItem("Info", eActionsOnClick.None);
            Delegates.MenuItem versionDelegateExample = createDelegateMenuItem("Version", eActionsOnClick.ShowVersion);
            Delegates.MenuItem countWordsDelegateExample = createDelegateMenuItem("Count Words", eActionsOnClick.CountWords);

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

        private static Delegates.MenuItem createDelegateMenuItem(string i_MenuItemName, eActionsOnClick i_ActionToPerform)
        {
            Delegates.MenuItem menuCreated = new Delegates.MenuItem(i_MenuItemName);
            
            m_MenuItemToActionOnClick.Add(menuCreated, i_ActionToPerform);
            menuCreated.Click += menuItemClicked;

            return menuCreated;
        }

        private static void menuItemClicked(Delegates.MenuItem i_menuItemClicked)
        {
            eActionsOnClick actionClicked = eActionsOnClick.None;

            if (i_menuItemClicked != null && m_MenuItemToActionOnClick.TryGetValue(i_menuItemClicked, out actionClicked))
            {
                switch (actionClicked)
                {
                    case eActionsOnClick.ShowDate:
                        showDate();
                        break;
                    case eActionsOnClick.ShowTime:
                        showTime();
                        break;
                    case eActionsOnClick.ShowVersion:
                        showVersion();
                        break;
                    case eActionsOnClick.CountWords:
                        countWords();
                        break;
                    case eActionsOnClick.None:
                        System.Console.WriteLine("Error: A Menu Item was activated as a button, but no action is linked to is.");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
