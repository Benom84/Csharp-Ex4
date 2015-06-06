using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        public event Action<MenuItem> Click;
        
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

        public void OnClick()
        {
            if (Click != null)
            {
                Click.Invoke(this);
            }
        }
    }
}
