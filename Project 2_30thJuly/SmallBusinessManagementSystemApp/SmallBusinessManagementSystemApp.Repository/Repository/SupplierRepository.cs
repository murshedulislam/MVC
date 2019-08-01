using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagementSystemApp.Models.Models;
using SmallBusinessManagementSystemApp.DatabaseContext.DatabaseContext;

namespace SmallBusinessManagementSystemApp.Repository.Repository
{
    public class SupplierRepository
    {
        StockDbContext db = new StockDbContext();

        public bool AddSupplier(Supplier supplier)
        {
            int isExecuted = 0;
            db.Suppliers.Add(supplier);
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }

        public bool DeleteSupplier(Supplier supplier)
        {
            int isExecuted = 0;

            Supplier aSupplier = db.Suppliers.FirstOrDefault(c => c.Code == supplier.Code);
            db.Suppliers.Remove(aSupplier);
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }
            return false;

        }

        public bool UpdateSupplier(Supplier supplier)
        {
            int isExecuted = 0;

            //Supplier aSupplier = db.Suppliers.FirstOrDefault(c => c.Code == supplier.Code);
            //if (aSupplier != null)
            //{
            //    aSupplier.Name = supplier.Name;

            //}

            db.Entry(supplier).State = EntityState.Modified;
            isExecuted = db.SaveChanges();


            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }

        public Supplier GetById(Supplier supplier)
        {
            Supplier aSupplier = db.Suppliers.FirstOrDefault(c => c.ID == supplier.ID);
            return aSupplier;

        }

        public List<Supplier> GetAll()
        {
            return db.Suppliers.ToList();
        }
    }
}
