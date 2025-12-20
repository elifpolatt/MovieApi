using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace MovieApi.Application.Features.MediatorDesignPattern.Commands.TagCommands;

public class DeleteTagCommand : IRequest
{
    public DeleteTagCommand(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}

