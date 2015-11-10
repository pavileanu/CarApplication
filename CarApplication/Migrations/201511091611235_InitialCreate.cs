namespace CarApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Car",
                c => new
                    {
                        id = c.Int(nullable: false),
                        make_name = c.String(nullable: false, maxLength: 50),
                        model_name = c.String(nullable: false, maxLength: 50),
                        registration_date = c.DateTime(nullable: false, storeType: "date"),
                        body_color = c.String(maxLength: 50),
                        engine_capacity = c.Int(),
                        doors_number = c.Int(),
                        image_url = c.String(maxLength: 50)
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Car");
        }
    }
}
