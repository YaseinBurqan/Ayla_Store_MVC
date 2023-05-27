using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace AdminPanal.AylaStoreModule;

[ConnectionKey("Ayla_Store_MVC_Database"), Module("AylaStoreModule"), TableName("ProductImages")]
[DisplayName("Product Image"), InstanceName("Product Image")]
[ReadPermission("ProductImage")]
[ModifyPermission("ProductImage")]
public sealed class ProductImageRow : Row<ProductImageRow.RowFields>, IIdRow, INameRow
{
    const string jProduct = nameof(jProduct);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Product"), ForeignKey("Product", "Id"), LeftJoin(jProduct), TextualField(nameof(ProductName))]
    public int? ProductId
    {
        get => fields.ProductId[this];
        set => fields.ProductId[this] = value;
    }

    [DisplayName("Image"), QuickSearch, NameProperty]
    public string Image
    {
        get => fields.Image[this];
        set => fields.Image[this] = value;
    }

    [DisplayName("Product Name"), Expression($"{jProduct}.[Name]")]
    public string ProductName
    {
        get => fields.ProductName[this];
        set => fields.ProductName[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field ProductId;
        public StringField Image;

        public StringField ProductName;
    }
}