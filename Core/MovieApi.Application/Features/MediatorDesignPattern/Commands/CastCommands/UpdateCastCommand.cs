using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands;

public class UpdateCastCommand : IRequest
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    public string ImgUrl { get; set; }

    public string? Overview { get; set; }

    public string? Biography { get; set; }
}

