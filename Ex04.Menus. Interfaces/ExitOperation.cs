namespace Ex04.Menus.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ExitOperation : ExecutableOperation
    {
        public ExitOperation(string i_OperationName) : base(i_OperationName)
        {
        }

        public override void ExecuteOperation()
        {
            Console.WriteLine("Thank you for using our software. Goodbye!");
        }
    }
}
