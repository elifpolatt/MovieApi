using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApi.Application.Features.Commands.CategoryCommands;
using Persistence.Context;

namespace MovieApi.Application.Features.Handlers.CategoryHandlers;
public class UpdateCategoryCommandHandler
{
    private readonly MovieContext _context;

    public UpdateCategoryCommandHandler(MovieContext context)
    {
        _context = context;
    }

    public async void Handle(UpdateCategoryCommand command)
    {
        var categories = await _context.Categories.FindAsync(command.Id);
        categories.Name = command.Name;

        await _context.SaveChangesAsync();
    }
}

