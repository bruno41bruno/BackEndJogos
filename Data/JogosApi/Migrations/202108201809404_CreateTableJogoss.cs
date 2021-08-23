namespace JogosApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableJogoss : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Jogos", "Lancamento", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Jogos", "Lancamento", c => c.DateTime(nullable: false));
        }
    }
}
