using Ex04.Menus.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            MainMenu mainMenu = new MainMenu();

            mainMenu.MenuItems.Add(new MenuItem("Show Date/Time", null));
            mainMenu.MenuItems.Add(new MenuItem("Version and Spaces", null));

            mainMenu.MenuItems[0].SubMenuItem.Add(new MenuItem("Show Time", mainMenu.MenuItems[0]));
            mainMenu.MenuItems[0].SubMenuItem.Add(new MenuItem("Show Date", mainMenu.MenuItems[0]));

            mainMenu.MenuItems[1].SubMenuItem.Add(new MenuItem("Count Spaces", mainMenu.MenuItems[1]));
            mainMenu.MenuItems[1].SubMenuItem.Add(new MenuItem("Show Version", mainMenu.MenuItems[1]));

            Utils utils = new Utils(mainMenu);

            mainMenu.Show();
        }
    }
}
