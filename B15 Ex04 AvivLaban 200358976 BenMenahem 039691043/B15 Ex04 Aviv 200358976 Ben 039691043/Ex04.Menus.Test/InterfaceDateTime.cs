using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceDateTime : MenuItem
    {
        private const string k_MenuTitle = "Show Date/Time";
        private const bool k_IsMainMenu = false;
        public InterfaceDateTime() : base(k_MenuTitle, k_IsMainMenu)
        {

        }
    }
}
