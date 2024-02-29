using BlogTracker.DAL.Context;
using BlogTracker.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogTracker.DAL.Repositories
{
    public  class EmployeeRepository:IEmployeeRepository
    {
        private readonly BlogContext _context;

        public EmployeeRepository(BlogContext context)
        {
            _context = context;
        }

        public void AddEmployee(EmpInfo employee)
        {
            _context.EmpInfos.Add(employee);
            _context.SaveChanges();
        }

        public IEnumerable<EmpInfo> GetAllEmployees()
        {
            return _context.EmpInfos.ToList();
        }

        public EmpInfo GetEmployeeByEmail(string email)
        {
            return _context.EmpInfos.FirstOrDefault(e => e.EmailId == email);
        }

    }
}
