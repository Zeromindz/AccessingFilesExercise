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
			//Open the file
			using (StreamWriter writer = new StreamWriter("Test.txt"))
			{
				// Do writing here
				writer.WriteLine("Hello World!");
				//Close the file
				writer.Close();
			}   // Disposal happens here

			Console.ReadLine();
		}
	}
}
