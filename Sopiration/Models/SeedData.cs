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
                        Image = "https://cdnstepup.r.worldssl.net/wp-content/uploads/2019/12/S%C3%A1ch-h%E1%BB%8Dc-ti%E1%BA%BFng-Anh-cho-tr%E1%BA%BB-em-768x999.jpg",
                        Description = "Giúp bé phát triển khả năng tự học tiếng anh",
                        Category = "Sách Tiếng Anh",
                        Price = 100
                    },
                    new Book
                    {
                        Name = "Ngôi Nhà Nhỏ Trên Thảo Nguyên",
                        Image = "https://gacsach.com/sites/gacsach.com/files/ngoi-nha-nho-tren-thao-nguyen.jpg",
                        Description = "Miêu tả những vẻ đẹp của cuộc sống quanh ta",
                        Category = "Tiểu Thuyết",
                        Price = 2.55m
                    },
                    new Book
                    {
                        Name = "Sách Toán Học Lớp 10",
                        Image = "https://metaisach.com/wp-content/uploads/2019/01/sach-giao-khoa-dai-so-lop-10.jpg",
                        Description = "Kiến thức phổ thông",
                        Category = "Sách Giáo Khoa",
                        Price = 20
                    },
                    new Book
                    {
                        Name = "Sách Văn Học Lớp 12",
                        Image = "https://sobee.vn/wp-content/uploads/2017/08/Ngu-van-12-Tap-2-727193-2-400x564.jpg",
                        Description = "Kiến thức phổ thông",
                        Category = "Sách Giap Khoa",
                        Price = 19
                    },
                    new Book
                    {
                        Name = "Đàn Ông Không Nói",
                        Image = "https://sachhaynendoc.net/wp-content/uploads/2020/01/bia-1-danong.u547.d20160914.t091130.33136.jpg",
                        Description = "Những điều chỉ những con người từng trải mới thấu hiểu",
                        Category = "Tiểu Thuyết",
                        Price = 16
                    },
                    new Book
                    {
                        Name = "1500 Từ Vựng Thông Dụng",
                        Image = "https://cf.shopee.vn/file/02fc0a752d401356adc8a5ad1e0e97e3",
                        Description = "Những từ vựng tiếng anh được sử dụng thông dụng trong giao tiếp",
                        Category = "Sách Tiếng Anh",
                        Price = 32
                    },
                    new Book
                    {
                        Name = "Hack Não 1500 Từ",
                        Image = "https://www.better.vn/wp-content/uploads/2019/08/Hack-N%C3%A3o-1500.jpg",
                        Description = "Giúp bạn học nhanh nhớ lâu từ vựng",
                        Category = "Sách Tiếng Anh",
                        Price = 62
                    },
                    new Book
                    {
                        Name = "Đàn Ông Đến Tù Sao Hỏa Đến Bà Đến Từ Sao Kim",
                        Image = "https://salt.tikicdn.com/cache/w1200/ts/product/0a/f6/38/bc10734989977da424642a1c4750eee2.jpg",
                        Description = "Thấu hiểu những điều về nữa kia của thế giới",
                        Category = "Tiểu Thuyết",
                        Price = 2.3m
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
