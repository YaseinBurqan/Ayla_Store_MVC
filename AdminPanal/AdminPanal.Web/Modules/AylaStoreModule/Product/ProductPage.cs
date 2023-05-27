using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanal.AylaStoreModule.Pages;

[PageAuthorize(typeof(ProductRow))]
public class ProductPage : Controller
{
    [Route("AylaStoreModule/Product")]
    public ActionResult Index()
    {
        return this.GridPage("@/AylaStoreModule/Product/ProductPage",
            ProductRow.Fields.PageTitle());
    }
}