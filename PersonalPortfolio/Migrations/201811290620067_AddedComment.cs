namespace PersonalPortfolio.Migrations {
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedComment : DbMigration {
        public override void Up() {
            CreateTable(
                "dbo.VisitorComments",
                c => new {
                        CommentID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        Comment = c.String(nullable: false, maxLength: 280),
                    })
                .PrimaryKey(t => t.CommentID); 
        }
        
        public override void Down() {
            DropTable("dbo.VisitorComments");
        }
    }
}
