using Microsoft.EntityFrameworkCore;
using OtoServisSatis.Data.Abstract;
using OtoServisSatis.Entities;
using System.Linq.Expressions;

namespace OtoServisSatis.Data.Concrete
{
    public class CarRepository : Repository<Arac>, ICarRepository
    {
        public CarRepository(DatabaseContext contex) : base(contex)
        {
        }

        public async Task<Arac> GetCustomCar(int Id)
        {
            return await _DbSet.AsNoTracking().Include(x=>x.Marka).FirstOrDefaultAsync(c=>c.Id==Id);
        }

        public async Task<List<Arac>> GetCustomCarList()
        {
            return await _DbSet.AsNoTracking().Include(x=>x.Marka).ToListAsync();
        }

        public async Task<List<Arac>> GetCustomCarList(Expression<Func<Arac, bool>> expression)
        {
            return await _DbSet.Where(expression).AsNoTracking().Include(x => x.Marka).ToListAsync();
        }
    }
}
