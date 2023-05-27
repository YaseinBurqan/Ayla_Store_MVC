using Microsoft.AspNetCore.Mvc;

namespace Ayla_Store_MVC.ViewComponents
{
    public class ContactUsViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}