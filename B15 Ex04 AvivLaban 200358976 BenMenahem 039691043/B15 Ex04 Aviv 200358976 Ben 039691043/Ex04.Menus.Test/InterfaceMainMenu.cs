using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceMainMenu : MenuItem
    {
        private const string k_MenuTitle = "Main Menu Intefaces";

        public InterfaceMainMenu()
            : base(k_MenuTitle)
        {
        }
    }
}
