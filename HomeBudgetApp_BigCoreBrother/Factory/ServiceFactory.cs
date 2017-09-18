using HomeBudgetApp_BigCoreBrother.Contract;
using HomeBudgetApp_BigCoreBrother.Data;

namespace HomeBudgetApp_BigCoreBrother.Factory
{
    class ServiceFactory : IExpensesFactory
    {
        public IExpenses Create()
        {
            return new Service();
        }
    }
}
