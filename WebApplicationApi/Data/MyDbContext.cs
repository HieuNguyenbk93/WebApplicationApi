using Microsoft.EntityFrameworkCore;

namespace WebApplicationApi.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> opt): base(opt)
        {

        }
    }
}
