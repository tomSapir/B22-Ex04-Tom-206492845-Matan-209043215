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
            o_UtilsMainMenu.SubMenuItem[0].SubMenuItem[0].m_MenuItemChooseInvoker += showTime;
            o_UtilsMainMenu.SubMenuItem[0].SubMenuItem[1].m_MenuItemChooseInvoker += showDate;
            o_UtilsMainMenu.SubMenuItem[1].SubMenuItem[0].m_MenuItemChooseInvoker += countSpaces;
            o_UtilsMainMenu.SubMenuItem[1].SubMenuItem[1].m_MenuItemChooseInvoker += showVersion;
        }

        private void showTime()
        {
            Console.WriteLine(string.Format("The time is: {0}{1}", DateTime.Now.ToString("HH:mm:ss"), Environment.NewLine));
        }

        private void showDate()
        {
            Console.WriteLine(string.Format("The data is: {0}{1}", DateTime.Now.ToShortDateString(), Environment.NewLine));
        }

        private void countSpaces()
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

        private void showVersion()
        {
            Console.WriteLine("0.4.2.22: Version");
        }
    }
}
