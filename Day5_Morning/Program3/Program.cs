using System;

namespace Program3
{
	class MainClass
	{
		public delegate void MyDelegate(string str1,string str2);

		public static void Main (string[] args)
		{

			MyDelegate myDelegate = delegate(string firstName, string lastName) {
			
				Console.WriteLine("Full name is:{0} {1}",firstName,lastName);
			};

			myDelegate ("Sijo", "Varghese");
		}
	}
}
