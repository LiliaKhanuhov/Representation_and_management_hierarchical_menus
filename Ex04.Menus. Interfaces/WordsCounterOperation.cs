namespace Ex04.Menus.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class WordsCounterOperation : ExecutableOperation
    {
        private string typedSentence     = null;
        private string userMessage       = null;
        private int numOfSentenceWords = 1;

        public WordsCounterOperation (string i_OperationName) : base(i_OperationName)
        {
        }

        public override void ExecuteOperation()
        {
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
