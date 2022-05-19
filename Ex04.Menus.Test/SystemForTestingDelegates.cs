using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus
{
    public class SystemForTestingDelegates
    {
        public SystemForTestingDelegates(MainMenu o_UtilsMainMenu)
        {
            o_UtilsMainMenu.SubMenuItem[0].SubMenuItem[0].m_MenuItemChosen += menuItemShowTime_Chosen;
            o_UtilsMainMenu.SubMenuItem[0].SubMenuItem[1].m_MenuItemChosen += menuItemShowDate_Chosen;
            o_UtilsMainMenu.SubMenuItem[1].SubMenuItem[0].m_MenuItemChosen += menuItemCountSpaces_Chosen;
            o_UtilsMainMenu.SubMenuItem[1].SubMenuItem[1].m_MenuItemChosen += menuItemShowVersion_Chosen;
        }

        private void menuItemShowTime_Chosen()
        {
            Console.WriteLine(string.Format("The time is: {0}{1}", DateTime.Now.ToString("HH:mm:ss"), Environment.NewLine));
        }

        private void menuItemShowDate_Chosen()
        {
            Console.WriteLine(string.Format("The data is: {0}{1}", DateTime.Now.ToShortDateString(), Environment.NewLine));
        }

        private void menuItemCountSpaces_Chosen()
        {
            string inputString = string.Empty;
            int amountOfSpaces = 0;

            Console.WriteLine("Please enter your sentence: ");
            inputString = Console.ReadLine();
            foreach (char ch in inputString)
            {
                if (ch == ' ')
                {
                    amountOfSpaces++;
                }
            }

            Console.WriteLine("The amount of spaces in the sentence: {0}", amountOfSpaces);
        }

        private void menuItemShowVersion_Chosen()
        {
            Console.WriteLine("0.4.2.22: Version");
        }
    }
}
