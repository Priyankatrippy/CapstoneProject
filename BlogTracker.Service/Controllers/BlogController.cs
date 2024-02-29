using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlogTracker.DAL.Repositories;

namespace BlogTracker.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogRepository _blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
    }
}
