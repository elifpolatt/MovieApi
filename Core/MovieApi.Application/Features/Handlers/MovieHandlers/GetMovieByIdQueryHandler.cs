using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApi.Application.Features.Queries.MovieQueries;
using MovieApi.Application.Features.Results.MovieResult;
using Persistence.Context;

namespace MovieApi.Application.Features.Handlers.MovieHandlers;
public class GetMovieByIdQueryHandler
{
    private readonly MovieContext _context;

    public GetMovieByIdQueryHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task<GetMovieByIdResult> Handle(GetMovieByIdQuery query)
    {
        var movies = await _context.Movies.FindAsync(query.Id);

        return new GetMovieByIdResult
        {
            CoverImageUrl = movies.CoverImageUrl,
            CreatedYear = movies.CreatedYear,
            Description = movies.Description,
            Duration = movies.Duration,
            Rating = movies.Rating,
            ReleaseDate = movies.ReleaseDate,
            Status = movies.Status,
            Title = movies.Title
        };
    }
}
