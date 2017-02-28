namespace CommentForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GetThisToWork : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Procedures",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Priority = c.Int(nullable: false),
                        Title = c.String(),
                        Details = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Procedures");
        }
    }
}
