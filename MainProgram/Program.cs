using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.Prototype
{
	class Program
	{
		public static void Run()
		{

			Customer c1 = new Customer();
			String a, b, c, d;
			int e;

			Console.WriteLine("Please Enter the Customer's First Name:");
			a = Console.ReadLine();
			c1.FirstName = a;

			Console.WriteLine("Please Enter the Customer's Last Name:");
			b = Console.ReadLine();
			c1.LastName = b;

			Console.WriteLine("Please Enter the Customer Type - 1 = Standard, 2 = Business, 3 = Premium:");
			c = Console.ReadLine();
			//Need to convert input value to 'int'
			c1.CustomerType = c;

			Console.WriteLine("Please Enter the Customer's Email Address:");
			d = Console.ReadLine();
			c1.EmailAddress = d;

			//Calling the GenerateFullName method
			var Name = c1.GenerateFullName(a, b);
			Console.WriteLine("Thank you " + Name);

			Console.WriteLine("Adding " + Name + "to the Database.");

			//Calling the 'Customer' Class method Add
			c1.Add();
			Console.WriteLine(Name + " Added to database.");
			//Console will stay open unitl user presses a key
			Console.Read();
		}

		static void Main(string[] args)
		{
				Program.Run();

			Console.WriteLine("Press any key to stop...");
			Console.ReadKey();
			
		}
	}
}
