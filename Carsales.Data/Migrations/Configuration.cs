namespace Carsales.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Carsales.Data.DbConnections.CarSalesDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Carsales.Data.DbConnections.CarSalesDb context)
        {
            context.Cars.AddOrUpdate(c => c,
                new Car[]
                {
                    new Car()
                    {
                        Comments = "",
                        ContactName = "Andy",
                        DapPrice = 73000,
                        DealerAbn = "80 152 673 936",
                        EgcPrice = 0,
                        Email = "abc@123.com",
                        Id = 1,
                        Make = "Mercedes Benz",
                        Model = "C200 Coupe",
                        Phone = "0409 123 456",
                        Year = "2016",
                        PriceType = CarPriceType.DAP
                    },
                    new Car
                    {
                        Comments = "",
                        ContactName = "John",
                        DapPrice = 43000,
                        DealerAbn = "80 152 673 936",
                        EgcPrice = 0,
                        Email = "abc@123.com",
                        Id = 2,
                        Make = "Toyota",
                        Model = "86 Blackline",
                        Phone = "0409 123 456",
                        Year = "2015",
                        PriceType = CarPriceType.DAP
                    },
                    new Car
                    {
                        Comments = "",
                        ContactName = "Jane",
                        DapPrice = 45000,
                        DealerAbn = "80 152 673 936",
                        EgcPrice = 0,
                        Email = "abc@123.com",
                        Id = 3,
                        Make = "Subaru",
                        Model = "Liberty 3.6R",
                        Phone = "0409 123 456",
                        Year = "2016",
                        PriceType = CarPriceType.DAP
                    },
                    new Car
                    {
                        Comments = "",
                        ContactName = "Steve",
                        DapPrice = 52000,
                        DealerAbn = "80 152 673 936",
                        EgcPrice = 0,
                        Email = "abc@123.com",
                        Id = 3,
                        Make = "Ford",
                        Model = "Mustang EcoBoost",
                        Phone = "0409 123 456",
                        Year = "2016",
                        PriceType = CarPriceType.DAP
                    }
                }
                );

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
        }
    }
}
