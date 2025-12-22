using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Queries.CastQueries;
using MovieApi.Application.Features.MediatorDesignPattern.Results.CastResults;
using Persistence.Context;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.CastHandlers;

public class GetCastByIdQueryHandler : IRequestHandler<GetCastByIdQuery, GetCastByIdQueryResult>
{
    private readonly MovieContext _context;

    public GetCastByIdQueryHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task<GetCastByIdQueryResult> Handle(GetCastByIdQuery request, CancellationToken cancellationToken)
    {
        var values = await _context.Casts.FindAsync(request.Id, cancellationToken);

        return new GetCastByIdQueryResult
        {
            Id = values.Id,
            Title = values.Title,
            Name = values.Name,
            Biography = values.Biography,
            ImgUrl = values.ImgUrl,
            Overview = values.Overview,
            Surname = values.Surname
        };
    }
}

