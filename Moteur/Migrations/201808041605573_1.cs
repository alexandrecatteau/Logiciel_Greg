namespace Moteur.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.t_erreur",
                c => new
                    {
                        Cle = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.Cle);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.t_erreur");
        }
    }
}
