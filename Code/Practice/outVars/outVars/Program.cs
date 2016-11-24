using System;

namespace outVars
{
	class MainClass
	{
		public static void Main (string [] args)
		{
			var myString = "7";
			if (int.TryParse (myString, out int i)) {
				Console.WriteLine (new string ('*', i));
			}
		}
	}
}
