using BlogTracker.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogTracker.DAL.Context
{
   public  class BlogContext:DbContext
    {
        public DbSet<AdminInfo> AdminInfos { get; set; }
        public DbSet<EmpInfo> EmpInfos { get; set; }
        public DbSet<BlogInfo> BlogInfos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)

        {
        }
    }
}
