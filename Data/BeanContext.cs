using all_the_beans.Models;
using Microsoft.EntityFrameworkCore;

namespace all_the_beans.Data
{
    public class BeanContext : ApplicationDbContext
    {
        public BeanContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Bean> Beans { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bean>().ToTable("Bean");
            base.OnModelCreating(modelBuilder);
        }
    }
}
