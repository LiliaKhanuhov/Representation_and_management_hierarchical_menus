namespace Ex04.Menus.Delegates
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Operations
    {
        public static void ExitOperations()
        {
            Console.WriteLine("Thank you for using our software. Goodbye!");
        }

        public static void ShowVersionOperation()
        {
            Console.WriteLine("Version: 14.2.4.0");
        }

        public static void ShowDateOperation()
        {
            DateTime now = DateTime.Now;
            string infoStr = now.ToString();
            string[] splitInfoStr = infoStr.Split(' ');
            string todayDataStr = String.Format(
@"Today's Date is {0}", splitInfoStr[0]);

            Console.WriteLine(todayDataStr);
        }

        public static void ShowTimeOperation()
        {
            DateTime now = DateTime.Now;
            string infoStr = now.ToString();
            string[] splitInfoStr = infoStr.Split(' ');
            string todayDataStr = String.Format(
@"Today's Date is {0}", splitInfoStr[1]);

            Console.WriteLine(todayDataStr);
        }

        public static void WordsCounterOperation()
        {
            string typedSentence = null;
            string userMessage = null;
            int numOfSentenceWords = 1;

            Console.WriteLine("Please, type a sentence");
            typedSentence = Console.ReadLine();

            for (int i = 0; i < typedSentence.Length; i++)
            {
                if (typedSentence[i].Equals(' '))
                {
                    numOfSentenceWords++;
                }
            }
            userMessage = String.Format(
@"Operation was successful!
Number of words in the sentence is {0}", numOfSentenceWords);

            Ex02.ConsoleUtils.Screen.Clear();
            Console.WriteLine(userMessage);
        }
    }
}


