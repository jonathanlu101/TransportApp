namespace TransportApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyPrimaryKeyForFavouriteStopRouteDirection : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.FavouriteStopRouteDirections", new[] { "UserId" });
            DropPrimaryKey("dbo.FavouriteStopRouteDirections");
            AlterColumn("dbo.FavouriteStopRouteDirections", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.FavouriteStopRouteDirections", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.FavouriteStopRouteDirections", "Id");
            CreateIndex("dbo.FavouriteStopRouteDirections", "UserId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.FavouriteStopRouteDirections", new[] { "UserId" });
            DropPrimaryKey("dbo.FavouriteStopRouteDirections");
            AlterColumn("dbo.FavouriteStopRouteDirections", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.FavouriteStopRouteDirections", "UserId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.FavouriteStopRouteDirections", "UserId");
            CreateIndex("dbo.FavouriteStopRouteDirections", "UserId");
        }
    }
}
