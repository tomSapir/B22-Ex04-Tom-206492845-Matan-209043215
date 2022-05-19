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
            MenuItem currentMenuItem = this, chosenMenuItem;
            bool currentMenuItemIsMainMenu;

            while (true)
            {
                currentMenuItemIsMainMenu = currentMenuItem.ItemAboveMeInTheHierarchy == null;
                Console.WriteLine(currentMenuItem.ToString());
                choiceAsInt = readUserChoice(currentMenuItem.SubMenuItem.Count);
                if (choiceAsInt == 0)
                {
                    if (currentMenuItemIsMainMenu)
                    {
                        break;
                    }

                    currentMenuItem = currentMenuItem.ItemAboveMeInTheHierarchy;
                }
                else
                {
                    chosenMenuItem = currentMenuItem.SubMenuItem[choiceAsInt - 1];
                    if (chosenMenuItem.AmIALeaf())
                    {
                        Console.Clear();
                        chosenMenuItem.NotifyAllThatImChosen();
                    }
                    else
                    {
                        currentMenuItem = chosenMenuItem;
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
                if (choiceAsInt < 0 || choiceAsInt > i_AmountOfOptions)
                {
                    isValid = false;
                }
            }

            return isValid;
        }

        private int readUserChoice(int i_AmountOfOptions)
        {
            bool isValid = false;
            string choiceAsString;
            int choiceAsInt = 0;

            while (isValid == false)
            {
                choiceAsString = Console.ReadLine();
                if (checkIfChoiceIsValid(choiceAsString, i_AmountOfOptions) == false)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 to {0}:", i_AmountOfOptions);
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
