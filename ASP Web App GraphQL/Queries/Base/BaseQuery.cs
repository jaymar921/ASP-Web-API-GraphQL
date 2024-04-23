using ASP_Web_App_GraphQL.Queries.Interfaces;

namespace ASP_Web_App_GraphQL.Queries.Base
{
    public class BaseQuery: ObjectGraphType
    {
        public BaseQuery(IEnumerable<IGraphQuery> graphQueryMarkers) 
        {
            Name = "Queries";
            foreach(var marker in graphQueryMarkers)
            {
                var query = marker as ObjectGraphType;
                if (null == query)
                {
                    continue;
                }
                foreach (var fields in query.Fields)
                {
                    AddField(fields);
                }
            }
        }

    }
}
