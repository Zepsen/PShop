using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PShop.Infrastructure.Interfaces.Repository
{
    public interface IRepository<T>  where T : class
    {
        List<T> All();
        T GetById(Guid id);
    }
}
