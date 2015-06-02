using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    class MainMenu
    {
        private const bool v_ShowMenu = true;
        private const string k_Title = "{0}\n****************************************************";
        private const string k_MenuLine = "{0}. {1}";
        private const string k_ExitLine = "0. Exit";
        private const string k_BackLine = "0. Back";
        private const string k_GetSelectionFromUser = "Please enter your selection: ";
        private const string k_GetSelectionFromUserAfterInvalid = "Please enter a valid selection (0 - {0}): ";

        public void Show(IMenuItem i_MenuItem)
        {
            bool showMenu = v_ShowMenu;
            int userSelection = 0;
            string lastMenuLine = (i_MenuItem.IsMainMenu) ? k_ExitLine : k_BackLine;

            while (showMenu)
            {
                int index = 1;
                System.Console.Clear();
                System.Console.WriteLine(string.Format(k_Title, i_MenuItem.Title));
                foreach (IMenuItem subMenuItem in i_MenuItem.SubMenuItems)
                {
                    System.Console.WriteLine(string.Format(k_MenuLine, index, subMenuItem.Title));
                    index++;
                }

                System.Console.WriteLine(lastMenuLine);
                System.Console.WriteLine();
                userSelection = getValidSelectionFromUser(index - 1);
                if (userSelection == 0)
                {
                    showMenu = !v_ShowMenu;
                }
                else
                {
                    IMenuItem selectedMenuItem = i_MenuItem.SubMenuItems[userSelection - 1];
                    if (selectedMenuItem.SubMenuItems != null)
                    {
                        Show(selectedMenuItem);
                    }
                    else
                    {
                        performAction(selectedMenuItem);
                    }
                }
            }
        }

        private void performAction(IMenuItem i_selectedMenuItem)
        {
            System.Console.Clear();
            i_selectedMenuItem.Select();
        }

        private int getValidSelectionFromUser(int i_NumberOfOptions)
        {
            string userSelectionEntered = string.Empty;
            int userSelection = 0;
            
            System.Console.Write(k_GetSelectionFromUser);
            userSelectionEntered = System.Console.ReadLine();
            while (!int.TryParse(userSelectionEntered, out userSelection) || userSelection < 0 || userSelection > i_NumberOfOptions)
            {
                System.Console.Write(k_GetSelectionFromUserAfterInvalid);
                userSelectionEntered = System.Console.ReadLine();
            }

            return userSelection;
        }
    }
}

