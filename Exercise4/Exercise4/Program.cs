using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise4
{
	class Program
	{
		static void Main(string[] args)
		{
			long unixTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

			//Open the file
			using (StreamWriter writer1 = new StreamWriter("UnixTime.txt"))
			{
				// Do writing here
				writer1.WriteLine(unixTime);


				//Close the file
				writer1.Close();
			}   // Disposal happens here

			//------------------------------------------------------------

			Console.WriteLine(unixTime);


			using (StreamReader reader = new StreamReader("UnixTime.txt"))
			{
				while (!reader.EndOfStream)
				{
					string lastLoggedTime = reader.ReadLine();
					

					

				}
				reader.Close();
			}   // Disposal happens here

			Console.ReadLine();
		}
	}
}
