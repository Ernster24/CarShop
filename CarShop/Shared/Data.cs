using System.Collections.Generic;
using System.Diagnostics;

namespace CarShop.Shared
{
    public class Product    // Class contains attributes for the vehicles
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? Year { get; set; }
        public string? Mileage { get; set; }
        public string? Reg { get; set; }
        public string? Transmission { get; set; }
        public string? Seats { get; set; }
        public string? FuelType { get; set; }
        public string? Engine { get; set; }
        public string? Cylinders { get; set; }
        public string? Power { get; set; }
        public string? FuelCapacity { get; set; }
        public string? TopSpeed { get; set; }
        public string? Acceleration { get; set; }
        public string? DriveType { get; set; }
        public string? GearBox { get; set; }
        public string? Length { get; set; }
        public string? Width { get; set; }
        public string? Height { get; set; }
        public string? WeightUnladed { get; set; }
        public string? WeightGross { get; set; }
        public string? FuelEconCity { get; set; }
        public string? FuelEconHighway { get; set; }
        public string? FuelEconComb { get; set; }
        public string? CarbonEmissions { get; set; }
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
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

    }

    public class ProductSale // Class contains attributes for each vehicle sale
    {
        public int Id { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? Reg { get; set; }
        public DateOnly Date { get; set; }
        public decimal Price { get; set; }
        public string? BuyerName { get; set; }
        public string? BuyerPhone { get; set; }
        public string? BuyerEmail { get; set;}

    }

    public static class CarSales
    {
        private static List<ProductSale> sales = new List<ProductSale>()
        {
            new ProductSale
            {
                Id = 1,
                Make = "Alfa Romeo",
                Model = "159",
                Reg = "KV57 BLT",
                Date = new DateOnly(2022, 09, 05),
                Price = 4000m,
                BuyerName = "John Smith",
                BuyerPhone = "07123456789",
                BuyerEmail = "johnsmith@email.com"
            },
            new ProductSale
            {
                Id = 2,
                Make = "Ford",
                Model = "Fiesta",
                Reg = "XF21 MNG",
                Date = new DateOnly(2023, 01, 02),
                Price = 14000m,
                BuyerName = "Bob Adams",
                BuyerPhone = "07639584390",
                BuyerEmail = "bobadams@email.com"
            },
            new ProductSale
            {
                Id = 3,
                Make = "Volkswagen",
                Model = "Fox",
                Reg = "KV56 OKF",
                Date = new DateOnly(2019, 05, 21),
                Price = 1600m,
                BuyerName = "Barry B",
                BuyerPhone = "07927475834",
                BuyerEmail = "barryb@email.com"
            },
            new ProductSale
            {
                Id = 4,
                Make = "Vauxhall",
                Model = "Corsa",
                Reg = "KE15 LVT",
                Date = new DateOnly(2019, 08, 20),
                Price = 7000m,
                BuyerName = "Jim Bob",
                BuyerPhone = "07195723563",
                BuyerEmail = "jimbob@email.com"
            },
            new ProductSale
            {
                Id = 5,
                Make = "BMW",
                Model = "1 Series",
                Reg = "FH13 ALE",
                Date = new DateOnly(2022, 11, 23),
                Price = 7500m,
                BuyerName = "Mary Jones",
                BuyerPhone = "07497651437",
                BuyerEmail = "maryjones@email.com"
            },
            new ProductSale
            {
                Id = 6,
                Make = "Fiat",
                Model = "500",
                Reg = "HG14 LMS",
                Date = new DateOnly(2019, 03, 28),
                Price = 4550m,
                BuyerName = "Sally Adams",
                BuyerPhone = "07886436696",
                BuyerEmail = "sallyadams@email.com"
            }
        };

        public static List<ProductSale> GetProductSales()
        {
            return sales;
        }
    }

        public static class CarList // Contains each vehicle object 
    {
        private static List<Product> vehicles = new List<Product>()
        {
            new Product 
            {
                Id = 1,
                Make = "Volkswagen",
                Model = "Golf",
                Year = "2009",
                Mileage = "85241",
                Reg = "OY59 HJJ",
                Transmission = "Manual",
                Seats = "5",
                FuelType = "Petrol",
                Engine = "2.0L",
                Title = "Volkswagen Golf GTI",
                Cylinders = "4",
                Power = "208bhp",
                FuelCapacity = "14.5 Gallons",
                TopSpeed = "149mph",
                Acceleration = "6.9s",
                DriveType = "Front Wheel Drive",
                GearBox = "6 Speed Manual",
                Length = "4214mm",
                Width = "1786mm",
                Height = "1468mm",
                WeightUnladed = "1393kg",
                WeightGross = "1870kg",
                FuelEconCity = "23.5mpg",
                FuelEconHighway = "40.6mpg",
                FuelEconComb = "32.2mpg",
                CarbonEmissions = "170g/km",
                Description = "Volkswagen Golf GTI 3dr 2.0L 2009",
                Image = "/Images/vw_golf_gti09.jpg",
                Price = 8000m
            },
            new Product
            { 
                Id = 2,
                Make = "Mazda",
                Model = "MX-5",
                Year = "2020",
                Mileage = "55342",
                Reg = "VX20 JXU",
                Transmission = "Manual",
                Seats = "2",
                FuelType = "Petrol",
                Engine = "2.0L",
                Title = "Mazda MX-5 RF",
                Cylinders = "4",
                Power = "158bhp",
                FuelCapacity = "11.9 Gallons",
                TopSpeed = "134mph",
                Acceleration = "7.4s",
                DriveType = "Rear Wheel Drive",
                GearBox = "6 Speed Manual",
                Length = "3914mm",
                Width = "1735mm",
                Height = "1224mm",
                WeightUnladed = "1130kg",
                WeightGross = "1305kg",
                FuelEconCity = "27.0mpg",
                FuelEconHighway = "43.6mpg",
                FuelEconComb = "35.6mpg",
                CarbonEmissions = "154g/km",
                Description = "Mazda MX-5 RF 3dr 2.0L 2020",
                Image = "/Images/mazda-mx5-rf-front.jpg",
                Price = 12000m
            },
            new Product 
            {
                Id = 3,
                Make = "MINI",
                Model = "Cooper S",
                Year = "2008",
                Mileage = "69432",
                Reg = "YG08 NOF",
                Transmission = "Manual",
                Seats = "4",
                FuelType = "Petrol",
                Engine = "1.6L",
                Title = "MINI Cooper S",
                Cylinders = "4",
                Power = "172bhp",
                FuelCapacity = "10.6 Gallons",
                TopSpeed = "139.8mph",
                Acceleration = "7.1s",
                DriveType = "Front Wheel Drive",
                GearBox = "6 Speed Manual",
                Length = "3711mm",
                Width = "1679mm",
                Height = "1410mm",
                WeightUnladed = "1105kg",
                WeightGross = "1510kg",
                FuelEconCity = "26.4mpg",
                FuelEconHighway = "41.3mpg",
                FuelEconComb = "34.1mpg",
                CarbonEmissions = "164g/km",
                Description = "MINI Cooper S 1.6L 2008",
                Image = "/Images/mini_cooper_s.jpg",
                Price = 6000m
            },
            new Product
            {
                Id = 4,
                Make = "Vauxhall",
                Model = "Corsa",
                Year = "2015",
                Mileage = "62975",
                Reg = "VX65 PYJ",
                Transmission = "Manual",
                Seats = "5",
                FuelType = "Petrol",
                Engine = "1.4L",
                Title = "Vauxhall Corsa",
                Cylinders = "4",
                Power = "148bhp",
                FuelCapacity = "11.9 Gallons",
                TopSpeed = "129mph",
                Acceleration = "8.9s",
                DriveType = "Front Wheel Drive",
                GearBox = "6 Speed Manual",
                Length = "4021mm",
                Width = "1735mm",
                Height = "1478mm",
                WeightUnladed = "1163kg",
                WeightGross = "1690kg",
                FuelEconCity = "31.8mpg",
                FuelEconHighway = "49.0mpg",
                FuelEconComb = "41.3mpg",
                CarbonEmissions = "132g/km",
                Description = "Vauxhall Corsa 1.4L 2015",
                Image = "/Images/vauxhall_corsa.jpg",
                Price = 5500m
            },
            new Product
            {
                Id = 5,
                Make = "Volvo",
                Model = "XC60",
                Year = "2018",
                Mileage = "34500",
                Reg = "KJ17 EHR",
                Transmission = "Automatic",
                Seats = "5",
                FuelType = "Diesel",
                Engine = "1.9",
                Title = "Volvo XC60 D4",
                Cylinders = "4",
                Power = "187bhp",
                FuelCapacity = "13.2 Gallons",
                TopSpeed = "127mph",
                Acceleration = "8.4s",
                DriveType = "Front Wheel Drive",
                GearBox = "8 Speed Automatic",
                Length = "4688mm",
                Width = "1902mm",
                Height = "1658mm",
                WeightUnladed = "2020kg",
                WeightGross = "2450kg",
                FuelEconCity = "49mpg",
                FuelEconHighway = "61mpg",
                FuelEconComb = "55mpg",
                CarbonEmissions = "133g/km",
                Description = "Volvo XC60 D4 1.9L 2018",
                Image = "/Images/volvo-xc60-hub.jpg",
                Price = 22000m
            }
        };

        public static List<Product> GetProducts()   // Returns vehicle object as 'vehicles'
        {
            return vehicles;
        }

        public static Product GetProduct(int id)    // Gets the vehicle id
        {
#pragma warning disable CS8603 // Possible null reference return.
            return vehicles.SingleOrDefault(p => p.Id == id);
#pragma warning restore CS8603 // Possible null reference return.
        }
    }
}


