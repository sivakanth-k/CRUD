using Microsoft.AspNetCore.Mvc;

namespace SampleCRUD.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
