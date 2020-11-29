using System;

namespace Program
{
	class Program
	{
		static void Main()
		{
			Console.Title = "C to F"; // title
			Console.Write("Enter celsius: ");
			double C = double.Parse(Console.ReadLine());
			double F = (C * 9/5) + 32;
			Console.WriteLine("F = " + F);
			Console.ReadKey();
		}
	}
}
