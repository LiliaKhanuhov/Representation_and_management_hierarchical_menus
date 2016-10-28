namespace Ex04.Menus.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ShowVersionOperation : ExecutableOperation
    {
        public ShowVersionOperation(string i_OperationName) : base(i_OperationName)
        {
        }

        public override void ExecuteOperation()
        {
            Console.WriteLine("Version: 14.2.4.0");
        }
    }
}
