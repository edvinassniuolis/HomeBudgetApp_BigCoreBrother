﻿namespace HomeBudgetApp_BigCoreBrother.Data
{
    public class Product : IExpenses
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
    }
}
