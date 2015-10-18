using System;

namespace Program2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Nullable<int> num;
			num = null;
			Console.WriteLine ("Printing null value: {0}",num.ToString());

			num = 10;
			Console.WriteLine ("Printing assigned value {0}", num);


		}
	}
}
