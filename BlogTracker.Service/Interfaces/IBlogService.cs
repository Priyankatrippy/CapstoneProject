using BlogTracker.DAL.Entity;

namespace BlogTracker.Service.Interfaces
{
    public interface IBlogService
    {
        IEnumerable<BlogInfo> GetAllBlogs();
        BlogInfo GetBlogById(int id);
        void AddBlog(BlogInfo blog);
        void UpdateBlog(BlogInfo blog);
        void DeleteBlog(int id);
    }
}
