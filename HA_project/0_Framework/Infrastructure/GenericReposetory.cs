using _0_Framework.GenericReposetory;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace _0_Framework.Infrastructure
{
    public class GenericReposetory<Tkey, T> : IGenericReposetory<Tkey, T> where T : class
    {
        private readonly DbContext _context;

        public GenericReposetory(DbContext context) 
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Add<T>(entity);
            Save();
        }

        public bool Exist(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Any(expression);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(Tkey id)
        {
            return _context.Find<T>(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
