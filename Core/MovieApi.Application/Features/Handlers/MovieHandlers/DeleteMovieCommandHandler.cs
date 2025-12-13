using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApi.Application.Features.Commands.MovieCommands;
using Persistence.Context;

namespace MovieApi.Application.Features.Handlers.MovieHandlers;

public class DeleteMovieCommandHandler
{
    private readonly MovieContext _context;

    public DeleteMovieCommandHandler(MovieContext context)
    {
        _context = context;
    }

    public async void Handle(DeleteMovieCommand command)
    {
        var movies = await _context.Movies.FindAsync(command.Id);
        _context.Movies.Remove(movies);

        await _context.SaveChangesAsync();
    }
}

