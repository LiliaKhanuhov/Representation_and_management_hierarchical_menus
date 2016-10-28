namespace Ex04.Menus.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ShowDateOperation : ShowDataOrTimeOperation
    {
        public ShowDateOperation (string i_OperationName) : base(i_OperationName)
        {
        }

        public override void ExecuteOperation()
        {
           string[] info =  GetNecessaryInfo();
            
            string todayDataStr = String.Format(
@"Today's Date is {0}", info[0]);

            Console.WriteLine(todayDataStr);
        }
    }
}
