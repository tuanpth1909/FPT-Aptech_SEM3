using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProductManager.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);

    }
}
