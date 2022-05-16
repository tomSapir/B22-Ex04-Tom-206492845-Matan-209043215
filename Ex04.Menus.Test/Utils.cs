using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class Utils
    {
        public Utils(MainMenu i_UtilsMainMenu)
        {
            i_UtilsMainMenu.SubMenuItem[0].SubMenuItem[0].m_MenuItemChooseInvoker += ShowTime;
            i_UtilsMainMenu.SubMenuItem[0].SubMenuItem[1].m_MenuItemChooseInvoker += ShowDate;
            i_UtilsMainMenu.SubMenuItem[1].SubMenuItem[0].m_MenuItemChooseInvoker += CountSpaces;
            i_UtilsMainMenu.SubMenuItem[1].SubMenuItem[1].m_MenuItemChooseInvoker += ShowVersion;
        }

        public void ShowTime()
        {
            Console.WriteLine(string.Format("The time is: {0}{1}", DateTime.Now.ToString("HH:mm:ss"), Environment.NewLine));
        }

        public void ShowDate()
        {
            Console.WriteLine(string.Format("The data is: {0}{1}", DateTime.Now.ToShortDateString(), Environment.NewLine));
        }

        public void CountSpaces()
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

        public void ShowVersion()
        {
            Console.WriteLine("0.4.2.22: Version");
        }
    }
}
