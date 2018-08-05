namespace Moteur.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.T_CNX",
                c => new
                    {
                        CLE = c.Int(nullable: false, identity: true),
                        DATE = c.DateTime(nullable: false),
                        NOMUTILISATEUR = c.String(),
                    })
                .PrimaryKey(t => t.CLE);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.T_CNX");
        }
    }
}
