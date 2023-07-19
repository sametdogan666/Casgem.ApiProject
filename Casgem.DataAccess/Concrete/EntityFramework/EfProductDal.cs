using Casgem.DataAccess.Abstract;
using Casgem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Casgem.DataAccess.Concrete.EntityFramework;

public class EfProductDal : GenericRepository<Product>, IProductDal
{
    public EfProductDal(Context context) : base(context)
    {
    }

    public List<Product> GetProductWithCategories()
    {
        using var context = new Context();

        return context.Products.Include(x => x.Category).ToList();
    }
}