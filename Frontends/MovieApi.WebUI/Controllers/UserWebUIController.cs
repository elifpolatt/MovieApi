using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.Controllers
{
    public class UserWebUIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
