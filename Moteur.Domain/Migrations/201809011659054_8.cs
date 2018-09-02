namespace Moteur.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _8 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.T_CNX", "NOMPROJET", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.T_CNX", "NOMPROJET", c => c.String());
        }
    }
}
