namespace Bigschool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES(ID, NAME) VALUES (1,'development')");
            Sql("INSERT INTO CATEGORIES(ID, NAME) VALUES (2,'Bisness')");
            Sql("INSERT INTO CATEGORIES(ID, NAME) VALUES (3,'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
