using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApi.Application.Features.Queries.CategoryQueries;
using MovieApi.Application.Features.Results.CategoryResult;
using Persistence.Context;

namespace MovieApi.Application.Features.Handlers.CategoryHandlers;

    public class GetCategoryByIdQueryHandler
    {
        private readonly MovieContext _context;

        public GetCategoryByIdQueryHandler(MovieContext context)
    {
        _context = context;
    }

        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {
            var category = await _context.Categories.FindAsync(query.Id);

            return new GetCategoryByIdQueryResult
            {
                Id = category.Id,
                Name = category.Name
            };
        }
}

