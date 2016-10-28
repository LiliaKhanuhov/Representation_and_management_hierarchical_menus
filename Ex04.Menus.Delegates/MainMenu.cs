namespace Ex04.Menus.Delegates
{
        using System;
        using System.Collections.Generic;
        using System.Text;
        using Ex02.ConsoleUtils;
        using System.Timers;

        public class MainMenu : MenuItem
        {
            private readonly List<MenuItem> m_MenuOptionsList;
            private string m_MenuTitle;
            private string m_MenuMessage;
            private ShowMenu m_PreviousMenuOption = null;
            private const int k_ExitOption = 0;
            private const int k_EnumerationsStartOfOptions = 1;

            public MainMenu(string i_MenuTitle, string i_MenuMessage)
            {
                this.m_MenuOptionsList = new List<MenuItem>();
                this.m_MenuTitle = i_MenuTitle;
                this.m_MenuMessage = i_MenuMessage;
                this.m_PreviousMenuOption = null;
            }

            public override string ToString()
            {
                return this.m_MenuTitle;
            }

            public void setPreviousMenu(ShowMenu i_PreviousMenu)
            {
                this.m_PreviousMenuOption = i_PreviousMenu;
            }

            public void addOption(MenuItem i_Option)
            {
                m_MenuOptionsList.Add(i_Option);
            }

            public void Show()
            {
                int selectedOption;
            Operation exitOperation;


                displayMenu();
                selectedOption = getSelectedOption();
                if (selectedOption == k_ExitOption)
                {
                    Ex02.ConsoleUtils.Screen.Clear();
                    if (this.m_PreviousMenuOption == null)
                    {
                        exitOperation = Operations.ExitOperations;
                        exitOperation.Invoke();
                        return;
                    }
                    else
                    {
                        this.m_PreviousMenuOption.Invoke();
                    }
                }
                else
                {
                    Ex02.ConsoleUtils.Screen.Clear();
                    m_MenuOptionsList[selectedOption - k_EnumerationsStartOfOptions].ExecuteOption();

                    for (int i = 0; i < 300000000; i++)
                    {
                    }

                    Ex02.ConsoleUtils.Screen.Clear();
                    if (m_MenuOptionsList[selectedOption - k_EnumerationsStartOfOptions] is ExecutableOperation)
                    {
                        Show();
                    }
                }
            }

            private void displayMenu()
            {
                int optionNumber = k_EnumerationsStartOfOptions;

                string titleOfCurrentMenu = string.Format(
    @"                 {0}                  ", this.ToString());

                Console.WriteLine(titleOfCurrentMenu);
                if (this.m_PreviousMenuOption == null)
                {
                    Console.WriteLine("0) Exit");
                }
                else
                {
                    Console.WriteLine("0) Back");
                }

                foreach (MenuItem menuOption in m_MenuOptionsList)
                {
                    Console.WriteLine("{0}) {1}", optionNumber, menuOption.ToString());
                    optionNumber++;
                }

                Console.WriteLine(m_MenuMessage);
            }

            private int getSelectedOption()
            {
                int o_SelectedOption;
                int maxOptionNumber = this.m_MenuOptionsList.Count;
                bool selectedOptionValid = false;

                selectedOptionValid = int.TryParse(Console.ReadLine(), out o_SelectedOption);
                while (!selectedOptionValid || o_SelectedOption > maxOptionNumber)
                {
                    Console.WriteLine("Invalid choice! Please, enter a number between 0 and {0}", maxOptionNumber);
                    selectedOptionValid = int.TryParse(Console.ReadLine(), out o_SelectedOption);
                }

                return o_SelectedOption;
            }

            public void ExecuteOption()
            {
                Show();
            }
        }
    }

