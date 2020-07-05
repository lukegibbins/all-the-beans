using all_the_beans.Models;
using Microsoft.AspNetCore.Identity;
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

            #region SEED ROLES
            var adminRoleGUID = Guid.NewGuid().ToString();
            var userRoleGUID = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = adminRoleGUID,
                    Name = "Admin",
                    NormalizedName = "Admin".ToUpper()
                },
                new IdentityRole
                {
                    Id = userRoleGUID,
                    Name = "User",
                    NormalizedName = "User".ToUpper()
                });
            #endregion

            #region SEED USERS
            var adminGUID = Guid.NewGuid().ToString();
            var userGUID = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = adminGUID,
                    UserName = "admin",
                    Email = "admin@admin.com",
                    PasswordHash = "admin"
                },
                new IdentityUser
                {
                    Id = userGUID,
                    UserName = "user",
                    Email = "user@user.com",
                    PasswordHash = "user"
                });
            #endregion

            #region SEED USER ROLES
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleGUID,
                    UserId = adminGUID
                },
                 new IdentityUserRole<string>
                 {
                     RoleId = userRoleGUID,
                     UserId = userGUID
                 });
            #endregion

            #region SEED BEANS
            modelBuilder.Entity<Bean>().HasData(
                new Bean
                {
                    Id = Guid.NewGuid(),
                    Name = "Craigy's cocoa bean",
                    Cost = 5.99,
                    Aroma = "smells like chocolate",
                    Colour = "black",
                    Image = "http://sample.com",
                    Date = new DateTime(2009, 5, 19)
                },
                new Bean
                {
                    Id = Guid.NewGuid(),
                    Name = "Columbias finest",
                    Cost = 3.20,
                    Aroma = "smells like flowers",
                    Colour = "green",
                    Image = "http://sample.com",
                    Date = new DateTime(2010, 5, 19)
                }
            );
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}