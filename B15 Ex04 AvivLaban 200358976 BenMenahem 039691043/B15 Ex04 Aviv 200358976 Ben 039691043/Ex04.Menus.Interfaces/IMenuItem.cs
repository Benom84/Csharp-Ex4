using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    interface IMenuItem
    {
        string Title
        {
            get;
        }

        bool IsMainMenu
        {
            get;
        }

        List<IMenuItem> SubMenuItems
        {
            get;
        }
        
        void Select();
    }
}
