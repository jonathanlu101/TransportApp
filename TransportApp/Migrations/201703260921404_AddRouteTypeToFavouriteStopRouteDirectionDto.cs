namespace TransportApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRouteTypeToFavouriteStopRouteDirectionDto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FavouriteStopRouteDirections", "RouteType", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FavouriteStopRouteDirections", "RouteType");
        }
    }
}
