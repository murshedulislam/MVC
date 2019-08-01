using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmallBusinessManagementSystemApp.BLL.BLL;
using SmallBusinessManagementSystemApp.Models.Models;

namespace SmallBusinessManagementSystemApp.Controllers
{
    public class SupplierController : Controller
    {
        SupplierManager _supplierManager = new SupplierManager();
        Supplier _supplier = new Supplier();
        // GET: Supplier
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                if (_supplierManager.AddSupplier(supplier))
                {
                    ViewBag.SuccessMsg = "Saved";
                }
                else
                {
                    ViewBag.FailMsg = "Failed";
                }
            }
            else
            {
                ViewBag.FailMsg = "Validation Failed";
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            _supplier.ID = Id;
            var supplier = _supplierManager.GetById(_supplier);
            return View(supplier);
        }

        [HttpPost]
        public ActionResult Edit(Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                _supplierManager.UpdateSupplier(supplier);
            }
            return View(supplier);
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            _supplier.ID = Id;
            var supplier = _supplierManager.GetById(_supplier);
            return View(supplier);
        }

        [HttpPost]
        public ActionResult Delete(Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                if (_supplierManager.UpdateSupplier(supplier))
                {
                    ViewBag.SuccessMsg = "Deleted.";
                }

                else
                {
                    ViewBag.FailMsg = "Delete Failed.";
                }
            }
            else
            {
                ViewBag.FailMsg = "Validation Failed.";
            }
            return View(supplier);
        }

        [HttpGet]
        public ActionResult Show()
        {
            _supplier.Suppliers = _supplierManager.GetAll();
            return View(_supplier);
        }
        [HttpPost]
        public ActionResult Show(Supplier supplier)
        {
            var suppliers = _supplierManager.GetAll();

            if (supplier.Code != null)
            {

                suppliers = suppliers.Where(c => c.Code.ToLower().Contains(supplier.Code.ToLower())).ToList();
            }

            if (supplier.Name != null)
            {
                //suppliers = suppliers.Where(c => c.Name.Contains(supplier.Name)).ToList();
                suppliers = suppliers.Where(c => c.Name.ToLower().Contains(supplier.Name.ToLower())).ToList();
            }
            if (supplier.Address != null)
            {

                suppliers = suppliers.Where(c => c.Address.ToLower().Contains(supplier.Address.ToLower())).ToList();
            }
            if (supplier.Contact > 0)
            {
                suppliers = suppliers.Where(c => c.Contact == supplier.Contact).ToList();
            }
            if (supplier.Email != null)
            {

                suppliers = suppliers.Where(c => c.Email.ToLower().Contains(supplier.Email.ToLower())).ToList();
            }
            if (supplier.ContactPerson != null)
            {

                suppliers = suppliers.Where(c => c.ContactPerson.ToLower().Contains(supplier.ContactPerson.ToLower())).ToList();
            }

            supplier.Suppliers = suppliers;
            return View(supplier);
        }
    }
}