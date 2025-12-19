using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Queries.CategoryQueries;

public class GetCategoryQuery
{
    public int Id { get; set; }

    public string Name { get; set; }
}
