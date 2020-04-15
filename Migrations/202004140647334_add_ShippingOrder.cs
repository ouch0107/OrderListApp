namespace interview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_ShippingOrder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShippingOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShippingOrders", "OrderId", "dbo.Orders");
            DropIndex("dbo.ShippingOrders", new[] { "OrderId" });
            DropTable("dbo.ShippingOrders");
        }
    }
}
