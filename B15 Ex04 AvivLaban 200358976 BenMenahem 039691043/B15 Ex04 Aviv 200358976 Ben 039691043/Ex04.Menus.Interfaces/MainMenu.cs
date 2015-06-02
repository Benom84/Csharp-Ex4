using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private const bool v_ShowMenu = true;
        private const string k_TitleLine = "****************************************************";
        private const string k_MenuLine = "{0}. {1}";
        private const string k_ExitLine = "{0}. Exit";
        private const string k_BackLine = "{0}. Back";
        private const string k_GetSelectionFromUser = "Please enter your selection: ";
        private const string k_GetSelectionFromUserAfterInvalid = "Please enter a valid selection (0 - {0}): ";
        private const int k_ExitSelection = 0;

        public void Show(MenuItem i_MenuItem)
        {
            bool showMenu = v_ShowMenu;
            int userSelection = 0;


            while (showMenu)
            {
                StringBuilder menuToDisplay = buildMenuToDisplay(i_MenuItem);
                
                System.Console.Clear();
                System.Console.WriteLine(menuToDisplay);
                userSelection = getValidSelectionFromUser(i_MenuItem);
                showMenu = userSelection != k_ExitSelection;
                if (showMenu)
                {
                    handleUserSelection(i_MenuItem, userSelection);
                }
            }
        }

        private void handleUserSelection(MenuItem i_MenuItem, int i_UserSelection)
        {
            // Adjust user selection from displayed index to 0-based index
            i_UserSelection--;
            MenuItem selectedMenuItem = i_MenuItem.SubMenuItems[i_UserSelection];

            if (selectedMenuItem.SubMenuItems != null && selectedMenuItem.SubMenuItems.Count != 0)
            {
                Show(selectedMenuItem);
            }
            else
            {
                IMenuButton selectedItemAsButton = selectedMenuItem as IMenuButton;
                if (selectedItemAsButton != null)
                {
                    selectedItemAsButton.ClickButton();
                }
                else
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("Error: The option selected cannot perform an action and is not a menu to display.");
                }
            }
            
            
        }

        private StringBuilder buildMenuToDisplay(MenuItem i_MenuItem)
        {
            StringBuilder menuToDisplay = new StringBuilder();
            string lastMenuLine = (i_MenuItem.IsMainMenu) ? k_ExitLine : k_BackLine;
            int index = 1;
            
            menuToDisplay.Append(i_MenuItem.Title);
            menuToDisplay.Append(System.Environment.NewLine);
            menuToDisplay.Append(k_TitleLine);
            menuToDisplay.Append(System.Environment.NewLine);
            foreach (MenuItem subMenuItem in i_MenuItem.SubMenuItems)
            {
                menuToDisplay.Append(string.Format(k_MenuLine, index, subMenuItem.Title));
                menuToDisplay.Append(System.Environment.NewLine);
                index++;
            }

            menuToDisplay.Append(string.Format(lastMenuLine, k_ExitSelection));
            menuToDisplay.Append(System.Environment.NewLine);

            return menuToDisplay;

        }


        private int getValidSelectionFromUser(MenuItem i_MenuItem)
        {
            string userSelectionEntered = string.Empty;
            int userSelection = 0;
            int maxLegalUserSelection = i_MenuItem.SubMenuItems.Count;
            
            System.Console.Write(k_GetSelectionFromUser);
            userSelectionEntered = System.Console.ReadLine();
            while (!int.TryParse(userSelectionEntered, out userSelection) || userSelection < 0 || userSelection > maxLegalUserSelection)
            {
                System.Console.Write(string.Format(k_GetSelectionFromUserAfterInvalid, maxLegalUserSelection));
                userSelectionEntered = System.Console.ReadLine();
            }

            return userSelection;
        }
    }
}

