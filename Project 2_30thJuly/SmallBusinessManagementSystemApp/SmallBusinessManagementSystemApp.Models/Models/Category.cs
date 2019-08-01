using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmallBusinessManagementSystemApp.Models.Models
{
    public class Category
    {
        
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter Code")]
        [StringLength(10, MinimumLength = 3)]
        public string Code { get; set; }

        [Required(ErrorMessage = "Please enter Name")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [NotMapped]
        public List<Product> Products { get; set; }

        [NotMapped]
        public List<Category> Categories { get; set; }
        public Category()
        {
            Products = new List<Product>();
        }
    }
}
