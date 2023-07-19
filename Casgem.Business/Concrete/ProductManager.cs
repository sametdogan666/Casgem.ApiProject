using Casgem.Business.Abstract;
using Casgem.DataAccess.Abstract;
using Casgem.Entities.Concrete;

namespace Casgem.Business.Concrete;

public class ProductManager : IProductService
{
    private readonly IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    public void Insert(Product entity)
    {
        _productDal.Insert(entity);
    }

    public void Update(Product entity)
    {
        _productDal.Update(entity);
    }

    public void Delete(Product entity)
    {
        _productDal.Delete(entity);
    }

    public List<Product> GetList()
    {
        return _productDal.GetList();
    }

    public Product? GetById(int id)
    {
        return _productDal.GetById(id);
    }

    public List<Product> GetProductWithCategoriesList()
    {
        return _productDal.GetProductWithCategories();
    }
}