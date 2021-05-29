
using HotChocolate;
using HotChocolate.Types;

namespace WebApplication1
{
    public class Author
    {
        [GraphQLType(typeof(NonNullType<IdType>))]
        public int Id { get; set; }

        [GraphQLNonNullType]
        public string Name { get; set; }
    }
}
