using System;

namespace Day6
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			MyEnumerable personList = new MyEnumerable();

			foreach (Person p in personList)
				Console.WriteLine ("Id        : {0} \nName      : {1} \nLocation  : {2}\n", p.Id, p.Name, p.Location);
            Console.Read();

		}
	}



}
