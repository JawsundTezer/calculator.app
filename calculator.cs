class calculator 
{
	static void Main(string[] args)
	{
		int a =10;
		int b= 6;
		
		Console.Writeline("Hasil penambahan : {0} + {1} = {2}" , a,b, penambahan (a, b));
		Console.Writeline("Hasil pengurangan : {0} - {1} = {2}" , a,b, pengurangan (a, b));
		
		Console.Write("\n Tekan sembarang untuk keluar");
		Console.ReadKey();
		
	}
	static int penambahan (int a, int b)
	{
		return a + b;
	}
	static int pengurangan(int a, int b)
	{
		return a - b;
		
	}
	
}