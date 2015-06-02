using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceDate : MenuItem, IMenuButton
    {
        private const string k_Title = "Show Date";
        private const string k_DateFormat = "dd.MM.yyyy";
        private const bool k_IsMainMenu = false;

        public InterfaceDate() : base (k_Title, k_IsMainMenu)
        {

        }

        public void ClickButton()
        {
            System.Console.WriteLine(DateTime.Today.ToString(k_DateFormat));
            System.Console.ReadLine();
        }
    }
}
