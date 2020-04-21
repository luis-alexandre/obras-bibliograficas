using System;
using System.Data.SQLite;
using System.IO;

namespace Guide.ObrasLiterarias.Infra.Migration
{
    [FluentMigrator.Migration(20200419)]
    public class AddCitacaoAutor : FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table("CitacaoAutor")
                .WithColumn("Id").AsInt64()
                .WithColumn("Autor").AsString()
                .WithColumn("Citacao").AsString();
        }

        public override void Down()
        {
            Delete.Table("CitacaoAutor");
        }
    }
}
