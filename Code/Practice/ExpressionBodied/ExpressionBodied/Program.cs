using System;

namespace ExpressionBodied
{
	class MainClass
	{
		public static void Main (string [] args)
		{
			Runner runner = new Runner ();
			runner.Run ();
		}
	}

	public class Runner
	{
		public void Run ()
		{
			int result1 = Func1 (5, 7);
			int result2 = Func2 (5, 7);
			Console.WriteLine ($"result1: {result1}");
			Console.WriteLine ($"result2: {result2}");

		}

		public int Func1 (int a, int b)
		{
			return a + b;
		}

		public int Func2 (int a, int b) => a + b;
	}
}
