using BlogTracker.DAL.Entity;

namespace BlogTracker.Service.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<EmpInfo> GetAllEmployees();
        EmpInfo GetEmployeeByEmail(string email);
    }
}
