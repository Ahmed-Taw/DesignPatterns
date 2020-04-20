using System;

namespace DesignPatterns.Chain_Of_Responsability
{
    public interface IExpenseReport
    {
        Decimal Total { get; }
    }

    public interface IExpenseApprover
    {
        ApprovalResponse ApproveExpense(IExpenseReport expenseReport);
    }

    public enum ApprovalResponse
    {
        Denied,
        Approved,
        BeyondApprovalLimit,
    }
}
