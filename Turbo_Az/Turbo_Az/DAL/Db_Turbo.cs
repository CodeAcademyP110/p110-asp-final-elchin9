using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turbo_Az.Models;

namespace Turbo_Az.DAL
{
    public class Db_Turbo : IdentityDbContext<AppUser>
    {
        public Db_Turbo(DbContextOptions<Db_Turbo> options) : base(options)
        {
        }

        public DbSet<News> News { get; set; }
        public DbSet<AdPhotos> AdPhotos { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<GradiuationYear> GradiuationYears { get; set; }
        public DbSet<MachinePower> MachinePowers { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Speed> Speeds { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //seeding Brand table
            builder.Entity(typeof(Brand)).HasData(
                new Brand { Id = 1, Name = "Mercedes" },
                new Brand { Id = 2, Name = "BMW" },
                new Brand { Id = 3, Name = "Honda" },
                new Brand { Id = 4, Name = "Ford" }
            );

            //seeding Model table
            builder.Entity(typeof(Model)).HasData(
                new Model { Id = 1, Name = "X5", BrandId = 2 },
                new Model { Id = 2, Name = "X3", BrandId = 2 },
                new Model { Id = 3, Name = "C200", BrandId = 1 },
                new Model { Id = 4, Name = "C230", BrandId = 1 }
            );

            //seeding City table
            builder.Entity(typeof(City)).HasData(
                new City { Id = 1, Name = "Bakı" },
                new City { Id = 2, Name = "Gence" },
                new City { Id = 3, Name = "Sumqayit" },
                new City { Id = 4, Name = "Lenkeran" }
            );
            //seeding Color table
            builder.Entity(typeof(Color)).HasData(
                new Color { Id = 1, CarColor = "Qara" },
                new Color { Id = 2, CarColor = "Sari" },
                new Color { Id = 3, CarColor = "Qirmizi" },
                new Color { Id = 4, CarColor = "Mavi" }
            );

            //seeding Fuel table
            builder.Entity(typeof(Fuel)).HasData(
                new Fuel { Id = 1, CarFuel = "Benzin" },
                new Fuel { Id = 2, CarFuel = "Qaz" },
                new Fuel { Id = 3, CarFuel = "Elektro" },
                new Fuel { Id = 4, CarFuel = "Hibrid" },
                new Fuel { Id = 5, CarFuel = "Dizel" }
            );

            //seeding GradiuationYear table
            builder.Entity(typeof(GradiuationYear)).HasData(
                new GradiuationYear { Id = 1, Year = 1910 },
                new GradiuationYear { Id = 2, Year = 1911 },
                new GradiuationYear { Id = 3, Year = 1912 },
                new GradiuationYear { Id = 4, Year = 1913 }
            );

            //seeding Speed table
            builder.Entity(typeof(Speed)).HasData(
                new Speed { Id = 1, CarSpeed = "Mexaniki" },
                new Speed { Id = 2, CarSpeed = "Avtomat" }
            );

            //seeding MachinePower table
            builder.Entity(typeof(MachinePower)).HasData(
                new MachinePower { Id = 1, Power = 200 },
                new MachinePower { Id = 2, Power = 300 },
                new MachinePower { Id = 3, Power = 400 },
                new MachinePower { Id = 4, Power = 500 }
            );

            //seeding Advertisement table
            builder.Entity(typeof(Advertisement)).HasData(
                new Advertisement
                {
                    Id = 1,
                    ModelId = 1,
                    MachinePowerId = 4,
                    Price = 25000,
                    SpeedId = 2,
                    GradiuationYearId = 1,
                    CityId = 1,
                    FuelId = 1,
                    ColorId = 1,
                    Hiking = 12000,
                    CarInfo = "Biraz orasin-burasin vurmusam",
                    AdYear = DateTime.Now,
                    PhotoURL = "bmv.jpg"
                },

                new Advertisement
                {
                    Id = 2,
                    ModelId = 3,
                    MachinePowerId = 4,
                    Price = 50000,
                    SpeedId = 1,
                    GradiuationYearId = 1,
                    CityId = 2,
                    FuelId = 1,
                    ColorId = 3,
                    Hiking = 8000,
                    CarInfo = "Biraz orasin-burasin vurmusam",
                    AdYear = DateTime.Now,
                    IsVip = true,
                    PhotoURL = "car2.jpg"
                },
                new Advertisement
                {
                    Id = 3,
                    ModelId = 2,
                    MachinePowerId = 4,
                    Price = 17000,
                    SpeedId = 2,
                    GradiuationYearId = 2,
                    CityId = 3,
                    FuelId = 2,
                    ColorId = 2,
                    Hiking = 76000,
                    CarInfo = "Biraz orasin-burasin vurmusam",
                    AdYear = DateTime.Now,
                    PhotoURL = "car1.jpg"
                },
                 new Advertisement
                 {
                     Id = 5,
                     ModelId = 3,
                     MachinePowerId = 4,
                     Price = 25000,
                     SpeedId = 2,
                     GradiuationYearId = 1,
                     CityId = 1,
                     FuelId = 1,
                     ColorId = 1,
                     Hiking = 12000,
                     CarInfo = "Biraz orasin-burasin vurmusam",
                     AdYear = DateTime.Now,
                     PhotoURL = "car2.jpg",
                     IsVip = true
                 }
            );

            //seeding AdPhotos table
            builder.Entity(typeof(AdPhotos)).HasData(
                new AdPhotos
                {
                    Id = 1,
                    AdvertisementId = 1,
                    PhotoURL = "bmv.jpg"
                });
            //seeding News table
            builder.Entity(typeof(News)).HasData(
                new News
                {
                    Id = 1,
                    PhotoURL = "car1.jpg",
                    Title = "Yeni Sport Car",
                    Time = DateTime.Now,
                    ShortInfo = "Yeni sport masin cemiyyete teqdim edildi.",
                    MainInfo = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum"
                },
            new News
            {
                Id = 2,
                PhotoURL = "car2.jpg",
                Title = "Aston Martin",
                Time = DateTime.Now,
                ShortInfo = "Aston Martin sirketinin yeni istehsali.",
                MainInfo = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum"
            },
            new News
            {
                Id = 3,
                PhotoURL = "car3.jpg",
                Title = "Mini",
                Time = DateTime.Now,
                ShortInfo = "AHJDKFF",
                MainInfo = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum"
            }
            );
        }
    }
}
