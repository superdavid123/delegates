using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

		Predicate<int> je = Je;

		List<int> cisla = numbers.FindAll(je);
		Console.WriteLine(string.Join(", ", cisla));
	}
	static bool Je(int cislicko)
	{
		return cislicko % 2 == 0;
	}
}
