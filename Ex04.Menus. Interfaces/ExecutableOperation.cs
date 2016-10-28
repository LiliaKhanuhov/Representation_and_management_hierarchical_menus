namespace Ex04.Menus.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class ExecutableOperation : MenuItem
    {
        private string m_OperationName;

        public ExecutableOperation(string i_OperationName)
        {
            this.m_OperationName = i_OperationName;
        }

        public abstract void ExecuteOperation();

        public void ExecuteOption()
        {
            ExecuteOperation();
        }

        public override string ToString()
        {
            return this.m_OperationName;
        }
    }
}
