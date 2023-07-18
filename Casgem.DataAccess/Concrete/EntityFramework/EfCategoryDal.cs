using Casgem.DataAccess.Abstract;
using Casgem.Entities.Concrete;

namespace Casgem.DataAccess.Concrete.EntityFramework;

public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
{
    public EfCategoryDal(Context context) : base(context)
    {
    }
}