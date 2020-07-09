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
            var adminRoleId = Guid.NewGuid().ToString();
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = adminRoleId,
                    Name = "Admin",
                    ConcurrencyStamp = "72115431-db0a-4474-bf9d-667f4adf8e25",
                    NormalizedName = "Admin".ToUpper()                    
                });
            #endregion

            #region SEED USERS

            var hasher = new PasswordHasher<IdentityUser>();
            var adminId = Guid.NewGuid().ToString();
            var userId = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = adminId,
                    UserName = "admin@admin.com",
                    NormalizedUserName = "admin@admin.com".ToUpper(),
                    Email = "admin@admin.com",
                    NormalizedEmail = "admin@admin.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "Tombola1!"),
                    SecurityStamp = Guid.NewGuid().ToString("D")
                },
                new IdentityUser
                {
                    Id = userId,
                    UserName = "user@user.com",
                    NormalizedUserName = "user@user.com".ToUpper(),
                    Email = "user@user.com",
                    NormalizedEmail = "user@user.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "Tombola1!"),
                    SecurityStamp = Guid.NewGuid().ToString("D")
                });
            #endregion


            #region SEED USER ROLES
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = adminId
                });
            #endregion

            #region SEED BEANS
            modelBuilder.Entity<Bean>().HasData(
                new Bean
                {
                    Id = Guid.NewGuid(),
                    Name = "Arabica",
                    Cost = 5.99,
                    Aroma = "Smoky",
                    Colour = "Dark",
                    Image = "1594313819_def.jpg",
                    Date = new DateTime(2020, 7, 13)
                },
                new Bean
                {
                    Id = Guid.NewGuid(),
                    Name = "Robusta",
                    Cost = 9.99,
                    Aroma = "Medicinal",
                    Colour = "Very dark",
                    Image = "1594313817_def.jpg",
                    Date = new DateTime(2020, 7, 14)
                }
            );
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}