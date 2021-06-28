namespace Bigschool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCategorySoure : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Soures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LiecturerId = c.String(nullable: false),
                        Place = c.String(nullable: false, maxLength: 255),
                        DateTime = c.DateTime(nullable: false),
                        catacoryId = c.Byte(nullable: false),
                        catagory_Id = c.Byte(),
                        Lecturer_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.catagory_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Lecturer_Id)
                .Index(t => t.catagory_Id)
                .Index(t => t.Lecturer_Id);
          

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Soures", "Lecturer_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Soures", "catagory_Id", "dbo.Categories");
            DropIndex("dbo.Soures", new[] { "Lecturer_Id" });
            DropIndex("dbo.Soures", new[] { "catagory_Id" });
            DropTable("dbo.Soures");
            DropTable("dbo.Categories");
        }
    }
}
