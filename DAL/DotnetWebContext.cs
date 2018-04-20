using Microsoft.EntityFrameworkCore;

namespace DotnetWeb.DAL
{
    public class DotnetWebContext : DbContext
    {
        public DotnetWebContext(DbContextOptions<DotnetWebContext> options) : base(options)
        {

        }
    }
}