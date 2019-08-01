using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagementSystemApp.Models.Models;
using SmallBusinessManagementSystemApp.Repository.Repository;

namespace SmallBusinessManagementSystemApp.BLL.BLL
{
    public class ProductManager
    {
        ProductRepository _productRepository = new ProductRepository();

        public bool AddProduct(Product product)
        {
            return _productRepository.AddProduct(product);
        }

        public bool DeleteProduct(Product product)
        {
            return _productRepository.DeleteProduct(product);
        }

        public bool UpdateProduct(Product product)
        {
            return _productRepository.UpdateProduct(product);
        }

        public Product GetByCode(Product product)
        {
            return _productRepository.GetByCode(product);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }
    }
}
