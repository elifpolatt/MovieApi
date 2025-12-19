using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using Persistence.Context;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers;

public class UpdateMovieCommandHandler
{
    private readonly MovieContext _context;

    public UpdateMovieCommandHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task Handle(UpdateMovieCommand command)
    {
        var movies = await _context.Movies.FindAsync(command.Id);
        if (movies != null)
        {
            movies.CoverImageUrl = command.CoverImageUrl;
            movies.CreatedYear = command.CreatedYear;
            movies.Description = command.Description;
            movies.Duration = command.Duration;
            movies.Rating = command.Rating;
            movies.ReleaseDate = command.ReleaseDate;
            movies.Status = command.Status;
            movies.Title = command.Title;
        }

        await _context.SaveChangesAsync();
    }
}

