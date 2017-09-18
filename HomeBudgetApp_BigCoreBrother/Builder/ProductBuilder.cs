using HomeBudgetApp_BigCoreBrother.Data;

namespace HomeBudgetApp_BigCoreBrother.Builder
{
    public class ProductBuilder
    {
        private readonly Product _product;

        public ProductBuilder()
        {
            _product = new Product()
            {
                Name = string.Empty,
                Description = string.Empty,
                Cost = 0
            };
        }

        public ProductBuilder AddName(string name)
        {
            _product.Name = name;
            return this;
        }
        public ProductBuilder AddDescription(string description)
        {
            _product.Description = description;
            return this;
        }
        public ProductBuilder AddCost(double cost)
        {
            _product.Cost = cost;
            return this;
        }

        public Product Add()
        {
            return _product;
        }
    }
}
