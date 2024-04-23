using ASP_Web_App_GraphQL.Queries;
using ASP_Web_App_GraphQL.Queries.Base;
using ASP_Web_App_GraphQL.Services;

namespace ASP_Web_App_GraphQL.Schema
{
    public class Schemas : GraphQL.Types.Schema
    {
        public Schemas(IServiceProvider serviceProvider) : base(serviceProvider)
        { 
            Query = serviceProvider.GetRequiredService<BaseQuery>();
        }
    }
}
