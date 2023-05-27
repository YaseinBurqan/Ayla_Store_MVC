using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanal.AylaStoreModule.Pages;

[PageAuthorize(typeof(ProductImageRow))]
public class ProductImagePage : Controller
{
    [Route("AylaStoreModule/ProductImage")]
    public ActionResult Index()
    {
        return this.GridPage("@/AylaStoreModule/ProductImage/ProductImagePage",
            ProductImageRow.Fields.PageTitle());
    }
}