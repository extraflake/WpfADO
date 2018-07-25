namespace WpfADO.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kelurahans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        PostalCode = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        Kecamatan_Id = c.Int(),
                        Kelurahan_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kecamatans", t => t.Kecamatan_Id)
                .ForeignKey("dbo.Kelurahans", t => t.Kelurahan_Id)
                .Index(t => t.Kecamatan_Id)
                .Index(t => t.Kelurahan_Id);
            
            CreateTable(
                "dbo.Kecamatans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Suppliers", "Kelurahan_Id", "dbo.Kelurahans");
            DropForeignKey("dbo.Suppliers", "Kecamatan_Id", "dbo.Kecamatans");
            DropIndex("dbo.Suppliers", new[] { "Kelurahan_Id" });
            DropIndex("dbo.Suppliers", new[] { "Kecamatan_Id" });
            DropTable("dbo.Kecamatans");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Kelurahans");
        }
    }
}
