using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.Results.CategoryResult;
using Persistence.Context;

namespace MovieApi.Application.Features.Handlers.CategoryHandlers;

public class GetCategoryQueryHandler
{
    private readonly MovieContext _context;

    public GetCategoryQueryHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task<List<GetCategoryQueryResult>> Handle()
    {
        var categories = await _context.Categories.ToListAsync();

        return categories.Select(x => new GetCategoryQueryResult
        {
            Id = x.Id,
            Name = x.Name
        }).ToList();
    }
}
