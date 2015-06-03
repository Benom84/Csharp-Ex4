using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceInfo : MenuItem
    {
        private const string k_Title = "Info";

        public InterfaceInfo()
            : base(k_Title)
        {
        }
    }
}
