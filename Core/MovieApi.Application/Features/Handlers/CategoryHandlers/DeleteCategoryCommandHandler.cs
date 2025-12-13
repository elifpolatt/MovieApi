using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApi.Application.Features.Commands.CategoryCommands;
using Persistence.Context;

namespace MovieApi.Application.Features.Handlers.CategoryHandlers;

public class DeleteCategoryCommandHandler
{
    private readonly MovieContext _context;

    public DeleteCategoryCommandHandler(MovieContext context)
    {
        _context = context;
    }

    public async void Handle(DeleteCategoryCommand command)
    {
        var categories = await _context.Categories.FindAsync(command.Id);

        _context.Categories.Remove(categories);
        await _context.SaveChangesAsync();

    }
}

