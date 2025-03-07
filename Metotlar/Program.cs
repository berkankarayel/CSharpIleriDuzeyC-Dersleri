using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region Metotlar 

			void CustomerList()
			{
                Console.WriteLine("Ali yıldız");
                Console.WriteLine("Ayşe yıldız");
                Console.WriteLine("Hakan  öztürk");
                Console.WriteLine("Berkan KIR");
			}

			CustomerList();

			void WriteMethod(string customerName)
			{
                Console.WriteLine(customerName);
			}
			WriteMethod("berkan");

			int Sum(int number1, int number2) 
			{
				int result = number1 + number2;
				return result;
			}
			Sum(55,45);

			Console.ReadKey();

			#endregion
		}
	}
}
