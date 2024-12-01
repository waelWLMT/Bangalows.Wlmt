using Core.Models;
using Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class CommoditeRepository : Repository<Comodite>, ICommoditeRepository
    {
        public CommoditeRepository(MyDbContext ctx) : base(ctx)
        {
        }
    }
}
