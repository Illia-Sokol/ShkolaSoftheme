using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using HRApp.Web;
using HRApp.Web.Repository;

namespace HRApp
{
    public partial class EmployeeList : Page
    {
        public EmployeeList()
        {
            InitializeComponent();
        }

        // Occurs when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            employeeDataSource.SubmitChanges();
        }


        private void approveSabbatical_Click(object sender, RoutedEventArgs e)
        {
            Employee luckyEmployee = (Employee)(dataGrid1.SelectedItem);
            luckyEmployee.ApproveSabbatical();
            employeeDataSource.SubmitChanges();
        }

        private void addNewEmployee_Click(object sender, RoutedEventArgs e)
        {
            EmployeeRegistrationWindow addEmp = new EmployeeRegistrationWindow();
            addEmp.Closed += new EventHandler(addEmp_Closed);
            addEmp.Show();
        }

        void addEmp_Closed(object sender, EventArgs e)
        {
            EmployeeRegistrationWindow emp = (EmployeeRegistrationWindow)sender;
            if (emp.NewEmployee != null && emp.DialogResult == true)
            {
                OrganizationDomainContext _OrganizationContext = (OrganizationDomainContext)(employeeDataSource.DomainContext);
                _OrganizationContext.Employees.Add(emp.NewEmployee);
                employeeDataSource.SubmitChanges();
            }
        }
    }
}
