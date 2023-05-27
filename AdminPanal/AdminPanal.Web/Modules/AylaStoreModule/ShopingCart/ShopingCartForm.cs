using Serenity.ComponentModel;

namespace AdminPanal.AylaStoreModule.Forms;

[FormScript("AylaStoreModule.ShopingCart")]
[BasedOnRow(typeof(ShopingCartRow), CheckNames = true)]
public class ShopingCartForm
{
    public string UserId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}