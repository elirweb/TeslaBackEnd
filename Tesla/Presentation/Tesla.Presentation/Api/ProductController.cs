using Microsoft.AspNetCore.Mvc;

namespace Tesla.Presentation.Api
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
