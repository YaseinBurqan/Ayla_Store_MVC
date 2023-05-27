using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanal.AylaStoreModule.Pages;

[PageAuthorize(typeof(ReviewRow))]
public class ReviewPage : Controller
{
    [Route("AylaStoreModule/Review")]
    public ActionResult Index()
    {
        return this.GridPage("@/AylaStoreModule/Review/ReviewPage",
            ReviewRow.Fields.PageTitle());
    }
}