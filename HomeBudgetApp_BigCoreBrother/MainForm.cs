using HomeBudgetApp_BigCoreBrother.Builder;
using HomeBudgetApp_BigCoreBrother.Factory;
using System.Windows.Forms;

namespace HomeBudgetApp_BigCoreBrother
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            InitExpenses();
        }

        public void InitExpenses()
        {
            var product = new ProductFactory().Create();
            var service = new ServiceFactory().Create();

            var newProduct = new ProductBuilder().AddName(productExpensesTxtBox.Text).Add();
        }
    }
}
