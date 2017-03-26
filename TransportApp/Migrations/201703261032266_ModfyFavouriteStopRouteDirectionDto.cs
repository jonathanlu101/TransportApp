namespace TransportApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModfyFavouriteStopRouteDirectionDto : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FavouriteStopRouteDirections", "RouteType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FavouriteStopRouteDirections", "RouteType", c => c.String(nullable: false));
        }
    }
}
