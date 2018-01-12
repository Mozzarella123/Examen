namespace ExamenProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        FilmId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        RealizeTime = c.DateTime(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FilmId);
            
            CreateTable(
                "dbo.Seans",
                c => new
                    {
                        SeansId = c.Int(nullable: false, identity: true),
                        Time = c.DateTime(nullable: false),
                        Price = c.Double(nullable: false),
                        Film_FilmId = c.Int(),
                        Hall_HallId = c.Int(),
                    })
                .PrimaryKey(t => t.SeansId)
                .ForeignKey("dbo.Films", t => t.Film_FilmId)
                .ForeignKey("dbo.Halls", t => t.Hall_HallId)
                .Index(t => t.Film_FilmId)
                .Index(t => t.Hall_HallId);
            
            CreateTable(
                "dbo.Halls",
                c => new
                    {
                        HallId = c.Int(nullable: false, identity: true),
                        PlaceCount = c.Int(nullable: false),
                        RowCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HallId);
            
            CreateTable(
                "dbo.Places",
                c => new
                    {
                        PlaceId = c.Int(nullable: false, identity: true),
                        Seat = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Hall_HallId = c.Int(),
                    })
                .PrimaryKey(t => t.PlaceId)
                .ForeignKey("dbo.Halls", t => t.Hall_HallId)
                .Index(t => t.Hall_HallId);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TicketId = c.Int(nullable: false, identity: true),
                        Summ = c.Double(nullable: false),
                        Place_PlaceId = c.Int(),
                        Seans_SeansId = c.Int(),
                    })
                .PrimaryKey(t => t.TicketId)
                .ForeignKey("dbo.Places", t => t.Place_PlaceId)
                .ForeignKey("dbo.Seans", t => t.Seans_SeansId)
                .Index(t => t.Place_PlaceId)
                .Index(t => t.Seans_SeansId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Seans", "Hall_HallId", "dbo.Halls");
            DropForeignKey("dbo.Tickets", "Seans_SeansId", "dbo.Seans");
            DropForeignKey("dbo.Tickets", "Place_PlaceId", "dbo.Places");
            DropForeignKey("dbo.Places", "Hall_HallId", "dbo.Halls");
            DropForeignKey("dbo.Seans", "Film_FilmId", "dbo.Films");
            DropIndex("dbo.Tickets", new[] { "Seans_SeansId" });
            DropIndex("dbo.Tickets", new[] { "Place_PlaceId" });
            DropIndex("dbo.Places", new[] { "Hall_HallId" });
            DropIndex("dbo.Seans", new[] { "Hall_HallId" });
            DropIndex("dbo.Seans", new[] { "Film_FilmId" });
            DropTable("dbo.Tickets");
            DropTable("dbo.Places");
            DropTable("dbo.Halls");
            DropTable("dbo.Seans");
            DropTable("dbo.Films");
        }
    }
}
