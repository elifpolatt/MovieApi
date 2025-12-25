using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponents.LayoutViewComponents;

public class _UserLayoutNavbarComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}

