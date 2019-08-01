using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagementSystemApp.Models.Models;
using SmallBusinessManagementSystemApp.DatabaseContext.DatabaseContext;

namespace SmallBusinessManagementSystemApp.Repository.Repository
{
    public class CustomerRepository
    {

        StockDbContext db = new StockDbContext();

        public bool AddCustomer(Customer customer)
        {
            int isExecuted = 0;
            db.Customers.Add(customer);
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }

        public bool DeleteCustomer(Customer customer)
        {
            int isExecuted = 0;

            Customer aCustomer = db.Customers.FirstOrDefault(c => c.Code == customer.Code);
            db.Customers.Remove(aCustomer);
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }
            return false;

        }

        public bool UpdateCustomer(Customer customer)
        {
            int isExecuted = 0;

            Customer aCustomer = db.Customers.FirstOrDefault(c => c.Code == customer.Code);
            if (aCustomer != null)
            {
                aCustomer.Name = customer.Name;

            }
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }

        public Customer GetByCode(Customer customer)
        {
            Customer aCustomer = db.Customers.FirstOrDefault(c => c.Code == customer.Code);
            return aCustomer;

        }

        public List<Customer> GetAll()
        {
            return db.Customers.ToList();
        }
    }
}
