
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
