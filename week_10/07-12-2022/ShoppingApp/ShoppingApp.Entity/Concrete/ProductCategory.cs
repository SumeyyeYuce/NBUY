using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Entity.Concrete
{
    public class ProductCategory
    {
        public int ProductId { get; set; }//veritabında olucak var olan herhangi bir productId ile ilişkilendiirlecek
        public Product Product { get; set; }
        public int CategoryId { get; set; }//veritabanında olucak
        public Category Category { get; set; }

    }
}
