using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sopiration.Models
{
    public static class SeedData //Khai báo class static 
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            SopirationContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<SopirationContext>(); //Add thêm service cho Db
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Name = "Sách Dạy Tiếng Anh Cho Bé",
                        Description = "Giúp bé phát triển khả năng tự học tiếng anh",
                        Category = "Sách Tiếng Anh",
                        Price = 100
                    },
                    new Book
                    {
                        Name = "Ngôi Nhà Nhỏ Trên Thảo Nguyên",
                        Description = "Miêu tả những vẻ đẹp của cuộc sống quanh ta",
                        Category = "Tiểu Thuyết",
                        Price = 2.55m
                    },
                    new Book
                    {
                        Name = "Sách Toàn Học Lớp 10",
                        Description = "Kiến thức phổ thông",
                        Category = "Sách Giáo Khoa",
                        Price = 20
                    },
                    new Book
                    {
                        Name = "Sách Văn Học Lớp 12",
                        Description = "Kiến thức phổ thông",
                        Category = "Sách Giap Khoa",
                        Price = 19
                    },
                    new Book
                    {
                        Name = "Đàn Ông Không Nói",
                        Description = "Những điều chỉ những con người từng trải mới thấu hiểu",
                        Category = "Tiểu Thuyết",
                        Price = 16
                    },
                    new Book
                    {
                        Name = "1600 Từ Vựng Thông Dụng",
                        Description = "Những từ vựng tiếng anh được sử dụng thông dụng trong giao tiếp",
                        Category = "Sách Tiếng Anh",
                        Price = 32
                    },
                    new Book
                    {
                        Name = "Hack Não 1500 Từ",
                        Description = "Giúp bạn học nhanh nhớ lâu từ vựng",
                        Category = "Sách Tiếng Anh",
                        Price = 62
                    },
                    new Book
                    {
                        Name = "Đàn Ông Đến Tù Sao Hỏa Đến Bà Đến Từ Sao Kim",
                        Description = "Thấu hiểu những điều về nữa kia của thế giới",
                        Category = "Tiểu Thuyết",
                        Price = 2.3m
                    }
                    );
            }
        }
    }
}
