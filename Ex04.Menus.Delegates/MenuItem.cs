using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    //public delegate Action<T>
    class MenuItem
    {
        private List<MenuItem> m_SubMenuItems = null;
        private string m_Text = string.Empty;

        public event Action<MenuItem> ItemClicked;

        public MenuItem()
        {

        }

        public string Text
        {
            get
            {
                return m_Text;
            }

            set
            {
                m_Text = value;
            }
        }

    }
}
