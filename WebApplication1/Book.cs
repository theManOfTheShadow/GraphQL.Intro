using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate;

namespace WebApplication1
{
    public class Book
    {
        public int Id { get; set; }

        [GraphQLNonNullType]
        public string Title { get; set; }
        public int Pages { get; set; }
        public int Chapters { get; set; }

        [GraphQLNonNullType]
        public Author Author { get; set; }

    }
}
