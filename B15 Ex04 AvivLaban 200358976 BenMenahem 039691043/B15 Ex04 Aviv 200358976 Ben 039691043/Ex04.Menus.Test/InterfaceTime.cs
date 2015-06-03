using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class InterfaceTime : MenuItem, IMenuButton
    {
        private const string k_Title = "Show Time";
        private const string k_TimeFormat = "T";

        public InterfaceTime() : base(k_Title)
        {
        }

        public void ClickButton()
        {
            System.Console.Clear();
            System.Console.WriteLine(DateTime.Now.ToString(k_TimeFormat));
            System.Console.ReadLine();
        }
    }
}
