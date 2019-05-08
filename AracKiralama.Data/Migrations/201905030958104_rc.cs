namespace AracKiralama.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsAvailable = c.Boolean(nullable: false),
                        CarName = c.String(nullable: false),
                        CarModel = c.String(nullable: false),
                        DriverLicenseAge = c.Int(nullable: false),
                        MinAge = c.Int(nullable: false),
                        DailyKmLimit = c.Int(nullable: false),
                        CurrentKm = c.Int(nullable: false),
                        Airbag = c.Boolean(nullable: false),
                        BaggageCapacity = c.Int(nullable: false),
                        SeatCount = c.Int(nullable: false),
                        DailyPrice = c.Int(nullable: false),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false),
                        City = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        CarCount = c.Int(nullable: false),
                        CompanyPoint = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RentedCars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OldKm = c.Int(nullable: false),
                        NewKm = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RentDate = c.DateTime(nullable: false),
                        DeliveryDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        carId = c.Int(nullable: false),
                        CustomerName = c.String(nullable: false),
                        CustomerSurname = c.String(nullable: false),
                        CustomerTC = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RentDate = c.DateTime(nullable: false),
                        DeliveryDate = c.DateTime(nullable: false),
                        CustomerName = c.String(nullable: false),
                        CustomerSurname = c.String(nullable: false),
                        CustomerTC = c.Int(nullable: false),
                        CarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        FullName = c.String(nullable: false),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Requests");
            DropTable("dbo.RentedCars");
            DropTable("dbo.Companies");
            DropTable("dbo.Cars");
        }
    }
}
