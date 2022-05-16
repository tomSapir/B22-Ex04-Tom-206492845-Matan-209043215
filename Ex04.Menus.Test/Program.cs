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

            mainMenu.SubMenuItem.Add(new MenuItem("Show Date/Time", mainMenu));
            mainMenu.SubMenuItem.Add(new MenuItem("Version and Spaces", mainMenu));

            mainMenu.SubMenuItem[0].SubMenuItem.Add(new MenuItem("Show Time", mainMenu.SubMenuItem[0]));
            mainMenu.SubMenuItem[0].SubMenuItem.Add(new MenuItem("Show Date", mainMenu.SubMenuItem[0]));

            mainMenu.SubMenuItem[1].SubMenuItem.Add(new MenuItem("Count Spaces", mainMenu.SubMenuItem[1]));
            mainMenu.SubMenuItem[1].SubMenuItem.Add(new MenuItem("Show Version", mainMenu.SubMenuItem[1]));

            Utils utils = new Utils(mainMenu);

            mainMenu.Show();
        }
    }
}
