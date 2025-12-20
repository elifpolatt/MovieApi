using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.MediatorDesignPattern.Queries.CastQueries;
using MovieApi.Application.Features.MediatorDesignPattern.Results.CastResults;
using Persistence.Context;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.CastHandlers;
public class GetCastQueryHandler : IRequestHandler<GetCastQuery, List<GetCastQueryResult>>
{
    private readonly MovieContext _context;

    public GetCastQueryHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task<List<GetCastQueryResult>> Handle(GetCastQuery request, CancellationToken cancellationToken)
    {
        var values = await _context.Casts.ToListAsync(cancellationToken);

        return values.Select(x => new GetCastQueryResult
        {
            Id = x.Id,
            Title = x.Title,
            Name = x.Name,
            Surname = x.Surname,
            Biography = x.Biography,
            ImgUrl = x.Biography,
            Overview = x.Overview
        }).ToList();
    }
}
