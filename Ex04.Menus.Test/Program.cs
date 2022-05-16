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
            Utils utils;

            mainMenu.AddSubMenuItem(new MenuItem("Show Date/Time", mainMenu));
            mainMenu.AddSubMenuItem(new MenuItem("Version and Spaces", mainMenu));
            mainMenu.SubMenuItem[0].AddSubMenuItem(new MenuItem("Show Time", mainMenu.SubMenuItem[0]));
            mainMenu.SubMenuItem[0].AddSubMenuItem(new MenuItem("Show Date", mainMenu.SubMenuItem[0]));
            mainMenu.SubMenuItem[1].AddSubMenuItem(new MenuItem("Count Spaces", mainMenu.SubMenuItem[1]));
            mainMenu.SubMenuItem[1].AddSubMenuItem(new MenuItem("Show Version", mainMenu.SubMenuItem[1]));
            utils = new Utils(mainMenu);
            mainMenu.Show();
        }
    }
}
