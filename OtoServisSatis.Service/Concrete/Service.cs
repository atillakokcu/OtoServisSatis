using OtoServisSatis.Data;
using OtoServisSatis.Data.Abstract;
using OtoServisSatis.Data.Concrete;
using OtoServisSatis.Entities;
using OtoServisSatis.Service.Abstract;

namespace OtoServisSatis.Service.Concrete
{
    public class Service<T> : Repository<T>,IService<T>,IRepository<T> where T : class, IEntitiy, new()
    {
        public Service(DatabaseContext contex) : base(contex)
        {
        }
    }
}
