using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Queries.CastQueries;
using MovieApi.Application.Features.MediatorDesignPattern.Results.CastResults;
using Persistence.Context;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.CastHandlers;

public class GetCastByIdQueryHandler : IRequestHandler<GetCastByIdQuery, GetCastByIdResult>
{
    private readonly MovieContext _context;
    public async Task<GetCastByIdResult> Handle(GetCastByIdQuery request, CancellationToken cancellationToken)
    {
        var values = await _context.Casts.FindAsync(request.Id);

        return new GetCastByIdResult
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

