using System.Windows;

namespace DXGrid_BindingToMSAccessDb {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            grid.DataSource = 
                new nwindCustomerDataSetTableAdapters.CustomersTableAdapter().GetData();
        }
    }
}
