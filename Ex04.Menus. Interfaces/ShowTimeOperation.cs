namespace Ex04.Menus.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ShowTimeOperation : ShowDataOrTimeOperation
    {
        public ShowTimeOperation(string i_OperationName) : base(i_OperationName)
        {
        }

        public override void ExecuteOperation()
        {
            string[] info =  GetNecessaryInfo();
            string todayNowStr = String.Format(
@"Now is {0}", info[1]);

            Console.WriteLine(todayNowStr);
        }
    }
}