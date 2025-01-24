
using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Výpočet výstupního výkonu zesilovače nebo filtru");
		Console.WriteLine("----------------------------");

		// zadání výstupního výkonu od uživatele
		Console.WriteLine("Zadejte vstupní výkon signálu Pin [mW]: ");

        double vstupniVykon = 0; //inicialnize promenne
		double.TryParse(Console.ReadLine(), out vstupniVykon); // [mW]


		// zadání zisku zesilovače nebo filtru od uživatele
		double ziskNeboUtlumdB = 0;
		Console.WriteLine("Zadejte zisk zesilovače nebo útlum filtru (G) [dB]: ");


		//osetreni vyjimky
		try
		{

			ziskNeboUtlumdB = double.Parse(Console.ReadLine()); // G [dB]

		}

		catch (OverflowException)
		{
			Console.WriteLine("Neplatný vstup (overflowexeption");

		}
		catch (Exception)
		{
			Console.WriteLine("Neplatný vstup.");

		}



		// Pout = 0,005*10 ^ (23 /10) = 1 W
		// zesílení nebo útlum (poměr)
		double pomer = Math.Pow(10, ziskNeboUtlumdB / 10);

		//výpočet výstupního výkonu
		double vystupniVykon = vstupniVykon * pomer;

		//výstupy pro uživatele
		Console.WriteLine("\nVýsledky:");

		Console.WriteLine($"Zisk nebo útlum: {ziskNeboUtlumdB:F2} [dB]");
		Console.WriteLine($"Výstupní výkon Pout:{vystupniVykon:F2} [mW]");

		Console.WriteLine("\nVýsledky:");
		Console.WriteLine($"Zisk nebo utlum pomer: {pomer:F2}");


		Console.WriteLine("\nStiskněte Enetr pro ukončení programu");


		Console.ReadLine();
	}
}