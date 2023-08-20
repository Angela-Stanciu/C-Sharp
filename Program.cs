using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello");
			Console.ReadLine();
			//variabile
			int numar = 10;
			double pret = 20.0D;
			char litera = 'A';
			string mesaj = "Aplicare Job";
			bool esteAprobat = true;
			long numarLung = 15000L;
			float numar2 = 1.75F;
			//constante - nu se vor modifica valorile lor
			const double pi = 3.14D;
			//casting
			//casting implicit: char -> int -> long -> float -> double
			//casting explicit: double -> float -> long -> int -> char
			//metode de conversie:
			Convert.ToBoolean(esteAprobat);
			Convert.ToDouble(numar2);
			Convert.ToString(esteAprobat);
			Convert.ToInt32(numar2);//int
			Convert.ToUInt64(numar2);//double

			//user input
			Console.WriteLine("Write your name: ");
			string nume = Console.ReadLine();
			Console.WriteLine("Your name is: " + nume);
			Console.ReadLine();

			//Math class methods:
			Math.Max(5, 10);
			Math.Min(5, 10);
			Math.Sqrt(64);
			Math.Abs(-4.7);
			Math.Round(9.99);

			//string methods:
			string text = "Hi";
			text.ToUpper();
			text.ToLower();
			Console.WriteLine(string.Concat(text,text));
			Console.ReadLine();

			//string interpolation
			Console.WriteLine($"My full name is: {text} {text}");
			Console.ReadLine();

			//other string methods:
			string mesaj2 = "Buna ziua sunt Angela";
			Console.WriteLine(mesaj2[3]);
			Console.WriteLine(mesaj2.IndexOf("a"));
			string mesaj3 = mesaj2.Substring(mesaj2.IndexOf("a"));//de obicei substring() este folosit cu indexOf()
			Console.WriteLine("This is \" a string\"\n");
			Console.ReadLine();

			//conditional statements: if, else, else if, switch
			//ternary operator-> ? :
			//exemplu: 
			int time = 20;
			string result = (time < 18) ? "Good day." : "Good evening.";
			Console.WriteLine(result);
			Console.ReadLine();

			switch (2+2)
			{
				case 3:
					// code block
					break;
				case 4:
					// code block
					Console.WriteLine(result);
					break;
				default:
					// code block
					break;
			}
			Console.ReadLine();


			//other statements: while(){}, do{}while();, for(){},- merge cu break si continue;

			//vectori -creare de vectori- diferite metode de a crea vectorul
			// Create an array of four elements, and add values later
			string[] cars = new string[4];

			// Create an array of four elements and add values right away 
			string[] cars2 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

			// Create an array of four elements without specifying the size 
			string[] cars3 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

			// Create an array of four elements, omitting the new keyword, and without specifying the size
			string[] cars4 = { "Volvo", "BMW", "Ford", "Mazda" };
			int[] cars5 =  { 1, 2, 3, 4, 5, 6 };

			Array.Sort(cars);
			foreach (string i in cars)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine(cars5.Max());  // returns the largest value
			Console.WriteLine(cars5.Min());  // returns the smallest value
			Console.WriteLine(cars5.Sum());  // returns the sum of elements
			Console.ReadLine();

			//multidimensional array
			int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };




		}
	}
}
