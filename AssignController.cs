using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace StokTakip2023.Controllers
{
    [Authorize]
    public class AssignController:Controller
    {
        AssignManager am = new AssignManager(new EfStockAssignment());
        ProductManager pm = new ProductManager(new EfProductRepository());
        UserManager um = new UserManager(new EfUserRepository());
        [HttpGet]
        public IActionResult CreateAssign(int id)
        {
            var product = pm.TGetById(id);
            var user = um.GetUserIdByUserName(User.Identity.Name);
            StockAssignment assign = new StockAssignment
            {
                ProductId = id,
                UserId = user.UserID,
                AssignmentDate = System.DateTime.Now,
            };
            return View(assign);
        }
        [HttpPost]
        public IActionResult CreateAssign(StockAssignment p)
        {
            am.TAdd(p);
            return RedirectToAction("ProductList","Product");
        }
        [Authorize(Roles = "Admin")]
        public IActionResult AssignList(string isAccepted)
        {
            var data = am.GetWithJoinService();
            var date = DateTime.Now;
            var dataNotAccepted = data.Where(x => x.IsAccepted == false).ToList();
            var dataTimeFull = data.Where(x => x.IsAccepted == true && x.ReturnDate <= date).ToList();
            switch (isAccepted)
            {
                case "false":
                    return View(dataNotAccepted);
                case "true":
                    return View(dataTimeFull);
                case "all":
                    return View(data);
                default:
                    return View(data);
            }
            
            
        }
        public IActionResult MyAssigns()
        {
            var user = um.GetUserIdByUserName(User.Identity.Name);
            var data = am.GetWithJoinService().Where(x=>x.UserId==user.UserID);
            return View(data);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var assign = am.TGetById(id);
            am.TDelete(assign);
            return RedirectToAction("AssignList");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Accept(int id)
        {
           
            var assign = am.TGetById(id);
            if (!assign.IsAccepted)
            {
                assign.IsAccepted = true;
                am.TUpdate(assign);
                var product = pm.TGetById(assign.ProductId);
                product.UnitsInStock -= assign.Quantity;
                pm.TUpdate(product);
            }
            
            return RedirectToAction("AssignList");
        }
    }
}
