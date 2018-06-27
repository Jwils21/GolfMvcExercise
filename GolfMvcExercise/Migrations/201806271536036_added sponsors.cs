namespace GolfMvcExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedsponsors : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sponsors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Amount = c.Double(nullable: false),
                        PlayerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.PlayerId, cascadeDelete: true)
                .Index(t => t.PlayerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sponsors", "PlayerId", "dbo.Players");
            DropIndex("dbo.Sponsors", new[] { "PlayerId" });
            DropTable("dbo.Sponsors");
        }
    }
}
