using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanal.AylaStoreModule.Pages;

[PageAuthorize(typeof(ShopingCartRow))]
public class ShopingCartPage : Controller
{
    [Route("AylaStoreModule/ShopingCart")]
    public ActionResult Index()
    {
        return this.GridPage("@/AylaStoreModule/ShopingCart/ShopingCartPage",
            ShopingCartRow.Fields.PageTitle());
    }
}