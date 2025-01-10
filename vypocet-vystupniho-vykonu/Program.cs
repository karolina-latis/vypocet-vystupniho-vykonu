
using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Výpočet výstupního výkonu zesilovače nebo filtru");
		Console.WriteLine("----------------------------");

		// zadání výstupního výkonu od uživatele
		Console.WriteLine("Zadejte vstupní výkon signálu Pin [mW]: ");
		double vstupniVykon = double.Parse(Console.ReadLine());  // P [mW]

		// zadání zisku zesilovače nebo filtru od uživatele
		Console.WriteLine("Zadejte zisk zesilovače nebo útlum filtru (G) [dB]: ");
		double ziskNeboUtlum = double.Parse(Console.ReadLine()); // G [dB]

		// Pout = 0,005*10 ^ (23 /10) = 1 W
		// zesílení nebo útlum (poměr)
		double pomer = Math.Pow(10, ziskNeboUtlum / 10);

		//výpočet výstupního výkonu
		double vystupniVykon = vstupniVykon * pomer;

		//výstupy pro uživatele
		Console.WriteLine("\nVýsledky:");

		Console.WriteLine($"Zisk nebo útlum (poměr): {pomer:F4}");
		Console.WriteLine($"Výstupní výkon Pout):{vystupniVykon:F4} [mW]");


		Console.WriteLine("\nStiskněte Enetr pro ukončení programu");


		Console.ReadLine();
	}
}