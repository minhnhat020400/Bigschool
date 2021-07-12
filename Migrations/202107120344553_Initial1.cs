namespace Bigschool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Soures", "Lecturer_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Soures", new[] { "Lecturer_Id" });
            RenameColumn(table: "dbo.Soures", name: "Lecturer_Id", newName: "LecturerId");
            AlterColumn("dbo.Soures", "LecturerId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Soures", "LecturerId");
            AddForeignKey("dbo.Soures", "LecturerId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            DropColumn("dbo.Soures", "LiecturerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Soures", "LiecturerId", c => c.String(nullable: false));
            DropForeignKey("dbo.Soures", "LecturerId", "dbo.AspNetUsers");
            DropIndex("dbo.Soures", new[] { "LecturerId" });
            AlterColumn("dbo.Soures", "LecturerId", c => c.String(maxLength: 128));
            RenameColumn(table: "dbo.Soures", name: "LecturerId", newName: "Lecturer_Id");
            CreateIndex("dbo.Soures", "Lecturer_Id");
            AddForeignKey("dbo.Soures", "Lecturer_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
