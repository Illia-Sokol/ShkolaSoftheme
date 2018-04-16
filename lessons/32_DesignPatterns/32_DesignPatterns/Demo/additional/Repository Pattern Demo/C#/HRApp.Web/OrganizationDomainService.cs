using System;
using System.Linq;
using System.ServiceModel.DomainServices;
using Microsoft.ServiceModel.DomainServices.LinqToSql;
using System.ServiceModel.DomainServices.Server;
using System.ServiceModel.DomainServices.Hosting;

namespace HRApp.Web.Repository
{
    //Add LinqToSQL metadata provider so that domain service
    //can reference Linq to SQL generated entities
    [LinqToSqlDomainServiceDescriptionProvider(typeof(AdventureWorksDataContext))]    
    [EnableClientAccess()]
    public class OrganizationDomainService : DomainService
    {
        private IRepository<Employee> employeeRepository;

        public OrganizationDomainService(IRepository<Employee> empRepository)
        {
            this.employeeRepository = empRepository;
        }

        public IQueryable<Employee> GetEmployee()
        {
            return this.employeeRepository.Query().OrderBy(e => e.EmployeeID);
        }

        public IQueryable<Employee> GetSalariedEmployee()
        {
            return this.employeeRepository.Query().Where(e => e.SalariedFlag == true).OrderBy(e => e.EmployeeID);
        }

        public void InsertEmployee(Employee employee)
        {
            // Modify the employee data to meet the database constraints.
            employee.HireDate = DateTime.Now;
            employee.ModifiedDate = DateTime.Now;
            employee.VacationHours = 0;
            employee.SickLeaveHours = 0;
            employee.rowguid = Guid.NewGuid();
            employee.ContactID = 1001;
            employee.BirthDate = new DateTime(1967, 3, 18);

            this.employeeRepository.Add(employee);
        }

        public void UpdateEmployee(Employee currentEmployee)
        {
            this.employeeRepository.Attach(currentEmployee, this.ChangeSet.GetOriginal(currentEmployee));
        }

        public void DeleteEmployee(Employee employee)
        {
            this.employeeRepository.Attach(employee);
            this.employeeRepository.Remove(employee);
        }

        public void ApproveSabbatical(Employee current)
        {
            this.employeeRepository.Attach(current);
            current.CurrentFlag = false;
        }

        #region Base class Overrides
        /// <summary>
        /// This method is called to finalize changes after all the operations in the specified changeset
        /// have been invoked. All changes are committed to the repository.
        /// </summary>        
        ///         
        protected override bool PersistChangeSet()
        {
            this.employeeRepository.SubmitChanges();
            return true;
        }
        #endregion
    }
}
