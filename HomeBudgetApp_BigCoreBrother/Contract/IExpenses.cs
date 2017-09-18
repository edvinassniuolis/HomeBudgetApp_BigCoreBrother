namespace HomeBudgetApp_BigCoreBrother
{
    public interface IExpenses
    {
        string Name { get; set; }
        string Description { get; set; }
        double Cost { get; set; }
    }
}
