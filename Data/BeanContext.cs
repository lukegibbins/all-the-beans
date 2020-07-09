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
            var hasher = new PasswordHasher<IdentityUser>();

            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = adminGUID,
                    UserName = "admin",
                    NormalizedUserName = "admin",
                    Email = "admin@admin.com",
                    NormalizedEmail = "admin@admin.com",
                    PasswordHash = hasher.HashPassword(null, "admin"),
                    SecurityStamp = string.Empty
                },
                new IdentityUser
                {
                    Id = userGUID,
                    UserName = "user",
                    NormalizedUserName = "user",
                    Email = "user@user.com",
                    NormalizedEmail = "user@user.com",
                    PasswordHash = hasher.HashPassword(null, "user"),
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
                    Colour = "green",
                    Image = "1594313817_def.jpg",
                    Date = new DateTime(2020, 7, 14)
                }
            );
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}