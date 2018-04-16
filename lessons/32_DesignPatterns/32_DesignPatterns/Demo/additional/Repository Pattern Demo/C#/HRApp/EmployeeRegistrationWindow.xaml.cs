using System.Windows;
using System.Windows.Controls;
using HRApp.Web;

namespace HRApp
{
    public partial class EmployeeRegistrationWindow : ChildWindow
    {
        public Employee NewEmployee { get; set; }

        public EmployeeRegistrationWindow()
        {
            InitializeComponent();
            NewEmployee = new Employee();
            addEmployeeDataForm.CurrentItem = NewEmployee;
            addEmployeeDataForm.BeginEdit();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            addEmployeeDataForm.CommitEdit();
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            NewEmployee = null;
            addEmployeeDataForm.CommitEdit();
            this.DialogResult = false;
        }
    }

}

