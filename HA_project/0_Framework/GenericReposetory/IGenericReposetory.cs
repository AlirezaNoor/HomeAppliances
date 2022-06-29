using System.Linq.Expressions;

namespace _0_Framework.GenericReposetory
{
    public interface IGenericReposetory<Tkey,T> where T: class
    {
        void Create(T entity);
        T GetById(Tkey id);
        bool Exist(Expression<Func<T,bool>> expression);
        List<T> GetAll();

        void Save();
    }
}
