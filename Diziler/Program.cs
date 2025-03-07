using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] colors = new string[4]; // 4 elemanlı dizi
			colors[0] = "kırmızı";
			colors[1] = "mavi";
			colors[2] = "kahverengi";

			int[] numbers = new int[10];
			numbers[0] = 34;
			numbers[1] = 776;


			#region Dizideki Tüm elemanları listeleme 
			string[] renkler = { "sari", "kırmızı", "beyaz" };
			for(int i = 0; i < renkler.Length; i++)
			{
				Console.WriteLine(renkler[i]);
				Console.Read();
			}
			#endregion

			int[] number = { 4, 34, 34, 34, 56, 56, 6734, 56, 8, 34, 67, 456 };
			for (int i = 0;i < number.Length; i++)
			{
				if(number[i] % 3 == 0)
				{
					Console.WriteLine(numbers[i]);

				}
			}

			char[] sembol = { 'A', 'b', 'c' };
			for (int i = 0; i < sembol.Length; i++)
			{
				Console.WriteLine(sembol[i]);
			}

			int[] myArray = { 34, 56, 765, 87676, 4343, 6757656, 343434 };
			int maxNumber = myArray[0];
			for (int i = 1; i < myArray.Length; i++) 
			{
				if (myArray[i] > maxNumber)
				{
					maxNumber = myArray[i];
				}
				

			}

            Console.WriteLine(myArray.Length);
            Array.Sort(myArray);// küçükten büyüğe sıralar 
			Array.Reverse(myArray);// ters çevirir.
			Array.IndexOf(myArray, 34);// dizinin kaçıncı elmanında oludğunu söyler.
			myArray.Max();
			myArray.Min();

			string[] sehir = new string[5];

			for (int i = 0; i < sehir.Length; i++)
			
			{
                Console.WriteLine($"Lütfen {i+1} şehr giriniz");
				sehir[i] = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("*****************");

				
			
			}
			for (int i = 0;i < sehir.Length; i++)
			{
				Console.WriteLine(sehir[i]);
			}

		}
	}
}
