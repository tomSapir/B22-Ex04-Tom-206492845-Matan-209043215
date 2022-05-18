using System;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            Delegates.MainMenu mainMenuForDelegatesTesting = new Delegates.MainMenu();
            Interfaces.MainMenu mainMenuForInterfacesTesting = new Interfaces.MainMenu();
            SystemForTestingDelegates systemForTestingDelegates;
            SystemForTestingInterfaces systemForTestingInterfaces;

            buildMainMenuForDelegatesTesting(mainMenuForDelegatesTesting);
            buildMainMenuForInterfacesTesting(mainMenuForInterfacesTesting);
            systemForTestingDelegates = new SystemForTestingDelegates(mainMenuForDelegatesTesting);
            systemForTestingInterfaces = new SystemForTestingInterfaces(mainMenuForInterfacesTesting);
            mainMenuForDelegatesTesting.Show();
            Console.Clear();
            mainMenuForInterfacesTesting.Show();
        }

        private static void buildMainMenuForDelegatesTesting(Delegates.MainMenu o_MainMenuForDelegatesTesting)
        {
            o_MainMenuForDelegatesTesting.Title = "**Delegates Main Menu**";
            o_MainMenuForDelegatesTesting.AddSubMenuItem(new Delegates.MenuItem());
            o_MainMenuForDelegatesTesting.SubMenuItem[0].Title = "Show Date/Time";
            o_MainMenuForDelegatesTesting.SubMenuItem[0].ItemAboveMeInTheHierarchy = o_MainMenuForDelegatesTesting;
            o_MainMenuForDelegatesTesting.AddSubMenuItem(new Delegates.MenuItem());
            o_MainMenuForDelegatesTesting.SubMenuItem[1].Title = "Version and Spaces";
            o_MainMenuForDelegatesTesting.SubMenuItem[1].ItemAboveMeInTheHierarchy = o_MainMenuForDelegatesTesting;
            o_MainMenuForDelegatesTesting.SubMenuItem[0].AddSubMenuItem(new Delegates.MenuItem());
            o_MainMenuForDelegatesTesting.SubMenuItem[0].SubMenuItem[0].Title = "Show Time";
            o_MainMenuForDelegatesTesting.SubMenuItem[0].SubMenuItem[0].ItemAboveMeInTheHierarchy = o_MainMenuForDelegatesTesting.SubMenuItem[0];
            o_MainMenuForDelegatesTesting.SubMenuItem[0].AddSubMenuItem(new Delegates.MenuItem());
            o_MainMenuForDelegatesTesting.SubMenuItem[0].SubMenuItem[1].Title = "Show Date";
            o_MainMenuForDelegatesTesting.SubMenuItem[0].SubMenuItem[1].ItemAboveMeInTheHierarchy = o_MainMenuForDelegatesTesting.SubMenuItem[0];
            o_MainMenuForDelegatesTesting.SubMenuItem[1].AddSubMenuItem(new Delegates.MenuItem());
            o_MainMenuForDelegatesTesting.SubMenuItem[1].SubMenuItem[0].Title = "Count Spaces";
            o_MainMenuForDelegatesTesting.SubMenuItem[1].SubMenuItem[0].ItemAboveMeInTheHierarchy = o_MainMenuForDelegatesTesting.SubMenuItem[1];
            o_MainMenuForDelegatesTesting.SubMenuItem[1].AddSubMenuItem(new Delegates.MenuItem());
            o_MainMenuForDelegatesTesting.SubMenuItem[1].SubMenuItem[1].Title = "Show Version";
            o_MainMenuForDelegatesTesting.SubMenuItem[1].SubMenuItem[1].ItemAboveMeInTheHierarchy = o_MainMenuForDelegatesTesting.SubMenuItem[1];
        }   

        private static void buildMainMenuForInterfacesTesting(Interfaces.MainMenu o_MainMenuForInterfacesTesting)
        {
            o_MainMenuForInterfacesTesting.Title = "**Interfaces Main Menu**";
            o_MainMenuForInterfacesTesting.AddSubMenuItem(new Interfaces.MenuItem());
            o_MainMenuForInterfacesTesting.SubMenuItem[0].Title = "Show Date/Time";
            o_MainMenuForInterfacesTesting.SubMenuItem[0].ItemAboveMeInTheHierarchy = o_MainMenuForInterfacesTesting;
            o_MainMenuForInterfacesTesting.AddSubMenuItem(new Interfaces.MenuItem());
            o_MainMenuForInterfacesTesting.SubMenuItem[1].Title = "Version and Spaces";
            o_MainMenuForInterfacesTesting.SubMenuItem[1].ItemAboveMeInTheHierarchy = o_MainMenuForInterfacesTesting;
            o_MainMenuForInterfacesTesting.SubMenuItem[0].AddSubMenuItem(new Interfaces.MenuItem());
            o_MainMenuForInterfacesTesting.SubMenuItem[0].SubMenuItem[0].Title = "Show Time";
            o_MainMenuForInterfacesTesting.SubMenuItem[0].SubMenuItem[0].ItemAboveMeInTheHierarchy = o_MainMenuForInterfacesTesting.SubMenuItem[0];
            o_MainMenuForInterfacesTesting.SubMenuItem[0].AddSubMenuItem(new Interfaces.MenuItem());
            o_MainMenuForInterfacesTesting.SubMenuItem[0].SubMenuItem[1].Title = "Show Date";
            o_MainMenuForInterfacesTesting.SubMenuItem[0].SubMenuItem[1].ItemAboveMeInTheHierarchy = o_MainMenuForInterfacesTesting.SubMenuItem[0];
            o_MainMenuForInterfacesTesting.SubMenuItem[1].AddSubMenuItem(new Interfaces.MenuItem());
            o_MainMenuForInterfacesTesting.SubMenuItem[1].SubMenuItem[0].Title = "Count Spaces";
            o_MainMenuForInterfacesTesting.SubMenuItem[1].SubMenuItem[0].ItemAboveMeInTheHierarchy = o_MainMenuForInterfacesTesting.SubMenuItem[1];
            o_MainMenuForInterfacesTesting.SubMenuItem[1].AddSubMenuItem(new Interfaces.MenuItem());
            o_MainMenuForInterfacesTesting.SubMenuItem[1].SubMenuItem[1].Title = "Show Version";
            o_MainMenuForInterfacesTesting.SubMenuItem[1].SubMenuItem[1].ItemAboveMeInTheHierarchy = o_MainMenuForInterfacesTesting.SubMenuItem[1];
        }
    }
}
