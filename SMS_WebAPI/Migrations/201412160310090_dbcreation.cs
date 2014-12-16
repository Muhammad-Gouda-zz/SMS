namespace SMS_WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbcreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        JoinDate = c.DateTime(nullable: false),
                        PhotoUrl = c.String(),
                        Address = c.String(),
                        Grade_Id = c.Int(),
                        Student_Id = c.Int(),
                        Area_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Grades", t => t.Grade_Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .ForeignKey("dbo.Areas", t => t.Area_Id)
                .Index(t => t.Grade_Id)
                .Index(t => t.Student_Id)
                .Index(t => t.Area_Id);
            
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Parents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        RelationType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhoneNumber = c.String(),
                        Parent_Id = c.Int(),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Parents", t => t.Parent_Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.Parent_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ParentStudents",
                c => new
                    {
                        Parent_Id = c.Int(nullable: false),
                        Student_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Parent_Id, t.Student_Id })
                .ForeignKey("dbo.Parents", t => t.Parent_Id, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .Index(t => t.Parent_Id)
                .Index(t => t.Student_Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.ParentStudents", new[] { "Student_Id" });
            DropIndex("dbo.ParentStudents", new[] { "Parent_Id" });
            DropIndex("dbo.Phones", new[] { "Student_Id" });
            DropIndex("dbo.Phones", new[] { "Parent_Id" });
            DropIndex("dbo.Students", new[] { "Area_Id" });
            DropIndex("dbo.Students", new[] { "Student_Id" });
            DropIndex("dbo.Students", new[] { "Grade_Id" });
            DropForeignKey("dbo.ParentStudents", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.ParentStudents", "Parent_Id", "dbo.Parents");
            DropForeignKey("dbo.Phones", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Phones", "Parent_Id", "dbo.Parents");
            DropForeignKey("dbo.Students", "Area_Id", "dbo.Areas");
            DropForeignKey("dbo.Students", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Students", "Grade_Id", "dbo.Grades");
            DropTable("dbo.ParentStudents");
            DropTable("dbo.Areas");
            DropTable("dbo.Phones");
            DropTable("dbo.Parents");
            DropTable("dbo.Grades");
            DropTable("dbo.Students");
        }
    }
}
