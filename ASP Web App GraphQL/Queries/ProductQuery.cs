using ASP_Web_App_GraphQL.Queries.GraphQueryTypes;
using ASP_Web_App_GraphQL.Queries.Interfaces;
using ASP_Web_App_GraphQL.Services;

namespace ASP_Web_App_GraphQL.Queries
{
    public class ProductQuery : ObjectGraphType, IGraphQuery
    {
        public ProductQuery(IDataProvider productProvider)
        {
            Field<ListGraphType<ProductType>>("products").Resolve(context =>
            {
                return productProvider.GetProducts();
            });
        }
    }
}
