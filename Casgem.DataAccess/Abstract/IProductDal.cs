using Casgem.Entities.Concrete;

namespace Casgem.DataAccess.Abstract;

public interface IProductDal : IGenericDal<Product>
{
    List<Product> GetProductWithCategories();
}