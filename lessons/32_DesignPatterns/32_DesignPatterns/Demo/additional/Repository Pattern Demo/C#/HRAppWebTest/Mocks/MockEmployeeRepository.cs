
namespace HRApp.Web.Test
{
public class MockEmployeeRepository : MockRepository<Employee>
{
    public MockEmployeeRepository()
    {
        Init();
    }

    void Init()
    {
        // populate in-memory data
        this.AddTable();
        Employee p1 = new Employee() { EmployeeID = 1, SalariedFlag = true };
        Employee p2 = new Employee() { EmployeeID = 2, SalariedFlag = true };
        Employee p3 = new Employee() { EmployeeID = 3, SalariedFlag = false };
        this.Table.Add(p1);
        this.Table.Add(p2);
        this.Table.Add(p3);
    }
}


}
