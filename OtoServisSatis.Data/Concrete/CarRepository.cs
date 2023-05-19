using Microsoft.EntityFrameworkCore;
using OtoServisSatis.Data.Abstract;
using OtoServisSatis.Entities;

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

        public async Task<IEnumerable<Arac>> GetCustomCarList()
        {
            return await _DbSet.AsNoTracking().Include(x=>x.Marka).ToListAsync();
        }
    }
}
