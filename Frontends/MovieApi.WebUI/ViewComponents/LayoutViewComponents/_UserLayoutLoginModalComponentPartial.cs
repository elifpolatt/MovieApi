using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MovieApi.WebUI.ViewComponents.LayoutViewComponents;

public class _UserLayoutLoginModalComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}

