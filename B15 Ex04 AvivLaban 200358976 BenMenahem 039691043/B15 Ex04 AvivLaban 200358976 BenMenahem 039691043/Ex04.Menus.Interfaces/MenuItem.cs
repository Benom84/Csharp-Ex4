using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        private List<MenuItem> m_SubMenuItems;
        private string m_Title;

        public MenuItem(string i_TitleOfMenu)
        {
            m_Title = i_TitleOfMenu;
            m_SubMenuItems = new List<MenuItem>();
        }

        public string Title
        {
            get
            {
                return m_Title;
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

        public void RemoveMenuItem(MenuItem i_MenuItemToRemove)
        {
            m_SubMenuItems.Remove(i_MenuItemToRemove);
        }

        public void ChangeTitle(string i_NewTitle)
        {
            m_Title = i_NewTitle;
        }
    }
}
