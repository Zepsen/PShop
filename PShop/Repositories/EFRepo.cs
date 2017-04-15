using System;
using System.Collections.Generic;
using PShop.Infrastructure.Interfaces.Repository;
using PShop.Models.DBEntities;
using PShop.Models.DBEFContext;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PShop.Repositories
{
    public class EFRepo : IRepository<Players>
    {
        private PShopContext _db;

        public EFRepo(PShopContext db)
        {
            _db = db;
        }

        ~EFRepo()
        {
            if (_db != null)
            {
                _db.Dispose();
            }
        }

        public List<Players> All()
        {
            return _db.Players.AsNoTracking()                
                .Include(i => i.Team.Sport)
                .ToList();
        }

        public Players GetById(Guid id)
        {
            return _db.Players.AsNoTracking().FirstOrDefault(i => i.Id == id);
        }
    }
}
