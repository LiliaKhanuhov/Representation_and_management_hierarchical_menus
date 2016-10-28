namespace Ex04.Menus.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class ShowDataOrTimeOperation : ExecutableOperation
    {
        public ShowDataOrTimeOperation(string i_OperationName) : base (i_OperationName)
        {
        }

        public string[] GetNecessaryInfo()
        {
            DateTime now = DateTime.Now;
            string infoStr = now.ToString();
            string[] splitInfoStr = infoStr.Split(' ');
            return splitInfoStr;
        }
    }
}
