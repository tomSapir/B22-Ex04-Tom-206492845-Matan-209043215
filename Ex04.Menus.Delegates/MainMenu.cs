using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private List<MenuItem> m_MenuItems;

        public void Show()
        {
            bool stopLoop = false;
            MenuItem currMenuItem = null;

            while (stopLoop == false)
            {
                if (currMenuItem == null)
                {
                    Console.WriteLine("***** Main Menu *****");
                }
                else
                {
                    Console.WriteLine("***** {0} *****", currMenuItem.Text);
                }



            }
        }

    }
}
