using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmallBusinessManagementSystemApp.Models.Models;
using SmallBusinessManagementSystemApp.BLL.BLL;

namespace SmallBusinessManagementSystemApp.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager _categoryManager = new CategoryManager();
        Category _category = new Category();
        //List<Category> categories = new List<Category>();
        // GET: Category
        [HttpGet]
        public ActionResult Add()
        {
            _category.Categories = _categoryManager.GetAll();
            return View(_category);
        }

        [HttpPost]
        public ActionResult Add(Category category)
        {
            
            
            if (ModelState.IsValid)
            {
                _categoryManager.AddCategory(category);
                category.Categories = _categoryManager.GetAll();
            }
            
            return View(category);
        }



        [HttpGet]
        public ActionResult Edit(int Id)
        {
            _category.ID = Id;
           var category = _categoryManager.GetById(_category);
            category.Categories = _categoryManager.GetAll();
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryManager.UpdateCategory(category);
                return RedirectToAction(nameof(Add));
            }
            return View(category);
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            _category.ID = Id;
            var category = _categoryManager.GetById(_category);
            category.Categories = _categoryManager.GetAll();
            return View(category);
        }

        [HttpPost]
        public ActionResult Delete(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryManager.DeleteCategory(category);
                category.Categories = _categoryManager.GetAll();
            }
            return View(category);
        }
    }
}