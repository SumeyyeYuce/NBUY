using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSitesi.Entity.Concrete.Identity;

namespace YemekSitesi.Data.ExtensionPath
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            #region Roller
            List<Role> roles = new List<Role>
            {
                new Role
                {
                    Name=  "Admin",
                    Description="Admin Rolü",
                    NormalizedName="ADMİN"
                },
                new Role
                {
                    Name=  "User",
                    Description="User Rolü",
                    NormalizedName="USER"
                }

            };
            modelBuilder.Entity<Role>().HasData(roles);
            #endregion

            #region Kullanıcılar
            List<User> users = new List<User>
            {
                new User {

                    FirstName="Sümeyye",
                    LastName="Yüce",
                    UserName="admin",
                    NormalizedUserName= "ADMIN",
                    Gender="Kadın",
                    DateOfBirth = new DateTime(1980,7,17),
                    Email="admin@gmail.com",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    EmailConfirmed =true
                },
                new User {

                    FirstName="Ornek",
                    LastName="User",
                    UserName="user",
                    NormalizedUserName= "USER",
                    Gender="Erkek",
                    DateOfBirth = new DateTime(1986,7,17),
                     Email="user@gmail.com",
                    NormalizedEmail = "USER@GMAIL.COM",
                    EmailConfirmed =true
                }

            };
            modelBuilder.Entity<User>().HasData(users);
            #endregion

            var passwordHasher = new PasswordHasher<User>();
            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "Qwe123.");
            users[1].PasswordHash = passwordHasher.HashPassword(users[1], "Qwe123.");

            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    UserId = users[0].Id,
                    RoleId = roles.First(r=>r.Name=="Admin").Id
                },
                new IdentityUserRole<string>
                {
                    UserId = users[1].Id,
                    RoleId = roles.First(r=>r.Name=="User").Id
                }
            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }
    }
}
