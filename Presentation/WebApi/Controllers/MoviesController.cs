using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.Commands.MovieCommands;
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

        [HttpGet]
        public async Task<IActionResult> MovieList()
        {
            var value = await _getMovieQueryHandler.Handle();
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(CreateMovieCommand command)
        {
            await _createMovieCommandHandler.Handle(command);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            await _deleteMovieCommandHandler.Handle(new DeleteMovieCommand(id));
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMovie(UpdateMovieCommand command)
        {
            await _updateMovieCommandHandler.Handle(command);
            return Ok();
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetMovieById(int id)
        {
            var value = await _getMovieByIdQueryHandler.Handle(new GetMovieByIdQuery(id));
            return Ok(value);
        }
    }
}
