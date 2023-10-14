using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakip2023.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
        public IActionResult ProductList()
        {
            var data = pm.GetList();
            return View(data);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product p)
        {
            pm.TAdd(p);
            return RedirectToAction("ProductList");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = pm.TGetById(id); 
            return View(data);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Edit(Product p)
        {
            pm.TUpdate(p);
            return RedirectToAction("ProductList");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = pm.TGetById(id);
            pm.TDelete(product);
            return RedirectToAction("ProductList");
        }
    }
}
