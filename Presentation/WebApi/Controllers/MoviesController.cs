using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.Handlers.MovieHandlers;
using MovieApi.Application.Features.Queries.MovieQueries;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly GetMovieByIdQueryHandler _getMovieByIdQueryHandler;
        private readonly GetMovieQueryHandler _getMovieQueryHandler;
        private readonly CreateMovieCommandHandler _createMovieCommandHandler;
        private readonly DeleteMovieCommandHandler _deleteMovieCommandHandler;
        private readonly UpdateMovieCommandHandler _updateMovieCommandHandler;


        public MoviesController(GetMovieByIdQueryHandler getMovieByIdQueryHandler, GetMovieQueryHandler getMovieQueryHandler, CreateMovieCommandHandler createMovieCommandHandler, DeleteMovieCommandHandler deleteMovieCommandHandler, UpdateMovieCommandHandler updateMovieCommandHandler)
        {
            _getMovieByIdQueryHandler = getMovieByIdQueryHandler;
            _getMovieQueryHandler = getMovieQueryHandler;
            _createMovieCommandHandler = createMovieCommandHandler;
            _deleteMovieCommandHandler = deleteMovieCommandHandler;
            _updateMovieCommandHandler = updateMovieCommandHandler;
        }
    }
}
