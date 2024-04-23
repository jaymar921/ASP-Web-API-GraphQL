using ASP_Web_App_GraphQL.Queries.GraphQueryTypes;
using ASP_Web_App_GraphQL.Queries.Interfaces;
using ASP_Web_App_GraphQL.Services;
using GraphQL;
using GraphQL.Types;

namespace ASP_Web_App_GraphQL.Queries
{
    public class PersonQuery: ObjectGraphType, IGraphQuery
    {
        public PersonQuery(IDataProvider dataProvider) 
        {
            Field<ListGraphType<PersonTypes>>("persons").Resolve(c => dataProvider.GetPersons());
            Field<PersonTypes>("person")
                .Argument<IntGraphType>("id").Resolve(c => dataProvider.GetPersons().FirstOrDefault(p => p.Id == c.GetArgument<int>("id")));
        }
    }
}
