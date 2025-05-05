using MonolithicArchitectureExample.Interfaces;
using MonolithicArchitectureExample.Models;

namespace MonolithicArchitectureExample.Services;

public class ProductService : IProductService
{
    public IEnumerable<Product> GetAll()
    {
        return new List<Product>
        {
            new Product { Id = 1, Name = "Keyboard" },
            new Product { Id = 2, Name = "Mouse" }
        };
    }
}
