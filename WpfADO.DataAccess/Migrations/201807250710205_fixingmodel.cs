namespace WpfADO.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixingmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kelurahans", "Name", c => c.String());
            AddColumn("dbo.Kelurahans", "Kecamatan_Id", c => c.Int());
            AddColumn("dbo.Kecamatans", "Name", c => c.String());
            CreateIndex("dbo.Kelurahans", "Kecamatan_Id");
            AddForeignKey("dbo.Kelurahans", "Kecamatan_Id", "dbo.Kecamatans", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kelurahans", "Kecamatan_Id", "dbo.Kecamatans");
            DropIndex("dbo.Kelurahans", new[] { "Kecamatan_Id" });
            DropColumn("dbo.Kecamatans", "Name");
            DropColumn("dbo.Kelurahans", "Kecamatan_Id");
            DropColumn("dbo.Kelurahans", "Name");
        }
    }
}
