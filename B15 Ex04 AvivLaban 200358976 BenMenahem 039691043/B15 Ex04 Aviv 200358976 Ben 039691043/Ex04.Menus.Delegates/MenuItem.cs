using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void SelectEventHandler();

    public class MenuItem
    {
        private event SelectEventHandler OnSelect;

        private List<MenuItem> m_SubMenuItems;
        private string m_Title;

        public MenuItem(string i_TitleOfMenu, SelectEventHandler i_OnSelectAction)
        {
            m_Title = i_TitleOfMenu;
            m_SubMenuItems = new List<MenuItem>();
            if (i_OnSelectAction != null)
            {
                OnSelect = i_OnSelectAction;
            }
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

        public void PerformOnSelect()
        {
            if (OnSelect != null)
            {
                OnSelect();
            }
        }
    }
}
