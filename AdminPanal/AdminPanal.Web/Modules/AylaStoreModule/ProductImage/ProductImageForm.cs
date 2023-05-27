using Serenity.ComponentModel;

namespace AdminPanal.AylaStoreModule.Forms;

[FormScript("AylaStoreModule.ProductImage")]
[BasedOnRow(typeof(ProductImageRow), CheckNames = true)]
public class ProductImageForm
{
    public int ProductId { get; set; }
    public string Image { get; set; }
}