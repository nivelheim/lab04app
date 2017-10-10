namespace Week04Lab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        Population = c.Int(nullable: false),
                        Province_ProvinceId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.Provinces", t => t.Province_ProvinceId)
                .Index(t => t.Province_ProvinceId);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        ProvinceId = c.String(nullable: false, maxLength: 128),
                        ProvinceName = c.String(),
                    })
                .PrimaryKey(t => t.ProvinceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "Province_ProvinceId", "dbo.Provinces");
            DropIndex("dbo.Cities", new[] { "Province_ProvinceId" });
            DropTable("dbo.Provinces");
            DropTable("dbo.Cities");
        }
    }
}
