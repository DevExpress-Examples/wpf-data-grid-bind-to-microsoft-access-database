Imports System.Windows

Namespace DXGrid_BindingToMSAccessDb
    Partial Public Class Window1
        Inherits Window

        Public Sub New()
            InitializeComponent()
            grid.ItemsSource = (New nwindCustomerDataSetTableAdapters.CustomersTableAdapter()).GetData()
        End Sub
    End Class
End Namespace
