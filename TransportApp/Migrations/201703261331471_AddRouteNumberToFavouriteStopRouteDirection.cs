namespace TransportApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRouteNumberToFavouriteStopRouteDirection : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FavouriteStopRouteDirections", "RouteNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FavouriteStopRouteDirections", "RouteNumber");
        }
    }
}
