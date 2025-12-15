using Domain.Entities;
using MovieApi.Application.Features.Commands.CategoryCommands;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.Handlers.CategoryHandlers;

public class CreateCategoryCommandHandler
{
    private readonly MovieContext _context;

    public CreateCategoryCommandHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task Handle(CreateCategoryCommand command)
    {
        _context.Categories.Add(new Category
        {
            Name = command.Name,
        });

        await _context.SaveChangesAsync();
    }
}
