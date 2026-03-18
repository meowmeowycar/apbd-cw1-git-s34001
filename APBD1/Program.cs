namespace APBD1
{
	public class Program 
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("mirësevini në aplikacionin e statistikave");
			int[] numbers = [6, 7, 6, 7, 6, 7];

			if (numbers.Length == 0 || numbers == null)
			{
				Console.WriteLine("Error: no entry data detected");
				return;
			}

			foreach (var number in numbers)
			{
				Console.WriteLine(number);
			}
		}
	}
}

