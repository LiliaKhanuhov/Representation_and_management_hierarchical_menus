namespace Ex04.Menus.Delegates
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ExecutableOperation : MenuItem
    {
        private string m_OperationName;
        private Operation m_Operation;

        public ExecutableOperation(Operation i_Operation, string i_OperationName)
        {
            this.m_Operation = i_Operation;
            this.m_OperationName = i_OperationName;
        }

        public void ExecuteOption()
        {
            this.m_Operation();
        }

        public override string ToString()
        {
            return this.m_OperationName;
        }
    }
}
