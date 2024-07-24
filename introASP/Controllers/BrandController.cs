using Microsoft.AspNetCore.Mvc;

namespace introASP.Controllers
{
    public class BrandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
