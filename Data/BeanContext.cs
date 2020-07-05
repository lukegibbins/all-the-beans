using all_the_beans.Models;
using Microsoft.EntityFrameworkCore;
using System;

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

            modelBuilder.Entity<Bean>().HasData(
                new Bean { 
                    Id = Guid.NewGuid(),
                    Name = "Craigy's cocoa bean",
                    Cost = 5.99,
                    Aroma = "smells like chocolate",
                    Colour = "black", 
                    Image = "http://sample.com",
                    Date = new DateTime(2009, 5, 19)
                },
                new Bean {
                    Id = Guid.NewGuid(),
                    Name = "Columbias finest",
                    Cost = 3.20,
                    Aroma = "smells like flowers",
                    Colour = "green",
                    Image = "http://sample.com",
                    Date = new DateTime(2010, 5, 19)
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}