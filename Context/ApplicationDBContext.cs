using JWTApp.Models;
using Microsoft.EntityFrameworkCore;

namespace JWTApp.Context
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}
