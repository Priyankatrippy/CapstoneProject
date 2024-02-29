using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlogTracker.DAL.Repositories;

namespace BlogTracker.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        
    }
}
