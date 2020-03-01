using System;

namespace Pizza
{
    public class HelloWorld
    {	
		public static void Hello()
		{
			Console.WriteLine("Lønforhandling: The Game!");
			int betaling = 100;
			Console.ReadLine();
			bool forhandling = true;
			while (forhandling)
			{
				Console.Clear();
				Console.WriteLine("Hvad siger du til " + betaling + " i løn?");
				Console.WriteLine("(J)a eller (N)ej");
				string svar = Console.ReadLine();
				if (svar.ToLower().Equals("j"))
				{
					forhandling = false;
				}
				else if (svar.ToLower().Equals("n"))
				{
					Console.WriteLine("Du svarer selvsikkert \"Nej\", og de ser forbløffede på dig i to sekunder, men samler sig så igen.");
					Console.ReadLine();
					betaling += 100;
				}
				else
				{
					Console.WriteLine("De forstår tydeligtvis ikke hvad du prøver at sige til dem. De spørger dig forsigtigt igen...");
					Console.ReadLine();
					Console.Clear();
				}
			}
			Console.Clear();
			Console.WriteLine("Tillykke med veloverstået forhandling!");
			Console.WriteLine("Du vil få " + betaling + " i løn!");
			Console.ReadLine();
		}
	}
}