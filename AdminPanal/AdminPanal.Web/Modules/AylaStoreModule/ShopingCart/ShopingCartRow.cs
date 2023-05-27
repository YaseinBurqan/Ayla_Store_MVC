using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace AdminPanal.AylaStoreModule;

[ConnectionKey("Ayla_Store_MVC_Database"), Module("AylaStoreModule"), TableName("ShopingCart")]
[DisplayName("Shoping Cart"), InstanceName("Shoping Cart")]
[ReadPermission("ShopingCart")]
[ModifyPermission("ShopingCart")]
public sealed class ShopingCartRow : Row<ShopingCartRow.RowFields>, IIdRow, INameRow
{
    const string jProduct = nameof(jProduct);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("User Id"), QuickSearch, NameProperty]
    public string UserId
    {
        get => fields.UserId[this];
        set => fields.UserId[this] = value;
    }

    [DisplayName("Product"), ForeignKey("Product", "Id"), LeftJoin(jProduct), TextualField(nameof(ProductName))]
    public int? ProductId
    {
        get => fields.ProductId[this];
        set => fields.ProductId[this] = value;
    }

    [DisplayName("Quantity")]
    public int? Quantity
    {
        get => fields.Quantity[this];
        set => fields.Quantity[this] = value;
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
        public StringField UserId;
        public Int32Field ProductId;
        public Int32Field Quantity;

        public StringField ProductName;
    }
}