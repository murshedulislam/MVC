using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SQLConnectionEntityMVCApp.Models.Models;
using SQLConnectionEntityMVCApp.BLL.BLL;

namespace SQLConnectionEntityMVCApp.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager _categoryManager = new CategoryManager();
        Category category = new Category();
        // GET: Category
        public ActionResult Add()
        {
            category.Name = "Aarong";
            _categoryManager.Add(category);

            return View();
        }

        public ActionResult Delete()
        {
            category.ID = 2;
            _categoryManager.Delete(category);
            return View();
        }

        public ActionResult Update()
        {
            category.ID = 1;
            category.Name = "Unimart";
            _categoryManager.Update(category);
            return View();
        }
    }
}