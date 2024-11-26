using System;

<<<<<<< HEAD
delegate int matematicoperace(int x, int y);

class program
{
	static void Main()
	{
		matematicoperace oskarsmrdi = Add;
		matematicoperace oskarnesmrdi = Substract;
		Console.WriteLine( oskarsmrdi(3, 4) );
		Console.WriteLine( oskarnesmrdi(3, 4) );

	}
	static int Add(int x, int y)
	{
		return x + y;
	}
	static int Substract(int x, int y)
	{
		return x - y;
	}
}
=======
class Program
{
	static void Main()
	{
		
		Action<string> napisto = Print;
		napisto("nabizim remizu"); 
	}

	static void Print(string message)
	{
		Console.WriteLine(message);
	}
}
>>>>>>> 87307bd8e8a91b530c893c5af7969f5a037935bb
