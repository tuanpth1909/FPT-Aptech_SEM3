using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestAzure.Models
{
    public class Product
    {
        public long ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(8,2)*")]//Vì kiểu dữ liệu trong C# và SQL khác nhau nên ta cần cấu hình lại cho tương ứng
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
