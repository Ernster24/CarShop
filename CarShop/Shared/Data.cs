using CarShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; } = "https://via.placeholder.com/300x300";
        public decimal Price { get; set; }
        public bool IsPublic { get; set; }
        public bool IsDeleted { get; set; }
        public string Make { get; set; }
        public int MakeId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }


    }

    public static class CarList
    {
        private static List<Product> vehicles = new List<Product>(){
            new Product {
                Id = 1,
                MakeId = 1,
                Title = "Volkswagen Golf",
                Description = "Volkswagen Golf GTI 3dr 2.0L 2009",
                Image = "https://parkers-images.bauersecure.com/Scale/wp-images/2338/cut-out/600x400/vw_golf_gti09.jpg",
                Price = 8000m
            },
            new Product {
                Id = 2,
                MakeId = 2,
                Title = "Mazda MX-5",
                Description = "Mazda MX-5 RF 2dr 2.0L 2020",
                Image = "https://parkers-images.bauersecure.com/Scale/wp-images/21887/cut-out/600x400/mazda-mx5-rf-front.jpg",
                Price = 12000m
            }
        };

        public static List<Product> GetProducts()
        {
            return vehicles;
        }
    }
}


