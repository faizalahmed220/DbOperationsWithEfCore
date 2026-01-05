using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEfCore.Data
{
    public class AppDbContext: DbContext
    {
        //All properties will transfer to parent class means conn string and other configuration, You have use dbcontextoption to override the configuration

        //Because ASP.NET Core DI + EF Core are designed around generics. registers DbContextOptions<AppDbContext>, not plain DbContextOptions.Hence we use without 
        // generic way its unable to resolve
        public AppDbContext( DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }
    }
}
