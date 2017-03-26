namespace TransportApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyFavouriteStopRouteDirection : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FavouriteStopRouteDirections", "StopName", c => c.String(nullable: false));
            AlterColumn("dbo.FavouriteStopRouteDirections", "RouteName", c => c.String(nullable: false));
            AlterColumn("dbo.FavouriteStopRouteDirections", "DirectionName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FavouriteStopRouteDirections", "DirectionName", c => c.String());
            AlterColumn("dbo.FavouriteStopRouteDirections", "RouteName", c => c.String());
            AlterColumn("dbo.FavouriteStopRouteDirections", "StopName", c => c.String());
        }
    }
}
