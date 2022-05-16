using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void MenuItemChooseInvoker();

    public class MenuItem
    {
        protected List<MenuItem> m_SubMenuItems;
        protected MenuItem m_ItemAboveMeInTheHierarchy;
        protected readonly string r_Title;

        public event MenuItemChooseInvoker m_MenuItemChooseInvoker;

        public MenuItem(string i_Title, MenuItem i_ItemAboveMeInTheHierarchy)
        {
            m_SubMenuItems = new List<MenuItem>();
            m_ItemAboveMeInTheHierarchy = i_ItemAboveMeInTheHierarchy;
            r_Title = i_Title;
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

        public string Title
        {
            get
            {
                return r_Title;
            }
        }

        public List<MenuItem> SubMenuItem
        {
            get
            {
                return m_SubMenuItems;
            }
        }

        public void MethodForWhenMenuItemIsChosen()
        {
            OnChosen();
        }

        protected virtual void OnChosen()
        {
            if (m_MenuItemChooseInvoker != null)
            {
                m_MenuItemChooseInvoker.Invoke();
            }
        }

        public void AddSubMenuItem(MenuItem i_MenuItem)
        {
            m_SubMenuItems.Add(i_MenuItem);
        }

        public void RemoveSubMenuItem(MenuItem i_MenuItemToRemove)
        {
            if (checkIfMenuItemIsSubItem(i_MenuItemToRemove) == false)
            {
                throw new ArgumentException(string.Format("There is no sub menu item under menu item {0}{1}", this.Title, Environment.NewLine));
            }
          
            m_SubMenuItems.Remove(i_MenuItemToRemove);
        }

        private bool checkIfMenuItemIsSubItem(MenuItem i_MenuItem)
        {
            bool doesExist = false;

            foreach(MenuItem menuItem in m_SubMenuItems)
            {
                if (i_MenuItem == menuItem)
                {
                    doesExist = true;
                    break;
                }
            }

            return doesExist;
        }
    }
}
