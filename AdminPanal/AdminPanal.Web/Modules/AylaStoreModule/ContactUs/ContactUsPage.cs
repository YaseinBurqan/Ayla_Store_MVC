using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanal.AylaStoreModule.Pages;

[PageAuthorize(typeof(ContactUsRow))]
public class ContactUsPage : Controller
{
    [Route("AylaStoreModule/ContactUs")]
    public ActionResult Index()
    {
        return this.GridPage("@/AylaStoreModule/ContactUs/ContactUsPage",
            ContactUsRow.Fields.PageTitle());
    }
}