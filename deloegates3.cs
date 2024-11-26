using System;

class Program
{
	static void Main()
	{
		Func<int, int, int> nasobeni = Nasobeni;
		Console.WriteLine(nasobeni(5, 8));
	}
	static int Nasobeni(int x, int y)
	{
		return x * y;
	}
}
