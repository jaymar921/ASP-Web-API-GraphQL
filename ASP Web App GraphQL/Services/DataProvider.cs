using ASP_Web_App_GraphQL.Queries.Model;

namespace ASP_Web_App_GraphQL.Services
{
    public class DataProvider : IDataProvider
    {
        public Person[] GetPersons()
        {
            return [
                new(1, "Jay", "Software Developer"),
                new(2, "Kent", "Software Developer"),
                new(3, "Maico", "Senior Software Developer"),
            ];
        }

        public Product[] GetProducts()
        {
            return
            [
                new Product(1, "Pokky", 10),
                new Product(2, "Bread Pan", 25),
                new Product(3, "Orange", 5)
            ];
        }
    }
}
