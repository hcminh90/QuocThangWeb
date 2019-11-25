using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using warehouseCMS.Data;
using warehouseCMS.Repository;

namespace warehouseCMS.Extensions
{
    public static class DBConnect
    {
        public static void AddMySql(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<CmsContext>(o => o.UseMySQL(configuration["ConnectionStrings:DefaultConnection"]));
            service.AddScoped<DataAccess, RepositoryContext>();
        }
    }
}