using BlogTracker.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogTracker.DAL.Context
{
    public class BlogContextInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        { 

            context.AdminInfos.Add(new AdminInfo { EmailId = "admin@example.com", Password = "admin123" });

            context.SaveChanges();
        }
    }
}

