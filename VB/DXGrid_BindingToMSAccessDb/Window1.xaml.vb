Imports System.Windows

Namespace DXGrid_BindingToMSAccessDb

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = New nwindCustomerDataSetTableAdapters.CustomersTableAdapter().GetData()
        End Sub
    End Class
End Namespace
