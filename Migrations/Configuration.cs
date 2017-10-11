namespace Week04Lab.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Week04Lab.Models.Week04;

    internal sealed class Configuration : DbMigrationsConfiguration<Week04Lab.Models.Week04.LabContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations";
        }

        protected override void Seed(Week04Lab.Models.Week04.LabContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            List<Province> provs = new List<Province>();
            provs.Add(new Province { ProvinceId = "BC", ProvinceName = "British Columbia" });
            provs.Add(new Province { ProvinceId = "AB", ProvinceName = "Alberta" });
            provs.Add(new Province { ProvinceId = "QC", ProvinceName = "Quebec" });

            List<City> cities = new List<City>();
            cities.Add(new City { CityId = 11, CityName = "Burnaby", Population = 100, ProvinceId = context.Provinces.FirstOrDefault(t => t.ProvinceName == "British Columbia").ProvinceId });
            cities.Add(new City { CityId = 12, CityName = "Vancouver", Population = 200, ProvinceId = context.Provinces.FirstOrDefault(t => t.ProvinceName == "Alberta").ProvinceId });
            cities.Add(new City { CityId = 13, CityName = "Surrey", Population = 300, ProvinceId = context.Provinces.FirstOrDefault(t => t.ProvinceName == "Quebec").ProvinceId });

            context.Cities.AddOrUpdate(t => t.CityName, cities.ToArray());
            context.Provinces.AddOrUpdate(u => u.ProvinceId, provs.ToArray());

            context.SaveChanges();
        }
    }
}
