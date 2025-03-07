using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_DatabaseProject
{
	internal class Program
	{
		static void Main(string[] args)
		{

            // Adonet : sql yapılarını kullanmamzı sağlayan çerçeve

            Console.WriteLine("******* c# Ürün kategori ürün sistemi ");
            Console.WriteLine();
            Console.WriteLine();

			string tableNumber;

            Console.WriteLine("1- Kategoriler");
            Console.WriteLine("2- Ürünler ");
            Console.WriteLine("3 - Siparişler ");
            Console.WriteLine("4-Çıkış Yap");

			Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz : ");
			tableNumber = Console.ReadLine();
            Console.WriteLine("--------------------");

			// sql bağlantımızı ado.net kullanrak yaparız.
			// sql bağlantısı için gereken kod :


			SqlConnection connection = new SqlConnection("Data Source=USER-PC\\SQLEXPRESS; initial Catalog =EgitimKampiDb;integrated security = true");
			connection.Open(); // bağlantımızı açtık 
			SqlCommand command = new SqlCommand("Select * from  TblCategory",connection);// tablo kodunu yazıp veritabanına bağladık. 
			SqlDataAdapter adapter = new SqlDataAdapter(command); // c# kodu ile sql arasında köprü sağlar. 
			DataTable dataTable = new DataTable(); // veriler geçiçi(ram) bellege almaya sağlar. 
			adapter.Fill(dataTable);
			connection.Close();// bağlantımızı kapattık. 

			foreach (DataRow row in dataTable.Rows) 
			{
                foreach(var item in row.ItemArray)
				{
                    Console.Write(item.ToString());
				}
                Console.WriteLine();
			}

			Console.Read();
		}
	}
}
