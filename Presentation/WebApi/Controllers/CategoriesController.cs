using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.Handlers.CategoryHandlers;
using MovieApi.Application.Features.Queries.CategoryQueries;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : Controller
    {
        private readonly GetCategoryQueryHandler _getCategoryQueryHandler;
    }
}
