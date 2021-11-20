// C# program to demonstrate the function
// overloading by changing the
// Order of the parameters
using System;
class GFG
{

	// Method
	public void Identity(String name, int id)
	{

		Console.WriteLine("Name1 : " + name + ", "
						+ "Id1 : " + id);
	}

	// Method
	public void Identity(int id, String name)
	{

		Console.WriteLine("Name2 : " + name + ", "
						+ "Id2 : " + id);
	}

	// Main Method
	public static void Main(String[] args)
	{

		// Creating Object
		GFG obj = new GFG();

		obj.Identity("Akku", 1);
		obj.Identity(2, "Abby");
	}
}

