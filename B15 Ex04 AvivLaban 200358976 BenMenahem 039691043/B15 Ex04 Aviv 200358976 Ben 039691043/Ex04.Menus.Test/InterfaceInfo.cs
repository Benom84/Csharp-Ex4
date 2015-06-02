using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceInfo : MenuItem, IMenuButton
    {
        private const string k_Title = "Info";
        private const bool k_IsMainMenu = false;

        public InterfaceInfo()
            : base(k_Title, k_IsMainMenu)
        {

        }

        public void ClickButton()
        {
            System.Console.WriteLine(DateTime.Today.ToString());
            System.Console.ReadLine();
        }
    }
}
