using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonguUygulamları
{
	internal class Program
	{
		static int Faktoriyel(int n)
		{
			int sonuc = 1;
			for (int i = 1; i <= n; i++)
			{
				sonuc *= i;

			}
			return sonuc;
		}

		static	int BasamakToplami(int sayi)
		{
			int toplam = 0;
			while (sayi > 0)
			{
				toplam += sayi % 10;
				sayi /= 10;
			}
			return toplam;
		}

		static void Main(string[] args)
		{
			

			Console.WriteLine("Pozitif bir sayı girin : ");
			int n = Convert.ToInt32(Console.ReadLine());

			int faktoriyelSonuc = Faktoriyel(n);
            int basamakToplami = BasamakToplami(faktoriyelSonuc);

            Console.WriteLine("faktoriyel: "+faktoriyelSonuc);
            Console.WriteLine("Basamk Toplami: "+ basamakToplami);

			Console.Read();



		}

		static void TekCiftBasamakSay(int sayi)
		{
			int tekSayac = 0, ciftSayac = 0;

			while (sayi > 0)
			{
				int basamak = sayi % 10;
				if (basamak % 2 == 0)
					ciftSayac++;
				else
					tekSayac++;

				sayi /= 10;
			}

			Console.WriteLine("Çift basamak sayısı: " + ciftSayac);
			Console.WriteLine("Tek basamak sayısı: " + tekSayac);
		}




	}
}
