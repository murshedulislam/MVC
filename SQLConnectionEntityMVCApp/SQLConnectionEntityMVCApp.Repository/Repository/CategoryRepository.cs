using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLConnectionEntityMVCApp.Models.Models;
using SQLConnectionEntityMVCApp.DatabaseContext.DatabaseContext;

namespace SQLConnectionEntityMVCApp.Repository.Repository
{
    public class CategoryRepository
    {
        CategoryDbContext db = new CategoryDbContext();

        public bool Add(Category category)
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

        public bool Delete(Category category)
        {
            int isExecuted = 0;

            Category aCategory = db.Categories.FirstOrDefault(c => c.ID == category.ID);
            db.Categories.Remove(aCategory);
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }

        public bool Update(Category category)
        {

            int isExecuted = 0;

            Category aCategory = db.Categories.FirstOrDefault(c => c.ID == category.ID);
            if(aCategory != null)
            {
                aCategory.Name = category.Name;
                isExecuted = db.SaveChanges();
            }
            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }

        public Category GetByID(Category category)
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
