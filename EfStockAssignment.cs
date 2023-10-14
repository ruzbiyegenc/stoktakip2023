using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfStockAssignment : GenericRepository<StockAssignment>, IStockAssignmentDAL
    {
        public List<StockAssignment> GetWithJoin()
        {
            using (var c = new Context())
            {
                return c.StockAssignments.Include(x=>x.Product).Include(x=>x.User).ToList();
            }
        }
    }
}
