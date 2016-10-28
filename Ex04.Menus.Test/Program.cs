namespace Ex04.Menus.Test
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Ex04.Menus.Interfaces;
    using Ex04.Menus.Delegates;
    using Ex02.ConsoleUtils;


    public class Program
    {
        public static void RunInterfacesSolution()
        {
            string chooseOptionMessege = "Please, choose one of the options";

            Ex04.Menus.Interfaces.MainMenu mainMenu = new Ex04.Menus.Interfaces.MainMenu("Main menu", chooseOptionMessege);

            Ex04.Menus.Interfaces.MainMenu showDateORTimeMenu = new Ex04.Menus.Interfaces.MainMenu("Show Date/Time", chooseOptionMessege);
            mainMenu.addOption(showDateORTimeMenu);

            Ex04.Menus.Interfaces.ExecutableOperation wordCounterOption = new Ex04.Menus.Interfaces.WordsCounterOperation("Words Counter");
            mainMenu.addOption(wordCounterOption);

            Ex04.Menus.Interfaces.ExecutableOperation showVersionOption = new Ex04.Menus.Interfaces.ShowVersionOperation("Show Version");
            mainMenu.addOption(showVersionOption);

            Ex04.Menus.Interfaces.ExecutableOperation showTimeOption = new Ex04.Menus.Interfaces.ShowTimeOperation("Show Time");
            showDateORTimeMenu.addOption(showTimeOption);

            Ex04.Menus.Interfaces.ExecutableOperation showDateOption = new Ex04.Menus.Interfaces.ShowDateOperation("Show Date");
            showDateORTimeMenu.addOption(showDateOption);

            showDateORTimeMenu.setPreviousMenu(mainMenu);

            mainMenu.Show();
        }

        public static void RunDelegatesSolution()
        {
            Ex02.ConsoleUtils.Screen.Clear();
            Console.WriteLine("Delegates solution...");

            string chooseOptionMessege = "Please, choose one of the options";

            Ex04.Menus.Delegates.MainMenu mainMenu = new Ex04.Menus.Delegates.MainMenu("Main menu", chooseOptionMessege);

            Ex04.Menus.Delegates.MainMenu showDateORTimeMenu = new Ex04.Menus.Delegates.MainMenu("Show Date/Time", chooseOptionMessege);
            mainMenu.addOption(showDateORTimeMenu);

            Ex04.Menus.Delegates.ExecutableOperation wordCounterOption = new Ex04.Menus.Delegates.ExecutableOperation(new Ex04.Menus.Delegates.Operation(Ex04.Menus.Delegates.Operations.WordsCounterOperation), "Words Counter");
            mainMenu.addOption(wordCounterOption);

            Ex04.Menus.Delegates.ExecutableOperation showVersionOption = new Ex04.Menus.Delegates.ExecutableOperation(new Ex04.Menus.Delegates.Operation(Ex04.Menus.Delegates.Operations.ShowVersionOperation), "Show Version");
            mainMenu.addOption(showVersionOption);

            Ex04.Menus.Delegates.ExecutableOperation showTimeOption = new Ex04.Menus.Delegates.ExecutableOperation(new Ex04.Menus.Delegates.Operation(Ex04.Menus.Delegates.Operations.ShowTimeOperation), "Show Time");
            showDateORTimeMenu.addOption(showTimeOption);

            Ex04.Menus.Delegates.ExecutableOperation showDateOption = new Ex04.Menus.Delegates.ExecutableOperation(new Ex04.Menus.Delegates.Operation(Ex04.Menus.Delegates.Operations.ShowDateOperation), "Show Date");
            showDateORTimeMenu.addOption(showDateOption);
            showDateORTimeMenu.setPreviousMenu(new Ex04.Menus.Delegates.ShowMenu(mainMenu.Show));

            mainMenu.Show();
        }

        public static void Main()
        {
            RunInterfacesSolution();
            RunDelegatesSolution();
        }
    }
}

