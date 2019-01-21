using Entity.Table;
using Microsoft.EntityFrameworkCore;

namespace Entity
{
    public class SenseContext : DbContext
    {
        public SenseContext(DbContextOptions<SenseContext> options)
            : base(options)
        { }

        public DbSet<Test> Tests{get;set;}
    }
}