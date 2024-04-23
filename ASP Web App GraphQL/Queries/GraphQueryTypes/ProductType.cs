using ASP_Web_App_GraphQL.Queries.Model;

namespace ASP_Web_App_GraphQL.Queries.GraphQueryTypes
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Quantity);
        }
    }
}
