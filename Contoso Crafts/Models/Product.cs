﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Contoso_Crafts.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Maker { get; set; }

        [JsonPropertyName("img")]//Thuộc tính đánh dấu quy định, nó sẽ chuyển thuộc tính 'img' sang Img
        public string Img { get; set; }

        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int[] Ratings { get ; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);//Chuyển dạng json sang chuỗi 
    }
}
