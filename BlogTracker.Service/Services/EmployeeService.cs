
using BlogTracker.DAL.Entity;
using BlogTracker.DAL.Repositories;

using BlogTracker.Service.Interfaces;
using System.Collections.Generic;

namespace BlogTracker.Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<EmpInfo> GetAllEmployees()
        {
            return _employeeRepository.GetAllEmployees();
        }

        public EmpInfo GetEmployeeByEmail(string email)
        {
            return _employeeRepository.GetEmployeeByEmail(email);
        }


    }
}

