using EntityLayer.Concrete;
using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface IStockAssignmentDAL : IGenericDAL<StockAssignment>
    {
        List<StockAssignment> GetWithJoin();
    }
}
