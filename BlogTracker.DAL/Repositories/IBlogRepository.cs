using BlogTracker.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogTracker.DAL.Repositories
{
    public interface  IBlogRepository
    {
        void AddBlog(BlogInfo blog);
        IEnumerable<BlogInfo> GetAllBlogs();
        BlogInfo GetBlogById(int id);
        void UpdateBlog(BlogInfo blog);
        void DeleteBlog(int id);
        void DeleteBlog(BlogInfo existingBlog);
    }
}
