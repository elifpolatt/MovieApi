using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.TagCommands;
using Persistence.Context;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.TagHandlers;

public class DeleteTagCommandHandler : IRequest<DeleteTagCommand>
{
    private readonly MovieContext _context;

    public DeleteTagCommandHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task Handle(DeleteTagCommand request, CancellationToken cancellationToken)
    {
        var values = await _context.Tags.FindAsync(request.Id, cancellationToken);

        _context.Tags.Remove(values);

        await _context.SaveChangesAsync(cancellationToken);
    }
}

