using System;

namespace expressionbodiedfunctionmembers
{
	class MainClass
	{
		public static void Main (string [] args)
		{
			Console.WriteLine ("Hello World!");
			Runner runner = new Runner ();
			runner.interpolation ();
		}
	}

	public class Runner
	{

		public void interpolation ()
		{
			int result = 5 + 7;
			//Console.WriteLine ("result: {$0}", result);
			Console.WriteLine ($"result: {result}");
			Console.WriteLine ($"result: ${result}");
		}
	}
}