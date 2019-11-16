using Microsoft.EntityFrameworkCore;

namespace warehouseCMS.Data
{
    public class CmsContext : DbContext
    {
        public CmsContext(DbContextOptions options) : base(options) 
        {

        }
    }
}