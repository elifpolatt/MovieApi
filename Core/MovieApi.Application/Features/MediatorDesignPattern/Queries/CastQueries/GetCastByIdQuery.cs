using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Results.CastResults;

namespace MovieApi.Application.Features.MediatorDesignPattern.Queries.CastQueries;
public class GetCastByIdQuery : IRequest<List<GetCastQueryResult>>
{
    public GetCastByIdQuery(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}

