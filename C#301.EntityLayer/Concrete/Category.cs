using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_301.EntityLayer.Concrete
{
	public class Category
	{
        // Code-fİRST yaklaşımı kullanıcaz. 

        /* field: direkt tanımlanırsa bu fielddır. 
		 * variable:  metot içinde değişken tanımlanırsa variable olur. 
		 * property : get set ile değer alırsa property olur 
		  */


		public int CategoryId { get; set; }
        public string CategoryName { get; set; }

		public bool CategoryStatus { get; set; }

		public List<Product> Products { get; set; } // code-first bire çok ilşki formatı 


		// Single Responsibilty 

	}
}
