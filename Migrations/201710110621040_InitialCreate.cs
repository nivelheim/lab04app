namespace Week04Lab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Cities", name: "Province_ProvinceId", newName: "ProvinceId");
            RenameIndex(table: "dbo.Cities", name: "IX_Province_ProvinceId", newName: "IX_ProvinceId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Cities", name: "IX_ProvinceId", newName: "IX_Province_ProvinceId");
            RenameColumn(table: "dbo.Cities", name: "ProvinceId", newName: "Province_ProvinceId");
        }
    }
}
