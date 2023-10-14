using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDAL _userDAL;

        public UserManager(IUserDAL userDAL)
        {
            _userDAL = userDAL;
        }

        public List<UserTable> GetList()
        {
           return _userDAL.GetListAll();
        }

        public UserTable GetUserIdByUserName(string userName)
        {
            return _userDAL.GetUserID(userName);
        }

        public void TAdd(UserTable t)
        {
            _userDAL.Insert(t);
        }

        public void TDelete(UserTable t)
        {
            _userDAL.Delete(t);
        }

        public UserTable TGetById(int id)
        {
            return _userDAL.GetById(id);
        }
        
        public void TUpdate(UserTable t)
        {
            _userDAL.Update(t);
        }
    }
}
