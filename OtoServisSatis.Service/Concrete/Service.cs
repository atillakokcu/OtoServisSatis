using OtoServisSatis.Data;
using OtoServisSatis.Data.Concrete;
using OtoServisSatis.Entities;

namespace OtoServisSatis.Service.Concrete
{
    public class Service<T> : Repository<T> where T : class, IEntitiy, new()
    {
        public Service(DatabaseContext contex) : base(contex)
        {
        }
    }
}
