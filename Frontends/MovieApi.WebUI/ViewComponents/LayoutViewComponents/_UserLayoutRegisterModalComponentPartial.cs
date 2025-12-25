using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponents.LayoutViewComponents;

public class _UserLayoutRegisterModalComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}

