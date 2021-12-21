using FluentMigrator;

namespace FluentMigration.Sample.Migrations
{
    [Migration(202112182218589356)]
    public class M_202112182218589356_Create_Table_ProductCategory: AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("ProductCategory")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey("PK_ProductCategory_Id").Identity()
                .WithColumn("Name").AsString(200).NotNullable();
        }
    }
}
