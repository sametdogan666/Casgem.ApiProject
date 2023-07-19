using Casgem.Business.Abstract;
using Casgem.DataAccess.Abstract;
using Casgem.Entities.Concrete;

namespace Casgem.Business.Concrete;

public class CustomerManager : ICustomerService
{
    private readonly ICustomerDal _customerDal;

    public CustomerManager(ICustomerDal customerDal)
    {
        _customerDal = customerDal;
    }

    public void Insert(Customer entity)
    {
        _customerDal.Insert(entity);
    }

    public void Update(Customer entity)
    {
        _customerDal.Update(entity);
    }

    public void Delete(Customer entity)
    {
        _customerDal.Delete(entity);
    }

    public List<Customer> GetList()
    {
        return _customerDal.GetList();
    }

    public Customer? GetById(int id)
    {
        return _customerDal.GetById(id);
    }
}