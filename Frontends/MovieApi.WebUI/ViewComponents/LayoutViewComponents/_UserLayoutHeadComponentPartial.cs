using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponents.LayoutViewComponents;

public class _UserLayoutHeadComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}

