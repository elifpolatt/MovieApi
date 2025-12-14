using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
