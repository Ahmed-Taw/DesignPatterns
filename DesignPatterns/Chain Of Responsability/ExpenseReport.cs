using System;

namespace DesignPatterns.Chain_Of_Responsability
{
    public class ExpenseReport : IExpenseReport
    {
        public ExpenseReport(Decimal total)
        {
            Total = total;
        }

        public decimal Total 
        { 
            get;
            private set;
        }
    }
}
