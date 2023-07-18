using Casgem.DataAccess.Abstract;
using Casgem.Entities.Concrete;

namespace Casgem.DataAccess.Concrete.EntityFramework;

public class EfProductDal : GenericRepository<Product>, IProductDal
{
    public EfProductDal(Context context) : base(context)
    {
    }
}