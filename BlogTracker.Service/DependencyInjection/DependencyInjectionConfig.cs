using BlogTracker.DAL.Repositories;

namespace BlogTracker.Service.DependencyInjection
{
   
        public static class DependencyInjectionConfig
        {
            public static void RegisterServices(IServiceCollection services)
            {
                services.AddScoped<IEmployeeRepository, EmployeeRepository>();
                services.AddScoped<IBlogRepository, BlogRepository>();
                
            }
        }
}
