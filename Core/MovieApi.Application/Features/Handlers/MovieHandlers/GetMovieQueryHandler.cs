using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.Results.CategoryResult;
using MovieApi.Application.Features.Results.MovieResult;
using Persistence.Context;

namespace MovieApi.Application.Features.Handlers.MovieHandlers;

public class GetMovieQueryHandler
{
    private readonly MovieContext _context;

    public GetMovieQueryHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task<List<GetMovieQueryResult>> Handle()
    {
        var movies = await _context.Movies.ToListAsync();

        return movies.Select(x => new GetMovieQueryResult
        {
            Id = x.Id,
            CoverImageUrl = x.CoverImageUrl,
            CreatedYear = x.CreatedYear,
            Description = x.Description,
            Duration = x.Duration,
            Rating = x.Rating,
            ReleaseDate = x.ReleaseDate,
            Status = x.Status,
            Title = x.Title
        }).ToList();
    }
}

