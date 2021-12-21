using FluentMigrator;

namespace FluentMigration.Sample.Migrations
{
    [Migration(202112182224551945)]
    public class M_202112182224551945_Create_Table_Product: Migration
    {
        public override void Up()
        {
            Create.Table("Product")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey("PK_Product_Id").Identity()
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("CategoryId").AsInt32().NotNullable()
                .WithColumn("Price").AsCurrency().NotNullable();

            Create.ForeignKey("FK_ProductCategory_Id")
                .FromTable("Product").ForeignColumn("CategoryId")
                .ToTable("ProductCategory").PrimaryColumn("Id");
        }

        public override void Down()
        {
            Delete.Table("Product");
        }
    }
}
