using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDAL _productDAL;
        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public List<Product> GetList()
        {
            return _productDAL.GetListAll();
        }

        public void TAdd(Product t)
        {
            _productDAL.Insert(t);
        }
        public void TDelete(Product t)
        {
            _productDAL.Delete(t);
        }
        public Product TGetById(int id)
        {
            return _productDAL.GetById(id);
        }
        public void TUpdate(Product t)
        {
            _productDAL.Update(t);
        }
    }
}
