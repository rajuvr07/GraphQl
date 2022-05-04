using GraphQL.Types;

namespace CofeeShop.Type
{
    public class ProductInputType:InputObjectGraphType
    {
        public  ProductInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<FloatGraphType>("price");
        }

    }
}
