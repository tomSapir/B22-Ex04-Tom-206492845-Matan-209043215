using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private List<MenuItem> m_MenuItems;

        public MainMenu()
        {
            m_MenuItems = new List<MenuItem>();
        }

        public List<MenuItem> MenuItems
        {
            get
            {
                return m_MenuItems;
            }
        }

        public void Show()
        {
            int choiceAsInt;
            MenuItem currMenuItem = null;

            while (true)
            {
                if (currMenuItem == null)
                {
                    printCurrentMenu("Main Menu", m_MenuItems, true);
                    choiceAsInt = readUserChoice(m_MenuItems.Count);

                    if (choiceAsInt == 0)
                    {
                        break;
                    }
                    else if (m_MenuItems[choiceAsInt - 1].SubMenuItem.Count == 0)
                    {
                        m_MenuItems[choiceAsInt - 1].MethodWhenChosen();
                    }
                    else
                    {
                        currMenuItem = m_MenuItems[choiceAsInt - 1];
                    }
                }
                else
                {
                    printCurrentMenu(currMenuItem.Text, currMenuItem.SubMenuItem, false);
                    choiceAsInt = readUserChoice(currMenuItem.SubMenuItem.Count);

                    if (choiceAsInt == 0)
                    {
                        currMenuItem = currMenuItem.ItemAboveMeInTheHierarchy;
                    }
                    else if (currMenuItem.SubMenuItem[choiceAsInt - 1].SubMenuItem.Count == 0)
                    {
                        currMenuItem.SubMenuItem[choiceAsInt - 1].MethodWhenChosen();
                    }
                    else
                    {
                        currMenuItem = currMenuItem.SubMenuItem[choiceAsInt - 1];
                    }
                }
            }
        }

        private bool checkIfChoiceIsValid(string i_Choice, int i_AmountOfOptions)
        {
            bool isValid = true;
            int choiceAsInt;

            if (int.TryParse(i_Choice, out choiceAsInt) == false)
            {
                isValid = false;
            }
            else
            {
                if(choiceAsInt < 0 || choiceAsInt > i_AmountOfOptions)
                {
                    isValid = false;
                }
            }

            return isValid;
        }

        private void printCurrentMenu(string i_Title, List<MenuItem> i_MenuItems, bool i_IsMainMenu)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("**").Append(i_Title).AppendLine("**");
            stringBuilder.AppendLine("-------------------------");

            for (int i = 1; i <= i_MenuItems.Count; i++)
            {
                stringBuilder.Append(i.ToString()).Append(" -> ").AppendLine(i_MenuItems[i - 1].Text);
            }

            if (i_IsMainMenu)
            {
                stringBuilder.AppendLine("0 -> Exit");
            }
            else
            {
                stringBuilder.AppendLine("0 -> Back");
            }

            stringBuilder.AppendLine("-------------------------");
            stringBuilder.Append("Enter your request (1 to ").Append(i_MenuItems.Count).Append(" or press '0' to ");
            if (i_IsMainMenu)
            {
                stringBuilder.Append("Exit).");
            }
            else
            {
                stringBuilder.Append("Back).");
            }

            Console.WriteLine(stringBuilder);
        }

        private int readUserChoice(int i_AmountOfOptions)
        {
            bool isValid = false;
            string choiceAsString = string.Empty;
            int choiceAsInt = 0;

            while (isValid == false)
            {
                choiceAsString = Console.ReadLine();
                if (checkIfChoiceIsValid(choiceAsString, i_AmountOfOptions) == false)
                {
                    Console.WriteLine("Invalid input. Please enter a valid input.");
                }
                else
                {
                    int.TryParse(choiceAsString, out choiceAsInt);
                    isValid = true;
                }
            }

            return choiceAsInt;
        }
    }
}
