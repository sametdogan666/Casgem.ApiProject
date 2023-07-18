using Casgem.DataAccess.Abstract;
using Casgem.Entities.Concrete;

namespace Casgem.DataAccess.Concrete.EntityFramework;

public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
{
    public EfCustomerDal(Context context) : base(context)
    {
    }
}