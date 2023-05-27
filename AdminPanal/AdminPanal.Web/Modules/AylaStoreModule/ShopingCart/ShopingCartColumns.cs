using Serenity.ComponentModel;
using System.ComponentModel;

namespace AdminPanal.AylaStoreModule.Columns;

[ColumnsScript("AylaStoreModule.ShopingCart")]
[BasedOnRow(typeof(ShopingCartRow), CheckNames = true)]
public class ShopingCartColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string UserId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
}