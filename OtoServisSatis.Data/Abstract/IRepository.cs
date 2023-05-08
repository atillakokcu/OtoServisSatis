using OtoServisSatis.Entities;
using System.Linq.Expressions;

namespace OtoServisSatis.Data.Abstract
{
    public interface IRepository<T> where T : class,IEntitiy
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T,bool>> expression);
        T Get(Expression<Func<T, bool>> expression);
        T Find(int id);
        void Add(T entitiy);

        void Delete(T entitiy);
        void Update(T entitiy);
        int Save();

        // Asenkron Methodlar
        Task<T> FindAsync(int Id);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression);
        Task AddAsync (T entitiy);
        Task<int> SaveAsync();

    }
}
