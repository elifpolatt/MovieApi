using Domain.Entities;
using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using Persistence.Context;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.CastHandlers;

public class CreateCastCommandHandler : IRequestHandler<CreateCastCommand>
{
    private readonly MovieContext _context;

    public CreateCastCommandHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task Handle(CreateCastCommand request, CancellationToken cancellationToken)
    {
        await _context.Casts.AddAsync(new Cast
        {
            Title = request.Title,
            Name = request.Name,
            Surname = request.Surname,
            Biography = request.Biography,
            ImgUrl = request.ImgUrl,
            Overview = request.Overview,
        });

        await _context.SaveChangesAsync(cancellationToken);

    }
}