using Casgem.Business.Abstract;
using Casgem.DataAccess.Abstract;
using Casgem.Entities.Concrete;

namespace Casgem.Business.Concrete;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void Insert(Category entity)
    {
        _categoryDal.Insert(entity);
    }

    public void Update(Category entity)
    {
        _categoryDal.Update(entity);
    }

    public void Delete(Category entity)
    {
        _categoryDal.Delete(entity);
    }

    public List<Category> GetList()
    {
        return _categoryDal.GetList();
    }

    public Category? GetById(int id)
    {
        return _categoryDal.GetById(id);
    }
}