using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachDongusu
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] sehirler = { "ankara", "istanbul", "paris" };

			foreach (string s in sehirler)
			
			{
                Console.WriteLine(s);
			}

			int[] number = {1, 2, 3,3434,43435,566,7,56};
			int toplam = 0;
			foreach (int i in number)
			{
				toplam += i;
			}


			List<int> numbers = new List<int>()// Liste oluşturma
			{
				1,2,3, 4,
			};
            Console.WriteLine(numbers);// tam çıktı vermez

			foreach (int i in numbers) 
			{
                Console.WriteLine(i);
			}

			string word = "Merhaba";

			foreach (char c in word) 
			{
                Console.WriteLine(c);
			}


            Console.WriteLine("******************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sınıfınızda kaç öğrenci var : ");
			int studentCount = int.Parse(Console.ReadLine());

			// öğrenci notlarını ve ortalamalarını saklayacak diziler.
			string[] studentNames = new string[studentCount];
			double[] studentValues = new double[studentCount];

			for(int i = 0; i < studentCount; i++)
			{
				Console.Write($"{i + 1}. öğrencinin ismini giriniz");
				studentNames[i] = Console.ReadLine();

				double totalExam = 0;
				// her öğrenci için 3 sınav notu girişi

				for(int  j = 0; j < studentCount; j++)
				{
                    Console.WriteLine($"öğrencin notu{studentNames[i]} adlı öğrencin {j+1}. notunu giriniz");
					double value  = double.Parse(Console.ReadLine());
					totalExam += value;
				}

				studentValues[i] = totalExam / studentCount;
			}
		}
	}
}
