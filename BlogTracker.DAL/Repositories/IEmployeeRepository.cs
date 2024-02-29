using BlogTracker.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogTracker.DAL.Repositories
{
   public  interface IEmployeeRepository
    {
        void AddEmployee(EmpInfo employee);
        IEnumerable<EmpInfo> GetAllEmployees();
        EmpInfo GetEmployeeByEmail(string email);
    }
}
