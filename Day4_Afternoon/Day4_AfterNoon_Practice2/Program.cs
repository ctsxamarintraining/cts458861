using System;

namespace Day4_AfterNoon_Practice2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int num;
			Console.WriteLine ("Enter Any Integer :");
			try {
				num = Convert.ToInt32 (Console.ReadLine ());
				if (num < 0)
					Console.WriteLine ("Invalid");
				else
					Console.WriteLine("Square root of {0} is {1}",num,Math.Sqrt(num));
			}catch(FormatException) {
				Console.WriteLine ("Invalid");
			
			}catch(Exception) {
					Console.WriteLine ("Invalid");
			
			} finally {
				Console.WriteLine ("Goodbye");
		
			}

			Program2 p2 = new Program2 ();
			p2.ReadFile ();


		}
	}
}
