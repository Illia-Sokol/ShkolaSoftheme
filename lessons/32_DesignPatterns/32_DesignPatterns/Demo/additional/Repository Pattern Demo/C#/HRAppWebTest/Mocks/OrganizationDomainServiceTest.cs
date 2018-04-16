using System;
using System.Linq;
using HRApp.Web.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HRApp.Web.Test
{
    /// <summary>
    /// Unit test for Organization domain service
    /// </summary>
[TestClass]
public class OrganizationDomainServiceTest
{
    [TestMethod]
    public void TestGetSalariedEmployee()
    {
        MockEmployeeRepository mockEmployeeRepository = new MockEmployeeRepository();
        OrganizationDomainService orgDomainSvc = new OrganizationDomainService(mockEmployeeRepository);

        IQueryable<Employee> salariedEmployees = orgDomainSvc.GetSalariedEmployee();
        Assert.IsTrue(salariedEmployees.Count() == 2, "Salaried employee count does not match.");
    }

    [TestMethod]
    public void TestInsertEmployee()
    {
        MockEmployeeRepository mockEmployeeRepository = new MockEmployeeRepository();
        OrganizationDomainService orgDomainSvc = new OrganizationDomainService(mockEmployeeRepository);

        Employee newEmployee = new Employee() { EmployeeID = 9, SalariedFlag = true };
        orgDomainSvc.InsertEmployee(newEmployee);
        Assert.AreEqual(DateTime.Today, newEmployee.HireDate.Date, "Hire date not as expected.");
    }
}
}
