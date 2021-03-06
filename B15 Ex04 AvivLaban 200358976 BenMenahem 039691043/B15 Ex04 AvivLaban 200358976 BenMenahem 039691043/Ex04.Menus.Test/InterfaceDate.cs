﻿using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceDate : MenuItem, IMenuButton
    {
        private const string k_Title = "Show Date";
        private const string k_DateFormat = "dd.MM.yyyy";

        public InterfaceDate() : base(k_Title)
        {
        }

        public void ClickButton()
        {
            System.Console.Clear();
            System.Console.WriteLine(DateTime.Today.ToString(k_DateFormat));
            System.Console.ReadLine();
        }
    }
}
