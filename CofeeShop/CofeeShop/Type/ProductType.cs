﻿using CofeeShop.Models;
using GraphQL.Types;

namespace CofeeShop.Type
{
    public class ProductType :ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(p => p.Id);
            Field(p => p.Name);
            Field(p => p.Price);
        }
    }
}
