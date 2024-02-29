using BlogTracker.DAL.Context;
using BlogTracker.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogTracker.DAL.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly BlogContext _context;

        public BlogRepository(BlogContext context)
        {
            _context = context;
        }

        public void AddBlog(BlogInfo blog)
        {
            if (blog == null)
                throw new ArgumentNullException(nameof(blog));

            _context.BlogInfos.Add(blog);
            _context.SaveChanges();
        }

        public IEnumerable<BlogInfo> GetAllBlogs()
        {
            return _context.BlogInfos.ToList();
        }

        public BlogInfo GetBlogById(int id)
        {
            return _context.BlogInfos.FirstOrDefault(b => b.BlogInfoId == id);
        }

        public void UpdateBlog(BlogInfo blog)
        {
            if (blog == null)
                throw new ArgumentNullException(nameof(blog));

            var existingBlog = _context.BlogInfos.Find(blog.BlogInfoId);
            if (existingBlog == null)
                throw new InvalidOperationException("Blog not found");

            existingBlog.Title = blog.Title;
            existingBlog.Subject = blog.Subject;
            existingBlog.DateOfCreation = blog.DateOfCreation;
            existingBlog.BlogUrl = blog.BlogUrl;
            existingBlog.EmpEmailId = blog.EmpEmailId;

            _context.SaveChanges();
        }

        public void DeleteBlog(int id)
        {
            var blog = _context.BlogInfos.Find(id);
            if (blog != null)
            {
                _context.BlogInfos.Remove(blog);
                _context.SaveChanges();
            }
        }

        public void DeleteBlog(BlogInfo existingBlog)
        {
            if (existingBlog == null)
                throw new ArgumentNullException(nameof(existingBlog));

            _context.BlogInfos.Remove(existingBlog);
            _context.SaveChanges();
        }
    }

 }


