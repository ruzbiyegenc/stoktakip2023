using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfUserRepository : GenericRepository<UserTable>, IUserDAL
    {
        public UserTable GetUserID(string userName)
        {
            using (var c = new Context())
            {
                return c.UserTables.FirstOrDefault(x=>x.UserName==userName);
            }
        }
    }
}
