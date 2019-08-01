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
    public class CategoryRepository
    {
        StockDbContext db = new StockDbContext();
      
        public bool AddCategory(Category category)
        {
            int isExecuted = 0;
            db.Categories.Add(category);
            isExecuted = db.SaveChanges();
            if(isExecuted > 0)
            {
                return true;
            }

            return false;
        }

        public bool DeleteCategory(Category category)
        {
            int isExecuted = 0;

            Category aCategory = db.Categories.FirstOrDefault(c => c.Code == category.Code);
            db.Categories.Remove(aCategory);
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }
            return false;

        }

        public bool UpdateCategory(Category category)
        {
            int isExecuted = 0;

            //Category aCategory = db.Categories.FirstOrDefault(c => c.Code == category.Code);
            //if (aCategory != null)
            //{
            //    aCategory.Name = category.Name;

            //}
            db.Entry(category).State = EntityState.Modified;
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }

        public Category GetById(Category category)
        {
            Category aCategory = db.Categories.FirstOrDefault(c => c.ID == category.ID);
            return aCategory;

        } 

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }
    }
}
