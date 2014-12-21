namespace SMS_WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addstudentgenderandremovebrothers : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Student_Id", "dbo.Students");
            DropIndex("dbo.Students", new[] { "Student_Id" });
            AddColumn("dbo.Students", "Gender", c => c.Int(nullable: false));
            DropColumn("dbo.Students", "Student_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Student_Id", c => c.Int());
            DropColumn("dbo.Students", "Gender");
            CreateIndex("dbo.Students", "Student_Id");
            AddForeignKey("dbo.Students", "Student_Id", "dbo.Students", "Id");
        }
    }
}
