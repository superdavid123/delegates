using System;

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

