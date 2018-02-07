namespace AwsWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.customer",
                c => new
                    {
                        id_customer = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 100),
                        nit = c.String(maxLength: 50),
                        address = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.id_customer);
            
        }
        
        public override void Down()
        {
            DropTable("public.customer");
        }
    }
}
