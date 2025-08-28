using Microsoft.AspNetCore.Mvc;

namespace Shopping_Batch24.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
