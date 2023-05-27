using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanal.AylaStoreModule.Pages;

[PageAuthorize(typeof(CategoryRow))]
public class CategoryPage : Controller
{
    [Route("AylaStoreModule/Category")]
    public ActionResult Index()
    {
        return this.GridPage("@/AylaStoreModule/Category/CategoryPage",
            CategoryRow.Fields.PageTitle());
    }
}