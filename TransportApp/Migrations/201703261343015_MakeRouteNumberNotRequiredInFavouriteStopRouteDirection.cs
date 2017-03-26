namespace TransportApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeRouteNumberNotRequiredInFavouriteStopRouteDirection : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FavouriteStopRouteDirections", "RouteNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FavouriteStopRouteDirections", "RouteNumber", c => c.String(nullable: false));
        }
    }
}
