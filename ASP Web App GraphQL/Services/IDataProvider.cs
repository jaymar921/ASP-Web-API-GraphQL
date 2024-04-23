using ASP_Web_App_GraphQL.Queries.Model;

namespace ASP_Web_App_GraphQL.Services
{
    public interface IDataProvider
    {
        Product[] GetProducts();
        Person[] GetPersons();
    }
}
