using BlogTracker.DAL.Entity;
using BlogTracker.DAL.Repositories;
using BlogTracker.Service.Interfaces;
using System;
using System.Collections.Generic;


namespace BlogTracker.Service.Services
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository _blogRepository;

        public BlogService(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public IEnumerable<BlogInfo> GetAllBlogs()
        {
            return _blogRepository.GetAllBlogs();
        }

        public BlogInfo GetBlogById(int id)
        {
            return _blogRepository.GetBlogById(id);
        }

        public void AddBlog(BlogInfo blog)
        {
            blog.DateOfCreation = DateTime.Now;
            _blogRepository.AddBlog(blog);
        }

        public void UpdateBlog(BlogInfo blog)
        {
            _blogRepository.UpdateBlog(blog);
        }

        public void DeleteBlog(int id)
        {
            _blogRepository.DeleteBlog(id);
        }

    }
}
