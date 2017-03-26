namespace TransportApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserToFavouriteStopRouteDirection : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.FavouriteStopRouteDirections");
            AlterColumn("dbo.FavouriteStopRouteDirections", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.FavouriteStopRouteDirections", "UserId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.FavouriteStopRouteDirections", "UserId");
            CreateIndex("dbo.FavouriteStopRouteDirections", "UserId");
            AddForeignKey("dbo.FavouriteStopRouteDirections", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FavouriteStopRouteDirections", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.FavouriteStopRouteDirections", new[] { "UserId" });
            DropPrimaryKey("dbo.FavouriteStopRouteDirections");
            AlterColumn("dbo.FavouriteStopRouteDirections", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.FavouriteStopRouteDirections", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.FavouriteStopRouteDirections", "Id");
        }
    }
}
