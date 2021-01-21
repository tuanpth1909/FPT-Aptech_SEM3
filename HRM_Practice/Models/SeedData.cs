using HRM_Practice.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM_Practice.Models
{
    public static class SeedData 
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            HRMDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<HRMDbContext>(); 

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                     new Employee
                     {
                         Name = "Pham Tuan",
                         Gender = "Male",
                         PhoneNumber = "0382548442",
                         EmailAddress = "tuanpth1908045@fpt.edu.vn",
                         Position = "Manager",
                         Salary = 1000
                     },
                    new Employee
                    {
                        Name = "Bui Quang Huy",
                        Gender = "Male",
                        PhoneNumber = "0982563542",
                        EmailAddress = "huy@fpt.edu.vn",
                        Position = "Leader",
                        Salary = 200
                    },
                    new Employee
                    {
                        Name = "Truong Thanh Tu",
                        Gender = "Male",
                        PhoneNumber = "0986521123",
                        EmailAddress = "tu@fpt.edu.vn",
                        Position = "Secretary ",
                        Salary = 360
                    },
                    new Employee
                    {
                        Name = "Pham Thanh Loan",
                        Gender = "Female",
                        PhoneNumber = "0362587958",
                        EmailAddress = "loan@fpt.edu.vn",
                        Position = "Apprentice",
                        Salary = 100
                    },
                    new Employee
                    {
                        Name = "Hoang Ngan",
                        Gender = "Female",
                        PhoneNumber = "0654856321",
                        EmailAddress = "ngan@fpt.edu.vn",
                        Position = "Trainee",
                        Salary = 100
                    },
                    new Employee
                    {
                        Name = "Pham Quy Luong",
                        Gender = "Male",
                        PhoneNumber = "0653258987",
                        EmailAddress = "luong@fpt.edu.vn",
                        Position = "Director",
                        Salary = 2000
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}

