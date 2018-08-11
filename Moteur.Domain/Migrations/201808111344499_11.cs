namespace Moteur.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.T_UTL", "ETAT", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.T_UTL", "ETAT");
        }
    }
}
