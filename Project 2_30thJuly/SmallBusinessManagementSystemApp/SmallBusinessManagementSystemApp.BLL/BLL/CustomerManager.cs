using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagementSystemApp.Models.Models;
using SmallBusinessManagementSystemApp.Repository.Repository;

namespace SmallBusinessManagementSystemApp.BLL.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();

        public bool AddCustomer(Customer customer)
        {
            return _customerRepository.AddCustomer(customer);
        }

        public bool DeleteCustomer(Customer customer)
        {
            return _customerRepository.DeleteCustomer(customer);
        }

        public bool UpdateCustomer(Customer customer)
        {
            return _customerRepository.UpdateCustomer(customer);
        }

        public Customer GetByCode(Customer customer)
        {
            return _customerRepository.GetByCode(customer);
        }

        public List<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }
    }
}
