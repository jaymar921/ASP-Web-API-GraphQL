using ASP_Web_App_GraphQL.Queries.Model;

namespace ASP_Web_App_GraphQL.Queries.GraphQueryTypes
{
    public class PersonTypes : ObjectGraphType<Person>
    {
        public PersonTypes() 
        {
            Field(x => x.Id).Description("Id of the Person Object");
            Field(x => x.Name).Description("Pangalan niya ofcourse :)");
            Field(x => x.Description).Description("Description niya");
        }

    }
}
