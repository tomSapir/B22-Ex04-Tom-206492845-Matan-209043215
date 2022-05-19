using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        protected List<MenuItem> m_SubMenuItems = new List<MenuItem>();
        protected MenuItem m_ItemAboveMeInTheHierarchy = null;
        protected string m_Title = string.Empty;

        protected List<IMenuItemChosenListner> m_MenuItemChosenListners = new List<IMenuItemChosenListner>();

        public void AddMenuItemChosenListner(IMenuItemChosenListner i_Listner)
        {
            m_MenuItemChosenListners.Add(i_Listner);
        } 
        
        public void RemoveMenuItemChosenListner(IMenuItemChosenListner i_Listner)
        {
            m_MenuItemChosenListners.Remove(i_Listner);
            // TODO: handle errors
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
                return m_Title;
            }

            set
            {
                m_Title = value;
            }
        }

        public List<MenuItem> SubMenuItem
        {
            get
            {
                return m_SubMenuItems;
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

            foreach (MenuItem menuItem in m_SubMenuItems)
            {
                if (i_MenuItem == menuItem)
                {
                    doesExist = true;
                    break;
                }
            }

            return doesExist;
        }

        public void NotifyAllThatImChosen()
        {
            foreach (IMenuItemChosenListner listner in m_MenuItemChosenListners)
            {
                listner.ReportMenuItemChosen(this);
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("**").Append(m_Title).AppendLine("**");
            stringBuilder.AppendLine("-------------------------");
            for (int i = 1; i <= m_SubMenuItems.Count; i++)
            {
                stringBuilder.Append(i.ToString()).Append(" -> ").AppendLine(m_SubMenuItems[i - 1].Title);
            }

            if (this is MainMenu)
            {
                stringBuilder.AppendLine("0 -> Exit");
            }
            else
            {
                stringBuilder.AppendLine("0 -> Back");
            }

            stringBuilder.AppendLine("-------------------------");
            stringBuilder.Append("Enter your request (1 to ").Append(m_SubMenuItems.Count).Append(" or press '0' to ");
            if (this is MainMenu)
            {
                stringBuilder.Append("Exit).");
            }
            else
            {
                stringBuilder.Append("Back).");
            }

            return stringBuilder.ToString();
        }

        public bool AmIALeaf()
        {
            return m_SubMenuItems.Count == 0;
        }
    }
}
