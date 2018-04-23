using System.Windows;

namespace DXGrid_BindingToMSAccessDb {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            grid.ItemsSource = 
                new nwindCustomerDataSetTableAdapters.CustomersTableAdapter().GetData();
        }
    }
}
