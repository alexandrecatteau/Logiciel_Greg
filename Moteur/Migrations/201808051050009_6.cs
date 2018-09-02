namespace Moteur.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.T_CNX", "NOMPROJET", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.T_CNX", "NOMPROJET");
        }
    }
}
