using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using Persistence.Context;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.CastHandlers;

public class UpdateCastCommandHandler : IRequestHandler<UpdateCastCommand>
{
    private readonly MovieContext _context;

    public UpdateCastCommandHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task Handle(UpdateCastCommand request, CancellationToken cancellationToken)
    {
        var values = await _context.Casts.FindAsync(request.Id, cancellationToken);

        values.Title = request.Title;
        values.Biography = request.Biography;
        values.ImgUrl = request.ImgUrl;
        values.Name = request.Name;
        values.Surname = request.Surname;
        values.Overview = request.Overview;

        await _context.SaveChangesAsync(cancellationToken);
    }
}
