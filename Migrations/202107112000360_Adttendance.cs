namespace Bigschool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adttendance : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        AttendeeId = c.String(nullable: false, maxLength: 128),
                        sourse_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CourseId, t.AttendeeId })
                .ForeignKey("dbo.AspNetUsers", t => t.AttendeeId, cascadeDelete: true)
                .ForeignKey("dbo.Soures", t => t.sourse_Id)
                .Index(t => t.AttendeeId)
                .Index(t => t.sourse_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "sourse_Id", "dbo.Soures");
            DropForeignKey("dbo.Attendances", "AttendeeId", "dbo.AspNetUsers");
            DropIndex("dbo.Attendances", new[] { "sourse_Id" });
            DropIndex("dbo.Attendances", new[] { "AttendeeId" });
            DropTable("dbo.Attendances");
        }
    }
}
