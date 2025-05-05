using MonolithicArchitectureExample.Models;

namespace MonolithicArchitectureExample.Interfaces;

public interface IProductService
{
    IEnumerable<Product> GetAll();
}