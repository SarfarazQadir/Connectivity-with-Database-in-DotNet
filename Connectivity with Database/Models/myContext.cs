using Microsoft.EntityFrameworkCore;

namespace Connectivity_with_Database.Models
{
    public class myContext : DbContext
    {
        public myContext(DbContextOptions<myContext> options) : base(options)
        {

        }
    }
}
