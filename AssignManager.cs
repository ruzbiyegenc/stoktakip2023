using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AssignManager : IAssignService
    {
        IStockAssignmentDAL _assignDAL;
        public AssignManager(IStockAssignmentDAL assignDAL)
        {
            _assignDAL = assignDAL;
        }

        public List<StockAssignment> GetList()
        {
            return _assignDAL.GetListAll();
        }

        public List<StockAssignment> GetWithJoinService()
        {
            return _assignDAL.GetWithJoin();
        }

        public void TAdd(StockAssignment t)
        {
            _assignDAL.Insert(t);
        }
        public void TDelete(StockAssignment t)
        {
            _assignDAL.Delete(t);
        }
        public StockAssignment TGetById(int id)
        {
            return _assignDAL.GetById(id);
        }
        public void TUpdate(StockAssignment t)
        {
            _assignDAL.Update(t);
        }
    }
}
