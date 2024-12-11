using System;

namespace Factorial
{
	class MainClass
	{
		public static void Main ()
		{
			Console.WriteLine (Factorial(Convert.ToInt32(Console.ReadLine())));
			Console.ReadLine();
		}

		private static int Factorial(int n)
		{
			if (n == 0) return 1;
			return Factorial(n - 1) * n;
		}
	}
}
