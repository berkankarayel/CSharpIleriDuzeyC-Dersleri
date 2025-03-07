using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_301.EntityLayer.Concrete
{
	public class Product
	{
        public int ProductId { get; set; }
        public int ProductName { get; set; }

        public int ProductStock { get; set; }

        public int  ProductPrice { get; set; }

        public string ProductDescription { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public List<Order> Orders { get; set; }



    }
}
