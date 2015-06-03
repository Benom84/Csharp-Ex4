using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceVersion : MenuItem, IMenuButton
    {
        private const string k_Title = "Version";
        private string k_Version = "Version: 15.2.4.0";

        public InterfaceVersion()
            : base(k_Title)
        {
        }

        public void ClickButton()
        {
            System.Console.Clear();
            System.Console.WriteLine(k_Version);
            System.Console.ReadLine();
        }
    }
}
