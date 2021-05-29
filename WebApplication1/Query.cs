using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1
{
    public class Query
    {
        [GraphQLNonNullType]
        public List<Book> GetBooks
            ([Service] BookDbContext dbContext) => dbContext.Books.Include(x => x.Author).ToList();

        //By convention GetBooks() will be declared book()
        //in the query type
        public Book GetBook([Service] BookDbContext dbContext, int id) => dbContext.Books.FirstOrDefault(x => x.Id == id);

    }
}
