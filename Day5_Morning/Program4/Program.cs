using System;

namespace Program4
{
	class MainClass
	{
		public delegate void MyDelegate(String name,int ID,string city);
		public static void Main (string[] args)
		{
			MyDelegate del = delegate(String name,int ID,string city) {
				Console.WriteLine("Name: {0}\nID :{1}\nCity :{2}",name,ID,city);
			};

			del ("Sijo", 458861, "Bhopal");
		}
	}
}
