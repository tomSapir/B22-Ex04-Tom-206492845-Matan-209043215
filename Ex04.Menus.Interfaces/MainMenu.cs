using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : MenuItem
    {
        public void Show()
        {
            int choiceAsInt;
            MenuItem currMenuItem = this;
            bool isMainMenu = true;

            while (true)
            {
                isMainMenu = currMenuItem.ItemAboveMeInTheHierarchy == null;
                printCurrentMenu(currMenuItem.Title, currMenuItem.SubMenuItem, isMainMenu);
                choiceAsInt = readUserChoice(currMenuItem.SubMenuItem.Count);
                if (choiceAsInt == 0 && isMainMenu)
                {
                    break;
                }
                else if (choiceAsInt == 0 && isMainMenu == false)
                {
                    currMenuItem = currMenuItem.ItemAboveMeInTheHierarchy;
                }
                else if (currMenuItem.SubMenuItem[choiceAsInt - 1].SubMenuItem.Count == 0)
                {
                    Console.Clear();
                    currMenuItem.SubMenuItem[choiceAsInt - 1].NotifyAllThatImChosen();
                }
                else
                {
                    currMenuItem = currMenuItem.SubMenuItem[choiceAsInt - 1];
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
                if (choiceAsInt < 0 || choiceAsInt > i_AmountOfOptions)
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
                stringBuilder.Append(i.ToString()).Append(" -> ").AppendLine(i_MenuItems[i - 1].Title);
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
