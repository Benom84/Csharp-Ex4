using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        private List<MenuItem> m_SubMenuItems;
        private string m_Title;
        private bool m_IsMainMenu;

        public MenuItem(string i_TitleOfMenu, bool i_IsMainMenu)
        {
            m_Title = i_TitleOfMenu;
            m_IsMainMenu = i_IsMainMenu;
            m_SubMenuItems = new List<MenuItem>();
        }
        public string Title
        {
            get
            {
                return m_Title;
            }
        }

        public bool IsMainMenu
        {
            get
            {
                return m_IsMainMenu;
            }
        }

        public List<MenuItem> SubMenuItems
        {
            get
            {
                return m_SubMenuItems;
            }
        }

        public void AddMenuItem(MenuItem i_MenuItemToAdd)
        {
            m_SubMenuItems.Add(i_MenuItemToAdd);
        }
    }
}
