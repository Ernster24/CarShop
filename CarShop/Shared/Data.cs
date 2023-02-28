using System.Collections.Generic;

namespace CarShop.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? Year { get; set; }
        public string? Mileage { get; set; }
        public string? Transmission { get; set; }
        public string? Seats { get; set; }
        public string? FuelType { get; set; }
        public string? Description { get; set; }
        public string Url
        {
            get
            {
                return "showroom/" + this.Id;
            }
        }
        public string Image { get; set; } = "https://via.placeholder.com/300x300";
        public decimal Price { get; set; }
        public bool IsPublic { get; set; }
        public bool IsDeleted { get; set; }
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
                Make = "Volkswagon",
                Model = "Golf",
                Year = "2009",
                Mileage = "85241",
                Transmission = "Manual",
                Seats = "5",
                FuelType = "Petrol",
                Title = "Volkswagen Golf",
                Description = "Volkswagen Golf GTI 3dr 2.0L 2009",
                Image = "/Images/vw_golf_gti09.jpg",
                Price = 8000m
            },
            new Product {
                Id = 2,
                MakeId = 2,
                Make = "Mazda",
                Model = "MX-5",
                Year = "2020",
                Mileage = "55342",
                Transmission = "Manual",
                Seats = "2",
                FuelType = "Petrol",
                Title = "Mazda MX-5",
                Description = "Mazda MX-5 RF 3dr 2.0L 2020",
                Image = "/Images/mazda-mx5-rf-front.jpg",
                Price = 12000m
            },
            new Product {
                Id = 3,
                MakeId = 3,
                Make = "MINI",
                Model = "Cooper S",
                Year = "2008",
                Mileage = "69432",
                Transmission = "Manual",
                Seats = "4",
                FuelType = "Petrol",
                Title = "MINI Cooper S",
                Description = "MINI Cooper S 1.6L 2008",
                Image = "/Images/mini_cooper_s.jpg",
                Price = 6000m
            }
        };

        public static List<Product> GetProducts()
        {
            return vehicles;
        }

        public static Product GetProduct(int id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return vehicles.SingleOrDefault(p => p.Id == id);
#pragma warning restore CS8603 // Possible null reference return.
        }

    }
}


