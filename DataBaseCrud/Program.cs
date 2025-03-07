﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseCrud
{
	internal class Program
	{
		static void Main(string[] args)
		{
            // Crud --> Create- Read-Update - Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli ******");
            Console.WriteLine();

            Console.WriteLine("--------------------------------");

            #region Kategori ekleme 

            //         Console.Write("Eklemek istediğiniz kategori adı : ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=USER-PC\\SQLEXPRESS;initial Catalog =EgitimKampiDb;integrated security = true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into Tblcategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery(); // koşulsuz birşekilde sorguyu çalıştır.
            //connection.Close();

            //         Console.WriteLine("Kategori başarıyla eklendi");

            #endregion

            #region Ürün EKleme işlemi 

            //string productName;
            //decimal productPrice;
            //// bool productStatus;

            //Console.WriteLine("Eklmeek istediğiniz ürün : ");
            //productName = Console.ReadLine();

            //Console.WriteLine("Eklediğiniz ürünün fiyatı :");
            //productPrice = decimal.Parse(Console.ReadLine());



            //Console.WriteLine("-----------------------------------");

            //// veritabanı bağlantısı sağlanır : 

            //SqlConnection connection = new SqlConnection("Data Source=USER-PC\\SQLEXPRESS;initial Catalog =EgitimKampiDb;integrated security = true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);

            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün Eklemesi Başarılı ");


            #endregion

            #region Ürün Listeleme İşlemi 

            //SqlConnection connection = new SqlConnection("Data Source=USER-PC\\SQLEXPRESS;initial Catalog =EgitimKampiDb;integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * from TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);// sql den verileri c# çekmeye yarar. 
            //DataTable dataTable = new DataTable(); // bellekte geçiçi yer tutması için yer sağlar. 
            //adapter.Fill(dataTable);


            //foreach (DataRow row in dataTable.Rows) 
            //{
            //	foreach (var item in row.ItemArray) 
            //	{
            //		Console.WriteLine(item.ToString() + " ");
            //	}
            //             Console.WriteLine();
            //}

            //connection.Close();


            #endregion


            #region ürün silme işlemi 

            //         Console.WriteLine("Silinecek id :");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=USER-PC\\SQLEXPRESS;initial Catalog =EgitimKampiDb;integrated security = true");
            //connection.Open();
            //         SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId", connection);
            //         command.Parameters.AddWithValue("@productId",productId);
            //         command.ExecuteNonQuery();

            //         connection.Close();

            //         Console.WriteLine("Silindi");

            #endregion

            #region Ürün Güncelleme
            Console.WriteLine("Güncellenecek ürün id : ");

            int productId =int.Parse(Console.ReadLine());
            Console.WriteLine("Ürün adi :");
            string productName =Console.ReadLine();
            Console.WriteLine("Güncellenecek ürün fiyat : ");
            decimal productPrice =decimal.Parse(Console.ReadLine());

			SqlConnection connection = new SqlConnection("Data Source=USER-PC\\SQLEXPRESS;initial Catalog =EgitimKampiDb;integrated security = true");
            connection.Open();

            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId",connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);

            command.ExecuteNonQuery();

           connection.Close();

            Console.WriteLine("Ürün güncellendi");

			#endregion



			Console.Read();


		}
	}
}
