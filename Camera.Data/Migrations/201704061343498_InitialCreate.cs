namespace Camera.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cameras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Make = c.Int(nullable: false),
                        Model = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        MinShatterSpeed = c.Int(nullable: false),
                        MaxShatterSpeed = c.Int(nullable: false),
                        MinISO = c.Int(nullable: false),
                        MaxISO = c.Int(nullable: false),
                        IsFullFrame = c.Boolean(nullable: false),
                        VideoResolution = c.String(),
                        LightMetering = c.Int(nullable: false),
                        Description = c.String(),
                        ImageURL = c.String(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cameras", "User_Id", "dbo.Users");
            DropIndex("dbo.Cameras", new[] { "User_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Cameras");
        }
    }
}
