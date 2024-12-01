using BLL.IServices;
using Core.Models;
using Data;
using Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CommoditeService : ServicePattern<Comodite>, ICommoditeService
    {
        public CommoditeService(ICommoditeRepository commoditeRepository, IUnitOfWork unitOfWork) : base(commoditeRepository, unitOfWork)
        {
        }
    }
}
