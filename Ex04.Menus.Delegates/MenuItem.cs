using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void Action<T>(T i_Param);

    class MenuItem
    {
        private List<MenuItem> m_SubMenuItems = null;
        private MenuItem m_ItemAboveMeInTheHierarchy = null;
        private string m_Text = string.Empty;

        public event Action<MenuItem> ItemChosen;

        public MenuItem()
        {

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

        protected virtual void OnChosen()
        {
            if (ItemChosen != null)
            {
                ItemChosen.Invoke(this);
            }
        }
    }
}
