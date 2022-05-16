using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void Action<T>();

    public class MenuItem
    {
        private List<MenuItem> m_SubMenuItems;
        private MenuItem m_ItemAboveMeInTheHierarchy;
        private string m_Text;

        public event Action<MenuItem> m_ItemChosen;

        public MenuItem(string i_Text, MenuItem i_ItemAboveMeInTheHierarchy)
        {
            m_SubMenuItems = new List<MenuItem>();
            m_ItemAboveMeInTheHierarchy = i_ItemAboveMeInTheHierarchy;
            m_Text = i_Text;
        }

        public MenuItem ItemAboveMeInTheHierarchy
        {
            get
            {
                return m_ItemAboveMeInTheHierarchy;
            }

            set
            {
                m_ItemAboveMeInTheHierarchy = value;
            }
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

        public List<MenuItem> SubMenuItem
        {
            get
            {
                return m_SubMenuItems;
            }
        }

        public void MethodWhenChosen()
        {
            OnChosen();
        }

        protected virtual void OnChosen()
        {
            if (m_ItemChosen != null)
            {
                m_ItemChosen.Invoke();
            }
        }
    }
}
