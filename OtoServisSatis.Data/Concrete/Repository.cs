using Microsoft.EntityFrameworkCore;
using OtoServisSatis.Data.Abstract;
using OtoServisSatis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.Data.Concrete
{
    public class Repository<T> : IRepository<T> where T : class, IEntitiy, new() // newlenebilir olmasına izin verdiğimiz için yazdık
    {
        internal DatabaseContext _Contex;

        internal DbSet<T> _DbSet;

        public Repository(DatabaseContext contex)
        {
            _Contex = contex;
            _DbSet = _Contex.Set<T>();
        }


        public void Add(T entitiy)
        {
            _DbSet.Add(entitiy);
        }

        public async Task AddAsync(T entitiy)
        {
            await _DbSet.AddAsync(entitiy);
        }

        public void Delete(T entitiy)
        {
            _DbSet.Remove(entitiy);
        }

        public T Find(int id)
        {
            return _DbSet.Find(id);
        }

        public async Task<T> FindAsync(int Id)
        {
            return await _DbSet.FindAsync(Id);
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            return _DbSet.FirstOrDefault(expression);
        }

        public List<T> GetAll()
        {
            return _DbSet.ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return _DbSet.Where(expression).ToList();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _DbSet.ToListAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression)
        {
            return await _DbSet.Where(expression).ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            return await _DbSet.FirstOrDefaultAsync(expression);
        }

        public void Remove(T entitiy)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            return _Contex.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _Contex.SaveChangesAsync();
        }

        public void Update(T entitiy)
        {
            _Contex.Update(entitiy);
        }
    }
}
