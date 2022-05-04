using CofeeShop.Mutation;
using CofeeShop.Query;

namespace CofeeShop.Schema
{
    public class ProductSchema:GraphQL.Types.Schema
    {
        public ProductSchema(ProductQuery productQuery,ProductMutataion productMutataion) 
        {
            Query = productQuery;
            Mutation = productMutataion;    

        }
    }
}
