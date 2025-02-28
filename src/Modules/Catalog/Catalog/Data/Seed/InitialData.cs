using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Data.Seed
{
    public static class InitialData
    {
        public static IEnumerable<Product> Products =>
            new List<Product>
            {
                Product.Create(new Guid("123e4567-e89b-12d3-a456-426614174000"), "iPhone 15", new List<string> { "Smartphones", "Apple" }, "The latest iPhone with advanced features.", "iphone15.jpg", 899),
                Product.Create(new Guid("223e4567-e89b-12d3-a456-426614174001"), "Samsung Galaxy S23", new List<string> { "Smartphones", "Samsung" }, "A powerful Android smartphone with a stunning display.", "galaxy_s23.jpg", 799),
                Product.Create(new Guid("323e4567-e89b-12d3-a456-426614174002"), "Google Pixel 7", new List<string> { "Smartphones", "Google" }, "A flagship phone with the best Android experience.", "pixel7.jpg", 699),
                Product.Create(new Guid("423e4567-e89b-12d3-a456-426614174003"), "OnePlus 11", new List<string> { "Smartphones", "OnePlus" }, "A high-performance phone with fast charging.", "oneplus11.jpg", 749),
                Product.Create(new Guid("523e4567-e89b-12d3-a456-426614174004"), "Xiaomi 13 Pro", new List<string> { "Smartphones", "Xiaomi" }, "A premium phone with cutting-edge camera technology.", "xiaomi13pro.jpg", 899)
            };
    }
}