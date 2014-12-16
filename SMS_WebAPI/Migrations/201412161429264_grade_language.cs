namespace SMS_WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class grade_language : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Grades", "Language", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Grades", "Language");
        }
    }
}
