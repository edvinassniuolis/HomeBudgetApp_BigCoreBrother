using HomeBudgetApp_BigCoreBrother.Contract;
using HomeBudgetApp_BigCoreBrother.Data;

namespace HomeBudgetApp_BigCoreBrother.Factory
{
    class ProductFactory : IExpensesFactory
    {
        public IExpenses Create()
        {
            return new Product();
        }
    }
}
