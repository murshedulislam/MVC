using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagementSystemApp.Models.Models;
using SmallBusinessManagementSystemApp.DatabaseContext.DatabaseContext;

namespace SmallBusinessManagementSystemApp.Repository.Repository
{
    public class ProductRepository
    {
        StockDbContext db = new StockDbContext();

        public bool AddProduct(Product product)
        {
            int isExecuted = 0;
            db.Products.Add(product);
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }

        public bool DeleteProduct(Product product)
        {
            int isExecuted = 0;

            Product aProduct = db.Products.FirstOrDefault(c => c.Code == product.Code);
            db.Products.Remove(aProduct);
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }
            return false;

        }

        public bool UpdateProduct(Product product)
        {
            int isExecuted = 0;

            Product aProduct = db.Products.FirstOrDefault(c => c.Code == product.Code);
            if (aProduct != null)
            {
                aProduct.Name = product.Name;

            }
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }

        public Product GetByCode(Product product)
        {
            Product aProduct = db.Products.FirstOrDefault(c => c.Code == product.Code);
            return aProduct;

        }

        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }

    }
}
