using Casgem.DataAccess.Abstract;

namespace Casgem.DataAccess.Concrete;

public class GenericRepository<T> : IGenericDal<T> where T : class
{
    private readonly Context _context;

    public GenericRepository(Context context)
    {
        _context = context;
    }


    public void Insert(T entity)
    {
        _context.Add(entity);
        _context.SaveChanges();
    }

    public void Delete(T entity)
    {
        _context.Remove(entity);
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        _context.Update(entity);
        _context.SaveChanges();
    }

    public List<T> GetList()
    {
        return _context.Set<T>().ToList();
    }

    public T? GetById(int id)
    {
        return _context.Set<T>().Find(id);
    }
}